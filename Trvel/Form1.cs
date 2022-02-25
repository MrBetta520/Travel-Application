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
using System.Configuration;
using System.Text.RegularExpressions;

namespace Trvel
{
    public partial class Main : Form
    {
        TravelRepository repository;                                 
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            groupBoxLogon.Visible = false;
            panelLogin.Visible = false;
            repository = new TravelRepository();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            groupBoxLogon.Visible = true;
            panelLogin.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtName.Text) &&
               !string.IsNullOrWhiteSpace(txtPassword.Text) &&
               !string.IsNullOrWhiteSpace(txtRepassword.Text) &&
               !string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    var newUser = new UserRegistration();
                    if (IsValidUserName(txtName.Text))
                    {
                        newUser.UserName = txtName.Text;
                    }
                    else
                    {
                        MessageBox.Show("User name must be have at least:\n · 8 characters long\n · 1 uppercase & 1 lowercase character \n · No special symble");
                        txtName.Focus();
                        return;
                    }

                    if (IsValidPassword(txtPassword.Text))
                    {
                        newUser.UserPassword = txtPassword.Text;
                    }
                    else
                    {
                        MessageBox.Show("Password must be have at least: \n · 8 characters long \n · 1 uppercase & 1 lowercase character \n · 1 special symble");
                        txtPassword.Focus();
                        return;
                    }

                    newUser.UserRepassword = txtRepassword.Text;
                    newUser.Email = txtEmail.Text;
                    repository.AddUser(newUser);
                    MessageBox.Show("Your registration is completed. Please log in.");
                    RegistrationClear();

                    groupBoxLogon.Visible = false;
                    panelLogin.Visible = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // This method is used to check if the password and repassword are the same.
        private void txtRepassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRepassword.Text)
            {
                MessageBox.Show("Password is not matching!");
                txtRepassword.Focus();
                return;
            }
        }

        private void RegistrationClear()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtRepassword.Clear();
            txtEmail.Clear();
        }

        // This method is used to check if the user name and password are matched. If they are matched, jump to booking page, otherwise display error message.
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TravelDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [dbo].[UserRegistration] where UserName = @userName and UserPassword = @password", conn);
            cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtUserPassword.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if(dt.Rows.Count > 0)
            {
                this.Hide();
                form2 f2 = new form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password.");
            }
            
        }
        private bool IsValidPassword(string password)
        {
            return (password.Length > 8 &&
                password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsSymbol) &&
                password.Any(char.IsDigit));
        }
        private bool IsValidUserName(string userName)
        {
            return (userName.Length > 8 &&
                userName.Any(char.IsUpper) &&
                userName.Any(char.IsLower) &&
                !userName.Any(char.IsSymbol));
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex emailFormat = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if(txtEmail.Text.Length > 0)
            {
                if(!emailFormat.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Invalid Email address");
                    txtEmail.SelectAll();
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void btnLogIn1_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            groupBoxLogon.Visible = false;
            
        }

        //private void txtName_Validating(object sender, CancelEventArgs e)
        //{
        //    Regex nameFormat = new Regex(@"^(?=.{3,15}$)([A-Za-z0-9][._()\[\]-]?)*$");
        //    if (txtName.Text.Length > 0)
        //    {
        //        if (!nameFormat.IsMatch(txtName.Text))
        //        {
        //            MessageBox.Show("User name must be have at least:\n · 5 characters long, 12 characters less\n · uppercase, lowercase or digital character \n · No special symble");
        //            txtName.SelectAll();
        //            e.Cancel = true;
        //            return;
        //        }
        //    }
        //}

        //private void txtPassword_Validating(object sender, CancelEventArgs e)
        //{
        //    Regex nameFormat = new Regex(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%&+=])(?=\\s+$).{6,}$");
        //    if (txtPassword.Text.Length > 0)
        //    {
        //        if (!nameFormat.IsMatch(txtPassword.Text))
        //        {
        //            MessageBox.Show("Password must be have at least:\n · 6 characters long\n · 1 uppercase character \n · 1 lowercase character \n · 1 digital character \n · 1 special symble \n · No spaces");
        //            txtPassword.SelectAll();
        //            e.Cancel = true;
        //            return;
        //        }
        //    }
        //}
    }
}
