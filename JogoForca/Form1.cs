using JogoForca.Classes;
using JogoForca.Controles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class Form1 : Form
    {
        private int _rodadaAtual = 0;
        private int _vitorias = 0;
        private int _derrotas = 0;

        /// <summary>
        /// Contador de erros cometidos pelo usuário. É usado diretamente para atualizar a figura do boneco enforcado
        /// </summary>
        private int _erros = 0;

        /// <summary>
        /// Indica se o jogo já foi finalizado (vitória ou derrota) ou não
        /// </summary>
        private bool _acabou = false;

        /// <summary>
        /// Armazena as letras incorretas entradas pelo jogador
        /// </summary>
        private HashSet<char> _letrasIncorretas = new HashSet<char>();

        public Form1()
        {
            InitializeComponent();

            //Retira o foco dos botões e coloca-o no formulário para permitir que a entrada das letras seja feita apenas aprtando a tecla
            this.Focus();
            _recomeca();
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Verifica se a tecla está entre A e Z de acordo com a tabela ASCII
            if ((int) e.KeyCode >= 65 && (int)e.KeyCode <= 90)
            {
                //Obtém o caracter pelo código ASCII
                char letra = _getLetra(e.KeyCode);
                //Armazena se a palavra da forca contém a letra entrada pelo usuário
                bool contem = palavraControl.AtualizaPalavra(letra);

                //Verifica se a letra entrada está incorreta
                if (!contem && !_acabou && !_letrasIncorretas.Contains(letra))
                {
                    //Verifica se a quantidade de erros é menor do que a quantidade máxima de erros, que corresponde à última parte do boneco que será desenhada
                    if ((_erros - 1) < (int)Boneco.ParteCorpo.PERNA_ESQ)
                    {
                        _erros++;
                        //Adiciona a letra digitada às letras incorretas
                        _letrasIncorretas.Add(letra);
                        //Atualiza o boneco para refletir o erro cometido
                        forca1.AtualizaBoneco((Boneco.ParteCorpo)(_erros - 1));
                        //Atualiza a lista de letras incorretas
                        _atualizaLetrasIncorretas();
                    }
                }
            }
        }

        /// <summary>
        /// Atualiza a lista de letras entradas incorretas
        /// </summary>
        private void _atualizaLetrasIncorretas()
        {
            string letras = "";
            int count = 0;

            foreach(char letra in _letrasIncorretas)
            {
                if (count == 0)
                {
                    letras += letra.ToString();
                    count++;
                }
                else
                {
                    letras += ", " + letra.ToString(); 
                }
                
            }

            lblLetrasIncorretas.Text = letras;
        }

        /// <summary>
        /// Obtém um char a partir de uma tecla do teclado (o código da tecla corresponde ao código ASCII do caracter)
        /// </summary>
        /// <param name="tecla">tecla pressionada</param>
        /// <returns>char contendo a representação textual da tecla</returns>
        private char _getLetra(Keys tecla)
        {
            return (char)tecla;
        }

        private void palavraControl_Vitoria(object sender, EventArgs e)
        {
            //Evento disparado em caso de vitoria do jogador

            _acabou = true;
            btnRecomecar.Enabled = true;
            MessageBox.Show("Você venceu!", "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            forca1.EscreveFinalizacao(Forca.Finalizacao.VITORIA);
            _vitorias++;
            lblVitorias.Text = "Vitórias: " + _vitorias.ToString();
        }

        private void forca1_Derrota(object sender, EventArgs e)
        {
            //Evento disparado em caso de derrota do jogador

            _acabou = true;
            btnRecomecar.Enabled = true;
            MessageBox.Show("Você perdeu!", "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            forca1.EscreveFinalizacao(Forca.Finalizacao.DERROTA);
            _derrotas++;
            lblDerrotas.Text = "Derrotas: " + _derrotas.ToString();
        }

        /// <summary>
        /// Recomeça o jogo. Recoloca a interface no seu estado inicial
        /// </summary>
        private void _recomeca()
        {
            forca1.Recomeca();
            palavraControl.Recomeca();
            _erros = 0;
            _rodadaAtual++;
            _letrasIncorretas.Clear();
            lblLetrasIncorretas.Text = "";
            lblCategoria.Text = palavraControl.Categoria;
            lblQtdLetras.Text = palavraControl.QtdLetras.ToString();
            lblPartida.Text = "Partida: " + _rodadaAtual.ToString();
            btnRecomecar.Enabled = false;
            this.Focus();
            _acabou = false;

            if(_rodadaAtual <= 1)
            {
                //Se for a primeira rodada inicializa o gráfico
                _inicializaGrafico();
            }
            else
            {
                //Senão apenas atualza os valores
                _atualizaGrafico();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            _recomeca();
        }
        
        private void _inicializaGrafico()
        {
            graficoColunas1.Total = _rodadaAtual - 1;
            graficoColunas1.AddSet("Vitórias", _vitorias, Color.Green);
            graficoColunas1.AddSet("Derrotas", _derrotas, Color.Red);
            graficoColunas1.IniciaPlot();
        }

        private void _atualizaGrafico()
        {
            //Para atualiza o gráfico basta alterar os valores aqui, pois o gráfico usa esses valroes diretamente para desenhar as barras
            graficoColunas1.Total = _rodadaAtual - 1;
            graficoColunas1.AtualizaSet("Vitórias", _vitorias, Color.Green);
            graficoColunas1.AtualizaSet("Derrotas", _derrotas, Color.Red);
        }

        private void btnCustomizar_Click(object sender, EventArgs e)
        {
            FrmCustomizarBoneco cust = new FrmCustomizarBoneco();

            if(cust.ShowDialog() == DialogResult.OK){
                List<Bitmap> partes = cust.Partes;
            }

            //Remove o foco do botão
            this.Focus();
            btnCustomizar.Enabled = false;
            btnCustomizar.Enabled = true;
        }

        private void btnResetarBoneco_Click(object sender, EventArgs e)
        {
            try {
                File.Delete("CABECA.png");
            } catch { }

            try {
                File.Delete("CORPO.png");
            } catch { }

            try {
                File.Delete("BRACO_ESQ.png");
            } catch { }

            try {
                File.Delete("BRACO_DIR.png");
            } catch { }

            try {
                File.Delete("PERNA_ESQ.png");
            } catch { }

            try {
                File.Delete("PERNA_DIR.png");
            } catch { }

            //Remove o foco do botão
            this.Focus();
            btnResetarBoneco.Enabled = false;
            btnResetarBoneco.Enabled = true;
        }
    }
}
