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
    public partial class ELGamal_Form : Form
    {
        public ELGamal_Form()
        {
            InitializeComponent();
            this.Load += new EventHandler(ELGamal_Form_Load);
        }

        void ELGamal_Form_Load(object sender, EventArgs e)
        {
            PlainTextBox.Text = "Computer Security is Important.";
            q_TextBox.Text = "1613";
            a_TextBox.Text = "1119";
            XA_TextBox.Text = "1229";
        }

        private void Encryption_Button_Click(object sender, EventArgs e)
        {
            int q = 0, a = 0, XA = 0, YA = 0, C1 = 1;
            int[] C2 = null;
            //Keys Generation by user A
            bool isReady = UserA_GenerateKeys(ref q, ref a, ref XA, ref YA);

            if (isReady)
            {
                int[] PlainTextInDecimal = null;
                //Text to Decimal
                if (TextCheckBoxForTextEncryption.Checked)
                {
                    PlainTextInDecimal = StringToDecimal(PlainTextBox.Text);
                }//Binary to Decimal
                else if (BinaryCheckBoxForTextEncryption.Checked)
                {
                    string[] SplitBinaryText = PlainTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    PlainTextInDecimal = BinaryToDecimal(SplitBinaryText);
                }//Hex to Decimal
                else if (HexCheckBoxForTextEncryption.Checked)
                {
                    string[] SplitHexText = PlainTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    PlainTextInDecimal = HexToDecimal(SplitHexText);
                }//Decimal to Decimal
                else if (DecimalCheckBoxForTextEncryption.Checked)
                {
                    string[] SplitDecimalText = PlainTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    PlainTextInDecimal = new int[SplitDecimalText.Length];
                    for (int i = 0; i < SplitDecimalText.Length; i++)
                    {
                        PlainTextInDecimal[i] = Convert.ToInt32(SplitDecimalText[i]);
                    }
                }//Error
                else
                {
                    MessageBox.Show("You did not choose the type of PlainText or PlainText is Wrong !!!");
                    return;
                }
                //Encryption
                Encryption(YA, q, a, PlainTextInDecimal, ref C1, ref C2);
            }
        }

        public bool UserA_GenerateKeys(ref int q, ref int a, ref int XA, ref int YA)
        {
            //Step 1:
            //Large Prime Integer
            if (!int.TryParse(q_TextBox.Text, out q))
            {
                MessageBox.Show("Insert Large Prime Integer (q)");
                return false;
            }
            else
            {
                if (!isPrime(q))
                {
                    MessageBox.Show(q + " is not a Prime Integer");
                    return false;
                }
            }
            //being a primitive root mod q
            //for n=1 to q-1
            //  a^n mod q = [1 to q-1]
            if (!int.TryParse(a_TextBox.Text, out a))
            {
                MessageBox.Show("Insert a Primitive root (a)");
                return false;
            }
            else
            {
                if (!isPrimitive(a, q))
                {
                    MessageBox.Show(a + " is not a Primitive root");
                    return false;
                }
            }

            //Step 2:
            // we have 2 users A & B
            //User A Select Secret Key ( 1 < XA < q - 1)
            if (!int.TryParse(XA_TextBox.Text, out XA))
            {
                MessageBox.Show("Insert Secret Key for User A");
                return false;
            }
            else
            {
                if (!(1 < XA && XA < q - 1))
                {
                    MessageBox.Show("Insert Secret Key for User A Less than the Large Prime Integer (q)");
                    return false;
                }
            }
            //Step 3:
            //User A Compute Public Key
            YA = 1;
            for (int n = 0; n < XA; n++)
            {
                YA = (YA * a) % q;
            }
            return true;
        }

        public void Encryption(int YA, int q, int a, int[] PlainTextInDecimal, ref int C1, ref int[] C2)
        {
            //Step 3:
            //User B select random inter k (1 <= k < q)
            Random R = new Random();
            int k = R.Next(1, Convert.ToInt32(q));
            k = 7;
            //User B compute one-time Key K = YA^k mod q
            int K = 1;
            for (int n = 0; n < k; n++)
            {
                K = (K * YA) % q;
            }
            //User B compute C1 and C2
            //C1 = a^k mod q
            string CipherText = "";// " CipherText = ( ";
            for (int n = 0; n < k; n++)
            {
                C1 = (C1 * a) % q;
            }
            if (TextCheckBoxForResultEncryption.Checked)
                CipherText += DecimalToChar(C1) + " ";
            else if (BinaryCheckBoxForResultEncryption.Checked)
                CipherText += DecimalToBinary(C1) + " ";
            else if (HexCheckBoxForResultEncryption.Checked)
                CipherText += DecimalToHex(C1) + " ";
            else if (DecimalCheckBoxForResultEncryption.Checked)
                CipherText += C1 + " ";
            else
            {
                MessageBox.Show("You did not choose the type of Result CipherText or Result is Wrong !!!");
                return;
            }
            //C2 = KM mod q
            C2 = new int[PlainTextInDecimal.Length];
            for (int i = 0; i < PlainTextInDecimal.Length; i++)
            {

                C2[i] = (K * PlainTextInDecimal[i]) % q;
                if (TextCheckBoxForResultEncryption.Checked)
                    CipherText += DecimalToChar(C2[i]) + " ";
                else if (BinaryCheckBoxForResultEncryption.Checked)
                    CipherText += DecimalToBinary(C2[i]) + " ";
                else if (HexCheckBoxForResultEncryption.Checked)
                    CipherText += DecimalToHex(C2[i]) + " ";
                else if (DecimalCheckBoxForResultEncryption.Checked)
                    CipherText += C2[i] + " ";
                else
                {
                    MessageBox.Show("You did not choose the type of Result CipherText or Result is Wrong !!!");
                    return;
                }
            }
           // CipherText += ")";
            EncryptResultTextBox.Text = CipherText;

            //User B sends (C1, C2) to User A (returned by reference)
        }

        public void Decryption_Button_Click(object sender, EventArgs e)
        {
            int q = 0, XA = 0, C1 = 1;
            int[] C2 = null;

            //Step 1:
            //Large Prime Integer
            if (!int.TryParse(q_TextBox2.Text, out q))
            {
                MessageBox.Show("Insert Large Prime Integer");
                return;
            }
            else
            {
                if (!isPrime(q))
                {
                    MessageBox.Show("Insert a Prime Integer");
                    return;
                }
            }
            //Step 2:
            // we have 2 users A & B
            //User A Select Secret Key ( 1 < XA < q - 1)
            if (!int.TryParse(XA_TextBox2.Text, out XA))
            {
                MessageBox.Show("Insert Secret Key for User A");
                return;
            }
            else
            {
                if (!(1 < XA && XA < q - 1))
                {
                    MessageBox.Show("Insert Secret Key for User A Less than the Large Prime Integer");
                    return;
                }
            }
            int[] CipherTextInDecimal = null;
            //Text to Decimal
            if (TextCheckBoxForTextDecryption.Checked)
            {
                string[] SplitText = CipherTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                CipherTextInDecimal = new int[SplitText.Length];
                for (int i = 0; i < SplitText.Length; i++)
                {
                    CipherTextInDecimal[i] = CharToDecimal(SplitText[i]);
                }
            }//Binary to Decimal
            else if (BinaryCheckBoxForTextDecryption.Checked)
            {
                string[] SplitBinaryText = CipherTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                CipherTextInDecimal = BinaryToDecimal(SplitBinaryText);
            }//Hex to Decimal
            else if (HexCheckBoxForTextDecryption.Checked)
            {
                string[] SplitHexText = CipherTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                CipherTextInDecimal = HexToDecimal(SplitHexText);
            }//Decimal to Decimal
            else if (DecimalCheckBoxForTextDecryption.Checked)
            {
                string[] SplitDecimalText = CipherTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                CipherTextInDecimal = new int[SplitDecimalText.Length];
                for (int i = 0; i < SplitDecimalText.Length; i++)
                {
                    CipherTextInDecimal[i] = Convert.ToInt32(SplitDecimalText[i]);
                }
            }//Error
            else
            {
                MessageBox.Show("You did not choose the type of CipherText or CipherText is Wrong !!!");
                return;
            }
            //Inserted CipherText (C1, C2)
            // C1
            C1 = CipherTextInDecimal[0];
            //C2
            C2 = new int[CipherTextInDecimal.Length - 1];
            for (int i = 1; i < CipherTextInDecimal.Length; i++)
            {
                C2[i - 1] = Convert.ToInt32(CipherTextInDecimal[i]);
            }
            //Decryption
            Decryption(C1, C2, XA, q);
        }

        public void Decryption( int C1, int[] C2, int XA, int q)
        {
            //Calculate K = C1^XA mod q
            int K = 1;
            for (int n = 0; n < XA; n++)
            {
                K = (K * C1) % q;
            }
            //Calculate K inverse (K^-1)
            int InversedK = modInverse(K, q);
            string PlainText = "";
            int Total = 0;
            //Calculate Plain Text
            for (int i = 0; i < C2.Length; i++)
            {
                Total = (C2[i] * InversedK) % q;
                if (TextCheckBoxForResultDecryption.Checked)
                    PlainText += DecimalToChar(Total);
                else if (BinaryCheckBoxForResultDecryption.Checked)
                    PlainText += DecimalToBinary(Total) + " ";
                else if (HexCheckBoxForResultDecryption.Checked)
                    PlainText += DecimalToHex(Total) + " ";
                else if (DecimalCheckBoxForResultDecryption.Checked)
                    PlainText += Total + " ";
                else
                {
                    MessageBox.Show("You did not choose the type of Result PlainText or Result is Wrong !!!");
                    return;
                }
            }
            DecryptResultTextBox.Text = PlainText;

        }

        public int modInverse(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
                if ((a * x) % m == 1)
                    return x;
            return 1;
        }

        public int GCD(int a, int b)
        {
            int Reminder;
            while (b != 0)
            {
                Reminder = a % b;
                a = b;
                b = Reminder;
            }
            return a;
        }

        public bool isPrime(int n)
        {
            // Corner case 
            if (n <= 1)
                return false;

            // Check from 2 to n-1 
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        public bool isPrimitive(int a, int q)
        {
            int Total = 1;
            int[] sort = new int[q - 1];
            for (int n = 0; n < q - 1; n++)
            {
                Total = (Total * a) % q;
                sort[n] = Total;
            }
            Array.Sort(sort);
            for (int n = 0; n < sort.Length; n++)
            {
                if (sort[n] != n + 1)
                {
                    return false;
                }
            }
            return true;
        }

        public int[] StringToDecimal(string data)
        {
            int[] Total = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                Total[i] = data[i];
            }
            return Total;
        }
        public string DecimalToString(int data)
        {
            return Convert.ToString(data);
        }

        public string DecimalToChar(int data)
        {
            return Convert.ToChar(data).ToString();
        }
        public int CharToDecimal(string data)
        {
            return Convert.ToInt32(Convert.ToChar(data));
        }

        public string DecimalToBinary(int data)
        {
            return Convert.ToString((long)data, 2);
        }
        public int[] BinaryToDecimal(string[] data)
        {
            int[] Total = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                Total[i] = Convert.ToInt32(data[i], 2);
            }

            return Total;
        }

        public int[] HexToDecimal(string[] data)
        {
            int[] Total = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                Total[i] = Convert.ToInt32(data[i], 16);
            }

            return Total;
        }
        public string DecimalToHex(int data)
        {
            return Convert.ToString((long)data, 16);
        }

        /// <summary>
        /// Note: unneeded to be Explained
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //Encryption
        //Text
        private void TextCheckBoxForTextEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (TextCheckBoxForTextEncryption.Checked)
            {
                BinaryCheckBoxForTextEncryption.Checked = false;
                HexCheckBoxForTextEncryption.Checked = false;
                DecimalCheckBoxForTextEncryption.Checked = false;
            }
        }
        private void BinaryCheckBoxForTextEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (BinaryCheckBoxForTextEncryption.Checked)
            {
                TextCheckBoxForTextEncryption.Checked = false;
                HexCheckBoxForTextEncryption.Checked = false;
                DecimalCheckBoxForTextEncryption.Checked = false;
            }
        }
        private void HexCheckBoxForTextEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (HexCheckBoxForTextEncryption.Checked)
            {
                TextCheckBoxForTextEncryption.Checked = false;
                BinaryCheckBoxForTextEncryption.Checked = false;
                DecimalCheckBoxForTextEncryption.Checked = false;
            }
        }
        private void DecimalCheckBoxForTextEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (DecimalCheckBoxForTextEncryption.Checked)
            {
                TextCheckBoxForTextEncryption.Checked = false;
                BinaryCheckBoxForTextEncryption.Checked = false;
                HexCheckBoxForTextEncryption.Checked = false;
            }
        }
        //Result
        private void TextCheckBoxForResultEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (TextCheckBoxForResultEncryption.Checked)
            {
                BinaryCheckBoxForResultEncryption.Checked = false;
                HexCheckBoxForResultEncryption.Checked = false;
                DecimalCheckBoxForResultEncryption.Checked = false;
            }
        }
        private void BinaryCheckBoxForResultEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (BinaryCheckBoxForResultEncryption.Checked)
            {
                TextCheckBoxForResultEncryption.Checked = false;
                HexCheckBoxForResultEncryption.Checked = false;
                DecimalCheckBoxForResultEncryption.Checked = false;
            }
        }
        private void HexCheckBoxForResultEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (HexCheckBoxForResultEncryption.Checked)
            {
                TextCheckBoxForResultEncryption.Checked = false;
                BinaryCheckBoxForResultEncryption.Checked = false;
                DecimalCheckBoxForResultEncryption.Checked = false;
            }
        }
        private void DecimalCheckBoxForResultEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (DecimalCheckBoxForResultEncryption.Checked)
            {
                TextCheckBoxForResultEncryption.Checked = false;
                BinaryCheckBoxForResultEncryption.Checked = false;
                HexCheckBoxForResultEncryption.Checked = false;
            }
        }
        //Decryption
        //Text
        private void TextCheckBoxForTextDecryption_CheckedChanged(object sender, EventArgs e)
        {
            if (TextCheckBoxForTextDecryption.Checked)
            {
                BinaryCheckBoxForTextDecryption.Checked = false;
                HexCheckBoxForTextDecryption.Checked = false;
                DecimalCheckBoxForTextDecryption.Checked = false;
            }
        }
        private void BinaryCheckBoxForTextDecryption_CheckedChanged(object sender, EventArgs e)
        {
            if (BinaryCheckBoxForTextDecryption.Checked)
            {
                TextCheckBoxForTextDecryption.Checked = false;
                HexCheckBoxForTextDecryption.Checked = false;
                DecimalCheckBoxForTextDecryption.Checked = false;
            }
        }
        private void HexCheckBoxForTextDecryption_CheckedChanged(object sender, EventArgs e)
        {
            if (HexCheckBoxForTextDecryption.Checked)
            {
                TextCheckBoxForTextDecryption.Checked = false;
                BinaryCheckBoxForTextDecryption.Checked = false;
                DecimalCheckBoxForTextDecryption.Checked = false;
            }
        }
        private void DecimalCheckBoxForTextDecryption_CheckedChanged(object sender, EventArgs e)
        {
            if (DecimalCheckBoxForTextDecryption.Checked)
            {
                TextCheckBoxForTextDecryption.Checked = false;
                BinaryCheckBoxForTextDecryption.Checked = false;
                HexCheckBoxForTextDecryption.Checked = false;
            }
        }
        //Result
        private void TextCheckBoxForResultDecryption_CheckedChanged(object sender, EventArgs e)
        {
            if (TextCheckBoxForResultDecryption.Checked)
            {
                BinaryCheckBoxForResultDecryption.Checked = false;
                HexCheckBoxForResultDecryption.Checked = false;
                DecimalCheckBoxForResultDecryption.Checked = false;
            }
        }
        private void BinaryCheckBoxForResultDecryption_CheckedChanged(object sender, EventArgs e)
        {
            if (BinaryCheckBoxForResultDecryption.Checked)
            {
                TextCheckBoxForResultDecryption.Checked = false;
                HexCheckBoxForResultDecryption.Checked = false;
                DecimalCheckBoxForResultDecryption.Checked = false;
            }
        }
        private void HexCheckBoxForResultDecryption_CheckedChanged(object sender, EventArgs e)
        {
            if (HexCheckBoxForResultDecryption.Checked)
            {
                TextCheckBoxForResultDecryption.Checked = false;
                BinaryCheckBoxForResultDecryption.Checked = false;
                DecimalCheckBoxForResultDecryption.Checked = false;
            }
        }
        private void DecimalCheckBoxForResultDecryption_CheckedChanged(object sender, EventArgs e)
        {
            if (DecimalCheckBoxForResultDecryption.Checked)
            {
                TextCheckBoxForResultDecryption.Checked = false;
                BinaryCheckBoxForResultDecryption.Checked = false;
                HexCheckBoxForResultDecryption.Checked = false;
            }
        }
    }
}
