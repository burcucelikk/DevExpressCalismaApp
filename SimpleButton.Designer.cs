namespace DevExpressCalismaApp
{
    partial class SimpleButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleButton));
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // simpleButton4
            // 
            simpleButton4.ImageOptions.Image = (Image)resources.GetObject("simpleButton4.ImageOptions.Image");
            simpleButton4.Location = new Point(174, 327);
            simpleButton4.Name = "simpleButton4";
            simpleButton4.Size = new Size(203, 49);
            simpleButton4.TabIndex = 11;
            simpleButton4.Text = "Çıkış";
            simpleButton4.Click += simpleButton4_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.ImageOptions.Image = (Image)resources.GetObject("simpleButton3.ImageOptions.Image");
            simpleButton3.Location = new Point(174, 251);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(203, 49);
            simpleButton3.TabIndex = 10;
            simpleButton3.Text = "Paint";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.ImageOptions.Image = (Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            simpleButton2.Location = new Point(174, 159);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(203, 49);
            simpleButton2.TabIndex = 9;
            simpleButton2.Text = "Hesap Makinesi";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new Point(174, 80);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(203, 49);
            simpleButton1.TabIndex = 8;
            simpleButton1.Text = "Hakkımda";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // SimpleButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 503);
            Controls.Add(simpleButton4);
            Controls.Add(simpleButton3);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Name = "SimpleButton";
            Text = "SimpleButton";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}