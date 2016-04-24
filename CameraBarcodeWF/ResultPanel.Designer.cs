namespace CameraBarcodeWF
{
    partial class ResultPanel
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
            this.imageGreenCheck = new System.Windows.Forms.PictureBox();
            this.imageRedX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageGreenCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageRedX)).BeginInit();
            this.SuspendLayout();
            // 
            // imageGreenCheck
            // 
            this.imageGreenCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageGreenCheck.Image = global::CameraBarcodeWF.Properties.Resources.GreenCheckCircle;
            this.imageGreenCheck.Location = new System.Drawing.Point(107, 2);
            this.imageGreenCheck.Name = "imageGreenCheck";
            this.imageGreenCheck.Size = new System.Drawing.Size(192, 180);
            this.imageGreenCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageGreenCheck.TabIndex = 0;
            this.imageGreenCheck.TabStop = false;
            // 
            // imageRedX
            // 
            this.imageRedX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageRedX.Image = global::CameraBarcodeWF.Properties.Resources.RedXCircle;
            this.imageRedX.Location = new System.Drawing.Point(107, 2);
            this.imageRedX.Name = "imageRedX";
            this.imageRedX.Size = new System.Drawing.Size(192, 180);
            this.imageRedX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageRedX.TabIndex = 1;
            this.imageRedX.TabStop = false;
            // 
            // ResultPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.imageRedX);
            this.Controls.Add(this.imageGreenCheck);
            this.Name = "ResultPanel";
            this.Size = new System.Drawing.Size(409, 185);
            ((System.ComponentModel.ISupportInitialize)(this.imageGreenCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageRedX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageGreenCheck;
        private System.Windows.Forms.PictureBox imageRedX;
    }
}
