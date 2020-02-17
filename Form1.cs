using System;
using System.Windows.Forms;

namespace GraphDZ1
{
    public partial class Form1 : Form {
        private Form resultForm;
        private string[] cities;
        private int currentYear;

        public Form1() {
            InitializeComponent();

            cities = new string[] {
                "Берлин",
                "Рио",
                "Токио",
                "Москва",
                "Денвер",
                "Осло",
                "Хельсинки",
                "Найроби",
            };
            currentYear = System.DateTime.Now.Year;

            SuspendLayout();
            birthdayYear.Minimum = 1900;
            birthdayYear.Maximum = currentYear;
            birthdayYear.Value = 2000;

            city.Items.AddRange(cities);
            city.Text = cities[0];
            ResumeLayout(false);
            PerformLayout();
        }

        private void submit(object sender, EventArgs e) {
            if (name.Text != "") {
                resultForm = new ResultForm(
                    name.Text,
                    birthdayYear.Value,
                    sexMale.Checked,
                    mariage.Checked,
                    city.Text
                );
                resultForm.Show();
            }
            else {
                MessageBox.Show("Incorrect name");
            }
        }
    }
}
