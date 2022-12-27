namespace Project
{
    partial class Edit_inventory
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
            this.dvg = new System.Windows.Forms.DataGridView();
            this.button_display = new System.Windows.Forms.Button();
            this.button_stock = new System.Windows.Forms.Button();
            this.text_stock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.button_price = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_cat_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_cat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg
            // 
            this.dvg.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Location = new System.Drawing.Point(351, 95);
            this.dvg.Name = "dvg";
            this.dvg.Size = new System.Drawing.Size(532, 261);
            this.dvg.TabIndex = 0;
            // 
            // button_display
            // 
            this.button_display.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_display.Location = new System.Drawing.Point(808, 68);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(75, 23);
            this.button_display.TabIndex = 1;
            this.button_display.Text = "Display";
            this.button_display.UseVisualStyleBackColor = false;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // button_stock
            // 
            this.button_stock.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_stock.Location = new System.Drawing.Point(270, 95);
            this.button_stock.Name = "button_stock";
            this.button_stock.Size = new System.Drawing.Size(75, 23);
            this.button_stock.TabIndex = 3;
            this.button_stock.Text = "Edit_Stock";
            this.button_stock.UseVisualStyleBackColor = false;
            this.button_stock.Click += new System.EventHandler(this.button_stock_Click);
            // 
            // text_stock
            // 
            this.text_stock.Location = new System.Drawing.Point(164, 97);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(100, 20);
            this.text_stock.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(75, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Product id";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(164, 71);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 20);
            this.text_id.TabIndex = 6;
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(164, 123);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(100, 20);
            this.text_price.TabIndex = 7;
            // 
            // button_price
            // 
            this.button_price.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_price.Location = new System.Drawing.Point(270, 124);
            this.button_price.Name = "button_price";
            this.button_price.Size = new System.Drawing.Size(75, 23);
            this.button_price.TabIndex = 8;
            this.button_price.Text = "Edit_price";
            this.button_price.UseVisualStyleBackColor = false;
            this.button_price.Click += new System.EventHandler(this.button_price_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(79, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(79, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Price";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(270, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(164, 149);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(100, 20);
            this.text_Name.TabIndex = 12;
            // 
            // text_cat_id
            // 
            this.text_cat_id.Location = new System.Drawing.Point(164, 175);
            this.text_cat_id.Name = "text_cat_id";
            this.text_cat_id.Size = new System.Drawing.Size(100, 20);
            this.text_cat_id.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Location = new System.Drawing.Point(79, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Location = new System.Drawing.Point(65, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter Category_ID";
            // 
            // button_cat
            // 
            this.button_cat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_cat.Location = new System.Drawing.Point(270, 178);
            this.button_cat.Name = "button_cat";
            this.button_cat.Size = new System.Drawing.Size(75, 23);
            this.button_cat.TabIndex = 16;
            this.button_cat.Text = "Edit_Cat_id";
            this.button_cat.UseVisualStyleBackColor = false;
            this.button_cat.Click += new System.EventHandler(this.button_cat_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(270, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Edit_Name";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "ADD/EDIT INVENTORY";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_add.Location = new System.Drawing.Point(164, 214);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 41);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "Add New";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Edit_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_cat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_cat_id);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_price);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_stock);
            this.Controls.Add(this.button_stock);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.dvg);
            this.Name = "Edit_inventory";
            this.Text = "Edit_inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.Button button_display;
        private System.Windows.Forms.Button button_stock;
        private System.Windows.Forms.TextBox text_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.Button button_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_cat_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_cat;
        private System.Windows.Forms.Button button_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_add;
    }
}