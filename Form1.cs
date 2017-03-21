using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        targetprop target = new targetprop();
        targetprop tuser = new targetprop();
        private void load(ref targetprop hum) 
        {
            hum.armo=int.Parse(Tarmo.Text);
            hum.armu=int.Parse(Tarmu.Text);
            hum.back=int.Parse(TBack.Text);
            hum.bustB = int.Parse(BustB.Text);
            hum.butt = int.Parse(Tbutt.Text);
            hum.calf = int.Parse(Tcalf.Text);
            hum.hand = int.Parse(Thand.Text);
            hum.hips = int.Parse(Thip.Text);
            hum.knee = int.Parse(Tknee.Text);
            hum.thigh = int.Parse(TThigh.Text);
            hum.thighs = int.Parse(TThighs.Text);
            hum.waist = int.Parse(Twaist.Text);
        
        
        }
        private void show(targetprop h) 
        {  Tarmo.Text=h.armo.ToString();
            Tarmu.Text=h.armu.ToString();

            TBack.Text=h.back.ToString();
            BustB.Text=h.bustB.ToString();
            Tbutt.Text=h.butt.ToString();
            Tcalf.Text=h.calf.ToString();
            Thand.Text=h.hand.ToString();
            Thip.Text=h.hips.ToString();
            Tknee.Text = h.knee.ToString();
            TThigh.Text=h.thigh.ToString();
            TThighs.Text = h.thighs.ToString();
            Twaist.Text=h.waist.ToString();
        
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            target.bustB = 93; target.back = 82; target.waist = 83; target.hips = 98; target.butt = 103; target.thighs = 99; target.thigh = 73; target.knee = 43; target.calf = 41; target.mochPa = 30; target.armo = 30; target.armu = 25; target.hand = 17;
            tuser.bustB = 103;
            tuser.back = 93;
            tuser.waist = 100;
            tuser.hips = 111;
            tuser.butt = 115;
            tuser.thighs = 109;
            tuser.thigh = 84;
            tuser.knee = 50;
            tuser.calf = 43;
            tuser.mochPa = 30;
            tuser.armo = 33; tuser.armu = 26; tuser.hand = 17;
            
            
            Pen myPen = new Pen(Color.Red);
            // Creates a brush that fills in solid blue.
            SolidBrush myBrush = new SolidBrush(Color.Blue);


        }
        private class targetprop
        {public int heigth;
            public int bustB;
            public int back;
            public int waist;
            public int hips;
            public int butt;
            public int thighs;
            public int thigh;
            public int knee;
            public int calf;
            public int armo;
            public int armu;
            public int hand;
            public int mochPa;
        
        }
        private void drawtarget(ref Graphics g, targetprop target, targetprop tuser, Pen myPen)
        { //target*****************************************

            Point[] ppdast = new Point[3];
            ppdast[0] = new Point(60, 197);
            ppdast[1] = new Point(53, 229);
            ppdast[2] = new Point(39, 285);
            g.DrawCurve(myPen, ppdast);


            Point[] p = new Point[12];
            double pss;
            int norm = 0;
            int user = 0;
            //Point[] p = new Point[10];
            p[0] = new Point(61, 142);
            //89 normal
            //94 user
            norm = target.bustB;
            user = tuser.bustB;
            pss = (double)user / (double)norm;
            pss = pss * 95;
            pss = pss - 95;
            pss = pss / 2;
            pss = -1 * pss;
            pss = pss + 61;
            //((((101 / 110) * 95) - 95) / 2) + 61
            p[1] = new Point((int)pss, 157);
            //norm 74
            //user 79
            norm = target.back;
            user = tuser.back;
            pss = (double)user / (double)norm;
            pss = pss * 93;
            pss = pss - 93;
            pss = pss / 2;
            pss = -1 * pss;
            pss = pss + 62;
            //((((108 / 115) * 93) - 93) / 2) + 62
            p[2] = new Point((int)pss, 183);
            //norm 75
            //user 81

            norm = target.waist;
            user = tuser.waist;
            pss = (double)user / (double)norm;
            pss = pss * 80;
            pss = pss - 80;
            pss = pss / 2;
            pss = -1 * pss;
            pss = pss + 71;
            //((((98 / 94) * 80) - 80) / 2) + 71
            p[3] = new Point((int)pss, 225);
            //norm 83
            //user 87
            norm = target.hips;
            user = tuser.hips;
            pss = (double)user / (double)norm;
            pss = pss * 107;
            pss = pss - 107;
            pss = pss / 2;
            pss = -1 * pss;
            pss = pss + 57;
            //((((120 / 115) * 107) - 107) / 2) + 57
            p[4] = new Point((int)pss, 263);

            //norm 92
            //user 99
            norm = target.butt;
            user = tuser.butt;
            pss = (double)user / (double)norm;
            pss = pss * 120;
            pss = pss - 120;
            pss = pss / 2;
            pss = -1 * pss;
            pss = pss + 51;

            p[5] = new Point((int)pss, 298);
            //norm 92
            //user 100
            norm = target.thighs;
            user = tuser.thighs;
            pss = (double)user / (double)norm;
            pss = pss * 120;
            pss = pss - 120;
            pss = pss / 2;
            pss = -1 * pss;
            pss = pss + 52;

            p[6] = new Point((int)pss, 318);


            //norm 69
            //user 77
            norm = target.thigh;
            user = tuser.thigh;
            pss = (double)user / (double)norm;
            pss = pss * 52;
            pss = pss - 52;
            pss = pss / 1;
            pss = -1 * pss;
            pss = pss + 56;

            p[7] = new Point((int)pss, 340);

            //norm 49
            //user 56
            norm = target.knee;
            user = tuser.knee;
            pss = (double)user / (double)norm;
            pss = pss * 37;
            pss = pss - 37;
            pss = pss / 1;
            pss = -1 * pss;
            pss = pss + 71;

            p[8] = new Point((int)pss, 410);

            //p[9] = new Point((int)pss, 410);

            //norm 33
            //user 35
            norm = target.calf;
            user = tuser.calf;
            pss = (double)user / (double)norm;
            pss = pss * 38;
            pss = pss - 38;
            pss = pss / 1;
            pss = -1 * pss;
            pss = pss + 72;


            p[9] = new Point((int)pss, 470);

            //norm 23
            //user 23
            norm = target.mochPa;
            user = tuser.mochPa;
            pss = (double)user / (double)norm;
            pss = pss * 18;
            pss = pss - 18;
            pss = pss / 1;
            pss = -1 * pss;
            pss = pss + 89;


            p[10] = new Point((int)pss, 534);
            p[11] = new Point(89, 555);


            g.DrawCurve(myPen, p);
            //g.DrawLine(myPen, p[1], p[5]);
            Point[] pr = new Point[12];
            for (int i = 0; i <= 11; i++)
            {
                pr[i].X = (109 - p[i].X) + 109;
                pr[i].Y = p[i].Y;

            }
            g.DrawCurve(myPen, pr);

            if (toolStripButton6.Checked)
            {
                Pen newpen = new Pen(Color.Navy);
                if (myPen.Color == Color.Red) { newpen.Color = Color.Pink; }
                else
                {
                    newpen.Color = Color.Navy;
                    
                }
                newpen.Width = 5;
                g.DrawLine(newpen, p[1], p[5]);
            }
            //g.DrawLine(myPen, pr[1], pr[5]);

            Point[] pd = new Point[5];
            pd[0] = new Point(37, 122);
            //29 normal
            //31 user
            norm = target.armo;
            user = tuser.armo;
            pss = (double)user / (double)norm;
            pss = pss * 26;
            pss = pss - 26;
            pss = pss / 1;
            pss = -1 * pss;
            pss = pss + 36;

            pd[1] = new Point((int)pss, 164);
            //norm 23
            //user 23
            norm = target.armu;
            user = tuser.armu;
            pss = (double)user / (double)norm;
            pss = pss * 29;
            pss = pss - 29;
            pss = pss / 1;
            pss = -1 * pss;
            pss = pss + 28;
            //((((108 / 115) * 93) - 93) / 2) + 62
            pd[2] = new Point((int)pss, 216);
            //norm 14
            //user 15

            norm = target.hand;
            user = tuser.hand;
            pss = (double)user / (double)norm;
            pss = pss * 19;
            pss = pss - 19;
            pss = pss / 1;
            pss = -1 * pss;
            pss = pss + 24;
            //((((98 / 94) * 80) - 80) / 2) + 71
            pd[3] = new Point((int)pss, 278);

            pd[4] = new Point(21, 286);


            g.DrawCurve(myPen, pd);
            for (int i = 0; i <= 4; i++)
            {
                pd[i].X = (109 - pd[i].X) + 109;
                pd[i].Y = pd[i].Y;

            }
            g.DrawCurve(myPen, pd);

            //******************************************************* norm dast

            //8******************************naf

            Point[] pnaf = new Point[3];
            pnaf[0] = new Point(107, 245 + 20);
            pnaf[1] = new Point(110, 246 + 20);
            pnaf[2] = new Point(111, 243 + 20);
            g.DrawCurve(myPen, pnaf);


            //****************************
            Point[] pvasat = new Point[5];
            pvasat[0] = new Point(86, 294);
            pvasat[1] = new Point(98, 303);
            pvasat[2] = new Point(109, 317);
            pvasat[3] = new Point(120, 303);
            pvasat[4] = new Point(132, 294);
            g.DrawCurve(myPen, pvasat);
            //*********************lapa
            Point[] plapa = new Point[9];
            plapa[0] = new Point(106, 317);
            plapa[1] = new Point(109, 330);
            plapa[2] = new Point(106, 375);
            plapa[3] = new Point(109, 412);
            plapa[4] = new Point(106, 439);
            plapa[5] = new Point(109, 468);
            plapa[6] = new Point(106, 515);
            plapa[7] = new Point(109, 543);
            plapa[8] = new Point(106, 553);
            g.DrawCurve(myPen, plapa);

            Point[] pnaf2 = new Point[3];
            pnaf2[0] = new Point(108, 309);
            pnaf2[1] = new Point(109, 313);
            pnaf2[2] = new Point(108, 317);
            g.DrawCurve(myPen, pnaf2);

            

            for (int i = 0; i <= 2; i++)
            {
                ppdast[i].X = (109 - ppdast[i].X) + 109;
                ppdast[i].Y = ppdast[i].Y;

            }
            g.DrawCurve(myPen, ppdast);

            Point[] pgardan = new Point[5];
            pgardan[0] = new Point(89, 81);
            pgardan[1] = new Point(84, 96);
            pgardan[2] = new Point(68, 103);
            pgardan[3] = new Point(45, 110);
            pgardan[4] = new Point(38, 119);
            g.DrawCurve(myPen, pgardan);

            for (int i = 0; i <= 4; i++)
            {
                pgardan[i].X = (109 - pgardan[i].X) + 109;
                pgardan[i].Y = pgardan[i].Y;

            }
            g.DrawCurve(myPen, pgardan);

            for (int i = 0; i <= 8; i++)
            {
                plapa[i].X = (109 - plapa[i].X) + 109;
                plapa[i].Y = plapa[i].Y;

            }
            g.DrawCurve(myPen, plapa);
            myPen.Width = 1; myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            if (toolStripButton6.Checked)
            {
                g.DrawLine(myPen, new Point(1, 94), new Point(457, 94));
                g.DrawLine(myPen, new Point(1, 120), new Point(457, 120));
                g.DrawLine(myPen, new Point(1, 142), new Point(457, 142));
                g.DrawLine(myPen, new Point(1, 157), new Point(457, 157));
                g.DrawLine(myPen, new Point(1, 183), new Point(457, 183));
                g.DrawLine(myPen, new Point(1, 225), new Point(457, 225));
                g.DrawLine(myPen, new Point(1, 263), new Point(457, 263));
                g.DrawLine(myPen, new Point(1, 298), new Point(457, 298));
                g.DrawLine(myPen, new Point(1, 318), new Point(457, 318));
                g.DrawLine(myPen, new Point(1, 340), new Point(457, 340));
                g.DrawLine(myPen, new Point(1, 410), new Point(457, 410));
                g.DrawLine(myPen, new Point(1, 470), new Point(457, 470));
                g.DrawLine(myPen, new Point(1, 534), new Point(457, 534));
            }
        
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int x = 71;
            int y = 218;
            Pen myPenB = new Pen(Color.Blue);
            Pen myPenB2 = new Pen(Color.Navy);
            Pen myPenR = new Pen(Color.Red);
            Pen myPenG = new Pen(Color.Green);
            Pen myPenRx = new Pen(Color.Red);
            Pen myPenR2 = new Pen(Color.Navy);
            Pen myPenY = new Pen(Color.Yellow);
            myPenR2.Width = 2;
            myPenY.Width = 1;
            myPenY.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            myPenRx.Width = 1;
            myPenR.Width = 1;
            myPenR.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            Pen myPenW = new Pen(Color.White);
            myPenB.Width = 2;
            Graphics g = pictureBox1.CreateGraphics();
            Rectangle rn = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);

            SolidBrush b = new SolidBrush(Color.White);
            Region r = new Region(rn);
            g.FillRegion(b, r);

            Point[] pi = new Point[3];
            pi[0] = new Point(x, y);
            pi[1] = new Point(x, y);
            pi[2] = new Point(x, y);
            Bitmap mybitmap = new Bitmap(Application.StartupPath + @"\woman23.gif");
            
            string s = "";
            Point pp = new Point(0, 0);
            for (int i = 0; i < mybitmap.Height; i++)
            {
                for (int j = 0; j < mybitmap.Width; j++)
                {
                    if ((i <= 109) && (j >= 545))
                    {
                        mybitmap.SetPixel(i + 109, j, mybitmap.GetPixel(i, j));
                    }
                    Color pixelColor = mybitmap.GetPixel(j, i);
                    if (pixelColor != Color.FromArgb(255, 0, 0, 0))
                    {
                        //write.WriteLine(i + "= white");
                    }
                    else
                    {
                        g.DrawLine(myPenB, new Point(j, i - 1), new Point(j, i));
                        // Rectangle rll=new Rectangle(j,i,j,i);
                        //           s += j.ToString()+","+i.ToString()+"\r\n";
                        if ((j <= 109) && (i >= 545))
                        {
                            //mybitmap.SetPixel(i + 109, j, mybitmap.GetPixel(i, j));
                            g.DrawLine(myPenB, new Point(109-j+109, i - 1), new Point(109-j+109, i));
                        }
                        if ((j <= 44) && (i >= 284) && (i <= 339))
                        {
                            //mybitmap.SetPixel(i + 109, j, mybitmap.GetPixel(i, j));
                            g.DrawLine(myPenB, new Point(109 - j + 109, i - 1), new Point(109 - j + 109, i));
                        }
                        //pp.X = j; pp.Y = i;
                        //write.WriteLine(i + "= black");
                        //MessageBox.Show(i.ToString() +","+j.ToString()+ "black");
                    }
                }
            }
            // richTextBox1.Text = s;
            //g.DrawImage(mybitmap, new Point(0, 0));
            //g.Save();
           









           
      

           

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            toolStripLabel1.Text = e.X.ToString() + "," + e.Y.ToString();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {



        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            
            
                drawtarget(ref g, target, target, new Pen(Color.Red, 2));
          
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            
            
            drawtarget(ref g, target, tuser, new Pen(Color.Green, 2));
          
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            drawtarget(ref g, target, target, new Pen(Color.Red, 2));
          drawtarget(ref g, target, tuser, new Pen(Color.Green, 2));
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Rectangle rn = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);

            SolidBrush b = new SolidBrush(Color.White);
            Region r = new Region(rn);
            g.FillRegion(b, r);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load(ref target);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load(ref tuser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show(target);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show(tuser);
        }
    }
}
