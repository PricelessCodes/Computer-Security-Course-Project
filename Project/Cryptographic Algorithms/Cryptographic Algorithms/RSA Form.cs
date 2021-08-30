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
    public partial class RSA_Form : Form
    {
        public RSA_Form()
        {
            InitializeComponent();
            this.Load += new EventHandler(RSA_Form_Load);
        }

        void RSA_Form_Load(object sender, EventArgs e)
        {
            TextBox.Text = "We found golden statues and stones, so find an honest person to sell them for us";
            P_TextBox.Text = "97";
            Q_TextBox.Text = "89";
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            ulong P = 0, Q = 0, N = 0, PhiOfN = 0, E = 2, D = 0;

            //Large Prime Integer (P)
            if (!ulong.TryParse(P_TextBox.Text, out P))
            {
                MessageBox.Show("Insert Large Prime Integer (P)");
                return;
            }
            else
            {
                //Check if P is prime or not
                if (!isPrime(P))
                {
                    MessageBox.Show(P + " is not a Prime Integer");
                    return;
                }
            }
            //Large Prime Integer (Q)
            if (!ulong.TryParse(Q_TextBox.Text, out Q))
            {
                MessageBox.Show("Insert Large Prime Integer (Q)");
                return;
            }
            else
            {
                //Check if Q is prime or not
                if (!isPrime(Q))
                {
                    MessageBox.Show(P + " is not a Prime Integer");
                    return;
                }
            }
            RSA_Algorithm(P, Q, N, PhiOfN, E, D);
        }

        public void RSA_Algorithm(ulong P, ulong Q, ulong N, ulong PhiOfN, ulong E, ulong D)
        {
            //Generate Public encryption and Private Decryption keys
            GenerateKeys(P, Q, ref N, PhiOfN, ref E, ref D);
            //Check to Encrypt or Decrypt
            if (EncryptCheckBox.Checked)
            {
                ulong[] PlainTextInDecimal = null;
                //Encryption
                //Text to Decimal
                if (TextCheckBoxForText.Checked)
                {
                    PlainTextInDecimal = StringToDecimal(TextBox.Text);
                }//Binary to Decimal
                else if (BinaryCheckBoxForText.Checked)
                {
                    string[] SplitBinaryText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    PlainTextInDecimal = BinaryToDecimal(SplitBinaryText);
                }//Hex to Decimal
                else if (HexCheckBoxForText.Checked)
                {
                    string[] SplitHexText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    PlainTextInDecimal = HexToDecimal(SplitHexText);
                }//Decimal to Decimal
                else if (DecimalCheckBoxForText.Checked)
                {
                    string[] SplitDecimalText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    PlainTextInDecimal = new ulong[SplitDecimalText.Length];
                    for (int i = 0; i < SplitDecimalText.Length; i++)
                    {
                        PlainTextInDecimal[i] = Convert.ToUInt64(SplitDecimalText[i]);
                    }
                }//Error
                else
                {
                    MessageBox.Show("You did not choose the type of PlainText or PlainText is Wrong !!!");
                    return;
                }
                //Enctyption
                Encryption(PlainTextInDecimal, N, E);
            }
            else if (DecrypytCheckBox.Checked)
            {
                ulong[] CipherTextInDecimal = null;
                //Decryption
                //Text to Decimal
                if (TextCheckBoxForText.Checked)
                {
                    string SplitText = TextBox.Text.Replace(" ", "");
                    CipherTextInDecimal = StringToDecimal(SplitText);
                }//Binary to Decimal
                else if (BinaryCheckBoxForText.Checked)
                {
                    string[] SplitBinaryText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    CipherTextInDecimal = BinaryToDecimal(SplitBinaryText);
                }//Hex to Decimal
                else if (HexCheckBoxForText.Checked)
                {
                    string[] SplitHexText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    CipherTextInDecimal = HexToDecimal(SplitHexText);
                }//Decimal to Decimal
                else if (DecimalCheckBoxForText.Checked)
                {
                    string[] SplitDecimalText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    CipherTextInDecimal = new ulong[SplitDecimalText.Length];
                    for (int i = 0; i < SplitDecimalText.Length; i++)
                    {
                        CipherTextInDecimal[i] = Convert.ToUInt64(SplitDecimalText[i]);
                    }
                }//Error
                else
                {
                    MessageBox.Show("You did not choose the type of CipherText or CipherText is Wrong !!!");
                    return;
                }
                //Decryption
                Decryption(CipherTextInDecimal, N, D);
            }
            else
            {
                MessageBox.Show("You did not choose to Encrypt or Decrypt");
                return;
            }
        }

        public void GenerateKeys(ulong P, ulong Q, ref ulong N, ulong PhiOfN, ref ulong E, ref ulong D)
        {
            //Step 1: Generate Public Key
            //The First Part of the Public Key "System Modulus"
            N = P * Q;
            

            //Step 2: Generate Private Key  “Eular function”
            PhiOfN = (P - 1) * (Q - 1);
            //The Second Part of the Public Key is E (1 < E < PhiOfN)
            while (E < PhiOfN)
            {
                // e must be co-prime to phi and 
                // smaller than phi. 
                if (GCD(E, PhiOfN) == 1)
                    break;
                else
                    E++;
            }
            //Public Keys = (N, E)
            D = modInverse(E, PhiOfN);
            //Private Keys = (N, D)
        }

        public void Encryption(ulong[] PlainTextInDecimal, ulong N, ulong E)
        {
            //CipherText = Math.Pow(PlainText, E) % N;
            string CipherText = "";
            for (int i = 0; i < PlainTextInDecimal.Length; i++)
            {
                ulong Total = 1;
                for (ulong n = 0; n < E; n++)
                {
                    Total = (Total * PlainTextInDecimal[i]) % N;
                }
                if (TextCheckBoxForResult.Checked)
                    CipherText += DecimalToChar(Total) + " ";
                else if (BinaryCheckBoxForResult.Checked)
                    CipherText += DecimalToBinary(Total) + " ";
                else if (HexCheckBoxForResult.Checked)
                    CipherText += DecimalToHex(Total) + " ";
                else if (DecimalCheckBoxForResult.Checked)
                    CipherText += Total + " ";
                else
                {
                    MessageBox.Show("You did not choose the type of Result CipherText or Result is Wrong !!!");
                    return;
                }
            }
            ResultBox.Text = CipherText;
        }

        public void Decryption(ulong[] CipherTextInDecimal, ulong N, ulong D)
        {
            //PlaintText = Math.Pow(CipherText, D) % N;
            string PlainText = "";
            for (int i = 0; i < CipherTextInDecimal.Length; i++)
            {
                ulong Total = 1;
                for (ulong n = 0; n < D; n++)
                {
                    Total = (Total * CipherTextInDecimal[i]) % N;
                }
                if (TextCheckBoxForResult.Checked)
                    PlainText += DecimalToChar(Total);
                else if (BinaryCheckBoxForResult.Checked)
                    PlainText += DecimalToBinary(Total) + " ";
                else if (HexCheckBoxForResult.Checked)
                    PlainText += DecimalToHex(Total) + " ";
                else if (DecimalCheckBoxForResult.Checked)
                    PlainText += Total + " ";
                else
                {
                    MessageBox.Show("You did not choose the type of Result PlainText or Result is Wrong !!!");
                    return;
                }
                
            }
            ResultBox.Text = PlainText;
        }

        public ulong GCD(ulong a, ulong b)
        {
            ulong Reminder;
            while (b != 0)
            {
                Reminder = a % b;
                a = b;
                b = Reminder;
            }
            return a;
        }

        public ulong modInverse(ulong a, ulong m)
        {
            a = a % m;
            for (ulong x = 1; x < m; x++)
                if ((a * x) % m == 1)
                    return x;
            return 1;
        }

        public ulong[] StringToDecimal(string data)
        {
            ulong[] Total = new ulong[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                Total[i] = data[i];
            }
            return Total;
        }
        public string DecimalToString(ulong data)
        {
            return Convert.ToString(data);
        }

        public string DecimalToChar(ulong data)
        {
            return Convert.ToChar(data).ToString();
        }
        public ulong CharToDecimal(string data)
        {
            return Convert.ToUInt64(data);
        }

        public string DecimalToBinary(ulong data)
        {
            return Convert.ToString((long)data, 2);
        }
        public ulong[] BinaryToDecimal(string[] data)
        {
            ulong[] Total = new ulong[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                Total[i] = Convert.ToUInt64(data[i], 2);
            }

            return Total;
        }

        public ulong[] HexToDecimal(string[] data)
        {
            ulong[] Total = new ulong[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                Total[i] = Convert.ToUInt64(data[i], 16);
            }

            return Total;
        }
        public string DecimalToHex(ulong data)
        {
            return Convert.ToString((long)data, 16);
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

        /// <summary>
        /// Note: unneeded to be Explained
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //Text
        private void TextCheckBoxForText_CheckedChanged(object sender, EventArgs e)
        {
            if (TextCheckBoxForText.Checked)
            {
                BinaryCheckBoxForText.Checked = false;
                HexCheckBoxForText.Checked = false;
                DecimalCheckBoxForText.Checked = false;
            }
        }
        private void BinaryCheckBoxForText_CheckedChanged(object sender, EventArgs e)
        {
            if (BinaryCheckBoxForText.Checked)
            {
                TextCheckBoxForText.Checked = false;
                HexCheckBoxForText.Checked = false;
                DecimalCheckBoxForText.Checked = false;
            }
        }
        private void HexCheckBoxForText_CheckedChanged(object sender, EventArgs e)
        {
            if (HexCheckBoxForText.Checked)
            {
                TextCheckBoxForText.Checked = false;
                BinaryCheckBoxForText.Checked = false;
                DecimalCheckBoxForText.Checked = false;
            }
        }
        private void DecimalCheckBoxForText_CheckedChanged(object sender, EventArgs e)
        {
            if (DecimalCheckBoxForText.Checked)
            {
                TextCheckBoxForText.Checked = false;
                BinaryCheckBoxForText.Checked = false;
                HexCheckBoxForText.Checked = false;
            }
        }
        //En/Decrypt
        private void EncryptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EncryptCheckBox.Checked)
            {
                DecrypytCheckBox.Checked = false;
            }
        }
        private void DecrypytCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DecrypytCheckBox.Checked)
            {
                EncryptCheckBox.Checked = false;
            }
        }
        //Result
        private void TextCheckBoxForResult_CheckedChanged(object sender, EventArgs e)
        {
            if (TextCheckBoxForResult.Checked)
            {
                BinaryCheckBoxForResult.Checked = false;
                HexCheckBoxForResult.Checked = false;
                DecimalCheckBoxForResult.Checked = false;
            }
        }
        private void BinaryCheckBoxForResult_CheckedChanged(object sender, EventArgs e)
        {
            if (BinaryCheckBoxForResult.Checked)
            {
                TextCheckBoxForResult.Checked = false;
                HexCheckBoxForResult.Checked = false;
                DecimalCheckBoxForResult.Checked = false;
            }
        }
        private void HexCheckBoxForResult_CheckedChanged(object sender, EventArgs e)
        {
            if (HexCheckBoxForResult.Checked)
            {
                TextCheckBoxForResult.Checked = false;
                BinaryCheckBoxForResult.Checked = false;
                DecimalCheckBoxForResult.Checked = false;
            }
        }
        private void DecimalCheckBoxForResult_CheckedChanged(object sender, EventArgs e)
        {
            if (DecimalCheckBoxForResult.Checked)
            {
                TextCheckBoxForResult.Checked = false;
                BinaryCheckBoxForResult.Checked = false;
                HexCheckBoxForResult.Checked = false;
            }
        }
    }
}
