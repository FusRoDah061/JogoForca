using JogoForca.Classes;
using JogoForca.Controles;
using System.Drawing;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class FrmCustomizarBoneco : Form
    {
        private ParteBoneco _cabeca;

        public FrmCustomizarBoneco()
        {
            InitializeComponent();

            _cabeca = new ParteBoneco(Boneco.ParteCorpo.CABECA);
            _cabeca.Location = new Point(5, 5);
            _cabeca.Size = new Size(270, 340);
        }
    }
}
