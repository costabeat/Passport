using System;
using System.Windows.Forms;
using Passport.Properties;

namespace Passport
{
    public partial class ParamForm : Form
    {
        public string msg = string.Empty;

        public ParamForm(int formType)
        {
            InitializeComponent();

            switch (formType)
            {
                //Add Group
                case 0:
                    label2.Text = Resources.AddGroup;
                    label3.Text = Resources.AddGroupMsg;
                    label1.Text = Resources.EnterGroupNameMsg;
                    break;
                //Add Passcard
                case 1:
                    label2.Text = Resources.AddPasscard;
                    label3.Text = Resources.AddPasscardMsg;
                    label1.Text = Resources.EnterCardNameMsg;
                    break;
                //Edit Group
                case 2:
                    label2.Text = Resources.EditGroup;
                    label3.Text = Resources.EditGroupMsg;
                    label1.Text = Resources.EnterGroupNameMsg;
                    break;
                //Edit Passcard
                case 3:
                    label2.Text = Resources.EditPasscard;
                    label3.Text = Resources.EditPasscardMsg;
                    label1.Text = Resources.EnterCardNameMsg;
                    break;
            }
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            msg = ValueBox.Text;
            Close();
        }

        private void ParamFormLoad(object sender, EventArgs e)
        {
            ValueBox.Text = msg;
            ValueBox.Focus();
        }
    }
}
