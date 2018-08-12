namespace UI_desktop
{
    partial class Store
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
            this.backstroe = new System.Windows.Forms.Button();
            this.exitstore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backstroe
            // 
            this.backstroe.BackColor = System.Drawing.Color.Transparent;
            this.backstroe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backstroe.Location = new System.Drawing.Point(377, 274);
            this.backstroe.Name = "backstroe";
            this.backstroe.Size = new System.Drawing.Size(51, 25);
            this.backstroe.TabIndex = 3;
            this.backstroe.UseVisualStyleBackColor = false;
            this.backstroe.Click += new System.EventHandler(this.backstroe_Click);
            // 
            // exitstore
            // 
            this.exitstore.BackColor = System.Drawing.Color.Transparent;
            this.exitstore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitstore.Location = new System.Drawing.Point(441, 272);
            this.exitstore.Name = "exitstore";
            this.exitstore.Size = new System.Drawing.Size(51, 26);
            this.exitstore.TabIndex = 4;
            this.exitstore.UseVisualStyleBackColor = false;
            this.exitstore.Click += new System.EventHandler(this.exitstore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 156);
            this.dataGridView1.TabIndex = 5;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI_desktop.Resource.stor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 319);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitstore);
            this.Controls.Add(this.backstroe);
            this.DoubleBuffered = true;
            this.Name = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backstroe;
        private System.Windows.Forms.Button exitstore;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}