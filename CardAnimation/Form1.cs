using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CardAnimation
{
    public partial class Stars : Form
    {
        public Stars()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Ping);
            Graphics g = this.CreateGraphics();
            Pen constellationConnector = new Pen(Color.Red, 4);
            SolidBrush starStuff = new SolidBrush(Color.White);
            g.Clear(Color.Black);
            /*
            player.Play();
            g.FillEllipse(starStuff, 25, 32, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 62, 90, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 43, 220, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 93, 125, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 726, 607, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 700, 697, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 85, 35, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 309, 197, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 400, 342, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 459, 267, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 579, 69, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 700, 546, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 764, 764, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 583, 400, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 670, 300, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 500, 400, 7, 7);
            Thread.Sleep(500);
            player.Play();

            g.FillEllipse(starStuff, 409, 500, 7, 7);
            Thread.Sleep(500);
            player.Play();
            */
            //CONSTELLATION STAR BREAK

            //1
            g.FillEllipse(starStuff, 500, 30, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //2
            g.FillEllipse(starStuff, 400, 120, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //3
            g.FillEllipse(starStuff, 280, 190, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //4
            g.FillEllipse(starStuff, 380, 230, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //5
            g.FillEllipse(starStuff, 275, 250, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //6
            g.FillEllipse(starStuff, 455, 210, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //7
            g.FillEllipse(starStuff, 255, 255, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //8
            g.FillEllipse(starStuff, 235, 280, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //9
            g.FillEllipse(starStuff, 315, 360, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //10
            g.FillEllipse(starStuff, 335, 295, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //11
            g.FillEllipse(starStuff, 405, 285, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //12
            g.FillEllipse(starStuff, 425, 300, 7, 7);
            Thread.Sleep(500);
            player.Play();

            //13
            g.FillEllipse(starStuff, 485, 340, 7, 7);
            Thread.Sleep(500);

            //Constellation Connectors
            Thread.Sleep(2000);

            g.DrawLine(constellationConnector, 500, 30, 400, 120);
            player.Play();
            Thread.Sleep(500);

            g.DrawLine(constellationConnector, 400, 120, 280, 190);
            player.Play();
            Thread.Sleep(500);

            g.DrawLine(constellationConnector, 280, 190, 380, 230);
            g.DrawLine(constellationConnector, 280, 190, 275, 250);
            player.Play();
            Thread.Sleep(500);

            g.DrawLine(constellationConnector, 455, 210, 380, 230);
            player.Play();
            Thread.Sleep(500);

            g.DrawLine(constellationConnector, 275, 250, 255, 255);
            player.Play();
            Thread.Sleep(500);

            g.DrawLine(constellationConnector, 255, 255, 235, 280);
            player.Play();
            Thread.Sleep(500);

            g.DrawLine(constellationConnector, 235, 280, 315, 360);
            player.Play();
            Thread.Sleep(500);

            g.DrawLine(constellationConnector, 315, 360, 335, 295);
            player.Play();
            Thread.Sleep(500);

            g.DrawLine(constellationConnector, 335, 295, 405, 285);
            player.Play();
            Thread.Sleep(500);

            g.DrawLine(constellationConnector, 405, 285, 425, 300);
            player.Play();
            Thread.Sleep(500);

            g.DrawLine(constellationConnector, 425, 300, 485, 340);
            player.Play();
            Thread.Sleep(500);


            /*Constellation Star Location
             * 1: 500, 30
             * 2: 400, 120
             * 3: 280, 190
             * 4: 380, 230
             * 5: 275, 250
             * 6: 455, 210
             * 7: 255, 255
             * 8: 235, 280
             * 9: 315, 360
             * 10: 335, 295
             * 11: 405, 285
             * 12: 425, 300
             * 13: 485, 340
             */
        }

        private void Stars_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen writingPen = new Pen(Color.Blue, 10);
            g.DrawLine(writingPen, 100, 100, 200, 100);
            g.DrawLine(writingPen, 200, 100, 100, 100);
        }
    }
}
 
 