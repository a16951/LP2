using System;
using System.Collections;
using System.Collections.Generic;
using CamadaBO;
using CamadaDAO;


// <summary>
/// nome:João Carlos Martins Silva
/// numero:a16951
/// Data:22/05/2019
/// versao:2
/// classe controlo classe que faz ligaçao entre os danos e a main
/// </summary>

namespace CamadaBL
{
    public class Controlo
    {

        /// <summary>
        /// add novo atleta de fut
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool AddNovo(Atleta a)
        {

            if (a.Desporto == "atletismo" || a.Desporto == "ATLETISMO") return (Dados.Add1(a));

            return (Dados.Add(a));

        }
            /// <summary>
            /// funçao elemina
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static bool Eli(int a, Funcionario b)
            {
                if (b.Nome == "joao" && b.Pass == 123) return (Dados.Elimina(a, b));
                else return false;
            }


            #region file
            /// <summary>
            /// salvar o file
            /// </summary>
            /// <param name="g"></param>
            /// <returns></returns>
            public static bool Salvar(string g)
        {
            return (Dados.Save(g));
        }

        /// <summary>
        /// salvar o file de atletismo
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool SalvarAtle(string s)
        {
            return (Dados.SaveAtl(s));
        }

        /// <summary>
        /// abrir o file
        /// </summary>
        /// <param name="g"></param>
        ///// <returns></returns>
        public static bool File(string g)
        {
            return (Dados.Load(g));
       }

        /// <summary>
        /// abrir o file de atletismo
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool FileAtle(string s)
        {
            return (Dados.LoadAtle(s));
        }
        #endregion


        /// <summary>
        /// ordenada
        /// </summary>
        /// <returns></returns>
        public static List<Atleta> Ord()
        {
            return (Dados.Ordena());
        }
            


     

        
  

        

        /// <summary>
        /// Funçao para mostrar os atletas
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static List<Atleta> TabelaFut()
        {
            
                return (Dados.Envia());



        }
    }
}

