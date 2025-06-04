namespace DevExpressCalismaApp
{
    partial class FrmOgrenciler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciler));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(543, 75);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(35, 22);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "ID :";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(543, 136);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(38, 22);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "AD :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(506, 199);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(75, 22);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "SOYAD :";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(584, 77);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(188, 22);
            textEdit1.TabIndex = 3;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(584, 136);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(188, 22);
            textEdit2.TabIndex = 4;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(587, 201);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(188, 22);
            textEdit3.TabIndex = 5;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new Point(611, 261);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(118, 36);
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "TEMİZLE";
            // 
            // FrmOgrenciler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(simpleButton1);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Name = "FrmOgrenciler";
            Text = "FrmOgrenciler";
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}