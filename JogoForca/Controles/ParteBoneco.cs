using JogoForca.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoForca.Controles
{
    public class ParteBoneco : Panel
    {

        /// <summary>
        /// Área onde o usuário pode desenhar. Será a parte branca dentro do controle
        /// </summary>
        private PictureBox _areaDesenho;

        /// <summary>
        /// Controla quando o usuário etá habiltado a desenhar. True no MouseDown e false no MouseUp
        /// </summary>
        private bool _podeDesenhar = false;

        /// <summary>
        /// Cor selecionada pelo usuário. O formulário de desenho que altera esse valor
        /// </summary>
        public static Color Cor { get; set; }
        
        /// <summary>
        /// Escala do desenho. Similar a um zoom. As dimensões das parte do corpo serão multiplicadas por esse valor
        /// </summary>
        public int Escala { get; set; }

        /// <summary>
        /// Tamanho do "pincel" que o usuário usa para desenhar
        /// </summary>
        public static int TamanhoPincel { get; set; }

        /// <summary>
        /// Guarda o conteúdo que foi desenhado em _areaDesenho
        /// </summary>
        public Bitmap Desenhado { get; set; }

        /// <summary>
        /// Parte do corpo que esse controle vai representar
        /// </summary>
        private Boneco.ParteCorpo _parteCorpo;
    
        /// <summary>
        /// Parte do corpo que esse controle irá representar
        /// </summary>
        public Boneco.ParteCorpo PtCorpo
        {
            get
            {
                return _parteCorpo;
            }

            set
            {
                _parteCorpo = value;
                _atualiza();
            }
        }

        public ParteBoneco(Boneco.ParteCorpo parteCorpo)
        {
            PtCorpo = parteCorpo;
            Escala = 4;
            TamanhoPincel = 4;
            this.Invalidated += _atualizaDesenho;
        }
        
        /// <summary>
        /// Event handler do MouseUp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _bloqueiaDesenho(object sender, MouseEventArgs e)
        {
            _podeDesenhar = false;
        }

        /// <summary>
        /// Event handler do MouseMove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _desenha(object sender, MouseEventArgs e)
        {
            if (_podeDesenhar)
            {
                                
                SolidBrush sb = new SolidBrush(Cor);
                Graphics g = Graphics.FromImage(Desenhado);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                //Desenha um quadrado na posição do ponteiro do mouse
                try {
                    g.FillRectangle(sb, e.X - TamanhoPincel / 2, e.Y - TamanhoPincel / 2, TamanhoPincel, TamanhoPincel);
                }catch { }

                //Atualiza a picturebox do desenho
                _areaDesenho.Invalidate();
            }
        }

        private void _permiteDesenhar(object sender, MouseEventArgs e)
        {
            _podeDesenhar = true;

            if (Desenhado == null)
            {
                //salva o desenho na imagem
                Desenhado = new Bitmap(_areaDesenho.Width, _areaDesenho.Height);
            }

            //Coloca a imagem na picturebox tanto para persistir o desenho ao trocar de abas,
            //quanto para salvar essa imagem para o disco
            _areaDesenho.BackgroundImage = Desenhado;
        }

        /// <summary>
        /// Event handler do Invalidate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _atualizaDesenho(object sender, InvalidateEventArgs e)
        {
            _atualiza();
        }

        private void _iniciaAreaDesenho(Size dimensoes)
        {
            //Destroi a picturebox caso ela já exista
            if(_areaDesenho != null)
            {
                this.Controls.Remove(_areaDesenho);
                _areaDesenho.Dispose();
                _areaDesenho = null;
            }

            _areaDesenho = new PictureBox();
            _areaDesenho.Size = dimensoes;
            //Centraliza a área de desenho dentro do panel
            _areaDesenho.Location = new Point((this.Width / 2) - (_areaDesenho.Width / 2), (this.Height / 2) - (_areaDesenho.Height / 2));
            _areaDesenho.BackColor = Color.White;
            _areaDesenho.CreateControl();

            //Atribui os handlers que controlarão o desenho.
            //No mousedown o desenho é "habilitado"
            _areaDesenho.MouseDown += _permiteDesenhar;
            //no mousemove, já com o desenho habilitado, será feito de fato o desenho
            _areaDesenho.MouseMove += _desenha;
            //Ao soltar o mouse o desenho é "desabilitado"
            _areaDesenho.MouseUp += _bloqueiaDesenho;
            
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Gray;
            
            this.Controls.Add(_areaDesenho);
        }

        /// <summary>
        /// Atualiza o controle todo
        /// </summary>
        private void _atualiza()
        {
            //Area que será usada pelo usuário para desenhar. varia de acordo com a parte do corpo
            Size area = new Size(this.Width, this.Height);

            switch (_parteCorpo)
            {
                case Boneco.ParteCorpo.CABECA:
                    area = new Size(30 * Escala, 30 * Escala);
                    break;

                case Boneco.ParteCorpo.CORPO:
                    area = new Size(21 * Escala, 70 * Escala);
                    break;

                case Boneco.ParteCorpo.BRACO_DIR:
                case Boneco.ParteCorpo.BRACO_ESQ:
                    area = new Size(15 * Escala, 50 * Escala);
                    break;

                case Boneco.ParteCorpo.PERNA_DIR:                 
                case Boneco.ParteCorpo.PERNA_ESQ:
                    area = new Size(15 * Escala, 70 * Escala);
                    break;
            }

            //Cria a picturebox
            _iniciaAreaDesenho(area);

        }
        
        /// <summary>
        /// Salva a imagem desenhada para o disco
        /// </summary>
        /// <param name="path">Diretório da imagem</param>
        public void SalvaImagem(string path)
        {
            if (Desenhado != null)
            {
                Desenhado.Save(path);
            }
        }
    }
}
