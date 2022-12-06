using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //connecting to MYSQL client
using System.IO;


namespace LotusFlora
{
    public partial class StockManagement : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");   //phpMYAdmin Database connection
        MySqlCommand command;   //MYSQL Command
        public StockManagement()
        {
            InitializeComponent();
        }

        public void FillDGV()    //getting data from the selected database to data grid view
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM blacklotus.stock_tbl", connection);   // Select * Query for data grid view
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);  // Getting data 
            DataTable table = new DataTable();
            adapter.Fill(table);           // display data in a table
            dgv.RowTemplate.Height = 60;   //row heigh = 60
            dgv.AllowUserToAddRows = false;  // auto row inserting = false
            dgv.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();     //showing images in an image column
            imgCol = (DataGridViewImageColumn)dgv.Columns[5];                   //defining the image column no in database table
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgv.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();    //open an file
            opf.Filter = "Choose Image (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";       //filtering image types 
            if (opf.ShowDialog() == DialogResult.OK)     
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);   
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();   //hide the current window
            AdminPanel panel = new AdminPanel();   //switching windows
            panel.ShowDialog();
        }
        private void Clear()
        {
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtAStock.Clear();
            
        }

       
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string radbtn = "";    // radio button categories

            if (radbtnBou.Checked)
            {
                radbtn = "Flower Bouquet";
            }
            if (radbtnDeco.Checked)
            {
                radbtn = "Decorations";
            }
            if (radbtnMemo.Checked)
            {
                radbtn = "Memorial Flower Bouquet";
            }
            if (radbtnVase.Checked)
            {
                radbtn = "Flower Vases";
            }

            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms,pictureBox2.Image.RawFormat);
            byte[] img = ms.ToArray();     //saving the image

            String insertQuery = "INSERT INTO blacklotus.stock_tbl (stock_id, category, name, price, A_stock, image) VALUES (@id, @category, @name, @price, @astock, @img)";   
            // stock insertingquery

            connection.Open();
            command = new MySqlCommand(insertQuery, connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@category", MySqlDbType.VarChar, 50);
            command.Parameters.Add("@name", MySqlDbType.VarChar, 100);
            command.Parameters.Add("@price", MySqlDbType.Double);
            command.Parameters.Add("@astock", MySqlDbType.Int32);
            command.Parameters.Add("@img", MySqlDbType.Blob);

            command.Parameters["@id"].Value = txtID.Text;
            command.Parameters["@category"].Value = radbtn;
            command.Parameters["@name"].Value = txtName.Text;
            command.Parameters["@price"].Value = txtPrice.Text;
            command.Parameters["@astock"].Value = txtAStock.Text;
            command.Parameters["@img"].Value = img;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Record Inserted!");
                Clear();
            }
            else
            {
                MessageBox.Show("Please Check whethe alll fields are filled, Data Not Inserted!");
            }
            connection.Close();
            FillDGV();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            string radbtn = "";

            if (radbtnBou.Checked)
            {
                radbtn = "Flower Bouquet";
            }
            if (radbtnDeco.Checked)
            {
                radbtn = "Decorations";
            }
            if (radbtnMemo.Checked)
            {
                radbtn = "Memorial Flower Bouquet";
            }
            if (radbtnVase.Checked)
            {
                radbtn = "Flower Vases";
            }

            //when the data grid view row click

            Byte[] img = (Byte[])dgv.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox2.Image = Image.FromStream(ms);   // image display in the picture box

            txtID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            radbtn = dgv.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            txtAStock.Text = dgv.CurrentRow.Cells[4].Value.ToString();  //values to the text boxes
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string radbtn = "";

            if (radbtnBou.Checked)
            {
                radbtn = "Flower Bouquet";
            }
            if (radbtnDeco.Checked)
            {
                radbtn = "Decorations";
            }
            if (radbtnMemo.Checked)
            {
                radbtn = "Memorial Flower Bouquet";
            }
            if (radbtnVase.Checked)
            {
                radbtn = "Flower Vases";
            }

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM blacklotus.stock_tbl WHERE stock_id = @id", connection);  //find button query 
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtID.Text;

                MySqlDataAdapter da = new MySqlDataAdapter(command);

                connection.Open();

                DataTable table = new DataTable();   //if admin click the relavant stock info it will automatically view on following text boxes
                da.Fill(table);

                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Record Not Found!");
                    Clear();


                }
                else
                {
                    txtID.Text = table.Rows[0][0].ToString();
                    radbtn = table.Rows[0][1].ToString();
                    txtName.Text = table.Rows[0][2].ToString();
                    txtPrice.Text = table.Rows[0][3].ToString();
                    txtAStock.Text = table.Rows[0][4].ToString();

                    byte[] img = (byte[])table.Rows[0][5];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox2.Image = Image.FromStream(ms);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            byte[] img = ms.ToArray();

            String updateQuery = "UPDATE blacklotus.stock_tbl SET stock_id = @id,name = @name, price = @price, A_stock = @astock, image = @img WHERE stock_id = @id";
            //update query

            connection.Open();
            command = new MySqlCommand(updateQuery, connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@name", MySqlDbType.VarChar, 100);
            command.Parameters.Add("@price", MySqlDbType.Double);
            command.Parameters.Add("@astock", MySqlDbType.Int32);
            command.Parameters.Add("@img", MySqlDbType.Blob);

            command.Parameters["@id"].Value = txtID.Text;
            command.Parameters["@name"].Value = txtName.Text;
            command.Parameters["@price"].Value = txtPrice.Text;
            command.Parameters["@astock"].Value = txtAStock.Text;
            command.Parameters["@img"].Value = img;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Record Updated!");
                Clear();
            }
            else
            {
                MessageBox.Show("Data Not Updated!");
            }
            connection.Close();
            FillDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM blacklotus.stock_tbl WHERE stock_id = @id", connection); // delete query for stock management
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtID.Text;

                MySqlDataAdapter da = new MySqlDataAdapter(command);

                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record DELETED!");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message);
            }
            finally
            {
                connection.Close();
                FillDGV();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnClearall_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
