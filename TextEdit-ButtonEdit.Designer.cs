namespace DevExpressCalismaApp
{
    partial class TextEdit_ButtonEdit
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
            textBox1 = new TextBox();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            colorEdit1 = new DevExpress.XtraEditors.ColorEdit();
            calcEdit1 = new DevExpress.XtraEditors.CalcEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calcEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 140);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "WinForm TextBox";
            textBox1.Size = new Size(171, 27);
            textBox1.TabIndex = 4;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(67, 207);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.BackColor = Color.FromArgb(255, 255, 192);
            textEdit1.Properties.Appearance.Options.UseBackColor = true;
            textEdit1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            textEdit1.Properties.MaskSettings.Set("mask", "n");
            textEdit1.Size = new Size(171, 22);
            textEdit1.TabIndex = 3;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(67, 276);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.BackColor = Color.FromArgb(192, 255, 192);
            textEdit2.Properties.Appearance.Options.UseBackColor = true;
            textEdit2.Size = new Size(171, 22);
            textEdit2.TabIndex = 5;
            // 
            // colorEdit1
            // 
            colorEdit1.EditValue = Color.Empty;
            colorEdit1.Location = new Point(333, 206);
            colorEdit1.Name = "colorEdit1";
            colorEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            colorEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            colorEdit1.Size = new Size(171, 22);
            colorEdit1.TabIndex = 7;
            // 
            // calcEdit1
            // 
            calcEdit1.Location = new Point(333, 141);
            calcEdit1.Name = "calcEdit1";
            calcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcEdit1.Properties.ShowCloseButton = true;
            calcEdit1.Size = new Size(171, 22);
            calcEdit1.TabIndex = 8;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = Color.Red;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            labelControl1.Location = new Point(67, 59);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(171, 42);
            labelControl1.TabIndex = 9;
            labelControl1.Text = "Text Edit Örnekleri\r\n";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl2.Appearance.ForeColor = Color.Blue;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            labelControl2.Location = new Point(333, 59);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(171, 42);
            labelControl2.TabIndex = 10;
            labelControl2.Text = "Button Edit Örnekleri\r\n";
            // 
            // timeEdit1
            // 
            timeEdit1.EditValue = new DateTime(2025, 6, 3, 0, 0, 0, 0);
            timeEdit1.Location = new Point(333, 274);
            timeEdit1.Name = "timeEdit1";
            timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeEdit1.Size = new Size(171, 24);
            timeEdit1.TabIndex = 11;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(333, 336);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(171, 22);
            dateEdit1.TabIndex = 12;
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(13, 213);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(48, 16);
            labelControl4.TabIndex = 14;
            labelControl4.Text = "Nümerik";
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(13, 282);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(34, 16);
            labelControl5.TabIndex = 15;
            labelControl5.Text = "String";
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(276, 147);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(45, 16);
            labelControl6.TabIndex = 16;
            labelControl6.Text = "CalcEdit";
            // 
            // labelControl7
            // 
            labelControl7.Location = new Point(276, 212);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(51, 16);
            labelControl7.TabIndex = 17;
            labelControl7.Text = "ColorEdit";
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(276, 275);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(50, 16);
            labelControl3.TabIndex = 18;
            labelControl3.Text = "TimeEdit";
            // 
            // labelControl8
            // 
            labelControl8.Location = new Point(276, 339);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(47, 16);
            labelControl8.TabIndex = 19;
            labelControl8.Text = "DateEdit";
            // 
            // TextEdit_ButtonEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 503);
            Controls.Add(labelControl8);
            Controls.Add(labelControl3);
            Controls.Add(labelControl7);
            Controls.Add(labelControl6);
            Controls.Add(labelControl5);
            Controls.Add(labelControl4);
            Controls.Add(dateEdit1);
            Controls.Add(timeEdit1);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(calcEdit1);
            Controls.Add(colorEdit1);
            Controls.Add(textEdit2);
            Controls.Add(textBox1);
            Controls.Add(textEdit1);
            Name = "TextEdit_ButtonEdit";
            Text = "TextEdit_ButtonEdit";
            Load += TextEdit_ButtonEdit_Load;
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)colorEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)calcEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.ColorEdit colorEdit1;
        private DevExpress.XtraEditors.CalcEdit calcEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}