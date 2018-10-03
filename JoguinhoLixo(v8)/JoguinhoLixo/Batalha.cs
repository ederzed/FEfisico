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
    public partial class Batalha : Form
    {
        public Batalha()
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
        bool alcance = false;
        bool defensor = false;
        bool reforçonoataque = false;
        bool esforco = false;
        bool martir = false;
        bool martire = false;
        bool loucura = false;
        bool usingitem = false;
        bool usingitem1 = false;
        bool usadoitem = false;
        int bufdearea = 0;
        int bufdearea1 = 0;
        string arma = "";
        private void Batalha_Load(object sender, EventArgs e)
        {
            alcance = false;
            defensor = false;
            reforçonoataque = false;
            esforco = false;
            martir = false;
            martire = false;
            loucura = false;
            usadoitem = false;
           
            if(sett.getBuf1() != null)
            {
                bufdearea = +10;
                lblBattle.Text = lblBattle.Text + "Alteração de status graças ao terreno CASTELO.";
            }
            if (sett.getBuf2() != null)
            {
                bufdearea1 = -5;
                lblBattle.Text = lblBattle.Text + "Alteração de status graças ao terreno GRAMA.";
            }
            if (sett.getPersonagem1() != null)
            {
                //MessageBox.Show(sett.turnoDeQuem(sett.getClick()).ToString());
                //MessageBox.Show(sett.getPersonagem1().FrameDimensionsList.Count().ToString());
                //MessageBox.Show(b.Palette.Entries.Count().ToString());
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.The_Knights_Shield.PhysicalDimension
                   )
                {

                    pbxAtacante.BackgroundImage = Properties.Resources.KingImg;
                    //this.Text = "Príncipe";
                    if (king.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.KingImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = king.getHP().ToString();
                    lblAtkA.Text = (king.getATK() ).ToString();
                    lblDefA.Text = (king.getDEF() ).ToString();
                    lblDesA.Text = (king.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (king.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = king.getHAB();
                    if (king.getITEM() != "")
                        lblItemA.Text = king.getITEM().Remove(king.getITEM().Length - 1);
                    else
                        lblItemA.Text = king.getITEM();
                    lblWeaponA.Text = king.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.warrior.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.warriorImg;
                    //this.Text = "Guerreiro";
                    if (warrior.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.warriorImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = warrior.getHP().ToString();
                    lblAtkA.Text = (warrior.getATK() ).ToString();
                    lblDefA.Text = (warrior.getDEF() ).ToString();
                    lblDesA.Text = (warrior.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (warrior.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = warrior.getHAB();
                    if (warrior.getITEM() != "")
                        lblItemA.Text = warrior.getITEM().Remove(warrior.getITEM().Length - 1);
                    else
                        lblItemA.Text = warrior.getITEM();
                    lblWeaponA.Text = warrior.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.archer.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.archerImg;
                    //this.Text = "Arqueiro";
                    if (archer.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.archerImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = archer.getHP().ToString();

                    lblAtkA.Text = (archer.getATK() ).ToString();
                    lblDefA.Text = (archer.getDEF() ).ToString();
                    lblDesA.Text = (archer.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (archer.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = archer.getHAB();
                    if (archer.getITEM() != "")
                        lblItemA.Text = archer.getITEM().Remove(archer.getITEM().Length - 1);
                    else
                        lblItemA.Text = archer.getITEM();
                    lblWeaponA.Text = archer.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.clerig.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.clerigImg;
                    //this.Text = "Clérigo";
                    if (clerig.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.clerigImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = clerig.getHP().ToString();
                    lblAtkA.Text = (clerig.getATK() ).ToString();
                    lblDefA.Text = (clerig.getDEF() ).ToString();
                    lblDesA.Text = (clerig.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (clerig.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = clerig.getHAB();
                    if (clerig.getITEM() != "")
                        lblItemA.Text = clerig.getITEM().Remove(clerig.getITEM().Length - 1);
                    else
                        lblItemA.Text = clerig.getITEM();
                    lblWeaponA.Text = clerig.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.mage.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.mageImg;
                    //this.Text = "Mago";
                    if (mage.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.mageImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = mage.getHP().ToString();
                    lblAtkA.Text = (mage.getATK() ).ToString();
                    lblDefA.Text = (mage.getDEF() ).ToString();
                    lblDesA.Text = (mage.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (mage.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = mage.getHAB();
                    if (mage.getITEM() != "")
                        lblItemA.Text = mage.getITEM().Remove(mage.getITEM().Length - 1);
                    else
                        lblItemA.Text = mage.getITEM();
                    lblWeaponA.Text = mage.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.winged.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.wingedImg;
                    //this.Text = "Escudeiro de Pegasus";
                    if (winged.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.wingedImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = winged.getHP().ToString();
                    lblAtkA.Text = (winged.getATK() ).ToString();
                    lblDefA.Text = (winged.getDEF() ).ToString();
                    lblDesA.Text = (winged.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (winged.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = winged.getHAB();
                    if (winged.getITEM() != "")
                        lblItemA.Text = winged.getITEM().Remove(winged.getITEM().Length - 1);
                    else
                        lblItemA.Text = winged.getITEM();
                    lblWeaponA.Text = winged.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.barbarian.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.barbarianImg;
                    //this.Text = "Rebelde";
                    if (barbarian.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.barbarianImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = barbarian.getHP().ToString();
                    lblAtkA.Text = (barbarian.getATK() ).ToString();
                    lblDefA.Text = (barbarian.getDEF() ).ToString();
                    lblDesA.Text = (barbarian.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (barbarian.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = barbarian.getHAB();
                    if (barbarian.getITEM() != "")
                        lblItemA.Text = barbarian.getITEM().Remove(barbarian.getITEM().Length - 1);
                    else
                        lblItemA.Text = barbarian.getITEM();
                    lblWeaponA.Text = barbarian.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.assasin.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.assasinImg;
                    //this.Text = "Ladrão";
                    if (assasin.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.assasinImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = assasin.getHP().ToString();
                    lblAtkA.Text = (assasin.getATK() ).ToString();
                    lblDefA.Text = (assasin.getDEF() ).ToString();
                    lblDesA.Text = (assasin.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (assasin.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = assasin.getHAB();
                    if (assasin.getITEM() != "")
                        lblItemA.Text = assasin.getITEM().Remove(assasin.getITEM().Length - 1);
                    else
                        lblItemA.Text = assasin.getITEM();
                    lblWeaponA.Text = assasin.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.horse.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.horseImg;
                    //this.Text = "Escudeiro";
                    if (horse.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.horseImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = horse.getHP().ToString();
                    lblAtkA.Text = (horse.getATK() ).ToString();
                    lblDefA.Text = (horse.getDEF() ).ToString();
                    lblDesA.Text = (horse.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (horse.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = horse.getHAB();
                    if (horse.getITEM() != "")
                        lblItemA.Text = horse.getITEM().Remove(horse.getITEM().Length - 1);
                    else
                        lblItemA.Text = horse.getITEM();
                    lblWeaponA.Text = horse.getWEAPON();
                }





                //separação



                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension
                  )
                {

                    pbxAtacante.BackgroundImage = Properties.Resources.kingenemyImg;
                    //this.Text = "Príncipe";
                    if (kingenemy.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.kingenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = kingenemy.getHP().ToString();
                    lblAtkA.Text = (kingenemy.getATK() ).ToString();
                    lblDefA.Text = (kingenemy.getDEF() ).ToString();
                    lblDesA.Text = (kingenemy.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (kingenemy.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = kingenemy.getHAB();
                    if (kingenemy.getITEM() != "")
                        lblItemA.Text = kingenemy.getITEM().Remove(kingenemy.getITEM().Length - 1);
                    else
                        lblItemA.Text = kingenemy.getITEM();
                    lblWeaponA.Text = kingenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.warrior___Enemy.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.warriorenemyImg;
                    //this.Text = "Guerreiro";
                    if (warriorenemy.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.warriorenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = warriorenemy.getHP().ToString();
                    lblAtkA.Text = (warriorenemy.getATK() ).ToString();
                    lblDefA.Text = (warriorenemy.getDEF() ).ToString();
                    lblDesA.Text = (warriorenemy.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (warriorenemy.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = warriorenemy.getHAB();
                    if (warriorenemy.getITEM() != "")
                        lblItemA.Text = warriorenemy.getITEM().Remove(warriorenemy.getITEM().Length - 1);
                    else
                        lblItemA.Text = warriorenemy.getITEM();
                    lblWeaponA.Text = warriorenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.archer___Enemy.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.archerenemyImg;
                    //this.Text = "Arqueiro";
                    if (archerenemy.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.archerenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = archerenemy.getHP().ToString();

                    lblAtkA.Text = (archerenemy.getATK() ).ToString();
                    lblDefA.Text = (archerenemy.getDEF() ).ToString();
                    lblDesA.Text = (archerenemy.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (archerenemy.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = archerenemy.getHAB();
                    if (archerenemy.getITEM() != "")
                        lblItemA.Text = archerenemy.getITEM().Remove(archerenemy.getITEM().Length - 1);
                    else
                        lblItemA.Text = archerenemy.getITEM();
                    lblWeaponA.Text = archerenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.clerig___Enemy.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.clerigenemyImg;
                    //this.Text = "Clérigo";
                    if (clerigenemy.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.clerigenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = clerigenemy.getHP().ToString();
                    lblAtkA.Text = (clerigenemy.getATK() ).ToString();
                    lblDefA.Text = (clerigenemy.getDEF() ).ToString();
                    lblDesA.Text = (clerigenemy.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (clerigenemy.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = clerigenemy.getHAB();
                    if (clerigenemy.getITEM() != "")
                        lblItemA.Text = clerigenemy.getITEM().Remove(clerigenemy.getITEM().Length - 1);
                    else
                        lblItemA.Text = clerigenemy.getITEM();
                    lblWeaponA.Text = clerigenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.mage___Enemy.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.mageenemyImg;
                    //this.Text = "Mago";
                    if (mageenemy.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.mageenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = mageenemy.getHP().ToString();
                    lblAtkA.Text = (mageenemy.getATK() ).ToString();
                    lblDefA.Text = (mageenemy.getDEF() ).ToString();
                    lblDesA.Text = (mageenemy.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (mageenemy.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = mageenemy.getHAB();
                    if (mageenemy.getITEM() != "")
                        lblItemA.Text = mageenemy.getITEM().Remove(mageenemy.getITEM().Length - 1);
                    else
                        lblItemA.Text = mageenemy.getITEM();
                    lblWeaponA.Text = mageenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.winged___Enemy.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.wingedenemyImg;
                    //this.Text = "Escudeiro de Pegasus";
                    if (wingedenemy.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.wingedenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = wingedenemy.getHP().ToString();
                    lblAtkA.Text = (wingedenemy.getATK() ).ToString();
                    lblDefA.Text = (wingedenemy.getDEF() ).ToString();
                    lblDesA.Text = (wingedenemy.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (wingedenemy.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = wingedenemy.getHAB();
                    if (wingedenemy.getITEM() != "")
                        lblItemA.Text = wingedenemy.getITEM().Remove(wingedenemy.getITEM().Length - 1);
                    else
                        lblItemA.Text = wingedenemy.getITEM();
                    lblWeaponA.Text = wingedenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.barbarian___Enemy.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                    //this.Text = "Rebelde";
                    if (barbarianenemy.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = barbarianenemy.getHP().ToString();
                    lblAtkA.Text = (barbarianenemy.getATK() ).ToString();
                    lblDefA.Text = (barbarianenemy.getDEF() ).ToString();
                    lblDesA.Text = (barbarianenemy.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (barbarianenemy.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = barbarianenemy.getHAB();
                    if (barbarianenemy.getITEM() != "")
                        lblItemA.Text = barbarianenemy.getITEM().Remove(barbarianenemy.getITEM().Length - 1);
                    else
                        lblItemA.Text = barbarianenemy.getITEM();
                    lblWeaponA.Text = barbarianenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.assasin___Enemy.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.assasinenemyImg;
                    //this.Text = "Ladrão";
                    if (assasinenemy.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.assasinenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = assasinenemy.getHP().ToString();
                    lblAtkA.Text = (assasinenemy.getATK() ).ToString();
                    lblDefA.Text = (assasinenemy.getDEF() ).ToString();
                    lblDesA.Text = (assasinenemy.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (assasinenemy.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = assasinenemy.getHAB();
                    if (assasinenemy.getITEM() != "")
                        lblItemA.Text = assasinenemy.getITEM().Remove(assasinenemy.getITEM().Length - 1);
                    else
                        lblItemA.Text = assasinenemy.getITEM();
                    lblWeaponA.Text = assasinenemy.getWEAPON();
                }
                if (sett.getPersonagem1().PhysicalDimension == Properties.Resources.horse___Enemy.PhysicalDimension
                    )
                {
                    pbxAtacante.BackgroundImage = Properties.Resources.horseenemyImg;
                    //this.Text = "Escudeiro";
                    if (horseenemy.getEVOL())
                    {
                        pbxAtacante.BackgroundImage = Properties.Resources.horseenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpA.Text = horseenemy.getHP().ToString();
                    lblAtkA.Text = (horseenemy.getATK() ).ToString();
                    lblDefA.Text = (horseenemy.getDEF() ).ToString();
                    lblDesA.Text = (horseenemy.getDES() + bufdearea1).ToString();
                    lblVelA.Text = (horseenemy.getVEL() + bufdearea1).ToString();
                    lblHabA.Text = horseenemy.getHAB();
                    if (horseenemy.getITEM() != "")
                        lblItemA.Text = horseenemy.getITEM().Remove(horseenemy.getITEM().Length - 1);
                    else
                        lblItemA.Text = horseenemy.getITEM();
                    lblWeaponA.Text = horseenemy.getWEAPON();
                }



            }


















            //SUPER SEPARAÇÃO


















            if (sett.getPersonagem2() != null)
            {
                //MessageBox.Show(sett.turnoDeQuem(sett.getClick()).ToString());
                //MessageBox.Show(sett.getPersonagem2().FrameDimensionsList.Count().ToString());
                //MessageBox.Show(b.Palette.Entries.Count().ToString());
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.The_Knights_Shield.PhysicalDimension
                   )
                {

                    pbxDefensor.BackgroundImage = Properties.Resources.KingImg;
                    //this.Text = "Príncipe";
                    if (king.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.KingImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = king.getHP().ToString();
                    lblAtkD.Text = (king.getATK() + bufdearea).ToString();
                    lblDefD.Text = (king.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (king.getDES() ).ToString();
                    lblVelD.Text = (king.getVEL() ).ToString();
                    lblHabD.Text = king.getHAB();
                    if (king.getITEM() != "")
                        lblItemD.Text = king.getITEM().Remove(king.getITEM().Length - 1);
                    else
                        lblItemD.Text = king.getITEM();
                    lblWeaponD.Text = king.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.warrior.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.warriorImg;
                    //this.Text = "Guerreiro";
                    if (warrior.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.warriorImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = warrior.getHP().ToString();
                    lblAtkD.Text = (warrior.getATK() + bufdearea).ToString();
                    lblDefD.Text = (warrior.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (warrior.getDES() ).ToString();
                    lblVelD.Text = (warrior.getVEL() ).ToString();
                    lblHabD.Text = warrior.getHAB();
                    if (warrior.getITEM() != "")
                        lblItemD.Text = warrior.getITEM().Remove(warrior.getITEM().Length - 1);
                    else
                        lblItemD.Text = warrior.getITEM();
                    lblWeaponD.Text = warrior.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.archer.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.archerImg;
                    //this.Text = "Arqueiro";
                    if (archer.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.archerImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = archer.getHP().ToString();

                    lblAtkD.Text = (archer.getATK() + bufdearea).ToString();
                    lblDefD.Text = (archer.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (archer.getDES() ).ToString();
                    lblVelD.Text = (archer.getVEL() ).ToString();
                    lblHabD.Text = archer.getHAB();
                    if (archer.getITEM() != "")
                        lblItemD.Text = archer.getITEM().Remove(archer.getITEM().Length - 1);
                    else
                        lblItemD.Text = archer.getITEM();
                    lblWeaponD.Text = archer.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.clerig.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.clerigImg;
                    //this.Text = "Clérigo";
                    if (clerig.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.clerigImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = clerig.getHP().ToString();
                    lblAtkD.Text = (clerig.getATK() + bufdearea).ToString();
                    lblDefD.Text = (clerig.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (clerig.getDES() ).ToString();
                    lblVelD.Text = (clerig.getVEL() ).ToString();
                    lblHabD.Text = clerig.getHAB();
                    if (clerig.getITEM() != "")
                        lblItemD.Text = clerig.getITEM().Remove(clerig.getITEM().Length - 1);
                    else
                        lblItemD.Text = clerig.getITEM();
                    lblWeaponD.Text = clerig.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.mage.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.mageImg;
                    //this.Text = "Mago";
                    if (mage.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.mageImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = mage.getHP().ToString();
                    lblAtkD.Text = (mage.getATK() + bufdearea).ToString();
                    lblDefD.Text = (mage.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (mage.getDES() ).ToString();
                    lblVelD.Text = (mage.getVEL() ).ToString();
                    lblHabD.Text = mage.getHAB();
                    if (mage.getITEM() != "")
                        lblItemD.Text = mage.getITEM().Remove(mage.getITEM().Length - 1);
                    else
                        lblItemD.Text = mage.getITEM();
                    lblWeaponD.Text = mage.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.winged.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.wingedImg;
                    //this.Text = "Escudeiro de Pegasus";
                    if (winged.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.wingedImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = winged.getHP().ToString();
                    lblAtkD.Text = (winged.getATK() + bufdearea).ToString();
                    lblDefD.Text = (winged.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (winged.getDES() ).ToString();
                    lblVelD.Text = (winged.getVEL() ).ToString();
                    lblHabD.Text = winged.getHAB();
                    if (winged.getITEM() != "")
                        lblItemD.Text = winged.getITEM().Remove(winged.getITEM().Length - 1);
                    else
                        lblItemD.Text = winged.getITEM();
                    lblWeaponD.Text = winged.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.barbarian.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.barbarianImg;
                    //this.Text = "Rebelde";
                    if (barbarian.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.barbarianImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = barbarian.getHP().ToString();
                    lblAtkD.Text = (barbarian.getATK() + bufdearea).ToString();
                    lblDefD.Text = (barbarian.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (barbarian.getDES() ).ToString();
                    lblVelD.Text = (barbarian.getVEL() ).ToString();
                    lblHabD.Text = barbarian.getHAB();
                    if (barbarian.getITEM() != "")
                        lblItemD.Text = barbarian.getITEM().Remove(barbarian.getITEM().Length - 1);
                    else
                        lblItemD.Text = barbarian.getITEM();
                    lblWeaponD.Text = barbarian.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.assasin.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.assasinImg;
                    //this.Text = "Ladrão";
                    if (assasin.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.assasinImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = assasin.getHP().ToString();
                    lblAtkD.Text = (assasin.getATK() + bufdearea).ToString();
                    lblDefD.Text = (assasin.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (assasin.getDES() ).ToString();
                    lblVelD.Text = (assasin.getVEL() ).ToString();
                    lblHabD.Text = assasin.getHAB();
                    if (assasin.getITEM() != "")
                        lblItemD.Text = assasin.getITEM().Remove(assasin.getITEM().Length - 1);
                    else
                        lblItemD.Text = assasin.getITEM();
                    lblWeaponD.Text = assasin.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.horse.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.horseImg;
                    //this.Text = "Escudeiro";
                    if (horse.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.horseImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = horse.getHP().ToString();
                    lblAtkD.Text = (horse.getATK() + bufdearea).ToString();
                    lblDefD.Text = (horse.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (horse.getDES() ).ToString();
                    lblVelD.Text = (horse.getVEL() ).ToString();
                    lblHabD.Text = horse.getHAB();
                      if (horse.getITEM() != "")
                        lblItemD.Text = horse.getITEM().Remove(horse.getITEM().Length - 1);
                    else
                        lblItemD.Text = horse.getITEM();
                    lblWeaponD.Text = horse.getWEAPON();
                }





                //separação



                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension
                  )
                {

                    pbxDefensor.BackgroundImage = Properties.Resources.kingenemyImg;
                    //this.Text = "Príncipe";
                    if (kingenemy.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.kingenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = kingenemy.getHP().ToString();
                    lblAtkD.Text = (kingenemy.getATK() + bufdearea).ToString();
                    lblDefD.Text = (kingenemy.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (kingenemy.getDES() ).ToString();
                    lblVelD.Text = (kingenemy.getVEL() ).ToString();
                    lblHabD.Text = kingenemy.getHAB();
                    if (kingenemy.getITEM() != "")
                        lblItemD.Text = kingenemy.getITEM().Remove(kingenemy.getITEM().Length - 1);
                    else
                        lblItemD.Text = kingenemy.getITEM();
                    lblWeaponD.Text = kingenemy.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.warrior___Enemy.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.warriorenemyImg;
                    //this.Text = "Guerreiro";
                    if (warriorenemy.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.warriorenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = warriorenemy.getHP().ToString();
                    lblAtkD.Text = (warriorenemy.getATK() + bufdearea).ToString();
                    lblDefD.Text = (warriorenemy.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (warriorenemy.getDES() ).ToString();
                    lblVelD.Text = (warriorenemy.getVEL() ).ToString();
                    lblHabD.Text = warriorenemy.getHAB();
                    if (warriorenemy.getITEM() != "")
                        lblItemD.Text = warriorenemy.getITEM().Remove(warriorenemy.getITEM().Length - 1);
                    else
                        lblItemD.Text = warriorenemy.getITEM();
                    lblWeaponD.Text = warriorenemy.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.archer___Enemy.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.archerenemyImg;
                    //this.Text = "Arqueiro";
                    if (archerenemy.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.archerenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = archerenemy.getHP().ToString();

                    lblAtkD.Text = (archerenemy.getATK() + bufdearea).ToString();
                    lblDefD.Text = (archerenemy.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (archerenemy.getDES() ).ToString();
                    lblVelD.Text = (archerenemy.getVEL() ).ToString();
                    lblHabD.Text = archerenemy.getHAB();
                    if (archerenemy.getITEM() != "")
                        lblItemD.Text = archerenemy.getITEM().Remove(archerenemy.getITEM().Length - 1);
                    else
                        lblItemD.Text = archerenemy.getITEM();
                    lblWeaponD.Text = archerenemy.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.clerig___Enemy.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.clerigenemyImg;
                    //this.Text = "Clérigo";
                    if (clerigenemy.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.clerigenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = clerigenemy.getHP().ToString();
                    lblAtkD.Text = (clerigenemy.getATK() + bufdearea).ToString();
                    lblDefD.Text = (clerigenemy.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (clerigenemy.getDES() ).ToString();
                    lblVelD.Text = (clerigenemy.getVEL() ).ToString();
                    lblHabD.Text = clerigenemy.getHAB();
                    if (clerigenemy.getITEM() != "")
                        lblItemD.Text = clerigenemy.getITEM().Remove(clerigenemy.getITEM().Length - 1);
                    else
                        lblItemD.Text = clerigenemy.getITEM();
                    lblWeaponD.Text = clerigenemy.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.mage___Enemy.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.mageenemyImg;
                    //this.Text = "Mago";
                    if (mageenemy.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.mageenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = mageenemy.getHP().ToString();
                    lblAtkD.Text = (mageenemy.getATK() + bufdearea).ToString();
                    lblDefD.Text = (mageenemy.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (mageenemy.getDES() ).ToString();
                    lblVelD.Text = (mageenemy.getVEL() ).ToString();
                    lblHabD.Text = mageenemy.getHAB();
                    if (mageenemy.getITEM() != "")
                        lblItemD.Text = mageenemy.getITEM().Remove(mageenemy.getITEM().Length - 1);
                    else
                        lblItemD.Text = mageenemy.getITEM();
                    lblWeaponD.Text = mageenemy.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.winged___Enemy.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.wingedenemyImg;
                    //this.Text = "Escudeiro de Pegasus";
                    if (wingedenemy.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.wingedenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = wingedenemy.getHP().ToString();
                    lblAtkD.Text = (wingedenemy.getATK() + bufdearea).ToString();
                    lblDefD.Text = (wingedenemy.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (wingedenemy.getDES() ).ToString();
                    lblVelD.Text = (wingedenemy.getVEL() ).ToString();
                    lblHabD.Text = wingedenemy.getHAB();
                    if (wingedenemy.getITEM() != "")
                        lblItemD.Text = wingedenemy.getITEM().Remove(wingedenemy.getITEM().Length - 1);
                    else
                        lblItemD.Text = wingedenemy.getITEM();
                    lblWeaponD.Text = wingedenemy.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.barbarian___Enemy.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                    //this.Text = "Rebelde";
                    if (barbarianenemy.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = barbarianenemy.getHP().ToString();
                    lblAtkD.Text = (barbarianenemy.getATK() + bufdearea).ToString();
                    lblDefD.Text = (barbarianenemy.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (barbarianenemy.getDES() ).ToString();
                    lblVelD.Text = (barbarianenemy.getVEL() ).ToString();
                    lblHabD.Text = barbarianenemy.getHAB();
                    if (barbarianenemy.getITEM() != "")
                        lblItemD.Text = barbarianenemy.getITEM().Remove(barbarianenemy.getITEM().Length - 1);
                    else
                        lblItemD.Text = barbarianenemy.getITEM();
                    lblWeaponD.Text = barbarianenemy.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.assasin___Enemy.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.assasinenemyImg;
                    //this.Text = "Ladrão";
                    if (assasinenemy.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.assasinenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = assasinenemy.getHP().ToString();
                    lblAtkD.Text = (assasinenemy.getATK() + bufdearea).ToString();
                    lblDefD.Text = (assasinenemy.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (assasinenemy.getDES() ).ToString();
                    lblVelD.Text = (assasinenemy.getVEL() ).ToString();
                    lblHabD.Text = assasinenemy.getHAB();
                    if (assasinenemy.getITEM() != "")
                        lblItemD.Text = assasinenemy.getITEM().Remove(assasinenemy.getITEM().Length - 1);
                    else
                        lblItemD.Text = assasinenemy.getITEM();
                    lblWeaponD.Text = assasinenemy.getWEAPON();
                }
                if (sett.getPersonagem2().PhysicalDimension == Properties.Resources.horse___Enemy.PhysicalDimension
                    )
                {
                    pbxDefensor.BackgroundImage = Properties.Resources.horseenemyImg;
                    //this.Text = "Escudeiro";
                    if (horseenemy.getEVOL())
                    {
                        pbxDefensor.BackgroundImage = Properties.Resources.horseenemyImgEvol;
                        //this.Text = "Rei";
                    }
                    lblHpD.Text = horseenemy.getHP().ToString();
                    lblAtkD.Text = (horseenemy.getATK() + bufdearea).ToString();
                    lblDefD.Text = (horseenemy.getDEF() + bufdearea).ToString();
                    lblDesD.Text = (horseenemy.getDES() ).ToString();
                    lblVelD.Text = (horseenemy.getVEL() ).ToString();
                    lblHabD.Text = horseenemy.getHAB();
                    if (horseenemy.getITEM() != "")
                        lblItemD.Text = horseenemy.getITEM().Remove(horseenemy.getITEM().Length - 1);
                    else
                        lblItemD.Text = horseenemy.getITEM();
                    lblWeaponD.Text = horseenemy.getWEAPON();
                }



            }
            arma = sett.Before(lblWeaponA.Text, ".");
            if (sett.turnoDeQuem(sett.getClick()) &&
              (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension ||
               pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension))
            {
                btnAtaque.Enabled = false;
                btnHabidade.Enabled = false;
            }
            if (!sett.turnoDeQuem(sett.getClick()) &&
             (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension))
            {
                btnCurar.Enabled = false;
                btnTitem.Enabled = false;
                btnFinalizar.Enabled = false;
            }
            if (!sett.turnoDeQuem(sett.getClick()) &&
            !(pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension ||
             pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension))
            {
                btnAtaque.Enabled = false;
                btnHabidade.Enabled = false;
            }
            if (sett.turnoDeQuem(sett.getClick()) &&
             !(pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension ||
              pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension))
            {
                btnCurar.Enabled = false;
                btnTitem.Enabled = false;
                btnFinalizar.Enabled = false;
            }
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                assasin.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    assasin.setATK(Convert.ToInt32(lblAtkA.Text) );
                    assasin.setDEF(Convert.ToInt32(lblDefA.Text) );
                    assasin.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    assasin.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                
                assasin.setHAB((lblHabA.Text));
                assasin.setITEM((lblItemA.Text) + ",");
                assasin.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                warrior.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!esforco)
                    {
                        warrior.setATK(Convert.ToInt32(lblAtkA.Text) );
                        warrior.setDEF(Convert.ToInt32(lblDefA.Text) );
                        warrior.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        warrior.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
                warrior.setHAB((lblHabA.Text));
                warrior.setITEM((lblItemA.Text) + ",");
                warrior.setWEAPON((lblWeaponA.Text));
            }


            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                winged.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    winged.setATK(Convert.ToInt32(lblAtkA.Text) );
                    winged.setDEF(Convert.ToInt32(lblDefA.Text) );
                    winged.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    winged.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                winged.setHAB((lblHabA.Text));
                winged.setITEM((lblItemA.Text) + ",");
                winged.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                mage.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    mage.setATK(Convert.ToInt32(lblAtkA.Text) );
                    mage.setDEF(Convert.ToInt32(lblDefA.Text) );
                    mage.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    mage.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                mage.setHAB((lblHabA.Text));
                mage.setITEM((lblItemA.Text) + ",");
                mage.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                horse.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    horse.setATK(Convert.ToInt32(lblAtkA.Text) );
                    horse.setDEF(Convert.ToInt32(lblDefA.Text) );
                    horse.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    horse.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                horse.setHAB((lblHabA.Text));
                horse.setITEM((lblItemA.Text) + ",");
                horse.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                king.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    king.setATK(Convert.ToInt32(lblAtkA.Text) );
                    king.setDEF(Convert.ToInt32(lblDefA.Text) );
                    king.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    king.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                king.setHAB((lblHabA.Text));
                king.setITEM((lblItemA.Text) + ",");
                king.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                barbarian.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!loucura)
                    {
                        barbarian.setATK(Convert.ToInt32(lblAtkA.Text) );
                        barbarian.setDEF(Convert.ToInt32(lblDefA.Text) );
                        barbarian.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        barbarian.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
                barbarian.setHAB((lblHabA.Text));
                barbarian.setITEM((lblItemA.Text) + ",");
                barbarian.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                clerig.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    clerig.setATK(Convert.ToInt32(lblAtkA.Text) );
                    clerig.setDEF(Convert.ToInt32(lblDefA.Text) );
                    clerig.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    clerig.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                clerig.setHAB((lblHabA.Text));
                clerig.setITEM((lblItemA.Text) + ",");
                clerig.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                archer.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!alcance)
                    {
                        archer.setATK(Convert.ToInt32(lblAtkA.Text) );
                        archer.setDEF(Convert.ToInt32(lblDefA.Text) );
                        archer.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        archer.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
               
                archer.setHAB((lblHabA.Text));
                archer.setITEM((lblItemA.Text) + ",");
                archer.setWEAPON((lblWeaponA.Text));
            }








            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                assasinenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    assasinenemy.setATK(Convert.ToInt32(lblAtkA.Text) );
                    assasinenemy.setDEF(Convert.ToInt32(lblDefA.Text) );
                    assasinenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    assasinenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                assasinenemy.setHAB((lblHabA.Text));
                assasinenemy.setITEM((lblItemA.Text) + ",");
                assasinenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                warriorenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!esforco)
                    {
                        warriorenemy.setATK(Convert.ToInt32(lblAtkA.Text) );
                        warriorenemy.setDEF(Convert.ToInt32(lblDefA.Text) );
                        warriorenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        warriorenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
                warriorenemy.setHAB((lblHabA.Text));
                warriorenemy.setITEM((lblItemA.Text) + ",");
                warriorenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                wingedenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    wingedenemy.setATK(Convert.ToInt32(lblAtkA.Text) );
                    wingedenemy.setDEF(Convert.ToInt32(lblDefA.Text) );
                    wingedenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    wingedenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                wingedenemy.setHAB((lblHabA.Text));
                wingedenemy.setITEM((lblItemA.Text) + ",");
                wingedenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                mageenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    mageenemy.setATK(Convert.ToInt32(lblAtkA.Text) );
                    mageenemy.setDEF(Convert.ToInt32(lblDefA.Text) );
                    mageenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    mageenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                mageenemy.setHAB((lblHabA.Text));
                mageenemy.setITEM((lblItemA.Text) + ",");
                mageenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                horseenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    horseenemy.setATK(Convert.ToInt32(lblAtkA.Text) );
                    horseenemy.setDEF(Convert.ToInt32(lblDefA.Text) );
                    horseenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    horseenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                horseenemy.setHAB((lblHabA.Text));
                horseenemy.setITEM((lblItemA.Text) + ",");
                horseenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                kingenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    kingenemy.setATK(Convert.ToInt32(lblAtkA.Text) );
                    kingenemy.setDEF(Convert.ToInt32(lblDefA.Text) );
                    kingenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    kingenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                kingenemy.setHAB((lblHabA.Text));
                kingenemy.setITEM((lblItemA.Text) + ",");
                kingenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                barbarianenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!loucura)
                    {
                        barbarianenemy.setATK(Convert.ToInt32(lblAtkA.Text) );
                        barbarianenemy.setDEF(Convert.ToInt32(lblDefA.Text) );
                        barbarianenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        barbarianenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
                barbarianenemy.setHAB((lblHabA.Text));
                barbarianenemy.setITEM((lblItemA.Text) + ",");
                barbarianenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                clerigenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    clerigenemy.setATK(Convert.ToInt32(lblAtkA.Text) );
                    clerigenemy.setDEF(Convert.ToInt32(lblDefA.Text) );
                    clerigenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    clerigenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                clerigenemy.setHAB((lblHabA.Text));
                clerigenemy.setITEM((lblItemA.Text) + ",");
                clerigenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                archerenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!alcance)
                    {
                        archerenemy.setATK(Convert.ToInt32(lblAtkA.Text) );
                        archerenemy.setDEF(Convert.ToInt32(lblDefA.Text) );
                        archerenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        archerenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
                archerenemy.setHAB((lblHabA.Text));
                archerenemy.setITEM((lblItemA.Text) + ",");
                archerenemy.setWEAPON((lblWeaponA.Text));
            }













            //separation











            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                assasin.setHP(Convert.ToInt32(lblHpD.Text));
                assasin.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                assasin.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                assasin.setDES(Convert.ToInt32(lblDesD.Text) );
                assasin.setVEL(Convert.ToInt32(lblVelD.Text) );
                assasin.setHAB((lblHabD.Text));
                assasin.setITEM((lblItemD.Text) + ",");
                assasin.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                warrior.setHP(Convert.ToInt32(lblHpD.Text));
                warrior.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                warrior.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                warrior.setDES(Convert.ToInt32(lblDesD.Text) );
                warrior.setVEL(Convert.ToInt32(lblVelD.Text) );
                warrior.setHAB((lblHabD.Text));
                warrior.setITEM((lblItemD.Text) + ",");
                warrior.setWEAPON((lblWeaponD.Text));
            }



            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                winged.setHP(Convert.ToInt32(lblHpD.Text));
                winged.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                winged.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                winged.setDES(Convert.ToInt32(lblDesD.Text) );
                winged.setVEL(Convert.ToInt32(lblVelD.Text) );
                winged.setHAB((lblHabD.Text));
                winged.setITEM((lblItemD.Text) + ",");
                winged.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                mage.setHP(Convert.ToInt32(lblHpD.Text));
                mage.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                mage.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                mage.setDES(Convert.ToInt32(lblDesD.Text) );
                mage.setVEL(Convert.ToInt32(lblVelD.Text) );
                mage.setHAB((lblHabD.Text));
                mage.setITEM((lblItemD.Text) + ",");
                mage.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                horse.setHP(Convert.ToInt32(lblHpD.Text));
                horse.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                horse.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                horse.setDES(Convert.ToInt32(lblDesD.Text) );
                horse.setVEL(Convert.ToInt32(lblVelD.Text) );
                horse.setHAB((lblHabD.Text));
                horse.setITEM((lblItemD.Text) + ",");
                horse.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                king.setHP(Convert.ToInt32(lblHpD.Text));
                king.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                king.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                king.setDES(Convert.ToInt32(lblDesD.Text) );
                king.setVEL(Convert.ToInt32(lblVelD.Text) );
                king.setHAB((lblHabD.Text));
                king.setITEM((lblItemD.Text) + ",");
                king.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension
               || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                barbarian.setHP(Convert.ToInt32(lblHpD.Text));
                barbarian.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                barbarian.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                barbarian.setDES(Convert.ToInt32(lblDesD.Text) );
                barbarian.setVEL(Convert.ToInt32(lblVelD.Text) );
                barbarian.setHAB((lblHabD.Text));
                barbarian.setITEM((lblItemD.Text) + ",");
                barbarian.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                clerig.setHP(Convert.ToInt32(lblHpD.Text));
                clerig.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                clerig.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                clerig.setDES(Convert.ToInt32(lblDesD.Text) );
                clerig.setVEL(Convert.ToInt32(lblVelD.Text) );
                clerig.setHAB((lblHabD.Text));
                clerig.setITEM((lblItemD.Text) + ",");
                clerig.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension
               || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                archer.setHP(Convert.ToInt32(lblHpD.Text));
                archer.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                archer.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                archer.setDES(Convert.ToInt32(lblDesD.Text) );
                archer.setVEL(Convert.ToInt32(lblVelD.Text) );
                archer.setHAB((lblHabD.Text));
                archer.setITEM((lblItemD.Text) + ",");
                archer.setWEAPON((lblWeaponD.Text));
            }









            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                assasinenemy.setHP(Convert.ToInt32(lblHpD.Text));
                assasinenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                assasinenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                assasinenemy.setDES(Convert.ToInt32(lblDesD.Text) );
                assasinenemy.setVEL(Convert.ToInt32(lblVelD.Text) );
                assasinenemy.setHAB((lblHabD.Text));
                assasinenemy.setITEM((lblItemD.Text) + ",");
                assasinenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                warriorenemy.setHP(Convert.ToInt32(lblHpD.Text));
                warriorenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                warriorenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                warriorenemy.setDES(Convert.ToInt32(lblDesD.Text) );
                warriorenemy.setVEL(Convert.ToInt32(lblVelD.Text) );
                warriorenemy.setHAB((lblHabD.Text));
                warriorenemy.setITEM((lblItemD.Text) + ",");
                warriorenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                wingedenemy.setHP(Convert.ToInt32(lblHpD.Text));
                wingedenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                wingedenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                wingedenemy.setDES(Convert.ToInt32(lblDesD.Text) );
                wingedenemy.setVEL(Convert.ToInt32(lblVelD.Text) );
                wingedenemy.setHAB((lblHabD.Text));
                wingedenemy.setITEM((lblItemD.Text) + ",");
                wingedenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                mageenemy.setHP(Convert.ToInt32(lblHpD.Text));
                mageenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                mageenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                mageenemy.setDES(Convert.ToInt32(lblDesD.Text) );
                mageenemy.setVEL(Convert.ToInt32(lblVelD.Text) );
                mageenemy.setHAB((lblHabD.Text));
                mageenemy.setITEM((lblItemD.Text) + ",");
                mageenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                horseenemy.setHP(Convert.ToInt32(lblHpD.Text));
                horseenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                horseenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                horseenemy.setDES(Convert.ToInt32(lblDesD.Text) );
                horseenemy.setVEL(Convert.ToInt32(lblVelD.Text) );
                horseenemy.setHAB((lblHabD.Text));
                horseenemy.setITEM((lblItemD.Text) + ",");
                horseenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                kingenemy.setHP(Convert.ToInt32(lblHpD.Text));
                kingenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                kingenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                kingenemy.setDES(Convert.ToInt32(lblDesD.Text) );
                kingenemy.setVEL(Convert.ToInt32(lblVelD.Text) );
                kingenemy.setHAB((lblHabD.Text));
                kingenemy.setITEM((lblItemD.Text) + ",");
                kingenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                barbarianenemy.setHP(Convert.ToInt32(lblHpD.Text));
                barbarianenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                barbarianenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                barbarianenemy.setDES(Convert.ToInt32(lblDesD.Text) );
                barbarianenemy.setVEL(Convert.ToInt32(lblVelD.Text) );
                barbarianenemy.setHAB((lblHabD.Text));
                barbarianenemy.setITEM((lblItemD.Text) + ",");
                barbarianenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                clerigenemy.setHP(Convert.ToInt32(lblHpD.Text));
                clerigenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                clerigenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                clerigenemy.setDES(Convert.ToInt32(lblDesD.Text) );
                clerigenemy.setVEL(Convert.ToInt32(lblVelD.Text) );
                clerigenemy.setHAB((lblHabD.Text));
                clerigenemy.setITEM((lblItemD.Text) + ",");
                clerigenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                archerenemy.setHP(Convert.ToInt32(lblHpD.Text));
                archerenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                archerenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                archerenemy.setDES(Convert.ToInt32(lblDesD.Text) );
                archerenemy.setVEL(Convert.ToInt32(lblVelD.Text) );
                archerenemy.setHAB((lblHabD.Text));
                archerenemy.setITEM((lblItemD.Text) + ",");
                archerenemy.setWEAPON((lblWeaponD.Text));
            }








            //viva la separation














            if (btnAtaque.Text == "Atacar")
            {
                string menarma = "";
                int efeitoarma = 0;
                if(arma == "BRAVURA")
                {
                    efeitoarma = 5;
                    menarma = "(Mais 5 de dano grças a sua arma: " + arma + ")";
                }
                if (arma == "REAL")
                {
                    efeitoarma = 10;
                    menarma = "(Mais 10 de dano grças a sua arma: " + arma + ")";
                }
                if (arma == "ELITE")
                {
                    efeitoarma = 5;
                    menarma = "(Mais 5 de dano grças a sua arma: " + arma + ")";
                }
                if (arma == "PESADO")
                {
                    efeitoarma = 1;
                    if(Convert.ToInt32(lblAtkA.Text) > Convert.ToInt32(lblDefD.Text))
                        menarma = "(Mais 5 de dano pois sua arma: " + arma + ", quebrou a armadura do oponente)";

                }
                if (arma == "GIGANTE")
                {
                    efeitoarma = 2;
                    if (Convert.ToInt32(lblAtkA.Text) > Convert.ToInt32(lblDefD.Text))
                        menarma = "(Mais 10 de dano pois sua arma: " + arma + ", estraçalhou a armadura do oponente)";

                }
                

                int atk = Convert.ToInt32(lblAtkA.Text);
                int def = Convert.ToInt32(lblDefD.Text);
                Random d20 = new Random();
                atk = atk + d20.Next(1, 21);
                def = def - d20.Next(1, 11);
                if (arma == "PERIGOSO" || arma == "PERIGOSA")
                {
                    efeitoarma = 3;
                   
                }
                if (arma == "LETAL")
                {
                    efeitoarma = 4;

                }
                if (arma == "NATUREZA(FRACA)")
                {
                    efeitoarma = 6;
                    if (d20.Next(1, 21) >= 6)
                        menarma = "(Mais 10 de dano pois sua arma: " + arma + ", acertou o oponente em sua fraqueza elemental)";

                }
                if (arma == "NATUREZA(FORTE)")
                {
                    efeitoarma = 6;
                    if (d20.Next(1, 21) >= 12)
                        menarma = "(Mais 15 de dano pois sua arma: " + arma + ", acertou em cheio o oponente em sua fraqueza elemental)";

                }
                bool crit = true;
                if (d20.Next(1, 21) <= (Convert.ToInt32(lblDesA.Text) / 8))
                {
                    crit = true;
                }
                else
                {
                    if(efeitoarma == 3 && d20.Next(1, 21) >= 10)
                    {
                        if (d20.Next(1, 21) <= (Convert.ToInt32(lblDesA.Text) / 8))
                        {
                            crit = true;
                            menarma = "Você acertou um crítico graças a sua arma: "+arma;
                        }
                    }
                    else if (efeitoarma == 4 && d20.Next(1, 21) >= 1)
                    {
                        if (d20.Next(1, 21) <= (Convert.ToInt32(lblDesA.Text) / 8))
                        {
                            crit = true;
                            menarma = "Você acertou um crítico graças a sua arma: " + arma;
                        }
                    }
                    else
                    {
                        crit = false;
                    }
                   
                }
                
                bool esq;
                if (d20.Next(1, 21) <= (Convert.ToInt32(lblVelD.Text) / 8))
                {
                    esq = true;
                }
                else
                {
                    esq = false;
                }

                int dano;

                if (crit && alcance)
                    dano = (atk - def) * 4;
                else if (crit && !alcance)
                    dano = (atk - def) * 2;
                else
                    dano = atk - def;
                if (esq)
                    dano = 0;
                if (dano < 0)
                {
                    dano = 0;
                }
                int hp = Convert.ToInt32(lblHpD.Text);
                hp = hp - dano;
                if(efeitoarma == 5 || efeitoarma  == 10)
                {
                    hp = hp - efeitoarma;
                }
                if (efeitoarma == 1 && menarma == "(Mais 5 de dano pois sua arma: " + arma + ", quebrou a armadura do oponente)")
                    hp = hp - 5;
                if (efeitoarma == 2 && menarma == "(Mais 10 de dano pois sua arma: " + arma + ", estraçalhou a armadura do oponente)")
                    hp = hp - 10;
                if (efeitoarma == 6 && menarma == "(Mais 10 de dano pois sua arma: " + arma + ", acertou o oponente em sua fraqueza elemental)")
                    hp = hp - 10;
                if (efeitoarma == 7 && menarma == "(Mais 15 de dano pois sua arma: " + arma + ", acertou em cheio o oponente em sua fraqueza elemental)")
                    hp = hp - 15;
                if (hp < 0)
                    hp = 0;
                lblHpD.Text = hp + "";

                if (crit && alcance)
                    lblBattle.Text = "Você causou " + dano + " de dano, graças a um golpe headshoot."+menarma;
                else  if (crit && !alcance)
                    lblBattle.Text = "Você causou " + dano + " de dano, graças a um golpe crítico."+menarma;
                else
                    lblBattle.Text = "Você causou " + dano + " de dano."+menarma;
                if (esq)
                    lblBattle.Text = "O oponente se esquivou." + menarma;

                btnAtaque.Text = "Defender";

            }


            else if (btnAtaque.Text == "Defender" /*&& lblHpD.Text != "0"*/) 
            {
                if(lblHpD.Text != "0")
                {
                    int atk = Convert.ToInt32(lblAtkD.Text);
                    int def = Convert.ToInt32(lblDefA.Text);
                    Random d20 = new Random();
                    atk = atk + d20.Next(1, 21);
                    def = def - d20.Next(1, 11);

                    bool crit;
                    if (d20.Next(1, 21) <= (Convert.ToInt32(lblDesD.Text) / 8))
                    {
                        crit = true;
                    }
                    else
                    {
                        crit = false;
                    }
                    
                    bool esq;
                    if (d20.Next(1, 21) <= (Convert.ToInt32(lblVelA.Text) / 8))
                    {
                        esq = true;
                    }
                    else
                    {
                        esq = false;
                    }

                    int dano;

                   
                    if (crit && defensor)
                        dano = (atk - def) ;
                    else if (crit && !defensor)
                        dano = (atk - def) * 2;
                    else
                        dano = atk - def;
                    if (esq)
                        dano = 0;
                    if (dano < 0)
                    {
                        dano = 0;
                    }
                    int hp = Convert.ToInt32(lblHpA.Text);
                    hp = hp - dano;
                    if (hp < 0)
                        hp = 0;
                    lblHpA.Text = hp + "";

                    if (crit)
                        lblBattle.Text = "Você recebeu " + dano + " de dano, graças a um golpe crítico.";
                    else
                        lblBattle.Text = "Você Recebeu " + dano + " de dano.";
                    if (esq)
                        lblBattle.Text = "Você se esquivou.";
                    if (esq && reforçonoataque)
                    {
                        lblBattle.Text = "Você se esquivou e contra-atacou causando 10 de dano.";
                        lblHpD.Text = (Convert.ToInt32(lblHpD.Text) - 10) + "";
                    }

                    btnAtaque.Text = "Finalizar";
                }
                else
                {
                    lblBattle.Text = "Seu oponente não pode atacar.";
                    btnAtaque.Text = "Finalizar";
                }

            }
            else if (btnAtaque.Text == "Finalizar")
            {
                if(lblHpA.Text == "0" && martir)
                {
                    king.setHP(king.getMHP());
                    warrior.setHP(warrior.getMHP());
                    archer.setHP(archer.getMHP());
                    winged.setHP(winged.getMHP());
                    barbarian.setHP(barbarian.getMHP());
                    horse.setHP(horse.getMHP());
                    assasin.setHP(assasin.getMHP());
                    mage.setHP(mage.getMHP());
                }
                if (lblHpA.Text == "0" && martire)
                {
                    kingenemy.setHP(king.getMHP());
                    warriorenemy.setHP(warrior.getMHP());
                    archerenemy.setHP(archer.getMHP());
                    wingedenemy.setHP(winged.getMHP());
                    barbarianenemy.setHP(barbarian.getMHP());
                    horseenemy.setHP(horse.getMHP());
                    assasinenemy.setHP(assasin.getMHP());
                    mageenemy.setHP(mage.getMHP());
                }
                sett.setPersonagem(null);
                sett.setPersonagem1(null);
                sett.setClick(1);
                this.Close();
            }









               


        }

        private void btnHabidade_Click(object sender, EventArgs e)
        {
            Random d20 = new Random();
            String habilidade = lblHabA.Text;
            
            if(lblHpA.Text != "0")
            {
                if (habilidade == "CHAMADO REAL")
                {
                    if (d20.Next(1, 21) >= 19)
                    {
                        lblBattle.Text = "O oponente aceitou o chamado real e vai se retirar para servi-lo como vassalo.";
                        lblHabA.Text = "-";
                        lblHpD.Text = "0";
                    }
                    else
                    {
                        lblBattle.Text = "O oponente não aceitou o chamado real.";
                        lblHabA.Text = "-";
                    }
                    
                }
                if (habilidade == "CHAMADO REAL+")
                {
                    if (d20.Next(1, 21) >= 10)
                    {
                        lblBattle.Text = "O oponente aceitou o chamado real e vai se retirar para servi-lo como vassalo.";
                        lblHabA.Text = "-";
                        lblHpD.Text = "0";
                    }
                    else
                    {
                        lblBattle.Text = "O oponente não aceitou o chamado real.";
                        lblHabA.Text = "-";
                    }

                }
                if (habilidade == "ALCANCE")
                {
                    if (d20.Next(1, 21) >= 15)
                    {
                        lblBattle.Text = "O seu arco está mais preciso e perigoso.";
                        lblDesA.Text = (Convert.ToInt32(lblDesA.Text)+10)+"";
                        lblAtkA.Text = (Convert.ToInt32(lblAtkA.Text)*2) + "";
                        alcance = true;
                    }
                    else
                    {
                        lblBattle.Text = "Você falhou em se concentrar para atirar.";
                        alcance = false;
                    }
                }
                if (habilidade == "ALCANCE+")
                {
                    if (d20.Next(1, 21) >= 10)
                    {
                        lblBattle.Text = "O seu arco está mais preciso e perigoso.";
                        lblDesA.Text = (Convert.ToInt32(lblDesA.Text) + 10) + "";
                        lblAtkA.Text = (Convert.ToInt32(lblAtkA.Text) * 2) + "";
                        alcance = true;
                    }
                    else
                    {
                        lblBattle.Text = "Você falhou em se concentrar para atirar.";
                        alcance = false;
                    }
                }
                if (habilidade == "ESFORÇO DO GUERREIRO")
                {
                    if (d20.Next(1, 21) >= 10)
                    {
                        lblBattle.Text = "Você se esforçou e superou seus limites.";
                        lblDesA.Text = (Convert.ToInt32(lblDesA.Text) + 5) + "";
                        lblAtkA.Text = (Convert.ToInt32(lblAtkA.Text) + 5) + "";
                        lblDefA.Text = (Convert.ToInt32(lblDefA.Text) + 5) + "";
                        lblVelA.Text = (Convert.ToInt32(lblVelA.Text) + 5) + "";
                        esforco = true;
                    }
                    else
                    {
                        lblBattle.Text = "Você falhou em se esforçar e superar os seus limites.";
                        esforco = false;
                    }
                }
                if (habilidade == "ESFORÇO DO GUERREIRO+")
                {
                    if (d20.Next(1, 21) >= 10)
                    {
                        lblBattle.Text = "Você se esforçou e superou seus limites.";
                        lblDesA.Text = (Convert.ToInt32(lblDesA.Text) + 10) + "";
                        lblAtkA.Text = (Convert.ToInt32(lblAtkA.Text) + 10) + "";
                        lblDefA.Text = (Convert.ToInt32(lblDefA.Text) + 10) + "";
                        lblVelA.Text = (Convert.ToInt32(lblVelA.Text) + 10) + "";
                        esforco = true;
                    }
                    else
                    {
                        lblBattle.Text = "Você falhou em se esforçar e superar os seus limites.";
                        esforco = false;
                    }
                }
                if (habilidade == "INABILIDAR")
                {
                    if (d20.Next(1, 21) >= 10)
                    {
                        lblBattle.Text = "Você retirou a habilidade do seu oponente.";
                        lblHabD.Text = "-";
                       
                    }
                    else
                    {
                        lblBattle.Text = "Você falhou em usar magia para retirar a habilidade do seu oponente.";
                       
                    }
                }
                if (habilidade == "INABILIDAR+")
                {
                    if (d20.Next(1, 21) >= 1)
                    {
                        lblBattle.Text = "Você retirou a habilidade do seu oponente.";
                        lblHabD.Text = "-";
                        if (d20.Next(1, 21) >= 10)
                        {
                            lblDesD.Text = (Convert.ToInt32(lblDesD.Text) - 5) + "";
                            lblAtkD.Text = (Convert.ToInt32(lblAtkD.Text) - 5) + "";
                            lblDefD.Text = (Convert.ToInt32(lblDefD.Text) - 5) + "";
                            lblVelD.Text = (Convert.ToInt32(lblVelD.Text) - 5) + "";
                            lblBattle.Text = "Você retirou a habilidade do seu oponente e o amaldiçou.";
                        }

                    }
                    else
                    {
                        lblBattle.Text = "Você falhou em usar magia para retirar a habilidade do seu oponente.";

                    }
                }
                if (habilidade == "DEFENSOR")
                {
                    if (d20.Next(1, 21) >= 10)
                    {
                        defensor = true;
                        lblBattle.Text = "Você levantou alto seu escudo, agora os críticos causan 1/2 dano.";
                        

                    }
                    else
                    {
                        defensor = false;
                        lblBattle.Text = "Você falhou em preparar sua guarda.";

                    }
                }
                if (habilidade == "DEFENSOR+")
                {
                    if (d20.Next(1, 21) >= 1)
                    {
                        defensor = true;
                        lblBattle.Text = "Você levantou alto seu escudo, agora os críticos causan 1/2 dano.";


                    }
                    else
                    {
                        defensor = false;
                        lblBattle.Text = "Você falhou em preparar sua guarda.";

                    }
                }
                if (habilidade == "ROUBAR")
                {
                    if (d20.Next(1, 21) >= 5)
                    {
                       
                        lblBattle.Text = "Você roubou o primeiro item encontrado na bolsa do seu opnente.";
                        if (lblItemD.Text.Contains(","))
                        {
                            lblItemA.Text = lblItemA.Text + lblItemD.Text.Substring(lblItemD.Text.LastIndexOf(','));
                            lblItemD.Text = lblItemD.Text.Remove(lblItemD.Text.LastIndexOf(','), lblItemD.Text.Length - lblItemD.Text.LastIndexOf(','));
                        }
                        else
                        {
                            lblItemA.Text = lblItemA.Text +","+ lblItemD.Text;
                            lblItemD.Text = "";
                        }
                      
                    }
                    else
                    {
                        
                        lblBattle.Text = "Você falhou em roubar algo.";

                    }
                }
                if (habilidade == "ROUBAR+")
                {
                    if (d20.Next(1, 21) >= 1)
                    {

                        lblBattle.Text = "Você roubou o primeiro item encontrado na bolsa do seu opnente.";
                        if (lblItemD.Text.Contains(","))
                        {
                            lblItemA.Text = lblItemA.Text + lblItemD.Text.Substring(lblItemD.Text.LastIndexOf(','));
                            lblItemD.Text = lblItemD.Text.Remove(lblItemD.Text.LastIndexOf(','), lblItemD.Text.Length - lblItemD.Text.LastIndexOf(','));
                        }
                        else
                        {
                            lblItemA.Text = lblItemA.Text + "," + lblItemD.Text;
                            lblItemD.Text = "";
                        }
                        if (d20.Next(1, 21) >= 18)
                        {
                            lblHpD.Text = "0";
                            lblBattle.Text = "Você roubou o primeiro item encontrado na bolsa do seu opnente e o assasinou.";
                        }
                    }
                    else
                    {

                        lblBattle.Text = "Você falhou em roubar algo.";

                    }
                }
                if (habilidade == "REFORÇO NO ATAQUE")
                {
                    if (d20.Next(1, 21) >= 10)
                    {
                        reforçonoataque = true;
                        lblBattle.Text = "Você e sua montaria ficaram em posição e podem atacar se esquivarem.";
                       

                    }
                    else
                    {
                        reforçonoataque = false;
                        lblBattle.Text = "Você falhou em adiantar sua posição.";

                    }
                }
                if (habilidade == "REFORÇO NO ATAQUE+")
                {
                    if (d20.Next(1, 21) >= 5)
                    {
                        reforçonoataque = true;
                        lblBattle.Text = "Você e sua montaria ficaram em posição e podem atacar se esquivarem.";


                    }
                    else
                    {
                        reforçonoataque = false;
                        lblBattle.Text = "Você falhou em adiantar sua posição.";

                    }
                }
                if (habilidade == "MARTIR")
                {
                    if (d20.Next(1, 21) >= 5)
                    {
                        martir = true;
                        lblBattle.Text = "Você realizou um milagre e vai se tornar um martir se morrer( todas as suas tropas não mortas teram HP regenerado).";


                    }
                    else
                    {
                        martir = false;
                        lblBattle.Text = "Você falhou em realizar um milagre.";

                    }
                }
                if (habilidade == "MARTIR+")
                {
                    if (d20.Next(1, 21) >= 1)
                    {
                        martir = true;
                        lblBattle.Text = "Você realizou um milagre e vai se tornar um martir se morrer( todas as suas tropas não mortas teram HP regenerado).";


                    }
                    else
                    {
                        martir = false;
                        lblBattle.Text = "Você falhou em realizar um milagre.";

                    }
                }
                if (habilidade == "MARTIRE")
                {
                    if (d20.Next(1, 21) >= 5)
                    {
                        martire = true;
                        lblBattle.Text = "Você realizou um milagre e vai se tornar um martir se morrer( todas as suas tropas não mortas teram HP regenerado).";


                    }
                    else
                    {
                        martire = false;
                        lblBattle.Text = "Você falhou em realizar um milagre.";

                    }
                }
                if (habilidade == "MARTIRE+")
                {
                    if (d20.Next(1, 21) >= 1)
                    {
                        martire = true;
                        lblBattle.Text = "Você realizou um milagre e vai se tornar um martir se morrer( todas as suas tropas não mortas teram HP regenerado).";


                    }
                    else
                    {
                        martire = false;
                        lblBattle.Text = "Você falhou em realizar um milagre.";

                    }
                }
                if (habilidade == "LOUCURA")
                {
                    if (Convert.ToInt32(lblHpA.Text) <= 18)
                    {
                        loucura = true;
                        lblBattle.Text = "Você enlouqueceu por conta da dor.";
                        lblDesA.Text = (Convert.ToInt32(lblDesA.Text) + 15) + "";
                        lblAtkA.Text = (Convert.ToInt32(lblAtkA.Text) + 15) + "";
                        lblDefA.Text = (Convert.ToInt32(lblDefA.Text) - 5) + "";
                        lblVelA.Text = (Convert.ToInt32(lblVelA.Text) - 5) + "";


                    }
                    else
                    {
                        loucura = false;
                        lblBattle.Text = "Você falhou em enlouquecer.";

                    }
                }
                if (habilidade == "LOUCURA+")
                {
                    if (Convert.ToInt32(lblHpA.Text) <= 25)
                    {
                        loucura = true;
                        lblBattle.Text = "Você enlouqueceu por conta da dor.";
                        lblDesA.Text = (Convert.ToInt32(lblDesA.Text) + 15) + "";
                        lblAtkA.Text = (Convert.ToInt32(lblAtkA.Text) + 15) + "";
                        lblDefA.Text = (Convert.ToInt32(lblDefA.Text) - 5) + "";
                        lblVelA.Text = (Convert.ToInt32(lblVelA.Text) - 5) + "";


                    }
                    else
                    {
                        loucura = false;
                        lblBattle.Text = "Você falhou em enlouquecer.";

                    }
                }
            }
            else
            {
                lblBattle.Text = "Você não pode usar sua habilidade";
            }
            btnHabidade.Enabled = false;

        }

        private void btnUitem_Click(object sender, EventArgs e)
        {
            if(lblHpA.Text != "0")
            {
                sett.setItemList(lblItemA.Text + ",");
                sett.setHpItem(lblHpA.Text);
                sett.setAtkItem(lblAtkA.Text);
                sett.setDefItem(lblDefA.Text);
                sett.setDesItem(lblDesA.Text);
                sett.setVelItem(lblVelA.Text);
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(assasin.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(warrior.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(horse.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(mage.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(winged.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(king.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(archer.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(clerig.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(barbarian.getMHP() + "");
                }






                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(assasinenemy.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(warriorenemy.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(horseenemy.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(mageenemy.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(wingedenemy.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(kingenemy.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(archerenemy.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(clerigenemy.getMHP() + "");
                }
                if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImg.PhysicalDimension
                    || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(barbarianenemy.getMHP() + "");
                }
                UsarItem p = new UsarItem();
                p.Show();
                usingitem = true;
            }
           
        }

        private void Batalha_Activated(object sender, EventArgs e)
        {
            if (usingitem)
            {

                if(sett.getItemList().Length > 0)
                {
                    lblItemA.Text = sett.getItemList().Remove(sett.getItemList().Length - 1);
                }
                else
                {
                    lblItemA.Text = "";
                }
                lblHpA.Text = sett.getHpItem();
                lblAtkA.Text = sett.getAtkItem();
                lblDefA.Text = sett.getDefItem();
                lblDesA.Text = sett.getDesItem();
                lblVelA.Text = sett.getVelItem();
                lblBattle.Text = sett.getMensagem();
                usadoitem = true;
            }
            if (usingitem1)
            {
                if (sett.getItemList().Length > 0)
                {
                    lblItemA.Text = sett.getItemList();
                    do
                    {
                        lblItemA.Text = lblItemA.Text.Remove(lblItemA.Text.Length - 1);
                    } while (lblItemA.Text.EndsWith(","));
                    
                    
                }
                else
                {
                    lblItemA.Text = "";
                }
                if (sett.getItemList1().Length > 0)
                {
                    lblItemD.Text = sett.getItemList1();
                    do
                    {
                        lblItemD.Text = lblItemD.Text.Remove(lblItemD.Text.Length - 1);
                    } while (lblItemD.Text.EndsWith(","));
                }
                else
                {
                    lblItemD.Text = "";
                }
            }
            
            usingitem = false;
            usingitem1 = false;
        }

        private void btnTitem_Click(object sender, EventArgs e)
        {
            sett.setItemList(lblItemA.Text + ",");
            sett.setItemList1(lblItemD.Text + ",");
            TrocaItem p = new TrocaItem();
            p.Show();
            usingitem1 = true;
        }

        private void btnCurar_Click(object sender, EventArgs e)
        {
            if (lblWeaponA.Text.EndsWith(".PEQ") && lblHpA.Text != "0")
            {
                lblBattle.Text = "Você curou 15 de vida do seu alvo";
                int heal = 15;
                int hp = Convert.ToInt32(lblHpD.Text);
                heal = heal + hp;

                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension
                     || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(assasin.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(warrior.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(horse.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(mage.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(winged.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(king.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(archer.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(clerig.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(barbarian.getMHP() + "");
                }






                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(assasinenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(warriorenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(horseenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(mageenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(wingedenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(kingenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(archerenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(clerigenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(barbarianenemy.getMHP() + "");
                }

                if (heal > Convert.ToInt32(sett.getMhpItem()))
                {
                    heal = Convert.ToInt32(sett.getMhpItem());
                }
                lblHpD.Text = heal + "";
            }
            else if (lblWeaponA.Text.EndsWith(".GRAN") && lblHpA.Text != "0")
            {
                lblBattle.Text = "Você curou 30 de vida do seu alvo";
                int heal = 30;
                int hp = Convert.ToInt32(lblHpD.Text);
                heal = heal + hp;

                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension
                     || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(assasin.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(warrior.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(horse.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(mage.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(winged.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(king.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(archer.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(clerig.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(barbarian.getMHP() + "");
                }






                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(assasinenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(warriorenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(horseenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(mageenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(wingedenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(kingenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(archerenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(clerigenemy.getMHP() + "");
                }
                if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImg.PhysicalDimension
                    || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImgEvol.PhysicalDimension)
                {
                    sett.setMhpItem(barbarianenemy.getMHP() + "");
                }

                if (heal > Convert.ToInt32(sett.getMhpItem()))
                {
                    heal = Convert.ToInt32(sett.getMhpItem());
                }
                lblHpD.Text = heal + "";
            }
            else
            {
                lblBattle.Text = "Você não pode curar";
            }
            btnCurar.Enabled = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                assasin.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    assasin.setATK(Convert.ToInt32(lblAtkA.Text));
                    assasin.setDEF(Convert.ToInt32(lblDefA.Text));
                    assasin.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    assasin.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }

                assasin.setHAB((lblHabA.Text));
                assasin.setITEM((lblItemA.Text) + ",");
                assasin.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                warrior.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!esforco)
                    {
                        warrior.setATK(Convert.ToInt32(lblAtkA.Text));
                        warrior.setDEF(Convert.ToInt32(lblDefA.Text));
                        warrior.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        warrior.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
                warrior.setHAB((lblHabA.Text));
                warrior.setITEM((lblItemA.Text) + ",");
                warrior.setWEAPON((lblWeaponA.Text));
            }


            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                winged.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    winged.setATK(Convert.ToInt32(lblAtkA.Text));
                    winged.setDEF(Convert.ToInt32(lblDefA.Text));
                    winged.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    winged.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                winged.setHAB((lblHabA.Text));
                winged.setITEM((lblItemA.Text) + ",");
                winged.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                mage.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    mage.setATK(Convert.ToInt32(lblAtkA.Text));
                    mage.setDEF(Convert.ToInt32(lblDefA.Text));
                    mage.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    mage.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                mage.setHAB((lblHabA.Text));
                mage.setITEM((lblItemA.Text) + ",");
                mage.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                horse.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    horse.setATK(Convert.ToInt32(lblAtkA.Text));
                    horse.setDEF(Convert.ToInt32(lblDefA.Text));
                    horse.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    horse.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                horse.setHAB((lblHabA.Text));
                horse.setITEM((lblItemA.Text) + ",");
                horse.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                king.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    king.setATK(Convert.ToInt32(lblAtkA.Text));
                    king.setDEF(Convert.ToInt32(lblDefA.Text));
                    king.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    king.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                king.setHAB((lblHabA.Text));
                king.setITEM((lblItemA.Text) + ",");
                king.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                barbarian.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!loucura)
                    {
                        barbarian.setATK(Convert.ToInt32(lblAtkA.Text));
                        barbarian.setDEF(Convert.ToInt32(lblDefA.Text));
                        barbarian.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        barbarian.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
                barbarian.setHAB((lblHabA.Text));
                barbarian.setITEM((lblItemA.Text) + ",");
                barbarian.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                clerig.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    clerig.setATK(Convert.ToInt32(lblAtkA.Text));
                    clerig.setDEF(Convert.ToInt32(lblDefA.Text));
                    clerig.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    clerig.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                clerig.setHAB((lblHabA.Text));
                clerig.setITEM((lblItemA.Text) + ",");
                clerig.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                archer.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!alcance)
                    {
                        archer.setATK(Convert.ToInt32(lblAtkA.Text));
                        archer.setDEF(Convert.ToInt32(lblDefA.Text));
                        archer.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        archer.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }

                archer.setHAB((lblHabA.Text));
                archer.setITEM((lblItemA.Text) + ",");
                archer.setWEAPON((lblWeaponA.Text));
            }








            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                assasinenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    assasinenemy.setATK(Convert.ToInt32(lblAtkA.Text));
                    assasinenemy.setDEF(Convert.ToInt32(lblDefA.Text));
                    assasinenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    assasinenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                assasinenemy.setHAB((lblHabA.Text));
                assasinenemy.setITEM((lblItemA.Text) + ",");
                assasinenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                warriorenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!esforco)
                    {
                        warriorenemy.setATK(Convert.ToInt32(lblAtkA.Text));
                        warriorenemy.setDEF(Convert.ToInt32(lblDefA.Text));
                        warriorenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        warriorenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
                warriorenemy.setHAB((lblHabA.Text));
                warriorenemy.setITEM((lblItemA.Text) + ",");
                warriorenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                wingedenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    wingedenemy.setATK(Convert.ToInt32(lblAtkA.Text));
                    wingedenemy.setDEF(Convert.ToInt32(lblDefA.Text));
                    wingedenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    wingedenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                wingedenemy.setHAB((lblHabA.Text));
                wingedenemy.setITEM((lblItemA.Text) + ",");
                wingedenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                mageenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    mageenemy.setATK(Convert.ToInt32(lblAtkA.Text));
                    mageenemy.setDEF(Convert.ToInt32(lblDefA.Text));
                    mageenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    mageenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                mageenemy.setHAB((lblHabA.Text));
                mageenemy.setITEM((lblItemA.Text) + ",");
                mageenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                horseenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    horseenemy.setATK(Convert.ToInt32(lblAtkA.Text));
                    horseenemy.setDEF(Convert.ToInt32(lblDefA.Text));
                    horseenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    horseenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                horseenemy.setHAB((lblHabA.Text));
                horseenemy.setITEM((lblItemA.Text) + ",");
                horseenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                kingenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    kingenemy.setATK(Convert.ToInt32(lblAtkA.Text));
                    kingenemy.setDEF(Convert.ToInt32(lblDefA.Text));
                    kingenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    kingenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                kingenemy.setHAB((lblHabA.Text));
                kingenemy.setITEM((lblItemA.Text) + ",");
                kingenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImg.PhysicalDimension
               || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                barbarianenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!loucura)
                    {
                        barbarianenemy.setATK(Convert.ToInt32(lblAtkA.Text));
                        barbarianenemy.setDEF(Convert.ToInt32(lblDefA.Text));
                        barbarianenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        barbarianenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
                barbarianenemy.setHAB((lblHabA.Text));
                barbarianenemy.setITEM((lblItemA.Text) + ",");
                barbarianenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                clerigenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    clerigenemy.setATK(Convert.ToInt32(lblAtkA.Text));
                    clerigenemy.setDEF(Convert.ToInt32(lblDefA.Text));
                    clerigenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                    clerigenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                }
                clerigenemy.setHAB((lblHabA.Text));
                clerigenemy.setITEM((lblItemA.Text) + ",");
                clerigenemy.setWEAPON((lblWeaponA.Text));
            }
            if (pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImg.PhysicalDimension
                || pbxAtacante.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImgEvol.PhysicalDimension)
            {
                //pbxAtacante.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                archerenemy.setHP(Convert.ToInt32(lblHpA.Text));
                if (!usadoitem)
                {
                    if (!alcance)
                    {
                        archerenemy.setATK(Convert.ToInt32(lblAtkA.Text));
                        archerenemy.setDEF(Convert.ToInt32(lblDefA.Text));
                        archerenemy.setDES(Convert.ToInt32(lblDesA.Text) - bufdearea1);
                        archerenemy.setVEL(Convert.ToInt32(lblVelA.Text) - bufdearea1);
                    }
                }
                archerenemy.setHAB((lblHabA.Text));
                archerenemy.setITEM((lblItemA.Text) + ",");
                archerenemy.setWEAPON((lblWeaponA.Text));
            }













            //separation











            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                assasin.setHP(Convert.ToInt32(lblHpD.Text));
                assasin.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                assasin.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                assasin.setDES(Convert.ToInt32(lblDesD.Text));
                assasin.setVEL(Convert.ToInt32(lblVelD.Text));
                assasin.setHAB((lblHabD.Text));
                assasin.setITEM((lblItemD.Text) + ",");
                assasin.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                warrior.setHP(Convert.ToInt32(lblHpD.Text));
                warrior.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                warrior.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                warrior.setDES(Convert.ToInt32(lblDesD.Text));
                warrior.setVEL(Convert.ToInt32(lblVelD.Text));
                warrior.setHAB((lblHabD.Text));
                warrior.setITEM((lblItemD.Text) + ",");
                warrior.setWEAPON((lblWeaponD.Text));
            }



            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                winged.setHP(Convert.ToInt32(lblHpD.Text));
                winged.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                winged.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                winged.setDES(Convert.ToInt32(lblDesD.Text));
                winged.setVEL(Convert.ToInt32(lblVelD.Text));
                winged.setHAB((lblHabD.Text));
                winged.setITEM((lblItemD.Text) + ",");
                winged.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                mage.setHP(Convert.ToInt32(lblHpD.Text));
                mage.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                mage.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                mage.setDES(Convert.ToInt32(lblDesD.Text));
                mage.setVEL(Convert.ToInt32(lblVelD.Text));
                mage.setHAB((lblHabD.Text));
                mage.setITEM((lblItemD.Text) + ",");
                mage.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                horse.setHP(Convert.ToInt32(lblHpD.Text));
                horse.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                horse.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                horse.setDES(Convert.ToInt32(lblDesD.Text));
                horse.setVEL(Convert.ToInt32(lblVelD.Text));
                horse.setHAB((lblHabD.Text));
                horse.setITEM((lblItemD.Text) + ",");
                horse.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.KingImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                king.setHP(Convert.ToInt32(lblHpD.Text));
                king.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                king.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                king.setDES(Convert.ToInt32(lblDesD.Text));
                king.setVEL(Convert.ToInt32(lblVelD.Text));
                king.setHAB((lblHabD.Text));
                king.setITEM((lblItemD.Text) + ",");
                king.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImg.PhysicalDimension
               || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                barbarian.setHP(Convert.ToInt32(lblHpD.Text));
                barbarian.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                barbarian.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                barbarian.setDES(Convert.ToInt32(lblDesD.Text));
                barbarian.setVEL(Convert.ToInt32(lblVelD.Text));
                barbarian.setHAB((lblHabD.Text));
                barbarian.setITEM((lblItemD.Text) + ",");
                barbarian.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                clerig.setHP(Convert.ToInt32(lblHpD.Text));
                clerig.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                clerig.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                clerig.setDES(Convert.ToInt32(lblDesD.Text));
                clerig.setVEL(Convert.ToInt32(lblVelD.Text));
                clerig.setHAB((lblHabD.Text));
                clerig.setITEM((lblItemD.Text) + ",");
                clerig.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImg.PhysicalDimension
               || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                archer.setHP(Convert.ToInt32(lblHpD.Text));
                archer.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                archer.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                archer.setDES(Convert.ToInt32(lblDesD.Text));
                archer.setVEL(Convert.ToInt32(lblVelD.Text));
                archer.setHAB((lblHabD.Text));
                archer.setITEM((lblItemD.Text) + ",");
                archer.setWEAPON((lblWeaponD.Text));
            }









            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.assasinenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                assasinenemy.setHP(Convert.ToInt32(lblHpD.Text));
                assasinenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                assasinenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                assasinenemy.setDES(Convert.ToInt32(lblDesD.Text));
                assasinenemy.setVEL(Convert.ToInt32(lblVelD.Text));
                assasinenemy.setHAB((lblHabD.Text));
                assasinenemy.setITEM((lblItemD.Text) + ",");
                assasinenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.warriorenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                warriorenemy.setHP(Convert.ToInt32(lblHpD.Text));
                warriorenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                warriorenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                warriorenemy.setDES(Convert.ToInt32(lblDesD.Text));
                warriorenemy.setVEL(Convert.ToInt32(lblVelD.Text));
                warriorenemy.setHAB((lblHabD.Text));
                warriorenemy.setITEM((lblItemD.Text) + ",");
                warriorenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.wingedenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                wingedenemy.setHP(Convert.ToInt32(lblHpD.Text));
                wingedenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                wingedenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                wingedenemy.setDES(Convert.ToInt32(lblDesD.Text));
                wingedenemy.setVEL(Convert.ToInt32(lblVelD.Text));
                wingedenemy.setHAB((lblHabD.Text));
                wingedenemy.setITEM((lblItemD.Text) + ",");
                wingedenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.mageenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                mageenemy.setHP(Convert.ToInt32(lblHpD.Text));
                mageenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                mageenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                mageenemy.setDES(Convert.ToInt32(lblDesD.Text));
                mageenemy.setVEL(Convert.ToInt32(lblVelD.Text));
                mageenemy.setHAB((lblHabD.Text));
                mageenemy.setITEM((lblItemD.Text) + ",");
                mageenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.horseenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                horseenemy.setHP(Convert.ToInt32(lblHpD.Text));
                horseenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                horseenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                horseenemy.setDES(Convert.ToInt32(lblDesD.Text));
                horseenemy.setVEL(Convert.ToInt32(lblVelD.Text));
                horseenemy.setHAB((lblHabD.Text));
                horseenemy.setITEM((lblItemD.Text) + ",");
                horseenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.kingenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                kingenemy.setHP(Convert.ToInt32(lblHpD.Text));
                kingenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                kingenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                kingenemy.setDES(Convert.ToInt32(lblDesD.Text));
                kingenemy.setVEL(Convert.ToInt32(lblVelD.Text));
                kingenemy.setHAB((lblHabD.Text));
                kingenemy.setITEM((lblItemD.Text) + ",");
                kingenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.barbarianenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                barbarianenemy.setHP(Convert.ToInt32(lblHpD.Text));
                barbarianenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                barbarianenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                barbarianenemy.setDES(Convert.ToInt32(lblDesD.Text));
                barbarianenemy.setVEL(Convert.ToInt32(lblVelD.Text));
                barbarianenemy.setHAB((lblHabD.Text));
                barbarianenemy.setITEM((lblItemD.Text) + ",");
                barbarianenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.clerigenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                clerigenemy.setHP(Convert.ToInt32(lblHpD.Text));
                clerigenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                clerigenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                clerigenemy.setDES(Convert.ToInt32(lblDesD.Text));
                clerigenemy.setVEL(Convert.ToInt32(lblVelD.Text));
                clerigenemy.setHAB((lblHabD.Text));
                clerigenemy.setITEM((lblItemD.Text) + ",");
                clerigenemy.setWEAPON((lblWeaponD.Text));
            }
            if (pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImg.PhysicalDimension
                || pbxDefensor.BackgroundImage.PhysicalDimension == Properties.Resources.archerenemyImgEvol.PhysicalDimension)
            {
                //pbxDefensor.BackgroundImage = Properties.Resources.barbarianenemyImg;
                //this.Text = "Rebelde";
                archerenemy.setHP(Convert.ToInt32(lblHpD.Text));
                archerenemy.setATK(Convert.ToInt32(lblAtkD.Text) - bufdearea);
                archerenemy.setDEF(Convert.ToInt32(lblDefD.Text) - bufdearea);
                archerenemy.setDES(Convert.ToInt32(lblDesD.Text));
                archerenemy.setVEL(Convert.ToInt32(lblVelD.Text));
                archerenemy.setHAB((lblHabD.Text));
                archerenemy.setITEM((lblItemD.Text) + ",");
                archerenemy.setWEAPON((lblWeaponD.Text));
            }
            sett.setPersonagem(null);
            sett.setPersonagem1(null);
            sett.setClick(1);
           
            this.Close();
        }
    }
}
