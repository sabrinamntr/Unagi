using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Unagi.Estrutura;

namespace Unagi.Formularios
{
    public partial class frCadastro : Form
    {
        private int originalWidth;
        private int originalHeight;
        public frCadastro()
        {
            InitializeComponent();
            originalWidth = this.Width;
            originalHeight = this.Height;
        }

        private void btnCadastroMusica_Click(object sender, EventArgs e)
        {
            this.Width = 958;
            panelMusica.Visible = true;
            panelAlbum.Visible = false;
            panelVideo.Visible = false;
            panelFoto.Visible = false;
        }

        private void btnCadastroAlbum_Click(object sender, EventArgs e)
        {
            this.Width = 958;
            panelMusica.Visible = false;
            panelAlbum.Visible = true;
            panelVideo.Visible = false;
            panelFoto.Visible = false;
        }

        private void bntCadastroVideo_Click(object sender, EventArgs e)
        {
            this.Width = 958;
            panelMusica.Visible = false;
            panelAlbum.Visible = false;
            panelVideo.Visible = true;
            panelFoto.Visible = false;
        }

        private void btnCadastroFoto_Click(object sender, EventArgs e)
        {
            this.Width = 958;
            panelMusica.Visible = false;
            panelAlbum.Visible = false;
            panelVideo.Visible = false;
            panelFoto.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSalvarMusica_Click(object sender, EventArgs e)
        {
            Musica M = new Musica();
            M.Descricao = txtDescMusica.Text;
            M.ArquivoMidia = txtDiretorioMusica.Text;
            M.Volume = Convert.ToInt32(txtVolumeMusica.Text);
            M.Duracao = Convert.ToDouble(txtDuracaoMusica.Text);
            //PEGAR O FORMATO AQUI!!!!!!!!!
            M.Incluir(M);
            

        }

        private void btnDiretorioMusica_Click(object sender, EventArgs e)
        {
            string fullPath ="";
            OpenFileDialog FD = new OpenFileDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                fullPath = Path.GetFullPath(FD.FileName);
            }
            txtDiretorioMusica.Text = fullPath; 
        }

        private void panelMusica_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbFormatoMusica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarMusica_Click(object sender, EventArgs e)
        {
            frLista telaLista = new frLista(Musica.ListaMusicas);
            telaLista.Show();
        }
    }
}
