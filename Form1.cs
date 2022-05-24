using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProPDFReader
{
    public partial class ProPDFReader : Form
    {
        public ProPDFReader()
        {
            InitializeComponent();
        }

        private void openPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF File | *.pdf";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                acroPDF1.LoadFile(ofd.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acroPDF1.Dispose();
            this.Close();
        }
    }
}
