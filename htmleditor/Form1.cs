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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        htmleditorfrm htmlef = new htmleditorfrm();

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            htmlef.MdiParent = this;
            htmlef.Show();
        }

        private void htmlToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            htmlef.insertstring("<html> </html>");
        }
    }
}
