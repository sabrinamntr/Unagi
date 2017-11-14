using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unagi.Estrutura;

namespace Unagi
{
    class Foto : Midia, ILocal, ICatalogo
    {
        public static Lista ListaFotos = new Lista();

        private string localizacao;

        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }
        private double megaPixels;

        public double MegaPixels
        {
            get { return megaPixels; }
            set { megaPixels = value; }
        }
        private int tempoDeExibicao;

        public int TempoDeExibicao
        {
            get { return tempoDeExibicao; }
            set { tempoDeExibicao = value; }
        }
        private string arquivoMidia;

        public string ArquivoMidia
        {
            get { return arquivoMidia; }
            set { arquivoMidia = value; }
        }
        private int anoDeLancamento;

        public int AnoDeLancamento
        {
            get { return anoDeLancamento; }
            set { anoDeLancamento = value; }
        }



        public override void Alterar()
        {
            throw new NotImplementedException();
        }

        public override void Consultar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }
        public void Excluir(Foto FPassada)
        {
            foreach (Foto F in ListaFotos)
            {
                if (F.Id == FPassada.Id)
                {
                    ListaFotos.RemoverDaPosicao(ListaFotos.RetornaPosicao(F));
                }
            }
        }

        public override void Incluir()
        {
            throw new NotImplementedException();
        }
        public void Incluir(Foto FPassada)
        {
            ListaFotos.InserirNoFim(FPassada);
        }

        public bool validaCaminho(string path)
        {
            return File.Exists(path);
        }

    }
}
