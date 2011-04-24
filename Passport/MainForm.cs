using System;
using System.Windows.Forms;
using Passport.Properties;
using PassportLib;

namespace Passport
{
    public partial class MainForm : Form
    {
        public readonly int groupImg = 1;
        public readonly int cardImg = 2;

        public const int ADD_GROUP = 0;
        public const int ADD_PCARD = 1;
        public const int EDIT_GROUP = 2;
        public const int EDIT_PCARD = 3;

        private static int clearTime = 10;
        private static string password = "123";
        private const string passFile = "data.pswrd";

        // добавление/редактирование групп/карт
        private void EditStore(int formType)
        {
            ParamForm paramForm = new ParamForm(formType);
            if (formType > 1) { paramForm.msg = passTree.SelectedNode.Text; }
            paramForm.ShowDialog();
            string msg = paramForm.msg;
            if (msg == "") { return; }
            switch (formType)
            {
                case 0: TreeNode newNode0 = new TreeNode(msg, 1, 1);
                    passTree.SelectedNode.Nodes.Add(newNode0);
                    break;
                case 1: TreeNode newNode1 = new TreeNode(msg, 2, 2);
                    passTree.SelectedNode.Nodes.Add(newNode1);
                    break;
                case 2:
                case 3: passTree.SelectedNode.Text = msg;
                    break;
            }
        }

        // добавление/редактирование элемента
        private void EditItem(bool isEdit)
        {
            ItemForm itemForm = new ItemForm(isEdit);
            if (isEdit) { itemForm.param = passTree.SelectedNode.Text; itemForm.value = passTree.SelectedNode.ToolTipText; }
            itemForm.ShowDialog();
            if (itemForm.param == "" || itemForm.value == "") { return; }
            int imgInd = PassportLib.Passport.GetImageIndex(itemForm.param) + 3;
            if (isEdit)
            {
                passTree.SelectedNode.Text = itemForm.param;
                passTree.SelectedNode.ToolTipText = itemForm.value;
                passTree.SelectedNode.ImageIndex = imgInd;
                passTree.SelectedNode.SelectedImageIndex = imgInd;
            }
            else
            {
                TreeNode newNode = new TreeNode(itemForm.param, imgInd, imgInd) {ToolTipText = itemForm.value};
                passTree.SelectedNode.Nodes.Add(newNode);
            }
        }

        // очистка буфера
        private void ClearBuff()
        {
            Clipboard.Clear();
            MainTimer.Enabled = false;
            statusStrip.Items[1].Text = string.Empty;
        }

        // помещает значение в буфер обмена
        private void PutValueToClipboard()
        {
            if (passTree.SelectedNode.Level != 3) { return; }
            Clipboard.Clear();
            Clipboard.SetText(passTree.SelectedNode.ToolTipText);
            clearTime = 10;
            MainTimer.Enabled = true;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            PassportLib.Passport passport = new PassportLib.Passport();
            if (!passport.Load(passFile, "123"))
            {
                MessageBox.Show(Resources.PassFileOpenError, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            foreach (PassportGroup group in passport.Groups)
            {
                TreeNode gNode = new TreeNode(group.Name, groupImg, groupImg);
                passTree.TopNode.Nodes.Add(gNode);
                foreach (PassportCard card in group.Cards)
                {
                    TreeNode cNode = new TreeNode(card.Name, cardImg, cardImg);
                    gNode.Nodes.Add(cNode);
                    foreach (PassportItem item in card.Items)
                    {
                        int itemImg = PassportLib.Passport.GetImageIndex(item.Param) + 3;
                        TreeNode iNode = new TreeNode(item.Param, itemImg, itemImg) {ToolTipText = item.Value};
                        cNode.Nodes.Add(iNode);
                    }
                }
            }
            passTree.TopNode.Expand();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            PassportLib.Passport passport = new PassportLib.Passport();
            TreeNode groupNode = passTree.TopNode;
            for (int i = 0; i < groupNode.Nodes.Count; i++)
            {
                PassportGroup group = new PassportGroup(groupNode.Nodes[i].Text);
                TreeNode cardNode = groupNode.Nodes[i];
                for (int j = 0; j < cardNode.Nodes.Count; j++)
                {
                    PassportCard card = new PassportCard(cardNode.Nodes[j].Text);
                    TreeNode itemNode = cardNode.Nodes[j];
                    for (int k = 0; k < itemNode.Nodes.Count; k++)
                    {
                        PassportItem item = new PassportItem(itemNode.Nodes[k].Text, itemNode.Nodes[k].ToolTipText);
                        card.Items.Add(item);
                    }
                    group.Cards.Add(card);
                }
                passport.Groups.Add(group);
            }
            if (!passport.Save(passFile, "123")) 
                MessageBox.Show(Resources.SaveFailed, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PassTreeAfterSelect(object sender, TreeViewEventArgs e)
        {
            statusStrip.Items[0].Text = passTree.SelectedNode.FullPath;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            switch (passTree.SelectedNode.Level)
            {
                case 0: EditStore(ADD_GROUP); break;
                case 1: EditStore(ADD_PCARD); break;
                case 2: EditItem(false); break;
                default: break;
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (passTree.SelectedNode.Level == 0)
            {
                MessageBox.Show(Resources.RootNodeDelete,
                                Resources.Error,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (passTree.SelectedNode.Nodes.Count > 0)
            {
                if (MessageBox.Show(Resources.DeleteItemWithChild,
                                    Resources.Warning,
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) != DialogResult.Yes) { return; }
            }
            passTree.SelectedNode.Remove();
        }

        private void MainTimerTick(object sender, EventArgs e)
        {
            statusStrip.Items[1].Text = String.Format(Resources.BufferCleanup, Convert.ToString(clearTime));
            clearTime -= 1;
            if (clearTime == 0) { ClearBuff(); }
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            switch (passTree.SelectedNode.Level)
            {
                case 1: EditStore(EDIT_GROUP); break;
                case 2: EditStore(EDIT_PCARD); break;
                case 3: EditItem(true); break;
                default: break;
            }
        }

        private void ShowValueButtonClick(object sender, EventArgs e)
        {
            if (passTree.SelectedNode.Level != 3) { return; }
            string message = String.Format("{0} : {1}", passTree.SelectedNode.Text, passTree.SelectedNode.ToolTipText);
            MessageBox.Show(message, Resources.Passport, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PutValueButtonClick(object sender, EventArgs e)
        {
            PutValueToClipboard();
        }

        private static void SettingsButtonClick(object sender, EventArgs e)
        {
            SettingsForm setForm = new SettingsForm(password);
            setForm.ShowDialog();
            password = setForm.passKey;
        }

        private static void ExitToolItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }   
    }
}
