using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace htmleditor
{
    public partial class htmleditorfrm : Form
    {
        public void insertstring(string s) {
            textBox1.Text += s;
        }
        public htmleditorfrm()
        {
            InitializeComponent();
        }

        private void htmleditorfrm_ResizeEnd(object sender, EventArgs e)
        {
            textBox1.Width = this.Width;
            textBox1.Height = this.Height;
        }

        private void htmleditorfrm_SizeChanged(object sender, EventArgs e)
        {
            textBox1.Width = this.Width;
            textBox1.Height = this.Height;
        }

 
    }
}
