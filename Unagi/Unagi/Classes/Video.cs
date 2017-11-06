using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unagi
{    
    class Video : Midia, ILocal, ICatalogo
    {
        //fazer enumerador : formato(AVI, WMV, MKV, MP4, MPEG, OUTROS????) e idioma (portugues, inglês, espanhol, outros)
        private string arquivoMidia;
        private int anoDeLancamento;
        bool possuiLegenda;

        public string ArquivoMidia { get => arquivoMidia; set => arquivoMidia = value; }
        public int AnoDeLancamento { get => anoDeLancamento; set => anoDeLancamento = value; }
        public bool PossuiLegenda { get => possuiLegenda; set => possuiLegenda = value; }

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
