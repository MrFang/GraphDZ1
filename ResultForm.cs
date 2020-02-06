using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphDZ1
{
    public partial class ResultForm : Form {
        public ResultForm() {
            InitializeComponent();
        }

        public ResultForm(string name, decimal birthdayYear, bool isMale, bool mariage, string city) {
            InitializeComponent();
            SuspendLayout();

            this.name.Text = name;
            this.birthdayYear.Text = birthdayYear.ToString();
            this.sex.Text = isMale ? "Мужской" : "Женский";
            this.mariage.Text = mariage ? "Да" : "Нет";
            this.city.Text = city;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
