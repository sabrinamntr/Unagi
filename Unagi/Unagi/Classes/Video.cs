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
        bool possuiLegenda;

        public bool PossuiLegenda
        {
            get { return possuiLegenda; }
            set { possuiLegenda = value; }
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
