using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JaartaakVolleybal_Business;

namespace JaartaakVolleybal_Forms
{
    public partial class frmVolleybalCompetitie : Form
    {
        private Competitie _volleybalcompetitietje;
        private string _team, _match;
        /// <summary>
        /// constructor voor  klasse frm VolleybalCompetitie
        /// </summary>
        /// <param name="volleybalcompetitietjes"> een object van de klasse competitie</param>
        public frmVolleybalCompetitie( )
        {
            InitializeComponent();
            _volleybalcompetitietje = new Competitie();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // deze methode zorgt ervoor dat je teams kan toevoegen waarmee je dan een match kan spelen.
        private void btnTeamToevoegen_Click(object sender, EventArgs e)
        {
            string t = textTeam.Text;
            _volleybalcompetitietje.voegTeamToe(t);


            textTeam.Focus();
            textTeam.Clear();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            comboboxteam1.DataSource = null;
            comboboxteam1.DataSource = _volleybalcompetitietje.Team;
            comboboxteam2.DataSource = null;
            comboboxteam2.BindingContext = new BindingContext();
            comboboxteam2.DataSource = _volleybalcompetitietje.Team;
            panel2.Visible = true;
            panel1.Visible = false;
        }
        // met deze voeg je een match toe 
        private void btnMatchToevoegen_Click(object sender, EventArgs e)
        {
           
            string H = comboboxteam1.SelectedItem.ToString();
            string W = comboboxteam2.SelectedItem.ToString();
            Team teamH = _volleybalcompetitietje.vraagTeamOp(H);
            Team teamW = _volleybalcompetitietje.vraagTeamOp(W);
            Match matchje = new Match(teamH, teamW);
            _volleybalcompetitietje.voegMatchToe(matchje);
            comboboxteam1.Enabled = false;
            comboboxteam2.Enabled = false;
            btnMatchToevoegen.Enabled = false;
            panel3.Visible = true;
        }

        private int huidignummer = 0;

        private void byncopetitieoverzicht_Click(object sender, EventArgs e)
        {
            Frmcompetitieoverzicht f = new Frmcompetitieoverzicht(_volleybalcompetitietje);
            f.Show();
        }

        // met deze methode voeg je set toe aan een match. 
        private void btnSetToevoegen_Click(object sender, EventArgs e)
        {
            int H = Convert.ToInt16(txtH.Text);
            int W = Convert.ToInt16(txtW.Text);
            Set setje = new Set(H, W);
            _volleybalcompetitietje.Match[huidignummer].voegSetToe(setje);

            if (_volleybalcompetitietje.Match[huidignummer].GameOver == true)
            {
                huidignummer++;
                comboboxteam1.Enabled = true;
                comboboxteam2.Enabled = true;
                btnMatchToevoegen.Enabled = true;
                panel3.Visible = false;
            }
            txtH.Clear();
            txtW.Clear();
            txtH.Focus();
        }

        
    }
}
