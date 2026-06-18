using Examen___Programmeren___Moba_Teamplanner.Forms;

namespace Examen___Programmeren___Moba_Teamplanner
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerForms playerForms = new PlayerForms();
            playerForms.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChampForm champForm = new ChampForm();
            champForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new TeamForm();
            teamForm.ShowDialog();
        }
    }
}
