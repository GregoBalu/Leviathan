using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leviathan.Editors.Utils
{
    public partial class InputForm : Form
    {

        public event EventHandler<StringEventArgs> Ok;
        private void OnOk()
        {
            if (TextBox.Text == "")
                MessageBox.Show("You must enter something!", "Bad input!");
            else
                if(Ok != null)
                {
                    Ok(this, new StringEventArgs(TextBox.Text));
                    this.Close();
                }
        }

        public event EventHandler Cancel;
        private void OnCancel()
        {
            if(Cancel != null)
            {
                Cancel(this, EventArgs.Empty);
                this.Close();
            }
        }

        public InputForm(String title, String label)
        {
            InitializeComponent();

            //this.FormClosing += new FormClosingEventHandler((sender, e) => OnCancel());

            this.Text = title;
            Label.Text = label;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            OnOk();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            OnCancel();
        }
    }
}
