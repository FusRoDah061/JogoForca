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
        private PictureBox _areaDesenho;

        private bool _podeDesenhar = false;

        public Color Cor { get; set; }

        public bool Modificado { get; set; }

        public int Escala { get; set; }

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
            this.Invalidated += _atualizaDesenho;
            Modificado = false;
        }

        private void _bloqueiaDesenho(object sender, MouseEventArgs e)
        {
            _podeDesenhar = false;
        }

        private void _desenha(object sender, MouseEventArgs e)
        {
            if (_podeDesenhar)
            {
                Modificado = true;

                Graphics g = _areaDesenho.CreateGraphics();
                
                SolidBrush sb = new SolidBrush(Cor);

                try {
                    g.FillRectangle(sb, e.X - Escala / 2, e.Y - Escala / 2, Escala, Escala);
                }catch { }
                
            }
        }

        private void _permiteDesenhar(object sender, MouseEventArgs e)
        {
            _podeDesenhar = true;
        }

        private void _atualizaDesenho(object sender, InvalidateEventArgs e)
        {
            _atualiza();
        }

        private void _iniciaAreaDesenho(Size dimensoes)
        {
            if(_areaDesenho != null)
            {
                this.Controls.Remove(_areaDesenho);
            }

            _areaDesenho = new PictureBox();
            _areaDesenho.Size = dimensoes;
            //Centraliza a área de desenho dentro do panel
            _areaDesenho.Location = new Point((this.Width / 2) - (_areaDesenho.Width / 2), (this.Height / 2) - (_areaDesenho.Height / 2));
            _areaDesenho.BackColor = Color.White;
            _areaDesenho.CreateControl();

            _areaDesenho.MouseDown += _permiteDesenhar;
            _areaDesenho.MouseMove += _desenha;
            _areaDesenho.MouseUp += _bloqueiaDesenho;

            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Gray;

            this.Controls.Add(_areaDesenho);
        }

        private void _atualiza()
        {
            Size area = new Size(this.Width, this.Height);

            switch (_parteCorpo)
            {
                case Boneco.ParteCorpo.CABECA:
                    area = new Size(30 * Escala, 30 * Escala);
                    break;

                case Boneco.ParteCorpo.CORPO:
                    area = new Size(2 * Escala, 70 * Escala);
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

            _iniciaAreaDesenho(area);

        }
        
    }
}
