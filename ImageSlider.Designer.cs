namespace DevExpressCalismaApp
{
    partial class ImageSlider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)imageSlider1).BeginInit();
            SuspendLayout();
            // 
            // imageSlider1
            // 
            imageSlider1.AllowLooping = true;
            imageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            imageSlider1.AutoSlideInterval = 2000;
            imageSlider1.Location = new Point(-1, -1);
            imageSlider1.Name = "imageSlider1";
            imageSlider1.Size = new Size(534, 506);
            imageSlider1.TabIndex = 0;
            imageSlider1.Text = "imageSlider1";
            // 
            // ImageSlider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 503);
            Controls.Add(imageSlider1);
            Name = "ImageSlider";
            Text = "ImageSlider";
            Load += ImageSlider_Load;
            ((System.ComponentModel.ISupportInitialize)imageSlider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
    }
}