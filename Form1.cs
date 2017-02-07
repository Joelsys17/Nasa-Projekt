using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication3
{
        public partial class Form1 : Form
        {
            private string conn;
            private MySqlConnection connect;
            public Form1()
            {
            InitializeComponent();            
        }

        private void db_connection()
            {
                try
                {
                    conn = "Server=localhost;Database=sys17;Uid=root;Pwd=;";
                    connect = new MySqlConnection(conn);
                    connect.Open();
                }
                catch (MySqlException e)
                {
                throw e;
                }
            }

            private bool validate_login(string user, string pass)
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from members where username=@username and password=@password";
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Connection = connect;
                MySqlDataReader login = cmd.ExecuteReader();
                if (login.Read())
                {
                    connect.Close();
                    return true;
                }
                else
                {
                connect.Close();
                return false;
                }
            }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }


        /// Gör klassen dragbar^ Ändra inte den koden.



        private void MainWindow(object sender, EventArgs e)
        {

        }

        private void BigLabel2(object sender, EventArgs e)
        {

        }


        private void LoginButton1(object sender, EventArgs e)
        {
            if (slide2.Left == 609)
            {
                slide1.Visible = false;
                slide1.Left = 609;
              
                slide2.Visible = false;
                slide2.Left = 23;
                slide2.Visible = true;
                slide2.Refresh();
            }

        }

        private void RegisterButton1(object sender, EventArgs e)
        {
            if (slide1.Left == 609)
            {
                slide2.Visible = false;
                slide2.Left = 609;

                slide1.Visible = false;
                slide1.Left = 23;
                slide1.Visible = true;
                slide1.Refresh();

            }

        }

        private void LogInButton2(object sender, EventArgs e)
        {
            string user = UserLogin.Text;
            string pass = UserLoginPass.Text;

            if (user == "" || pass == "")
            {
                label2.Text = ("Var snäll och och fyll i båda fösterna.");
                return;
            }

        bool r = validate_login(user, pass);
            if (r)
            {
                label2.Text = ("Hej Marcus!");
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Show();
            }
            else
                label2.Text = ("Användarnamnet eller lössenordet är inkorrekt!");
        }


        private void RegisterButton2(object sender, EventArgs e)
        {

        }

        private void Textbox1(object sender, EventArgs e)
        {

        }

        private void Textbox2(object sender, EventArgs e)
        {

        }
        private void Textbox3(object sender, EventArgs e)
        {

        }

        private void BigLabel1(object sender, EventArgs e)
        {

        }

        private void SmallLabel4(object sender, EventArgs e)
        {
    }

        private void LogInButton(object sender, EventArgs e)
        {
            if (slide2.Left == 609)
            {
                slide1.Visible = false;
                slide1.Left = 609;

                slide2.Visible = false;
                slide2.Left = 23;
                slide2.Visible = true;
                slide2.Refresh();
            }
        }

        private void RegisterButton(object sender, EventArgs e)
        {

            if (slide1.Left == 609)
            {
                slide2.Visible = false;
                slide2.Left = 609;

                slide1.Visible = false;
                slide1.Left = 23;
                slide1.Visible = true;
                slide1.Refresh();

            }

        }

        private void MinimizeWindow(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void Slide1(object sender, PaintEventArgs e)
        {

        }
        private void Textbox4(object sender, EventArgs e)
        {

        }
        private void Textbox5(object sender, EventArgs e)
        {

        }

        private void BigLabel3(object sender, EventArgs e)
        {

        }

        private void SmallLabel1(object sender, EventArgs e)
        {

        }

        private void SmallLabel2(object sender, EventArgs e)
        {

        }

        private void SmallLabel3(object sender, EventArgs e)
        {

        }

        private void SmallLabel5(object sender, EventArgs e)
        {

        }

        private void Slide2(object sender, PaintEventArgs e)
        {

        }
    }
        }



