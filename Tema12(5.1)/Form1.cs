using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema12_5._1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);
            int y = 10;
            // Прорисовка текста,
            // выровненного по левому краю. 
            Rectangle rect = new Rectangle(10, y, 400, Font.Height);
            g.DrawRectangle(Pens.Black, rect);
            g.DrawString("текст, выровненный по левому краю", Font, Brushes.Black, rect);
            y += Font.Height + 20;

            // Прорисовка текста,
            // выровненного по правому краю. 

            Font myFont = new Font("Arial", 16,
            FontStyle.Bold | FontStyle.Italic);
            rect = new Rectangle(10, y, 400, myFont.Height);
            g.DrawRectangle(Pens.Black, rect);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far;
            g.DrawString("текст, выровненный по правомукраю", myFont, Brushes.Black, rect, sf);
            y += myFont.Height + 20;
            myFont.Dispose();

            // Прорисовка текста, выровненного по центру. 
            myFont = new Font("Courier New", 12, FontStyle.Underline);
            rect = new Rectangle(10, y, 400, myFont.Height);
            g.DrawRectangle(Pens.Black, rect);
            sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            g.DrawString("текст, выровненный по центру", myFont, Brushes.Black, rect, sf);
            y += myFont.Height + 20;
            myFont.Dispose();


            // Прорисовка многострочного текста. 
            myFont = new Font("Times New Roman", 12);
            rect = new Rectangle(10, y, 120, myFont.Height * 4);
            g.DrawRectangle(Pens.Black, rect);
            String s = "Make it run, Make it right," + "Make it small, Make it fast";
            g.DrawString(s, myFont, Brushes.Black, rect);
            myFont.Dispose();
        }
    }
}
