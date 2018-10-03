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
    public partial class Personagem : Form
    {
        public Personagem()
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
       
        private void Personagem_Load(object sender, EventArgs e)
        {
            if(sett.getPersonagem1() != null)
            {
                //MessageBox.Show(sett.turnoDeQuem(sett.getClick()).ToString());
                //MessageBox.Show(sett.getPersonagem1().FrameDimensionsList.Count().ToString());
                //MessageBox.Show(b.Palette.Entries.Count().ToString());
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.The_Knights_Shield.PhysicalDimension
                   )
                {
                    
                    pbxImage.BackgroundImage = Properties.Resources.KingImg;
                    this.Text = "Príncipe";
                    if (king.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.KingImgEvol;
                        this.Text = "Rei";
                    }

                    lblHp.Text = king.getHP().ToString() + "//" + king.getMHP().ToString();
                    lblAtk.Text = king.getATK().ToString();
                    lblDef.Text = king.getDEF().ToString();
                    lblDes.Text = king.getDES().ToString();
                    lblVel.Text = king.getVEL().ToString();
                    lblHab.Text = king.getHAB();
                    if (king.getITEM() != "")
                        lblItem.Text = king.getITEM().Remove(king.getITEM().Length - 1);
                    else
                    lblItem.Text = king.getITEM();
                    lblWeapon.Text = king.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.warrior.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.warriorImg;
                    this.Text = "Guerreiro";
                    if (warrior.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.warriorImgEvol;
                        this.Text = "Espadachim";
                    }
                    lblHp.Text = warrior.getHP().ToString() + "//" + warrior.getMHP().ToString();
                    lblAtk.Text = warrior.getATK().ToString();
                    lblDef.Text = warrior.getDEF().ToString();
                    lblDes.Text = warrior.getDES().ToString();
                    lblVel.Text = warrior.getVEL().ToString();
                    lblHab.Text = warrior.getHAB();
                    if (warrior.getITEM() != "")
                        lblItem.Text = warrior.getITEM().Remove(warrior.getITEM().Length - 1);
                    else
                    lblItem.Text = warrior.getITEM();
                    lblWeapon.Text = warrior.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.archer.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.archerImg;
                    this.Text = "Arqueiro";
                    if (archer.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.archerImgEvol;
                        this.Text = "Sniper";
                    }
                    lblHp.Text = archer.getHP().ToString() + "//" + archer.getMHP().ToString();
                    lblAtk.Text = archer.getATK().ToString();
                    lblDef.Text = archer.getDEF().ToString();
                    lblDes.Text = archer.getDES().ToString();
                    lblVel.Text = archer.getVEL().ToString();
                    lblHab.Text = archer.getHAB();
                    if (archer.getITEM() != "")
                        lblItem.Text = archer.getITEM().Remove(archer.getITEM().Length - 1);
                    else
                    lblItem.Text = archer.getITEM();
                    lblWeapon.Text = archer.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.clerig.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.clerigImg;
                    this.Text = "Clérigo";
                    if (clerig.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.clerigImgEvol;
                        this.Text = "Bispo";
                    }
                    lblHp.Text = clerig.getHP().ToString() + "//" + clerig.getMHP().ToString();
                    lblAtk.Text = clerig.getATK().ToString();
                    lblDef.Text = clerig.getDEF().ToString();
                    lblDes.Text = clerig.getDES().ToString();
                    lblVel.Text = clerig.getVEL().ToString();
                    lblHab.Text = clerig.getHAB();
                    if (clerig.getITEM() != "")
                        lblItem.Text = clerig.getITEM().Remove(clerig.getITEM().Length - 1);
                    else
                    lblItem.Text = clerig.getITEM();
                    lblWeapon.Text = clerig.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.mage.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.mageImg;
                    this.Text = "Mago";
                    if (mage.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.mageImgEvol;
                        this.Text = "Mago negro";
                    }
                    lblHp.Text = mage.getHP().ToString() + "//" + mage.getMHP().ToString();
                    lblAtk.Text = mage.getATK().ToString();
                    lblDef.Text = mage.getDEF().ToString();
                    lblDes.Text = mage.getDES().ToString();
                    lblVel.Text = mage.getVEL().ToString();
                    lblHab.Text = mage.getHAB();
                    if (mage.getITEM() != "")
                        lblItem.Text = mage.getITEM().Remove(mage.getITEM().Length - 1);
                    else
                    lblItem.Text = mage.getITEM();
                    lblWeapon.Text = mage.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.winged.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.wingedImg;
                    this.Text = "Escudeiro de Pegasus";
                    if (winged.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.wingedImgEvol;
                        this.Text = "CAVALEIRO de Pegasus";
                    }
                    lblHp.Text = winged.getHP().ToString() + "//" + winged.getMHP().ToString();
                    lblAtk.Text = winged.getATK().ToString();
                    lblDef.Text = winged.getDEF().ToString();
                    lblDes.Text = winged.getDES().ToString();
                    lblVel.Text = winged.getVEL().ToString();
                    lblHab.Text = winged.getHAB();
                    if (winged.getITEM() != "")
                        lblItem.Text = winged.getITEM().Remove(winged.getITEM().Length - 1);
                    else
                    lblItem.Text = winged.getITEM();
                    lblWeapon.Text = winged.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.barbarian.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.barbarianImg;
                    this.Text = "Rebelde";
                    if (barbarian.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.barbarianImgEvol;
                        this.Text = "Barbáro";
                    }
                    lblHp.Text = barbarian.getHP().ToString() + "//" + barbarian.getMHP().ToString();
                    lblAtk.Text = barbarian.getATK().ToString();
                    lblDef.Text = barbarian.getDEF().ToString();
                    lblDes.Text = barbarian.getDES().ToString();
                    lblVel.Text = barbarian.getVEL().ToString();
                    lblHab.Text = barbarian.getHAB();
                    if (barbarian.getITEM() != "")
                        lblItem.Text = barbarian.getITEM().Remove(barbarian.getITEM().Length - 1);
                    else
                    lblItem.Text = barbarian.getITEM();
                    lblWeapon.Text = barbarian.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.assasin.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.assasinImg;
                    this.Text = "Ladrão";
                    if (assasin.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.assasinImgEvol;
                        this.Text = "Assasino";
                    }
                    lblHp.Text = assasin.getHP().ToString() + "//" + assasin.getMHP().ToString();
                    lblAtk.Text = assasin.getATK().ToString();
                    lblDef.Text = assasin.getDEF().ToString();
                    lblDes.Text = assasin.getDES().ToString();
                    lblVel.Text = assasin.getVEL().ToString();
                    lblHab.Text = assasin.getHAB();
                    if (assasin.getITEM() != "")
                        lblItem.Text = assasin.getITEM().Remove(assasin.getITEM().Length - 1);
                    else
                        lblItem.Text = assasin.getITEM();
                    lblWeapon.Text = assasin.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.horse.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.horseImg;
                    this.Text = "Escudeiro";
                    if (horse.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.horseImgEvol;
                        this.Text = "Cavaleiro";
                    }
                    lblHp.Text = horse.getHP().ToString() + "//" + horse.getMHP().ToString();
                    lblAtk.Text = horse.getATK().ToString();
                    lblDef.Text = horse.getDEF().ToString();
                    lblDes.Text = horse.getDES().ToString();
                    lblVel.Text = horse.getVEL().ToString();
                    lblHab.Text = horse.getHAB();
                    if (horse.getITEM() != "")
                        lblItem.Text = horse.getITEM().Remove(horse.getITEM().Length - 1);
                    else
                       lblItem.Text = horse.getITEM();
                    lblWeapon.Text = horse.getWEAPON();
                }





                //separação



                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension
                    )
                {

                    pbxImage.BackgroundImage = Properties.Resources.kingenemyImg;
                    this.Text = "Príncipe";
                    if (kingenemy.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.kingenemyImgEvol;
                        this.Text = "Rei";
                    }

                    lblHp.Text = kingenemy.getHP().ToString() + "//" + kingenemy.getMHP().ToString();
                    lblAtk.Text = kingenemy.getATK().ToString();
                    lblDef.Text = kingenemy.getDEF().ToString();
                    lblDes.Text = kingenemy.getDES().ToString();
                    lblVel.Text = kingenemy.getVEL().ToString();
                    lblHab.Text = kingenemy.getHAB();
                    if (kingenemy.getITEM() != "")
                        lblItem.Text = kingenemy.getITEM().Remove(kingenemy.getITEM().Length - 1);
                    else
                        lblItem.Text = kingenemy.getITEM();
                    lblWeapon.Text = kingenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.warrior___Enemy.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.warriorenemyImg;
                    this.Text = "Guerreiro";
                    if (warriorenemy.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.warriorenemyImgEvol;
                        this.Text = "Espadachim";
                    }
                    lblHp.Text = warriorenemy.getHP().ToString() + "//" + warriorenemy.getMHP().ToString();
                    lblAtk.Text = warriorenemy.getATK().ToString();
                    lblDef.Text = warriorenemy.getDEF().ToString();
                    lblDes.Text = warriorenemy.getDES().ToString();
                    lblVel.Text = warriorenemy.getVEL().ToString();
                    lblHab.Text = warriorenemy.getHAB();
                    if (warriorenemy.getITEM() != "")
                        lblItem.Text = warriorenemy.getITEM().Remove(warriorenemy.getITEM().Length - 1);
                    else
                        lblItem.Text = warriorenemy.getITEM();
                    lblWeapon.Text = warriorenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.archer___Enemy.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.archerenemyImg;
                    this.Text = "Arqueiro";
                    if (archerenemy.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.archerenemyImgEvol;
                        this.Text = "Sniper";
                    }
                    lblHp.Text = archerenemy.getHP().ToString() + "//" + archerenemy.getMHP().ToString();
                    lblAtk.Text = archerenemy.getATK().ToString();
                    lblDef.Text = archerenemy.getDEF().ToString();
                    lblDes.Text = archerenemy.getDES().ToString();
                    lblVel.Text = archerenemy.getVEL().ToString();
                    lblHab.Text = archerenemy.getHAB();
                    if (archerenemy.getITEM() != "")
                        lblItem.Text = archerenemy.getITEM().Remove(archerenemy.getITEM().Length - 1);
                    else
                        lblItem.Text = archerenemy.getITEM();
                    lblWeapon.Text = archerenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.clerig___Enemy.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.clerigenemyImg;
                    this.Text = "Clérigo";
                    if (clerigenemy.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.clerigenemyImgEvol;
                        this.Text = "Bispo";
                    }
                    lblHp.Text = clerigenemy.getHP().ToString() + "//" + clerigenemy.getMHP().ToString();
                    lblAtk.Text = clerigenemy.getATK().ToString();
                    lblDef.Text = clerigenemy.getDEF().ToString();
                    lblDes.Text = clerigenemy.getDES().ToString();
                    lblVel.Text = clerigenemy.getVEL().ToString();
                    lblHab.Text = clerigenemy.getHAB();
                    if (clerigenemy.getITEM() != "")
                        lblItem.Text = clerigenemy.getITEM().Remove(clerigenemy.getITEM().Length - 1);
                    else
                       lblItem.Text = clerigenemy.getITEM();
                    lblWeapon.Text = clerigenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.mage___Enemy.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.mageenemyImg;
                    this.Text = "Mago";
                    if (mageenemy.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.mageenemyImgEvol;
                        this.Text = "Mago negro";
                    }
                    lblHp.Text = mageenemy.getHP().ToString() + "//" + mageenemy.getMHP().ToString();
                    lblAtk.Text = mageenemy.getATK().ToString();
                    lblDef.Text = mageenemy.getDEF().ToString();
                    lblDes.Text = mageenemy.getDES().ToString();
                    lblVel.Text = mageenemy.getVEL().ToString();
                    lblHab.Text = mageenemy.getHAB();
                    if (mageenemy.getITEM() != "")
                        lblItem.Text = mageenemy.getITEM().Remove(mageenemy.getITEM().Length - 1);
                    else
                        lblItem.Text = mageenemy.getITEM();
                    lblWeapon.Text = mageenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.winged___Enemy.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.wingedenemyImg;
                    this.Text = "Escudeiro de Pegasus";
                    if (wingedenemy.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.wingedenemyImgEvol;
                        this.Text = "CAVALEIRO de Pegasus";
                    }
                    lblHp.Text = wingedenemy.getHP().ToString() + "//" + wingedenemy.getMHP().ToString();
                    lblAtk.Text = wingedenemy.getATK().ToString();
                    lblDef.Text = wingedenemy.getDEF().ToString();
                    lblDes.Text = wingedenemy.getDES().ToString();
                    lblVel.Text = wingedenemy.getVEL().ToString();
                    lblHab.Text = wingedenemy.getHAB();
                    if (wingedenemy.getITEM() != "")
                        lblItem.Text = wingedenemy.getITEM().Remove(wingedenemy.getITEM().Length - 1);
                    else
                        lblItem.Text = wingedenemy.getITEM();
                    lblWeapon.Text = wingedenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.barbarian___Enemy.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.barbarianenemyImg;
                    this.Text = "Rebelde";
                    if (barbarianenemy.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.barbarianenemyImgEvol;
                        this.Text = "Barbáro";
                    }
                    lblHp.Text = barbarianenemy.getHP().ToString() + "//" + barbarianenemy.getMHP().ToString();
                    lblAtk.Text = barbarianenemy.getATK().ToString();
                    lblDef.Text = barbarianenemy.getDEF().ToString();
                    lblDes.Text = barbarianenemy.getDES().ToString();
                    lblVel.Text = barbarianenemy.getVEL().ToString();
                    lblHab.Text = barbarianenemy.getHAB();
                    if (barbarianenemy.getITEM() != "")
                        lblItem.Text = barbarianenemy.getITEM().Remove(barbarianenemy.getITEM().Length - 1);
                    else
                        lblItem.Text = barbarianenemy.getITEM();
                    lblWeapon.Text = barbarianenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.assasin___Enemy.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.assasinenemyImg;
                    this.Text = "Ladrão";
                    if (assasinenemy.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.assasinenemyImgEvol;
                        this.Text = "Assasino";
                    }
                    lblHp.Text = assasinenemy.getHP().ToString() + "//" + assasinenemy.getMHP().ToString();
                    lblAtk.Text = assasinenemy.getATK().ToString();
                    lblDef.Text = assasinenemy.getDEF().ToString();
                    lblDes.Text = assasinenemy.getDES().ToString();
                    lblVel.Text = assasinenemy.getVEL().ToString();
                    lblHab.Text = assasinenemy.getHAB();
                    if (assasinenemy.getITEM() != "")
                        lblItem.Text = assasinenemy.getITEM().Remove(assasinenemy.getITEM().Length - 1);
                    else
                        lblItem.Text = assasinenemy.getITEM();
                    lblWeapon.Text = assasinenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.horse___Enemy.PhysicalDimension
                    )
                {
                    pbxImage.BackgroundImage = Properties.Resources.horseenemyImg;
                    this.Text = "Escudeiro";
                    if (horseenemy.getEVOL())
                    {
                        pbxImage.BackgroundImage = Properties.Resources.horseenemyImgEvol;
                        this.Text = "Cavaleiro";
                    }
                    lblHp.Text = horseenemy.getHP().ToString() + "//" + horseenemy.getMHP().ToString();
                    lblAtk.Text = horseenemy.getATK().ToString();
                    lblDef.Text = horseenemy.getDEF().ToString();
                    lblDes.Text = horseenemy.getDES().ToString();
                    lblVel.Text = horseenemy.getVEL().ToString();
                    lblHab.Text = horseenemy.getHAB();
                    if (horseenemy.getITEM() != "")
                        lblItem.Text = horseenemy.getITEM().Remove(horseenemy.getITEM().Length - 1);
                    else
                        lblItem.Text = horseenemy.getITEM();
                    lblWeapon.Text = horseenemy.getWEAPON();
                }


            }

        }

      
    }
}
