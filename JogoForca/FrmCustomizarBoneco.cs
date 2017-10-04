using JogoForca.Classes;
using JogoForca.Controles;
using System.Drawing;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class FrmCustomizarBoneco : Form
    {
        private ParteBoneco _cabeca;
        private ParteBoneco _torso;
        private ParteBoneco _bracoEsq;
        private ParteBoneco _bracoDir;
        private ParteBoneco _pernaDir;
        private ParteBoneco _pernaEsq;

        public FrmCustomizarBoneco()
        {
            InitializeComponent();
            
            _cabeca = new ParteBoneco(Boneco.ParteCorpo.CABECA);
            _cabeca.Location = new Point(5, 5);
            _cabeca.Size = new Size(270, 340);
            _cabeca.CreateControl();

            _torso = new ParteBoneco(Boneco.ParteCorpo.CORPO);
            _torso.Location = new Point(5, 5);
            _torso.Size = new Size(270, 340);
            _torso.CreateControl();
            
            _bracoEsq = new ParteBoneco(Boneco.ParteCorpo.BRACO_ESQ);
            _bracoEsq.Location = new Point(5, 5);
            _bracoEsq.Size = new Size(270, 315);
            _bracoEsq.CreateControl();
            
            _bracoDir = new ParteBoneco(Boneco.ParteCorpo.BRACO_DIR);
            _bracoDir.Location = new Point(5, 5);
            _bracoDir.Size = new Size(270, 315);
            _bracoDir.CreateControl();
            
            _pernaDir = new ParteBoneco(Boneco.ParteCorpo.PERNA_DIR);
            _pernaDir.Location = new Point(5, 5);
            _pernaDir.Size = new Size(270, 315);
            _pernaDir.CreateControl();

            _pernaEsq = new ParteBoneco(Boneco.ParteCorpo.PERNA_ESQ);
            _pernaEsq.Location = new Point(5, 5);
            _pernaEsq.Size = new Size(270, 315);
            _pernaEsq.CreateControl();
            

            tabCabeca.Controls.Add(_cabeca);
            _cabeca.Invalidate();

            tabTorso.Controls.Add(_torso);
            _torso.Invalidate();

            tabBracoEsquerdo.Controls.Add(_bracoEsq);
            _bracoEsq.Invalidate();

            tabBracoDireito.Controls.Add(_bracoDir);
            _bracoDir.Invalidate();

            tabPernaDireita.Controls.Add(_pernaDir);
            _pernaDir.Invalidate();

            tabPernaEsquerda.Controls.Add(_pernaEsq);
            _pernaEsq.Invalidate();
            
        }
    }
}
