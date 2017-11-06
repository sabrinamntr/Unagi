using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Unagi
{
    class Musica : Midia, ILocal
    {
        //Fazer Enumerador de formato(MP3, WAV ou WMA);

        double duracao;
        int volume;
        private string arquivoMidia;

        public string ArquivoMidia { get => arquivoMidia; set => arquivoMidia = value; }
        public double Duracao { get => duracao; set => duracao = (true ? value : duracao = 0); } //faz validacao assim pra ficar bonitinho;
        public int Volume { get => volume; set => volume = value; }
        

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
