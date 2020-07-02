using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caractivity
{
    public partial class Form1 : Form
    {
        Lexus Le;
        BMW Bm;
        Toyota To;
        Mercedes Me;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Le = new Lexus("LexusName", LexusPicture);
            Bm = new BMW("BMWName", BMWPicture);
            To = new Toyota("ToyotaName", ToyotaPicture);
            Me = new Mercedes("MercedesName", MercedesPicture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (Le.Picture.Location.Y < 600 &&
               Bm.Picture.Location.Y< 600 &&
                To.Picture.Location.Y< 600 &&
                Me.Picture.Location.Y < 600)
            {
                Le.Move(rand.Next(2, 20));
                Bm.Move(rand.Next(2, 20));
                To.Move(rand.Next(2, 20));
                Me.Move(rand.Next(2, 20));
            }

            else
            {
                string winner = "";

                for (int i = 0; i < 4; i++)
                {
                    if (Le.Picture.Location.Y >= 600)
                    {
                        winner = Le.Name;
                    }
                    else if (Le.Picture.Location.Y >= 600)
                    {
                        winner = Bm.Name;
                    }
                    else if (To.Picture.Location.Y >= 600)
                    {
                        winner = To.Name;
                    }
                    else if (Me.Picture.Location.Y >= 600)
                    {
                        winner = Me.Name;
                    }
                    else
                    {
                        winner = "Something wents wrong!";
                    }

                }
                MessageBox.Show("The race is finished and the winner is" + winner);
            }
        }
    }
}

       
    

