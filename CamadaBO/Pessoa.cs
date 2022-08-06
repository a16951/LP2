using System;
using System.Collections;
using System.Text;


// <summary>
/// nome:João Carlos Martins Silva
/// numero:a16951
/// Data:22/05/2019
/// versao:2
/// classe pessoa trata de uma pessoa com construtores etc
/// </summary>

namespace CamadaBO
{
    [Serializable]
    public class Pessoa
    {
        
            #region ESTADO

            int idade;
            string nome;



            #endregion


            #region METODOS

            #region CONSTRUTORES
            /// <summary>
            /// Construtor com valores por defeito/omissão
            /// </summary>
            public Pessoa()
            {
                idade = 20;
                nome = "Arroz";
            }

            /// <summary>
            /// Construtor com dados vindos do exterior
            /// Polimorfismo!
            /// </summary>
            /// <param name="i">Idade da Pessoa</param>
            /// <param name="n">Nome da Pessoa</param>
            public Pessoa(int i, string n)
            {
                idade = i;
                nome = n;
            }

            /// <summary>
            /// Construtor com dados vindos do exterior
            /// Polimorfismo!
            /// </summary>
            /// <param name="nome">Nome da Pessoa</param>
            /// <param name="idade">Idade da Pessoa</param>
            public Pessoa(string nome, int idade)
            {
                this.idade = idade;
                this.nome = nome;
            }

            #endregion


            #region PROPRIEDADES
            /// <summary>
            /// Manipula o atributo "idade"
            /// int idade;
            /// </summary>
            public int Idade
            {
                get { return idade; }
                set { if (value > 0) idade = value; }
            }


            /// <summary>
            /// Manipula o atributo "nome"
            /// string nome;
            /// </summary>
            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }



            #endregion



            #endregion



            #region OVERRIDES

            public override string ToString()
            {
                return "Idade: " + idade + " Nome:" + nome;
            }

            //comparar as pessoas pelo nome
            public override bool Equals(object x)
            {
                Pessoa aux = (Pessoa)x;
                if (aux.nome == this.nome)
                {
                    return true;
                }
                return false;
            }
            #endregion



            #region OPERADORES 

            //para conseguir usar o == em pessoas
            public static bool operator ==(Pessoa x, Pessoa y)
            {
                return (x.Equals(y));
            }

            public static bool operator !=(Pessoa x, Pessoa y)
            {
                return (!(x == y));
            }
            #endregion

            //destrutor 
            ~Pessoa()
            {

            }
        
    }
}
