namespace _2DGameApp
{
    partial class gamescreen
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.jumpTimer = new System.Windows.Forms.Timer(this.components);
            this.currentscoreLabel = new System.Windows.Forms.Label();
            this.floorPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 60;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // jumpTimer
            // 
            this.jumpTimer.Interval = 60;
            this.jumpTimer.Tick += new System.EventHandler(this.jumpTimer_Tick);
            // 
            // currentscoreLabel
            // 
            this.currentscoreLabel.AutoSize = true;
            this.currentscoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentscoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentscoreLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.currentscoreLabel.Location = new System.Drawing.Point(14, 11);
            this.currentscoreLabel.Name = "currentscoreLabel";
            this.currentscoreLabel.Size = new System.Drawing.Size(0, 21);
            this.currentscoreLabel.TabIndex = 0;
            // 
            // floorPictureBox
            // 
            this.floorPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.floorPictureBox.BackgroundImage = global::_2DGameApp.Properties.Resources.Floor2;
            this.floorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.floorPictureBox.Image = global::_2DGameApp.Properties.Resources.Floor2;
            this.floorPictureBox.InitialImage = null;
            this.floorPictureBox.Location = new System.Drawing.Point(0, 347);
            this.floorPictureBox.Name = "floorPictureBox";
            this.floorPictureBox.Size = new System.Drawing.Size(400, 53);
            this.floorPictureBox.TabIndex = 1;
            this.floorPictureBox.TabStop = false;
            // 
            // gamescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2DGameApp.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.floorPictureBox);
            this.Controls.Add(this.currentscoreLabel);
            this.DoubleBuffered = true;
            this.Name = "gamescreen";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.gamescreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gamescreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamescreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gamescreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.floorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer jumpTimer;
        private System.Windows.Forms.Label currentscoreLabel;
        private System.Windows.Forms.PictureBox floorPictureBox;
    }
}
