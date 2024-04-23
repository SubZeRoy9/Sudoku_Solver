namespace HaeringProject
{
    partial class LaunchForm
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.openSaveForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sudoku Solver";
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(218, 164);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(75, 23);
            this.easyButton.TabIndex = 1;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(340, 164);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 23);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.MediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(469, 164);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(75, 23);
            this.hardButton.TabIndex = 3;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Cornsilk;
            this.loadButton.Location = new System.Drawing.Point(297, 294);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(167, 23);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load your own board!";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // openSaveForm
            // 
            this.openSaveForm.BackColor = System.Drawing.Color.Cornsilk;
            this.openSaveForm.Location = new System.Drawing.Point(297, 252);
            this.openSaveForm.Name = "openSaveForm";
            this.openSaveForm.Size = new System.Drawing.Size(167, 23);
            this.openSaveForm.TabIndex = 5;
            this.openSaveForm.Text = "Save your own board!";
            this.openSaveForm.UseVisualStyleBackColor = false;
            this.openSaveForm.Click += new System.EventHandler(this.OpenSaveButton_Click);
            // 
            // LaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openSaveForm);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.label1);
            this.Name = "LaunchForm";
            this.Text = "Sudoku Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button easyButton; //Easy Button  
        private System.Windows.Forms.Button mediumButton; //Medium Button
        private System.Windows.Forms.Button hardButton; //Hard Button 
        private System.Windows.Forms.Button loadButton; //Load your own button
        private System.Windows.Forms.Button openSaveForm;
    }
}