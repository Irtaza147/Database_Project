namespace Project
{
    partial class admin_job
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
            this.button2 = new System.Windows.Forms.Button();
            this.dvg = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(195, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit_User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(772, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "View_User";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dvg
            // 
            this.dvg.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Location = new System.Drawing.Point(376, 92);
            this.dvg.Name = "dvg";
            this.dvg.Size = new System.Drawing.Size(504, 231);
            this.dvg.TabIndex = 2;
            this.dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Location = new System.Drawing.Point(195, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit_Inventory";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.Location = new System.Drawing.Point(195, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "Main Menu";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // admin_job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "admin_job";
            this.Text = "admin_job";
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}