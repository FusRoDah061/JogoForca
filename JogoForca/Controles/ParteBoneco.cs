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
                _atualiza();
            }
        }

        public ParteBoneco(Boneco.ParteCorpo parteCorpo)
        {
            PtCorpo = parteCorpo;
        }

        private void _iniciaAreaDesenho(Size dimensoes)
        {
            _areaDesenho = new PictureBox();
            _areaDesenho.Size = dimensoes;
            //Centraliza a área de desenho dentro do panel
            _areaDesenho.Location = new Point((this.Width / 2) - (_areaDesenho.Width / 2), (this.Height / 2) - (_areaDesenho.Height / 2));
            _areaDesenho.BackColor = Color.White;

            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Gray;
        }

        private void _atualiza()
        {
            switch (_parteCorpo)
            {
                case Boneco.ParteCorpo.CABECA:
                    _cabeca();
                    break;

                case Boneco.ParteCorpo.CORPO:
                    _corpo();
                    break;

                case Boneco.ParteCorpo.BRACO_DIR:
                    _braco(Boneco.Braco.DIREITO);
                    break;

                case Boneco.ParteCorpo.BRACO_ESQ:
                    _braco(Boneco.Braco.ESQUERDO);
                    break;

                case Boneco.ParteCorpo.PERNA_DIR:
                    _perna(Boneco.Perna.DIREITA);
                    break;

                case Boneco.ParteCorpo.PERNA_ESQ:
                    _perna(Boneco.Perna.ESQUERDA);
                    break;
            }
        }

        private void _perna(Boneco.Perna dIREITA)
        {
            throw new NotImplementedException();
        }

        private void _braco(Boneco.Braco dIREITO)
        {
            throw new NotImplementedException();
        }

        private void _corpo()
        {
            throw new NotImplementedException();
        }

        private void _cabeca()
        {
            throw new NotImplementedException();
        }
    }
}
