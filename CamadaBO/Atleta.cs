using System;

// <summary>
/// nome:João Carlos Martins Silva
/// numero:a16951
/// Data:22/05/2019
/// versao:2
/// classe pessoa trata de uma atleta com construtores etc que herda da classe pessoa
/// </summary>

namespace CamadaBO
{
    [Serializable]
    public class Atleta: Pessoa
    {
        #region ATRIBUTOS
        int codigoAtleta;
        string desporto;
        double tempos;
        #endregion

        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// construtor por defeito
        /// </summary>
        public Atleta()
        {
            codigoAtleta = 1;
            desporto = "Futsal";
            tempos = 0;
        }

        /// <summary>
        /// construtor de fora
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="codigoAtleta"></param>
        /// <param name="desporto"></param>
        /// <param name="tempos"></param>
        public Atleta(string nome, int idade, int codigoAtleta,string desporto,double tempos) : base(nome, idade)
        {
            this.desporto = desporto;
            this.tempos = tempos;
            this.codigoAtleta = codigoAtleta;
        }


        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Manipula o atributo codigoAtleta
        /// </summary>
        public int CodigoAtleta
        {
            get { return codigoAtleta; }
            set { if (value >= 0) codigoAtleta = value; }
        }

        /// <summary>
        /// Manipula o atributo desporto
        /// </summary>
        public string Desporto
        {
            get { return desporto; }
            set { desporto = value; }
        }

        /// <summary>
        /// Manipula o atributo tempos
        /// </summary>
        public double Tempo
        {
            get { return tempos; }
            set { if (value > 0) tempos = value; }
        }

        #endregion


       


        #endregion

        //destrutor
        ~Atleta()
        {

        }

    }

}
