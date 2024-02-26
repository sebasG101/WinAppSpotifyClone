using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSpotifyClone
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void eliminarCancionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarCancionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReadSong formReadSong = new FormReadSong(); 
            formReadSong.MdiParent = this;  
            formReadSong.Show();
        }
    }
}
