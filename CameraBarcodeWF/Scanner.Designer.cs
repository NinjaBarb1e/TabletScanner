namespace CameraBarcodeWF
{
    partial class Scanner
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
            this.webCameraControl1 = new WebEye.WebCameraControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBadgeId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBadgeID = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.laserBar = new System.Windows.Forms.Panel();
            this.cboCameras = new System.Windows.Forms.ComboBox();
            this.resultPanel1 = new CameraBarcodeWF.ResultPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webCameraControl1
            // 
            this.webCameraControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webCameraControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.webCameraControl1.Location = new System.Drawing.Point(26, 26);
            this.webCameraControl1.Name = "webCameraControl1";
            this.webCameraControl1.Size = new System.Drawing.Size(590, 582);
            this.webCameraControl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.4359F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBadgeId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBadgeID, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 683);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 110);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(77, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblBadgeId
            // 
            this.lblBadgeId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBadgeId.AutoSize = true;
            this.lblBadgeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBadgeId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBadgeId.Location = new System.Drawing.Point(31, 64);
            this.lblBadgeId.Name = "lblBadgeId";
            this.lblBadgeId.Size = new System.Drawing.Size(158, 37);
            this.lblBadgeId.TabIndex = 1;
            this.lblBadgeId.Text = "Badge ID:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(195, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(392, 37);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Test";
            // 
            // txtBadgeID
            // 
            this.txtBadgeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBadgeID.BackColor = System.Drawing.Color.Black;
            this.txtBadgeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBadgeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBadgeID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBadgeID.Location = new System.Drawing.Point(195, 64);
            this.txtBadgeID.Name = "txtBadgeID";
            this.txtBadgeID.Size = new System.Drawing.Size(392, 37);
            this.txtBadgeID.TabIndex = 3;
            this.txtBadgeID.Text = "847938";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.DimGray;
            this.btnOK.Location = new System.Drawing.Point(26, 824);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(590, 60);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // laserBar
            // 
            this.laserBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laserBar.BackColor = System.Drawing.Color.IndianRed;
            this.laserBar.Location = new System.Drawing.Point(17, 316);
            this.laserBar.Name = "laserBar";
            this.laserBar.Size = new System.Drawing.Size(608, 3);
            this.laserBar.TabIndex = 4;
            // 
            // cboCameras
            // 
            this.cboCameras.FormattingEnabled = true;
            this.cboCameras.Location = new System.Drawing.Point(26, 636);
            this.cboCameras.Name = "cboCameras";
            this.cboCameras.Size = new System.Drawing.Size(299, 21);
            this.cboCameras.TabIndex = 5;
            // 
            // resultPanel1
            // 
            this.resultPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultPanel1.BackColor = System.Drawing.Color.White;
            this.resultPanel1.Location = new System.Drawing.Point(26, 26);
            this.resultPanel1.Name = "resultPanel1";
            this.resultPanel1.Size = new System.Drawing.Size(590, 582);
            this.resultPanel1.TabIndex = 3;
            this.resultPanel1.Visible = false;
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.cboCameras);
            this.Controls.Add(this.laserBar);
            this.Controls.Add(this.resultPanel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.webCameraControl1);
            this.Name = "Scanner";
            this.Size = new System.Drawing.Size(643, 900);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WebEye.WebCameraControl webCameraControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBadgeId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBadgeID;
        private System.Windows.Forms.Button btnOK;
        private ResultPanel resultPanel1;
        private System.Windows.Forms.Panel laserBar;
        private System.Windows.Forms.ComboBox cboCameras;
    }
}
