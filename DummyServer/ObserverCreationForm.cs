using System;
using System.Windows.Forms;

namespace DummyServer
{
    public partial class ObserverCreationForm : Form
    {
        public ObserverCreationForm()
        {
            InitializeComponent();
        }

        public string ObserverTitle
        {
            get { return titleTextBox.Text; }
            set { titleTextBox.Text = value; }
        }

        private void creaetionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public string ObserverType => bigScreenRadioButton.Checked ? "B" : "C";

        private void graphicalTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ObserverCreationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
