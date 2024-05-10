using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaptainHook
{
    public partial class RegionDrawingForm : Form
    {
        private Point startPoint;
        private Point endPoint;
        private bool drawing;

        public Rectangle SelectedRegion { get; private set; }
        private Point selectedCoordinate;

        public Point SelectedCoordinate
        {
            get { return selectedCoordinate; }
        }

        public RegionDrawingForm()
        {
            //InitializeComponent();
            InitializeForm();
            this.MouseClick += RegionDrawingForm_MouseClick;
        }

        private void InitializeForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 0.2; // Set opacity to approximately 20%
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Screen.PrimaryScreen.Bounds.Location;
            this.Size = Screen.PrimaryScreen.Bounds.Size;

            this.MouseDown += RegionDrawingForm_MouseDown;
            this.MouseMove += RegionDrawingForm_MouseMove;
            this.MouseUp += RegionDrawingForm_MouseUp;
        }

        private void RegionDrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            drawing = true;
        }

        private void RegionDrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                endPoint = e.Location;
                this.Invalidate();
            }
        }
        private void RegionDrawingForm_MouseClick(object sender, MouseEventArgs e)
        {
            // Capture the coordinates where the user clicked
            selectedCoordinate = e.Location;
            MessageBox.Show(e.X.ToString()+" - "+e.Y.ToString());
        }
        private void RegionDrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                endPoint = e.Location;
                drawing = false;
                SelectedRegion = new Rectangle(
                    Math.Min(startPoint.X, endPoint.X),
                    Math.Min(startPoint.Y, endPoint.Y),
                    Math.Abs(startPoint.X - endPoint.X),
                    Math.Abs(startPoint.Y - endPoint.Y));

                this.DialogResult = DialogResult.OK;
                //DisplaySelectedRegion();
                this.Close();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawRectangle(pen, SelectedRegion);
            }
        }
    }
}
