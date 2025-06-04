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
    public partial class TextEdit_ButtonEdit : Form
    {
        public TextEdit_ButtonEdit()
        {
            InitializeComponent();
        }

        private void TextEdit_ButtonEdit_Load(object sender, EventArgs e)
        {
            textEdit2.Text = "Hello World";
        }

    }
}
