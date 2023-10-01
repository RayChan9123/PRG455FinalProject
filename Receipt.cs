using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455FInalProject
{
    public partial class Receipt : Form
    {
        public Receipt(ClientInfo clientInfo)
        {
            InitializeComponent();

            cusLbl.Text = clientInfo.CustomerIDprop.ToString();
            fnLbl.Text = clientInfo.FirstNamep.ToString();
            lnLbl.Text = clientInfo.LastNamep.ToString();
            bookingLbl.Text = clientInfo.BookingIDprop.ToString();
            carIdLbl.Text = clientInfo.CarIDprop.ToString();
            date1Lbl.Text = clientInfo.PickUpTime.ToString("yyyy-MM-dd");
            date2Lbl.Text = clientInfo.DropOffTime.ToString("yyyy-MM-dd");
            totalCostLbl.Text = clientInfo.TotalCostp.ToString();
        }


    }
}
