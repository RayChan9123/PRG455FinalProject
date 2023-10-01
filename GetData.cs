using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455FInalProject
{
    public partial class GetData : Form
    {

        int carIdLocal, rentalDays, customerID;
        
        public GetData(int carID)
        {
            InitializeComponent();
            Random rnd = new Random();
            int num = rnd.Next();
            customerID = num;
            carIdLocal = carID;
        }

        private void phoneNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void creditCardTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            DateTime date1 = pickUpDateTimePicker.Value.Date;
            DateTime date2 = dropOffDateTimePicker.Value.Date;

            TimeSpan dtDiff = date2 - date1;
            rentalDays = dtDiff.Days;

            double totalCost;

            if (rentalDays < 0)
            {
                MessageBox.Show("Error, you may have inputted wrong date!");
            } 
            else
            {
                if (carIdLocal == 1)
                {
                    totalCost = rentalDays * 100 * 1.13;
                }
                else if (carIdLocal == 2) 
                {
                    totalCost = rentalDays * 120 * 1.13;
                }
                else if (carIdLocal == 3)
                {
                    totalCost = rentalDays * 130 * 1.13;
                }
                else if(carIdLocal == 4)
                {
                    totalCost = rentalDays * 100 * 1.13;
                }
                else
                {
                    totalCost = rentalDays * 110 * 1.13;
                }
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                int phoneNo = Convert.ToInt32(phoneNoTextBox.Text);
                int creditCardNo = Convert.ToInt32(creditCardTextBox.Text);
                int bookingID = customerID + 11;

                SqlConnection conStr = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\prg455\\PRG455FInalProject\\CarRentalDatabase.mdf;Integrated Security=True");
                conStr.Open();

                //modify cars quantity in db by -1
                SqlCommand sqlUpdateCarCmd = new SqlCommand("UPDATE CarsDataTable SET QuanityOnStock=QuanityOnStock-1 WHERE CarID=" + carIdLocal, conStr);
                sqlUpdateCarCmd.ExecuteNonQuery();

                //input customer info in db
                SqlCommand sqlAddCustomerInfoCmd = new SqlCommand("INSERT INTO CustomerInfoTable VALUES (@CustomerID,@FIrstName,@LastName,@PhoneNo,@CreditCardData)", conStr);
                sqlAddCustomerInfoCmd.Parameters.AddWithValue("@CustomerID", customerID);
                sqlAddCustomerInfoCmd.Parameters.AddWithValue("@FirstName", firstName);
                sqlAddCustomerInfoCmd.Parameters.AddWithValue("@LastName", lastName);
                sqlAddCustomerInfoCmd.Parameters.AddWithValue("@PhoneNo", phoneNo);
                sqlAddCustomerInfoCmd.Parameters.AddWithValue("@CreditCardData", creditCardNo);
                sqlAddCustomerInfoCmd.ExecuteNonQuery();

                

                //input booking info in db
                SqlCommand sqlAddBookingInfoCmd = new SqlCommand("INSERT INTO BookingsTable VALUES(@BookingID,@CarID,@CustomerID,@PickUpDate,@DropOffDate,@TotalCost)", conStr);
                sqlAddBookingInfoCmd.Parameters.AddWithValue("@BookingID", bookingID);
                sqlAddBookingInfoCmd.Parameters.AddWithValue("@CarID", carIdLocal);
                sqlAddBookingInfoCmd.Parameters.AddWithValue("@CustomerID", customerID);
                sqlAddBookingInfoCmd.Parameters.AddWithValue("@PickUpDate", date1);
                sqlAddBookingInfoCmd.Parameters.AddWithValue("@DropOffDate", date2);
                sqlAddBookingInfoCmd.Parameters.AddWithValue("@TotalCost", totalCost);
                sqlAddBookingInfoCmd.ExecuteNonQuery();
                conStr.Close();

                MessageBox.Show("Booking Information already saved in database.");

                ClientInfo clientInfo = new ClientInfo();
                clientInfo.CustomerIDprop = customerID;
                clientInfo.FirstNamep = firstName;
                clientInfo.LastNamep = lastName;
                clientInfo.BookingIDprop = bookingID;
                clientInfo.CarIDprop = carIdLocal;
                clientInfo.PickUpTime = date1;
                clientInfo.DropOffTime = date2;
                clientInfo.TotalCostp = totalCost;

                Receipt receipt = new Receipt(clientInfo);
                receipt.ShowDialog();
            }            
        }
    }

    public class ClientInfo
    {
        private int customerIDprop, bookingIDprop, carIDprop;
        private string firstNamep, lastNamep;
        private double totalCostp;
        private DateTime pickUpTime, dropOffTime;

        public int CustomerIDprop
        {
            get { return customerIDprop; }
            set { customerIDprop = value; }
        }

        public int BookingIDprop
        {
            get { return bookingIDprop; }
            set { bookingIDprop = value; }
        }

        public int CarIDprop
        {
            get { return carIDprop; }
            set { carIDprop = value; }
        }

        public string FirstNamep
        {
            get { return firstNamep; }
            set { firstNamep = value; }
        }

        public string LastNamep
        {
            get { return lastNamep; }
            set { lastNamep = value; }
        }

        public double TotalCostp
        {
            get { return totalCostp; }
            set { totalCostp = value; }
        }

        public DateTime PickUpTime
        {
            get { return pickUpTime; }
            set { pickUpTime = value; }
        }

        public DateTime DropOffTime
        {
            get { return dropOffTime; }
            set { dropOffTime = value; }
        }
    }
}
