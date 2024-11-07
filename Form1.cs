using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        private List<User> users;

        public Form1()
        {
            InitializeComponent();

            users = new List<User>
            {
                new User("admin", "admin123", "Admin"),
                new User("hasan", "hasan123"),
                new User("amin", "amin123")
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            lblMessage.Visible = true;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Pls enter again!";
                return;
            }

            try
            {
                User authenticatedUser = users.FirstOrDefault(u => u.Username == username.Trim() && u.Password == password.Trim());

                if (authenticatedUser != null)
                {
                    lblMessage.Text = "Login successful!"; 
                }
                else
                {
                
                    lblMessage.Text = "Invalid username or password.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred: " + ex.Message;
            }


        }
    }
}
