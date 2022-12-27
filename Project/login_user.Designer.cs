namespace Project
{
    partial class login_user
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Menu = new System.Windows.Forms.Button();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.text_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_user = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(259, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(259, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "PASSWORD";
            // 
            // button_Menu
            // 
            this.button_Menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_Menu.Location = new System.Drawing.Point(314, 324);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(88, 36);
            this.button_Menu.TabIndex = 15;
            this.button_Menu.Text = "MAIN MENU";
            this.button_Menu.UseVisualStyleBackColor = false;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(354, 183);
            this.text_pass.Name = "text_pass";
            this.text_pass.PasswordChar = '*';
            this.text_pass.Size = new System.Drawing.Size(100, 20);
            this.text_pass.TabIndex = 13;
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(354, 125);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(100, 20);
            this.text_user.TabIndex = 14;
            this.text_user.TextChanged += new System.EventHandler(this.text_user_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOG IN";
            // 
            // button_user
            // 
            this.button_user.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_user.Location = new System.Drawing.Point(366, 239);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(88, 36);
            this.button_user.TabIndex = 11;
            this.button_user.Text = "LOGIN";
            this.button_user.UseVisualStyleBackColor = false;
            this.button_user.Click += new System.EventHandler(this.button_user_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(272, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "SIGNUP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Project.Properties.Resources.log;
            this.ClientSize = new System.Drawing.Size(741, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_user);
            this.Name = "login_user";
            this.Text = "login_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.Button button1;
    }
}