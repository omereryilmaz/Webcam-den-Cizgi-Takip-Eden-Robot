using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision;
using AForge.Vision.Motion;

namespace WebcamNesneTespit
{

    public partial class Form1 : Form
    {
        private FilterInfoCollection webcam;//webcam isminde tanımladığımız değişken bilgisayara kaç kamera bağlıysa onları tutan bir dizi. 
        private VideoCaptureDevice cam;//cam ise bizim kullanacağımız aygıt.
        Boolean calisti = false;
        Boolean kontrolTipi = false; //kontol tipi manuel konumda geliyor
        SerialPort sp = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            sp.PortName = "COM2";
            sp.BaudRate = 9600;
            sp.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);//webcam dizisine mevcut kameraları dolduruyoruz.
            foreach (FilterInfo videocapturedevice in webcam)
            {
                comboBox1.Items.Add(videocapturedevice.Name);//kameraları combobox a dolduruyoruz.
            }
            comboBox1.SelectedItem = 0;
        }

        private void baslatBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
                cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
                cam.Start();//kamerayı başlatıyoruz.
                calisti = true;

            }
            else
            {
                MessageBox.Show("Kamerayı seçme kısmını boşuna koyduk oraya zaten !");
            }
            
        }

        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Bitmap image1 = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = image;

            

            if (radioButton1.Checked)
            {
                // Euclidean Color Filterin yapildigi yer
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // Algilanacak renk belirleniyor ve orta noktasi belirleniyor
                filter.CenterColor = new RGB(Color.FromArgb(15, 10, 0));
                filter.Radius = 50;
                // filtre calistiriliyor
                filter.ApplyInPlace(image1);

                //Görüntü üzerinde algilanan rengi cevrcevelemek veya hedeflemek icin gerekli Methodlar
                cevresiniciz(image1);
                //hedefal(image);

            }

            if (radioButton2.Checked)
            {
                // Euclidean Color Filterin yapildigi yer
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // Algilanacak renk belirleniyor ve orta noktasi belirleniyor
                filter.CenterColor = new RGB(Color.FromArgb(8, 47, 114));
                filter.Radius = 50;
                // filtre calistiriliyor
                filter.ApplyInPlace(image1);

                //Görüntü üzerinde algilanan rengi cevrcevelemek veya hedeflemek icin gerekli Methodlar
                cevresiniciz(image1);
                //hedefal(image);
            }
        }

        private void cevresiniciz(Bitmap image)
        {
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 2;
            blobCounter.MinHeight = 2;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;

            Grayscale grayFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = grayFilter.Apply(image);

            blobCounter.ProcessImage(grayImage);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            
            
            foreach (Rectangle recs in rects)
            {

                if (rects.Length > 0)
                {
                    Rectangle objectRect = rects[0];
                    //Graphics g = Graphics.FromImage(image);
                    Graphics g = pictureBox1.CreateGraphics();
                    

                    using (Pen pen = new Pen(Color.FromArgb(242, 145, 9), 4))
                    {

                        g.DrawRectangle(pen, objectRect);
                    }

                    //Cizdirilen Dikdörtgenin Koordinatlari aliniyor.
                    int objectX = objectRect.X + (objectRect.Width / 2);
                    int objectY = objectRect.Y + (objectRect.Height / 2);
                 
                   
                  //Cizginin hangi koordinatlar üzerinde olduğunu görüntü üzerine yazdırıyor
                    g.DrawString(objectX.ToString() + " x " + objectY.ToString(), new Font("Arial", 9), Brushes.DarkOrange, new System.Drawing.Point(1, 1));
                    g.Dispose();

                    if (kontrolTipi == true) { //eğer otomatik butonuna tıklanmışsa webcam değerlerine göre çalış
                        if (objectX >= 350)
                        {     
                            yonLabel.Text = "Saga";
                            sp.Write("d");
                        }
                        else if (objectX <= 200 )
                        {                        
                            yonLabel.Text = "Sola";
                            sp.Write("a");
                        }
                        //if (objectX < 480 && objectX > 430)
                        else
                        {                        
                            yonLabel.Text = "Ileri";
                            sp.Write("w");
                        }

                        
                    }

                }
            }
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (calisti == true) { 
            if (cam.IsRunning)
            {
                cam.Stop();
            }
            }
            
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void otoBtn_Click(object sender, EventArgs e)
        {
            otoBtn.Enabled = false;
            kontoltipLabel.Text = "Otomatik";
            manBtn.Enabled = true;
            mangroupBox.Enabled = false;
            kontrolTipi = true;
        }

        private void manBtn_Click(object sender, EventArgs e)
        {
            manBtn.Enabled = false;
            kontoltipLabel.Text = "Manuel";
            otoBtn.Enabled = true;
            mangroupBox.Enabled = true;
            kontrolTipi = false;
            yonLabel.Text = "...";
        }


        private void ileriBtn_Click(object sender, EventArgs e)
        {
            yonLabel.Text = "Ileri";
            sp.Write("w");
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            yonLabel.Text = "Geri";
            sp.Write("s");
        }

        private void solBtn_Click(object sender, EventArgs e)
        {
            yonLabel.Text = "Sola";
            sp.Write("a");
        }

        private void sagBtn_Click(object sender, EventArgs e)
        {
            yonLabel.Text = "Saga";
            sp.Write("d");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (controlTextBox.Text)
            {
                case "w":
                    yonLabel.Text = "Ileri";
                    sp.Write("w");
                    break;
                case "s":
                    yonLabel.Text = "Geri";
                    sp.Write("s");
                    break;
                case "a":
                    yonLabel.Text = "Sola";
                    sp.Write("a");
                    break;
                case "d":
                    yonLabel.Text = "Saga";
                    sp.Write("d");
                    break;
            }
            controlTextBox.Text = "";
        }

        

     

      
    }
}
