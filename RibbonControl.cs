using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCalismaApp
{
    public partial class RibbonControl : Form
    {
        public RibbonControl()
        {
            InitializeComponent();
        }

        FrmOgrenciler fr1;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 == null || fr1.IsDisposed)
            {
                fr1 = new FrmOgrenciler();
                fr1.MdiParent = this;
                fr1.Show();
            }
            else
                fr1.BringToFront();

        }
    }
}
