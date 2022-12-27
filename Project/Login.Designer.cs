namespace Project
{
    partial class Login
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
            this.text_pass = new System.Windows.Forms.TextBox();
            this.text_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_user = new System.Windows.Forms.Button();
            this.button_Menu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(312, 197);
            this.text_pass.Name = "text_pass";
            this.text_pass.PasswordChar = '*';
            this.text_pass.Size = new System.Drawing.Size(100, 20);
            this.text_pass.TabIndex = 6;
            this.text_pass.TextChanged += new System.EventHandler(this.text_pass_TextChanged);
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(312, 139);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(100, 20);
            this.text_user.TabIndex = 7;
            this.text_user.TextChanged += new System.EventHandler(this.text_user_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOG IN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_user
            // 
            this.button_user.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_user.Location = new System.Drawing.Point(312, 241);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(88, 36);
            this.button_user.TabIndex = 4;
            this.button_user.Text = "LOGIN";
            this.button_user.UseVisualStyleBackColor = false;
            this.button_user.Click += new System.EventHandler(this.button_user_Click);
            // 
            // button_Menu
            // 
            this.button_Menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_Menu.Location = new System.Drawing.Point(312, 283);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(88, 36);
            this.button_Menu.TabIndex = 8;
            this.button_Menu.Text = "MAIN MENU";
            this.button_Menu.UseVisualStyleBackColor = false;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PASSWORD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "USERNAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Project.Properties.Resources.log;
            this.ClientSize = new System.Drawing.Size(673, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_user);
            this.Name = "Login";
            this.Text = "Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}