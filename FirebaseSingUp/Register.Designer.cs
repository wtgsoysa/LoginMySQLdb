namespace FirebaseSingUp
{
    partial class Register
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
            this.passText = new System.Windows.Forms.TextBox();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.toLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fullText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserOccupation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUploard = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(270, 272);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(209, 37);
            this.passText.TabIndex = 9;
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(270, 212);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(209, 37);
            this.userEmail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(133, 447);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 29);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // toLogin
            // 
            this.toLogin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLogin.Location = new System.Drawing.Point(270, 447);
            this.toLogin.Name = "toLogin";
            this.toLogin.Size = new System.Drawing.Size(194, 29);
            this.toLogin.TabIndex = 10;
            this.toLogin.Text = "Back to Login";
            this.toLogin.UseVisualStyleBackColor = true;
            this.toLogin.Click += new System.EventHandler(this.toLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "Register";
            // 
            // fullText
            // 
            this.fullText.Location = new System.Drawing.Point(270, 90);
            this.fullText.Name = "fullText";
            this.fullText.Size = new System.Drawing.Size(209, 37);
            this.fullText.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Full Name";
            // 
            // UserOccupation
            // 
            this.UserOccupation.Location = new System.Drawing.Point(270, 147);
            this.UserOccupation.Name = "UserOccupation";
            this.UserOccupation.Size = new System.Drawing.Size(209, 37);
            this.UserOccupation.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Occupation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "Profile Photo";
            // 
            // btnUploard
            // 
            this.btnUploard.AnimationHoverSpeed = 0.07F;
            this.btnUploard.AnimationSpeed = 0.03F;
            this.btnUploard.BackColor = System.Drawing.Color.Transparent;
            this.btnUploard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUploard.BorderColor = System.Drawing.Color.Black;
            this.btnUploard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUploard.FocusedColor = System.Drawing.Color.Empty;
            this.btnUploard.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploard.ForeColor = System.Drawing.Color.Black;
            this.btnUploard.Image = null;
            this.btnUploard.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUploard.Location = new System.Drawing.Point(271, 345);
            this.btnUploard.Name = "btnUploard";
            this.btnUploard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUploard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUploard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUploard.OnHoverImage = null;
            this.btnUploard.OnPressedColor = System.Drawing.Color.Black;
            this.btnUploard.Radius = 10;
            this.btnUploard.Size = new System.Drawing.Size(208, 42);
            this.btnUploard.TabIndex = 18;
            this.btnUploard.Text = "Add Profile Photo";
            this.btnUploard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUploard.Click += new System.EventHandler(this.btnUploard_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 533);
            this.Controls.Add(this.btnUploard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserOccupation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fullText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toLogin);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("Poppins", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button toLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserOccupation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton btnUploard;
    }
}