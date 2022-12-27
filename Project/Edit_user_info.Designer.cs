namespace Project
{
    partial class edituserinfo
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
            this.components = new System.ComponentModel.Container();
            this.text_delete = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.text_f_name = new System.Windows.Forms.TextBox();
            this.text_l_name = new System.Windows.Forms.TextBox();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.text_add = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.dvg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_display = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // text_delete
            // 
            this.text_delete.Location = new System.Drawing.Point(593, 74);
            this.text_delete.Name = "text_delete";
            this.text_delete.Size = new System.Drawing.Size(100, 20);
            this.text_delete.TabIndex = 0;
            this.text_delete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // text_f_name
            // 
            this.text_f_name.Location = new System.Drawing.Point(108, 126);
            this.text_f_name.Name = "text_f_name";
            this.text_f_name.Size = new System.Drawing.Size(100, 20);
            this.text_f_name.TabIndex = 1;
            this.text_f_name.TextChanged += new System.EventHandler(this.text_f_name_TextChanged);
            // 
            // text_l_name
            // 
            this.text_l_name.Location = new System.Drawing.Point(108, 152);
            this.text_l_name.Name = "text_l_name";
            this.text_l_name.Size = new System.Drawing.Size(100, 20);
            this.text_l_name.TabIndex = 2;
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(108, 178);
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(100, 20);
            this.text_pass.TabIndex = 3;
            // 
            // text_add
            // 
            this.text_add.Location = new System.Drawing.Point(108, 204);
            this.text_add.Name = "text_add";
            this.text_add.Size = new System.Drawing.Size(100, 20);
            this.text_add.TabIndex = 5;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(108, 100);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 20);
            this.text_id.TabIndex = 6;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_delete.Location = new System.Drawing.Point(713, 71);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dvg
            // 
            this.dvg.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Location = new System.Drawing.Point(381, 100);
            this.dvg.Name = "dvg";
            this.dvg.Size = new System.Drawing.Size(407, 235);
            this.dvg.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(607, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter User id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter User id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter  First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter Last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Location = new System.Drawing.Point(18, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enter Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Location = new System.Drawing.Point(18, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enter Address";
            // 
            // button_display
            // 
            this.button_display.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_display.Location = new System.Drawing.Point(713, 341);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(75, 23);
            this.button_display.TabIndex = 15;
            this.button_display.Text = "Display";
            this.button_display.UseVisualStyleBackColor = false;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(250, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update_F_Name";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Location = new System.Drawing.Point(250, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Update_L_Name";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.Location = new System.Drawing.Point(250, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Update_Password";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button5.Location = new System.Drawing.Point(250, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Update_Address";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(108, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Update_All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button6.Location = new System.Drawing.Point(250, 312);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "ADD/EDIT USER";
            // 
            // edituserinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.text_add);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.text_l_name);
            this.Controls.Add(this.text_f_name);
            this.Controls.Add(this.text_delete);
            this.Name = "edituserinfo";
            this.Text = "edit _user_info";
            this.Load += new System.EventHandler(this.edituserinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox text_f_name;
        private System.Windows.Forms.TextBox text_l_name;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.TextBox text_add;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_display;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
    }
}