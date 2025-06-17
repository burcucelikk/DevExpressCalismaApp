namespace DevExpressCalismaApp
{
    partial class Anasayfa
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
            tileGroup6 = new DevExpress.XtraEditors.TileGroup();
            tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // tileGroup6
            // 
            tileGroup6.Name = "tileGroup6";
            // 
            // tileGroup1
            // 
            tileGroup1.Name = "tileGroup1";
            // 
            // tileGroup3
            // 
            tileGroup3.Name = "tileGroup3";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(116, 54);
            button1.TabIndex = 1;
            button1.Text = "Simple Button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(134, 12);
            button2.Name = "button2";
            button2.Size = new Size(116, 54);
            button2.TabIndex = 2;
            button2.Text = "Text-Button Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(256, 12);
            button3.Name = "button3";
            button3.Size = new Size(116, 54);
            button3.TabIndex = 3;
            button3.Text = "Image Slider";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(378, 12);
            button4.Name = "button4";
            button4.Size = new Size(116, 54);
            button4.TabIndex = 4;
            button4.Text = "Combo Box Edit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(500, 12);
            button5.Name = "button5";
            button5.Size = new Size(116, 54);
            button5.TabIndex = 5;
            button5.Text = "Chart Control";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Anasayfa";
            Text = "Anasayfa";
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.TileGroup tileGroup6;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}