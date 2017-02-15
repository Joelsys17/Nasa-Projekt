using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace NasaProjekt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        //Kör att man kan flytta klassen

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)

        {

            webBrowser1.Navigate("https://www.youtube.com/embed/qzMQza8xZCc?autoplay=1");
            webBrowser2.Navigate("https://www.youtube.com/embed/UdmHHpAsMVw?autoplay=1");
        }

       
        
        private void NewsFeedButton(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel4.Visible = true;         
            panel4.Refresh();

            }

        private void CalendarButton(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel2.Visible = true;
            panel2.Location =  new Point (151, 11);

        }

    


        private void StreamButton2(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel7.Visible = true;
            panel7.Location = new Point(151, 11);
        }

        private void ForumButton(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = false;
            panel7.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(151, 11);

           
        }
        private void MinimizeWindow(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Close();
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser3.Navigate("localhost");
        }
    }
}
