
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Sett
{

    //private static Random d5 = new Random();
    private static int click;
    private static String mess;
    //static Random random = new Random();
    private static int passos;
    private static int gp;
    private static int initiall;
    private static int lblcontent;
    //private static int passos = d5.Next(1,6);
    private static Control certo;
    private static String itemList;
    private static String itemList1;
    private static String itemMensagem;
    private static String hpItem;
    private static String mhpItem;
    private static String atkItem;
    private static String defItem;
    private static String velItem;
    private static String desItem;
    private static bool bateu = false;
    private static bool vermelho = false;
    private static Image personagem = null;
    private static Image personagem1 = null;
    private static Image personagem2 = null;
    private static Image buf1 = null;
    private static Image buf2 = null;
    private static Image ambiente = null;
    private static Image[] pcheck = new Image[299];
    private static Bitmap[] plista = new Bitmap[18] {JoguinhoLixo.Properties.Resources.archer,
        JoguinhoLixo.Properties.Resources.archer___Enemy,JoguinhoLixo.Properties.Resources.assasin,
        JoguinhoLixo.Properties.Resources.assasin___Enemy,JoguinhoLixo.Properties.Resources.barbarian,
        JoguinhoLixo.Properties.Resources.barbarian___Enemy,JoguinhoLixo.Properties.Resources.clerig,
        JoguinhoLixo.Properties.Resources.clerig___Enemy,JoguinhoLixo.Properties.Resources.horse,
        JoguinhoLixo.Properties.Resources.horse___Enemy,JoguinhoLixo.Properties.Resources.mage,
        JoguinhoLixo.Properties.Resources.mage___Enemy, JoguinhoLixo.Properties.Resources.The_Knights_Shield,
        JoguinhoLixo.Properties.Resources.The_Knights_Shield___Enemy,JoguinhoLixo.Properties.Resources.warrior,
        JoguinhoLixo.Properties.Resources.warrior___Enemy,JoguinhoLixo.Properties.Resources.winged,
        JoguinhoLixo.Properties.Resources.winged___Enemy,};
    private static Bitmap[] pclista = new Bitmap[10]{JoguinhoLixo.Properties.Resources.grass,
        JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
        JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
        JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
        JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
        JoguinhoLixo.Properties.Resources.grass,};
    private static Color[] ccheck = new Color[299];
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
    //##########################################################################//
    public string After(string value, string a)
    {
        int posA = value.LastIndexOf(a);
        if (posA == -1)
        {
            return "";
        }
        return value.Substring(0, posA);
    }
    public string Before(string value, string a)
    {
        int posA = value.LastIndexOf(a);
        if (posA == -1)
        {
            return "";
        }
        int adjustedPosA = posA + a.Length;
        if (adjustedPosA >= value.Length)
        {
            return "";
        }
        return value.Substring(adjustedPosA);
    }
    //##########################################################################//
    public void setVermelho(bool Val)
    {
        vermelho = Val;
    }
    public void setPclista(Bitmap[] Val)
    {
        pclista = Val;
    }
    public Bitmap[] getPclista()
    {
        return pclista;
    }
    public void setPersonagem(Image Val)
    {
        personagem = Val;
    }
    public Image getPersonagem()
    {
        return personagem;
    }
    public void setPersonagem1(Image Val)
    {
        personagem1 = Val;
    }
    public Image getPersonagem1()
    {
        return personagem1;
    }
    public void setBuf1(Image Val)
    {
        buf1 = Val;
    }
    public Image getBuf1()
    {
        return buf1;
    }
    public void setBuf2(Image Val)
    {
        buf2 = Val;
    }
    public Image getBuf2()
    {
        return buf2;
    }
    public void setPersonagem2(Image Val)
    {
        personagem2 = Val;
    }
    public Image getPersonagem2()
    {
        return personagem2;
    }
    public void setBateu(bool Val)
    {
        bateu = Val;
    }
    public bool getBateu()
    {
        return bateu;
    }
    //##########################################################################//
    public String menssagemParaUmDiaMelhor(int passadas)
    {
        mess = "As tropas podem andar " + passadas + " passos.";
        return mess;
    }
    //##########################################################################//
    public void setAmbiente(Image Val)
    {
        ambiente = Val;
    }
    public Image getAmbiente()
    {
        return ambiente;
    }
    //##########################################################################//
    public void setMensagem(String Val)
    {
        itemMensagem = Val;
    }
    public String getMensagem()
    {
        return itemMensagem;
    }
    public void setIni(int Val)
    {
        initiall = Val;
    }
    public int getIni()
    {
        return initiall;
    }
    public void setLbl(int Val)
    {
        lblcontent = Val;
    }
    public int getLbl()
    {
        return lblcontent;
    }
    public void setItemList(String Val)
    {
        itemList = Val;
    }
    public String getItemList()
    {
        return itemList;
    }
    public void setItemList1(String Val)
    {
        itemList1 = Val;
    }
    public String getItemList1()
    {
        return itemList1;
    }
    public void setHpItem(String Val)
    {
        hpItem = Val;
    }
    public String getHpItem()
    {
        return hpItem;
    }
    public void setMhpItem(String Val)
    {
        mhpItem = Val;
    }
    public String getMhpItem()
    {
        return mhpItem;
    }
    public void setAtkItem(String Val)
    {
        atkItem = Val;
    }
    public String getAtkItem()
    {
        return atkItem;
    }
    public void setDefItem(String Val)
    {
        defItem = Val;
    }
    public String getDefItem()
    {
        return defItem;
    }
    public void setDesItem(String Val)
    {
        desItem = Val;
    }
    public String getDesItem()
    {
        return desItem;
    }
    public void setVelItem(String Val)
    {
        velItem = Val;
    }
    public String getVelItem()
    {
        return velItem;
    }
    //##########################################################################//
    public void setClick(int Val)
    {
        click = click + Val;
    }
    public int getClick()
    {
        return click;
    }
    public void setPassos(int Val)
    {
        passos = Val;
    }
    public int getPassos()
    {
        return passos;
    }
    //##########################################################################//

    public bool verrificaLimite(Control initial, Control last)
    {
        if ((last.Location.X - initial.Location.X) <= 400 && (last.Location.X - initial.Location.X) >= -400)
        {
            return true;
        }
        else
        {
            return false;
        }


    }
    public bool nEvol(Image persona)
    {
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer.PhysicalDimension && !archer.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer___Enemy.PhysicalDimension && !archerenemy.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin.PhysicalDimension && !assasin.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin___Enemy.PhysicalDimension && !assasinenemy.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian.PhysicalDimension && !barbarian.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian___Enemy.PhysicalDimension && !barbarianenemy.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig.PhysicalDimension && !clerig.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig___Enemy.PhysicalDimension && !clerigenemy.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse.PhysicalDimension && !horse.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse___Enemy.PhysicalDimension && !horseenemy.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage.PhysicalDimension && !mage.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage___Enemy.PhysicalDimension && !mageenemy.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield.PhysicalDimension && !king.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension && !kingenemy.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior.PhysicalDimension && !warrior.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior___Enemy.PhysicalDimension && !warriorenemy.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged.PhysicalDimension && !winged.getEVOL())
        {
            return true;
        }
        else if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension && !wingedenemy.getEVOL())
        {
            return true;
        }
        else
        {
            return false;
        }


    }
    //##########################################################################//
    public bool turnoDeQuem(int quantaspecas)
    {
        if (quantaspecas < 5)
        {
            // MessageBox.Show("Turno da equipe azul");
            //setBuf1(null);
            //setBuf2(null);
            return true;
        }
        else
        {
            //setBuf1(null);
            //setBuf2(null);
            // MessageBox.Show("Turno da equipe Vermelha");
            return false;
        }


    }
    //##########################################################################//
    public void PodeAndar(int initial, Control.ControlCollection coll, Control x)
    {

        passos = getPassos();
        // passos = 23;
        certo = x;

        int guarda = passos;
        foreach (Control c in coll)
        {



            int[] multiplos = new int[passos + 1];
            int[] multiplos2 = new int[passos + 1];
            int casasdiagonais = 0;
            int cont;
            for (cont = 1; cont <= guarda; cont++, passos--)
            {
                casasdiagonais = casasdiagonais + ((passos - 1) * 4);
            }
            passos = guarda;
            int[] diagonais = new int[casasdiagonais];
            int y;
            for (y = 0; y <= passos; y++)
            {
                multiplos2[y] = initial - (23 * y);
                multiplos[y] = initial + (23 * y);
            }
            //if (passos == 2)
            //{
            //    diagonais[0] = multiplos2[1] - 1;
            //    diagonais[1] = multiplos2[1] + 1;
            //    diagonais[2] = multiplos[1] - 1;
            //    diagonais[3] = multiplos[1] + 1;
            //}
            //if (passos == 3)
            //{
            //    diagonais[0] = multiplos2[1] - 1;
            //    diagonais[1] = multiplos2[1] + 1;
            //    diagonais[2] = multiplos[1] - 1;
            //    diagonais[3] = multiplos[1] + 1;
            //    diagonais[4] = multiplos2[1] - 2;
            //    diagonais[5] = multiplos2[1] + 2;
            //    diagonais[6] = multiplos[1] - 2;
            //    diagonais[7] = multiplos[1] + 2;
            //    diagonais[8] = multiplos2[2] - 1;
            //    diagonais[9] = multiplos2[2] + 1;
            //    diagonais[10] = multiplos[2] - 1;
            //    diagonais[11] = multiplos[2] + 1;
            //}
            //if (passos == 4)
            //{
            //    diagonais[0] = multiplos2[1] - 1;
            //    diagonais[1] = multiplos2[1] + 1;
            //    diagonais[2] = multiplos[1] - 1;
            //    diagonais[3] = multiplos[1] + 1;
            //    diagonais[4] = multiplos2[1] - 2;
            //    diagonais[5] = multiplos2[1] + 2;
            //    diagonais[6] = multiplos[1] - 2;
            //    diagonais[7] = multiplos[1] + 2;
            //    diagonais[8] = multiplos2[2] - 1;
            //    diagonais[9] = multiplos2[2] + 1;
            //    diagonais[10] = multiplos[2] - 1;
            //    diagonais[11] = multiplos[2] + 1;

            //    diagonais[12] = multiplos2[1] - 3;
            //    diagonais[13] = multiplos2[1] + 3;
            //    diagonais[14] = multiplos[1] - 3;
            //    diagonais[15] = multiplos[1] + 3;
            //    diagonais[16] = multiplos2[2] - 2;
            //    diagonais[17] = multiplos2[2] + 2;
            //    diagonais[18] = multiplos[2] - 2;
            //    diagonais[19] = multiplos[2] + 2;
            //    diagonais[20] = multiplos2[3] - 1;
            //    diagonais[21] = multiplos2[3] + 1;
            //    diagonais[22] = multiplos[3] - 1;
            //    diagonais[23] = multiplos[3] + 1;
            //}
            //if (passos == 5)
            //{
            int limitvert = passos - 1;
            int limithorizont = passos - 1;
            for (int totalDiagonais = 0; totalDiagonais <= casasdiagonais - 1;)
            {
                for (int horizont = 1; horizont <= limithorizont; horizont++)
                {


                    for (int vertico = 1; vertico <= limitvert; vertico++)
                    {

                        diagonais[totalDiagonais] = multiplos2[horizont] - vertico;
                        diagonais[totalDiagonais + 1] = multiplos2[horizont] + vertico;
                        diagonais[totalDiagonais + 2] = multiplos[horizont] - vertico;
                        diagonais[totalDiagonais + 3] = multiplos[horizont] + vertico;
                        totalDiagonais = totalDiagonais + 4;
                    }
                    limitvert = limitvert - 1;



                    //limithorizont = limithorizont - 1;

                }
            }
            //diagonais[0] = multiplos2[1] - 1;
            //diagonais[1] = multiplos2[1] + 1;
            //diagonais[2] = multiplos[1] - 1;
            //diagonais[3] = multiplos[1] + 1;
            //diagonais[4] = multiplos2[1] - 2;
            //diagonais[5] = multiplos2[1] + 2;
            //diagonais[6] = multiplos[1] - 2;
            //diagonais[7] = multiplos[1] + 2;
            //diagonais[8] = multiplos2[2] - 1;
            //diagonais[9] = multiplos2[2] + 1;
            //diagonais[10] = multiplos[2] - 1;
            //diagonais[11] = multiplos[2] + 1;

            //diagonais[12] = multiplos2[1] - 3;
            //diagonais[13] = multiplos2[1] + 3;
            //diagonais[14] = multiplos[1] - 3;
            //diagonais[15] = multiplos[1] + 3;
            //diagonais[16] = multiplos2[2] - 2;
            //diagonais[17] = multiplos2[2] + 2;
            //diagonais[18] = multiplos[2] - 2;
            //diagonais[19] = multiplos[2] + 2;
            //diagonais[20] = multiplos2[3] - 1;
            //diagonais[21] = multiplos2[3] + 1;
            //diagonais[22] = multiplos[3] - 1;
            //diagonais[23] = multiplos[3] + 1;

            //diagonais[24] = multiplos2[4] - 1;
            //diagonais[25] = multiplos2[4] + 1;
            //diagonais[26] = multiplos[4] - 1;
            //diagonais[27] = multiplos[4] + 1;
            //diagonais[28] = multiplos2[3] - 2;
            //diagonais[29] = multiplos2[3] + 2;
            //diagonais[30] = multiplos[3] - 2;
            //diagonais[31] = multiplos[3] + 2;
            //diagonais[32] = multiplos2[2] - 3;
            //diagonais[33] = multiplos[2] + 3;
            //diagonais[34] = multiplos2[2] + 3;
            //diagonais[35] = multiplos[2] - 3;

            //diagonais[36] = multiplos[1] + 4;
            //diagonais[37] = multiplos2[1] - 4;
            //diagonais[38] = multiplos2[1] + 4;
            //diagonais[39] = multiplos[1] - 4;



            //}





            if (Convert.ToInt32(c.Name.ToString().Replace("panel", "")) <= (initial + passos) &&
               Convert.ToInt32(c.Name.ToString().Replace("panel", "")) >= (initial - passos))
            {
                if (((c.BackColor != Color.SaddleBrown) && verrificaLimite(certo, c)) ||
                (((c.BackColor == Color.SaddleBrown) && verrificaLimite(certo, c)) && (certo.BackgroundImage.PhysicalDimension ==
                JoguinhoLixo.Properties.Resources.winged.PhysicalDimension
                || certo.BackgroundImage.PhysicalDimension ==
                JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)))
                {
                    c.BackColor = System.Drawing.Color.Blue;
                }

            }
            if (multiplos.Contains(Convert.ToInt32(c.Name.ToString().Replace("panel", ""))) ||
                multiplos2.Contains(Convert.ToInt32(c.Name.ToString().Replace("panel", ""))) ||
                diagonais.Contains(Convert.ToInt32(c.Name.ToString().Replace("panel", ""))))
            {
                if (((c.BackColor != Color.SaddleBrown) && verrificaLimite(certo, c)) ||
                  (((c.BackColor == Color.SaddleBrown) && verrificaLimite(certo, c)) && (certo.BackgroundImage.PhysicalDimension ==
                  JoguinhoLixo.Properties.Resources.winged.PhysicalDimension || certo.BackgroundImage.PhysicalDimension ==
                  JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)))
                {
                    c.BackColor = System.Drawing.Color.Blue;
                }
            }

        }

    }

    //##########################################################################//
    public void AtualizaTabuleiro(Control.ControlCollection coll)
    {
        Random random = new Random();
        int newcasa = random.Next(1, 5);
        Image nc = JoguinhoLixo.Properties.Resources.grass;
        string mnc = "";
        if (newcasa == 1)
        {
            nc = JoguinhoLixo.Properties.Resources.upgrade;
            mnc = "Uma nova casa de EVOLUÇÃO surgiu.";
        }
        if (newcasa == 2)
        {
            nc = JoguinhoLixo.Properties.Resources.status;
            mnc = "Uma nova casa de STATUS UP surgiu.";
        }
        if (newcasa == 3)
        {
            nc = JoguinhoLixo.Properties.Resources.item;
            mnc = "Uma nova casa de ITEM MISTERIOSO surgiu.";
        }
        if (newcasa == 4)
        {
            nc = JoguinhoLixo.Properties.Resources.sparkle_weapon;
            mnc = "Uma nova casa de ARMAMENTO MISTERIOSO surgiu.";
        }
        int qualcasa = random.Next(1, 299);
        foreach (Control c in coll)
        {

            if (Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == qualcasa && c.BackgroundImage == null)
            {
                c.BackgroundImage = nc;
                MessageBox.Show(mnc);

            }


        }

    }









    public void PodeAtacar(int initial, Control.ControlCollection coll, Control x)
    {
        gp = getPassos();
        passos = 1;
        //passos = 23;
        if ((getPersonagem().PhysicalDimension == JoguinhoLixo.Properties.Resources.archer.PhysicalDimension &&
            !archer.getEVOL()) ||
           (getPersonagem().PhysicalDimension == JoguinhoLixo.Properties.Resources.archer___Enemy.PhysicalDimension &&
            !archerenemy.getEVOL()))
            passos = 2;
        if ((getPersonagem().PhysicalDimension == JoguinhoLixo.Properties.Resources.mage.PhysicalDimension &&
           !mage.getEVOL()) ||
          (getPersonagem().PhysicalDimension == JoguinhoLixo.Properties.Resources.mage___Enemy.PhysicalDimension &&
           !mageenemy.getEVOL()))
            passos = 2;
        if ((getPersonagem().PhysicalDimension == JoguinhoLixo.Properties.Resources.archer.PhysicalDimension &&
           archer.getEVOL()) ||
          (getPersonagem().PhysicalDimension == JoguinhoLixo.Properties.Resources.archer___Enemy.PhysicalDimension &&
           archerenemy.getEVOL()))
            passos = 3;
        certo = x;
        int guarda = passos;
        foreach (Control c in coll)
        {



            int[] multiplos = new int[passos + 1];
            int[] multiplos2 = new int[passos + 1];
            int casasdiagonais = 0;
            int cont;
            for (cont = 1; cont <= guarda; cont++, passos--)
            {
                casasdiagonais = casasdiagonais + ((passos - 1) * 4);
            }
            passos = guarda;
            int[] diagonais = new int[casasdiagonais];
            int y;
            for (y = 0; y <= passos; y++)
            {
                multiplos2[y] = initial - (23 * y);
                multiplos[y] = initial + (23 * y);
            }
            //if (passos == 2)
            //{
            //    diagonais[0] = multiplos2[1] - 1;
            //    diagonais[1] = multiplos2[1] + 1;
            //    diagonais[2] = multiplos[1] - 1;
            //    diagonais[3] = multiplos[1] + 1;
            //}
            //if (passos == 3)
            //{
            //    diagonais[0] = multiplos2[1] - 1;
            //    diagonais[1] = multiplos2[1] + 1;
            //    diagonais[2] = multiplos[1] - 1;
            //    diagonais[3] = multiplos[1] + 1;
            //    diagonais[4] = multiplos2[1] - 2;
            //    diagonais[5] = multiplos2[1] + 2;
            //    diagonais[6] = multiplos[1] - 2;
            //    diagonais[7] = multiplos[1] + 2;
            //    diagonais[8] = multiplos2[2] - 1;
            //    diagonais[9] = multiplos2[2] + 1;
            //    diagonais[10] = multiplos[2] - 1;
            //    diagonais[11] = multiplos[2] + 1;
            //}
            //if (passos == 4)
            //{
            //    diagonais[0] = multiplos2[1] - 1;
            //    diagonais[1] = multiplos2[1] + 1;
            //    diagonais[2] = multiplos[1] - 1;
            //    diagonais[3] = multiplos[1] + 1;
            //    diagonais[4] = multiplos2[1] - 2;
            //    diagonais[5] = multiplos2[1] + 2;
            //    diagonais[6] = multiplos[1] - 2;
            //    diagonais[7] = multiplos[1] + 2;
            //    diagonais[8] = multiplos2[2] - 1;
            //    diagonais[9] = multiplos2[2] + 1;
            //    diagonais[10] = multiplos[2] - 1;
            //    diagonais[11] = multiplos[2] + 1;

            //    diagonais[12] = multiplos2[1] - 3;
            //    diagonais[13] = multiplos2[1] + 3;
            //    diagonais[14] = multiplos[1] - 3;
            //    diagonais[15] = multiplos[1] + 3;
            //    diagonais[16] = multiplos2[2] - 2;
            //    diagonais[17] = multiplos2[2] + 2;
            //    diagonais[18] = multiplos[2] - 2;
            //    diagonais[19] = multiplos[2] + 2;
            //    diagonais[20] = multiplos2[3] - 1;
            //    diagonais[21] = multiplos2[3] + 1;
            //    diagonais[22] = multiplos[3] - 1;
            //    diagonais[23] = multiplos[3] + 1;
            //}
            //if (passos == 5)
            //{
            int limitvert = passos - 1;
            int limithorizont = passos - 1;
            for (int totalDiagonais = 0; totalDiagonais <= casasdiagonais - 1;)
            {
                for (int horizont = 1; horizont <= limithorizont; horizont++)
                {


                    for (int vertico = 1; vertico <= limitvert; vertico++)
                    {

                        diagonais[totalDiagonais] = multiplos2[horizont] - vertico;
                        diagonais[totalDiagonais + 1] = multiplos2[horizont] + vertico;
                        diagonais[totalDiagonais + 2] = multiplos[horizont] - vertico;
                        diagonais[totalDiagonais + 3] = multiplos[horizont] + vertico;
                        totalDiagonais = totalDiagonais + 4;
                    }
                    limitvert = limitvert - 1;



                    //limithorizont = limithorizont - 1;

                }
            }
            //diagonais[0] = multiplos2[1] - 1;
            //diagonais[1] = multiplos2[1] + 1;
            //diagonais[2] = multiplos[1] - 1;
            //diagonais[3] = multiplos[1] + 1;
            //diagonais[4] = multiplos2[1] - 2;
            //diagonais[5] = multiplos2[1] + 2;
            //diagonais[6] = multiplos[1] - 2;
            //diagonais[7] = multiplos[1] + 2;
            //diagonais[8] = multiplos2[2] - 1;
            //diagonais[9] = multiplos2[2] + 1;
            //diagonais[10] = multiplos[2] - 1;
            //diagonais[11] = multiplos[2] + 1;

            //diagonais[12] = multiplos2[1] - 3;
            //diagonais[13] = multiplos2[1] + 3;
            //diagonais[14] = multiplos[1] - 3;
            //diagonais[15] = multiplos[1] + 3;
            //diagonais[16] = multiplos2[2] - 2;
            //diagonais[17] = multiplos2[2] + 2;
            //diagonais[18] = multiplos[2] - 2;
            //diagonais[19] = multiplos[2] + 2;
            //diagonais[20] = multiplos2[3] - 1;
            //diagonais[21] = multiplos2[3] + 1;
            //diagonais[22] = multiplos[3] - 1;
            //diagonais[23] = multiplos[3] + 1;

            //diagonais[24] = multiplos2[4] - 1;
            //diagonais[25] = multiplos2[4] + 1;
            //diagonais[26] = multiplos[4] - 1;
            //diagonais[27] = multiplos[4] + 1;
            //diagonais[28] = multiplos2[3] - 2;
            //diagonais[29] = multiplos2[3] + 2;
            //diagonais[30] = multiplos[3] - 2;
            //diagonais[31] = multiplos[3] + 2;
            //diagonais[32] = multiplos2[2] - 3;
            //diagonais[33] = multiplos[2] + 3;
            //diagonais[34] = multiplos2[2] + 3;
            //diagonais[35] = multiplos[2] - 3;

            //diagonais[36] = multiplos[1] + 4;
            //diagonais[37] = multiplos2[1] - 4;
            //diagonais[38] = multiplos2[1] + 4;
            //diagonais[39] = multiplos[1] - 4;



            //}





            if (Convert.ToInt32(c.Name.ToString().Replace("panel", "")) <= (initial + passos) &&
               Convert.ToInt32(c.Name.ToString().Replace("panel", "")) >= (initial - passos))
            {
                if ((verrificaLimite(certo, c)) ||
                ((verrificaLimite(certo, c)) && (certo.BackgroundImage.PhysicalDimension ==
                JoguinhoLixo.Properties.Resources.winged.PhysicalDimension
                || certo.BackgroundImage.PhysicalDimension ==
                JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)))
                {
                    c.BackColor = System.Drawing.Color.Red;
                }

            }
            if (multiplos.Contains(Convert.ToInt32(c.Name.ToString().Replace("panel", ""))) ||
                multiplos2.Contains(Convert.ToInt32(c.Name.ToString().Replace("panel", ""))) ||
                diagonais.Contains(Convert.ToInt32(c.Name.ToString().Replace("panel", ""))))
            {
                if ((verrificaLimite(certo, c)) ||
                  ((verrificaLimite(certo, c)) && (certo.BackgroundImage.PhysicalDimension ==
                  JoguinhoLixo.Properties.Resources.winged.PhysicalDimension || certo.BackgroundImage.PhysicalDimension ==
                  JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)))
                {
                    c.BackColor = System.Drawing.Color.Red;
                }
            }

        }
        vermelho = true;
        passos = gp;
    }


    //##########################################################################//
    public void LimparAreaAzul(Control.ControlCollection coll)
    {
        
       
        foreach (Control c in coll)
        {
            int i;
            for (i = 0; i <= coll.Count - 1; i++)
            {
                if (coll[i] is Panel)
                {

                    // PodeAndar(initialocation, coll);
                    (coll[i] as Panel).BackColor = ccheck[i];


                }
            }
        }

    }
    //##########################################################################//
    public void itemMisterioso(Image persona)
    {

        Random random = new Random();
        int qitem = random.Next(1, 9);
        String ite = "";
        if (qitem == 1)
        {
            ite = "pot peq,";
        }
        if (qitem == 2)
        {
            ite = "pot med,";
        }
        if (qitem == 3)
        {
            ite = "pot max,";
        }
        if (qitem == 4)
        {
            ite = "am velocidade,";
        }
        if (qitem == 5)
        {
            ite = "am destreza,";
        }
        if (qitem == 6)
        {
            ite = "am defesa,";
        }
        if (qitem == 7)
        {
            ite = "am força,";
        }
        if (qitem == 8)
        {
            ite = "am poderoso,";
        }

        MessageBox.Show("Você encontrou um: " + ite.Replace(",", "."));

        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin.PhysicalDimension)
        {
            assasin.setITEM(assasin.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior.PhysicalDimension)
        {
            warrior.setITEM(warrior.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse.PhysicalDimension)
        {
            horse.setITEM(horse.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage.PhysicalDimension)
        {
            mage.setITEM(mage.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged.PhysicalDimension)
        {
            winged.setITEM(winged.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield.PhysicalDimension)
        {
            king.setITEM(king.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer.PhysicalDimension)
        {
            archer.setITEM(archer.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig.PhysicalDimension)
        {
            clerig.setITEM(clerig.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian.PhysicalDimension)
        {
            barbarian.setITEM(barbarian.getITEM() + ite);
        }




        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin___Enemy.PhysicalDimension)
        {
            assasinenemy.setITEM(assasinenemy.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior___Enemy.PhysicalDimension)
        {
            warriorenemy.setITEM(warriorenemy.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse___Enemy.PhysicalDimension)
        {
            horseenemy.setITEM(horseenemy.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage___Enemy.PhysicalDimension)
        {
            mageenemy.setITEM(mageenemy.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)
        {
            wingedenemy.setITEM(wingedenemy.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension)
        {
            kingenemy.setITEM(kingenemy.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer___Enemy.PhysicalDimension)
        {
            archerenemy.setITEM(archerenemy.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig___Enemy.PhysicalDimension)
        {
            clerigenemy.setITEM(clerigenemy.getITEM() + ite);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian___Enemy.PhysicalDimension)
        {
            barbarianenemy.setITEM(barbarianenemy.getITEM() + ite);
        }

    }
    public void Evoluir(Image persona)
    {



        MessageBox.Show("Você evoluiu esta peça");

        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin.PhysicalDimension)
        {
            assasin.setMHP(assasin.getMHP() + 20);
            assasin.setHP(assasin.getMHP());
            assasin.setATK(assasin.getATK() + 15);
            assasin.setDEF(assasin.getDEF() + 20);
            assasin.setDES(assasin.getDES() + 30);
            assasin.setVEL(assasin.getVEL() + 25);
            assasin.setHAB(assasin.getHAB() + "+");
            assasin.setWEAPON(After(assasin.getWEAPON(), ".") + ".LETAL");
            assasin.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior.PhysicalDimension)
        {
            warrior.setMHP(warrior.getMHP() + 30);
            warrior.setHP(warrior.getMHP());
            warrior.setATK(warrior.getATK() + 25);
            warrior.setDEF(warrior.getDEF() + 25);
            warrior.setDES(warrior.getDES() + 25);
            warrior.setVEL(warrior.getVEL() + 25);
            warrior.setHAB(warrior.getHAB() + "+");
            warrior.setWEAPON(After(warrior.getWEAPON(), ".") + ".ELITE");
            warrior.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse.PhysicalDimension)
        {
            horse.setMHP(horse.getMHP() + 25);
            horse.setHP(horse.getMHP());
            horse.setATK(horse.getATK() + 20);
            horse.setDEF(horse.getDEF() + 30);
            horse.setDES(horse.getDES() + 15);
            horse.setVEL(horse.getVEL() + 25);
            horse.setHAB(horse.getHAB() + "+");
            horse.setWEAPON(After(horse.getWEAPON(), ".") + ".GIGANTE");
            horse.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage.PhysicalDimension)
        {
            mage.setMHP(mage.getMHP() + 30);
            mage.setHP(mage.getMHP());
            mage.setATK(mage.getATK() + 25);
            mage.setDEF(mage.getDEF() + 20);
            mage.setDES(mage.getDES() + 20);
            mage.setVEL(mage.getVEL() + 25);
            mage.setHAB(mage.getHAB() + "+");
            mage.setWEAPON(After(mage.getWEAPON(), ".") + ".NATUREZA(FORTE)");
            mage.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged.PhysicalDimension)
        {
            winged.setMHP(winged.getMHP() + 20);
            winged.setHP(winged.getMHP());
            winged.setATK(winged.getATK() + 25);
            winged.setDEF(winged.getDEF() + 15);
            winged.setDES(winged.getDES() + 20);
            winged.setVEL(winged.getVEL() + 30);
            winged.setHAB(winged.getHAB() + "+");
            winged.setWEAPON(After(winged.getWEAPON(), ".") + ".ELITE");
            winged.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield.PhysicalDimension)
        {
            king.setMHP(king.getMHP() + 30);
            king.setHP(king.getMHP());
            king.setATK(king.getATK() + 30);
            king.setDEF(king.getDEF() + 30);
            king.setDES(king.getDES() + 30);
            king.setVEL(king.getVEL() + 30);
            king.setHAB(king.getHAB() + "+");
            king.setWEAPON(After(king.getWEAPON(), ".") + ".REAL");
            king.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer.PhysicalDimension)
        {
            archer.setMHP(archer.getMHP() + 15);
            archer.setHP(archer.getMHP());
            archer.setATK(archer.getATK() + 15);
            archer.setDEF(archer.getDEF() + 15);
            archer.setDES(archer.getDES() + 30);
            archer.setVEL(archer.getVEL() + 20);
            archer.setHAB(archer.getHAB() + "+");
            archer.setWEAPON(After(archer.getWEAPON(), ".") + ".LETAL");
            archer.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig.PhysicalDimension)
        {
            clerig.setMHP(clerig.getMHP() + 40);
            clerig.setHP(clerig.getMHP());
            clerig.setATK(clerig.getATK() + 9);
            clerig.setDEF(clerig.getDEF() + 5);
            clerig.setDES(clerig.getDES() + 5);
            clerig.setVEL(clerig.getVEL() + 15);
            clerig.setHAB(clerig.getHAB() + "+");
            clerig.setWEAPON(After(clerig.getWEAPON(), ".") + ".GRAN");
            clerig.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian.PhysicalDimension)
        {
            barbarian.setMHP(barbarian.getMHP() + 20);
            barbarian.setHP(barbarian.getMHP());
            barbarian.setATK(barbarian.getATK() + 30);
            barbarian.setDEF(barbarian.getDEF() + 20);
            barbarian.setDES(barbarian.getDES() + 30);
            barbarian.setVEL(barbarian.getVEL() + 20);
            barbarian.setHAB(barbarian.getHAB() + "+");
            barbarian.setWEAPON(After(barbarian.getWEAPON(), ".") + ".GIGANTE");
            barbarian.setEVOL(true);
        }



        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin___Enemy.PhysicalDimension)
        {
            assasinenemy.setMHP(assasinenemy.getMHP() + 20);
            assasinenemy.setHP(assasinenemy.getMHP());
            assasinenemy.setATK(assasinenemy.getATK() + 15);
            assasinenemy.setDEF(assasinenemy.getDEF() + 20);
            assasinenemy.setDES(assasinenemy.getDES() + 30);
            assasinenemy.setVEL(assasinenemy.getVEL() + 25);
            assasinenemy.setHAB(assasinenemy.getHAB() + "+");
            assasinenemy.setWEAPON(After(assasinenemy.getWEAPON(), ".") + ".LETAL");
            assasinenemy.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior___Enemy.PhysicalDimension)
        {
            warriorenemy.setMHP(warriorenemy.getMHP() + 30);
            warriorenemy.setHP(warriorenemy.getMHP());
            warriorenemy.setATK(warriorenemy.getATK() + 25);
            warriorenemy.setDEF(warriorenemy.getDEF() + 25);
            warriorenemy.setDES(warriorenemy.getDES() + 25);
            warriorenemy.setVEL(warriorenemy.getVEL() + 25);
            warriorenemy.setHAB(warriorenemy.getHAB() + "+");
            warriorenemy.setWEAPON(After(warriorenemy.getWEAPON(), ".") + ".ELITE");
            warriorenemy.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse___Enemy.PhysicalDimension)
        {
            horseenemy.setMHP(horseenemy.getMHP() + 25);
            horseenemy.setHP(horseenemy.getMHP());
            horseenemy.setATK(horseenemy.getATK() + 20);
            horseenemy.setDEF(horseenemy.getDEF() + 30);
            horseenemy.setDES(horseenemy.getDES() + 15);
            horseenemy.setVEL(horseenemy.getVEL() + 30);
            horseenemy.setHAB(horseenemy.getHAB() + "+");
            horseenemy.setWEAPON(After(horseenemy.getWEAPON(), ".") + ".GIGANTE");
            horseenemy.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage___Enemy.PhysicalDimension)
        {
            mageenemy.setMHP(mageenemy.getMHP() + 30);
            mageenemy.setHP(mageenemy.getMHP());
            mageenemy.setATK(mageenemy.getATK() + 25);
            mageenemy.setDEF(mageenemy.getDEF() + 20);
            mageenemy.setDES(mageenemy.getDES() + 20);
            mageenemy.setVEL(mageenemy.getVEL() + 25);
            mageenemy.setHAB(mageenemy.getHAB() + "+");
            mageenemy.setWEAPON(After(mageenemy.getWEAPON(), ".") + ".NATUREZA(FORTE)");
            mageenemy.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)
        {
            wingedenemy.setMHP(wingedenemy.getMHP() + 20);
            wingedenemy.setHP(wingedenemy.getMHP());
            wingedenemy.setATK(wingedenemy.getATK() + 25);
            wingedenemy.setDEF(wingedenemy.getDEF() + 15);
            wingedenemy.setDES(wingedenemy.getDES() + 20);
            wingedenemy.setVEL(wingedenemy.getVEL() + 30);
            wingedenemy.setHAB(wingedenemy.getHAB() + "+");
            wingedenemy.setWEAPON(After(wingedenemy.getWEAPON(), ".") + ".ELITE");
            wingedenemy.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension)
        {
            kingenemy.setMHP(kingenemy.getMHP() + 30);
            kingenemy.setHP(kingenemy.getMHP());
            kingenemy.setATK(kingenemy.getATK() + 30);
            kingenemy.setDEF(kingenemy.getDEF() + 30);
            kingenemy.setDES(kingenemy.getDES() + 30);
            kingenemy.setVEL(kingenemy.getVEL() + 30);
            kingenemy.setHAB(kingenemy.getHAB() + "+");
            kingenemy.setWEAPON(After(kingenemy.getWEAPON(), ".") + ".REAL");
            kingenemy.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer___Enemy.PhysicalDimension)
        {
            archerenemy.setMHP(archerenemy.getMHP() + 15);
            archerenemy.setHP(archerenemy.getMHP());
            archerenemy.setATK(archerenemy.getATK() + 15);
            archerenemy.setDEF(archerenemy.getDEF() + 15);
            archerenemy.setDES(archerenemy.getDES() + 30);
            archerenemy.setVEL(archerenemy.getVEL() + 20);
            archerenemy.setHAB(archerenemy.getHAB() + "+");
            archerenemy.setWEAPON(After(archerenemy.getWEAPON(), ".") + ".LETAL");
            archerenemy.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig___Enemy.PhysicalDimension)
        {
            clerigenemy.setMHP(clerigenemy.getMHP() + 40);
            clerigenemy.setHP(clerigenemy.getMHP());
            clerigenemy.setATK(clerigenemy.getATK() + 9);
            clerigenemy.setDEF(clerigenemy.getDEF() + 5);
            clerigenemy.setDES(clerigenemy.getDES() + 5);
            clerigenemy.setVEL(clerigenemy.getVEL() + 15);
            clerigenemy.setHAB(clerigenemy.getHAB() + "+");
            clerigenemy.setWEAPON(After(clerigenemy.getWEAPON(), ".") + ".GRAN");
            clerigenemy.setEVOL(true);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian___Enemy.PhysicalDimension)
        {
            barbarianenemy.setMHP(barbarianenemy.getMHP() + 20);
            barbarianenemy.setHP(barbarianenemy.getMHP());
            barbarianenemy.setATK(barbarianenemy.getATK() + 30);
            barbarianenemy.setDEF(barbarianenemy.getDEF() + 20);
            barbarianenemy.setDES(barbarianenemy.getDES() + 30);
            barbarianenemy.setVEL(barbarianenemy.getVEL() + 20);
            barbarianenemy.setHAB(barbarianenemy.getHAB() + "+");
            barbarianenemy.setWEAPON(After(barbarianenemy.getWEAPON(), ".") + ".GIGANTE");
            barbarianenemy.setEVOL(true);
        }

    }

    public void trocaArma(Image persona)
    {
        Random random = new Random();
        int qarma = random.Next(1, 6);
        String arm = "";
        if (qarma == 1)
        {
            arm = ".PESADO";
        }
        if (qarma == 2)
        {
            arm = ".GIGANTE";
        }
        if (qarma == 3)
        {
            arm = ".PERIGOSO";
        }
        if (qarma == 4)
        {
            arm = ".LETAL";
        }
        if (qarma == 5)
        {
            arm = ".ELITE";
        }


        MessageBox.Show("Sua arma agora é: " + arm);

        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin.PhysicalDimension)
        {
            assasin.setWEAPON(After(assasin.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior.PhysicalDimension)
        {
            warrior.setWEAPON(After(warrior.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse.PhysicalDimension)
        {
            horse.setWEAPON(After(horse.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage.PhysicalDimension)
        {
            mage.setWEAPON(After(mage.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged.PhysicalDimension)
        {
            winged.setWEAPON(After(winged.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield.PhysicalDimension)
        {
            king.setWEAPON(After(king.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer.PhysicalDimension)
        {
            archer.setWEAPON(After(archer.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig.PhysicalDimension)
        {
            clerig.setWEAPON(After(clerig.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian.PhysicalDimension)
        {
            barbarian.setWEAPON(After(barbarian.getWEAPON(), ".") + arm);
        }




        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin___Enemy.PhysicalDimension)
        {
            assasinenemy.setWEAPON(After(assasinenemy.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior___Enemy.PhysicalDimension)
        {
            warriorenemy.setWEAPON(After(warriorenemy.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse___Enemy.PhysicalDimension)
        {
            horseenemy.setWEAPON(After(horseenemy.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage___Enemy.PhysicalDimension)
        {
            mageenemy.setWEAPON(After(mageenemy.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)
        {
            wingedenemy.setWEAPON(After(wingedenemy.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension)
        {
            kingenemy.setWEAPON(After(kingenemy.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer___Enemy.PhysicalDimension)
        {
            archerenemy.setWEAPON(After(archerenemy.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig___Enemy.PhysicalDimension)
        {
            clerigenemy.setWEAPON(After(clerigenemy.getWEAPON(), ".") + arm);
        }
        if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian___Enemy.PhysicalDimension)
        {
            barbarianenemy.setWEAPON(After(barbarianenemy.getWEAPON(), ".") + arm);
        }








    }
    public void statusAleatorio(Image persona)
    {
        Random random = new Random();
        int qstatus = random.Next(1, 5);
        String sta = "";
        if (qstatus == 1)
        {
            sta = "ATK";



            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin.PhysicalDimension)
            {
                assasin.setATK(assasin.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior.PhysicalDimension)
            {
                warrior.setATK(warrior.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse.PhysicalDimension)
            {
                horse.setATK(horse.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage.PhysicalDimension)
            {
                mage.setATK(mage.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged.PhysicalDimension)
            {
                winged.setATK(winged.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield.PhysicalDimension)
            {
                king.setATK(king.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer.PhysicalDimension)
            {
                archer.setATK(archer.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig.PhysicalDimension)
            {
                clerig.setATK(clerig.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian.PhysicalDimension)
            {
                barbarian.setATK(barbarian.getATK() + 10);
            }




            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin___Enemy.PhysicalDimension)
            {
                assasinenemy.setATK(assasinenemy.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior___Enemy.PhysicalDimension)
            {
                warriorenemy.setATK(warriorenemy.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse___Enemy.PhysicalDimension)
            {
                horseenemy.setATK(horseenemy.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage___Enemy.PhysicalDimension)
            {
                mageenemy.setATK(mageenemy.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)
            {
                wingedenemy.setATK(wingedenemy.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension)
            {
                kingenemy.setATK(kingenemy.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer___Enemy.PhysicalDimension)
            {
                archerenemy.setATK(archerenemy.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig___Enemy.PhysicalDimension)
            {
                clerigenemy.setATK(clerigenemy.getATK() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian___Enemy.PhysicalDimension)
            {
                barbarianenemy.setATK(barbarianenemy.getATK() + 10);
            }
        }
        if (qstatus == 2)
        {
            sta = "DEF";


            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin.PhysicalDimension)
            {
                assasin.setDEF(assasin.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior.PhysicalDimension)
            {
                warrior.setDEF(warrior.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse.PhysicalDimension)
            {
                horse.setDEF(horse.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage.PhysicalDimension)
            {
                mage.setDEF(mage.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged.PhysicalDimension)
            {
                winged.setDEF(winged.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield.PhysicalDimension)
            {
                king.setDEF(king.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer.PhysicalDimension)
            {
                archer.setDEF(archer.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig.PhysicalDimension)
            {
                clerig.setDEF(clerig.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian.PhysicalDimension)
            {
                barbarian.setDEF(barbarian.getDEF() + 10);
            }




            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin___Enemy.PhysicalDimension)
            {
                assasinenemy.setDEF(assasinenemy.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior___Enemy.PhysicalDimension)
            {
                warriorenemy.setDEF(warriorenemy.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse___Enemy.PhysicalDimension)
            {
                horseenemy.setDEF(horseenemy.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage___Enemy.PhysicalDimension)
            {
                mageenemy.setDEF(mageenemy.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)
            {
                wingedenemy.setDEF(wingedenemy.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension)
            {
                kingenemy.setDEF(kingenemy.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer___Enemy.PhysicalDimension)
            {
                archerenemy.setDEF(archerenemy.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig___Enemy.PhysicalDimension)
            {
                clerigenemy.setDEF(clerigenemy.getDEF() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian___Enemy.PhysicalDimension)
            {
                barbarianenemy.setDEF(barbarianenemy.getDEF() + 10);
            }
        }
        if (qstatus == 3)
        {
            sta = "DES";

            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin.PhysicalDimension)
            {
                assasin.setDES(assasin.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior.PhysicalDimension)
            {
                warrior.setDES(warrior.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse.PhysicalDimension)
            {
                horse.setDES(horse.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage.PhysicalDimension)
            {
                mage.setDES(mage.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged.PhysicalDimension)
            {
                winged.setDES(winged.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield.PhysicalDimension)
            {
                king.setDES(king.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer.PhysicalDimension)
            {
                archer.setDES(archer.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig.PhysicalDimension)
            {
                clerig.setDES(clerig.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian.PhysicalDimension)
            {
                barbarian.setDES(barbarian.getDES() + 10);
            }




            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin___Enemy.PhysicalDimension)
            {
                assasinenemy.setDES(assasinenemy.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior___Enemy.PhysicalDimension)
            {
                warriorenemy.setDES(warriorenemy.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse___Enemy.PhysicalDimension)
            {
                horseenemy.setDES(horseenemy.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage___Enemy.PhysicalDimension)
            {
                mageenemy.setDES(mageenemy.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)
            {
                wingedenemy.setDES(wingedenemy.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension)
            {
                kingenemy.setDES(kingenemy.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer___Enemy.PhysicalDimension)
            {
                archerenemy.setDES(archerenemy.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig___Enemy.PhysicalDimension)
            {
                clerigenemy.setDES(clerigenemy.getDES() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian___Enemy.PhysicalDimension)
            {
                barbarianenemy.setDES(barbarianenemy.getDES() + 10);
            }
        }
        if (qstatus == 4)
        {
            sta = "VEL";


            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin.PhysicalDimension)
            {
                assasin.setVEL(assasin.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior.PhysicalDimension)
            {
                warrior.setVEL(warrior.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse.PhysicalDimension)
            {
                horse.setVEL(horse.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage.PhysicalDimension)
            {
                mage.setVEL(mage.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged.PhysicalDimension)
            {
                winged.setVEL(winged.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield.PhysicalDimension)
            {
                king.setVEL(king.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer.PhysicalDimension)
            {
                archer.setVEL(archer.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig.PhysicalDimension)
            {
                clerig.setVEL(clerig.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian.PhysicalDimension)
            {
                barbarian.setVEL(barbarian.getVEL() + 10);
            }




            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.assasin___Enemy.PhysicalDimension)
            {
                assasinenemy.setVEL(assasinenemy.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.warrior___Enemy.PhysicalDimension)
            {
                warriorenemy.setVEL(warriorenemy.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.horse___Enemy.PhysicalDimension)
            {
                horseenemy.setVEL(horseenemy.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.mage___Enemy.PhysicalDimension)
            {
                mageenemy.setVEL(mageenemy.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.winged___Enemy.PhysicalDimension)
            {
                wingedenemy.setVEL(wingedenemy.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.The_Knights_Shield___Enemy.PhysicalDimension)
            {
                kingenemy.setVEL(kingenemy.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.archer___Enemy.PhysicalDimension)
            {
                archerenemy.setVEL(archerenemy.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.clerig___Enemy.PhysicalDimension)
            {
                clerigenemy.setVEL(clerigenemy.getVEL() + 10);
            }
            if (persona.PhysicalDimension == JoguinhoLixo.Properties.Resources.barbarian___Enemy.PhysicalDimension)
            {
                barbarianenemy.setVEL(barbarianenemy.getVEL() + 10);
            }
        }



        MessageBox.Show("Você aumentou em 10 o seu: " + sta);










    }
    //##########################################################################//
    public void setNome(Control.ControlCollection coll)
    {
        //FUNÇÃO QUE FAZ TODOS OS F##### 298 PANELS TEREM A MESMA FUNCTION CLICK
        foreach (Control c in coll)
        {
            //MOVIMENTAÇÃO EM CLICK
            c.MouseClick += (sender, e) =>
            {
                setBuf1(null);
                setBuf2(null);

                //if (e.Button == MouseButtons.Left)
                //{
                //   int initialocation = Convert.ToInt32(c.Name.ToString().Replace("panel", ""));
                //}
                if (e.Button == MouseButtons.Middle)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja passar uma peça?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        setClick(1);
                        if ((getClick() == 4 || getClick() == 10) && getPersonagem() != null)
                        {
                            setClick(-1);
                            MessageBox.Show("Vc ta querendo roubar cara!!!");
                        }
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        //nada n 
                    }

                    if (getClick() == 10)
                    {
                        setClick(-10);
                        pclista = new Bitmap[10]{JoguinhoLixo.Properties.Resources.grass,
    JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
    JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
    JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
    JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
    JoguinhoLixo.Properties.Resources.grass,};
                        Random random = new Random();
                        int passos = random.Next(1, 7);

                        MessageBox.Show("Turno da equipe Azul");
                        MessageBox.Show(menssagemParaUmDiaMelhor(passos));
                        AtualizaTabuleiro(coll);
                        setPassos(passos);
                        setLbl(passos);
                        setBuf1(null);
                        setBuf2(null);
                    }

                    if (getClick() == 4)
                    {
                        MessageBox.Show("Turno da equipe Vermelha");
                        AtualizaTabuleiro(coll);
                        setBuf1(null);
                        setBuf2(null);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (getPersonagem() == null)
                    {
                        setPersonagem1(c.BackgroundImage);
                        JoguinhoLixo.Personagem p = new JoguinhoLixo.Personagem();
                        p.Show();
                        setPersonagem1(null);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Deseja cancelar esse movimento?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes && !getBateu() && !vermelho)
                        {
                            setClick(0);
                            LimparAreaAzul(coll);
                            int i;
                            for (i = 0; i <= coll.Count - 1; i++)
                            {
                                if (coll[i] is Panel)
                                {
                                    if (getIni() > 0)
                                    {
                                        if (Convert.ToInt32((coll[i] as Panel).Name.ToString().Replace("panel", "")) == getIni())
                                        {
                                            (coll[i] as Panel).BackgroundImage = getPersonagem();

                                        }
                                    }


                                }
                            }
                            setPersonagem(null);
                        }
                        if (dialogResult == DialogResult.Yes && getBateu())
                        {
                            MessageBox.Show("Vc ta querendo roubar cara!!!");
                        }
                        if (dialogResult == DialogResult.Yes && vermelho)
                        {
                            LimparAreaAzul(coll);
                            setClick(1);
                            setPersonagem(null);
                            vermelho = false;
                        }
                        if (dialogResult == DialogResult.No)
                        {
                            //nada n 
                        }
                    }

                }
                else if (e.Button == MouseButtons.Left)
                {


                    if (c.BackgroundImage != null && (c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[1].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[2].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[3].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[4].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[5].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[6].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[7].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[8].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[9].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[10].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[11].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[12].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[13].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[14].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[15].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[16].PhysicalDimension ||
                             c.BackgroundImage.PhysicalDimension == plista[17].PhysicalDimension))
                    {
                        if (getPersonagem() != null)
                        {

                            if (c.BackColor == Color.Red)
                            {
                                setPersonagem2(c.BackgroundImage);
                                if (!getBateu())
                                {
                                    if (Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 63 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 62 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 86 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 85 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 134 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 133 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 158 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 155 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 182 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 177 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 204 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 201 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 226 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 225 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 245 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 268 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 269 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 267 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 291 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 14 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 36 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 34 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 58 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 10 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 7 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 30 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 29 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 31 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 53 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 73 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 72 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 63 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 97 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 94 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 121 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 116 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 143 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 140 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 165 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 164 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 213 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 212 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 236 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 235 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 240 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 264 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 262 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 288 ||
                                     Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 284)
                                    {
                                        setBuf2(JoguinhoLixo.Properties.Resources.grass);
                                    }
                                    if (Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 89 ||
                                              Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 224 ||
                                              Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 74 ||
                                              Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 209)
                                    {
                                        setBuf1(c.BackgroundImage);
                                    }
                                    if (c.BackgroundImage.PhysicalDimension == getPersonagem().PhysicalDimension && vermelho)
                                    {
                                        LimparAreaAzul(coll);
                                        setClick(1);
                                        setPersonagem(null);
                                        vermelho = false;
                                    }
                                    else
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Deseja interagir com essa unidade?", "", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            JoguinhoLixo.Batalha b = new JoguinhoLixo.Batalha();
                                            b.Show();
                                            setBateu(true);
                                        }
                                        if (dialogResult == DialogResult.No)
                                        {
                                            //nada n 
                                        }
                                    }
                                }


                                setPersonagem2(null);
                            }
                        }
                    }
                    if (getClick() == 10)
                    {
                        setClick(-10);
                        pclista = new Bitmap[10]{JoguinhoLixo.Properties.Resources.grass,
    JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
    JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
    JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
    JoguinhoLixo.Properties.Resources.grass,JoguinhoLixo.Properties.Resources.grass,
    JoguinhoLixo.Properties.Resources.grass,};
                        Random random = new Random();
                        int passos = random.Next(1, 6);
                        MessageBox.Show("Turno da equipe Azul");
                        MessageBox.Show(menssagemParaUmDiaMelhor(passos));
                        AtualizaTabuleiro(coll);
                        setPassos(passos);
                        setLbl(passos);
                        setBuf1(null);
                        setBuf2(null);
                    }

                    int initialocation = Convert.ToInt32(c.Name.ToString().Replace("panel", ""));

                    int i;
                    for (i = 0; i <= coll.Count - 1; i++)
                    {
                        if (coll[i] is Panel)
                        {

                            if ((coll[i] as Panel).BackColor != Color.Blue && (coll[i] as Panel).BackColor != Color.Red)
                                ccheck[i] = (coll[i] as Panel).BackColor;

                            pcheck[i] = (coll[i] as Panel).BackgroundImage;

                        }
                    }
                    for (i = 0; i <= coll.Count - 1; i++)
                    {
                        if (coll[i] is Panel)
                        {
                            if (getPersonagem() == null && c.BackgroundImage != getPersonagem())
                            {
                                if ((c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[1].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[2].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[3].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[4].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[5].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[6].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[7].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[8].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[9].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[10].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[11].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[12].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[13].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[14].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[15].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[16].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[17].PhysicalDimension))
                                {
                                    if (turnoDeQuem(getClick()) && !vermelho)
                                    {
                                        if (c.BackgroundImage != null)
                                        {
                                            if ((c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[2].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[4].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[6].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[8].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[10].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[12].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[14].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[16].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension))
                                            {
                                                if (!(c.BackgroundImage.PhysicalDimension == pclista[0].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[1].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[2].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[3].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[4].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[5].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[6].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[7].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[8].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[9].PhysicalDimension))
                                                {

                                                    PodeAndar(initialocation, coll, c);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (c.BackgroundImage != null && !vermelho)
                                        {
                                            if (!(c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[2].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[4].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[6].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[8].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[10].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[12].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[14].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[16].PhysicalDimension ||
                                               c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension))
                                            {
                                                if (!(c.BackgroundImage.PhysicalDimension == pclista[0].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[1].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[2].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[3].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[4].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[5].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[6].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[7].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[8].PhysicalDimension ||
                                         c.BackgroundImage.PhysicalDimension == pclista[9].PhysicalDimension))
                                                {
                                                    PodeAndar(initialocation, coll, c);
                                                }
                                            }
                                        }
                                    }
                                }
                            }


                            //pcheck[i] = (coll[i] as Panel).BackgroundImage;

                        }
                    }

                    if (c.BackgroundImage != null && !(c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[1].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[2].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[3].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[4].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[5].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[6].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[7].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[8].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[9].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[10].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[11].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[12].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[13].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[14].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[15].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[16].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[17].PhysicalDimension))
                    {
                        if (getPersonagem() != null)
                        {

                            if (c.BackColor == Color.Blue)
                            {
                                if (c.BackgroundImage.PhysicalDimension
                                == JoguinhoLixo.Properties.Resources.item.PhysicalDimension)
                                {
                                    itemMisterioso(getPersonagem());
                                }
                                if (c.BackgroundImage.PhysicalDimension
                                == JoguinhoLixo.Properties.Resources.sparkle_weapon.PhysicalDimension)
                                {
                                    trocaArma(getPersonagem());
                                }
                                if (c.BackgroundImage.PhysicalDimension
                               == JoguinhoLixo.Properties.Resources.status.PhysicalDimension)
                                {
                                    statusAleatorio(getPersonagem());
                                }
                                if (c.BackgroundImage.PhysicalDimension
                              == JoguinhoLixo.Properties.Resources.upgrade.PhysicalDimension)
                                {
                                    if (nEvol(getPersonagem()))
                                        Evoluir(getPersonagem());
                                }


                            }
                        }
                    }
                    if (c.BackgroundImage == null ||
                               !(c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[1].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[2].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[3].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[4].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[5].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[6].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[7].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[8].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[9].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[10].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[11].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[12].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[13].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[14].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[15].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[16].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[17].PhysicalDimension))
                    {
                        if (getPersonagem() != null)
                        {

                            if (c.BackColor == Color.Blue)
                            {
                                if (c.BackgroundImage != null &&
                               !(c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[1].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[2].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[3].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[4].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[5].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[6].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[7].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[8].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[9].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[10].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[11].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[12].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[13].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[14].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[15].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[16].PhysicalDimension ||
                               c.BackgroundImage.PhysicalDimension == plista[17].PhysicalDimension) &&
                               c.BackgroundImage.PhysicalDimension
                               == JoguinhoLixo.Properties.Resources.castle_black.PhysicalDimension)
                                {
                                    setAmbiente(c.BackgroundImage);

                                }
                                if (c.BackgroundImage == null)
                                {
                                    setAmbiente(JoguinhoLixo.Properties.Resources.castle_black);

                                }
                                c.BackgroundImage = getPersonagem();
                                //só pra saber
                                LimparAreaAzul(coll);

                                PodeAtacar(initialocation, coll, c);





                                if (getClick() == 4)
                                {
                                    MessageBox.Show("Turno da equipe Vermelha");
                                    AtualizaTabuleiro(coll);
                                    setBuf1(null);
                                    setBuf2(null);
                                }
                            }



                        }
                    }
                    else
                    {
                        if (pcheck.Contains(getPersonagem()))
                        {
                            if ((c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[1].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[2].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[3].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[4].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[5].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[6].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[7].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[8].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[9].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[10].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[11].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[12].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[13].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[14].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[15].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[16].PhysicalDimension ||
                                c.BackgroundImage.PhysicalDimension == plista[17].PhysicalDimension))
                            {
                                if (turnoDeQuem(getClick()))
                                {
                                    if (c.BackgroundImage != null && !vermelho)
                                    {
                                        if ((c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[2].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[4].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[6].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[8].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[10].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[12].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[14].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[16].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension))
                                        {
                                            if (!(c.BackgroundImage.PhysicalDimension == pclista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[1].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[2].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[3].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[4].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[5].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[6].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[7].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[8].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[9].PhysicalDimension))
                                            {
                                                setPersonagem1(c.BackgroundImage);
                                                setBateu(false);
                                                if (!vermelho)
                                                {
                                                    setPersonagem(c.BackgroundImage);


                                                    setIni(initialocation);
                                                    //setClick(1);
                                                    pclista[getClick() - 0] = (Bitmap)c.BackgroundImage;
                                                    if (Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 89 ||
                                                   Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 224 ||
                                                   Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 74 ||
                                                   Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 209)
                                                    {
                                                        c.BackgroundImage = getAmbiente();
                                                    }
                                                    else
                                                    {
                                                        c.BackgroundImage = null;
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                                else
                                {
                                    if (c.BackgroundImage != null)
                                    {
                                        if (!(c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[2].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[4].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[6].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[8].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[10].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[12].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[14].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[16].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == plista[0].PhysicalDimension))
                                        {
                                            if (!(c.BackgroundImage.PhysicalDimension == pclista[0].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[1].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[2].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[3].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[4].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[5].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[6].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[7].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[8].PhysicalDimension ||
                                           c.BackgroundImage.PhysicalDimension == pclista[9].PhysicalDimension))
                                            {
                                                setPersonagem1(c.BackgroundImage);
                                                setBateu(false);
                                                if (!vermelho)
                                                {
                                                    setPersonagem(c.BackgroundImage);


                                                    setIni(initialocation);
                                                    //  setClick(1);
                                                    pclista[getClick() - 0] = (Bitmap)c.BackgroundImage;
                                                    if (Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 89 ||
                                                    Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 224 ||
                                                    Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 74 ||
                                                    Convert.ToInt32(c.Name.ToString().Replace("panel", "")) == 209)
                                                    {
                                                        c.BackgroundImage = getAmbiente();
                                                    }
                                                    else
                                                    {
                                                        c.BackgroundImage = null;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }

                        }


                    }

                }
            };
            setNome(c.Controls);
        }
        //##########################################################################//

    }

}
public class King
{
    ////    PRINCIPE//REI
    ////-HP 30//50
    ////-ATK 30//50
    ////-DEF 30//50
    ////-DES 30//50
    ////-VEL 30//50
    ////-WEAPON: ESP.BRAV(50%//100% DE TENTAR O GOLPE OUTRA VEZ)
    ////-ITEM: POTION MAX E CARTA REAL(CONVERSÃO 25%//50%)
    ////-HABILIDADE: CHAMADO REAL (1//3 PERSONAGENS NA LINHA DE FRENTE)
    private static int MHP;
    private static int HP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class Warrior
{
    //    GUERREIRO//ESPADACHIM 
    //-HP 30//45
    //-ATK 25//30
    //-DEF 25//30
    //-DES 30//40
    //-VEL 20//35
    //-ITEM: POÇÃO MÉDIA 
    //-WEAPON:ESPADA COMUM//DE ELITE(-//20% DE CONTRATAQUE METADE DO DANO RECEBIDO)
    //-HABILIDADE: ESFORÇO(25% DE CHANCE DO AUMENTO DE 5//10 EM TODOS OS ESTADOS)


    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class Archer
{
    //    ARQUEIRO//SNIPER
    //-HP 25//30
    //-ATK 15//25
    //-DEF 15//25
    //-DES 50//70
    //-VEL 30//45
    //-ITEM: AMULETO DA DESTREZA(+10 DES 3X) E POÇÃO MÉDIA
    //-WEAPON:ARCO PERIGOSO//LETAL (10%//30%DE TENTAR CRÍTICO NOVAMENTE)
    //-HABILIDADE: ALCANCE(1//2 A MAIS DE ALCANCE)



    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class Clerig
{
    //    CLÉRIGO//SACERDOTE
    //-HP 60//80
    //-ATK 0//0
    //-DEF 10//30
    //-DES 20//30
    //-VEL 15//25
    //-ITEM: POTION MAX/
    //-WEAPON: BAQUE CURA(20//30)
    //-HABILIDADE: MARTIR (10%//20% DE CURAR TUDO)




    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;


    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }


    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }

    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class Mage
{
    //    FEITICEIRO//MAGO
    //-HP 30//40
    //-ATK 25//35
    //-DEF 25//35
    //-DES 30//40
    //-VEL 20//30
    //-ITEM: AMULETO PODEROSO(+5 TODOS-HP 2X) E POÇÃO PEQUENA
    //-WEAPON:FORÇA DA NATUREZA(20//40% DE FRAQUEZA)
    // -HABILIDADE: ATAQUE EM DIAGONAL E INABILIDAR//ATEQUE EM DIAGONAL E MALDIÇÃO (INABILIDAR + -5 EM TODOS OS STATUS EXCETO HP)





    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }

    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class Winged
{
    //    ESCUDEIRO EM MONTARIA ALADA//CAVALEIRO EM MONTARIA ALADA
    //-HP:20//40
    //-ATK 25//30
    //-DEF 25//30
    //-DES 30//50
    //-VEL 35//55
    //-ITEM: POÇÃO PEQ E AMULETO VEL(+10 VEL 3X)
    //-WEAPON:LANÇA COMUM// DE ELITE
    //-HABILIDADE: MOVIMENTO +2//MOVIMENTO+3 E REFORÇO NO ATAQUE(50% DE CHACE DE ATACAR APÓS O GOLPE DE OUTRO PERSONAGEM(A JOGADA DE ATAQUE É A COMUM MAS O DANO FINAL É DIVIDIDO POR 2 ,1 VEZ NO TURNO))




    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }

    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class Barbarian
{
    //    REBELDE//BÁRBARO
    //-HP 35//45
    //-ATK 40//60
    //-DEF 20//30
    //-DES 15//30
    //-VEL 25//35
    //-ITEM: AMULETO DA FORÇA(+10 ATK 3X)
    //-WEAPON: MAC.PESADO//GIGANTE(20%//40% DE NEGAR DEFESA)
    //-HABILIDADE: LOUCURA(10//20 A MAIS DE DANO SE HP MENOR QUE 10//20 APÓS O ATAQUE)


    private static int HP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;
    private static int MHP;
    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class Assasin
{
    // LADRÃO//ASSASINO
    //-HP 20//30
    //-ATK 30//30
    //-DEF 10//20
    //-DES 40//60
    //-VEL 40//60
    //-ITEM: POÇÃO PEQUENA E FACA ENVENENADA(25% DE CHACE DE ENVENENAR (-3 HP TODO TURNO)3X)
    //-WEAPON:LANÇA COMUM E ADAGA PERIGOSA//LETAL(10%//30%DE TENTAR CRÍTICO NOVAMENTE)
    //-HABILIDADE: ROUBAR(25%//50% DE ROUBAR ITEM)//ROUBAR E ASSASINATO(10% DE CHACE DE MORTE INSTANTANEA )



    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class Horse
{
    //    ESCUDEIRO MONTADO//CAVALEIRO MONTADO
    //-HP:40//60
    //-ATK 30//50
    //-DEF 35//60
    //-DES 25//35
    //-VEL 30//35
    //-ITEM: POÇÃO MED E AMULETO DEF(+10 DEF 3X)
    //-WEAPON:LANÇA,MACHADO E ESPADA COMUM// GIGANTE
    //-HABILIDADE: MOVIMENTO +1//MOVIMENTO+2 E DEFENSOR(50% DE CHACE DE LEVAR O GOLPE DE OUTRO PERSONAGEM(1 VEZ NO TURNO))




    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}





//separação










public class KingEnemy
{
    ////    PRINCIPE//REI
    ////-HP 30//50
    ////-ATK 30//50
    ////-DEF 30//50
    ////-DES 30//50
    ////-VEL 30//50
    ////-WEAPON: ESP.BRAV(50%//100% DE TENTAR O GOLPE OUTRA VEZ)
    ////-ITEM: POTION MAX E CARTA REAL(CONVERSÃO 25%//50%)
    ////-HABILIDADE: CHAMADO REAL (1//3 PERSONAGENS NA LINHA DE FRENTE)

    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class WarriorEnemy
{
    //    GUERREIRO//ESPADACHIM 
    //-HP 30//45
    //-ATK 25//30
    //-DEF 25//30
    //-DES 30//40
    //-VEL 20//35
    //-ITEM: POÇÃO MÉDIA 
    //-WEAPON:ESPADA COMUM//DE ELITE(-//20% DE CONTRATAQUE METADE DO DANO RECEBIDO)
    //-HABILIDADE: ESFORÇO(25% DE CHANCE DO AUMENTO DE 5//10 EM TODOS OS ESTADOS)


    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class ArcherEnemy
{
    //    ARQUEIRO//SNIPER
    //-HP 25//30
    //-ATK 15//25
    //-DEF 15//25
    //-DES 50//70
    //-VEL 30//45
    //-ITEM: AMULETO DA DESTREZA(+10 DES 3X) E POÇÃO MÉDIA
    //-WEAPON:ARCO PERIGOSO//LETAL (10%//30%DE TENTAR CRÍTICO NOVAMENTE)
    //-HABILIDADE: ALCANCE(1//2 A MAIS DE ALCANCE)



    private static int HP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;
    private static int MHP;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class ClerigEnemy
{
    //    CLÉRIGO//SACERDOTE
    //-HP 60//80
    //-ATK 0//0
    //-DEF 10//30
    //-DES 20//30
    //-VEL 15//25
    //-ITEM: POTION MAX/
    //-WEAPON: BAQUE CURA(20//30)
    //-HABILIDADE: MARTIR (10%//20% DE CURAR TUDO)




    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class MageEnemy
{
    //    FEITICEIRO//MAGO
    //-HP 30//40
    //-ATK 25//35
    //-DEF 25//35
    //-DES 30//40
    //-VEL 20//30
    //-ITEM: AMULETO PODEROSO(+5 TODOS-HP 2X) E POÇÃO PEQUENA
    //-WEAPON:FORÇA DA NATUREZA(20//40% DE FRAQUEZA)
    // -HABILIDADE: ATAQUE EM DIAGONAL E INABILIDAR//ATEQUE EM DIAGONAL E MALDIÇÃO (INABILIDAR + -5 EM TODOS OS STATUS EXCETO HP)





    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class WingedEnemy
{
    //    ESCUDEIRO EM MONTARIA ALADA//CAVALEIRO EM MONTARIA ALADA
    //-HP:20//40
    //-ATK 25//30
    //-DEF 25//30
    //-DES 30//50
    //-VEL 35//55
    //-ITEM: POÇÃO PEQ E AMULETO VEL(+10 VEL 3X)
    //-WEAPON:LANÇA COMUM// DE ELITE
    //-HABILIDADE: MOVIMENTO +2//MOVIMENTO+3 E REFORÇO NO ATAQUE(50% DE CHACE DE ATACAR APÓS O GOLPE DE OUTRO PERSONAGEM(A JOGADA DE ATAQUE É A COMUM MAS O DANO FINAL É DIVIDIDO POR 2 ,1 VEZ NO TURNO))




    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class BarbarianEnemy
{
    //    REBELDE//BÁRBARO
    //-HP 35//45
    //-ATK 40//60
    //-DEF 20//30
    //-DES 15//30
    //-VEL 25//35
    //-ITEM: AMULETO DA FORÇA(+10 ATK 3X)
    //-WEAPON: MAC.PESADO//GIGANTE(20%//40% DE NEGAR DEFESA)
    //-HABILIDADE: LOUCURA(10//20 A MAIS DE DANO SE HP MENOR QUE 10//20 APÓS O ATAQUE)


    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class AssasinEnemy
{
    // LADRÃO//ASSASINO
    //-HP 20//30
    //-ATK 30//30
    //-DEF 10//20
    //-DES 40//60
    //-VEL 40//60
    //-ITEM: POÇÃO PEQUENA E FACA ENVENENADA(25% DE CHACE DE ENVENENAR (-3 HP TODO TURNO)3X)
    //-WEAPON:LANÇA COMUM E ADAGA PERIGOSA//LETAL(10%//30%DE TENTAR CRÍTICO NOVAMENTE)
    //-HABILIDADE: ROUBAR(25%//50% DE ROUBAR ITEM)//ROUBAR E ASSASINATO(10% DE CHACE DE MORTE INSTANTANEA )



    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

public class HorseEnemy
{
    //    ESCUDEIRO MONTADO//CAVALEIRO MONTADO
    //-HP:40//60
    //-ATK 30//50
    //-DEF 35//60
    //-DES 25//35
    //-VEL 30//35
    //-ITEM: POÇÃO MED E AMULETO DEF(+10 DEF 3X)
    //-WEAPON:LANÇA,MACHADO E ESPADA COMUM// GIGANTE
    //-HABILIDADE: MOVIMENTO +1//MOVIMENTO+2 E DEFENSOR(50% DE CHACE DE LEVAR O GOLPE DE OUTRO PERSONAGEM(1 VEZ NO TURNO))




    private static int HP;
    private static int MHP;
    private static int ATK;
    private static int DEF;
    private static int DES;
    private static int VEL;
    private static string WEAPON;
    private static string ITEM;
    private static string HAB;
    private static bool EVOL;

    public void setHP(int Val)
    {
        HP = Val;
    }
    public int getHP()
    {
        return HP;
    }
    public void setMHP(int Val)
    {
        MHP = Val;
    }
    public int getMHP()
    {
        return MHP;
    }
    public void setATK(int Val)
    {
        ATK = Val;
    }
    public int getATK()
    {
        return ATK;
    }

    public void setDEF(int Val)
    {
        DEF = Val;
    }
    public int getDEF()
    {
        return DEF;
    }

    public void setDES(int Val)
    {
        DES = Val;
    }
    public int getDES()
    {
        return DES;
    }

    public void setVEL(int Val)
    {
        VEL = Val;
    }
    public int getVEL()
    {
        return VEL;
    }

    public void setWEAPON(string Val)
    {
        WEAPON = Val;
    }
    public string getWEAPON()
    {
        return WEAPON;
    }

    public void setITEM(string Val)
    {
        ITEM = Val;
    }
    public string getITEM()
    {
        return ITEM;
    }

    public void setHAB(string Val)
    {
        HAB = Val;
    }
    public string getHAB()
    {
        return HAB;
    }

    public void setEVOL(bool Val)
    {
        EVOL = Val;
    }
    public bool getEVOL()
    {
        return EVOL;
    }
}

