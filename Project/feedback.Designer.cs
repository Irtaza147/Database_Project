namespace Project
{
    partial class feedback
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
            this.text_comment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_place = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_comment
            // 
            this.text_comment.Location = new System.Drawing.Point(377, 152);
            this.text_comment.Multiline = true;
            this.text_comment.Name = "text_comment";
            this.text_comment.Size = new System.Drawing.Size(151, 70);
            this.text_comment.TabIndex = 0;
            this.text_comment.TextChanged += new System.EventHandler(this.text_comment_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "FEEDBACK";
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_submit.Location = new System.Drawing.Point(405, 283);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 3;
            this.button_submit.Text = "SUBMIT";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_place
            // 
            this.button_place.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_place.Location = new System.Drawing.Point(175, 274);
            this.button_place.Name = "button_place";
            this.button_place.Size = new System.Drawing.Size(94, 40);
            this.button_place.TabIndex = 4;
            this.button_place.Text = "Place Order Again";
            this.button_place.UseVisualStyleBackColor = false;
            this.button_place.Click += new System.EventHandler(this.button_place_Click);
            // 
            // button_log
            // 
            this.button_log.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_log.Location = new System.Drawing.Point(632, 283);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(75, 23);
            this.button_log.TabIndex = 5;
            this.button_log.Text = "LOG OUT";
            this.button_log.UseVisualStyleBackColor = false;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(377, 111);
            this.text_name.Multiline = true;
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(88, 23);
            this.text_name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(298, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Location = new System.Drawing.Point(308, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comment";
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Laptop;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.button_place);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_comment);
            this.Name = "feedback";
            this.Text = "feedback";
            this.Load += new System.EventHandler(this.feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_comment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_place;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}