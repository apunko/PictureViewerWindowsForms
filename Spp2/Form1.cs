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
    public partial class pictureViewerForm : Form
    {
        Image LoadedImage;
        bool EnableDraw = false;
        bool draw = false;
        bool sizeChangeMode = false; 
        Point priviousPoint;

        Color color = Color.Red;
        int thickness = 1;
        public pictureViewerForm()
        {
            InitializeComponent();
            panelWithPictureBox.AutoScroll = true;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            DrawPanel.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openImageFileDialog.FileName);
                LoadedImage = pictureBox.Image;
                DrawPanel.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image.Save(saveImageDialog.FileName);

                }
                catch (Exception error)
                {
                    MessageBox.Show("Sorry! Can't save image {0}", error.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Refresh();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            float value = brightnessTrackBar.Value*0.01f;
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
            pictureBox.Image = bm_dest;
            pictureBox.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Size modifiedSize = new Size((LoadedImage.Width * resizeTrackBar.Value) / 10, (LoadedImage.Height * resizeTrackBar.Value) / 10);
            Bitmap bm_source = new Bitmap(LoadedImage);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(modifiedSize.Width), Convert.ToInt32(modifiedSize.Height));
            Graphics gr_dest = Graphics.FromImage(bm_dest);
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
            pictureBox.Image = bm_dest;
            pictureBox.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sizeChangeMode == false)
            {
                sizeChangeMode = true;
                brightnessTrackBar.Hide();
                resizeTrackBar.Show();
            }
            else
            {
                sizeChangeMode = false;
                resizeTrackBar.Hide();
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {        
            if (EnableDraw)
            {
                thicknessTrackBar.Hide();
                EnableDraw = false;
            }
            else
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    color = colorDialog.Color;
                    thicknessTrackBar.Show();
                    EnableDraw = true;
                }
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (EnableDraw)
            {
                priviousPoint = e.Location;
                draw = true;
                Graphics graph = Graphics.FromImage(pictureBox.Image);
                graph.FillEllipse(new SolidBrush(color), e.X, e.Y, thickness, thickness);
                graph.Save();
                pictureBox.Refresh();
                LoadedImage = (Bitmap)pictureBox.Image;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw && EnableDraw)
            {
                Graphics graph = Graphics.FromImage(pictureBox.Image);
                graph.DrawLine(new Pen(new SolidBrush(color), thickness), priviousPoint, e.Location);
                priviousPoint = e.Location;
                graph.Save();
                pictureBox.Refresh();
                LoadedImage = (Bitmap)pictureBox.Image;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (brightnessTrackBar.Visible)
            {
                brightnessTrackBar.Hide();
            }
            else
            {
                brightnessTrackBar.Show();
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

            int Value = contrastTrackBar.Value;
            Bitmap oBitmap = default(Bitmap);
            oBitmap = (Bitmap)LoadedImage;
            Graphics oGraphic = default(Graphics);
            Bitmap bmpNew = new Bitmap(oBitmap.Width, oBitmap.Height);
            oGraphic = Graphics.FromImage(bmpNew);
            float[][] FloatColorMatrix ={
                        new float[] {Value, 0f, 0f, 0f, 0f},
                        new float[] {0f, Value, 0f, 0f, 0f},
                        new float[] {0f, 0f, Value, 0f, 0},
                        new float[] {0f, 0f, 0f, 1f, 0f},
                        new float[] {0.001f, 0.001f, 0.001f, 0f, 1f}
                    };
            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);
            ImageAttributes Attributes = new ImageAttributes();
            Attributes.SetColorMatrix(NewColorMatrix);
            oGraphic.DrawImage(oBitmap, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), 0, 0, oBitmap.Width, oBitmap.Height, GraphicsUnit.Pixel, Attributes);
            oBitmap = bmpNew;
            pictureBox.Image = oBitmap;
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (contrastTrackBar.Visible)
            {
                contrastTrackBar.Hide();
            }
            else
            {
                contrastTrackBar.Show();
            }
        }

        private void thicknessTrackBar_Scroll(object sender, EventArgs e)
        {
            thickness = thicknessTrackBar.Value;
        }
    }
}
