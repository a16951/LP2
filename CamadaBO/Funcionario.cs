using System;

// <summary>
/// nome:João Carlos Martins Silva
/// numero:a16951
/// Data:22/05/2019
/// versao:2
/// classe funcionario trata de funcionarios que podem fazer coisas que na camada atletas nao podem
/// </summary>

namespace CamadaBO
{
    [Serializable]
    public class Funcionario: Pessoa
    {

        #region ATRIBUTOS
        int pass;

        #endregion


        #region METODOS
        #region CONSTRUTORES
       public Funcionario()
        {
            pass = 141;
        }



        /// <summary>
        /// construtor de funcionario
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="pass"></param>
        public Funcionario(string nome,int idade,int pass) : base(nome, idade)
        {
            this.pass = pass;
            
            
        }
        #endregion



        #region PROPRIEDADES

        public int Pass
        {
            get{ return pass; }
            set{ pass = value; }
        }
        #endregion

        #endregion

        //destrutor
        ~Funcionario()
        {

        }
    }
}
