using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Runtime.InteropServices;

namespace N2B2_Jogo
{
    class InformacoesCompartilhadas
    {
        public static int pontuacao; //pontuação do pacman para a tabela de recordes
        public static int dinheiro; //dinheiro do jogo clicker
        public static int vidaMaxima; //vida maxima do jogo clicker
        public static int danoAdicional; //dano adicional no jogo clicker
        public static int dificuldade = 0; //dificuldade do pacman
        public static int indexSelecionado = -1; //indexselecionado no combobox da dificuldade do pacman
        public static string nome; //string nome para a tabela de recordes
        public static bool musicaAtivada = true; //booleano de musicas ativadas
        public static SoundPlayer musicaPacMan = new SoundPlayer(@"musicaPacMan.wav"); //musica da tela do pacman
        public static SoundPlayer musica = new SoundPlayer(@"musicamenu.wav"); //musica da tela do clicker
        public static SoundPlayer inicioPacMan = new SoundPlayer(@"pacman_beginning.wav"); //musica da tela de inicio
        public static SoundPlayer mordidaPacMan = new SoundPlayer(@"pacman_chomp.wav"); //som da mordida do pacman
        public static SoundPlayer mortePacMan = new SoundPlayer(@"pacman_death.wav"); //som da morte do pacman
        public static SoundPlayer hit = new SoundPlayer(@"hit.wav"); //som de hit no jogo clicker
        public static SoundPlayer kill = new SoundPlayer(@"roblox.wav"); //som de morte no jogo clicker
        public static SoundPlayer pegueopombo = new SoundPlayer(@"pegue o pombo.wav"); //musica do pegue o pomo
    }
}
