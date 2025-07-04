using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;// Adiciona a referência ao Windows Media Player

namespace Projeto_Mp3
{
    public partial class Frm_Musicas : Form
    {
        
        Dictionary<string, string> musicFiles = new Dictionary<string, string>(); // Dicionário para mapear nomes das músicas para seus caminhos
        WindowsMediaPlayer wmp = new WindowsMediaPlayer(); // Declara o objeto Windows Media Player
        int currentVolume = 50; // Volume inicial 
        List<string> currentMusicList = new List<string>(); // Lista de músicas para navegação

        public Frm_Musicas()
        {
            InitializeComponent();
        }

        private void Btn_X_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Voltar Para O Acesso?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_Acesso acesso = new Frm_Acesso();
                acesso.Show();
                Hide();
                wmp.controls.stop();
            }
            

        }
        private void Frm_Musicas_Load(object sender, EventArgs e)
        {
            

            // Adicionando itens ao primeiro ComboBox
            Cmb_Tipo.Items.Add("Nacional");
            Cmb_Tipo.Items.Add("Internacional");

            // Adicionando eventos SelectedIndexChanged
            Cmb_Tipo.SelectedIndexChanged += Cmb_Tipo_SelectedIndexChanged; //atualiza as opções do Cmb_Estilo com base no Cmb_Tipo
            Cmb_Estilo.SelectedIndexChanged += Cmb_Estilo_SelectedIndexChanged; //atualiza as opções do Cmb_Artista com base no Cmb_Estilo
            Cmb_Artista.SelectedIndexChanged += Cmb_Artista_SelectedIndexChanged; //atualiza as opções do Cmb_Musica com base no Cmb_Artista
            Cmb_Musica.SelectedIndexChanged += Cmb_Musica_SelectedIndexChanged; //Toca Musica

            // Inicializar volume do media player
            wmp.settings.volume = currentVolume;

            wmp.settings.volume = currentVolume; // Define o volume inicial do media player
            LblVolume.Text = $"Volume: {currentVolume}"; // Define o texto inicial do label de volume
            // Associar eventos de clique aos botões
            Btn_VolumeUp.Click += Btn_VolumeUp_Click;
            Btn_VolumeDown.Click += Btn_VolumeDown_Click;
           

            // Preencher o ComboBox de velocidade
            Cmb_Velocidade.Items.AddRange(new string[] { "0,25", "0,5", "0,75", "1,0", "1,25", "1,5", "1,75", "2,0" });
            Cmb_Velocidade.SelectedIndex = 3; // Define 1,0 como a velocidade padrão
            Cmb_Velocidade.SelectedIndexChanged += Cmb_Velocidade_SelectedIndexChanged_1;

            // Adicionando arquivos de música ao dicionário
            //Secos E Molhados
            musicFiles.Add("O Vira", "Musicas/Nacional/Mpb/Secos & Molhados/O Vira.mp3");
            musicFiles.Add("Sangue Latino", "Musicas/Nacional/Mpb/Secos & Molhados/Sangue Latino.mp3");
            musicFiles.Add("Assim Assado", "Musicas/Nacional/Mpb/Secos & Molhados/Assim Assado.mp3");
            musicFiles.Add("Rosa de Hiroshima", "Musicas/Nacional/Mpb/Secos & Molhados/Rosa de Hiroshima.mp3");
            musicFiles.Add("Amor", "Musicas/Nacional/Mpb/Secos & Molhados/Amor.mp3");
            musicFiles.Add("Fala", "Musicas/Nacional/Mpb/Secos & Molhados/Fala.mp3");
            musicFiles.Add("O Patrão Nosso De cada Dia", "Musicas/Nacional/Mpb/Secos & Molhados/O patrão nosso de cada dia.mp3");
            musicFiles.Add("Flores Astrais","Musicas/Nacional/Mpb/Secos & Molhados/Flores Astrais.mp3");
            //Titãns
            musicFiles.Add("O Pulso", "Musicas/Nacional/Mpb/Titãns/O Pulso.mp3");
            musicFiles.Add("Deus e o Diabo", "Musicas/Nacional/Mpb/Titãns/Deus e o Diabo.mp3");
            musicFiles.Add("Flores", "Musicas/Nacional/Mpb/Titãns/Flores.mp3");
            musicFiles.Add("Cegos No Castelo", "Musicas/Nacional/Mpb/Titãns/Cegos No Castelo.mp3");
            musicFiles.Add("Marvin", "Musicas/Nacional/Mpb/Titãns/Marvin.mp3");
            musicFiles.Add("Homem Primata", "Musicas/Nacional/Mpb/Titãns/Homem Primata.mp3");
            musicFiles.Add("Bichos Escrotos", "Musicas/Nacional/Mpb/Titãns/Bichos Escrotos.mp3");
            //Tim Maia
            musicFiles.Add("Ela Partiu", "Musicas/Nacional/Mpb/Tim Maia/Ela Partiu.mp3");
            musicFiles.Add("Chocolate", "Musicas/Nacional/Mpb/Tim Maia/Chocolate.mp3");
            musicFiles.Add("Vale Tudo", "Musicas/Nacional/Mpb/Tim Maia/Vale Tudo.mp3");
            musicFiles.Add("Eu Amo Você", "Musicas/Nacional/Mpb/Tim Maia/Eu Amo Você.mp3");
            musicFiles.Add("O Descobridor dos Sete Mares", "Musicas/Nacional/Mpb/Tim Maia/O Descobridor dos Sete Mares.mp3");
            //The Doors
            musicFiles.Add("Touch Me", "Musicas/Internacional/Rock/The Doors/Touch Me.mp3");
            musicFiles.Add("People Are Strange", "Musicas/Internacional/Rock/The Doors/People Are Strange.mp3");
            //Gorillaz
            musicFiles.Add("19-2000", "Musicas/Internacional/Rock/Gorillaz/19-2000.mp3");
            musicFiles.Add("Clint Eastwood", "Musicas/Internacional/Rock/Gorillaz/Clint Eastwood.mp3");
            musicFiles.Add("Feel Good Inc.", "Musicas/Internacional/Rock/Gorillaz/Feel Good Inc..mp3");
            ////Queen
            musicFiles.Add("Love Of My Life", "Musicas/Internacional/Rock/Queen/Love Of My Life.mp3");
            musicFiles.Add("Bohemian Rhapsody", "Musicas/Internacional/Rock/Queen/Bohemian Rhapsody.mp3");
            musicFiles.Add("Somebody To Love", "Musicas/Internacional/Rock/Queen/Somebody To Love.mp3");
            musicFiles.Add("Good Old-Fashioned Lover Boy", "Musicas/Internacional/Rock/Queen/Good Old-Fashioned Lover Boy.mp3");
            musicFiles.Add("We Will Rock You", "Musicas/Internacional/Rock/Queen/We Will Rock You.mp3");
            musicFiles.Add("We Are The Champions", "Musicas/Internacional/Rock/Queen/We Are The Champions.mp3");
            musicFiles.Add("Don’t Stop Me Now", "Musicas/Internacional/Rock/Queen/Don’t Stop Me Now.mp3");
            musicFiles.Add("Killer Queen", "Musicas/Internacional/Rock/Queen/Killer Queen.mp3");
            musicFiles.Add("Sheer Heart Attack", "Musicas/Internacional/Rock/Queen/Sheer Heart Attack.mp3");
            musicFiles.Add("Another One Bites The Dust", "Musicas/Internacional/Rock/Queen/Another One Bites The Dust.mp3");
            musicFiles.Add("Made In Heaven", "Musicas/Internacional/Rock/Queen/Made In Heaven.mp3");
            //The Alan Parsons Project
            musicFiles.Add("Eye In The Sky", "Musicas/Internacional/Rock/The Alan Parsons Project/Eye In The Sky.mp3");
            //Fools Gardem
            musicFiles.Add("Lemon Tree", "Musicas/Internacional/Rock/Fools Gardem/Lemon Tree.mp3");
            musicFiles.Add("Save The World Tomorrow", "Musicas/Internacional/Rock/Fools Gardem/Save The World Tomorrow.mp3");
            //The Beatles
            musicFiles.Add("Hello,GoodBye", "Musicas/Internacional/Rock/The Beatles/Hello,GoodBye.mp3");
            musicFiles.Add("Yellow Submarine", "Musicas/Internacional/Rock/The Beatles/Yellow Submarine.mp3");
            musicFiles.Add("Beautiful Boy", "Musicas/Internacional/Rock/The Beatles/Beautiful Boy.mp3");
            ////Trio
            musicFiles.Add("Da Da Da", "Musicas/Internacional/Rock/Trio/Da Da Da.mp3");
            // KC & the Sunshine Band
            musicFiles.Add("Please Don't Go", "Musicas/Internacional/Rock/KC & The Sunshine Band/Please Don_t Go.mp3");
            //Jack Stauber
            musicFiles.Add("Cupid", "Musicas/Internacional/Pop/Jack Stauber/Cupid.mp3");
            musicFiles.Add("Choice", "Musicas/Internacional/Pop/Jack Stauber/Choice.mp3");
            musicFiles.Add("Coffee", "Musicas/Internacional/Pop/Jack Stauber/Coffee.mp3");
            musicFiles.Add("Baby Hotline", "Musicas/Internacional/Pop/Jack Stauber/Baby Hotline.mp3");
            musicFiles.Add("Tea Errors", "Musicas/Internacional/Pop/Jack Stauber/Tea Errors.mp3");
            musicFiles.Add("Oh Klahoma", "Musicas/Internacional/Pop/Jack Stauber/Oh klahoma.mp3");
            musicFiles.Add("Bettercup", "Musicas/Internacional/Pop/Jack Stauber/Buttercup.mp3");
            musicFiles.Add("Two time", "Musicas/Internacional/Pop/Jack Stauber/Two time.mp3");
            musicFiles.Add("Doctor", "Musicas/Internacional/Pop/Jack Stauber/Doctor.mp3");
            musicFiles.Add("Peppermint", "Musicas/Internacional/Pop/Jack Stauber/Peppermint (feat.Lexy).mp3");
            //Cafuné
           musicFiles.Add("Tek It", "Musicas/Internacional/Pop/Cafuné/Tek It.mp3");
            //Arctic Monkeys
            musicFiles.Add("505", "Musicas/Internacional/Pop/Arctic Monkeys/505.mp3");
            //Steve Lacy
            musicFiles.Add("Bad Habit", "Musicas/Internacional/Pop/Steve Lacy/Bad Habit.mp3");
            musicFiles.Add("Dark Red", "Musicas/Internacional/Pop/Steve Lacy/Dark Red.mp3");
            //Mild High Club
            musicFiles.Add("Homage", "Musicas/Internacional/Pop/Mild High Club/Homage.mp3");

        }

        private void Cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Caso Tenha algo no combo box irá limpar

            Cmb_Estilo.Items.Clear();
            Cmb_Artista.Items.Clear();
            Cmb_Musica.Items.Clear();
            wmp.controls.stop();
            Pic_Albuns.Visible = false;
            Btn_VolumeDown.Visible = false;
            Btn_VolumeUp.Visible = false;
            LblVolume.Visible = false;
            Cmb_Velocidade.Visible = false;
            Lbl_Velocidade.Visible = false;
            

            if (Cmb_Tipo.SelectedItem.ToString() == "Nacional") //Condição para que caso for selecionada a o opção Nacional irá aárecer MPB
            {
                Cmb_Estilo.Items.AddRange(new string[] { "MPB" });
            }
            else if (Cmb_Tipo.SelectedItem.ToString() == "Internacional") //Caso Contrario, se for seleciona a opção Internacional Irá Aparecer Rock e Pop
            {
                Cmb_Estilo.Items.AddRange(new string[] { "Rock", "Pop" });
            }
            Cmb_Estilo.Visible = true;
            Cmb_Estilo.Focus();
        }

        private void Cmb_Estilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Caso Tenha algo no combo box irá limpar
            Cmb_Artista.Items.Clear();
            Cmb_Musica.Items.Clear();
            wmp.controls.stop();
            Pic_Albuns.Visible = false;
            Btn_VolumeDown.Visible = false;
            Btn_VolumeUp.Visible = false;
            LblVolume.Visible = false;
            Cmb_Velocidade.Visible = false;
            Lbl_Velocidade.Visible = false;

            if (Cmb_Estilo.Text != "")
            {
                if (Cmb_Tipo.SelectedItem.ToString() == "Nacional" && Cmb_Estilo.SelectedItem.ToString() == "MPB") //Condição Para caso for selecionada a opção mpb vai aparecer os artistas de mpb
                {
                    Cmb_Artista.Items.AddRange(new string[] { "Secos & Molhados", "Titãs", "Tim Maia" });
                }
                else if (Cmb_Tipo.SelectedItem.ToString() == "Internacional" && Cmb_Estilo.SelectedItem.ToString() == "Rock") //Condição Para caso for selecionada a opção Rock vai aparecer os artistas do Rock
                {
                    Cmb_Artista.Items.AddRange(new string[] { "The Doors", "Gorillaz", "Queen", "The Alan Parsons Project", "Fools Gardem", "The Beatles", "Trio", "KC & the Sunshine Band" });
                }
                else if (Cmb_Tipo.SelectedItem.ToString() == "Internacional" && Cmb_Estilo.SelectedItem.ToString() == "Pop") //Condição Para caso for selecionada a opção Pop  vai aparecer os artistas de Pop
                {
                    Cmb_Artista.Items.AddRange(new string[] { "Jack Stauber", "Cafuné", "Arctic Monkeys", "Steve Lacy" , "Mild High Club" });
                }
                Cmb_Artista.Visible = true;
                Cmb_Artista.Focus();
            }
        }

        private void Cmb_Artista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Caso Tenha algo no combo box irá limpar

            Cmb_Musica.Items.Clear();
            wmp.controls.stop();
            Pic_Albuns.Visible = false;
            Btn_VolumeDown.Visible = false;
            Btn_VolumeUp.Visible = false;
            LblVolume.Visible = false;
            Cmb_Velocidade.Visible = false;
            Lbl_Velocidade.Visible = false;

            if (Cmb_Artista.Text != "")
            {
                if (Cmb_Artista.SelectedItem.ToString() == "Secos & Molhados") //Caso For Selecionada a Opção Secos & Molhados vai aparecer as suas musicas
                {
                    Cmb_Musica.Items.AddRange(new string[] { "O Vira", "Sangue Latino", "Assim Assado", "Rosa de Hiroshima", "Amor", "Fala", "O Patrão Nosso De cada Dia", "Flores Astrais" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Titãs") //Caso For Selecionada a Opção Titãs vai aparecer as suas musicas
                {
                    Cmb_Musica.Items.AddRange(new string[] { "O Pulso", "Deus e o Diabo", "Flores", "Cegos No Castelo", "Marvin", "Homem Primata", "Bichos Escrotos" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Tim Maia")  //Caso For Selecionada a Opção Tim Maia vai aparecer as suas musicas
                {
                    Cmb_Musica.Items.AddRange(new string[] { "Ela Partiu", "Chocolate", "Vale Tudo", "Eu Amo Você", "O Descobridor dos Sete Mares" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "The Doors")  //Caso For Selecionada a Opção "The Doors vai aparecer as suas musicas
                {
                    Cmb_Musica.Items.AddRange(new string[] { "Touch Me", "People Are Strange" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Gorillaz")  //Caso For Selecionada a Opção Gorillaz vai aparecer as suas musicas
                {
                    Cmb_Musica.Items.AddRange(new string[] { "19-2000", "Clint Eastwood", "Feel Good Inc." });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Queen")  //Caso For Selecionada a Opção "Queen vai aparecer as suas musicas
                {
                    Cmb_Musica.Items.AddRange(new string[] { "Love Of My Life", "Bohemian Rhapsody", "Somebody To Love", "Good Old-Fashioned Lover Boy", "We Will Rock You", "We Are The Champions", "Don’t Stop Me Now", "Killer Queen", "Sheer Heart Attack", "Another One Bites The Dust", "Made In Heaven" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "The Alan Parsons Project")  //Caso For Selecionada a Opção The Alan Parsons Project vai aparecer as suas musicas
                {
                    Cmb_Musica.Items.AddRange(new string[] { "Eye In The Sky" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Fools Gardem") //Caso For Selecionada a Opção Fools Gardem vai aparecer as suas musicas
                {
                    Cmb_Musica.Items.AddRange(new string[] { "Lemon Tree", "Save The World Tomorrow" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "The Beatles") //Caso For Selecionada a Opção The Beatles vai aparecer as suas musicas
                {
                    Cmb_Musica.Items.AddRange(new string[] { "Hello,GoodBye", "Yellow Submarine", "Beautiful Boy" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Trio") //Caso For Selecionada a Opção Trio vai aparecer as suas musicas
                {
                    Cmb_Musica.Items.AddRange(new string[] { "Da Da Da" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "KC & the Sunshine Band")
                {
                    Cmb_Musica.Items.AddRange(new string[] { "Please Don't Go" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Jack Stauber") //Caso For Selecionada a Opção Jack Stauber vai aparecer as suas musicas
                {
                        Cmb_Musica.Items.AddRange(new string[] { "Cupid", "Choice", "Coffee", "Baby Hotline", "Tea Errors", "Oh Klahoma", "Bettercup", "Two time", "Doctor", "Peppermint" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Cafuné") //Caso For Selecionada a Opção Titãs vai aparecer as suas musicas
                {
                        Cmb_Musica.Items.AddRange(new string[] { "Tek It" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Arctic Monkeys") //Caso For Selecionada a Opção Arctic Monkeys vai aparecer as suas musicas
                {
                        Cmb_Musica.Items.AddRange(new string[] { "505" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Steve Lacy") //Caso For Selecionada a Opção "Steve Lacy vai aparecer as suas musicas
                {
                        Cmb_Musica.Items.AddRange(new string[] { "Bad Habit", "Dark Red" });
                }
                else if (Cmb_Artista.SelectedItem.ToString() == "Mild High Club")
                {
                        Cmb_Musica.Items.AddRange(new string[] { "Homage" });
                }
                Cmb_Musica.Visible = true;
                Cmb_Musica.Focus();
            }

        }
        private void Cmb_Musica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Musica.Text !="")
            {
                string selectedMusic = Cmb_Musica.SelectedItem.ToString();

                if (musicFiles.ContainsKey(selectedMusic))  // Obtém a música selecionada no ComboBox de músicas
                {
                    string musicFilePath = musicFiles[selectedMusic]; 
                    PlayMusic(musicFilePath);  // Verifica se o dicionário de arquivos de música contém a música selecionada
                }
                else
                {
                    MessageBox.Show("Arquivo de música não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // Chama o método para tocar a música
                }

                // Inicia um switch baseado na música selecionada
                switch (selectedMusic) //é uma estrutura de controle que facilita a escolha entre múltiplas execuções possíveis com base no valor de uma variável ou expressão
                {
                    // Caso a música selecionada for uma da lista define o seu album
                    //Secos & Molhados
                    case "O Vira":
                    case "Sangue Latino":
                    case "Assim Assado":
                    case "Rosa de Hiroshima":
                    case "Amor":
                    case "Fala":
                    Pic_Albuns.Image = Properties.Resources.Secos___Molhados_1___Album;
                    break; //Finaliza a lista
                    case "O Patrão Nosso De cada Dia":
                    case "Flores Astrais":
                    Pic_Albuns.Image = Properties.Resources.Secos___Molhados_2___Album;
                    break; //Finaliza a lista
                     //Titãns
                    case "O Pulso":
                    case "Deus e o Diabo":
                    Pic_Albuns.Image = Properties.Resources.Õ_Blesq_Blom___Album;
                    break; //Finaliza a lista
                    case "Flores":
                    Pic_Albuns.Image = Properties.Resources._84_94___Volume_1___Album;
                    break; //Finaliza a lista
                    case "Cegos No Castelo":
                    Pic_Albuns.Image = Properties.Resources.Acústico_MTV___Album;
                    break; //Finaliza a lista
                    case "Marvin":
                    Pic_Albuns.Image = Properties.Resources.Dia_dos_Pais___Album;
                    break; //Finaliza a lista
                    case "Homem Primata":
                    case "Bichos Escrotos":
                    Pic_Albuns.Image = Properties.Resources.Cabeça_de_Dinossauro___Album;
                    break; //Finaliza a lista
                    //Tim Maia
                    case "Ela Partiu":
                   Pic_Albuns.Image = Properties.Resources.Ela_Partiu___Album;
                   break; //Finaliza a lista
                    case "Chocolate":
                    Pic_Albuns.Image = Properties.Resources.Dançando_a_noite_inteira___album;
                     break; //Finaliza a lista
                    case "Vale Tudo":
                    Pic_Albuns.Image = Properties.Resources.Dance_Bem___Album;
                    break; //Finaliza a lista
                    case "Eu Amo Você":
                  Pic_Albuns.Image = Properties.Resources.Tim_Maia_71___Album;
                  break; //Finaliza a lista
                    case "O Descobridor dos Sete Mares":
                    Pic_Albuns.Image = Properties.Resources.O_Descobridor_dos_7_mares____album;
                     break; //Finaliza a lista
                     //The Doors
                    case "Touch Me":
                     Pic_Albuns.Image = Properties.Resources.The_Soft_Parade___Album;
                    break; //Finaliza a lista
                    case "People Are Strange":
                      Pic_Albuns.Image = Properties.Resources.Strange_Days___Album;
                   break; //Finaliza a lista
                    //Gorillaz
                    case "19-2000":
                    case "Clint Eastwood":
                    case "Feel Good ":
                     Pic_Albuns.Image = Properties.Resources.Demon_Days;
                    break; //Finaliza a lista
                    //Queen
                    case "Love Of My Life":
                    case "Bohemian Rhapsody":
                     Pic_Albuns.Image = Properties.Resources.A_Night_At_The_Opera___Album;
                   break; //Finaliza a lista
                    case "Somebody To Love":
                    case "Good Old-Fashioned Lover Boy":
                    Pic_Albuns.Image = Properties.Resources.A_Day_At_The_Races___Album;
                    break; //Finaliza a lista
                    case "We Will Rock You":
                    case "We Are The Champions":
                     Pic_Albuns.Image = Properties.Resources.News_of_the_World__Album;
                    break; //Finaliza a lista
                    case "Don’t Stop Me Now":
                    Pic_Albuns.Image = Properties.Resources.Jazz_Album;
                     break; //Finaliza a lista
                    case "Killer Queen":
                    case "Sheer Heart Attack":
                    Pic_Albuns.Image = Properties.Resources.Sheer_Heart_Attack___Album;
                     break; //Finaliza a lista
                    case "Another One Bites The Dust":
                    Pic_Albuns.Image = Properties.Resources.The_Game___Album;
                    break; //Finaliza a lista
                    case "Made In Heaven":
                    Pic_Albuns.Image = Properties.Resources.Made_In_Heaven___Album;
                    break; //Finaliza a lista
                    //The Alan Parsons Project
                    case "Eye In The Sky":
                     Pic_Albuns.Image = Properties.Resources.Eye_In_The_Sky_Album;
                     break; //Finaliza a lista
                     //Fools Gardem
                    case "Lemon Tree":
                    Pic_Albuns.Image = Properties.Resources.Dish_Of_The_Day___Album;
                    break; //Finaliza a lista
                    case "Save The World Tomorrow":
                    Pic_Albuns.Image = Properties.Resources.Rise_And_Fall___Album;
                   break; //Finaliza a lista
                    //The Beatles
                    case "Hello,GoodBye":
                    Pic_Albuns.Image = Properties.Resources.Magical_Mystery_Tour___Album;
                    break; //Finaliza a lista
                    case "Yellow Submarine":
                    Pic_Albuns.Image = Properties.Resources.Yellow_Submarine___Album;
                    break; //Finaliza a lista
                    case "Beautiful Boy":
                    Pic_Albuns.Image = Properties.Resources.Double_Fantasy___Album;
                    break; //Finaliza a lista
                    //Trio
                    case "Da Da Da":
                    Pic_Albuns.Image = Properties.Resources.Trio____Album;
                    break; //Finaliza a lista
                    //KC and the Sunshine Band
                    case "Please Don't Go":
                    Pic_Albuns.Image = Properties.Resources.Please_Don_t_Go___Album;
                    break; //Finaliza a lista
                    //Jack Stauber
                    case "Cupid":
                    Pic_Albuns.Image = Properties.Resources.Dinner_Is_Not_Over___Album;
                    break; //Finaliza a lista
                    case "Choice":
                    case "Doctor":
                    case "Peppermint":
                    Pic_Albuns.Image = Properties.Resources.Micropop___Album;
                    break; //Finaliza a lista
                    case "Coffee":
                    Pic_Albuns.Image = Properties.Resources.Shop_A_Pop_Opera___Album;
                   break; //Finaliza a lista
                    case "Baby_Hotline":
                    case "Tea_Errors":
                    Pic_Albuns.Image = Properties.Resources.Baby_Hotline_Tea_Errors___Album;
                    break; //Finaliza a lista
                    case "Two_Time":
                    Pic_Albuns.Image = Properties.Resources.Two_Time___Album;
                    break; //Finaliza a lista
                    case "Oh Klahoma":
                    case "Bettercup":
                    Pic_Albuns.Image = Properties.Resources.Pop_Food___Album;
                    break; //Finaliza a lista
                    //Cafuné
                    case "Tek It":
                    Pic_Albuns.Image = Properties.Resources.Running___Album;
                    break; //Finaliza a lista
                    //Arctic Monkeys
                    case "505":
                    Pic_Albuns.Image = Properties.Resources.Favourite_Worst_Nightmare__Album;
                    break; //Finaliza a lista
                    //Steve Lancy
                    case "Bad Habit":
                    Pic_Albuns.Image = Properties.Resources.Gemini_Rights_Album;
                    break; //Finaliza a lista 
                    case "Dark Red":
                    Pic_Albuns.Image = Properties.Resources.Steve_Lacy_s_Demo___Album;
                    break; //Finaliza a lista
                    //Mild High Club
                    case "Homage":
                    Pic_Albuns.Image = Properties.Resources.Skiptracing_Album;
                    break; //Finaliza a lista



                }
            }
        }
        private void PlayMusic(string filePath)
        {
            try
            {
                wmp.URL = filePath; // Define a URL da mídia para o Windows Media Player
                wmp.controls.play(); // Reproduz a mídia
                Pic_Albuns.Visible = true;
                Btn_VolumeDown.Visible = true;
                Btn_VolumeUp.Visible = true;
                LblVolume.Visible = true;
                Lbl_Velocidade.Visible = true;
                Cmb_Velocidade.Visible = true;
            }
            catch
            {
                MessageBox.Show("Erro ao tentar tocar a música", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_VolumeUp_Click(object sender, EventArgs e)
        {
            if (currentVolume < 100) // O volume máximo é 100
            {
                currentVolume += 1; //O volume sera aumentado de um em um
                wmp.settings.volume = currentVolume;// Inicializar volume do media player
                LblVolume.Text = $"Volume: {currentVolume}";// Atualiza o label de volume
            }
            
        }

        private void Btn_VolumeDown_Click(object sender, EventArgs e)
        {
            if (currentVolume > 0) // O volume mínimo é 0
            {
                currentVolume -= 1; //O volume diminuirá de um em um
                wmp.settings.volume = currentVolume;// Inicializar volume do media player
                LblVolume.Text = $"Volume: {currentVolume}";// Atualiza label de volume
            }
        }

        private void Cmb_Velocidade_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (double.TryParse(Cmb_Velocidade.SelectedItem.ToString(), out double speed))
            {
                // Define a velocidade de reprodução
                wmp.settings.rate = speed;
            }
            else
            {
                MessageBox.Show("Seleção de velocidade inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

