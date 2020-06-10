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
    public partial class Frmcompetitieoverzicht : Form
    {
        private Competitie competitietje;
        public Frmcompetitieoverzicht(Competitie C)
        {
            InitializeComponent();
            competitietje = C;
        }

        private void Frmcompetitieoverzicht_Load(object sender, EventArgs e)
        {
            // dit gebruik je om tabellen te maken 
            // hier maak je een tabel om een overzicht te geven tussen de competities van verschillende ploegen
            grdcompetitietabel.ColumnCount = 8;
            grdcompetitietabel.Columns[0].Name = "ploeg";
            grdcompetitietabel.Columns[1].Name = "aantalMatch";
            grdcompetitietabel.Columns[2].Name = "ploegpunten";
            grdcompetitietabel.Columns[3].Name = "aantalgewonnenM";
            grdcompetitietabel.Columns[4].Name = "aantalverlorenM";
            grdcompetitietabel.Columns[5].Name = "aantalSets";
            grdcompetitietabel.Columns[6].Name = "aantalgewonnenS";
            grdcompetitietabel.Columns[7].Name = "aantalverlorenS";
            string naam = "";
            foreach (Team t in competitietje.Team)
            {
                naam = t.Naam;
                string[] rij = new string[8] { naam, t.AantalMatchen.ToString(), t.Punten.ToString(), t.MatchGewonnen.ToString(), t.MatchVerloren.ToString(), t.AantalSets.ToString(), t.GewonnenSets.ToString(), t.VerlorenSets.ToString() };
                grdcompetitietabel.Rows.Add(rij);
            }
        }
    }
}
