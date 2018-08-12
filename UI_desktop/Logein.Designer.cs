namespace UI_desktop
{
    partial class Logein
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
            this.username_login = new System.Windows.Forms.TextBox();
            this.accountno_logein = new System.Windows.Forms.TextBox();
            this.exit_login = new System.Windows.Forms.Button();
            this.back_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_login
            // 
            this.username_login.BackColor = System.Drawing.Color.Silver;
            this.username_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_login.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_login.Location = new System.Drawing.Point(62, 157);
            this.username_login.Name = "username_login";
            this.username_login.Size = new System.Drawing.Size(182, 18);
            this.username_login.TabIndex = 0;
            // 
            // accountno_logein
            // 
            this.accountno_logein.BackColor = System.Drawing.Color.Silver;
            this.accountno_logein.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountno_logein.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountno_logein.Location = new System.Drawing.Point(62, 221);
            this.accountno_logein.Name = "accountno_logein";
            this.accountno_logein.Size = new System.Drawing.Size(182, 18);
            this.accountno_logein.TabIndex = 1;
            // 
            // exit_login
            // 
            this.exit_login.BackColor = System.Drawing.Color.Transparent;
            this.exit_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_login.Location = new System.Drawing.Point(160, 268);
            this.exit_login.Name = "exit_login";
            this.exit_login.Size = new System.Drawing.Size(64, 24);
            this.exit_login.TabIndex = 5;
            this.exit_login.UseVisualStyleBackColor = false;
            this.exit_login.Click += new System.EventHandler(this.exit_login_Click);
            // 
            // back_login
            // 
            this.back_login.BackColor = System.Drawing.Color.Transparent;
            this.back_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_login.Location = new System.Drawing.Point(87, 268);
            this.back_login.Name = "back_login";
            this.back_login.Size = new System.Drawing.Size(54, 24);
            this.back_login.TabIndex = 6;
            this.back_login.UseVisualStyleBackColor = false;
            this.back_login.Click += new System.EventHandler(this.back_login_Click);
            // 
            // Logein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI_desktop.Resource.update_pagere;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 339);
            this.Controls.Add(this.back_login);
            this.Controls.Add(this.exit_login);
            this.Controls.Add(this.accountno_logein);
            this.Controls.Add(this.username_login);
            this.DoubleBuffered = true;
            this.Name = "Logein";
            this.Load += new System.EventHandler(this.Logein_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_login;
        private System.Windows.Forms.TextBox accountno_logein;
        private System.Windows.Forms.Button exit_login;
        private System.Windows.Forms.Button back_login;
    }
}