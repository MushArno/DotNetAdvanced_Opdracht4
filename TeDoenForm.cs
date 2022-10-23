namespace Opdracht4
{
    public partial class TeDoenForm : Form
    {
        public delegate void Meedelen(object container);
        public TeDoenForm()
        {
            InitializeComponent();
        }

        private FouteRij<TeDoen> taken = new FouteRij<TeDoen>();
        private void TeDoenForm_Load(object sender, EventArgs e)
        {

        }
    }
}