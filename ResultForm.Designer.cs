namespace GraphDZ1
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.bithdayYearLabel = new System.Windows.Forms.Label();
            this.birthdayYear = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.mariageLabel = new System.Windows.Forms.Label();
            this.mariage = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "ФИО:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(124, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 17);
            this.name.TabIndex = 1;
            // 
            // bithdayYearLabel
            // 
            this.bithdayYearLabel.AutoSize = true;
            this.bithdayYearLabel.Location = new System.Drawing.Point(13, 34);
            this.bithdayYearLabel.Name = "bithdayYearLabel";
            this.bithdayYearLabel.Size = new System.Drawing.Size(105, 17);
            this.bithdayYearLabel.TabIndex = 2;
            this.bithdayYearLabel.Text = "Год рождения:";
            // 
            // birthdayYear
            // 
            this.birthdayYear.AutoSize = true;
            this.birthdayYear.Location = new System.Drawing.Point(124, 34);
            this.birthdayYear.Name = "birthdayYear";
            this.birthdayYear.Size = new System.Drawing.Size(46, 17);
            this.birthdayYear.TabIndex = 3;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(13, 55);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(34, 17);
            this.sexLabel.TabIndex = 4;
            this.sexLabel.Text = "Пол";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(124, 55);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(46, 17);
            this.sex.TabIndex = 5;
            // 
            // mariageLabel
            // 
            this.mariageLabel.AutoSize = true;
            this.mariageLabel.Location = new System.Drawing.Point(13, 76);
            this.mariageLabel.Name = "mariageLabel";
            this.mariageLabel.Size = new System.Drawing.Size(111, 17);
            this.mariageLabel.TabIndex = 6;
            this.mariageLabel.Text = "Жент/Замужем:";
            // 
            // mariage
            // 
            this.mariage.AutoSize = true;
            this.mariage.Location = new System.Drawing.Point(124, 76);
            this.mariage.Name = "mariage";
            this.mariage.Size = new System.Drawing.Size(46, 17);
            this.mariage.TabIndex = 7;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 97);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(52, 17);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "Город:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(124, 97);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(54, 17);
            this.city.TabIndex = 9;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 142);
            this.Controls.Add(this.city);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.mariage);
            this.Controls.Add(this.mariageLabel);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.birthdayYear);
            this.Controls.Add(this.bithdayYearLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Name = "ResultForm";
            this.Text = "Результат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label bithdayYearLabel;
        private System.Windows.Forms.Label birthdayYear;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label mariageLabel;
        private System.Windows.Forms.Label mariage;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label city;
    }
}