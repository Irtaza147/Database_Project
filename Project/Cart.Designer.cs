namespace Project
{
    partial class Cart
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
            this.button_order = new System.Windows.Forms.Button();
            this.dvg_cart = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CART";
            // 
            // button_order
            // 
            this.button_order.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_order.Location = new System.Drawing.Point(761, 398);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(104, 33);
            this.button_order.TabIndex = 1;
            this.button_order.Text = "PROCEED";
            this.button_order.UseVisualStyleBackColor = false;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // dvg_cart
            // 
            this.dvg_cart.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dvg_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_cart.Location = new System.Drawing.Point(58, 160);
            this.dvg_cart.Name = "dvg_cart";
            this.dvg_cart.Size = new System.Drawing.Size(566, 278);
            this.dvg_cart.TabIndex = 2;
            this.dvg_cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_cart_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(641, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "DISPLAY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(641, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "CLEAR CART";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Location = new System.Drawing.Point(641, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dvg_cart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.label1);
            this.Name = "Cart";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.DataGridView dvg_cart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}