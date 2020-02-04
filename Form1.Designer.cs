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
            this.button1 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nametextBoxLabel = new System.Windows.Forms.Label();
            this.birthdayYear = new System.Windows.Forms.NumericUpDown();
            this.birthdayYearLabel = new System.Windows.Forms.Label();
            this.sexMale = new System.Windows.Forms.RadioButton();
            this.sexFemale = new System.Windows.Forms.RadioButton();
            this.sexRadioButtons = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayYear)).BeginInit();
            this.sexRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(143, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(130, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // nametextBoxLabel
            // 
            this.nametextBoxLabel.AutoSize = true;
            this.nametextBoxLabel.Location = new System.Drawing.Point(78, 45);
            this.nametextBoxLabel.Name = "nametextBoxLabel";
            this.nametextBoxLabel.Size = new System.Drawing.Size(42, 17);
            this.nametextBoxLabel.TabIndex = 2;
            this.nametextBoxLabel.Text = "ФИО";
            // 
            // birthdayYear
            // 
            this.birthdayYear.Location = new System.Drawing.Point(185, 70);
            this.birthdayYear.Maximum = System.DateTime.Now.Year;
            this.birthdayYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.birthdayYear.Name = "birthdayYear";
            this.birthdayYear.Size = new System.Drawing.Size(146, 22);
            this.birthdayYear.TabIndex = 3;
            this.birthdayYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // birthdayYearLabel
            // 
            this.birthdayYearLabel.AutoSize = true;
            this.birthdayYearLabel.Location = new System.Drawing.Point(78, 72);
            this.birthdayYearLabel.Name = "birthdayYearLabel";
            this.birthdayYearLabel.Size = new System.Drawing.Size(101, 17);
            this.birthdayYearLabel.TabIndex = 4;
            this.birthdayYearLabel.Text = "Год рождения";
            // 
            // sexMale
            // 
            this.sexMale.AutoEllipsis = true;
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
            this.sexFemale.Location = new System.Drawing.Point(156, 37);
            this.sexFemale.Name = "sexFemale";
            this.sexFemale.Size = new System.Drawing.Size(88, 21);
            this.sexFemale.TabIndex = 6;
            this.sexFemale.TabStop = true;
            this.sexFemale.Text = "Женский";
            this.sexFemale.UseVisualStyleBackColor = true;
            // 
            // sexRadioButtons
            // 
            this.sexRadioButtons.Controls.Add(this.sexMale);
            this.sexRadioButtons.Controls.Add(this.sexFemale);
            this.sexRadioButtons.Location = new System.Drawing.Point(81, 113);
            this.sexRadioButtons.Name = "sexRadioButtons";
            this.sexRadioButtons.Size = new System.Drawing.Size(250, 101);
            this.sexRadioButtons.TabIndex = 7;
            this.sexRadioButtons.TabStop = false;
            this.sexRadioButtons.Text = "Пол";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 537);
            this.Controls.Add(this.sexRadioButtons);
            this.Controls.Add(this.birthdayYearLabel);
            this.Controls.Add(this.birthdayYear);
            this.Controls.Add(this.nametextBoxLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(440, 584);
            this.MinimumSize = new System.Drawing.Size(440, 584);
            this.Name = "Form1";
            this.Text = "Анкета";
            ((System.ComponentModel.ISupportInitialize)(this.birthdayYear)).EndInit();
            this.sexRadioButtons.ResumeLayout(false);
            this.sexRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nametextBoxLabel;
        private System.Windows.Forms.NumericUpDown birthdayYear;
        private System.Windows.Forms.Label birthdayYearLabel;
        private System.Windows.Forms.RadioButton sexMale;
        private System.Windows.Forms.RadioButton sexFemale;
        private System.Windows.Forms.GroupBox sexRadioButtons;
    }
}

