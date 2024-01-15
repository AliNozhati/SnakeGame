namespace SnakeGame
{
    partial class InformationGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationGameForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search_by_cmb = new System.Windows.Forms.ComboBox();
            this.back_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(332, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // search_txt
            // 
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.search_txt.Location = new System.Drawing.Point(117, 155);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(267, 27);
            this.search_txt.TabIndex = 15;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.search_lbl.Location = new System.Drawing.Point(33, 154);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(72, 28);
            this.search_lbl.TabIndex = 13;
            this.search_lbl.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search by";
            // 
            // search_by_cmb
            // 
            this.search_by_cmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_by_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_by_cmb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.search_by_cmb.FormattingEnabled = true;
            this.search_by_cmb.Items.AddRange(new object[] {
            "Username",
            "Score"});
            this.search_by_cmb.Location = new System.Drawing.Point(177, 80);
            this.search_by_cmb.Name = "search_by_cmb";
            this.search_by_cmb.Size = new System.Drawing.Size(207, 36);
            this.search_by_cmb.TabIndex = 11;
            this.search_by_cmb.SelectedIndexChanged += new System.EventHandler(this.search_by_cmb_SelectedIndexChanged);
            // 
            // back_picture
            // 
            this.back_picture.Image = ((System.Drawing.Image)(resources.GetObject("back_picture.Image")));
            this.back_picture.Location = new System.Drawing.Point(9, 12);
            this.back_picture.Name = "back_picture";
            this.back_picture.Size = new System.Drawing.Size(35, 35);
            this.back_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_picture.TabIndex = 20;
            this.back_picture.TabStop = false;
            this.back_picture.Click += new System.EventHandler(this.back_picture_Click);
            // 
            // InformationGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 712);
            this.Controls.Add(this.back_picture);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_by_cmb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InformationGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationGameForm";
            this.Load += new System.EventHandler(this.InformationGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox back_picture;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox search_by_cmb;
    }
}