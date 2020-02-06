namespace GraphDZ1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthdayYear = new System.Windows.Forms.NumericUpDown();
            this.birthdayYearLabel = new System.Windows.Forms.Label();
            this.sexMale = new System.Windows.Forms.RadioButton();
            this.sexFemale = new System.Windows.Forms.RadioButton();
            this.sexRadioButtons = new System.Windows.Forms.GroupBox();
            this.mariage = new System.Windows.Forms.CheckBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();

            this.cities = new string[] {
                "Берлин",
                "Рио",
                "Токио",
                "Москва",
                "Денвер",
                "Осло",
                "Хельсинки",
                "Найроби",
            };
            this.currentYear = System.DateTime.Now.Year;
            ((System.ComponentModel.ISupportInitialize)(this.birthdayYear)).BeginInit();
            this.sexRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(121, 251);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(72, 40);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Готово";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submit);
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(101, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 22);
            this.name.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(53, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "ФИО";
            // 
            // birthdayYear
            // 
            this.birthdayYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayYear.Location = new System.Drawing.Point(160, 40);
            this.birthdayYear.Maximum = new decimal(new int[] {
            this.currentYear,
            0,
            0,
            0});
            this.birthdayYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.birthdayYear.Name = "birthdayYear";
            this.birthdayYear.Size = new System.Drawing.Size(130, 22);
            this.birthdayYear.TabIndex = 3;
            this.birthdayYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // birthdayYearLabel
            // 
            this.birthdayYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayYearLabel.AutoSize = true;
            this.birthdayYearLabel.Location = new System.Drawing.Point(53, 42);
            this.birthdayYearLabel.Name = "birthdayYearLabel";
            this.birthdayYearLabel.Size = new System.Drawing.Size(101, 17);
            this.birthdayYearLabel.TabIndex = 4;
            this.birthdayYearLabel.Text = "Год рождения";
            // 
            // sexMale
            // 
            this.sexMale.AutoSize = true;
            this.sexMale.Checked = true;
            this.sexMale.Location = new System.Drawing.Point(6, 37);
            this.sexMale.Name = "sexMale";
            this.sexMale.Size = new System.Drawing.Size(86, 21);
            this.sexMale.TabIndex = 5;
            this.sexMale.TabStop = true;
            this.sexMale.Text = "Мужской";
            this.sexMale.UseVisualStyleBackColor = true;
            // 
            // sexFemale
            // 
            this.sexFemale.AutoSize = true;
            this.sexFemale.Location = new System.Drawing.Point(140, 37);
            this.sexFemale.Name = "sexFemale";
            this.sexFemale.Size = new System.Drawing.Size(88, 21);
            this.sexFemale.TabIndex = 6;
            this.sexFemale.TabStop = true;
            this.sexFemale.Text = "Женский";
            this.sexFemale.UseVisualStyleBackColor = true;
            // 
            // sexRadioButtons
            // 
            this.sexRadioButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sexRadioButtons.Controls.Add(this.sexMale);
            this.sexRadioButtons.Controls.Add(this.sexFemale);
            this.sexRadioButtons.Location = new System.Drawing.Point(56, 68);
            this.sexRadioButtons.Name = "sexRadioButtons";
            this.sexRadioButtons.Size = new System.Drawing.Size(234, 101);
            this.sexRadioButtons.TabIndex = 7;
            this.sexRadioButtons.TabStop = false;
            this.sexRadioButtons.Text = "Пол";
            // 
            // mariage
            // 
            this.mariage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mariage.AutoSize = true;
            this.mariage.Location = new System.Drawing.Point(56, 175);
            this.mariage.Name = "mariage";
            this.mariage.Size = new System.Drawing.Size(137, 21);
            this.mariage.TabIndex = 8;
            this.mariage.Text = "Женат/Замужем";
            this.mariage.UseVisualStyleBackColor = true;
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(53, 205);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(48, 17);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "Город";
            // 
            // city
            // 
            this.city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.city.FormattingEnabled = true;
            this.city.Items.AddRange(this.cities);
            this.city.Location = new System.Drawing.Point(107, 202);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(183, 24);
            this.city.TabIndex = 10;
            this.city.Text = "Берлин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.city);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.mariage);
            this.Controls.Add(this.sexRadioButtons);
            this.Controls.Add(this.birthdayYearLabel);
            this.Controls.Add(this.birthdayYear);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form1";
            this.Text = "Анкета";
            ((System.ComponentModel.ISupportInitialize)(this.birthdayYear)).EndInit();
            this.sexRadioButtons.ResumeLayout(false);
            this.sexRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.NumericUpDown birthdayYear;
        private System.Windows.Forms.Label birthdayYearLabel;
        private System.Windows.Forms.RadioButton sexMale;
        private System.Windows.Forms.RadioButton sexFemale;
        private System.Windows.Forms.GroupBox sexRadioButtons;
        private System.Windows.Forms.CheckBox mariage;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ComboBox city;

        private string[] cities;
        private int currentYear;
    }
}

