namespace SnakeGame
{
    partial class Form1
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
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.infoGame_btn = new System.Windows.Forms.Button();
            this.usernameHelp_lbl = new System.Windows.Forms.Label();
            this.passHelp_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forget_lbl = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkLoginHelp_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(41, 303);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(320, 46);
            this.login_btn.TabIndex = 1;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(41, 355);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(320, 46);
            this.register_btn.TabIndex = 2;
            this.register_btn.Text = "REGISTER";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // pass_txt
            // 
            this.pass_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.pass_txt.Location = new System.Drawing.Point(150, 227);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(211, 27);
            this.pass_txt.TabIndex = 7;
            // 
            // infoGame_btn
            // 
            this.infoGame_btn.BackColor = System.Drawing.Color.White;
            this.infoGame_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoGame_btn.FlatAppearance.BorderSize = 0;
            this.infoGame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoGame_btn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGame_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.infoGame_btn.Location = new System.Drawing.Point(12, 479);
            this.infoGame_btn.Name = "infoGame_btn";
            this.infoGame_btn.Size = new System.Drawing.Size(81, 29);
            this.infoGame_btn.TabIndex = 8;
            this.infoGame_btn.Text = "ranking";
            this.infoGame_btn.UseVisualStyleBackColor = false;
            this.infoGame_btn.Click += new System.EventHandler(this.infoGame_btn_Click);
            // 
            // usernameHelp_lbl
            // 
            this.usernameHelp_lbl.AutoSize = true;
            this.usernameHelp_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.usernameHelp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameHelp_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.usernameHelp_lbl.Location = new System.Drawing.Point(153, 207);
            this.usernameHelp_lbl.Name = "usernameHelp_lbl";
            this.usernameHelp_lbl.Size = new System.Drawing.Size(0, 16);
            this.usernameHelp_lbl.TabIndex = 9;
            this.usernameHelp_lbl.Tag = "";
            // 
            // passHelp_lbl
            // 
            this.passHelp_lbl.AutoSize = true;
            this.passHelp_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.passHelp_lbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passHelp_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.passHelp_lbl.Location = new System.Drawing.Point(154, 262);
            this.passHelp_lbl.Name = "passHelp_lbl";
            this.passHelp_lbl.Size = new System.Drawing.Size(0, 17);
            this.passHelp_lbl.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(75, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 57);
            this.label3.TabIndex = 11;
            this.label3.Text = "WELLCOME";
            // 
            // forget_lbl
            // 
            this.forget_lbl.AutoSize = true;
            this.forget_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forget_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forget_lbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.forget_lbl.Location = new System.Drawing.Point(128, 415);
            this.forget_lbl.Name = "forget_lbl";
            this.forget_lbl.Size = new System.Drawing.Size(129, 20);
            this.forget_lbl.TabIndex = 12;
            this.forget_lbl.Text = "forget password";
            this.forget_lbl.Click += new System.EventHandler(this.forget_lbl_Click);
            // 
            // user_txt
            // 
            this.user_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txt.Location = new System.Drawing.Point(150, 174);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(211, 27);
            this.user_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // checkLoginHelp_lbl
            // 
            this.checkLoginHelp_lbl.AutoSize = true;
            this.checkLoginHelp_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.checkLoginHelp_lbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLoginHelp_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.checkLoginHelp_lbl.Location = new System.Drawing.Point(108, 125);
            this.checkLoginHelp_lbl.Name = "checkLoginHelp_lbl";
            this.checkLoginHelp_lbl.Size = new System.Drawing.Size(0, 17);
            this.checkLoginHelp_lbl.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(407, 520);
            this.Controls.Add(this.checkLoginHelp_lbl);
            this.Controls.Add(this.forget_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passHelp_lbl);
            this.Controls.Add(this.usernameHelp_lbl);
            this.Controls.Add(this.infoGame_btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.login_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNAKE GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button infoGame_btn;
        private System.Windows.Forms.Label usernameHelp_lbl;
        private System.Windows.Forms.Label passHelp_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forget_lbl;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label checkLoginHelp_lbl;
    }
}

