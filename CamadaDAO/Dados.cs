using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using CamadaBO;

/// <summary>
/// nome:João Carlos Martins Silva
/// numero:a16951
/// Data:22/05/2019
/// versao:2
/// classe Dados que serve para tratar dos dados do programa
/// </summary>


namespace CamadaDAO
{
    [Serializable]
    public class Dados
    {
        public Dados()
        {

        }


       
        // list de atletas 
        static List<Atleta> atleta = new List<Atleta>();


        // list de atletas de atletismo
        static List<Atleta> atleta1 = new List<Atleta>();


        #region metodos variados

        /// <summary>
        ///funçao adiciona atleta no list 
        /// /summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool Add(Atleta x)
        {
            
            if (!atleta.Contains(x))
            {
                

                 atleta.Add(x);
                return true;

            }
            else  return false;
         }

        /// <summary>
        /// para atletismo
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool Add1(Atleta x)
        {

            if (!atleta.Contains(x))
            {
                

                atleta1.Add(x);
                return true;

            }
            else return false;
        }



        /// <summary>
        /// funçao de eliminar um atleta
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool Elimina(int codigo,Funcionario a)
        {
            if (a.Nome == "joao" && a.Pass == 123)
            {
                for (int i = 0; i < atleta.Count(); i++)
                {
                    if (codigo.Equals(atleta[i].CodigoAtleta))
                    {
                        atleta.Remove(atleta[i]);
                        return true;
                    }

                }
                for(int i = 0; i < atleta1.Count(); i++)
                {
                    if(codigo.Equals(atleta1[i].CodigoAtleta))
                    {
                        atleta1.Remove(atleta1[i]);
                        return true;
                    }
                }
            }
            return false;
           
        }




       /// <summary>
       /// funçao que ordena
       /// </summary>
       /// <returns></returns>
        public static List<Atleta> Ordena()
        {
                List<Atleta> listordenada = atleta1.OrderBy(o => o.Tempo).ToList();
            return (List<Atleta>)listordenada;
        }


        /// <summary>
        /// funçao que envia a list
        /// </summary>
        /// <returns></returns>
        public static List<Atleta> Envia()
        {
          
            return (List<Atleta>)atleta;
        }

        #endregion


        #region ficheiro
        /// <summary>
        /// para salvar ficheiro de atletas normais
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Save(string fileName)
        {
            
            var binformatter = new BinaryFormatter();
            try
            {
                Stream s = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, atleta);
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }


        /// <summary>
        /// funçao para salavar os atletas de atletismo
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool SaveAtl(string fileName)
        {
            var binformatter = new BinaryFormatter();
            try
            {
                Stream s = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, atleta1);
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }


        /// <summary>
        /// dar load do file de atletas
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Load(string fileName)
        {
            
            Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            if (s.Length <= 0) return true;
            atleta = (List<Atleta>)b.Deserialize(s);
            s.Close();
            return true;
        }


        /// <summary>
        /// dar load do file de atletas de atletismo
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool LoadAtle(string fileName)
        {
            
            Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            if (s.Length <= 0) return true;
            atleta1 = (List<Atleta>)b.Deserialize(s);
            s.Close();
            return true;
        }

        #endregion
    }
}
