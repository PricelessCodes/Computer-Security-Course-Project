using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cryptographic_Algorithms
{
    public partial class Diffie_Hellman_Form : Form
    {
        public Diffie_Hellman_Form()
        {
            InitializeComponent();
            this.Load += new EventHandler(Diffie_Hellman_Form_Load);
        }

        void Diffie_Hellman_Form_Load(object sender, EventArgs e)
        {
            q_TextBox.Text = "353";
            a_TextBox.Text = "3";
            XA_TextBox.Text = "97";
            XB_TextBox.Text = "233";

        }

        private void Diffie_Button_Click(object sender, EventArgs e)
        {
            //Step 1:
            //Large Prime Integer
            ulong q;
            if (!ulong.TryParse(q_TextBox.Text, out q))
            {
                MessageBox.Show("Insert Large Prime Integer");
                return;
            }
            else
            {
                if (!isPrime(q))
                {
                    MessageBox.Show(q + " is not a Prime Integer");
                    return;
                }
            }
            //being a primitive root mod q
            //for n=1 to q-1
            //  a^n mod q = [1 to q-1]
            ulong a;
            if (!ulong.TryParse(a_TextBox.Text, out a))
            {
                MessageBox.Show("Insert Primitive Root Integer");
                return;
            }
            else
            {
                //Check if a is primitive root to q or not
                if (!isPrimitive(a, q))
                {
                    MessageBox.Show(q + " is not a Primitive root");
                    return;
                }
            }
            //Step 2:
            //Secret Key < q for user A and user B
            ulong XA;
            ulong XB;
            if (!ulong.TryParse(XA_TextBox.Text, out XA))
            {
                MessageBox.Show("Insert Secret Key for User A");
                return;
            }
            else
            {
                if (XA >= q)
                {
                    MessageBox.Show("Insert Secret Key for User A (XA) Less than the Large Prime Integer (q)");
                    return;
                }
            }
            if (!ulong.TryParse(XB_TextBox.Text, out XB))
            {
                MessageBox.Show("Insert Secret Key for User B (XB)");
                return;
            }
            else
            {
                if (XB >= q)
                {
                    MessageBox.Show("Insert Secret Key for User B (XB) Less than the Large Prime Integer (q)");
                    return;
                }
            }
            //Step 3:
            //Public Keys for user A and user B
            ulong YA = 1, YB = 1;
            for (ulong n = 0; n < XA; n++)
            {
                YA = (YA * a) % q;
            }
            YA_TextBox.Text = YA.ToString();
            for (ulong n = 0; n < XB; n++)
            {
                YB = (YB * a) % q;
            }
            YB_TextBox.Text = YB.ToString();
            //Step 4: Share Public Keys

            //Step 5: Private Key
            //KAB = a^(XA.XB) mod q
            //    = yA^xB mod q  = (a^xA mod q)^xB (which B can compute ) 
            //    = yB^xA mod q =  (a^xB mod q)^xA   (which A can compute)
            //KAB = KA = KB
            ulong KA = 1, KB = 1;
            //Private key for user A
            for (ulong n = 0; n < XA; n++)
            {
                KA = (KA * YB) % q;
            }
            //Private key for user B
            for (ulong n = 0; n < XB; n++)
            {
                KB = (KB * YA) % q;
            }//Private key for user A must be equal to Private key for user B
            if (KA == KB)
            {
                KAB_TextBox.Text = KA.ToString();
            }//Error
            else
            {
                MessageBox.Show("Error Try agian !!!");
                return;
            }
        }

        public bool isPrime(ulong n)
        {
            // Corner case 
            if (n <= 1)
                return false;

            // Check from 2 to n-1 
            for (ulong i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        public bool isPrimitive(ulong a, ulong q)
        {
            ulong Total = 1;
            ulong[] sort = new ulong[q - 1];
            for (ulong n = 0; n < q - 1; n++)
            {
                Total = (Total * a) % q;
                sort[n] = Total;
            }
            Array.Sort(sort);
            for (int n = 0; n < sort.Length; n++)
            {
                if (sort[n] != Convert.ToUInt64(n) + 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
