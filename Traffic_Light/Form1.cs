using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traffic_Light
{
    public partial class frmTrafficLight : Form
    {
        public frmTrafficLight()
        {

           // int num = 1;
            
            InitializeComponent();

        }

        private void frmTrafficLight_Load(object sender, EventArgs e)
        {




            //lblOne.Visible = true;
            //lblTwo.Visible = false;
           // lblThree.Visible = false;

            lblStop.ForeColor = Color.Red;
            lblWait.ForeColor = Color.Yellow;
            lblGo.ForeColor = Color.Green;
            //lblStop.ForeColor = Color.FromArgb(255,255,255);



            /* picStart1.Visible = true;
             PicRed1.Visible = false;
             picYello1.Visible = false;
             picGreen1.Visible = false;*/



            /*picStart2.Visible = true;
            picStart3.Visible = true;
            picStart4.Visible = true;*/

            PicRed1.Visible = true;
            picYello1.Visible = false;
            picGreen1.Visible = false;

            picRed2.Visible = true;
            picYellow2.Visible = false;
            picGreen2.Visible = false;

            picRed3.Visible = true;
            picYellow3.Visible = false;
            picGreen3.Visible = false;

            picRed4.Visible = true;
            picGreen4.Visible = false;
            picYellow4.Visible = false;

            lblStop.Visible = true;
            lblWait.Visible = false;
            lblGo.Visible = false;


            lblSLPolice.BackColor = Color.FromArgb(178, 34, 34);
            lblSLPolice.ForeColor = Color.White;
  
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (PicRed1.Visible == true && picRed2.Visible == true && picRed3.Visible == true && picRed4.Visible == true)
            {

                PicRed1.Visible = false;
                picYello1.Visible = true;
                picGreen1.Visible = false;

                picRed2.Visible = false;
                picYellow2.Visible = true;
                picGreen2.Visible = false;

                picRed3.Visible = false;
                picYellow3.Visible = true;
                picGreen3.Visible = false;

                picRed4.Visible = false;
                picYellow4.Visible = true;
                picGreen4.Visible = false;


                lblWait.Visible = true;
                lblStop.Visible = false;
                lblGo.Visible = false;


            }

            else if (picYello1.Visible == true && picYellow2.Visible == true && picYellow3.Visible == true && picYellow4.Visible == true)
            {




                picYello1.Visible = false;
                picGreen1.Visible = true;
                PicRed1.Visible = false;

                picYellow2.Visible = false;
                picGreen2.Visible = true;
                picRed2.Visible = false;

                picYellow3.Visible = false;
                picGreen3.Visible = true;
                picRed3.Visible = false;

                picYellow4.Visible = false;
                picGreen4.Visible = true;
                picRed4.Visible = false;

                lblGo.Visible = true;
                lblWait.Visible = false;
                lblStop.Visible = false;


                // lblOne.ForeColor = Color.Red;



            }

            else
            {
                PicRed1.Visible = true;
                picRed2.Visible = true;
                picRed3.Visible = true;
                picRed4.Visible = true;

                lblStop.Visible = true;
                lblGo.Visible = false;
                lblWait.Visible = false;



            }

        }

        private void lblGo_Click(object sender, EventArgs e)
        {

        }

        private void tmrLogo_Tick(object sender, EventArgs e)
        {
            lblSLPolice.Visible = !lblSLPolice.Visible;

        }

        private void PicRed1_Click(object sender, EventArgs e)
        {

        }
       }
          
            
}
    


