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
    public partial class CreateAdmin : Form
    {
        public CreateAdmin()
        {
            InitializeComponent();
        }

        private void lblBack_MouseEnter(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.FloralWhite;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtEmail.Clear();
            txtPswrd.Clear();
            txtFname.Focus();
        }

        private void lblClear_MouseEnter(object sender, EventArgs e)
        {
            lblClear.ForeColor = Color.FloralWhite;
        }

        private void lblClear_MouseLeave(object sender, EventArgs e)
        {
            lblClear.ForeColor = Color.Black;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel panel = new AdminPanel();
            panel.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            txtEmail.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtPswrd.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SignIn admin = new SignIn();   // reffering the business layer class
                admin.Email = txtEmail.Text;
                admin.Fname = txtFname.Text;
                admin.Lname = txtLname.Text;
                admin.Password = txtPswrd.Text;

                if (txtEmail.Text == "" || txtFname.Text == "" || txtLname.Text == "" || txtPswrd.Text == "" )   // if admin provide empty values
                {
                    MessageBox.Show("Please enter all fields", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else if (admin.AdminInsert() > 0)   // if inserted all required information
                {
                    MessageBox.Show("Added Successfully", "Admin Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SignIn admin = new SignIn();
                admin.Email = txtEmail.Text;
                admin.Fname = txtFname.Text;
                admin.Lname = txtLname.Text;
                admin.Password = txtPswrd.Text;

                if (admin.AdminUpdate() > 0)
                {
                    MessageBox.Show("Successfully UPDATED!", "Admin Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SignIn admin = new SignIn();
                admin.Email = txtEmail.Text;   ///find by admin email adress to delete

                if (admin.AdminDelete() > 0)
                {
                    MessageBox.Show("Profile DELETED!", "Admin Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SignIn admin = new SignIn();
                admin.Email = txtEmail.Text;   // search admin information using email address

                if (admin.AdminFind())
                {
                    txtFname.Text = admin.Fname;
                    txtLname.Text = admin.Lname;
                    txtPswrd.Text = admin.Password;
                   
                }
                else
                {
                    MessageBox.Show("Record Not Found!", "Admin Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
