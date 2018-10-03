using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoguinhoLixo
{
    public partial class TrocaItem : Form
    {
        public TrocaItem()
        {
            InitializeComponent();
        }
        Sett sett = new Sett();
        King king = new King();
        Archer archer = new Archer();
        Warrior warrior = new Warrior();
        Clerig clerig = new Clerig();
        Mage mage = new Mage();
        Winged winged = new Winged();
        Barbarian barbarian = new Barbarian();
        Assasin assasin = new Assasin();
        Horse horse = new Horse();

        KingEnemy kingenemy = new KingEnemy();
        WarriorEnemy warriorenemy = new WarriorEnemy();
        ArcherEnemy archerenemy = new ArcherEnemy();
        ClerigEnemy clerigenemy = new ClerigEnemy();
        MageEnemy mageenemy = new MageEnemy();
        WingedEnemy wingedenemy = new WingedEnemy();
        BarbarianEnemy barbarianenemy = new BarbarianEnemy();
        AssasinEnemy assasinenemy = new AssasinEnemy();
        HorseEnemy horseenemy = new HorseEnemy();
        private void TrocaItem_Load(object sender, EventArgs e)
        {
            String[] ItemList = new String[(sett.getItemList() + ",").Split(',').Length - 1];
            ItemList = (sett.getItemList() + ",").Split(',');
            for (int i = 0; i <= (sett.getItemList() + ",").Split(',').Length - 1; i++)
            {
                llbxDoador.Items.Add(ItemList[i]);
            }
            String[] ItemList1 = new String[(sett.getItemList1() + ",").Split(',').Length - 1];
            ItemList1 = (sett.getItemList1() + ",").Split(',');
            for (int i = 0; i <= (sett.getItemList1() + ",").Split(',').Length - 1; i++)
            {
                lbxReceptor.Items.Add(ItemList1[i]);
            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            
                lbxReceptor.Items.Add(llbxDoador.Text);
                llbxDoador.Items.Remove(llbxDoador.Text);
         
                llbxDoador.Items.Add(lbxReceptor.Text);
                lbxReceptor.Items.Remove(lbxReceptor.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // var regex = new Regex(Regex.Escape("pot med,"));
            string idoa = "";
            
            foreach (var item in llbxDoador.Items)
            {
                if (item.ToString() != "")
                {
                    idoa += item.ToString() + ",";
                } // /n to print each item on new line or you omit /n to print text on same line
            }
            
            sett.setItemList(idoa);



            string irec = "";

            foreach (var item in lbxReceptor.Items)
            {
                if(item.ToString() != "")
                {
                    irec += item.ToString() + ",";
                }
               // /n to print each item on new line or you omit /n to print text on same line
            }

            sett.setItemList1(irec);
            this.Close();
        }
    }
}
