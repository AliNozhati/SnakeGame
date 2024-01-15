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
    public partial class RegisterForm : Form
    {
        private DataBase _db = new DataBase();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            var check = this._db.ConnectDb("SnakeGame", "AliNozhati");
            if (!check.Key)
            {
                MessageBox.Show(check.Value);
                return;
            }
        }

        private void birthDate_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(birthDate.Value.Year.ToString());
            //DateTimePicker s = new DateTimePicker.ControlCollection();
        /*
            birthDate.FormatChanged()
            Application.CurrentCulture = new CultureInfo("fa-IR");
            radDateTimePicker1.Format = DateTimePickerFormat.Custom;
            radDateTimePicker1.CustomFormat = Application.CurrentCulture.DateTimeFormat.ShortDatePattern;
        */
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

            if (!validation_Username())
                check = false;
            if (!validation_Email())
                check = false;
            if (!validation_PhoneNumber())
                check = false;
            if (!validation_Password())
                check = false;

            return check;
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (!ValidationForm())
                return;

            Player.PlayerinfoStruct p   = new Player.PlayerinfoStruct();
            p.lastName = lastName_txt.Text;
            p.userName = userName_txt.Text;
            p.firsName = firstName_txt.Text;
            p.phoneNumber = phoneNumber_txt.Text;
            p.email = email_txt.Text;
            p.password = pass_txt.Text;

            var check = Player.add(p);
            if (!check.Key)
            {
                MessageBox.Show("sdfasdf");
                return;
            }

            MessageBox.Show("You have successfully registered");
            Form1 main_form = new Form1();
            this.Hide();
            main_form.ShowDialog();
            this.Close();
        }

        private void cnl_btn_Click(object sender, EventArgs e)
        {
            Form1 main_form = new Form1();
            this.Hide();
            main_form.ShowDialog();
            this.Close();
        }
    }


    public class Player
    {
        public Player(string userName = null, string password = null)
        {
            this.Login(userName, password);
        }


        //public void updateInfo(PlayerinfoStruct Params)
        //{
        //    if(Params.userName == "")
        //        MessageBox.Show(Params.userName);
        //}

        static public bool checkExist_UserName(string userName)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Username", userName);

            // TODO: یوزر نیم اگر بیشتر از یکی باشه باید خودم دستی بزنم که این سخته باید مثل قبیا دیکشنری باشه
               return Player.get("Username", Player.tableName, dict).Key;
           // var check = 
           // if (check == true)
             //   return false;
        }

        static public bool checkExist_Email(string email)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Email", email);

            return Player.get("Email", Player.tableName, dict).Key;
        }

        static public bool checkExist_PhoneNumber(string phoneNumber)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("PhoneNumber", phoneNumber);

            return Player.get("PhoneNumber", Player.tableName, dict).Key;
        }

        static public KeyValuePair<bool, string> validation_UserName(string userName)
        {
            if (String.IsNullOrWhiteSpace(userName))
                return new KeyValuePair<bool, string>(false, "Username cannot be empty");

            if (Player.checkExist_UserName(userName))
                return new KeyValuePair<bool, string>(false, "Username already exsits!");

            return new KeyValuePair<bool, string>(true, "validated");
        }

        static public KeyValuePair<bool, string> validation_Email(string email)
        {
            if (String.IsNullOrWhiteSpace(email))
                return new KeyValuePair<bool, string>(false, "Email cannot be empty");

            if(Player.checkExist_Email(email))
                return new KeyValuePair<bool, string>(false, "There is an account with this email");
            
            return new KeyValuePair<bool, string>(true, "validated");
        }

        static public KeyValuePair<bool, string> validation_PhoneNumber(string phoneNumber)
        {
            if (String.IsNullOrWhiteSpace(phoneNumber))
                return new KeyValuePair<bool, string>(false, "PhoneNumber cannot be empty");

            if (Player.checkExist_PhoneNumber(phoneNumber))
                return new KeyValuePair<bool, string>(false, "There is an account with this phoneNumber");

            return new KeyValuePair<bool, string>(true, "validated");
        }

        static public KeyValuePair<bool, string> validationAdd(PlayerinfoStruct parameters)
        {
            KeyValuePair<bool, string> checkValidation;

            checkValidation = Player.validation_UserName(parameters.userName);
            if (!checkValidation.Key)
                return checkValidation;

            checkValidation = Player.validation_Email(parameters.email);
            if (!checkValidation.Key)
                return checkValidation;

            checkValidation = Player.validation_PhoneNumber(parameters.phoneNumber);
            if (!checkValidation.Key)
                return checkValidation;

            return new KeyValuePair<bool, string>(true, "Everything is validated");
        }   

        static public KeyValuePair<bool, string> validationEdit(PlayerinfoStruct parameters)
        {
            KeyValuePair<bool, string> checkValidation;
            //parameters.userName.Length != 0
            if (parameters.userName != null)
            {
                checkValidation = Player.validation_UserName(parameters.userName);
                if (!checkValidation.Key)
                    return checkValidation;
            }

            if (parameters.email != null)
            {
                checkValidation = Player.validation_Email(parameters.email);
                if (!checkValidation.Key)
                    return checkValidation;
            }

            if (parameters.phoneNumber != null)
            {
                checkValidation = Player.validation_PhoneNumber(parameters.phoneNumber);
                if (!checkValidation.Key)
                    return checkValidation;
            }

            return new KeyValuePair<bool, string>(true, "Everything is validated");
        }

        //static public KeyValuePair<bool, string> validationLogin(string userName, string password)
        //{
        //    KeyValuePair<bool, string> checkValidation;

        //    if (userName.Length == 0)

        //    {
        //        checkValidation = Player.validation_UserName(parameters.userName);
        //        if (!checkValidation.Key)
        //            return checkValidation;
        //    }

        //    if (parameters.email.Length != 0)
        //    {
        //        checkValidation = Player.validation_Email(parameters.email);
        //        if (!checkValidation.Key)
        //            return checkValidation;
        //    }

        //    if (parameters.phoneNumber.Length != 0)
        //    {
        //        checkValidation = Player.validation_PhoneNumber(parameters.phoneNumber);
        //        if (!checkValidation.Key)
        //            return checkValidation;
        //    }

        //    return new KeyValuePair<bool, string>(true, "Everything is validated");
        //}        
        
        //static public KeyValuePair<bool, string> validationAdd2(Dictionary<string, object> ditcParams)
        //{
        //    if (!ditcParams.ContainsKey("India") && !Player.validation_UserName(ditcParams['']))
        //        return new KeyValuePair<bool, string>(false, "Username already exists!");
        //    if (!Player.validation_Email(parameters.email))
        //        return new KeyValuePair<bool, string>(false, "There is an account with this email");
        //    if (!Player.validation_PhoneNumber(parameters.phoneNumber))
        //        return new KeyValuePair<bool, string>(false, "There is an account with this phoneNumber");

        //    return new KeyValuePair<bool, string>(true, "Everything is validated");
        //}

        static public KeyValuePair<bool, string> add(PlayerinfoStruct parameters)
        {
            KeyValuePair<bool, string> checkValidate = Player.validationAdd(parameters);
            if (!checkValidate.Key)
                return checkValidate;

            Dictionary<string, object> dict = Player.convert_StructToDict(parameters);
            return Player.db.Insert(Player.tableName, dict);
        }
        
        public KeyValuePair<bool, string> edit(PlayerinfoStruct parameters)
        {
            KeyValuePair<bool, string> checkValidate = Player.validationEdit(parameters);
            if (!checkValidate.Key)
                return checkValidate;

            Dictionary<string, object> dictForUpdate = Player.convert_StructToDict(parameters);
            Dictionary<string, object> dictForSelect = new Dictionary<string, object>();
            dictForSelect.Add("Username", this.userName);

            return Player.db.Update(Player.tableName, dictForUpdate, dictForSelect);
        }        

        public bool delete()
        {
            return true;
        }

        static private KeyValuePair<bool, object> get(string columns, string tableName, Dictionary<string, object> dict = null)
        {
            return Player.db.Select(columns, tableName, dict);
        }

        static public KeyValuePair<bool, object> getAllInfoPlayer(string columns=null)
        {
            if (columns == null)
                columns = "*";
            return Player.get(columns, Player.tableName);
        }        
        
        static public KeyValuePair<bool, object> searchAllInfoPlayer(string columns, Dictionary<string, object> dict)
        {
            return Player.db.SelectByContains(columns, Player.tableName, dict);
        }

        public KeyValuePair<bool, object> Login(string username, string password)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Username", username);
            dict.Add("Password", password);

            KeyValuePair<bool, object> checkPlayer = Player.get("*", Player.tableName, dict);
            if (checkPlayer.Key)
            {
                SqlDataAdapter sqlAdapter = (SqlDataAdapter)checkPlayer.Value;
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                this.userName = dt.Rows[0]["Username"].ToString();
                this.password = dt.Rows[0]["Password"].ToString();
                this.phoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
                this.email = dt.Rows[0]["Email"].ToString();
                this.firtName = dt.Rows[0]["FirstName"].ToString();
                this.lastName = dt.Rows[0]["LastName"].ToString();
                this.score = Convert.ToInt32(dt.Rows[0]["Score"]);
            }

            return checkPlayer;
        }


        //static public int checkLogin(string userName, string password)
        //{
        //    for(int index = 0; index < Player.countPlayer; index++)
        //        if(Player.players[index].userName == userName && Player.players[index].password == password)
        //            return index;
            
        //    return -1;
        //}

        private bool checkToken(string userName, string password)
        {
            if(userName == this.userName && password == this.password)
                return true;
            else
                return false;
        }

        static public Dictionary<string, object> convert_StructToDict(PlayerinfoStruct structure)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();

            if (structure.userName != null)
                dict.Add("Username", structure.userName);
            if(structure.password != null)
                dict.Add("Password", structure.password);
            if(structure.email != null)
                dict.Add("Email", structure.password);
            if(structure.phoneNumber != null)
                dict.Add("PhoneNumber", structure.phoneNumber);
            if(structure.firsName != null)
                dict.Add("FirstName", structure.firsName);
            if(structure.lastName != null)
                dict.Add("LastName", structure.lastName);

            return dict;
        }


        public string get_Username()
        {
            return this.userName;
        }

        public string get_Firstname()
        {
            return this.firtName;
        }
        
        public string get_Lastname()
        {
            return this.lastName;
        }
        
        public string get_Password()
        {
            return this.password;
        }       

        public string get_Email()
        {
            return this.email;
        }       
        
        public string get_PhoneNumber()
        {
            return this.phoneNumber;
        }
        
        public int get_Score()
        {
            return this.score;
        }


        static public int countPlayer = 0;
        private int id;
        private int score;
        private string userName;
        private string password;
        private string firtName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime birthDate;
        static private string tableName = "Player";
        static private DataBase db = Globals.GameDb;
        public struct PlayerinfoStruct
        {
            public string userName;
            public string password;
            public string email;
            public string phoneNumber;
            public string firsName;
            public string lastName;
          //  public DateTime birthDate;
        };
    }
}
