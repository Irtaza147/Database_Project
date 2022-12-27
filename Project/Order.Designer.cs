namespace Project
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.dvg_Order = new System.Windows.Forms.DataGridView();
            this.button_Order = new System.Windows.Forms.Button();
            this.button_display = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER";
            // 
            // dvg_Order
            // 
            this.dvg_Order.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dvg_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Order.Location = new System.Drawing.Point(177, 169);
            this.dvg_Order.Name = "dvg_Order";
            this.dvg_Order.Size = new System.Drawing.Size(504, 210);
            this.dvg_Order.TabIndex = 1;
            this.dvg_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_Order_CellContentClick);
            // 
            // button_Order
            // 
            this.button_Order.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.button_Order.Location = new System.Drawing.Point(705, 259);
            this.button_Order.Name = "button_Order";
            this.button_Order.Size = new System.Drawing.Size(137, 39);
            this.button_Order.TabIndex = 3;
            this.button_Order.Text = "PLACE ORDER";
            this.button_Order.UseVisualStyleBackColor = true;
            this.button_Order.Click += new System.EventHandler(this.button_Order_Click);
            // 
            // button_display
            // 
            this.button_display.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.button_display.Location = new System.Drawing.Point(705, 169);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(137, 39);
            this.button_display.TabIndex = 4;
            this.button_display.Text = "DISPLAY";
            this.button_display.UseVisualStyleBackColor = true;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.button1.Location = new System.Drawing.Point(705, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "CLEAR CART";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.button2.Location = new System.Drawing.Point(705, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "BACK To Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.button_Order);
            this.Controls.Add(this.dvg_Order);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvg_Order;
        private System.Windows.Forms.Button button_Order;
        private System.Windows.Forms.Button button_display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}