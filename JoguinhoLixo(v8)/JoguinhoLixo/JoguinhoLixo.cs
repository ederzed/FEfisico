using System;
//using System.collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoguinhoLixo
{
    public partial class JoguinhoLixo : Form
    {
        public JoguinhoLixo()
        {
            InitializeComponent();

        }

        Sett sett = new Sett();
        King king = new King();
        Warrior warrior = new Warrior();
        Archer archer = new Archer();
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
        Personagem p = new Personagem();
        bool vitoriaazul = true;
        bool vitoriavermelha = true;
        private void JoguinhoLixo_Load(object sender, EventArgs e)
        {
            sett.setNome(this.Controls);
            Random random = new Random();
            int passos = random.Next(1, 7);

            sett.setPassos(passos);
            MessageBox.Show(sett.menssagemParaUmDiaMelhor(passos));
            sett.setLbl(passos);
            //lblPassosDoDado.Text = "As Tropas podem se mexer " + sett.getLbl()+ " passos.";
            // MessageBox.Show(sett.After("xxxxCodiFunfaFi","x"));
            king.setHP(30);
            king.setMHP(30);
            king.setATK(30);
            king.setDEF(30);
            king.setDES(30);
            king.setVEL(30);
            king.setWEAPON("ESP.BRAVURA");
            king.setITEM("carta real,pot max,");
            king.setHAB("CHAMADO REAL");
            king.setEVOL(false);

            warrior.setHP(30);
            warrior.setMHP(30);
            warrior.setATK(25);
            warrior.setDEF(25);
            warrior.setDES(30);
            warrior.setVEL(20);
            warrior.setWEAPON("ESP.COMUN");
            warrior.setITEM("pot med,");
            warrior.setHAB("ESFORÇO DO GUERREIRO");
            warrior.setEVOL(false);

            archer.setHP(25);
            archer.setMHP(25);
            archer.setATK(15);
            archer.setDEF(15);
            archer.setDES(50);
            archer.setVEL(30);
            archer.setWEAPON("ARC.PERIGOSO");
            archer.setITEM("pot med,am destreza,am destreza,am destreza,");
            archer.setHAB("ALCANCE");
            archer.setEVOL(false);

            clerig.setHP(60);
            clerig.setMHP(60);
            clerig.setATK(1);
            clerig.setDEF(10);
            clerig.setDES(20);
            clerig.setVEL(15);
            clerig.setWEAPON("MAÇA.CURA.PEQ");
            clerig.setITEM("pot max,");
            clerig.setHAB("MARTIR");
            clerig.setEVOL(false);

            mage.setHP(30);
            mage.setMHP(30);
            mage.setATK(25);
            mage.setDEF(25);
            mage.setDES(30);
            mage.setVEL(20);
            mage.setWEAPON("FORÇA.DA.NATUREZA(FRACA)");
            mage.setITEM("pot peq,am poderoso,am poderoso,");
            mage.setHAB("INABILIDAR");
            mage.setEVOL(false);

            winged.setHP(20);
            winged.setMHP(20);
            winged.setATK(25);
            winged.setDEF(25);
            winged.setDES(30);
            winged.setVEL(40);
            winged.setWEAPON("LANÇA.COMUM");
            winged.setITEM("pot peq,am velocidade,am velocidade,am velocidade,");
            winged.setHAB("REFORÇO NO ATAQUE");
            winged.setEVOL(false);

            barbarian.setHP(35);
            barbarian.setMHP(35);
            barbarian.setATK(40);
            barbarian.setDEF(20);
            barbarian.setDES(15);
            barbarian.setVEL(25);
            barbarian.setWEAPON("MACHADO.PESADO");
            barbarian.setITEM("am força,am força,am força,");
            barbarian.setHAB("LOUCURA");
            barbarian.setEVOL(false);

            assasin.setHP(20);
            assasin.setMHP(20);
            assasin.setATK(30);
            assasin.setDEF(10);
            assasin.setDES(40);
            assasin.setVEL(40);
            assasin.setWEAPON("ADAGA.PERIGOSA");
            assasin.setITEM("pot med,");
            assasin.setHAB("ROUBAR");
            assasin.setEVOL(false);

            horse.setHP(40);
            horse.setMHP(40);
            horse.setATK(25);
            horse.setDEF(35);
            horse.setDES(20);
            horse.setVEL(30);
            horse.setWEAPON("ESP.COMUN");
            horse.setITEM("pot med,am defesa,am defesa,am defesa,");
            horse.setHAB("DEFENSOR");
            horse.setEVOL(false);



            //separação






            kingenemy.setHP(30);
            kingenemy.setMHP(30);
            kingenemy.setATK(30);
            kingenemy.setDEF(30);
            kingenemy.setDES(30);
            kingenemy.setVEL(30);
            kingenemy.setWEAPON("ESP.BRAVURA");
            kingenemy.setITEM("carta real,pot max,");
            kingenemy.setHAB("CHAMADO REAL");
            kingenemy.setEVOL(false);

            warriorenemy.setHP(30);
            warriorenemy.setMHP(30);
            warriorenemy.setATK(25);
            warriorenemy.setDEF(25);
            warriorenemy.setDES(30);
            warriorenemy.setVEL(20);
            warriorenemy.setWEAPON("ESP.COMUN");
            warriorenemy.setITEM("pot med,");
            warriorenemy.setHAB("ESFORÇO DO GUERREIRO");
            warriorenemy.setEVOL(false);

            archerenemy.setHP(25);
            archerenemy.setMHP(25);
            archerenemy.setATK(15);
            archerenemy.setDEF(15);
            archerenemy.setDES(50);
            archerenemy.setVEL(30);
            archerenemy.setWEAPON("ARC.PERIGOSO");
            archerenemy.setITEM("pot med,am destreza,am destreza,am destreza,");
            archerenemy.setHAB("ALCANCE");
            archerenemy.setEVOL(false);

            clerigenemy.setHP(60);
            clerigenemy.setMHP(60);
            clerigenemy.setATK(1);
            clerigenemy.setDEF(10);
            clerigenemy.setDES(20);
            clerigenemy.setVEL(15);
            clerigenemy.setWEAPON("MAÇA.CURA.PEQ");
            clerigenemy.setITEM("pot max,");
            clerigenemy.setHAB("MARTIRE");
            clerigenemy.setEVOL(false);

            mageenemy.setHP(30);
            mageenemy.setMHP(30);
            mageenemy.setATK(25);
            mageenemy.setDEF(25);
            mageenemy.setDES(30);
            mageenemy.setVEL(20);
            mageenemy.setWEAPON("FORÇA.DA.NATUREZA(FRACA)");
            mageenemy.setITEM("pot peq,am poderoso,am poderoso,");
            mageenemy.setHAB("INABILIDAR");
            mageenemy.setEVOL(false);

            wingedenemy.setHP(20);
            wingedenemy.setMHP(20);
            wingedenemy.setATK(25);
            wingedenemy.setDEF(25);
            wingedenemy.setDES(30);
            wingedenemy.setVEL(40);
            wingedenemy.setWEAPON("LANÇA.COMUM");
            wingedenemy.setITEM("pot peq,am velocidade,am velocidade,am velocidade,");
            wingedenemy.setHAB("REFORÇO NO ATAQUE");
            wingedenemy.setEVOL(false);

            barbarianenemy.setHP(35);
            barbarianenemy.setMHP(35);
            barbarianenemy.setATK(40);
            barbarianenemy.setDEF(20);
            barbarianenemy.setDES(15);
            barbarianenemy.setVEL(25);
            barbarianenemy.setWEAPON("MACHADO.PESADO");
            barbarianenemy.setITEM("am força,am força,am força,");
            barbarianenemy.setHAB("LOUCURA");
            barbarianenemy.setEVOL(false);

            assasinenemy.setHP(20);
            assasinenemy.setMHP(20);
            assasinenemy.setATK(30);
            assasinenemy.setDEF(10);
            assasinenemy.setDES(40);
            assasinenemy.setVEL(40);
            assasinenemy.setWEAPON("ADAGA.PERIGOSA");
            assasinenemy.setITEM("pot med,");
            assasinenemy.setHAB("ROUBAR");
            assasinenemy.setEVOL(false);

            horseenemy.setHP(40);
            horseenemy.setMHP(40);
            horseenemy.setATK(25);
            horseenemy.setDEF(35);
            horseenemy.setDES(20);
            horseenemy.setVEL(30);
            horseenemy.setWEAPON("ESP.COMUN");
            horseenemy.setITEM("pot med,am defesa,am defesa,am defesa,");
            horseenemy.setHAB("DEFENSOR");
            horseenemy.setEVOL(false);

            sett.AtualizaTabuleiro(this.Controls);
            // lblTurnoDeQuem.Text = "O turno pertence a equipe: "+ sett.turnoDeQuem(sett.getPassos());
            //if (sett.turnoDeQuem(sett.getPassos()))
            //    lblTurnoDeQuem.Text = "O turno pertence a equipe: azul";
            //if (!sett.turnoDeQuem(sett.getPassos()))
            //    lblTurnoDeQuem.Text = "O turno pertence a equipe: vermelha";
            //lblPecasMovidas.Text = "O número total de peças movidas é: " + sett.getClick();
        }

        private void JoguinhoLixo_Activated(object sender, EventArgs e)
        {
            //lblPassosDoDado.Text = "As Tropas podem se mexer " + sett.getLbl() + " passos.";
            //if (sett.turnoDeQuem(sett.getPassos()))
            //    lblTurnoDeQuem.Text = "O turno pertence a equipe: azul";
            //if (!sett.turnoDeQuem(sett.getPassos()))
            //    lblTurnoDeQuem.Text = "O turno pertence a equipe: vermelha";
            //lblPecasMovidas.Text = "O número total de peças movidas é: " + sett.getClick();
            vitoriaazul = true;
            vitoriavermelha = true;
            if (sett.getBateu())
            {
                sett.LimparAreaAzul(this.Controls);
                sett.setVermelho(false);
            }

            int i;
            for (i = 0; i <= this.Controls.Count - 1; i++)
            {
                if (this.Controls[i] is Panel)
                {
                    if ((this.Controls[i] as Panel).BackgroundImage != null)
                    {
                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.assasin.PhysicalDimension)
                            {
                                if (assasin.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;

                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.warrior.PhysicalDimension)
                            {
                                if (warrior.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.archer.PhysicalDimension)
                            {
                                if (archer.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.winged.PhysicalDimension)
                            {
                                if (winged.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.barbarian.PhysicalDimension)
                            {
                                if (barbarian.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.horse.PhysicalDimension)
                            {
                                if (horse.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.clerig.PhysicalDimension)
                            {
                                if (clerig.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.mage.PhysicalDimension)
                            {
                                if (mage.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.The_Knights_Shield.PhysicalDimension)
                            {
                                if (king.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }











                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.assasin___Enemy.PhysicalDimension)
                            {
                                if (assasinenemy.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.warrior___Enemy.PhysicalDimension)
                            {
                                if (warriorenemy.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.archer___Enemy.PhysicalDimension)
                            {
                                if (archerenemy.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                        Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.winged___Enemy.PhysicalDimension)
                            {
                                if (wingedenemy.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.barbarian___Enemy.PhysicalDimension)
                            {
                                if (barbarianenemy.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                          Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.horse___Enemy.PhysicalDimension)
                            {
                                if (horseenemy.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.clerig___Enemy.PhysicalDimension)
                            {
                                if (clerigenemy.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                           Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                           Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                           Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.mage___Enemy.PhysicalDimension)
                            {
                                if (mageenemy.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }


                        if ((this.Controls[i] as Panel).BackgroundImage != null)
                        {
                            if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                                == Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension)
                            {
                                if (kingenemy.getHP() == 0)
                                {
                                    if (Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 89 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 224 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 209 ||
                                         Convert.ToInt32((this.Controls[i] as Panel).Name.ToString().Replace("panel", "")) == 74)
                                        (this.Controls[i] as Panel).BackgroundImage = sett.getAmbiente();
                                    else
                                        (this.Controls[i] as Panel).BackgroundImage = null;
                                }
                            }
                        }
                    }


                }
            }
            i = 0;
            for (i = 0; i <= this.Controls.Count - 1; i++)
            {
                if (this.Controls[i] is Panel)
                {
                    if ((this.Controls[i] as Panel).BackgroundImage != null)
                    {

                        if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                        == Properties.Resources.The_Knights_Shield.PhysicalDimension)
                        {
                            vitoriavermelha = false;
                        }
                        else
                        {
                            //   vitoriavermelha = true;
                        }
                        if ((this.Controls[i] as Panel).BackgroundImage.PhysicalDimension
                           == Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension)
                        {
                            vitoriaazul = false;
                        }
                        else
                        {
                            //  vitoriaazul = true;
                        }
                    }
                }

            }
            if (vitoriavermelha && sett.getPersonagem() == null)
            {
                MessageBox.Show("Time vermelho é o vencedor");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\victori.wav");
                player.Play();
                DialogResult dialogResult = MessageBox.Show("Deseja jogar novamente?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            if (vitoriaazul && sett.getPersonagem() == null)
            {
                MessageBox.Show("Time azul é o vencedor");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\victori.wav");
                player.Play();
                DialogResult dialogResult = MessageBox.Show("Deseja jogar novamente?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            if (king.getITEM() == ",")
            {
                king.setITEM("");
            }
            if (warrior.getITEM() == ",")
            {
                warrior.setITEM("");
            }
            if (archer.getITEM() == ",")
            {
                archer.setITEM("");
            }
            if (horse.getITEM() == ",")
            {
                horse.setITEM("");
            }
            if (winged.getITEM() == ",")
            {
                winged.setITEM("");
            }
            if (mage.getITEM() == ",")
            {
                mage.setITEM("");
            }
            if (assasin.getITEM() == ",")
            {
                assasin.setITEM("");
            }
            if (clerig.getITEM() == ",")
            {
                clerig.setITEM("");
            }
            if (barbarian.getITEM() == ",")
            {
                barbarian.setITEM("");
            }




            if (kingenemy.getITEM() == ",")
            {
                kingenemy.setITEM("");
            }
            if (warriorenemy.getITEM() == ",")
            {
                warriorenemy.setITEM("");
            }
            if (archerenemy.getITEM() == ",")
            {
                archerenemy.setITEM("");
            }
            if (horseenemy.getITEM() == ",")
            {
                horseenemy.setITEM("");
            }
            if (wingedenemy.getITEM() == ",")
            {
                wingedenemy.setITEM("");
            }
            if (mageenemy.getITEM() == ",")
            {
                mageenemy.setITEM("");
            }
            if (assasinenemy.getITEM() == ",")
            {
                assasinenemy.setITEM("");
            }
            if (clerigenemy.getITEM() == ",")
            {
                clerigenemy.setITEM("");
            }
            if (barbarianenemy.getITEM() == ",")
            {
                barbarianenemy.setITEM("");
            }
        }

        private void JoguinhoLixo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                Dados d = new Dados();
                d.Show();
            }
            if (e.KeyCode == Keys.P)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja passar uma peça?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    sett.setClick(1);
                    if ((sett.getClick() == 5 || sett.getClick() == 10) && sett.getPersonagem() != null)
                    {
                        sett.setClick(-1);
                        MessageBox.Show("Vc ta querendo roubar cara!!!");
                    }
                }
                if (dialogResult == DialogResult.No)
                {
                    //nada n 
                }

                if (sett.getClick() >= 10)
                {
                    sett.setClick(-10);
                    sett.setPclista(new Bitmap[10]{Properties.Resources.grass,
   Properties.Resources.grass,Properties.Resources.grass,
    Properties.Resources.grass,Properties.Resources.grass,
   Properties.Resources.grass,Properties.Resources.grass,
    Properties.Resources.grass,Properties.Resources.grass,
    Properties.Resources.grass,});
                    Random random = new Random();
                    int passos = random.Next(1, 7);

                    MessageBox.Show("Turno da equipe Azul");
                    MessageBox.Show(sett.menssagemParaUmDiaMelhor(passos));
                    sett.AtualizaTabuleiro(this.Controls);
                    sett.setPassos(passos);
                    sett.setLbl(passos);
                    sett.setBuf1(null);
                    sett.setBuf2(null);
                }

                if (sett.getClick() == 5)
                {
                    MessageBox.Show("Turno da equipe Vermelha");
                    sett.AtualizaTabuleiro(this.Controls);
                    sett.setBuf1(null);
                    sett.setBuf2(null);
                }
            }
        }
    }
}
