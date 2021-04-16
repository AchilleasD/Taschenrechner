using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        int weiter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e) 
        {
            if (Ergebnis.Text.Length != 0)
            {
                Ergebnis.Text = Ergebnis.Text.Remove(Ergebnis.Text.Length - 1, 1);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Die folgende if Anwendung ist bei jeder Zahl,
            //um das vorherige Ergebnis zu löschen und weiter zu machen
            if (weiter == 1) 
            {
                weiter = 0;
                Ergebnis.Text = "";
            }
                Ergebnis.Text = Ergebnis.Text + "1";


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (weiter == 1)
            {
                weiter = 0;
                Ergebnis.Text = "";
            }
            Ergebnis.Text = Ergebnis.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (weiter == 1)
            {
                weiter = 0;
                Ergebnis.Text = "";
            }
            Ergebnis.Text = Ergebnis.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (weiter == 1)
            {
                weiter = 0;
                Ergebnis.Text = "";
            }
            Ergebnis.Text = Ergebnis.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (weiter == 1)
            {
                weiter = 0;
                Ergebnis.Text = "";
            }
            Ergebnis.Text = Ergebnis.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (weiter == 1)
            {
                weiter = 0;
                Ergebnis.Text = "";
            }
            Ergebnis.Text = Ergebnis.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (weiter == 1)
            {
                weiter = 0;
                Ergebnis.Text = "";
            }
            Ergebnis.Text = Ergebnis.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (weiter == 1)
            {
                weiter = 0;
                Ergebnis.Text = "";
            }
            Ergebnis.Text = Ergebnis.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (weiter == 1)
            {
                weiter = 0;
                Ergebnis.Text = "";
            }
            Ergebnis.Text = Ergebnis.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (weiter == 1)
            {
                weiter = 0;
                Ergebnis.Text = "";
            }
            Ergebnis.Text = Ergebnis.Text + "0";
        }

        private void btnMultiplikation_Click(object sender, EventArgs e)
        {   
            //Bei den Rechenzeichen ist die if Frage nach "weiter" nicht, um mit dem Ergebnis
            // weiter zu rechnen
            Ergebnis.Text = Ergebnis.Text + "*";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            Ergebnis.Text = Ergebnis.Text + "+";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Ergebnis.Text = Ergebnis.Text + "/";
        }

        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            Ergebnis.Text = Ergebnis.Text + "-";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Ergebnis.Text = Ergebnis.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            try
            {   //weil es in C# kein eval gibt wie ich nach Recherche z.B. bei Java gefunden habe
                // konvertiere ich das Ergebnis hier mit einem DataTable zu einer Rechnung
                DataTable dtErgebnis = new DataTable();
                var v = dtErgebnis.Compute(Ergebnis.Text, "");
                Ergebnis.Text = Convert.ToString(v);
                weiter = 1;
            }
            catch(Exception fehler)
            {   //Try/ Catch zur Sicherheit falls jemand zum Beispiel
                Ergebnis.Text = fehler.Message;
                weiter = 1;
            }


        }


    }
}
