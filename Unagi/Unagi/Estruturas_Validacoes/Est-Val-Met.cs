using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Unagi
{
    namespace Metodos
    {
        public static class Arquivo
        {
            public static void CarregaMidias(Estrutura.Lista L)
            {
                if (!File.Exists("Banco.txt"))
                {
                    File.Create("Banco.txt");
                    return;
                }

                string[] arquivo = File.ReadAllLines("Banco.txt");
                foreach(string s in arquivo)
                {
                    string[] linha = s.Split();
                    switch (linha[0])
                    {
                        case "Musica":
                            addMusica(linha);
                            break;
                        case "Foto":
                            addFoto(linha);
                            break;
                            


                    }
                }

                void addMusica(string[] F)
                {

                }
                void addFoto(string[] F)
                {

                }
                
            
            }
        }

    }

    namespace Estrutura
    {
        public class Nodo
        {
            object dado;

            public object Dado
            {
                get { return dado; }
                set { dado = value; }
            }
            Nodo proximo;

            public Nodo Proximo
            {
                get { return proximo; }
                set { proximo = value; }
            }

            Nodo anterior;

            public Nodo Anterior
            {
                get { return anterior; }
                set { anterior = value; }
            }

            /// <summary>
            /// Construtor parametrizado
            /// </summary>
            /// <param name="dado"></param>
            /// <param name="proximo"></param>
            public Nodo(object dado, Nodo proximo)
            {
                this.dado = dado;
                this.proximo = proximo;
            }

            /// <summary>
            /// construtor sem parâmetros
            /// </summary>
            public Nodo()
            {
                dado = null;
                proximo = null;
                anterior = null;
            }
        }
        public class Lista : IEnumerable
        {
            Nodo primeiro = null;
            Nodo ultimo = null;
            int qtde = 0;


            private void InserirNaPosicao(Nodo anterior, object valor)
            {
                Nodo novo = new Nodo();
                novo.Dado = valor;

                if (anterior == null)
                {
                    if (qtde == 0)
                        primeiro = novo;
                    else
                    {
                        novo.Proximo = primeiro;
                        primeiro.Anterior = novo;
                        primeiro = novo;
                    }
                }
                else
                {
                    novo.Proximo = anterior.Proximo;
                    anterior.Proximo = novo;
                    novo.Anterior = anterior;
                    if (novo.Proximo != null)
                    {
                        novo.Proximo.Anterior = novo;
                    }
                }

                if (novo.Proximo == null)
                    ultimo = novo;

                qtde++;
            }

            public void InserirNoInicio(object valor)
            {
                InserirNaPosicao(null, valor);
            }
            public void InserirNoFim(object valor)
            {
                if (qtde == 0)
                {
                    InserirNoInicio(valor);
                }
                else
                {
                    InserirNaPosicao(ultimo, valor);
                }
            }
            /// <summary>
            /// Insere em uma posição, iniciando do 0
            /// </summary>
            /// <param name="valor">valor</param>
            /// <param name="posicao">posicao iniciando do 0</param>
            public void InserirNaPosicao(object valor, int posicao)
            {
                if (posicao > qtde || posicao < 0)
                    throw new Exception("Não é possível inserir.");

                if (posicao == 0)
                    InserirNoInicio(valor);
                else
                {
                    Nodo aux = primeiro;
                    for (int i = 1; i < posicao; i++)
                        aux = aux.Proximo;

                    InserirNaPosicao(aux, valor);
                }
            }


            public object RemoverDaPosicao(int posicao)
            {
                if (posicao >= qtde || posicao < 0 || qtde == 0)
                    throw new Exception("Não é possível remover.");

                object valor = "";
                qtde--;

                if (qtde == 0)
                {
                    valor = primeiro.Dado;
                    primeiro = ultimo = null;
                    return valor;
                }
                else
                {
                    //nodoApagado irá armazenar o nodo será apagado.
                    Nodo nodoApagado = primeiro;
                    for (int i = 1; i <= posicao; i++)  // encontra o elemento anterior ao que será apagado
                        nodoApagado = nodoApagado.Proximo;

                    valor = nodoApagado.Dado;

                    if (nodoApagado.Proximo == null) // ajusta o último
                        ultimo = nodoApagado.Anterior;

                    if (nodoApagado.Anterior == null) // ajusta o primeiro
                        primeiro = nodoApagado.Proximo;

                    if (nodoApagado.Anterior != null)
                        nodoApagado.Anterior.Proximo = nodoApagado.Proximo;

                    if (nodoApagado.Proximo != null)
                        nodoApagado.Proximo.Anterior = nodoApagado.Anterior;

                    return valor;
                }
            }


            public bool Existe(object dado)
            {
                Nodo aux = primeiro;
                while (aux != null)
                {
                    if (aux.Dado == dado)
                        return true;
                    aux = aux.Proximo;
                }

                return false;
            }

            public int RetornaPosicao(object dado)
            {
                int pos = 0;
                Nodo aux = primeiro;
                while (aux != null)
                {
                    if (aux.Dado == dado)
                        return pos;
                    aux = aux.Proximo;
                    pos++;
                }
                pos = -1;
                return pos;
            }


            /// <summary>
            /// Método listar recursivo
            /// </summary>
            /// <param name=""></param>
            /// <returns></returns>           


            public Nodo RetornaPrimeiro()
            {
                return primeiro;
            }

            Nodo nodoAtualParaForEach = null;

            public bool MoveNext()
            {
                if (nodoAtualParaForEach == null)
                    nodoAtualParaForEach = RetornaPrimeiro();
                else
                    nodoAtualParaForEach = nodoAtualParaForEach.Proximo;

                return nodoAtualParaForEach != null;
            }

            public void Reset()
            {
                nodoAtualParaForEach = null;
            }

            public IEnumerator GetEnumerator()
            {
                Reset();
                //return this as IEnumerator;
                return (IEnumerator)this;
            }


            public object Current
            {
                get
                {
                    return nodoAtualParaForEach.Dado;
                }
            }
        }
    }




    namespace Estrutura
    {

    }


}