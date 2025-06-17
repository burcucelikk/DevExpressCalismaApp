using DevExpress.XtraEditors;
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
    public partial class Anasayfa : Form
    {
        SimpleButton simpleButton;
        TextEdit_ButtonEdit text_button;
        ImageSlider imageSlider;
        ComboBoxEdit comboBoxEdit;
        ChartControl chartControl;
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (simpleButton==null || simpleButton.IsDisposed)
            {
                this.Hide();
                using(var form= new SimpleButton())
                {
                    form.ShowDialog();
                }
                this.Show();
            }
            else
                simpleButton.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(text_button==null|| text_button.IsDisposed)
            {
                this.Hide();
                using (var form=new TextEdit_ButtonEdit()) 
                { 
                    form.ShowDialog();
                }
                this.Show();
            }
            else
                text_button.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(imageSlider==null || imageSlider.IsDisposed)
            {
                this.Hide();
                using( var form=new ImageSlider())
                {
                    form.ShowDialog();
                }
                this.Show();
            }
            else
                imageSlider.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBoxEdit == null || comboBoxEdit.IsDisposed)
            {
                this.Hide();
                using(var form=new ComboBoxEdit())
                {
                    form.ShowDialog();
                }
                this.Show();
            }
            else
                comboBoxEdit.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (chartControl == null || chartControl.IsDisposed)
            {
                this.Hide();
                using (var chart = new ChartControl())
                {
                    chart.ShowDialog();
                }
                this.Show();
            }
            else
                this.BringToFront();
        }
    }
}
