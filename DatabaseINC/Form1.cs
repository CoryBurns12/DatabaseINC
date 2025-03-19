using Microsoft.VisualBasic;
using MySql;
using MySql.Data.MySqlClient;

namespace DatabaseINC
{
    public partial class Form1 : Form
    {
        private MySqlConnection mainconnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            HideButtons();
            TextBox _SERVER = new()
            {
                PlaceholderText = "Server",
                Location = new(271, 45),
                Width = 200,
                ForeColor = Color.Red
            };

            TextBox _UID = new()
            {
                PlaceholderText = "Username",
                Location = new(271, 91),
                Width = 200,
                ForeColor = Color.Red
            };

            TextBox _PW = new()
            {
                PlaceholderText = "Password",
                Location = new(271, 137),
                Width = 200,
                ForeColor = Color.Red,
                PasswordChar = '*'
            };

            Button connectMYSQL = new()
            {
                Text = "Connect",
                Location = new(372, 183),
                Width = 100
            };

            connectMYSQL.Click += (sender, e) =>
            {
                string connectionquery = $"server={_SERVER.Text};uid={_UID.Text};pwd={_PW.Text}";

                while (_SERVER.Text == null || _UID.Text == null || _PW.Text == null)
                {
                    MessageBox.Show("One or more empty fields");
                    return;
                }

                try
                {
                    mainconnection = new MySqlConnection(connectionquery);
                    mainconnection.Open();
                    MessageBox.Show("Connection established!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"ERROR CONNECTING. {ex.Message}");
                }
            };

            Button backbutton = new()
            {
                Text = "Back",
                Location = new(271, 183),
                Width = 100
            };

            backbutton.Click += (sender, e) =>
            {
                _SERVER.Visible = false;
                _UID.Visible = false;
                _PW.Visible = false;

                Connect.Visible = true;
                backbutton.Visible = false;
                connectMYSQL.Visible = false;
                CreateDatabase.Visible = true;
                CreateTable.Visible = true;
            };

            this.Controls.Add(_SERVER);
            this.Controls.Add(_UID);
            this.Controls.Add(_PW);
            this.Controls.Add(backbutton);
            this.Controls.Add(connectMYSQL);
        }

        private void HideButtons()
        {
            Connect.Visible = false;
            CreateDatabase.Visible = false;
            CreateTable.Visible = false;
        }

        private void CreateDatabase_Click(object sender, EventArgs e)
        {
            // Checks if connection is null (which it always will be on first run)
            while (mainconnection == null)
            {
                MessageBox.Show("Connection has not been established. Connect to MYSQL using your login information first.");
                return;
            }

            HideButtons();
            TextBox _DATABASE = new()
            {
                PlaceholderText = "Database Name",
                Location = new(271, 45),
                Width = 200,
                ForeColor = Color.Red
            };

            Button CDBbackbutton = new()
            {
                Text = "Back",
                Location = new(271, 183),
                Width = 100
            };

            Button createdatabase = new()
            {
                Text = "Create",
                Location = new(372, 183),
                Width = 100
            };

            createdatabase.Click += (sender, e) =>
            {
                MySqlCommand CDBCommand = new();
                string cdbname = _DATABASE.Text;

                try
                {
                    CDBCommand.Connection = mainconnection;
                    CDBCommand.CommandText = $"CREATE DATABASE {cdbname}";

                    var execute = CDBCommand.ExecuteNonQuery();

                    MessageBox.Show($"Database {cdbname} created.");
                    _DATABASE.Clear();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"ERROR CREATING DATABASE. {ex.Message}");
                }
            };

            CDBbackbutton.Click += (sender, e) =>
            {
                Connect.Visible = true;
                CreateDatabase.Visible = true;
                CDBbackbutton.Visible = false;
                createdatabase.Visible = false;
                _DATABASE.Visible = false;
                CreateTable.Visible = true;
            };

            this.Controls.Add(_DATABASE);
            this.Controls.Add(createdatabase);
            this.Controls.Add(CDBbackbutton);
        }

        private void CreateTable_Click(object sender, EventArgs e)
        {

            while(mainconnection == null)
            {
                MessageBox.Show("Connection has not been established. Connect to MYSQL using your login information first.");
                return;
            }

            HideButtons();
            TextBox _DBNAME = new()
            {
                PlaceholderText = "Database Name",
                Location = new(271, 91),
                Width = 200,
                ForeColor = Color.Red
            };

            TextBox _TABLENAME = new()
            {
                PlaceholderText = "Table",
                Location = new(271, 45),
                Width = 43,
                ForeColor = Color.Red
            };

            TextBox _VARNAME = new()
            {
                PlaceholderText = "Variable Name",
                Location = new(324, 45),
                Width = 86,
                ForeColor = Color.Red
            };

            ComboBox _VARTYPE = new()
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new(420, 45),
                Width = 50,
                Height = 50,
                MaxLength = 50
            };

            ClutterVars.ArraySort();
            foreach (string type in ClutterVars._DATATYPES)
            {
                _VARTYPE.Items.Add(type);
            }

            Button CTBackbutton = new()
            {
                Text = "Back",
                Location = new(271, 183),
                Width = 100
            };

            Button createtable = new()
            {
                Text = "Create",
                Location = new(372, 183),
                Width = 100
            };

            this.Controls.Add(_DBNAME);
            this.Controls.Add(_TABLENAME);
            this.Controls.Add(_VARNAME);
            this.Controls.Add(_VARTYPE);
            this.Controls.Add(CTBackbutton);
            this.Controls.Add(createtable);
        }
    }
}
