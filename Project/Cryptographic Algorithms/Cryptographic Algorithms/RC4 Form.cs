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
    public partial class RC4_Form : Form
    {
        public RC4_Form()
        {
            InitializeComponent();
            this.Load += new EventHandler(RC4_Form_Load);
        }

        void RC4_Form_Load(object sender, EventArgs e)
        {
            TextBox.Text = "The quick brown fox jumps over the lazy dog.";
            KeyTextBox.Text = "63 72 79 70 74 69 69";
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            //Initialize
            ulong[] PlainTextInDecimal = null;
            ulong[] CipherTextInDecimal = null;
            ulong[] Key = null;
            ulong[] S = new ulong[256];
            ulong[] T = new ulong[256];
            //Check to Encrypt or Decrypt
            if (EncryptCheckBox.Checked)
            {
                //Plaint Text
                //Text
                if (TextCheckBoxForText.Checked)
                {
                    PlainTextInDecimal = StringToDecimal(TextBox.Text);
                }//Binary
                else if (BinaryCheckBoxForText.Checked)
                {
                    string[] SplitBinaryText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    PlainTextInDecimal = BinaryToDecimal(SplitBinaryText);
                }//Hex
                else if (HexCheckBoxForText.Checked)
                {
                    string[] SplitHexText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    PlainTextInDecimal = HexToDecimal(SplitHexText);
                }//Decimal
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
                    MessageBox.Show("You did not choose the type of the 'PlainText' !!!");
                    return;
                }
                //Key
                //Binary
                if (BinaryCheckBoxForKey.Checked)
                {
                    string[] SplitBinaryKey = KeyTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Key = BinaryToDecimal(SplitBinaryKey);
                }//Hex
                else if (HexCheckBoxForKey.Checked)
                {
                    string[] SplitHexKey = KeyTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Key = HexToDecimal(SplitHexKey);
                }
                //Decncrypt
                RC4_Algorithm(PlainTextInDecimal, Key, S, T);
                
            }
            else if (DecrypytCheckBox.Checked)
            {
                //Cipher Text
                //Text
                if (TextCheckBoxForText.Checked)
                {
                    CipherTextInDecimal = StringToDecimal(TextBox.Text);
                }//Binary
                else if (BinaryCheckBoxForText.Checked)
                {
                    string[] SplitBinaryText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    CipherTextInDecimal = BinaryToDecimal(SplitBinaryText);
                }//Hex
                else if (HexCheckBoxForText.Checked)
                {
                    string[] SplitHexText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    CipherTextInDecimal = HexToDecimal(SplitHexText);
                }//Decimal
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
                    MessageBox.Show("You did not choose the type of the 'CipherText' !!!");
                    return;
                }
                //Key
                //Binary
                if (BinaryCheckBoxForKey.Checked)
                {
                    string[] SplitBinaryKey = KeyTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Key = BinaryToDecimal(SplitBinaryKey);
                }//Hex
                else if (HexCheckBoxForKey.Checked)
                {
                    string[] SplitHexKey = KeyTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Key = HexToDecimal(SplitHexKey);
                }//Error
                else
                {
                    MessageBox.Show("You did not choose the type of the 'Key'!!!");
                    return;
                }
                //Encrypt
                RC4_Algorithm(CipherTextInDecimal, Key, S, T);
            }
            else
            {
                MessageBox.Show("You did not choose to Encrypt or Decrypt !!!");
                return;
            }
        }

        public void RC4_Algorithm(ulong[] Text, ulong[] Key, ulong[] S, ulong[] T)
        {
            //Step 1: Generate State Vector S[] and Temporary Vector T[]
            Generate_SandT(ref S, ref T, Key);

            //Step 2: Initial Permutation On S[]
            Initial_Permutation(ref S, ref T);
            
            //Step 3: Encryption Or Decryption
            En_Decryption(Text, S, T);
        }
        
        public void Generate_SandT(ref ulong[] S, ref ulong[] T, ulong[] Key)
        {
            //Generating State Vector
            for (ulong i = 0; i < 256; i++)
            {
                S[i] = i;
                T[i] = Key[i % Convert.ToUInt64(Key.Length)];
            }
        }

        public void Initial_Permutation(ref ulong[] S, ref ulong[] T)
        {
            ulong j = 0;
            for (ulong i = 0; i < 256; i++)
            {
                j = (j + S[i] + T[i]) % 256;
                ulong Swap = S[i];
                S[i] = S[j];
                S[j] = Swap;
            }
        }

        public void En_Decryption(ulong[] InputTextInDecimal, ulong[] S, ulong[] T)
        {
            ulong i = 0, j = 0;
            int TextIndex = 0;
            string ResultTextAsString = "";
            while (TextIndex < InputTextInDecimal.Length)
            {
                i = (i + 1) % 256;
                j = (j + S[i]) % 256;

                ulong Swap = S[i];
                S[i] = S[j];
                S[j] = Swap;

                ulong t = (S[i] + S[j]) % 256;

                ulong K = S[t];
                //Xor
                ulong ResultTextInDecimal = K ^ InputTextInDecimal[TextIndex];

                if (EncryptCheckBox.Checked)
                {
                    if (TextCheckBoxForResult.Checked)
                        ResultTextAsString += DecimalToChar(ResultTextInDecimal);
                    else if (BinaryCheckBoxForResult.Checked)
                        ResultTextAsString += DecimalToBinary(ResultTextInDecimal).PadLeft(8, '0') + " ";
                    else if (HexCheckBoxForResult.Checked)
                        ResultTextAsString += DecimalToHex(ResultTextInDecimal) + " ";
                    else if (DecimalCheckBoxForResult.Checked)
                        ResultTextAsString += ResultTextInDecimal + " ";
                    else
                    {
                        MessageBox.Show("You did not choose the type of Result or Result is Wrong !!!");
                        return;
                    }
                }
                else if (DecrypytCheckBox.Checked)
                {
                    if (TextCheckBoxForResult.Checked)
                        ResultTextAsString += DecimalToChar(ResultTextInDecimal);
                    else if (BinaryCheckBoxForResult.Checked)
                        ResultTextAsString += DecimalToBinary(ResultTextInDecimal).PadLeft(8, '0') + " ";
                    else if (HexCheckBoxForResult.Checked)
                        ResultTextAsString += DecimalToHex(ResultTextInDecimal) + " ";
                    else if (DecimalCheckBoxForResult.Checked)
                        ResultTextAsString += ResultTextInDecimal + " ";
                    else
                    {
                        MessageBox.Show("You did not choose the type of Result or Result is Wrong !!!");
                        return;
                    }
                }
                TextIndex++;
            }
            ResultBox.Text = ResultTextAsString;
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
            return Convert.ToUInt64(Convert.ToChar(data));
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
        //Key
        private void BinaryCheckBoxForKey_CheckedChanged(object sender, EventArgs e)
        {
            if (BinaryCheckBoxForKey.Checked)
            {
                HexCheckBoxForKey.Checked = false;
            }
        }
        private void HexCheckBoxForKey_CheckedChanged(object sender, EventArgs e)
        {
            if (HexCheckBoxForKey.Checked)
            {
                BinaryCheckBoxForKey.Checked = false;
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
