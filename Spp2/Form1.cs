using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spp2
{
    public partial class Form1 : Form
    {
        Image LoadedImage;
        bool EnableDraw = false;
        bool draw = false;
        Point priviousPoint;
        Color color = Color.Red;
        public Form1()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                LoadedImage = pictureBox1.Image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);

                }
                catch (Exception error)
                {

                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            float value = trackBar2.Value*0.01f;
            float[][] colorMatrixElements = { 
                new float[] {1,  0,  0,  0, 0},        // red scaling factor of 2
                new float[] {0,  1,  0,  0, 0},        // green scaling factor of 1
                new float[] {0,  0,  1,  0, 0},        // blue scaling factor of 1
                new float[] {0,  0,  0,  1, 0},        // alpha scaling factor of 1
                new float[] {value, value, value, 0, 1}
            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            Image _img = LoadedImage;
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            pictureBox1.Image = bm_dest;
            pictureBox1.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Size modifiedSize = new Size((LoadedImage.Width * trackBar1.Value) / 10, (LoadedImage.Height * trackBar1.Value) / 10);
            Bitmap bm_source = new Bitmap(LoadedImage);
            // Make a bitmap for the result.
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(modifiedSize.Width), Convert.ToInt32(modifiedSize.Height));
            // Make a Graphics object for the result Bitmap.
            Graphics gr_dest = Graphics.FromImage(bm_dest);
            // Copy the source image into the destination bitmap.
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
            // Display the result.
            pictureBox1.Image = bm_dest;
            pictureBox1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
            {
                button5.Text = "TurnOffSizeChangedMode";
                trackBar1.Show();
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                button5.Text = "TurnOnSizeChangedMode";
                trackBar1.Hide();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (EnableDraw)
            {
                DrawButton.Text = "EnableDraw";
                EnableDraw = false;
            }
            else
            {
                DrawButton.Text = "DisableDraw";
                EnableDraw = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Up");
            draw = false;
        }

        private int TranslateToImageX(int x)
        {
            return x;
        }

        private int TranslateToImageY(int y)
        {
            return y;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(e.X.ToString() + "/" + e.Y.ToString());
           // MessageBox.Show(pictureBox1.Image.Height.ToString() + "/" + pictureBox1.Image.Width.ToString());
            priviousPoint = e.Location;
            draw = true;
            /*
            Graphics graph = Graphics.FromImage(pictureBox1.Image);
            graph.FillEllipse(new SolidBrush(Color.Red), TranslateToImageY(e.X), TranslateToImageY(e.Y), 5, 5);
            graph.Save();
            pictureBox1.Refresh();
            LoadedImage = (Bitmap)pictureBox1.Image; 
        */
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {           
            if (draw && EnableDraw) 
            {
                Graphics graph = Graphics.FromImage(pictureBox1.Image);
                graph.DrawLine(new Pen(new SolidBrush(Color.Red)), priviousPoint, e.Location);
                priviousPoint = e.Location;
                //graph.FillEllipse(new SolidBrush(Color.Red), TranslateToImageX(e.X), TranslateToImageY(e.Y), 5, 5); 
                graph.Save(); 
                pictureBox1.Refresh(); 
                LoadedImage = (Bitmap)pictureBox1.Image; 

            } 
            /*
            if (draw)
            {
                Graphics g = Graphics.FromImage(LoadedImage);
                SolidBrush brush = new SolidBrush(color);
                g.FillRectangle(brush, e.X, e.Y, 5, 5);
                g.Save();
                pictureBox1.Image = LoadedImage;
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
