using System.Windows.Forms;

namespace Project
{
    partial class Inventory
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
            this.label_inven = new System.Windows.Forms.Label();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button_display = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_inven
            // 
            this.label_inven.AutoSize = true;
            this.label_inven.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_inven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inven.Location = new System.Drawing.Point(397, 28);
            this.label_inven.Name = "label_inven";
            this.label_inven.Size = new System.Drawing.Size(158, 25);
            this.label_inven.TabIndex = 1;
            this.label_inven.Text = "CATEGORIES";
            this.label_inven.Click += new System.EventHandler(this.label_inven_Click);
            // 
            // dvg1
            // 
            this.dvg1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Location = new System.Drawing.Point(285, 107);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(330, 212);
            this.dvg1.TabIndex = 2;
            this.dvg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg1_CellContentClick_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(621, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "BUY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_display
            // 
            this.button_display.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_display.Location = new System.Drawing.Point(621, 107);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(75, 23);
            this.button_display.TabIndex = 3;
            this.button_display.Text = "DISPLAY";
            this.button_display.UseVisualStyleBackColor = false;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // Inventory
            // 
            this.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.ClientSize = new System.Drawing.Size(850, 378);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.dvg1);
            this.Controls.Add(this.label_inven);
            this.Controls.Add(this.button2);
            this.Name = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_inven;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_display;
        private DataGridViewCellEventHandler dvg1_CellContentClick;
    }
}