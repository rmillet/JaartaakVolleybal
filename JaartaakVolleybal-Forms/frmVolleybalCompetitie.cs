﻿using System;
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
        public frmVolleybalCompetitie( Competitie Volleybalcompetitietje)
        {
            InitializeComponent();
            textTeam.Text = Volleybalcompetitietje.Team;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void voegTeamToe(Team teampje)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
