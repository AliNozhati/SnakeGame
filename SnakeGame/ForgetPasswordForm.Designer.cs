namespace SnakeGame
{
    partial class ForgetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            this.change_by_cmb = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.emailOrPhone_lbl = new System.Windows.Forms.Label();
            this.newPass_lbl = new System.Windows.Forms.Label();
            this.emailOrPhone_txt = new System.Windows.Forms.TextBox();
            this.newPass_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.emailOrPhoneHelp_lbl = new System.Windows.Forms.Label();
            this.newPassHelp_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // change_by_cmb
            // 
            this.change_by_cmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_by_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.change_by_cmb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.change_by_cmb.FormattingEnabled = true;
            this.change_by_cmb.Items.AddRange(new object[] {
            "Email",
            "Phone"});
            this.change_by_cmb.Location = new System.Drawing.Point(187, 66);
            this.change_by_cmb.Name = "change_by_cmb";
            this.change_by_cmb.Size = new System.Drawing.Size(207, 36);
            this.change_by_cmb.TabIndex = 0;
            this.change_by_cmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change by";
            // 
            // emailOrPhone_lbl
            // 
            this.emailOrPhone_lbl.AutoSize = true;
            this.emailOrPhone_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailOrPhone_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.emailOrPhone_lbl.Location = new System.Drawing.Point(61, 149);
            this.emailOrPhone_lbl.Name = "emailOrPhone_lbl";
            this.emailOrPhone_lbl.Size = new System.Drawing.Size(60, 28);
            this.emailOrPhone_lbl.TabIndex = 3;
            this.emailOrPhone_lbl.Text = "Email";
            // 
            // newPass_lbl
            // 
            this.newPass_lbl.AutoSize = true;
            this.newPass_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.newPass_lbl.Location = new System.Drawing.Point(29, 211);
            this.newPass_lbl.Name = "newPass_lbl";
            this.newPass_lbl.Size = new System.Drawing.Size(141, 28);
            this.newPass_lbl.TabIndex = 4;
            this.newPass_lbl.Text = "new Password";
            // 
            // emailOrPhone_txt
            // 
            this.emailOrPhone_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailOrPhone_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.emailOrPhone_txt.Location = new System.Drawing.Point(187, 149);
            this.emailOrPhone_txt.Name = "emailOrPhone_txt";
            this.emailOrPhone_txt.Size = new System.Drawing.Size(207, 27);
            this.emailOrPhone_txt.TabIndex = 5;
            // 
            // newPass_txt
            // 
            this.newPass_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPass_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.newPass_txt.Location = new System.Drawing.Point(187, 212);
            this.newPass_txt.Name = "newPass_txt";
            this.newPass_txt.Size = new System.Drawing.Size(207, 27);
            this.newPass_txt.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "CHANGE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // emailOrPhoneHelp_lbl
            // 
            this.emailOrPhoneHelp_lbl.AutoSize = true;
            this.emailOrPhoneHelp_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.emailOrPhoneHelp_lbl.Location = new System.Drawing.Point(194, 179);
            this.emailOrPhoneHelp_lbl.Name = "emailOrPhoneHelp_lbl";
            this.emailOrPhoneHelp_lbl.Size = new System.Drawing.Size(95, 16);
            this.emailOrPhoneHelp_lbl.TabIndex = 8;
            this.emailOrPhoneHelp_lbl.Text = "helpText email";
            // 
            // newPassHelp_lbl
            // 
            this.newPassHelp_lbl.AutoSize = true;
            this.newPassHelp_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.newPassHelp_lbl.Location = new System.Drawing.Point(194, 242);
            this.newPassHelp_lbl.Name = "newPassHelp_lbl";
            this.newPassHelp_lbl.Size = new System.Drawing.Size(93, 16);
            this.newPassHelp_lbl.TabIndex = 9;
            this.newPassHelp_lbl.Text = "helpText Pass";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newPassHelp_lbl);
            this.Controls.Add(this.emailOrPhoneHelp_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newPass_txt);
            this.Controls.Add(this.emailOrPhone_txt);
            this.Controls.Add(this.newPass_lbl);
            this.Controls.Add(this.emailOrPhone_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.change_by_cmb);
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox change_by_cmb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailOrPhone_lbl;
        private System.Windows.Forms.Label newPass_lbl;
        private System.Windows.Forms.TextBox emailOrPhone_txt;
        private System.Windows.Forms.TextBox newPass_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label emailOrPhoneHelp_lbl;
        private System.Windows.Forms.Label newPassHelp_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}