namespace _2DGameApp
{
    partial class endscreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.endLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.mainmenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endLabel.Location = new System.Drawing.Point(139, 102);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(102, 21);
            this.endLabel.TabIndex = 0;
            this.endLabel.Text = "GAME OVER";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(139, 149);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 21);
            this.scoreLabel.TabIndex = 1;
            // 
            // mainmenuButton
            // 
            this.mainmenuButton.Location = new System.Drawing.Point(119, 246);
            this.mainmenuButton.Name = "mainmenuButton";
            this.mainmenuButton.Size = new System.Drawing.Size(149, 23);
            this.mainmenuButton.TabIndex = 2;
            this.mainmenuButton.Text = "MAIN MENU";
            this.mainmenuButton.UseVisualStyleBackColor = true;
            this.mainmenuButton.Click += new System.EventHandler(this.mainmenuButton_Click);
            // 
            // endscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainmenuButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.endLabel);
            this.Name = "endscreen";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.endscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button mainmenuButton;
    }
}
