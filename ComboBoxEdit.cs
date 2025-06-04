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
    public partial class ComboBoxEdit : Form
    {
        public ComboBoxEdit()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string newItem = textEdit1.Text.Trim();
            if (string.IsNullOrEmpty(newItem))
                MessageBox.Show("Boş değer girilemez");
            else if (comboBoxEdit1.Properties.Items.Contains(newItem))
                MessageBox.Show("Aynı isim bulunmaktadır. Farklı bir değer giriniz.");
            else
                comboBoxEdit1.Properties.Items.Add(textEdit1.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string newItem2= textEdit2.Text.Trim();
            if (string.IsNullOrEmpty(newItem2))
                MessageBox.Show("Boş değer girilemez");
            else if(listBoxControl1.Items.Contains(newItem2))
                MessageBox.Show("Aynı bölge eklenemez.");
            else
                listBoxControl1.Items.Add(textEdit2.Text);
        }
    }
}
