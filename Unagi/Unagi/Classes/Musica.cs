using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unagi
{
    class Musica : Midia, ILocal
    {
        //Fazer Enumerador de formato(MP3, WAV ou WMA);

        double duracao;

        public double Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }
        int volume;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        private string arquivoMidia;

        

        public string ArquivoMidia
        {
            get { return arquivoMidia; }
            set { arquivoMidia = value; }
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
