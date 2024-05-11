using System.Diagnostics;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.Text.RegularExpressions;
using WindowsInput;
using OpenCvSharp;
using Point = System.Drawing.Point;
using System.Drawing;
using System.Drawing.Imaging;
using OpenCvSharp.Extensions;
using System;
using System.IO;
using System.Collections;
using Squirrel;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Net;
namespace CaptainHook
{
    public partial class Form1 : Form
    {
        private List<Point> customCoordinates =
            new List<Point>();  // List to store the custom coordinates
        private List<Point> stoppingPoints =
            new List<Point>();  // List to store stopping points
        private List<int> stoppingPointIndexes =
            new List<int>();  // List to store the indexes of stopping points
        private TransparentForm transparentForm;
        private AnotherTransparentForm TransparentForm2;

        private List<Point> clickCoordinates =
            new List<Point>();  // List to store click coordinates
        private List<Point> clickCoordinates2 =
            new List<Point>();             // List to store click coordinates
        private int clickInterval = 2000;  // Interval between clicks in milliseconds
        private int currentCoordinateIndex =
            0;  // Index of the current coordinate being clicked
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private readonly MMDeviceEnumerator enumerator;
        private WasapiLoopbackCapture loopbackCapture;
        private WaveBuffer waveBuffer;
        private Point savedCoordinate;
        private BufferedWaveProvider bufferedWaveProvider;
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
                                               string lpWindowName);
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp,
                                                 IntPtr lp);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy,
                                               int cButtons, int dwExtraInfo);
        private bool isDragging = false;
        private Point lastCursorPosition;
        private bool isClickAndHoldActive;
        private Rectangle selectedRegion;
        //private string[] originalItems = { };
        private SmallApp smallAppForm;

        public Form1()
        {
            // Form temel giriş.
            InitializeComponent();
            this.KeyPreview = true;  // Set KeyPreview to true
            this.KeyDown += Form1_KeyDown;
            enumerator = new MMDeviceEnumerator();
            this.MouseClick += Form1_MouseClick;
            PopulateOutputDevices();
            MMDeviceEnumerator en = new MMDeviceEnumerator();
        }
        private void PopulateOutputDevices()
        {
            // Sistemde kayıtlı tüm ses çıkış cihazlarının comboboxa eklenmesi fonks.
            comboBoxOutputDevices.Items.Clear();

            foreach (var device in enumerator.EnumerateAudioEndPoints(
                         DataFlow.Render, DeviceState.Active))
            {
                comboBoxOutputDevices.Items.Add(device);
            }

            if (comboBoxOutputDevices.Items.Count > 0)
            {
                comboBoxOutputDevices.SelectedIndex = 0;
            }
        }
        int version = 2026;
        int atilanoltasayisi = 0, tuketilenseaweed = 0, tuketilenbait = 0;


        private void comboBoxOutputDevices_SelectedIndexChanged(object sender,
                                                                EventArgs e)
        { labelStatus.Text = "Çıkış aygıtı - " + comboBoxOutputDevices.SelectedItem.ToString() + " olarak seçildi."; }

        private void LoopbackCaptureOnDataAvailable(object sender,
                                                    WaveInEventArgs waveInEventArgs)
        {

        }

        private void UpdateSoundLevel(float soundLevel) { }

        private void btnSelectRegion_Click(object sender, EventArgs e)
        {
            //// Balık tutma ekranındaki gerginlik barının koordinatlarını sisteme ilk
            //// kayıt ve güncelleme butonu.
            //using (RegionDrawingForm regionDrawingForm = new RegionDrawingForm())
            //{
            //    if (regionDrawingForm.ShowDialog() == DialogResult.OK)
            //    {
            //        selectedRegion = regionDrawingForm.SelectedRegion;

            //        DisplaySelectedRegion();
            //    }
            //}
        }
        string data;
        Point mousekoordinatson;
        private void ButtonSmallStart_Click(object sender, EventArgs e)
        {
            // Handle button click event
            baslatbutonu();
        }
        private void ButtonSmallStop_Click(object sender, EventArgs e)
        {
            // Handle button click event
            stopbuttonu();
        }
        private void ButtonSmallClose_Click(object sender, EventArgs e)
        {
            // kapat butonu fonks.
            this.Close();
        }
        public void getnewlocation()
        {
            // olta atım noktasının değiştirilmesi fonks.
            using (RegionDrawingForm regionDrawingForm = new RegionDrawingForm())
            {
                if (regionDrawingForm.ShowDialog() == DialogResult.OK)
                {
                    savedCoordinate = regionDrawingForm.SelectedCoordinate;

                    labelCoordinate.Text =
                        $"{savedCoordinate.X}, {savedCoordinate.Y}";

                }
            }
        }
        private void ButtonSmallLocation_Click(object sender, EventArgs e)
        {
            getnewlocation();
        }
        //SmallApp smallAppForm = new SmallApp();

        public void ShowMainForm()
        {
            this.Show();
        }
        // Instantiate SmallApp form
        //private SmallApp smallAppForm;
        Point formlokasyon2;
        private void Form1_Load(object sender, EventArgs e)
        {

            listBox1.BackColor = Color.FromArgb(210, 180, 140);
            // Set label text

            this.TransparencyKey =
                Color.Gray;  // You can choose a color that is not in your image

            // Form yüklenirken yapılması gerekenler aka tarih saat, kayıtlı ayarların
            // okunması ve güncellenmesi.
            labelDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            this.TopMost = true;


            try
            {
                smallAppForm = new SmallApp();
                smallAppForm.MainFormReference = this; // Pass reference to SmallApp

                // Show the main form
                this.Show();
                smallAppForm.LabelText = labelStatus.Text;

                // Set button click event
                smallAppForm.StartButonu(ButtonSmallStart_Click);
                smallAppForm.StopButonu(ButtonSmallStop_Click);
                smallAppForm.CloseButonu(ButtonSmallClose_Click);
                //smallAppForm.LocationButonu(ButtonSmallLocation_Click);
                using (StreamReader streamReader = new StreamReader("userData.txt"))
                {
                    // AYARLARI KAYDET CHECKBOX KAYDINI OKUMA
                    data = streamReader.ReadLine();
                    if (data == "Checked")
                    {
                        checkBox1.Checked = true;
                    }
                    else
                    {
                        checkBox1.Checked = false;
                    }
                    // MOUSE KOORDİNAT KAYDINI OKUMA
                    data = streamReader.ReadLine();
                    // labelStatus.Text = data;
                    string[] coordinateComponents = data.Split(',');
                    if (TryParseCoordinates(data, out int x, out int y))
                    {
                        Debug.WriteLine($"X: {x}, Y: {y}");
                        Point mousekoordinat = new Point((int)x, (int)y);
                        mousekoordinatson = mousekoordinat;
                        savedCoordinate = mousekoordinat;
                        labelCoordinate.Text = x + ", " + y;
                    }
                    else
                    {
                        Debug.WriteLine("Invalid coordinate format.");
                    }
                    // BAR KOORDİNAT KAYDINI OKUMA
                    data = streamReader.ReadLine();
                    if (TryParseRectangle(data, out int xRect, out int yRect,
                                          out int widthRect, out int heightRect))
                    {
                        selectedRegion.X = xRect;
                        selectedRegion.Y = yRect;
                        selectedRegion.Width = widthRect;
                        selectedRegion.Height = heightRect;
                        Debug.WriteLine(
                            $"Rectangle - X: {xRect}, Y: {yRect}, Width: {widthRect}, Height: {heightRect}");
                        DisplaySelectedRegion();

                    }
                    else
                    {
                        Debug.WriteLine("Invalid rectangle format.");
                    }
                    // Seçili Ses Sistemi
                    data = streamReader.ReadLine();
                    comboBoxOutputDevices.SelectedIndex = Convert.ToInt32(data);
                    // Verilen ses seviyesi
                    data = streamReader.ReadLine();
                    textBox1.Text = data;
                    // Uygulama konumu
                    data = streamReader.ReadLine();
                    if (TryParseCoordinates(data, out int parsedX, out int parsedY))
                    {
                        Debug.WriteLine($"Parsed X: {parsedX}, Parsed Y: {parsedY}");

                        Point formlokasyon = new Point(parsedX, parsedY);
                        this.Location = new System.Drawing.Point(parsedX, parsedY);

                    }
                    else
                    {
                        Debug.WriteLine("Invalid coordinate format.");
                    }
                    // Pathfinder CheckBox checkstate (yürüme)
                    data = streamReader.ReadLine();
                    if (data == "Checked")
                    {
                        Pathfinder.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        Pathfinder.CheckState = CheckState.Unchecked;
                    }
                    // PATHFINDDER MAP LİSTESİ COUNT

                    data = streamReader.ReadLine();
                    int haritasayisi = Convert.ToInt32(data);
                    for (int i = 0; i < haritasayisi; i++)
                    {
                        // PATHFINDDER MAP LİSTESİ Tek Tek Yazma
                        data = streamReader.ReadLine();
                        comboBoxHaritalar.Items.Add(data.ToString());
                    }

                    // Pathfinder konum sayısı (yürüme)
                    data = streamReader.ReadLine();
                    // Pathfinder konumları comboboxa ekleme,
                    int toplamkoordinatsayisiyurume = Convert.ToInt32(data);
                    for (int i = 0; i < toplamkoordinatsayisiyurume; i++)
                    {
                        data = streamReader.ReadLine();
                        comboBoxNoktalar.Items.Add(data.ToString());
                    }
                    // BALIK NOKTALARI COUNT
                    data = streamReader.ReadLine();
                    int toplambaliknoktasi = Convert.ToInt32(data);
                    for (int i = 0; i < toplambaliknoktasi; i++)
                    {
                        data = streamReader.ReadLine();
                        comboBoxBalikNoktalari.Items.Add(data.ToString());
                    }
                    // FishStop Noktalari COUNT
                    data = streamReader.ReadLine();
                    int toplamfishstop = Convert.ToInt32(data);
                    for (int i = 0; i < toplamfishstop; i++)
                    {
                        data = streamReader.ReadLine();
                        comboBoxFishStop.Items.Add(data.ToString());
                    }
                    // PATHFINDER Tutulacak balik sayısı
                    data = streamReader.ReadLine();
                    int secilenbaliksayisi = Convert.ToInt32(data);
                    comboBoxBalikSayisi.SelectedIndex = secilenbaliksayisi;
                    // OLTA SAYACI TEXTBOX READ
                    data = streamReader.ReadLine();
                    textBoxOltaMaxSuresi.Text = data.ToString();
                    // OLTA ARA SAYACI TEXTBOX READ
                    data = streamReader.ReadLine();
                    textBoxOltaAraSuresi.Text = data.ToString();
                    // Form2 LOKASYON KAYDI 
                    data = streamReader.ReadLine();
                    if (TryParseCoordinates(data, out int parsedX2, out int parsedY2))
                    {
                        Debug.WriteLine($"Parsed X: {parsedX2}, Parsed Y: {parsedY2}");

                        formlokasyon2 = new Point(parsedX2, parsedY2);
                        smallAppForm.Location = new System.Drawing.Point(formlokasyon2.X, formlokasyon2.Y);

                    }
                    else
                    {
                        Debug.WriteLine("Invalid coordinate format.");
                    }
                    // Fishbait ayar okuma 
                    data = streamReader.ReadLine();
                    if (data == "True")
                    {
                        fishbait = true;
                        pictureBoxFishBait.BackColor = Color.Green;
                    }
                    //CheckForUpdates();

                    labelStatus.Text = "Hazır.";
                    oltasayacitextbox = Convert.ToInt32(textBoxOltaMaxSuresi.Text);
                    pauseinttextbox = Convert.ToInt32(textBoxOltaAraSuresi.Text);



                }
            }
            catch (Exception)
            {
            }
            smallAppForm = new SmallApp();
            smallAppForm.MainFormReference = this; // Pass reference to SmallApp

            // Show the main form
            this.Show();
            smallAppForm.LabelText = labelStatus.Text;

            // Set button click event
            smallAppForm.StartButonu(ButtonSmallStart_Click);
            smallAppForm.StopButonu(ButtonSmallStop_Click);
            smallAppForm.CloseButonu(ButtonSmallClose_Click);
            //smallAppForm.Show();
            CheckVersion();
            AddVersionNumber();
        }
        static string GetLatestVersion()
        {
            string url = "https://raw.githubusercontent.com/ucandutch/CaptainHook/master/version.txt";

            try
            {
                using (WebClient client = new WebClient())
                {
                    string version = client.DownloadString(url).Trim();
                    return version;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while fetching version information: " + ex.Message);
                return null;
            }
        }

        private void CheckVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versioninfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string localVersion = versioninfo.FileVersion; // Your app's current version
            string latestVersion = GetLatestVersion();
            try
            {
                if (latestVersion != null)
                {
                    if (localVersion == latestVersion)
                    {
                        Debug.WriteLine("Your app is up to date.");
                        Debug.WriteLine(localVersion);
                        //labelStatus.Text = "Uygulama ";
                        pictureBoxUpToDate.Visible = true;
                        pictureBoxUpdate.Visible = false;
                    }
                    else
                    {
                        Debug.WriteLine("Your app is not up to date. The latest version is: " + latestVersion);
                        Debug.WriteLine(localVersion);
                        pictureBoxUpToDate.Visible = false;
                        pictureBoxUpdate.Visible = true;
                        labelStatus.Text = "Yeni bir güncelleme mevcut. Yüklemek için Uygulamanın en üstünde bulunan güncelleme butonuna basın. Sürüm :" + localVersion + " - Yeni sürüm :" + latestVersion;
                    }
                }
                else
                {
                    pictureBoxUpToDate.Visible = false;
                    pictureBoxUpdate.Visible = false;
                    labelStatus.Text = "Uygulama güncelliği kontrol edilirken bir hata oluştu. İnternet bağlantınızı kontrol edip uygulamayı tekrar açmanız tavsiye edilir.";
                }
            }
            catch (Exception)
            {
                pictureBoxUpToDate.Visible = false;
                pictureBoxUpdate.Visible = false;
                labelStatus.Text = "Uygulama güncelliği kontrol edilirken bir hata oluştu. İnternet bağlantınızı kontrol edip uygulamayı tekrar açmanız tavsiye edilir.";


            }

        }


        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versioninfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            labelVersion.Text = versioninfo.FileVersion;
        }
        private async Task CheckForUpdates()
        {
            try
            {
                using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/ucandutch/CaptainHook"))
                {
                    labelStatus.Text = "Güncelleme varsa arka planda yükleyecektir. Eğer varsa güncel halini kullanmak için uygulamayı yeniden başlatın.";

                    ReleaseEntry releaseEntry = await mgr.UpdateApp();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message + Environment.NewLine;
                if (ex.InnerException != null)
                    message += ex.InnerException.Message;
                Debug.WriteLine(message);
            }


        }
        private static bool TryParseRectangle(string input, out int x, out int y,
                                              out int width, out int height)
        {
            // kayıtlı dosyaları ayıklama ve okuma fonks (x,y,w,h dikdörtgen için).

            string pattern = @"\{X=(\d+),Y=(\d+),Width=(\d+),Height=(\d+)\}";

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                x = int.Parse(match.Groups[1].Value);
                y = int.Parse(match.Groups[2].Value);
                width = int.Parse(match.Groups[3].Value);
                height = int.Parse(match.Groups[4].Value);
                return true;
            }

            x = y = width = height = 0;
            return false;
        }
        private static bool TryParseCoordinates(string input, out int x, out int y)
        {
            // kayıtlı dosyaları ayıklama ve okuma fonks (x,y koordinat için).
            string pattern = @"\{X=(\d+),Y=(\d+)\}";

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                x = int.Parse(match.Groups[1].Value);
                y = int.Parse(match.Groups[2].Value);
                return true;
            }

            x = y = 0;
            return false;
        }
        private Rectangle GetGreenBarRect()
        {
            // Define percentages based on your screenshot analysis (1080p)
            double greenBarXPercentage =
                861.0 / 1920.0;  // X-coordinate as a percentage
            double greenBarYPercentage =
                538.0 / 1080.0;  // Y-coordinate as a percentage
            double greenBarWidthPercentage = 197.0 / 1920.0;  // Width as a percentage
            double greenBarHeightPercentage = 30.0 / 1080.0;  // Height as a percentage

            // Get the current screen dimensions
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Calculate coordinates based on percentages and screen dimensions
            int greenBarX = (int)(screenWidth * greenBarXPercentage);
            int greenBarY = (int)(screenHeight * greenBarYPercentage);
            int greenBarWidth = (int)(screenWidth * greenBarWidthPercentage);
            int greenBarHeight = (int)(screenHeight * greenBarHeightPercentage);

            return new Rectangle(greenBarX, greenBarY, greenBarWidth, greenBarHeight);
        }

        private void DisplaySelectedRegion()
        {
            try
            {
                // Get green bar rectangle using the newly created function
                Rectangle greenBarRect = GetGreenBarRect();

                // Create a new bitmap with the size of the green bar
                Bitmap greenBarBitmap =
                    new Bitmap(greenBarRect.Width, greenBarRect.Height);

                using (Graphics g = Graphics.FromImage(greenBarBitmap))
                {
                    // Copy the green bar area from the screen to the bitmap
                    g.CopyFromScreen(greenBarRect.X, greenBarRect.Y, 0, 0,
                                     greenBarRect.Size);
                }

                // Update pictureBox1 with the green bar bitmap
                pictureBox1.Image = greenBarBitmap;
            }
            catch (Exception)
            {
            }
        }
        private int CountGreenPixels(Bitmap bitmap)
        {
            // yeşil piksel kontrol fonks.
            int greenPixelCount = 0;

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);

                    if (pixelColor.G > pixelColor.R && pixelColor.G > pixelColor.B)
                    {
                        greenPixelCount++;
                    }
                }
            }

            return greenPixelCount;
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e) { }
        private void MouseClickAndHold(int x, int y)
        {
            if (Pathfinder.CheckState == CheckState.Checked)
            {
                string[] coordinates =
                    comboBoxBalikNoktalari.SelectedItem.ToString().Trim('(', ')').Split(
                        ',');
                if (coordinates.Length == 2 &&
                    int.TryParse(coordinates[0]
                                     .Trim(),
                                 out int x1) &&
                    int.TryParse(coordinates[1]
                                     .Trim(),
                                 out int y1))
                {
                    // mouse tıkla ve basılı tut fonks.
                    SetCursorPos(x1, y1);
                }
            }
            else
            {
                SetCursorPos(savedCoordinate.X, savedCoordinate.Y);
            }
            // labelCoordinate.Text = $"Mouse Clicked at: X = {savedCoordinate.X}, Y =
            // {savedCoordinate.Y}";

            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
        }

        private void ReleaseMouseClick()
        {
            if (Pathfinder.CheckState == CheckState.Checked)
            {
                string[] coordinates =
                    comboBoxBalikNoktalari.SelectedItem.ToString().Trim('(', ')').Split(
                        ',');
                if (coordinates.Length == 2 &&
                    int.TryParse(coordinates[0]
                                     .Trim(),
                                 out int x) &&
                    int.TryParse(coordinates[1]
                                     .Trim(),
                                 out int y))
                {
                    // mouse tıkla ve basılı tut fonks.
                    SetCursorPos(x, y);
                }
            }
            else
            {
                SetCursorPos(savedCoordinate.X, savedCoordinate.Y);
            }
            // mouse bırak fonks.
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        bool oltada = false;

        int greenThreshold = 26;
        int clickAttempts = 0;

        private void timerReeling_Tick(object sender, EventArgs e)
        {
            //timerFishBar.Stop();


            // balık oltaya geldikten ve ilk yoklama çekişi sonrası balığın tamamen
            // çekilmesi fonks.
            if (pictureBox1.Image != null)
            {
                DisplaySelectedRegion();
                int greenTarget = 140;    // Adjust based on your green value analysis
                int greenTolerance = 30;  // Adjust tolerance based on color variations
                Bitmap areaBitmap = new Bitmap(pictureBox1.Image);
                double checkXPercentage = 0.90;

                int greenPixelCount = CountGreenPixels(areaBitmap);

                double greenThresholdPercentage = 70.0;

                double percentageGreen = (double)greenPixelCount /
                                         (areaBitmap.Width * areaBitmap.Height) * 100.0;
                int checkX = (int)(areaBitmap.Width * checkXPercentage);

                int checkY = pictureBox1.Height / 2;

                if (checkX >= 0 && checkX < areaBitmap.Width && checkY >= 0 &&
                    checkY < areaBitmap.Height)

                {
                    // Secili pixel yesilin tonundaysa
                    if (percentageGreen <= greenThresholdPercentage)
                    {
                        labelStatus.Text = "Çekme işlemi tamamlandı.";
                        if (isClickAndHoldActive)
                        {
                            isClickAndHoldActive = false;
                            ReleaseMouseClick();
                        }
                        //InputSimulator simulator = new InputSimulator();

                        //simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_S);


                    }
                    else
                    {
                        Color pixelColor = areaBitmap.GetPixel(checkX, checkY);
                        labelFish.ForeColor = pixelColor;
                        //Thread.Sleep(10);

                        if (pixelColor.G > pixelColor.R + greenThreshold &&
                            pixelColor.G > pixelColor.B + greenThreshold &&
                            pixelColor.G >= greenTarget - greenTolerance &&
                            pixelColor.G <= greenTarget + greenTolerance)
                        {

                            labelFish.Text = "Cekiliyor";
                            // Thread.Sleep(20);

                            if (!isClickAndHoldActive)
                            {
                                isClickAndHoldActive = true;
                                MouseClickAndHold(checkX, checkY);
                            }


                        }
                        else
                        {
                            // Secili pixel yesilin tonunda degilse

                            labelFish.Text = "Salınıyor";
                            // Thread.Sleep(20);

                            if (isClickAndHoldActive)
                            {
                                isClickAndHoldActive = false;
                                ReleaseMouseClick();
                            }
                        }
                    }
                }
            }
        }

        void balikcekme()
        {
            if (Pathfinder.CheckState == CheckState.Checked)
            {
                // if (pathfinderlisayac > Convert.ToInt32(comboBoxBalikSayisi.Text))
                //{
                //    stopbuttonu();
                //    pathfinderlisayac = 0;
                //    isPaused = false;
                //}
                // else
                //{
                // pathfinderlisayac++;
                //label12.Text = pathfinderlisayac.ToString();
                string[] coordinates =
                    comboBoxBalikNoktalari.SelectedItem.ToString().Trim('(', ')').Split(
                        ',');
                if (coordinates.Length == 2 &&
                    int.TryParse(coordinates[0]
                                     .Trim(),
                                 out int x) &&
                    int.TryParse(coordinates[1]
                                     .Trim(),
                                 out int y))
                {
                    // ilk yoklama çekişi
                    labelStatus.Text = "Olta Yoklanıyor...";
                    SetCursorPos(x, y);

                    mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                    Thread.Sleep(45);
                    mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                    isClickAndHoldActive = false;
                    ReleaseMouseClick();
                }
                //}

            }
            else
            {
                labelStatus.Text = "Olta Yoklanıyor...";
                SetCursorPos(savedCoordinate.X, savedCoordinate.Y);

                mouse_event(MOUSEEVENTF_LEFTDOWN, savedCoordinate.X, savedCoordinate.Y, 0,
                            0);
                Thread.Sleep(45);
                mouse_event(MOUSEEVENTF_LEFTUP, savedCoordinate.X, savedCoordinate.Y, 0,
                            0);
            }
        }
        void stopbuttonu()
        {

            if (Pathfinder.CheckState == CheckState.Checked)
            {
                // durdurma butonu fonks.
                progressBar1.Value = 0;

                labelStatus.Text = "Durduruldu.";
                calismadurumu = false;
                timerFishBar.Enabled = false;
                timerReeling.Enabled = false;
                timerPause.Enabled = false;
                oltada = false;
                oltasayaci = 0;
                labelOltadakiSure.Text = oltasayaci.ToString();
                pauseint = 0;
                labelPause.Text = pauseint.ToString();
                pathfinderlisayac = 0;
                //timerWalk.Stop();


            }
            else
            {
                // durdurma butonu fonks.
                progressBar1.Value = 0;

                labelStatus.Text = "Durduruldu.";
                calismadurumu = false;
                timerFishBar.Enabled = false;
                timerReeling.Enabled = false;
                timerPause.Enabled = false;
                oltada = false;
                oltasayaci = 0;
                labelOltadakiSure.Text = oltasayaci.ToString();
                pauseint = 0;
                labelPause.Text = pauseint.ToString();
                pathfinderlisayac = 0;
                //timerWalk.Stop();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            stopbuttonu(); isPaused = true;
        }
        int oltasayaci = 0;
        int oltasayacitextbox;
        private void timerSoundcheck_Tick(object sender, EventArgs e)
        {
            // Belirtilen sürede balık gelmediyse yeniden olatalama fonks.
            if (oltada == true)
            {
                if (oltasayaci == oltasayacitextbox)
                {
                    stopbuttonu();

                    oltasayaci = 0;
                    labelOltadakiSure.Text = (oltasayaci.ToString());
                    baslatbutonu();
                }
                else
                {
                    oltasayaci++;
                    labelOltadakiSure.Text = (oltasayaci.ToString());
                }
            }
            else
            {
                oltasayaci = 0;
                labelOltadakiSure.Text = (oltasayaci.ToString());
            }
        }

        private void comboBoxOutputDevices_SelectedIndexChanged_1(object sender,
                                                                  EventArgs e)
        {
            // Seçili ses sisteminin değiştirilmesi
            if (loopbackCapture != null &&
                loopbackCapture.CaptureState == CaptureState.Capturing)
            {
                loopbackCapture.StopRecording();
            }

            MMDevice selectedDevice = comboBoxOutputDevices.SelectedItem as MMDevice;
            if (selectedDevice != null)
            {
                loopbackCapture = new WasapiLoopbackCapture(selectedDevice);
                loopbackCapture.DataAvailable += LoopbackCaptureOnDataAvailable;
                loopbackCapture.StartRecording();

                waveBuffer =
                    new WaveBuffer(loopbackCapture.WaveFormat.AverageBytesPerSecond / 2);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e) { }

        private void Form1_MouseClick(object sender, MouseEventArgs e) { }

        void oltaatma()
        {
            if (Pathfinder.CheckState == CheckState.Checked)
            {
                // if (pathfinderlisayac >10)
                //{
                //    stopbuttonu();
                //    pathfinderlisayac = 0;
                //    isPaused = false;
                //}
                // else
                //{
                // pathfinderlisayac++;
                // label12.Text = pathfinderlisayac.ToString();
                // olta atimi fonksyonlari baslangici
                labelStatus.Text = "Olta Atılıyor.";
                InputSimulator simulator = new InputSimulator();
                simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_S);
                timerPause.Enabled = true;

                // timerFishBar.Start();
                //}
            }
            else
            {
                // olta atimi fonksyonlari baslangici
                labelStatus.Text = "Olta Atılıyor.";
                InputSimulator simulator = new InputSimulator();
                simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_S);
                timerPause.Enabled = true;
                ;
                // timerFishBar.Start();
            }
        }
        // Define the RGB values for the green color you want to search for
        int targetGreenR = 63; // Adjust these values as needed
        int targetGreenG = 117;
        int targetGreenB = 39;

        // Define a threshold for the color comparison
        int colorThreshold = 50; // Adjust this threshold as needed

        private bool IsGreenColor(Color pixelColor)
        {
            // Calculate the difference between the target green color and the pixel's color
            int colorDifference = Math.Abs(pixelColor.R - targetGreenR) +
                                  Math.Abs(pixelColor.G - targetGreenG) +
                                  Math.Abs(pixelColor.B - targetGreenB);

            // If the color difference is within the threshold, consider it a green color
            return colorDifference < colorThreshold;
        }
        private int CountGreenPixels1(Bitmap bitmap)
        {
            int greenPixelCount = 0;

            // Iterate through each pixel in the bitmap
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    // Get the color of the current pixel
                    Color pixelColor = bitmap.GetPixel(x, y);

                    // Check if the color is green
                    if (IsGreenColor(pixelColor))
                    {
                        greenPixelCount++;
                    }
                }
            }

            return greenPixelCount;
        }
        private void timerFishBar_Tick(object sender, EventArgs e)
        {
            // seçili koordinatlara göre balık çekim ekranındaki gerginlik barını
            // güncelleme fonks.
            DisplaySelectedRegion();

            if (pictureBox1.Image != null)
            {
                Bitmap areaBitmap = new Bitmap(pictureBox1.Image);

                int greenPixelCount = CountGreenPixels1(areaBitmap);

                double greenThresholdPercentage = 40.0;

                //double percentageGreen = (double)greenPixelCount /
                //                         (areaBitmap.Width * areaBitmap.Height) * 100.0;
                double percentageGreen = (double)greenPixelCount / (areaBitmap.Width * areaBitmap.Height) * 100.0;

                // bot çalışıyorsa
                if (calismadurumu == true)
                {
                    // secili hoparlor alani bos degilse
                    if (textBox1.Text != null)
                    {
                        // ses seviyesi belirtilenden yuksekse
                        if (sesseviyesi >= Convert.ToInt32(textBox1.Text))
                        {
                            // olta atildiktan sonra en az 3 saniye gectiyse
                            if (oltasayaci > 3)
                            {
                                // karakter olta pozisyonundaysa
                                if (oltada == true)
                                {
                                    // ilkçekme yoklaması
                                    balikcekme();
                                }
                            }
                        }
                    }

                    if (calismadurumu == true &&
                        percentageGreen >= greenThresholdPercentage && oltada == true)
                    {
                        // bot çalışıy-or ve ekranda yeşil kutu var ayrıca oltadaysa
                        labelStatus.Text = "Balık Bulundu, Çekilmeye başlanıyor";
                        oltasayaci = 0;
                        oltada = false;
                        timerReeling.Enabled = true;
                    }
                    if (oltada == false && percentageGreen <= greenThresholdPercentage &&
                        calismadurumu == true)
                    {
                        oltaatma();
                        // timerFishBar.Stop();
                        timerReeling.Enabled = false;
                        // Bot çalışıyor Yeşil ekran yok ve çar oltada değilse
                    }
                }
                if (calismadurumu == true && oltada == true &&
                    percentageGreen <= greenThresholdPercentage)
                {

                    timerPause.Enabled = false;
                }
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                // uygulama kapanirken ayarlarin kaydedilmesi
                using (StreamWriter streamWriter = new StreamWriter("userData.txt"))
                {
                    // Kayıt Checkbox
                    streamWriter.WriteLine(checkBox1.CheckState.ToString());
                    // Mouse koordinatı
                    streamWriter.WriteLine(savedCoordinate);
                    // Balık Barı koordinatı
                    streamWriter.WriteLine(selectedRegion);
                    // Seçili ses sistemi
                    streamWriter.WriteLine(comboBoxOutputDevices.SelectedIndex);
                    // Verilen Ses seviyesi
                    streamWriter.WriteLine(textBox1.Text);
                    // Uygulama konumu
                    streamWriter.WriteLine(this.Location);
                    // PATHFINDER ALL
                    streamWriter.WriteLine(Pathfinder.CheckState.ToString());
                    // MAP Listesi count
                    streamWriter.WriteLine(comboBoxHaritalar.Items.Count.ToString());
                    // MAP Listesi tektek yazma
                    int haritatoplam = comboBoxHaritalar.Items.Count;
                    for (int i = 0; i < haritatoplam; i++)
                    {
                        streamWriter.WriteLine(comboBoxHaritalar
                                                   .Items[i]
                                                   .ToString());
                    }
                    // Pathfinder konum listesi (yürüme)
                    streamWriter.WriteLine(comboBoxNoktalar.Items.Count);
                    for (int i = 0; i < comboBoxNoktalar.Items.Count; i++)
                    {
                        streamWriter.WriteLine(comboBoxNoktalar
                                                   .Items[i]
                                                   .ToString());
                    }
                    // Pathfinder Balik Noktalaarı listesi
                    streamWriter.WriteLine(comboBoxBalikNoktalari.Items.Count);

                    for (int i = 0; i < comboBoxBalikNoktalari.Items.Count; i++)
                    {
                        streamWriter.WriteLine(comboBoxBalikNoktalari
                                                   .Items[i]
                                                   .ToString());
                    }
                    // Pathfinder FishStop Noktalari listesi
                    streamWriter.WriteLine(comboBoxFishStop.Items.Count);
                    for (int i = 0; i < comboBoxFishStop.Items.Count; i++)
                    {
                        streamWriter.WriteLine(comboBoxFishStop
                                                   .Items[i]
                                                   .ToString());
                    }
                    // PATHFINDER Tutulacak balık sayısı
                    streamWriter.WriteLine(comboBoxBalikSayisi.SelectedIndex.ToString());

                    // OLTA MAX ARA TEXTBOX KAYDI
                    streamWriter.WriteLine(textBoxOltaMaxSuresi.Text);

                    // OLTA ARA TEXTBOX KAYDI
                    streamWriter.WriteLine(textBoxOltaAraSuresi.Text);

                    // Form2 LOKASYON KAYDI 
                    streamWriter.WriteLine(smallAppForm.Location);
                    // FishBait Ayar kaydı
                    streamWriter.WriteLine(fishbait.ToString());
                    streamWriter.Close();
                }
            }
            catch (Exception)
            {
                labelStatus.Text = "Kayıtlı ayarlar okunurken hata oluştu. Lütfen uygulamayı kapatıp açın.";

            }

            if (loopbackCapture != null &&
                loopbackCapture.CaptureState == CaptureState.Capturing)
            {
                loopbackCapture.StopRecording();
            }
        }
        int pathfinderlisayac = 0;
        int tuketilenfishbait;
        void baslatbutonu()
        {
            // baslat butonu fonks.
            progressBar1.Value = 100;
            if (Pathfinder.CheckState == CheckState.Checked)
            {
                if (comboBoxBalikSayisi.Text != "")
                {
                    if (pathfinderlisayac >= Convert.ToInt32(comboBoxBalikSayisi.Text))
                    {
                        stopbuttonu();
                        pathfinderlisayac = 0;
                    }
                    else
                    {
                        labelStatus.Text = "Başlatılıyor...";
                        //calismadurumu = true;
                        InputSimulator simulator = new InputSimulator();
                        Random random = new Random();

                        if (fishbait == true && toplamoltasayisi % 10 == 0)
                        {
                            tuketilenbait++;
                            labelFishBait.Text = tuketilenbait.ToString();
                            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_1);
                            int randomNumber2 = random.Next(100, 401);
                        }
                        simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_S);
                        int randomNumber = random.Next(300, 701);
                        if (comboBoxNoktalar.Text == comboBoxFishStop.Text && comboBoxNoktalar.Text != "")
                        {
                            Thread.Sleep(2000);
                            string[] coordinates =
                                comboBoxBalikNoktalari.SelectedItem.ToString().Trim('(', ')').Split(
                                    ',');
                            if (coordinates.Length == 2 &&
                                int.TryParse(coordinates[0]
                                                 .Trim(),
                                             out int x) &&
                                int.TryParse(coordinates[1]
                                                 .Trim(),
                                             out int y))
                            {
                                labelStatus.Text =
                                    (comboBoxBalikNoktalari.Text + " noktasına olta atılıyor");
                                // pathfinderlisayac++;
                                // label12.Text = pathfinderlisayac.ToString();
                                calismadurumu = true;
                                pathfinderlisayac++;
                                SetCursorPos(x, y);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                                Thread.Sleep(randomNumber);
                                mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                                timerSoundcheck.Start();
                                oltada = true;
                                toplamoltasayisi++;
                                labelToplamOlta.Text = toplamoltasayisi.ToString();
                                timerFishBar.Start();
                                //isPaused = false;

                            }
                        }
                        else
                        {
                            isPaused = false;

                            StartMovingAlongRoute();

                        }

                    }
                }
                else
                {
                    labelStatus.Text = "Lütfen Pathfinder ayarlarında Her noktada kaç balık tutulacağını seçiniz.";
                }


            }
            else
            {
                labelStatus.Text = "Başlatılıyor...";
                calismadurumu = true;
                labelStatus.Text = "Olta atılıyor.";
                InputSimulator simulator = new InputSimulator();
                Random random = new Random();
                if (fishbait == true && toplamoltasayisi % 10 == 0)
                {
                    tuketilenbait++;
                    labelFishBait.Text = tuketilenbait.ToString();
                    simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_1);
                    int randomNumber2 = random.Next(100, 301);
                }
                simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_S);

                int randomNumber = random.Next(300, 701);
                Thread.Sleep(2000);
                SetCursorPos(savedCoordinate.X, savedCoordinate.Y);
                mouse_event(MOUSEEVENTF_LEFTDOWN, savedCoordinate.X, savedCoordinate.Y, 0,
                            0);
                Thread.Sleep(randomNumber);
                mouse_event(MOUSEEVENTF_LEFTUP, savedCoordinate.X, savedCoordinate.Y, 0,
                            0);
                timerSoundcheck.Start();
                oltada = true;
                toplamoltasayisi++;
                labelToplamOlta.Text = toplamoltasayisi.ToString();
                timerFishBar.Start();
            }
        }
        Boolean calismadurumu = false;
        private void button2_Click(object sender, EventArgs e) { baslatbutonu(); }

        void walk() { }
        void stoptofish() { }
        int sesseviyesi;
        int maxsesseviyesi = 0;
        private void timerAudio_Tick(object sender, EventArgs e)
        {
            // Seçili ses sisteminden çıkan sesi prog.bar da gösterme fonks.
            if (comboBoxOutputDevices.SelectedItem != null)
            {
                var singledevice = (MMDevice)comboBoxOutputDevices.SelectedItem;
                sesseviyesi =
                    (int)(singledevice.AudioMeterInformation.MasterPeakValue * 100);
                if (maxsesseviyesi < sesseviyesi)
                {
                    maxsesseviyesi = sesseviyesi;
                    progressBarSoundLevel.Value = sesseviyesi;
                    labelSesSeviyesi.Text = maxsesseviyesi.ToString();
                }
                else
                {
                    progressBarSoundLevel.Value = sesseviyesi;
                }

                // labelSesSeviyesi.Text = sesseviyesi.ToString();
            }
        }
        bool kayitcheckbox;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ayarların kaydedilmesi fonks.
            if (checkBox1.CheckState == CheckState.Checked)
            {
                labelStatus.Text = "Otomatik kayıt açıldı. Uygulama kapanırken kayıt yapılacaktır.";
                kayitcheckbox = true;
            }
            else
            {
                labelStatus.Text = "Otomatik kayıt devre dışı kaldı. Eğer varsa son kayıtlı ayarlar yüklenecektir.";
                kayitcheckbox = false;
            }
        }

        private void labelCoordinate_Click(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Hide the main form
            this.Hide();

            // Show the SmallApp form
            //smallAppForm SmallApp();
            smallAppForm.Show();
            smallAppForm.Location = new System.Drawing.Point(formlokasyon2.X, formlokasyon2.Y);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //this.Cursor = Cursors.SizeAll;
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                //this.Cursor = Cursors.Cross;
                ReleaseCapture();
                SendMessage(Handle, 0xA1, (IntPtr)0x2, IntPtr.Zero);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(Cursor.Position.X - this.Width / 2,
                                          Cursor.Position.Y - this.Height / 2);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)(HT_CAPTION);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // olta atım noktasının değiştirilmesi fonks.
            using (RegionDrawingForm regionDrawingForm = new RegionDrawingForm())
            {
                if (regionDrawingForm.ShowDialog() == DialogResult.OK)
                {
                    savedCoordinate = regionDrawingForm.SelectedCoordinate;

                    labelCoordinate.Text =
                        $"{savedCoordinate.X}, {savedCoordinate.Y}";
                }
            }
        }
        int toplamoltasayisi;
        int pauseint = 0;
        int pauseinttextbox;
        private void timerPause_Tick(object sender, EventArgs e)
        {
            labelPause.Text = pauseint.ToString();
            if (pauseint == pauseinttextbox)
            {
                if (Pathfinder.CheckState == CheckState.Checked)
                {
                    if (pathfinderlisayac == Convert.ToInt32(comboBoxBalikSayisi.Text))
                    {
                        //isPaused = true;
                        pathfinderlisayac = 0;
                        //label12.Text = pathfinderlisayac.ToString();

                        stopbuttonu();
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        pathfinderlisayac++;
                        Random random = new Random();
                        if (fishbait == true && toplamoltasayisi % 10 == 0)
                        {
                            tuketilenbait++;
                            labelFishBait.Text = tuketilenbait.ToString();
                            InputSimulator simulator = new InputSimulator();
                            simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_1);
                            int randomNumber2 = random.Next(100, 301);
                        }
                        //label12.Text = pathfinderlisayac.ToString();
                        string[] coordinates = comboBoxBalikNoktalari.SelectedItem.ToString()
                                                   .Trim('(', ')')
                                                   .Split(',');
                        if (coordinates.Length == 2 &&
                            int.TryParse(coordinates[0]
                                             .Trim(),
                                         out int x) &&
                            int.TryParse(coordinates[1]
                                             .Trim(),
                                         out int y))
                        {
                            labelStatus.Text =
                                (comboBoxBalikNoktalari.Text + " noktasına olta atılıyor");

                            int randomNumber = random.Next(300, 901);
                            SetCursorPos(x, y);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                            Thread.Sleep(randomNumber);
                            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);

                            oltada = true;
                            toplamoltasayisi++;
                            labelToplamOlta.Text = toplamoltasayisi.ToString();
                            // oltada = true;
                            pauseint = 0;
                        }
                    }

                }
                else
                {
                    Random random = new Random();
                    if (fishbait == true && toplamoltasayisi % 10 == 0)
                    {
                        tuketilenbait++;
                        labelFishBait.Text = tuketilenbait.ToString();
                        InputSimulator simulator = new InputSimulator();
                        simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_1);
                        int randomNumber2 = random.Next(100, 301);
                    }

                    SetCursorPos(savedCoordinate.X, savedCoordinate.Y);

                    int randomNumber = random.Next(300, 901);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, savedCoordinate.X, savedCoordinate.Y,
                                0, 0);
                    Thread.Sleep(randomNumber);
                    mouse_event(MOUSEEVENTF_LEFTUP, savedCoordinate.X, savedCoordinate.Y, 0,
                                0);
                    oltada = true;
                    toplamoltasayisi++;
                    labelToplamOlta.Text = toplamoltasayisi.ToString();
                    // oltada = true;
                    pauseint = 0;
                }

            }
            else
            {
                pauseint++;
            }
        }
        public class TransparentForm : Form
        {
            private List<Point> clickCoordinates =
                new List<Point>();  // List to store click coordinates
            private ComboBox comboBoxNoktalar;
            public TransparentForm(ComboBox comboBox)
            {
                // Set the reference to the ComboBox
                comboBoxNoktalar = comboBox;
                // Set form properties
                this.FormBorderStyle = FormBorderStyle.None;
                this.BackColor = Color.Black;  // Change to your desired background color
                this.Opacity =
                    0.5;  // Adjust the opacity to make the form semi-transparent

                // Set the form to cover the entire screen
                this.StartPosition = FormStartPosition.Manual;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                // Add mouse click event handler
                this.MouseClick += TransparentForm_MouseClick;
            }

            private void TransparentForm_MouseClick(object sender, MouseEventArgs e)
            {
                // Get the coordinates of the mouse click
                int mouseX = e.X;
                int mouseY = e.Y;

                // Save the coordinates
                clickCoordinates.Add(new Point(mouseX, mouseY));

                // Update the ComboBox on the main form
                comboBoxNoktalar.Invoke((MethodInvoker)delegate
                {
                    comboBoxNoktalar.Items.Add($"({mouseX}, {mouseY})");
                    comboBoxNoktalar.Text = ($"({mouseX}, {mouseY})");
                });

                // Pass the coordinates to your existing app's functionality for game
                // interaction Replace this with your actual method call or property
                // setting YourApp.HandleMouseClick(mouseX, mouseY);

                // Hide the transparent form
                this.Hide();

                // Perform mouse click in the game
                mouse_event(MOUSEEVENTF_LEFTDOWN, mouseX, mouseY, 0, 0);
                Thread.Sleep(38);
                mouse_event(MOUSEEVENTF_LEFTUP, mouseX, mouseY, 0, 0);
            }

            public List<Point> GetClickCoordinates() { return clickCoordinates; }
        }
        public class AnotherTransparentForm : Form
        {
            private List<Point> clickCoordinates2 =
                new List<Point>();         // List to store click coordinates
            private ComboBox statusLabel;  // Reference to the passed label

            public AnotherTransparentForm(ComboBox combobox2)
            {
                // Set the reference to the Label
                statusLabel = combobox2;

                // Set form properties
                this.FormBorderStyle = FormBorderStyle.None;
                this.BackColor = Color.Black;  // Change to your desired background color
                this.Opacity =
                    0.5;  // Adjust the opacity to make the form semi-transparent

                // Set the form to cover the entire screen
                this.StartPosition = FormStartPosition.Manual;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

                // **Do not add mainFormLabel to Controls collection**
                // This label belongs to the main form, not the transparent form.

                // Add mouse click event handler
                this.MouseClick += AnotherTransparentForm_MouseClick;
            }

            private void AnotherTransparentForm_MouseClick(object sender,
                                                           MouseEventArgs e)
            {
                // Get the coordinates of the mouse click
                int mouseX2 = e.X;
                int mouseY2 = e.Y;

                // Save the coordinates (optional, if you need them later)
                clickCoordinates2.Add(new Point(mouseX2, mouseY2));
                string coordinates = $"({mouseX2}, {mouseY2})";
                statusLabel.Items.Add(coordinates);  // Update passed label text
                this.Hide();
            }

            public List<Point> GetClickCoordinates() { return clickCoordinates2; }
        }

        private void panelAnasayfa_MouseDown(object sender, MouseEventArgs e) { }

        private void panelAnasayfa_MouseMove(object sender, MouseEventArgs e) { }

        private void panelAnasayfa_MouseUp(object sender, MouseEventArgs e) { }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Yeni koordinat ekle. 'Yürüme noktası'";
            transparentForm = new TransparentForm(comboBoxNoktalar);
            transparentForm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Start moving along the route
            StartMovingAlongRoute();
        }
        private bool isPaused = false;

        private void timerWalk_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                // label12.Text = clickCoordinates.Count.ToString();
                // Check if there are coordinates left to click
                if (clickCoordinates.Count > 0)
                {
                    // Reset the index if it reaches the end of the list
                    if (currentCoordinateIndex >= clickCoordinates.Count)
                    {
                        // timerWalk.Stop();
                        currentCoordinateIndex = 0;
                    }
                    // Get the next coordinate to click
                    Point nextCoordinate = clickCoordinates[currentCoordinateIndex];
                    // Perform mouse click at the coordinate
                    Cursor.Position = nextCoordinate;  // Move cursor to the coordinate
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    Thread.Sleep(38);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                    // Increment the index for the next coordinate,
                    comboBoxNoktalar.SelectedIndex = currentCoordinateIndex;

                    currentCoordinateIndex++;
                }
                for (int i = 0; i < comboBoxFishStop.Items.Count; i++)
                {
                    if (comboBoxFishStop
                            .Items[i]
                            .ToString() == comboBoxNoktalar.Text)
                    {
                        // MessageBox.Show("Balık tutma noktası. Durdu");
                        isPaused = true;

                        // Pause the timer

                        comboBoxFishStop.SelectedIndex = i;
                        comboBoxBalikNoktalari.SelectedIndex = i;
                        comboBoxNoktalar.Text = "";
                        Thread.Sleep(2000);

                        baslatbutonu();
                        // calismadurumu = true;
                        // break; // Exit the loop once a match is found
                    }
                }

            }
            else
            {
                // calismadurumu = true;
            }
            ////////// BALIK TUTMA NOKTASI
        }
        private void StartMovingAlongRoute()
        {
            clickCoordinates.Clear();
            //// Extract coordinates from ComboBox items and store them in
            ///clickCoordinates list
            foreach (var item in comboBoxNoktalar.Items)
            {
                string[] coordinates = item.ToString().Trim('(', ')').Split(',');
                if (coordinates.Length == 2 &&
                    int.TryParse(coordinates[0]
                                     .Trim(),
                                 out int x) &&
                    int.TryParse(coordinates[1]
                                     .Trim(),
                                 out int y))
                {
                    clickCoordinates.Add(new Point(x, y));
                }
            }

            // Initialize the list of click coordinates from the transparent form
            // Start moving along the route
            movepoint = true;
            timerWalk.Interval = clickInterval;
            timerWalk.Start();
        }

        private void StopMoving()
        {
            // Stop the character's movement

            timerWalk.Stop();
            currentCoordinateIndex = 0;
        }

        private void RegisterStoppingPoint()
        {
            // Register the current coordinate as a stopping point
            Point currentCoordinate = clickCoordinates[currentCoordinateIndex];
            stoppingPoints.Add(currentCoordinate);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Stop the character's movement
            StopMoving();
            movepoint = false;
            // Save the index of the current point in comboBoxNoktalar
            SaveStoppingPointIndex();
            // Open the transparent form to select a custom point
            // OpenTransparentForm();
        }
        private void OpenTransparentForm()
        {
            transparentForm = new TransparentForm(comboBoxNoktalar);
            // transparentForm.MouseClick += TransparentForm_MouseClick; // Subscribe to
            // the event here
            transparentForm.ShowDialog();
        }
        bool movepoint = false;
        private void TransparentForm_MouseClick(object sender, MouseEventArgs e)
        {
            // Save the clicked coordinate
            Point clickedPoint = e.Location;
            customCoordinates.Add(clickedPoint);

            // Add the clicked coordinate to comboBoxFishStopCustom
            comboBoxFishStop.Items.Add(clickedPoint);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // Stop the character's movement
            StopMoving();
            movepoint = false;
            // Save the index of the current point in comboBoxNoktalar
            SaveStoppingPointIndex();
            // Open the transparent form to select a custom point
            // OpenTransparentForm();
            // ComboBox comboBoxBalikNoktalari = new ComboBox();
            // Create an instance of AnotherTransparentForm
            AnotherTransparentForm transparentForm2 =
                new AnotherTransparentForm(comboBoxBalikNoktalari);  // Pass label
            transparentForm2.Show();
        }
        private void SaveStoppingPointIndex()
        {
            // Save the index of the current point in comboBoxNoktalar
            int currentIndex = comboBoxNoktalar.SelectedIndex;
            stoppingPointIndexes.Add(currentIndex);
            comboBoxFishStop.Items.Add(comboBoxNoktalar.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StartMovingAlongRoute();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Seçili koordinat kayıttan silindi.";
            comboBoxNoktalar.Items.Remove(comboBoxNoktalar.SelectedItem);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // if (e.KeyCode == Keys.Y) //
            //{

            //    transparentForm = new TransparentForm(comboBoxNoktalar);
            //    transparentForm.Show();

            //}
            // if (e.KeyCode == Keys.U) //
            //{

            //    StopMoving();
            //    movepoint = false;

            //    SaveStoppingPointIndex();

            //    AnotherTransparentForm transparentForm2 = new
            //    AnotherTransparentForm(comboBoxBalikNoktalari); // Pass label
            //    transparentForm2.Show();

            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBoxHaritalar.Text != null)
            {
                labelStatus.Text = "Yeni Kayıt oluşturuldu.";

                comboBoxHaritalar.Items.Add(comboBoxHaritalar.Text);
                comboBoxNoktalar.Items.Clear();
                comboBoxFishStop.Items.Clear();
                comboBoxBalikNoktalari.Items.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBoxHaritalar.SelectedItem != null)
            {
                labelStatus.Text = "Kayıt silindi.";
                comboBoxNoktalar.Items.Clear();
                comboBoxFishStop.Items.Clear();
                comboBoxBalikNoktalari.Items.Clear();
                comboBoxHaritalar.Items.Remove(comboBoxHaritalar.SelectedItem);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // checkopencvtest();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBoxMain.SendToBack();
            pictureBoxLog.SendToBack();
            pictureBoxSettings.BringToFront();

            groupBoxSettings.Visible = true;
            groupBoxLog.Visible = false;
            panelAnasayfa.Visible = false;


        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBoxMain.SendToBack();
            pictureBoxLog.BringToFront();
            pictureBoxSettings.SendToBack();
            groupBoxLog.Visible = true;
            groupBoxSettings.Visible = false;
            panelAnasayfa.Visible = false;


        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            pictureBoxMain.BringToFront();
            pictureBoxLog.SendToBack();
            pictureBoxSettings.SendToBack();
            groupBoxSettings.Visible = false;
            groupBoxLog.Visible = false;
            panelAnasayfa.Visible = true;

        }

        private void labelStatus_TextChanged(object sender, EventArgs e)
        {
            //smallAppForm = new SmallApp();
            listBox1.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " " + labelStatus.Text);
           
            //smallAppForm.labelSmallStatus.Text = labelStatus.Text;
            //smallAppForm.LabelText = labelStatus.Text;
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void pathFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelPathFinder.Visible == false)
            {
                panelPathFinder.Visible = true;
                panelSoundSettings.Visible = false;
            }
        }

        private void sesAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelSoundSettings.Visible == false)
            {
                panelSoundSettings.Visible = true;
                panelPathFinder.Visible = false;
            }
        }

        private void Pathfinder_CheckedChanged(object sender, EventArgs e)
        {
            if (Pathfinder.CheckState == CheckState.Checked)
            {
                labelStatus.Text = "Pathfinder ayarı açıldı. Karakter seçili rotada balık tutacak.";
            }
            else
            {
                labelStatus.Text = "Pathfinder ayarı kapatıldı. Karakter durduğu yerde seçili konuma olta atacaktır.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                int newValue;
                if (int.TryParse(textBox1.Text, out newValue))
                {
                    // Valid number entered, update the stored value
                    textBox1.Tag = newValue;
                }
                else
                {
                    // Invalid input, revert to the previous valid value
                    textBox1.Text = textBox1.Tag?.ToString() ?? "0";
                }
            }
        }

        private void comboBoxHaritalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNoktalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelPathFinder_Paint(object sender, PaintEventArgs e)
        {

        }


        private void textBoxLogSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            IEnumerable items = listBox1.Items;
            List<int> indices = new List<int>();
            if (textBoxLogSearch.Text == "" || textBoxLogSearch.Text == "Search")
            {
                listBox1.SelectedItem = null;
            }
            else
            {
                foreach (var item in items)
                {
                    string movieName = item as string;

                    if ((!string.IsNullOrEmpty(movieName)) && movieName.Contains(textBoxLogSearch.Text))
                    {
                        indices.Add(listBox1.Items.IndexOf(item));
                    }
                }
                indices.ForEach(index => listBox1.SelectedIndices.Add(index));
            }

        }

        private void listBox1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PopulateOriginalItems();
            //// Check if the selected item is not already in the originalItems array
            //string selectedItem = listBox1.SelectedItem as string;
            //if (!Array.Exists(originalItems, item => item == selectedItem))
            //{
            //    // Add the selected item to the originalItems array
            //    Array.Resize(ref originalItems, originalItems.Length + 1);
            //    originalItems[originalItems.Length - 1] = selectedItem;
            //}
        }

        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToString("HH:mm");
            // Format the time as desired

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxZamanlayici.Checked)
            {
                checkBoxZamanlayici.ForeColor = Color.RoyalBlue;

            }
            else
            {
                checkBoxZamanlayici.ForeColor = Color.DimGray;
            }
        }

        private void textBoxOltaMaxSuresi_TextChanged(object sender, EventArgs e)
        {

            if (textBoxOltaMaxSuresi.Text != "")
            {
                oltasayacitextbox = Convert.ToInt32(textBoxOltaMaxSuresi.Text);
            }


        }

        private void textBoxOltaMaxSuresi_Leave(object sender, EventArgs e)
        {
            // If TextBox is left empty, set its text to "0"
            if (string.IsNullOrWhiteSpace(textBoxOltaMaxSuresi.Text))
            {
                textBoxOltaMaxSuresi.Text = "0";
            }
            labelStatus.Text = "Oltada beklenecek maksimum süre " + textBoxOltaMaxSuresi.Text + " saniye olarak kaydedildi.";
        }

        private void textBoxOltaMaxSuresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters like backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Allow only two characters
            if (textBoxOltaMaxSuresi.Text.Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxOltaAraSuresi_Leave(object sender, EventArgs e)
        {
            // If TextBox is left empty, set its text to "0"
            if (string.IsNullOrWhiteSpace(textBoxOltaAraSuresi.Text))
            {
                textBoxOltaAraSuresi.Text = "0";
            }
            labelStatus.Text = "Olta aralığında beklenecek süre " + textBoxOltaAraSuresi.Text + " saniye olarak kaydedildi.";
        }

        private void textBoxOltaAraSuresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters like backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Allow only two characters
            if (textBoxOltaAraSuresi.Text.Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxOltaAraSuresi_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOltaMaxSuresi.Text != "")
            {
                oltasayacitextbox = Convert.ToInt32(textBoxOltaMaxSuresi.Text);
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSeaweedSalad_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxLogSearch.Text == "")
            {
                textBoxLogSearch.Text = "Search";
            }
        }

        private void textBoxLogSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxLogSearch.Text == "Search")
            {
                textBoxLogSearch.Text = "";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            labelStatus.Text = "Uygulamanın son sürümünü kullanıyorsunuz!";
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            CheckForUpdates();
        }
        bool fishbait;
        private void buttonFishingBait_Click(object sender, EventArgs e)
        {
            if (pictureBoxFishBait.BackColor == Color.DimGray)
            {
                pictureBoxFishBait.BackColor = Color.Green;
                fishbait = true;
                labelStatus.Text = "Otomatik Fish Bait tüketimi devrede. 10 Oltada bir bait tüketilecektir.";
            }
            else
            {
                fishbait = false;

                pictureBoxFishBait.BackColor = Color.DimGray;
                labelStatus.Text = "Fish Bait tüketimi devre dışı bırakıldı.";

            }
        }

        private void labelFishBait_TextChanged(object sender, EventArgs e)
        {
            smallAppForm.LabelTextFishBait = labelFishBait.Text;
        }

        private void labelToplamOlta_TextChanged(object sender, EventArgs e)
        {
            smallAppForm.LabelTextToplamOlta = labelToplamOlta.Text;

        }

        private void labelCoordinate_TextChanged(object sender, EventArgs e)
        {
            smallAppForm.LabelTextCoordinate = labelCoordinate.Text;

        }

        private void labelOltadakiSure_TextChanged(object sender, EventArgs e)
        {
            smallAppForm.LabelTextOltadakiSure = labelOltadakiSure.Text;

        }

        private void labelPause_TextChanged(object sender, EventArgs e)
        {
            smallAppForm.LabelTextPause = labelPause.Text;

        }
    }

}
