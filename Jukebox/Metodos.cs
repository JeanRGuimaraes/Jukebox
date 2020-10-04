using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
    class Metodos
    {
        public static List<String> CarregarAlbuns(string caminho)
        {
            string[] aux;
            aux = Directory.GetDirectories(@caminho);
            List<String> albuns = new List<String>();
            foreach (var item in aux)
            {
                albuns.Add(item);
            }


            return albuns;
        }


        public static List<String> CarregarMusicas(string album)
        {
            List<String> musicas = new List<String>();
            string[] aux = Directory.GetFiles(album, "*.mp3");
            foreach (var item in aux)
            {
                musicas.Add(item);
            }


            return musicas;
        }


        public static string CarregarCapaAlbum(string album)
        {

            string[] aux = Directory.GetFiles(album, "*.jpg");
            foreach (var item in aux)
            {
                string toCompare = album + "/capa.jpg";
                toCompare = toCompare.Replace("\\", "/").ToUpper();
                string itemAux = item.Replace("\\", "/").ToUpper();

                if (itemAux.Equals(toCompare))
                {
                    return item.ToString();
                }
            }


            return "../../Imagens/no-image.jpg";
        }
        public static int GetIndexAlbumA()
        {
            return Variaveis.indexAlbumA;
        }

        public static int GetIndexAlbumB()
        {
            return Variaveis.indexAlbumB;
        }

        public static string RetornaMusicaSelecionada(int album, int indexMusica)
        {
            List<string> musicas = CarregarMusicas(Variaveis.albuns[album]);
            return musicas[indexMusica];
        }


        public static bool VerificaFimMusica()
        {
            if (DateTime.Now.Hour == Variaveis.horaFinal.Hours)
            {
                if (DateTime.Now.Minute == Variaveis.horaFinal.Minutes)
                
     {
                    if (DateTime.Now.Second >= Variaveis.horaFinal.Seconds)
                    {
                        return true;
                    }
                }
                if (DateTime.Now.Minute > Variaveis.horaFinal.Minutes)
                {
                    return true;
                }
            }

            return false;
        }


    }

}
