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
    public partial class PanelAdmin : Form
    {
        private Player player;

        public PanelAdmin(Player player)
        {
            this.player = player;
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            EarthGame earthGame_form = new EarthGame();
            this.Hide();
            earthGame_form.ShowDialog();

            this.Close();
        }

        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            firstName_txt.Text = player.get_Firstname();
            lastName_txt.Text = player.get_Lastname();
            userName_txt.Text = player.get_Username();
            pass_txt.Text = player.get_Password();
            email_txt.Text = player.get_Email();
            phoneNumber_txt.Text = player.get_PhoneNumber();

            firstName_txt.Enabled = false;
            lastName_txt.Enabled = false;
            userName_txt.Enabled = false;
            pass_txt.Enabled = false;
            email_txt.Enabled = false;
            phoneNumber_txt.Enabled = false;
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            save_btn.Visible = true;
            cancel_btn.Visible = true;
            change_btn.Visible = false;

            firstName_txt.Enabled = true;
            lastName_txt.Enabled = true;
           // userName_txt.Enabled = true;
            pass_txt.Enabled = true;
            email_txt.Enabled = true;
            phoneNumber_txt.Enabled = true;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            save_btn.Visible = false;
            cancel_btn.Visible = false;
            change_btn.Visible = true;

            firstName_txt.Enabled = false;
            lastName_txt.Enabled = false;
            // userName_txt.Enabled = false;
            pass_txt.Enabled = false;
            email_txt.Enabled = false;
            phoneNumber_txt.Enabled = false;
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }


        private bool validation_Username()
        {
            if (String.IsNullOrWhiteSpace(userName_txt.Text))
            {
                userNameHelpText.Text = "* Username is required";
                return false;
            }

            var check = Player.validation_UserName(userName_txt.Text);
            if (!check.Key)
            {
                userNameHelpText.Text = check.Value;
                return false;
            }

            return true;
        }

        private bool validation_Email()
        {
            if (String.IsNullOrWhiteSpace(email_txt.Text))
            {
                emailHelpText.Text = "* Email is required";
                return false;
            }

            var check = Player.validation_Email(email_txt.Text);
            if (!check.Key)
            {
                emailHelpText.Text = check.Value;
                return false;
            }

            return true;
        }

        private bool validation_PhoneNumber()
        {
            if (String.IsNullOrWhiteSpace(phoneNumber_txt.Text))
            {
                phoneHelpText.Text = "* PhoneNumber is required";
                return false;
            }

            var check = Player.validation_PhoneNumber(phoneNumber_txt.Text);
            if (!check.Key)
            {
                phoneHelpText.Text = check.Value;
                return false;
            }

            return true;
        }

        private bool validation_Password()
        {
            if (String.IsNullOrWhiteSpace(pass_txt.Text))
            {
                passHelpText.Text = "* Password is required";
                return false;
            }

            return true;
        }

        private void reset_HelpTexts()
        {
            userNameHelpText.Text = "";
            emailHelpText.Text = "";
            phoneHelpText.Text = "";
            passHelpText.Text = "";
        }

        private bool ValidationForm()
        {
            this.reset_HelpTexts();
            bool check = true;

            if (this.player.get_Email() != email_txt.Text && !validation_Email())
                check = false;
            if (this.player.get_PhoneNumber() != phoneNumber_txt.Text && !validation_PhoneNumber())
                check = false;
            if (this.player.get_Password() != pass_txt.Text && !validation_Password())
                check = false;

            return check;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (!ValidationForm())
                return;

            Player.PlayerinfoStruct p = new Player.PlayerinfoStruct();
            if (this.player.get_Email() != email_txt.Text)
                p.email = email_txt.Text;
            if (this.player.get_PhoneNumber() != phoneNumber_txt.Text)
                p.phoneNumber = phoneNumber_txt.Text;
            if (this.player.get_Password() != pass_txt.Text)
                p.password = pass_txt.Text;
            if (this.player.get_Firstname() != firstName_txt.Text)
                p.firsName = firstName_txt.Text;
            if (this.player.get_Lastname() != lastName_txt.Text)
                p.lastName = lastName_txt.Text;


            var check = this.player.edit(p);
            if (!check.Key)
            {
                MessageBox.Show(check.Value, "Error!");
                return;
            }

            MessageBox.Show("The information has been successfully updated");
            this.cancel_btn_Click(sender, e);
        }
    }

    
}
