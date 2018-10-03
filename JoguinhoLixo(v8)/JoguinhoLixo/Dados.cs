using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoguinhoLixo
{
    public partial class Dados : Form
    {
        public Dados()
        {
            InitializeComponent();
        }
        Sett sett = new Sett();

        private void Dados_Load(object sender, EventArgs e)
        {
            //lblTurnoDe.Text = "O turno pertence a equipe: " + sett.turnoDeQuem(sett.getPassos());
            
            lblPecas.Text =  sett.getClick()+ "";
            lblPassos.Text = sett.getLbl()+ "";
            if (Convert.ToInt32(lblPecas.Text) < 5)
            {
                lblTurnoDe.ForeColor = Color.Blue;
                lblTurnoDe.Text = "Azul";
            }
            else
            {
                lblTurnoDe.ForeColor = Color.Red;
                lblTurnoDe.Text = "Vermelha";
            }
            if(sett.getPersonagem() == null)
            {
                lblGetPersonagem.Text = "null";
            }
            else
            {
                lblGetPersonagem.Text = sett.getPersonagem().ToString();
            }
           
            lblPclista.Text = sett.getPclista()[Convert.ToInt32(lblPecas.Text)].PhysicalDimension.ToString();
        }
    }
}
