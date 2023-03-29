using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unitTestSeSuchem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public static string jmeno = "";
        public static string specializace = "";

        public static string GetName(string jmeno)
        {
            return jmeno; 
        }

        public static bool GetSpecialziation(string specializace)
        {
            string[] pole = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
            if (pole.Contains(specializace)) return true;
            return false;
        }
        public static bool GetFace(string face)
        {
            string[] pole = { "velký nos", "ušoplesk", "make-up" };
            if (pole.Contains(face)) return true;
            return false;
        }
        public static bool GetHair(string hair)
        {
            string[] pole = { "drdol", "culík", "pleška" };
            if (pole.Contains(hair)) return true;
            return false;
        }
        public static bool GetHairColour(string colour)
        {
            string[] pole = { "kaštanová", "blond", "červená" };
            if (pole.Contains(colour)) return true;
            return false;
        }

        public static bool GetJob(string job)
        {
            string[] pole = { "obchodník", "nepřítel", "obyvatel" };
            if (pole.Contains(job)) return true;
            return false;
        }

        public static string GetBoss(string jeboss)
        {            
            return jeboss;
        }
        public static int GetX(int x)
        {
            return x;
        }
        public static int GetY(int y)
        {
            return y;
        }
       
        public static int GetLevel(int level)
        {
            return level;
        }
        public static int GetXP(int xp)
        {
            return xp;
        }

    }
}
