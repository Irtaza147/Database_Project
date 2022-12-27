namespace Project
{
    partial class Person_identify
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
            this.button_admin = new System.Windows.Forms.Button();
            this.button_cus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_admin
            // 
            this.button_admin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_admin.Location = new System.Drawing.Point(322, 130);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(88, 36);
            this.button_admin.TabIndex = 0;
            this.button_admin.Text = "ADMIN";
            this.button_admin.UseVisualStyleBackColor = false;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // button_cus
            // 
            this.button_cus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_cus.Location = new System.Drawing.Point(322, 212);
            this.button_cus.Name = "button_cus";
            this.button_cus.Size = new System.Drawing.Size(88, 35);
            this.button_cus.TabIndex = 0;
            this.button_cus.Text = "CUSTOMER";
            this.button_cus.UseVisualStyleBackColor = false;
            this.button_cus.Click += new System.EventHandler(this.button_cus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDENTIFICATION";
            // 
            // Person_identify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.log;
            this.ClientSize = new System.Drawing.Size(743, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cus);
            this.Controls.Add(this.button_admin);
            this.Name = "Person_identify";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_admin;
        private System.Windows.Forms.Button button_cus;
        private System.Windows.Forms.Label label1;
    }
}

