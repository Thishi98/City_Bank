using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using BusinessLayer;

namespace LotusFlora
{
    public partial class OrderForm : Form
    {
        
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtNo.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtType.Clear();
            txtMsg.Clear();
            txtQtx.Clear();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.FloralWhite;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Black;
        }

        private void lblMin_MouseEnter(object sender, EventArgs e)
        {
            lblMin.ForeColor = Color.FloralWhite;
        }

        private void lblMin_MouseLeave(object sender, EventArgs e)
        {
            lblMin.ForeColor = Color.Black;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel panel = new AdminPanel();
            panel.ShowDialog();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void calculate()
        { 
            
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            string radbtn = "";

            if (radBirthday.Checked)
            {
                radbtn = "Birthday Decoration";
            }
            if (radWedding.Checked)
            {
                radbtn = "Wedding Decoration";
            }
            if (radParty.Checked)
            {
                radbtn = "Party Decoration";
            }
            if (radFuneral.Checked)
            {
                radbtn = "Memorial Services";
            }
            if (radOther.Checked)
            {
                radbtn = "Other Occatioin";
            }

            try
            {

                Order ord = new Order();   //reffering business layer class
                ord.Contact = Convert.ToInt32(txtNo.Text);
                ord.Custnam_name = txtName.Text;
                ord.Address = txtAddress.Text;
                ord.Function = radbtn;
                ord.Flower_type = txtType.Text;
                ord.Message = txtMsg.Text;
                ord.Quantity = Convert.ToInt32(txtQtx.Text);
                ord.P_order = dateTimePicker.Text;  // order table variables 

                if (ord.OInsert() > 0)  // if all text boxes are completed
                {
                    MessageBox.Show("Order has Placed Successfully!", "Order Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : Fill all text fields or "  + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Clear();
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Order ord = new Order();
                ord.Contact = Convert.ToInt32(txtNo.Text);
                ord.Custnam_name = txtName.Text;
                ord.Address = txtAddress.Text;
                ord.Flower_type = txtType.Text;
                ord.Message = txtMsg.Text;
                ord.Quantity = Convert.ToInt32(txtQtx.Text);
                ord.P_order = dateTimePicker.Text;

                if (ord.OUpdate() > 0) 
                {
                    MessageBox.Show("Successfully UPDATED!", "Order Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    FillDGV();  //auto refresh when update an order information
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
           
                string radbtn = "";

                if (radBirthday.Checked)
                {
                    radbtn = "Birthday Decoration";
                }
                if (radWedding.Checked)
                {
                    radbtn = "Wedding Decoration";
                }
                if (radParty.Checked)
                {
                    radbtn = "Party Decoration";
                }
                if (radFuneral.Checked)
                {
                    radbtn = "Memorial Services";
                }
                if (radOther.Checked)
                {
                    radbtn = "Other Occatioin";
                }
            


                try
                {
                    Order ord = new Order();
                    ord.Contact = Convert.ToInt32(txtNo.Text);   // searchin an order by contact no that customer provied
                    if (ord.OFind())
                    {
                        txtName.Text = ord.Custnam_name;
                        txtAddress.Text = ord.Address;
                        radbtn = ord.Function;
                        txtType.Text = ord.Flower_type;
                        txtMsg.Text = ord.Message;
                        txtQtx.Text = ord.Quantity.ToString();
                   
                }
                    else
                    {
                        MessageBox.Show("Record Not Found!", "Order Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Order ord = new Order();
                ord.Contact = Convert.ToInt32(txtNo.Text);

                if (ord.ODelete() > 0)
                {
                    MessageBox.Show("Order DELETED!", "Order Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    FillDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void FillDGV()
        {
            try
            {
                Order ord = new Order();
                dgv.RowTemplate.Height = 40;
                dgv.AllowUserToAddRows = false;
                dgv.DataSource = ord.SearchAll().Tables[0];  // if the table is empty, fill by getting data from order table in the database 
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            string radbtn = "";

            if (radBirthday.Checked)
            {
                radbtn = "Birthday Decoration";
            }
            if (radWedding.Checked)
            {
                radbtn = "Wedding Decoration";
            }
            if (radParty.Checked)
            {
                radbtn = "Party Decoration";
            }
            if (radFuneral.Checked)
            {
                radbtn = "Memorial Services";
            }
            if (radOther.Checked)
            {
                radbtn = "Other Occatioin";
            }

            txtNo.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txtName.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            radbtn = dgv.CurrentRow.Cells[4].Value.ToString();
            txtType.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            txtMsg.Text = dgv.CurrentRow.Cells[6].Value.ToString();
            txtQtx.Text = dgv.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
