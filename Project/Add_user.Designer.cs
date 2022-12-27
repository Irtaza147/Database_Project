namespace Project
{
    partial class Add_user
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_add = new System.Windows.Forms.TextBox();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.text_l_name = new System.Windows.Forms.TextBox();
            this.text_f_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Enter Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Enter Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Enter Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Enter  First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter User id";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(230, 48);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 20);
            this.text_id.TabIndex = 26;
            // 
            // text_add
            // 
            this.text_add.Location = new System.Drawing.Point(230, 152);
            this.text_add.Name = "text_add";
            this.text_add.Size = new System.Drawing.Size(100, 20);
            this.text_add.TabIndex = 25;
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(230, 126);
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(100, 20);
            this.text_pass.TabIndex = 24;
            // 
            // text_l_name
            // 
            this.text_l_name.Location = new System.Drawing.Point(230, 100);
            this.text_l_name.Name = "text_l_name";
            this.text_l_name.Size = new System.Drawing.Size(100, 20);
            this.text_l_name.TabIndex = 23;
            // 
            // text_f_name
            // 
            this.text_f_name.Location = new System.Drawing.Point(230, 74);
            this.text_f_name.Name = "text_f_name";
            this.text_f_name.Size = new System.Drawing.Size(100, 20);
            this.text_f_name.TabIndex = 22;
            // 
            // Add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.text_add);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.text_l_name);
            this.Controls.Add(this.text_f_name);
            this.Name = "Add_user";
            this.Text = "Add_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_add;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.TextBox text_l_name;
        private System.Windows.Forms.TextBox text_f_name;
    }
}