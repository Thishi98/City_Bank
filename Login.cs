using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace LotusFlora
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtMail.Clear();
            txtPswrd.Clear();
            txtMail.Focus();

        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void lblclear_MouseEnter(object sender, EventArgs e)
        {
            lblclear.ForeColor = Color.FloralWhite;
        }

        private void lblclear_MouseLeave(object sender, EventArgs e)
        {
            lblclear.ForeColor = Color.Black;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.FloralWhite;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                try
                {
                    SignIn log = new SignIn();    // reffering the business layer class
                    log.Email = txtMail.Text;     // get email address
                    log.Password = txtPswrd.Text; // get password 

                if (log.Loginn())             // matching emai and password with database
                {
                    MessageBox.Show("LOGIN SUCCESSFUL!", "Signin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AdminPanel panel = new AdminPanel();   //switching to admin panel
                    panel.ShowDialog();
                }
  
                else if (txtMail.Text == "" || txtPswrd.Text == "")
                {
                    MessageBox.Show("Please Enter your Email & Password!", "Sign-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else 
                {
                    MessageBox.Show("Please Enter Valid Email & Password!", "Sign-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
              
        private void txtMail_Validated(object sender, EventArgs e)
        { 
        
          
        }

        

        private void lblExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
