using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Unagi
{
    class Foto : Midia, ILocal, ICatalogo
    {
        private string localizacao;
        private double megaPixels;
        private int tempoDeExibicao;
        private string arquivoMidia;
        private int anoDeLancamento;

        public string ArquivoMidia { get => arquivoMidia; set => arquivoMidia = value; }
        public int AnoDeLancamento { get => anoDeLancamento; set => anoDeLancamento = value; }
        public string Localizacao { get => localizacao; set => localizacao = value; }
        public double MegaPixels { get => megaPixels; set => megaPixels = value; }
        public int TempoDeExibicao { get => tempoDeExibicao; set => tempoDeExibicao = value; }

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

        public override void Incluir()
        {
            throw new NotImplementedException();
        }

        public bool validaCaminho(string path)
        {
            throw new NotImplementedException();
        }
    }
}
