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
    public partial class UsarItem : Form
    {
        public UsarItem()
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
        private void UsarItem_Load(object sender, EventArgs e)
        {
            String[] ItemList = new String[(sett.getItemList() + ",").Split(',').Length -1];
            ItemList = (sett.getItemList()+",").Split(',');
            for(int i = 0; i<= (sett.getItemList() + ",").Split(',').Length - 1; i++)
            {
                cbxItem.Items.Add(ItemList[i]);
            }
        }

        private void btnUitem_Click(object sender, EventArgs e)
        {
            String[] ItemList = new String[(sett.getItemList() + ",").Split(',').Length - 1];
            ItemList = (sett.getItemList() + ",").Split(',');
            string item = cbxItem.Text;
            if(item == "pot med")
            {
                sett.setHpItem((Convert.ToInt32(sett.getHpItem()) + 20)+ "" );
                if(Convert.ToInt32(sett.getHpItem()) > Convert.ToInt32(sett.getMhpItem()))
                {
                    sett.setHpItem(sett.getMhpItem());
                }
                var regex = new Regex(Regex.Escape("pot med,"));
                sett.setItemList(regex.Replace(sett.getItemList(),"",1));
                sett.setMensagem("Você curou 20 de dano graças a uma poção média");
            }
            else if (item == "pot peq")
            {
                sett.setHpItem((Convert.ToInt32(sett.getHpItem()) + 10) + "");
                if (Convert.ToInt32(sett.getHpItem()) > Convert.ToInt32(sett.getMhpItem()))
                {
                    sett.setHpItem(sett.getMhpItem());
                }
                var regex = new Regex(Regex.Escape("pot peq,"));
                sett.setItemList(regex.Replace(sett.getItemList(), "", 1));
                sett.setMensagem("Você curou 10 de dano graças a uma poção pequena");
            }
            else if (item == "pot max")
            {
                
                    sett.setHpItem(sett.getMhpItem());
                
                var regex = new Regex(Regex.Escape("pot max,"));
                sett.setItemList(regex.Replace(sett.getItemList(), "", 1));
                sett.setMensagem("Você curou todo seu dano graças a uma poção máxima");
            }
            else if (item == "am destreza")
            {
                sett.setDesItem((Convert.ToInt32(sett.getDesItem()) + 10) + "");
                
                var regex = new Regex(Regex.Escape("am destreza,"));
                sett.setItemList(regex.Replace(sett.getItemList(), "", 1));
                sett.setMensagem("Você aumentou 10 de destreza graças a um amuleto");
            }
            else if (item == "am força")
            {
                sett.setAtkItem((Convert.ToInt32(sett.getAtkItem()) + 10) + "");

                var regex = new Regex(Regex.Escape("am força,"));
                sett.setItemList(regex.Replace(sett.getItemList(), "", 1));
                sett.setMensagem("Você aumentou 10 de ataque graças a um amuleto");
            }
            else if (item == "am velocidade")
            {
                sett.setVelItem((Convert.ToInt32(sett.getVelItem()) + 10) + "");

                var regex = new Regex(Regex.Escape("am velocidade,"));
                sett.setItemList(regex.Replace(sett.getItemList(), "", 1));
                sett.setMensagem("Você aumentou 10 de velocidade graças a um amuleto");
            }
            else if (item == "am defesa")
            {
                sett.setDefItem((Convert.ToInt32(sett.getDefItem()) + 10) + "");

                var regex = new Regex(Regex.Escape("am defesa,"));
                sett.setItemList(regex.Replace(sett.getItemList(), "", 1));
                sett.setMensagem("Você aumentou 10 de defesa graças a um amuleto");
            }
            else if (item == "am poderoso")
            {
                sett.setAtkItem((Convert.ToInt32(sett.getAtkItem()) + 5) + "");
                sett.setDefItem((Convert.ToInt32(sett.getDefItem()) + 5) + "");
                sett.setVelItem((Convert.ToInt32(sett.getVelItem()) + 5) + "");
                sett.setDesItem((Convert.ToInt32(sett.getDesItem()) + 5) + "");

                var regex = new Regex(Regex.Escape("am poderoso,"));
                sett.setItemList(regex.Replace(sett.getItemList(), "", 1));
                sett.setMensagem("Você aumentou 5 de seus status graças a um amuleto");
            }
            else if (item == "carta real")
            {
                sett.setAtkItem((Convert.ToInt32(sett.getAtkItem()) + 10) + "");
                sett.setDefItem((Convert.ToInt32(sett.getDefItem()) + 10) + "");
                sett.setVelItem((Convert.ToInt32(sett.getVelItem()) + 10) + "");
                sett.setDesItem((Convert.ToInt32(sett.getDesItem()) + 10) + "");

                var regex = new Regex(Regex.Escape("carta real,"));
                sett.setItemList(regex.Replace(sett.getItemList(), "", 1));
                sett.setMensagem("Você aumentou 10 de seus status graças à carta real");
            }
            else
            {
                sett.setMensagem("Você não conseguiu usar nenhum item.");
            }
            this.Close();
        }
    }
}
