namespace PresidentHWGUI
{
    partial class NullBoxes
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 72);
            label1.Name = "label1";
            label1.Size = new Size(319, 31);
            label1.TabIndex = 0;
            label1.Text = "Please fill in all of the fields!";
            label1.Click += label1_Click;
            // 
            // NullBoxes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 175);
            Controls.Add(label1);
            Name = "NullBoxes";
            Text = "NullBoxes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}