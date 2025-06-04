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
    public partial class SimpleButton : Form
    {
        
        public SimpleButton()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Burcu Çelik tarafından oluşturuldu.");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
