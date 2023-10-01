using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455FInalProject
{
    public partial class Search : Form
    {
        int carId;

        public Search()
        {
            InitializeComponent();       
        }
        private void Search_Load(object sender, EventArgs e)
        {
            SqlConnection conStr = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\prg455\\PRG455FInalProject\\CarRentalDatabase.mdf;Integrated Security=True");
            conStr.Open();
            SqlCommand cmd = new SqlCommand("Select * from CarsDataTable", conStr);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
           
            conStr.Close();

            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            carDataGridView.DataSource = dt;
        }

        private void carIdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (carIdTextbox.Text == string.Empty)
            {
                MessageBox.Show("No ID input!");
            }
            else
            {
                carId = Convert.ToInt32(carIdTextbox.Text);

                if (carId < 1 || carId > 5)
                {
                    MessageBox.Show("The ID you inputted does not exist! ");
                    carIdTextbox.Text = string.Empty;
                }
                else
                {
                    CarsDetail carsDetail = new CarsDetail(carId);
                    carsDetail.Show();
                }
            }           
        }
    }
}

//create database's tables
//Show cars availabe in stock by connecting to the database
//allow user to input the wanted car
//when confirm btn was click, new window opens
// new windows should shows selected car's pic and description
//allow user to book the car or return to last form.
