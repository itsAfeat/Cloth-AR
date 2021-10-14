// System.* libs
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

// Emgu.* libs
using Emgu.CV;
using Emgu.CV.Structure;

namespace Clother
{
    public partial class MainForm : Form
    {
        menuForm menu;

        readonly VideoCapture capture = new VideoCapture(0, VideoCapture.API.Any);
        readonly CascadeClassifier casFace = new CascadeClassifier(@"haarcascade_frontalface_default.xml");
        Image<Bgr, byte> showImg;
        Rectangle ost;

        int counter = 3;
        bool timerOn = false;
        bool showingImg = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menu = new menuForm();

            capture.Start();
            capture.ImageGrabbed += Capture_ImageGrabbed;

            timeLabel.Text = "3";
            saveBtn.Enabled = false;
            conBtn.Enabled = false;
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            if (!showingImg)
            {
                Mat m = new Mat();
                capture.Retrieve(m);
                picBox.Image = m.Bitmap;
            }
        }

        private void PicTimer_Tick(object sender, EventArgs e)
        {
            if (capture.QueryFrame() != null)
            {

                Mat m = new Mat();
                capture.Retrieve(m);
                Image<Bgr, byte> currFrame = m.ToImage<Bgr, byte>();
                Image<Gray, byte> grayFrame = currFrame.Convert<Gray, byte>();
                if (!showingImg)
                {
                    Rectangle[] faces = casFace.DetectMultiScale(grayFrame, 1.1, 8);
                    if (faces.Length > 0)
                    {
                        stateBox.BackColor = Color.LawnGreen;
                        if (menu.Img.filepath == "slot.png")
                        {
                            ost = new Rectangle(Convert.ToInt32(faces[0].X + (faces[0].Width / 2)), faces[0].Y + (faces[0].Height - 10), Convert.ToInt32(faces[0].Width * 4), faces[0].Height * 4);
                        }
                        else
                        {
                            ost = new Rectangle(Convert.ToInt32(faces[0].X + (faces[0].Width / 2)), faces[0].Y + (faces[0].Height + 5), Convert.ToInt32(faces[0].Width * 3.6), faces[0].Height * 3);
                        }
                    }
                    else
                    {
                        stateBox.BackColor = Color.Maroon;
                    }
                }

                if (timerOn && stateBox.BackColor == Color.LawnGreen)
                {
                    counter--;
                    timeLabel.Text = counter.ToString();
                }

                if (counter == 0 && timerOn)
                {
                    showImg = currFrame;
                    counter = 5;

                    showingImg = true;
                    timerOn = false;
                }

                if (showingImg)
                {
                    if (!saveBtn.Enabled)
                    {
                        picBtn.Enabled = false;
                        saveBtn.Enabled = true;
                        conBtn.Enabled = true;
                    }

                    if (counter == 4)
                    {
                        using (var canvas = Graphics.FromImage(showImg.Bitmap))
                        {
                            canvas.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            canvas.DrawImage(showImg.Bitmap, picBox.Location);
                            canvas.DrawImage(menu.Img.image, new Rectangle(Convert.ToInt32(ost.X - ost.Width / 2), ost.Y, ost.Width, ost.Height + ost.Height / 2));
                            canvas.Save();
                        }

                        picBox.Image = showImg.Bitmap;
                    }
                    counter--;
                }
            }
        }

        private void PicBtn_Click(object sender, EventArgs e)
        {
            if (menu.Img.image != null)
            {
                if (!timerOn && !showingImg && stateBox.BackColor == Color.LawnGreen)
                {
                    timerOn = true;
                    counter = 3;
                    timeLabel.Text = counter.ToString();
                }
            }
            else
                MessageBox.Show("No clothes has been selected", "No clothes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp",
                Title = "Save image"
            };
            saveFileDialog.ShowDialog();

            using (FileStream fs = (FileStream)saveFileDialog.OpenFile())
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        picBox.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        picBox.Image.Save(fs, ImageFormat.Bmp);
                        break;

                }
            }

            picBtn.Enabled = true;
            saveBtn.Enabled = false;
            conBtn.Enabled = false;
            timeLabel.Text = "3";
        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            showingImg = false;

            picBtn.Enabled = true;
            saveBtn.Enabled = false;
            conBtn.Enabled = false;
            timeLabel.Text = "3";
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            menu.Show();
            menu.Start();
            menu.Location = new Point(Convert.ToInt32(Location.X - Width / 5), Convert.ToInt32(Location.Y + 10));
        }
    }
}
