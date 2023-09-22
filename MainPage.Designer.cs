namespace PresidentHWGUI
{
    partial class MainPage
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
            haveRebelled = new CheckBox();
            haveBeenImpeached = new CheckBox();
            naturalBornCitizen = new CheckBox();
            birthYear = new TextBox();
            yearsInUS = new TextBox();
            priorTerms = new TextBox();
            submitButton = new Button();
            rebelledText = new Label();
            impeachedText = new Label();
            label3 = new Label();
            ageText = new Label();
            label5 = new Label();
            priorTermsText = new Label();
            SuspendLayout();
            // 
            // haveRebelled
            // 
            haveRebelled.AutoSize = true;
            haveRebelled.Location = new Point(424, 59);
            haveRebelled.Name = "haveRebelled";
            haveRebelled.Size = new Size(94, 24);
            haveRebelled.TabIndex = 0;
            haveRebelled.Text = "Yes or No";
            haveRebelled.UseVisualStyleBackColor = true;
            haveRebelled.CheckedChanged += haveRebelled_CheckedChanged;
            // 
            // haveBeenImpeached
            // 
            haveBeenImpeached.AutoSize = true;
            haveBeenImpeached.Location = new Point(424, 106);
            haveBeenImpeached.Name = "haveBeenImpeached";
            haveBeenImpeached.Size = new Size(94, 24);
            haveBeenImpeached.TabIndex = 1;
            haveBeenImpeached.Text = "Yes or No";
            haveBeenImpeached.UseVisualStyleBackColor = true;
            haveBeenImpeached.CheckedChanged += haveBeenImpeached_CheckedChanged;
            // 
            // naturalBornCitizen
            // 
            naturalBornCitizen.AutoSize = true;
            naturalBornCitizen.Location = new Point(424, 151);
            naturalBornCitizen.Name = "naturalBornCitizen";
            naturalBornCitizen.Size = new Size(94, 24);
            naturalBornCitizen.TabIndex = 2;
            naturalBornCitizen.Text = "Yes or No";
            naturalBornCitizen.UseVisualStyleBackColor = true;
            naturalBornCitizen.CheckedChanged += naturalBornCitizen_CheckedChanged;
            // 
            // birthYear
            // 
            birthYear.Location = new Point(424, 195);
            birthYear.Name = "birthYear";
            birthYear.Size = new Size(125, 27);
            birthYear.TabIndex = 3;
            birthYear.TextChanged += birthYear_TextChanged;
            // 
            // yearsInUS
            // 
            yearsInUS.Location = new Point(424, 247);
            yearsInUS.Name = "yearsInUS";
            yearsInUS.Size = new Size(125, 27);
            yearsInUS.TabIndex = 4;
            yearsInUS.TextChanged += yearsInUS_TextChanged;
            // 
            // priorTerms
            // 
            priorTerms.Location = new Point(424, 302);
            priorTerms.Name = "priorTerms";
            priorTerms.Size = new Size(125, 27);
            priorTerms.TabIndex = 5;
            priorTerms.TextChanged += priorTerms_TextChanged;
            // 
            // submitButton
            // 
            submitButton.BackColor = SystemColors.GradientActiveCaption;
            submitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.ForeColor = Color.DarkBlue;
            submitButton.Location = new Point(221, 360);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(143, 64);
            submitButton.TabIndex = 6;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // rebelledText
            // 
            rebelledText.AutoSize = true;
            rebelledText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rebelledText.Location = new Point(72, 59);
            rebelledText.Name = "rebelledText";
            rebelledText.Size = new Size(246, 20);
            rebelledText.TabIndex = 7;
            rebelledText.Text = "Have you rebelled against the US?";
            // 
            // impeachedText
            // 
            impeachedText.AutoSize = true;
            impeachedText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            impeachedText.Location = new Point(72, 106);
            impeachedText.Name = "impeachedText";
            impeachedText.Size = new Size(199, 20);
            impeachedText.TabIndex = 8;
            impeachedText.Text = "Have you been impeached?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 151);
            label3.Name = "label3";
            label3.Size = new Size(223, 20);
            label3.TabIndex = 9;
            label3.Text = "Are you a natural born citizen?";
            // 
            // ageText
            // 
            ageText.AutoSize = true;
            ageText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ageText.Location = new Point(72, 195);
            ageText.Name = "ageText";
            ageText.Size = new Size(130, 20);
            ageText.TabIndex = 10;
            ageText.Text = "How old are you?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(72, 247);
            label5.Name = "label5";
            label5.Size = new Size(283, 20);
            label5.TabIndex = 11;
            label5.Text = "How many years did you live in the US?";
            label5.Click += label5_Click;
            // 
            // priorTermsText
            // 
            priorTermsText.AutoSize = true;
            priorTermsText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            priorTermsText.Location = new Point(72, 302);
            priorTermsText.Name = "priorTermsText";
            priorTermsText.Size = new Size(292, 20);
            priorTermsText.TabIndex = 12;
            priorTermsText.Text = "How many prior terms have you served?";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 450);
            Controls.Add(priorTermsText);
            Controls.Add(label5);
            Controls.Add(ageText);
            Controls.Add(label3);
            Controls.Add(impeachedText);
            Controls.Add(rebelledText);
            Controls.Add(submitButton);
            Controls.Add(priorTerms);
            Controls.Add(yearsInUS);
            Controls.Add(birthYear);
            Controls.Add(naturalBornCitizen);
            Controls.Add(haveBeenImpeached);
            Controls.Add(haveRebelled);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox haveRebelled;
        private CheckBox haveBeenImpeached;
        private CheckBox naturalBornCitizen;
        private TextBox birthYear;
        private TextBox yearsInUS;
        private TextBox priorTerms;
        private Button submitButton;
        private Label rebelledText;
        private Label impeachedText;
        private Label label3;
        private Label ageText;
        private Label label5;
        private Label priorTermsText;
    }
}