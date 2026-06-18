using Examen___Programmeren___Moba_Teamplanner.Data;
using Examen___Programmeren___Moba_Teamplanner.Forms;
using Microsoft.EntityFrameworkCore;

namespace Examen___Programmeren___Moba_Teamplanner
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            using var context = new AppDbContext();
            context.Database.Migrate();
            SeedData.SeedChampions(context);

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

        private void button4_Click(object sender, EventArgs e)
        {
            MatchForm matchForm = new MatchForm();
            matchForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StatForm statForm = new StatForm();
            statForm.ShowDialog();
        }
    }
}
