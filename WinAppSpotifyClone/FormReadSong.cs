using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSpotifyClone
{
    public partial class FormReadSong : Form
    {
        
        public FormReadSong()
        {
            InitializeComponent();
        }

        private void FormReadSong_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDD_SpotifyMusicDataSet.TBL_SONG' Puede moverla o quitarla según sea necesario.
            this.tBL_SONGTableAdapter.Fill(this.bDD_SpotifyMusicDataSet.TBL_SONG);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnPlay1_Click(object sender, EventArgs e)
        {
            
            // Obtener la ruta del directorio de la aplicación
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construir la ruta relativa al archivo de sonido
            string relativePath = Path.Combine("SongFiles", "bensound-adventure.mp3");
            string fullPath = Path.Combine(appDirectory, relativePath);

            // Verificar si el archivo existe
            if (File.Exists(fullPath))
            {
                axWindowsMediaPlayer1.URL = fullPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("El archivo de sonido no se encuentra en la ubicación especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            // Obtener la ruta del directorio de la aplicación
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construir la ruta relativa al archivo de sonido
            string relativePath = Path.Combine("SongFiles", "bensound-dreams.mp3");
            string fullPath = Path.Combine(appDirectory, relativePath);

            // Verificar si el archivo existe
            if (File.Exists(fullPath))
            {
                axWindowsMediaPlayer1.URL = fullPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("El archivo de sonido no se encuentra en la ubicación especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPlay3_Click(object sender, EventArgs e)
        {
            // Obtener la ruta del directorio de la aplicación
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construir la ruta relativa al archivo de sonido
            string relativePath = Path.Combine("SongFiles", "bensound-energy.mp3");
            string fullPath = Path.Combine(appDirectory, relativePath);

            // Verificar si el archivo existe
            if (File.Exists(fullPath))
            {
                axWindowsMediaPlayer1.URL = fullPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("El archivo de sonido no se encuentra en la ubicación especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlay4_Click(object sender, EventArgs e)
        {
            // Obtener la ruta del directorio de la aplicación
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construir la ruta relativa al archivo de sonido
            string relativePath = Path.Combine("SongFiles", "bensound-scifi.mp3");
            string fullPath = Path.Combine(appDirectory, relativePath);

            // Verificar si el archivo existe
            if (File.Exists(fullPath))
            {
                axWindowsMediaPlayer1.URL = fullPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("El archivo de sonido no se encuentra en la ubicación especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlay5_Click(object sender, EventArgs e)
        {
            // Obtener la ruta del directorio de la aplicación
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construir la ruta relativa al archivo de sonido
            string relativePath = Path.Combine("SongFiles", "bensound-tomorrow.mp3");
            string fullPath = Path.Combine(appDirectory, relativePath);

            // Verificar si el archivo existe
            if (File.Exists(fullPath))
            {
                axWindowsMediaPlayer1.URL = fullPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("El archivo de sonido no se encuentra en la ubicación especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
