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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Register cust = new Register();  //reffering the business layer class
                cust.Contact = Convert.ToInt32(textBox1.Text);
                cust.Custfname = textBox2.Text;
                cust.Custlname = textBox3.Text;
                cust.Address = textBox4.Text;
                cust.Email = textBox5.Text;

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")   // if admin provide empty values
                {
                    MessageBox.Show("Please Fill all fields", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else if (cust.insert() > 0)  // if admin did not provide empty values
                {
                    MessageBox.Show("Customer Registered Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)   // if admin use different data type, showing an exception
            {
                MessageBox.Show("ERROR : Check the contact number - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Clear();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Register cust = new Register();
                cust.Contact = Convert.ToInt32(textBox1.Text);
                cust.Custfname = textBox2.Text;
                cust.Custlname = textBox3.Text;
                cust.Address = textBox4.Text;
                cust.Email = textBox5.Text;

                if (cust.Update()>0)
                {
                    MessageBox.Show("Customer Successfully UPDATED!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Register cust = new Register();
                cust.Contact = Convert.ToInt32(textBox1.Text);

                if(cust.Delete()>0)
                {
                    MessageBox.Show("Customer DELETED!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                Register cust = new Register();
                cust.Contact = Convert.ToInt32(textBox1.Text);   //selcted variable for find csutomer data
                if (cust.Find())   // if customer is in the system
                {
                    textBox2.Text = cust.Custfname;
                    textBox3.Text =cust.Custlname;
                    textBox4.Text = cust.Address;
                    textBox5.Text =cust.Email;
                }
                else    // if customer is not in the system
                {
                    MessageBox.Show("Customer Record Not Found!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockManagement formstock = new StockManagement();
            formstock.ShowDialog();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm formorder = new OrderForm();
            formorder.ShowDialog();
        }

        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.ForeColor = Color.FloralWhite;
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.ForeColor = Color.Black;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Out", "LogOut", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Hide();
            Login formLog = new Login();
            formLog.ShowDialog();
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAdmin formAdmin = new CreateAdmin();
            formAdmin.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void lblAdmin_MouseEnter(object sender, EventArgs e)
        {
            lblAdmin.ForeColor = Color.Crimson;
        }

        private void lblAdmin_MouseLeave(object sender, EventArgs e)
        {
            lblAdmin.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminPanel_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
