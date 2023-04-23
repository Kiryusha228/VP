using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class MainForm : Form
    {
        private Bitmap _sourceImage;
        private Images _images;
        private string _fileName;
        public MainForm()
        {
            InitializeComponent();
            _images = new Images();
            pictureBox.Visible = false;
            imageMenuItem.Enabled = false;
        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения(*.bmp; *.jpeg; *.jpg)| *.bmp; *.jpeg; *.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            using (var tmp = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
            {
                _sourceImage = new Bitmap(tmp);
            }
            _fileName = openFileDialog.FileName;

            _images.Add((Bitmap)_sourceImage.Clone());

            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Image = _sourceImage;
            this.Width = pictureBox.Width + 40;
            this.Height = pictureBox.Height + 77;
            this.CenterToScreen();
            pictureBox.Visible = true;
            imageMenuItem.Enabled = true;
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Изображение BMP|*.bmp;|Изображение JPEG|*.jpeg;|Изображение JPG|*.jpg;";
            saveFileDialog.ShowDialog();
            using (var tmp = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                var reg = @"\.(.+)$";

                if (Regex.Match(_fileName, reg).ToString() == ".jpeg" || Regex.Match(_fileName, reg).ToString() == ".jpg")
                {
                    _sourceImage.Save(tmp, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (Regex.Match(_fileName, reg).ToString() == ".bmp")
                {
                    _sourceImage.Save(tmp, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void filterMenuItem_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[3, 3] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
            _images.Add(ImageProcess.FilterImage(_sourceImage, matrix));
            _sourceImage = _images.Get();
            pictureBox.Image = _sourceImage;
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[3, 3] { { 0, 0.2, 0 }, { 0.2, 0.2, 0.2 }, { 0, 0.2, 0 } };
            _images.Add(ImageProcess.FilterImage(_sourceImage, matrix));
            _sourceImage = _images.Get();
            pictureBox.Image = _sourceImage;
        }

        private void усилитьКрайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[3, 3] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
            _images.Add(ImageProcess.FilterImage(_sourceImage, matrix));
            _sourceImage = _images.Get();
            pictureBox.Image = _sourceImage;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                _sourceImage = _images.Undo();
                pictureBox.Image = _sourceImage;
            }

            if (e.Control && e.KeyCode == Keys.Y)
            {
                _sourceImage = _images.Redo();
                pictureBox.Image = _sourceImage;
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                using (var tmp = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Write))
                {


                    var reg = @"\.(.+)$";

                    if (Regex.Match(_fileName, reg).ToString() == ".jpeg" || Regex.Match(_fileName, reg).ToString() == ".jpg")
                    {
                        _sourceImage.Save(tmp, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else if (Regex.Match(_fileName, reg).ToString() == ".bmp")
                    {
                        _sourceImage.Save(tmp, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                }
            }
        }
    }
}
