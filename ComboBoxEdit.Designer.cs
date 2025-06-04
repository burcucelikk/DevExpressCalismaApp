namespace DevExpressCalismaApp
{
    partial class ComboBoxEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBoxEdit));
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listBoxControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            SuspendLayout();
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.EditValue = "Seçiniz";
            comboBoxEdit1.Location = new Point(22, 310);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.Items.AddRange(new object[] { "Ali", "Ayşe", "Barış", "Burak", "Burcu", "Eylül", "Fatma", "Hayriye", "İskender", "Rıfkı", "Veli" });
            comboBoxEdit1.Properties.Sorted = true;
            comboBoxEdit1.Size = new Size(183, 22);
            comboBoxEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new Point(93, 408);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(112, 36);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "EKLE";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(22, 357);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(183, 22);
            textEdit1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            simpleButton2.ImageOptions.Image = (Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            simpleButton2.Location = new Point(361, 88);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(112, 36);
            simpleButton2.TabIndex = 4;
            simpleButton2.Text = "KAYDET";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // listBoxControl1
            // 
            listBoxControl1.HorizontalScrollbar = true;
            listBoxControl1.Items.AddRange(new object[] { "Akdeniz", "Karadeniz", "Ege", "Marmara", "Güney Doğu Anadolu", "Doğu Anadolu", "İç Anadolu" });
            listBoxControl1.Location = new Point(22, 12);
            listBoxControl1.Name = "listBoxControl1";
            listBoxControl1.SelectionMode = SelectionMode.MultiExtended;
            listBoxControl1.Size = new Size(203, 203);
            listBoxControl1.TabIndex = 5;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(277, 36);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(196, 22);
            textEdit2.TabIndex = 6;
            // 
            // ComboBoxEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 503);
            Controls.Add(textEdit2);
            Controls.Add(listBoxControl1);
            Controls.Add(simpleButton2);
            Controls.Add(textEdit1);
            Controls.Add(simpleButton1);
            Controls.Add(comboBoxEdit1);
            Name = "ComboBoxEdit";
            Text = "ComboBoxEdit";
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)listBoxControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}