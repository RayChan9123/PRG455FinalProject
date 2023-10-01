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
    public partial class CarsDetail : Form
    {
        int carIdLocal;

        public CarsDetail(int carID)
        {
            InitializeComponent();

            carIdLocal = carID;

            if(carID == 1)
            {
                car1PictureBox.Visible = true;
                carDescript1TextBox.Visible = true;
                car2PictureBox.Visible = false;
                car2TextBox.Visible = false;
                car3PictureBox.Visible = false;
                car3TextBox.Visible = false;
                car4PictureBox.Visible = false;
                car4TextBox.Visible = false;
                car5PictureBox.Visible = false;
                car5TextBox.Visible = false;
            }
            else if(carID == 2)
            {
                car1PictureBox.Visible = false;
                carDescript1TextBox.Visible = false;
                car2PictureBox.Visible = true;
                car2TextBox.Visible = true;
                car3PictureBox.Visible = false;
                car3TextBox.Visible = false;
                car4PictureBox.Visible = false;
                car4TextBox.Visible = false;
                car5PictureBox.Visible = false;
                car5TextBox.Visible = false;
            }
            else if(carID == 3)
            {
                car1PictureBox.Visible = false;
                carDescript1TextBox.Visible = false;
                car2PictureBox.Visible = false;
                car2TextBox.Visible = false;
                car3PictureBox.Visible = true;
                car3TextBox.Visible = true;
                car4PictureBox.Visible = false;
                car4TextBox.Visible = false;
                car5PictureBox.Visible = false;
                car5TextBox.Visible = false;
            }
            else if(carID == 4)
            {
                car1PictureBox.Visible = false;
                carDescript1TextBox.Visible = false;
                car2PictureBox.Visible = false;
                car2TextBox.Visible = false;
                car3PictureBox.Visible = false;
                car3TextBox.Visible = false;
                car4PictureBox.Visible = true;
                car4TextBox.Visible = true;
                car5PictureBox.Visible = false;
                car5TextBox.Visible = false;
            }
            else
            {
                car1PictureBox.Visible = false;
                carDescript1TextBox.Visible = false;
                car2PictureBox.Visible = false;
                car2TextBox.Visible = false;
                car3PictureBox.Visible = false;
                car3TextBox.Visible = false;
                car4PictureBox.Visible = false;
                car4TextBox.Visible = false;
                car5PictureBox.Visible = true;
                car5TextBox.Visible = true;
            }
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            GetData getData = new GetData(carIdLocal);
            getData.ShowDialog();
        }
    }
}
