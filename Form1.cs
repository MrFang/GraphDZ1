using System;
using System.Windows.Forms;

namespace GraphDZ1
{
    public partial class Form1 : Form {
        private Form resultForm;
        public Form1() {
            InitializeComponent();
        }

        private void submit(object sender, EventArgs e) {
            if (this.name.Text != "") {
                resultForm = new ResultForm(
                    name.Text,
                    birthdayYear.Value,
                    true,
                    mariage.Checked,
                    this.city.Text
                );
                resultForm.Show();
            }
            else {
                MessageBox.Show("Incorrect name");
            }
        }
    }
}
