using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptainHook
{

    public partial class SmallApp : Form
    {

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy,
                                               int cButtons, int dwExtraInfo);
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
                                             string lpWindowName);
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp,
                                                 IntPtr lp);
        private bool isDragging = false;
        private Point lastLocation;
        public SmallApp()
        {
            InitializeComponent();

        }
        public Form1 MainFormReference { get; set; }

        private Form1 mainForm;
        public string LabelText
        {
            get { return labelSmallStatus.Text; }
            set { labelSmallStatus.Text = value; }
        }
        public string LabelTextFishBait
        {
            get { return labelSmallFishBait.Text; }
            set { labelSmallFishBait.Text = value; }
        }
        public string LabelTextToplamOlta
        {
            get { return labelSmallToplamOlta.Text; }
            set { labelSmallToplamOlta.Text = value; }
        }
        public string LabelTextCoordinate
        {
            get { return labelSmallCoordinate.Text; }
            set { labelSmallCoordinate.Text = value; }
        }
        public string LabelTextOltadakiSure
        {
            get { return labelSmallOltadakiSure.Text; }
            set { labelSmallOltadakiSure.Text = value; }
        }
        public string LabelTextPause
        {
            get { return labelSmallPause.Text; }
            set { labelSmallPause.Text = value; }
        }
        // Public method to set button click event
        public void StartButonu(EventHandler eventHandler)
        {
            buttonSmallStart.Click += eventHandler;
        }
        public void StopButonu(EventHandler eventHandler)
        {
            buttonSmallStop.Click += eventHandler;
        }
        public void CloseButonu(EventHandler eventHandler)
        {
            buttonSmallClose.Click += eventHandler;
        }
        public void LocationButonu(EventHandler eventHandler)
        {
            buttonSmallLocation.Click += eventHandler;
        }
        private void SmallApp_Load(object sender, EventArgs e)
        {
            //mainForm = new Form1();
            //mainForm.Show();
            this.Hide();
        }

        private void SmallApp_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
            ////this.Cursor = Cursors.SizeAll;
            //base.OnMouseDown(e);

            //if (e.Button == MouseButtons.Left)
            //{
            //    //this.Cursor = Cursors.Cross;
            //    ReleaseCapture();
            //    SendMessage(Handle, 0xA1, (IntPtr)0x2, IntPtr.Zero);
            //}
        }

        private void SmallApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate the new position of the form
                int deltaX = e.Location.X - lastLocation.X;
                int deltaY = e.Location.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
            //base.OnMouseMove(e);

            //if (e.Button == MouseButtons.Left)
            //{
            //    this.Location = new Point(Cursor.Position.X - this.Width / 2,
            //                              Cursor.Position.Y - this.Height / 2);
            //}
        }

        private void SmallApp_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            //base.OnMouseUp(e);
        }

        private void buttonSmallClose_Click(object sender, EventArgs e)
        {

        }

        private void buttonSmallMaximize_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the SmallApp form
            MainFormReference.Show();
        }

        private void buttonSmallLocation_Click(object sender, EventArgs e)
        {
            MainFormReference.getnewlocation();
        }

        private void labelSmallStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
