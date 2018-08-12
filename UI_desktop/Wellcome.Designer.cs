namespace UI_desktop
{
    partial class Wellcome
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
            this.createbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createbutton
            // 
            this.createbutton.BackColor = System.Drawing.Color.Transparent;
            this.createbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createbutton.Location = new System.Drawing.Point(60, 147);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(30, 21);
            this.createbutton.TabIndex = 0;
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.Transparent;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatebutton.Location = new System.Drawing.Point(60, 196);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(30, 21);
            this.updatebutton.TabIndex = 1;
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exitbutton.Location = new System.Drawing.Point(193, 254);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(55, 24);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Wellcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI_desktop.Resource.wellcome_page_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 341);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.createbutton);
            this.DoubleBuffered = true;
            this.Name = "Wellcome";
            this.Load += new System.EventHandler(this.Wellcome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}

