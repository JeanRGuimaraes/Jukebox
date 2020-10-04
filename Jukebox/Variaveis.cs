using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
    class Variaveis
    {
        public static int LadoA_KeyPress = 0;
        public static int LadoB_KeyPress = 0;
        public static List<string> albuns = new List<string>();
        public static List<string> musicas = new List<string>();
        public static List<string> playlist = new List<string>();

        public static int indexAlbumA = 0;
        public static int indexAlbumB = 1;

        public static int[] horaMinutoProxMusica = { 0, 0 };

        public static TimeSpan duracao;
        public static TimeSpan horaIni;
        public static TimeSpan horaFinal;



        public static bool playingMusic = false;
    }
}
