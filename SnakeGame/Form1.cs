using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        static private DataBase db = new DataBase("SnakeGame", "AliNozhati");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase("", "");
            var check = db.ConnectDb("SnakeGame", "AliNozhati");

            if (!check.Key)
            {
                MessageBox.Show(check.Value);
            }
        }

        private bool validate_login()
        {
            usernameHelp_lbl.Text = "";
            passHelp_lbl.Text = "";

            bool check = true;

            if(String.IsNullOrEmpty(user_txt.Text))
            {
                usernameHelp_lbl.Text = "* Username is required";
                check = false;
            }
            if(String.IsNullOrEmpty(pass_txt.Text))
            {
                passHelp_lbl.Text = "* Password is required";
                check = false;
            }

            return check;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            bool checkValidation = this.validate_login();
            if (!checkValidation)
                return;
            Player player = new Player();

            var checkLogin = player.Login(user_txt.Text, pass_txt.Text);
            if (!checkLogin.Key)
            {
                checkLoginHelp_lbl.Text = checkLogin.Value.ToString();
                return;
            }

            PanelAdmin panel_admin = new PanelAdmin(player);
            this.Hide();
            panel_admin.ShowDialog();
            this.Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            RegisterForm register_form = new RegisterForm();
            this.Hide();
            register_form.ShowDialog();
            this.Close();
        }

        private void infoGame_btn_Click(object sender, EventArgs e)
        {
            InformationGameForm infoGame_form = new InformationGameForm();
            this.Hide();
            infoGame_form.ShowDialog();

            this.Close();
        }

        private void forget_lbl_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetForm = new ForgetPasswordForm();
            this.Hide();
            forgetForm.ShowDialog();
            this.Close();
        }
    }

    
}