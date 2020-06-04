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
       
        /// <summary>
        /// constructor voor  klasse frm VolleybalCompetitie
        /// </summary>
        /// <param name="volleybalcompetitietjes"> een object van de klasse competitie</param>
        public frmVolleybalCompetitie()
        {
            InitializeComponent();
            _volleybalcompetitietje = new Competitie();
     
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _volleybalcompetitietje.voegTeamToe(textTeam.Text);
            textTeam.Focus;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            panel2.Visible = true;
        }
    
    }
}
