namespace FirebaseSingUp
{
    partial class LoginSuccess
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.button1.Location = new System.Drawing.Point(515, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.lblFullName.Location = new System.Drawing.Point(219, 285);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(238, 53);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Display Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email  Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(281, 476);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 34);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOccupation
            // 
            this.lblOccupation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.lblOccupation.Location = new System.Drawing.Point(262, 338);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(136, 34);
            this.lblOccupation.TabIndex = 6;
            this.lblOccupation.Text = "Occupation";
            this.lblOccupation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 181);
            this.panel1.TabIndex = 8;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxProfile.BaseColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Image = global::FirebaseSingUp.Properties.Resources.Rectangle_80;
            this.pictureBoxProfile.Location = new System.Drawing.Point(247, 118);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(151, 151);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 10;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.UseTransfarantBackground = true;
            // 
            // LoginSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 618);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFullName);
            this.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LoginSuccess";
            this.Text = "LoginSuccess";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCirclePictureBox pictureBoxProfile;
    }
}