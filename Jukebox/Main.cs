using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jukebox
{
    public partial class Main : Form
    {
        public Media media;
        public Main()
        {
            InitializeComponent();
            media = new Media();

            Variaveis.albuns = Metodos.CarregarAlbuns(@"C:/Musicas/");
            Variaveis.albuns.Sort();

            LoadAlbumA(Variaveis.indexAlbumA);
            LoadAlbumB(Variaveis.indexAlbumB);




            

        }
        

        #region Componente_Timer
        private void tmr_Geral_Tick(object sender, EventArgs e)
        {

            lbl_Data.Text = "DATA: " + DateTime.Now.ToString("dd/MM/yyyy");
            lbl_Hora.Text = "HORA:  " + DateTime.Now.ToString("HH:mm:ss") + "    ";
            lbl_Data.Refresh();

            //Verificar se há alguma música tocanndo
            if (Variaveis.playingMusic)
            {
                pcbGifNotasMusicais.Visible = true;

            }
            else
            {
                pcbGifNotasMusicais.Visible = false;
            }

            
            if(Variaveis.playlist.Count > 0)
            {
                if (!Variaveis.playingMusic)
                {
                    TocarMusica();
                    Variaveis.playingMusic = true;
                    lblMusicPlaying.Text = Path.GetFileNameWithoutExtension(Variaveis.playlist[0]);


                    // Pega dados de duração da música e indica que horario ela terminará
                    var tfile = TagLib.File.Create(Variaveis.playlist[0]);
                    Variaveis.duracao = tfile.Properties.Duration;                    
                    Variaveis.horaIni= new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    string horaFim = Variaveis.horaIni.Add(Variaveis.duracao).ToString();
                    Variaveis.horaFinal = Variaveis.horaIni + Variaveis.duracao;
                    
                }
            }

            // Verifica se já finalizou a ultima musica
            if (Variaveis.playingMusic)
            {
                if (Metodos.VerificaFimMusica())
                {
                    Variaveis.playingMusic = false;
                    Variaveis.playlist.RemoveAt(0);
                    lblMusicPlaying.Text ="";

                }
            }

            // Atualizar labels 
            lblQtdeMusicas.Text = "Músicas Selecionadas:  " + Variaveis.playlist.Count + "    ";

        }
        #endregion

        #region Acoes_Teclas
        private void lstA_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Convert.ToInt32(e.KeyChar) == 32)
            {
                lstA.ClearSelected();
                SendKeys.Send("{TAB}");
                SendKeys.Send("{DOWN}");
            }

            if (Convert.ToInt32(e.KeyChar) == 13)
            {

                string musicaSelecionada = Path.GetFullPath(Metodos.RetornaMusicaSelecionada(Variaveis.indexAlbumA, lstA.SelectedIndex));
                Variaveis.playlist.Add(musicaSelecionada);                
                //lblMusicPlaying.Text =  lstA.SelectedItem.ToString();
              

            }



        }

        private void lstB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 32)
            {
                lstB.ClearSelected();
                SendKeys.Send("{TAB}");
                SendKeys.Send("{DOWN}");
            }


            if (Convert.ToInt32(e.KeyChar) == 13)
            {

                string musicaSelecionada = Path.GetFullPath(Metodos.RetornaMusicaSelecionada(Variaveis.indexAlbumB, lstB.SelectedIndex));
                Variaveis.playlist.Add(musicaSelecionada);
                //lblQtdeMusicas.Text = "Músicas Selecionadas:  " + Variaveis.playlist.Count + "    ";
                //lblMusicPlaying.Text = lstB.SelectedItem.ToString();

            }

        }
        #endregion

        #region Métodos
        private void lstA_KeyDown(object sender, KeyEventArgs e)



        {

            if (Convert.ToInt32(e.KeyCode) == 39)
            {
                lstA.ClearSelected();
                SendKeys.Send(" ");

            }

            if (Convert.ToInt32(e.KeyCode) == 37)
            {
                if (Variaveis.indexAlbumA > 0)
                {
                    // Carrega dados do Album A (esquerda)
                    Variaveis.indexAlbumA += -1;
                    LoadAlbumA(Variaveis.indexAlbumA);

                    // Carrega dados do Album B (direita)
                    Variaveis.indexAlbumB += -1;
                    LoadAlbumB(Variaveis.indexAlbumB);
                    SendKeys.Send(" ");
                }

            }

        }

        private void lstB_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 37)
            {
                lstB.ClearSelected();
                SendKeys.Send(" ");
            }

            if (Convert.ToInt32(e.KeyCode) == 39)
            {
                if (Variaveis.indexAlbumB < Variaveis.albuns.Count - 1)
                {
                    // Carrega dados do Album A (esquerda)
                    lstA.Items.Clear();
                    Variaveis.indexAlbumA += 1;
                    List<String> musicas = Metodos.CarregarMusicas(Variaveis.albuns[Variaveis.indexAlbumA]);
                    foreach (var item in musicas)
                    {
                        lstA.Items.Add(Path.GetFileNameWithoutExtension(item.ToString()));

                    }
                    lblA.Text = Variaveis.albuns[Variaveis.indexAlbumA].ToString().Replace("C:/Musicas/", "");

                    PicBox_LadoA.Load(Metodos.CarregarCapaAlbum(Variaveis.albuns[Variaveis.indexAlbumA]));



                    // Carrega dados do Album B (direita)
                    lstB.Items.Clear();
                    Variaveis.indexAlbumB += 1;
                    musicas = Metodos.CarregarMusicas(Variaveis.albuns[Variaveis.indexAlbumB]);
                    foreach (var item in musicas)
                    {
                        lstB.Items.Add(Path.GetFileNameWithoutExtension(item.ToString()));
                    }
                    lblB.Text = Variaveis.albuns[Variaveis.indexAlbumB].ToString().Replace("C:/Musicas/", "");

                    PicBox_LadoB.Load(Metodos.CarregarCapaAlbum(Variaveis.albuns[Variaveis.indexAlbumB]));
                    SendKeys.Send(" ");
                }

            }
        }

        public void LoadAlbumA(int indexAlbum)
        {
            // Carrega dados do Album A (esquerda)
            lstA.Items.Clear();
            List<String> musicas = Metodos.CarregarMusicas(Variaveis.albuns[indexAlbum]);
            foreach (var item in musicas)
            {
                lstA.Items.Add(Path.GetFileNameWithoutExtension(item.ToString()));

            }
            lblA.Text = Variaveis.albuns[indexAlbum].ToString().Replace("C:/Musicas/", "");

            PicBox_LadoA.Load(Metodos.CarregarCapaAlbum(Variaveis.albuns[indexAlbum]));
        }

        public void LoadAlbumB(int indexAlbum)
        {
            // Carrega dados do Album B (direita)
            lstB.Items.Clear();
            List<String> musicas = Metodos.CarregarMusicas(Variaveis.albuns[indexAlbum]);
            musicas = Metodos.CarregarMusicas(Variaveis.albuns[indexAlbum]);
            foreach (var item in musicas)
            {
                lstB.Items.Add(Path.GetFileNameWithoutExtension(item.ToString()));
            }
            lblB.Text = Variaveis.albuns[indexAlbum].ToString().Replace("C:/Musicas/", "");

            PicBox_LadoB.Load(Metodos.CarregarCapaAlbum(Variaveis.albuns[indexAlbum]));
      
        }

        public  void TocarMusica()
        {

            media.Play(Variaveis.playlist[0].ToString(), this);
            RefreshStop(true);


        }

        //Override the WndProc function in the form
        //to receive the notify message when the playback complete
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Media.MM_MCINOTIFY)
            {
                RefreshStop(false);
            }
            base.WndProc(ref m);
        }


        private void RefreshStop(bool stop)
        {
            //stopButton.Enabled = stop;
        }

        #endregion
    }
}
