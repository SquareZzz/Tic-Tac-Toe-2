using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tick_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private bool KreisAnDerReihe;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    if (MousePosition.X <= 200 && MousePosition.Y <= 200 && MousePosition.X >= 0)
                    {
                        linksoben = true;

                    }
                    else if (MousePosition.X <= 400 && MousePosition.Y <= 200 && MousePosition.X >= 200)
                    {
                        mitteoben = true;
                    }
                    else if (MousePosition.X <= 600 && MousePosition.Y <= 200 && MousePosition.X >= 400)            //oben
                    {
                        rechtsoben = true;
                    }
                    else if (MousePosition.X <= 200 && MousePosition.Y <= 400 && MousePosition.Y >= 200)
                    {
                        mittelinks = true;
                    }
                    else if (MousePosition.X <= 400 && MousePosition.Y <= 400 && MousePosition.Y >= 200 && MousePosition.X >= 200)
                    {
                        mittemitte = true;
                    }
                    else if (MousePosition.X <= 600 && MousePosition.Y <= 400 && MousePosition.Y >= 200 && MousePosition.X >= 400)          // mitte
                    {
                        mitterechts = true;
                    }
                    else if (MousePosition.X <= 200 && MousePosition.Y <= 600 && MousePosition.Y >= 400 && MousePosition.X >= 0)
                    {
                        untenlinks = true;
                    }
                    else if (MousePosition.X <= 400 && MousePosition.Y <= 600 && MousePosition.Y >= 400 && MousePosition.X >= 200)
                    {
                        untenmitte = true;
                    }
                    else if (MousePosition.X <= 600 && MousePosition.Y <= 600 && MousePosition.Y >= 400 && MousePosition.X >= 400)                      //unten
                    {
                        untenrechts = true;
                    }
                    break;


            }
            switch (MouseButtons)
            {
                case MouseButtons.Right:
                    if (MousePosition.X <= 200 && MousePosition.Y <= 200 && MousePosition.X >= 0)
                    {
                        linksobenK = true;

                    }
                    else if (MousePosition.X <= 400 && MousePosition.Y <= 200 && MousePosition.X >= 200)
                    {
                        mitteobenK = true;
                    }
                    else if (MousePosition.X <= 600 && MousePosition.Y <= 200 && MousePosition.X >= 400)            //oben
                    {
                        rechtsobenK = true;
                    }
                    else if (MousePosition.X <= 200 && MousePosition.Y <= 400 && MousePosition.Y >= 200)
                    {
                        mittelinksK = true;
                    }
                    else if (MousePosition.X <= 400 && MousePosition.Y <= 400 && MousePosition.Y >= 200 && MousePosition.X >= 200)
                    {
                        mittemitteK = true;
                    }
                    else if (MousePosition.X <= 600 && MousePosition.Y <= 400 && MousePosition.Y >= 200 && MousePosition.X >= 400)          // mitte
                    {
                        mitterechtsK = true;
                    }
                    else if (MousePosition.X <= 200 && MousePosition.Y <= 600 && MousePosition.Y >= 400 && MousePosition.X >= 0)
                    {
                        untenlinksK = true;
                    }
                    else if (MousePosition.X <= 400 && MousePosition.Y <= 600 && MousePosition.Y >= 400 && MousePosition.X >= 200)
                    {
                        untenmitteK = true;
                    }
                    else if (MousePosition.X <= 600 && MousePosition.Y <= 600 && MousePosition.Y >= 400 && MousePosition.X >= 400)                      //unten
                    {
                        untenrechtsK = true;
                    }
                    break;





            }
            Invalidate();
        }

        private bool linksoben, mitteoben, rechtsoben, mittelinks, mittemitte, mitterechts, untenlinks, untenmitte, untenrechts;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                loesche = true;
            }
        }

        

        private bool linksobenK, mitteobenK, rechtsobenK, mittelinksK, mittemitteK, mitterechtsK, untenlinksK, untenmitteK, untenrechtsK;
      
        private bool loesche = false;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, 200 ,0 ,10 ,600);
            e.Graphics.FillRectangle(Brushes.Black, 400, 0, 10, 600);
            e.Graphics.FillRectangle(Brushes.Black, 0, 200, 600, 10);
            e.Graphics.FillRectangle(Brushes.Black, 0, 400, 600, 10);
            if(loesche == true)
            {
                e.Graphics.Clear(Color.White);
               
                linksoben = false;
                mittelinks = false;
                mitteoben = false;
                rechtsoben = false;
                mittemitte = false;
                mitterechts = false;
                untenlinks = false;
                untenmitte = false;
                untenrechts = false;
                linksobenK = false;
                mittelinksK = false;
                mitteobenK = false;
                rechtsobenK = false;
                mittemitteK = false;
                mitterechtsK = false;
                untenlinksK = false;
                untenmitteK = false;
                untenrechtsK = false;
                Invalidate();
                loesche = false;
            }
           
            if (linksoben == true)
            {
                e.Graphics.DrawEllipse(new Pen(Brushes.Red ,10), new RectangleF(5, 5, 180, 180));
            }
           if(mitteoben == true)
            {
                e.Graphics.DrawEllipse(new Pen(Brushes.Red, 10), new RectangleF(215,5, 180, 180));
                            }
            if (rechtsoben == true )
            {
                e.Graphics.DrawEllipse(new Pen(Brushes.Red, 10), new RectangleF(415, 5, 180, 180));
            }
            if (mittelinks == true)
            {
                e.Graphics.DrawEllipse(new Pen(Brushes.Red, 10), new RectangleF(5, 205, 180, 180));
            }
            if (mittemitte == true)
            {
                e.Graphics.DrawEllipse(new Pen(Brushes.Red, 10), new RectangleF(215, 205, 180, 180));
            }
            if (mitterechts == true )
            {
                e.Graphics.DrawEllipse(new Pen(Brushes.Red, 10), new RectangleF(415,205, 180, 180));
            }
            if (untenlinks == true )
            {
                e.Graphics.DrawEllipse(new Pen(Brushes.Red, 10), new RectangleF(5, 405, 180, 180));
            }
            if (untenmitte == true )
            {
                e.Graphics.DrawEllipse(new Pen(Brushes.Red, 10), new RectangleF(215, 405, 180, 180));
            }
            if (untenrechts == true)
            {
                e.Graphics.DrawEllipse(new Pen(Brushes.Red, 10), new RectangleF(415, 405, 180, 180));
            }// Kreis
            if (linksobenK == true)
            {
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 5, 5, 195, 195);
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 5, 195, 195, 5);
            }
            if (mitteobenK == true )
            {
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 205, 5, 395, 195);
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 205, 195, 395, 5);
            }
            if (rechtsobenK == true )
            {
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 405, 5, 595, 195);//3
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 405, 195, 595, 5);
            }
            if (mittelinksK == true)
            {
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 5, 205, 195, 395);
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 5, 395, 195, 205);
            }
            if (mittemitteK == true )
            {
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 205, 205, 395, 395);
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 205, 395, 395, 205);
            }
            if (mitterechtsK == true)
            {
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 405, 205, 595, 395);//3
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 405, 395, 595, 205);
            }
            if (untenlinksK == true)
            {
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 5, 405, 195, 595);
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 5, 595, 195, 405);
            }
            if (untenmitteK == true)
            {
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 205, 405, 395, 595);
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 205, 595, 395, 405);
            }
            if (untenrechtsK == true)
            {
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 405, 405, 595, 595);
                e.Graphics.DrawLine(new Pen(Brushes.Red, 10), 405, 595, 595, 405);
            }

           
        }

       
    }
}
