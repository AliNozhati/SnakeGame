using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SnakeGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    public static class Globals
    {
        public static DataBase GameDb = new DataBase("SnakeGame", "AliNozhati");
    }

    public class DataBase
    {
        private string name;
        private string password;
        private string path;

        private SqlConnection dbConnection;

        static private string mainDbPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\DataBase\MainDataBase.mdf"));
        static private SqlConnection mainDbConnection = new SqlConnection(
            $@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename={DataBase.mainDbPath};
            Integrated Security=True;Connect Timeout=30"
        );

        public DataBase(string name = null, string pass = null)
        {
            if (name != null && pass != null)
                this.ConnectDb(name, pass);

        }

        // !TODO: try catch
        private KeyValuePair<bool, string> FindDb(string name, string pass)
        {
            KeyValuePair<bool, string> result;

            string query = $"Select * From DataBaseInfo Where name=@name";


            try
            {
                DataBase.mainDbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, DataBase.mainDbConnection);
                sqlCommand.Parameters.AddWithValue("@name", name);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read() && reader["Password"].ToString() == pass)
                    {
                        string pathDb = reader["Path"].ToString();
                        if (pathDb.Length == 0)
                            pathDb = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\DataBase"));

                        result = new KeyValuePair<bool, string>(true, pathDb);
                    }
                    else
                        result = new KeyValuePair<bool, string>(false, "Name or password incorrect!");
                }
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }

            DataBase.mainDbConnection.Close();
            return result;
        }

        public KeyValuePair<bool, string> ConnectDb(string name, string pass)
        {
            var checkExistDb = this.FindDb(name, pass);

            if (!checkExistDb.Key)
                return checkExistDb;

            this.name = name;
            this.password = pass;
            this.path = checkExistDb.Value;

            try
            {
                this.dbConnection = new SqlConnection(
                    $@"Data Source = (LocalDB)\MSSQLLocalDB;
                    AttachDbFilename={this.path}\{ this.name}.mdf;
                    Integrated Security = True; Connect Timeout = 30"
                );
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, $"There is a problem connecting to the database,\n{ex.Message}");
            }

            return new KeyValuePair<bool, string>(true, "The connection to the database was successful");
        }

        public KeyValuePair<bool, object> Select(string columns, string tableName, Dictionary<string, object> dict = null)
        {
            string query = $"SELECT {columns} FROM {tableName} ";
            KeyValuePair<bool, object> result;

            if (dict != null)
            {
                int i = 0;
                query += "WHERE ";
                foreach (var item in dict)
                {
                    if (i++ != 0)
                        query += " AND ";
                    query += $"{item.Key}=@{item.Key}";
                }
            }

            try
            {
                this.dbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, this.dbConnection);
                if (dict != null)
                    foreach (var item in dict)
                        sqlCommand.Parameters.AddWithValue($"@{item.Key}", item.Value);

              //  sqlCommand.ExecuteReader();

              //  SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                        result = new KeyValuePair<bool, object>(true, new SqlDataAdapter(sqlCommand));
                    else
                        result = new KeyValuePair<bool, object>(false, "Any records not found!");
                }
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, object>(false, $"There is a problem connecting to the database,\n{ex.Message}");
            }

            this.dbConnection.Close();
            return result;
        }

        public KeyValuePair<bool, object> SelectByContains(string columns, string tableName, Dictionary<string, object> dict)
        {
            string query = $"SELECT {columns} FROM {tableName} ";
            KeyValuePair<bool, object> result;

            if (dict != null)
            {
                int i = 0;
                query += "WHERE ";
                foreach (var item in dict)
                {
                    if (i++ != 0)
                        query += " OR ";
                    query += $"{item.Key} LIKE @{item.Key}";
                }
            }

            try
            {
                this.dbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, this.dbConnection);
                if (dict != null)
                    foreach (var item in dict)
                        sqlCommand.Parameters.AddWithValue($"@{item.Key}", "%"+item.Value+"%");

              //  sqlCommand.ExecuteReader();

              //  SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                        result = new KeyValuePair<bool, object>(true, new SqlDataAdapter(sqlCommand));
                    else
                        result = new KeyValuePair<bool, object>(false, "Any records not found!");
                }
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, object>(false, $"There is a problem connecting to the database,\n{ex.Message}");
            }

            this.dbConnection.Close();
            return result;
        }

        public KeyValuePair<bool, string> Insert(string tableName, Dictionary<string, object> dict)
        {
            if (dict == null)
                return new KeyValuePair<bool, string>(false, "Values cannot be empty!");

            KeyValuePair<bool, string> result;
            string query, keys = "(", values = "(";
            int i = 0;

            foreach (var item in dict)
            {
                if (i++ != 0)
                {
                    keys += ", ";
                    values += ", ";
                }

                keys += item.Key;
                values += "@" + item.Key;
            }
            keys = keys + ")";
            values = values + ")";

            query = String.Format("Insert Into {0} {1} Values {2}", tableName, keys, values);


            try
            {
                this.dbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, this.dbConnection);
                // or user KeyValuePair
                foreach (var item in dict)
                    sqlCommand.Parameters.AddWithValue($"@{item.Key}", item.Value);

                sqlCommand.ExecuteNonQuery();
                result = new KeyValuePair<bool, string>(true, "succses");
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }

            //con.Open();
            this.dbConnection.Close();
            //con.Close();
            return result;
        }

        public KeyValuePair<bool, string> Update(string tableName, Dictionary<string, object> dictForUpdate, Dictionary<string, object> dictForSelect)
        {
            if (dictForUpdate == null || dictForSelect == null)
                return new KeyValuePair<bool, string>(false, "Values cannot be empty!");

            KeyValuePair<bool, string> result;
            string query, updateValues = "", selected = "";
            int i = 0;

            foreach (var item in dictForUpdate)
            {
                if (i++ != 0)
                    updateValues += ", ";
                updateValues += item.Key + "=@" + item.Key;
            }

            i = 0;
            foreach (var item in dictForSelect)
            {
                if (i++ != 0)
                    selected += " AND ";
                selected += item.Key + "=@" + item.Key;
            }

            query = String.Format("UPDATE {0} SET {1} WHERE {2}", tableName, updateValues, selected);

            try
            {
                this.dbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, this.dbConnection);

                foreach (var item in dictForUpdate)
                    sqlCommand.Parameters.AddWithValue($"@{item.Key}", item.Value);
                foreach (var item in dictForSelect)
                    sqlCommand.Parameters.AddWithValue($"@{item.Key}", item.Value);

                sqlCommand.ExecuteNonQuery();
                result = new KeyValuePair<bool, string>(true, "success");
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }

            // this.dbConnection.Open();
            // exclue
            this.dbConnection.Close();
            //con.Close();
            return result;
        }

        public KeyValuePair<bool, string> Delete(string tableName, int id)
        {
            string query = String.Format("Delete From {0} Where ID={1}", tableName, id);


            //con.Open();
            //com.ExecuteNonQuery();
            //con.Close();
            return new KeyValuePair<bool, string>(true, "");
        }
    }
}
