using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCalismaApp
{
    public partial class ImageSlider : Form
    {
        public ImageSlider()
        {
            InitializeComponent();
        }

        private void ImageSlider_Load(object sender, EventArgs e)
        {
            LoadImagestoSlider();
        }
        private void LoadImagestoSlider()
        {
            string folderPath = @"C:\Users\burcu\source\repos\DevExpressCalismaApp\backgrounds";

            if (!Directory.Exists(folderPath))
                return;

            var imageFiles = Directory.GetFiles(folderPath, "*.jpg");
            imageSlider1.Images.Clear();
            foreach (var imageFile in imageFiles)
            {
                try
                {
                    imageSlider1.Images.Add(Image.FromFile(imageFile));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim yüklenemedi: " + ex.Message);
                }
            }

        }
    }
}