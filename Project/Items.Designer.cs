using System;

namespace Project
{
    partial class Items
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
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dvg2 = new System.Windows.Forms.DataGridView();
            this.text_user_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_display = new System.Windows.Forms.Button();
            this.text_pro_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_add.Location = new System.Drawing.Point(709, 198);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(91, 41);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "ADD TO CART";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "ITEMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dvg2
            // 
            this.dvg2.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dvg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg2.Location = new System.Drawing.Point(12, 84);
            this.dvg2.Name = "dvg2";
            this.dvg2.Size = new System.Drawing.Size(480, 275);
            this.dvg2.TabIndex = 5;
            // 
            // text_user_id
            // 
            this.text_user_id.Location = new System.Drawing.Point(709, 161);
            this.text_user_id.Name = "text_user_id";
            this.text_user_id.Size = new System.Drawing.Size(91, 20);
            this.text_user_id.TabIndex = 6;
            this.text_user_id.TextChanged += new System.EventHandler(this.text_user_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(614, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Product ID ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_display
            // 
            this.button_display.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_display.Location = new System.Drawing.Point(498, 84);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(75, 23);
            this.button_display.TabIndex = 8;
            this.button_display.Text = "DISPLAY";
            this.button_display.UseVisualStyleBackColor = false;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // text_pro_id
            // 
            this.text_pro_id.Location = new System.Drawing.Point(709, 129);
            this.text_pro_id.Name = "text_pro_id";
            this.text_pro_id.Size = new System.Drawing.Size(91, 20);
            this.text_pro_id.TabIndex = 6;
            this.text_pro_id.TextChanged += new System.EventHandler(this.text_pro_id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(614, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter User ID ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(709, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_pro_id);
            this.Controls.Add(this.text_user_id);
            this.Controls.Add(this.dvg2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvg2;
        private System.Windows.Forms.TextBox text_user_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_display;
        private EventHandler button_ram_Click;
        private System.Windows.Forms.TextBox text_pro_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}