using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unagi.Estrutura;
using System.IO;
namespace Unagi
{
    class Musica : Midia, ILocal
    {
        //Fazer Enumerador de formato(MP3, WAV ou WMA);

        public static Lista ListaMusicas = new Lista();
        

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
            //Pergunta qual musica
            //Musica MPassada = ...
            //Alterar(MPassada)
        }
        public void Alterar(Musica MPassada)
        {
            foreach(Musica M in ListaMusicas)
            {
                if(M.Id == MPassada.Id)
                {
                    Excluir(M);
                    Incluir(MPassada);
                }
            }
        }        

        public override void Consultar(int id)//abrir forms com dados, e permitir alteração
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            //Pergunta qual musica
            //Musica MPassada = ...
            //Excluir(MPassada)
        }
        public void Excluir(Musica MPassada)
        {
            foreach (Musica M in ListaMusicas)
            {
                if (M.Id == MPassada.Id)
                {
                    ListaMusicas.RemoverDaPosicao(ListaMusicas.RetornaPosicao(M));
                }
            }
        }

        public override void Incluir()
        {
            throw new NotImplementedException();
        }
        public void Incluir(Musica MPassada)
        {
            ListaMusicas.InserirNoFim(MPassada);
        }

        public bool validaCaminho(string path)
        {
            return File.Exists(path);
        }
    }
}
