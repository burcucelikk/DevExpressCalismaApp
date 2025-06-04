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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            tileGroup6 = new DevExpress.XtraEditors.TileGroup();
            tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
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
            // tileBar1
            // 
            tileBar1.DropDownOptions.BeakColor = Color.Empty;
            tileBar1.Groups.Add(tileBarGroup2);
            tileBar1.Location = new Point(-1, 0);
            tileBar1.MaxId = 5;
            tileBar1.Name = "tileBar1";
            tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            tileBar1.Size = new Size(801, 103);
            tileBar1.TabIndex = 0;
            tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            tileBarGroup2.Items.Add(tileBarItem1);
            tileBarGroup2.Items.Add(tileBarItem2);
            tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tileBarItem1
            // 
            tileBarItem1.DropDownOptions.BeakColor = Color.Empty;
            tileItemElement1.Text = "SimpleButton";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileBarItem1.Elements.Add(tileItemElement1);
            tileBarItem1.Id = 0;
            tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            tileBarItem1.Name = "tileBarItem1";
            // 
            // tileBarItem2
            // 
            tileBarItem2.DropDownOptions.BeakColor = Color.Empty;
            tileItemElement2.Text = "Text_Button";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileBarItem2.Elements.Add(tileItemElement2);
            tileBarItem2.Id = 1;
            tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            tileBarItem2.Name = "tileBarItem2";
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tileBar1);
            Name = "Anasayfa";
            Text = "Anasayfa";
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.TileGroup tileGroup6;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
    }
}