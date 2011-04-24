using System;
using System.Windows.Forms;
using Passport.Properties;

namespace Passport
{
    public partial class ItemForm : Form
    {
        public string param = string.Empty;
        public string value = string.Empty;

        public ItemForm(bool isEdit)
        {
            InitializeComponent();
            label2.Text = isEdit ? Resources.EditItem : Resources.AddItem;
            label3.Text = isEdit ? Resources.EditItemMsg : Resources.AddItemMsg;
        }

        private void GenerateButtonClick(object sender, EventArgs e)
        {
            ValueBox.Text = PassportLib.Passport.RandomValue((int)numericUpDown1.Value);
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            param = ParamList.Text;
            value = ValueBox.Text;
            Close();
        }

        private void ItemFormLoad(object sender, EventArgs e)
        {
            ParamList.Text = param;
            ValueBox.Text = value;
        }
    }
}
