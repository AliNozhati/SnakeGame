using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class InformationGameForm : Form
    {
        public InformationGameForm()
        {
            InitializeComponent();
        }

        private void InformationGameForm_Load(object sender, EventArgs e)
        {
            search_txt.Enabled = false;
            search_lbl.Visible = false;
            this.getAllInfoPlayer();
        }

        private void SetDataGridView(SqlDataAdapter sqlAdapter)
        {
            DataSet ds = new DataSet();
            sqlAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            if (dataGridView1.Columns.Contains("Password"))
                dataGridView1.Columns.Remove("Password");
            if (dataGridView1.Columns.Contains("FirstName"))
                dataGridView1.Columns.Remove("FirstName");
            if (dataGridView1.Columns.Contains("LastName"))
                dataGridView1.Columns.Remove("LastName");
            if (dataGridView1.Columns.Contains("PhoneNumber"))
                dataGridView1.Columns.Remove("PhoneNumber");
            if (dataGridView1.Columns.Contains("Email"))
                dataGridView1.Columns.Remove("Email");
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void searchBy_Username()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Username", search_txt.Text);

            var check = Player.searchAllInfoPlayer("*", dict);
            if (!check.Key)
                return;

            this.SetDataGridView((SqlDataAdapter) check.Value);
        }

        private void getAllInfoPlayer()
        {
            var check = Player.getAllInfoPlayer();
            if (!check.Key)
                return;

            this.SetDataGridView((SqlDataAdapter)check.Value);
        }

        private void searchBy_Score()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Score", search_txt.Text);

            var check = Player.searchAllInfoPlayer("*", dict);
            if (!check.Key)
                return;

            this.SetDataGridView((SqlDataAdapter) check.Value);
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            if (search_by_cmb.Text == "")
                this.getAllInfoPlayer();

            if(search_by_cmb.SelectedIndex == 0)
                this.searchBy_Username();
            if(search_by_cmb.SelectedIndex == 1)
                this.searchBy_Score();
        }

        private void search_by_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_txt.Text = "";
            search_txt.Enabled = true;
            search_lbl.Visible = true;
            this.search_txt_TextChanged(sender, e);
        }
    }
}
