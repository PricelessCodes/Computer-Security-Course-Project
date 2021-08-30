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
    public partial class S_DES_Form : Form
    {
        public S_DES_Form()
        {
            InitializeComponent();
            this.Load += new EventHandler(S_DES_Form_Load);
        }

        void S_DES_Form_Load(object sender, EventArgs e)
        {
            TextBox.Text = "Hitler attacked russia.";
            KeyTextBox.Text = "1010011010";
        }

        private void En_Decryption_Button_Click(object sender, EventArgs e)
        {
            S_DES_Algorithm();
        }

        public void S_DES_Algorithm()
        {
            //initialize
            string Key = null;
            string K1 = null;
            string K2 = null;

            int[] P10 = { 3, 5, 2, 7, 4, 10, 1, 9, 8, 6 };
            int[] P8 = { 6, 3, 7, 4, 8, 5, 10, 9 };
            int[] IP = { 2, 6, 3, 1, 4, 8, 5, 7 };
            int[] EP = { 4, 1, 2, 3, 2, 3, 4, 1 };
            int[] P4 = { 2, 4, 3, 1 };
            int[,] S0 = {
                            {1, 0, 3, 2},
                            {3, 2, 1, 0},
                            {0, 2, 1, 3},
                            {3, 1, 3, 2},
                        };
            int[,] S1 = {
                            {0, 1, 2, 3},
                            {2, 0, 1, 3},
                            {3, 0, 1, 0},
                            {2, 1, 0, 3},
                        };
            //Step 1: Key Generation
            Key = KeyTextBox.Text;
            K1 = Key;
            K2 = Key;
            Key_Generation(ref K1, ref K2, P10, P8);
            //Check Encrypt or Decrypt
            if (EncryptCheckBox.Checked)
            {
                //Step 2.0: Convert Text
                string[] BinaryPlainText = null;
                //Text
                if (TextCheckBoxForText.Checked)
                {
                    BinaryPlainText = new string[TextBox.TextLength];
                    for (int i = 0; i < TextBox.TextLength; i++)
                    {
                        BinaryPlainText[i] = CharToBinary(TextBox.Text[i].ToString());
                    }
                }//Binary
                else if (BinaryCheckBoxForText.Checked)
                {
                    string[] SplitBinaryPlainText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    BinaryPlainText = SplitBinaryPlainText;
                }//Hex
                else if (HexCheckBoxForText.Checked)
                {
                    string[] SplitHexPlainText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    BinaryPlainText = new string[SplitHexPlainText.Length];
                    for (int i = 0; i < SplitHexPlainText.Length; i++)
                    {
                        BinaryPlainText[i] = HexToBin(SplitHexPlainText[i]);
                    }
                }//Error
                else
                {
                    MessageBox.Show("You did not choose the type of the 'PlainText' !!!");
                    return;
                }
                //Step 2: Initial Permutation
                string[] IP_PlainText = Initial_Permutation(BinaryPlainText, IP);
                //Step 3: Encryption
                string[] OutputOfEncryption = Encryption(IP_PlainText, EP, K1, K2, S0, S1, P4);
                //Step 4: Final Permutation
                string[] CipherText = Final_Permutation(OutputOfEncryption, IP);
                
                string Temp = "";
                for (int i = 0; i < CipherText.Length; i++)
                {
                    if (TextCheckBoxForResult.Checked)//Result As Text
                        Temp += BinaryToChar(CipherText[i]);
                    else if (BinaryCheckBoxForResult.Checked)//Result As Binary
                        Temp += CipherText[i] + " ";
                    else if (HexCheckBoxForResult.Checked)//Result As Hex
                        Temp += BinToHex(CipherText[i]) + " ";
                    else
                    {
                        MessageBox.Show("You did not choose the type of Result or Result is Wrong !!!");
                        return;
                    }
                }
                //Result CipherText
                ResultBox.Text = Temp;
            }
            else if (DecrypytCheckBox.Checked)
            {
                //Step 2.0: Convert Text
                string[] BinaryCipherText = null;
                //Text
                if (TextCheckBoxForText.Checked)
                {
                    BinaryCipherText = new string[TextBox.TextLength];
                    for (int i = 0; i < TextBox.TextLength; i++)
                    {
                        BinaryCipherText[i] = CharToBinary(TextBox.Text[i].ToString());
                    }
                }//Binary
                else if (BinaryCheckBoxForText.Checked)
                {
                    string[] SplitBinaryPlainText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    BinaryCipherText = SplitBinaryPlainText;
                }//Hex
                else if (HexCheckBoxForText.Checked)
                {
                    string[] SplitHexPlainText = TextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    BinaryCipherText = new string[SplitHexPlainText.Length];
                    for (int i = 0; i < SplitHexPlainText.Length; i++)
                    {
                        BinaryCipherText[i] = HexToBin(SplitHexPlainText[i]);
                    }
                }//Error
                else
                {
                    MessageBox.Show("You did not choose the type of the 'CipherText' !!!");
                    return;
                }
                //Step 2: Initial Permutation
                string[] IP_CipherText = Initial_Permutation(BinaryCipherText, IP);
                //Step 3: Decryption
                string[] OutputOfDecryption = Decryption(IP_CipherText, EP, K1, K2, S0, S1, P4);
                //Step 4: Final Permutation
                string[] PlainText = Final_Permutation(OutputOfDecryption, IP);

                string Temp = "";
                for (int i = 0; i < PlainText.Length; i++)
                {
                    if (TextCheckBoxForResult.Checked)
                        Temp += BinaryToChar(PlainText[i]);
                    else if (BinaryCheckBoxForResult.Checked)
                        Temp += PlainText[i] + " ";
                    else if (HexCheckBoxForResult.Checked)
                        Temp += BinToHex(PlainText[i]) + " ";
                    else
                    {
                        MessageBox.Show("You did not choose the type of Result or Result is Wrong !!!");
                        return;
                    }
                }
                //Result PlainText
                ResultBox.Text = Temp;
            }//Error
            else
            {
                MessageBox.Show("You did not choose to Encrypt or Decrypt !!!");
                return;
            }
        }

        public void Key_Generation(ref string K1, ref string K2, int[] P10, int[] P8)
        {
            //Key 1
            //P10
            String TempKey = "";
            for (int i = 0; i < P10.Length; i++)
            {
                TempKey += K1[P10[i] - 1];
            }
            K1 = TempKey;
            K2 = TempKey;
            
            //Shift To Left By 1
            string LeftK = K1.Substring(1, (K1.Length / 2) - 1) + K1[0];
            string RightK = K1.Substring((K1.Length / 2) + 1, (K1.Length / 2) - 1) + K1[K1.Length / 2];
            K1 = LeftK + RightK;
            
            //P8
            TempKey = "";
            for (int i = 0; i < P8.Length; i++)
            {
                TempKey += K1[P8[i] - 1];
            }
            K1 = TempKey;

            //Key 2
            //P10 is Done
            //Shift To Left By 3
            LeftK = K2.Substring(3, (K2.Length / 2) - 3) + K2[0] + K2[1] + K2[2];
            RightK = K2.Substring((K2.Length / 2) + 3, (K2.Length / 2) - 3) + K2[K2.Length / 2] + K2[(K2.Length / 2) + 1] + K2[(K2.Length / 2) + 2];
            K2 = LeftK + RightK;
            //P8
            TempKey = "";
            for (int i = 0; i < P8.Length; i++)
            {
                TempKey += K2[P8[i] - 1];
            }
            K2 = TempKey;
        }

        public string[] Initial_Permutation(string[] PlainText, int[] IP)
        {
            string[] TempPlainText = new string[PlainText.Length];
            for (int i = 0; i < PlainText.Length; i++)
            {
                for (int j = 0; j < IP.Length; j++)
                {
                    TempPlainText[i] += PlainText[i][IP[j] - 1];
                }
            }
            return TempPlainText;
        }

        public string[] Encryption(string[] IP_PlainText, int[] EP, string K1, string K2, int[,] S0, int[,] S1, int[] P4)
        {
            string[] Encrypted = new string[IP_PlainText.Length];
            for (int i = 0; i < IP_PlainText.Length; i++)
            {
                string Round1 = Round_1(IP_PlainText[i], EP, K1, S0, S1, P4);
                string Round2 = Round_2(Round1, EP, K2, S0, S1, P4);
                Encrypted[i] = Round2;
            }
            return Encrypted;
        }

        public string[] Decryption(string[] IP_CipherText, int[] EP, String K1, string K2, int[,] S0, int[,] S1, int[] P4)
        {
            string[] Decrypted = new string[IP_CipherText.Length];
            for (int i = 0; i < IP_CipherText.Length; i++)
            {
                string Round1 = Round_1(IP_CipherText[i], EP, K2, S0, S1, P4);
                string Round2 = Round_2(Round1, EP, K1, S0, S1, P4);
                Decrypted[i] = Round2;
            }
            return Decrypted;
        }

        public string Round_1(string Text, int[] EP, String K1, int[,] S0, int[,] S1, int[] P4)
        {
            //Using EP //With IP_PlainTextRight
            string IP_PlainTextRight = null;
            string Temp = Text.Substring(Text.Length / 2, Text.Length / 2);
            for (int i = 0; i < EP.Length; i++)
            {
                IP_PlainTextRight += Temp[EP[i] - 1];
            }
            //PlainTextRight Xor K1
            string XorResult = null;
            for (int i = 0; i < IP_PlainTextRight.Length; i++)
            {
                if (IP_PlainTextRight[i] == K1[i])
                    XorResult += "0";
                else
                    XorResult += "1";
            }
            
            //S Boxes
            string SLeft = XorResult.Substring(0, XorResult.Length / 2);
            string SRight = XorResult.Substring(XorResult.Length / 2, XorResult.Length / 2);
            //S0
            Temp = null;
            Temp += SLeft[0];
            Temp += SLeft[3];
            int Row = BinaryToDecimal(Temp);
            Temp = null;
            Temp += SLeft[1];
            Temp += SLeft[2];
            int Col = BinaryToDecimal(Temp);

            IP_PlainTextRight = null;
            IP_PlainTextRight += DecimalToBinary(S0[Row, Col]).PadLeft(2, '0');
            //S1
            Temp = null;
            Temp += SRight[0];
            Temp += SRight[3];
            Row = BinaryToDecimal(Temp);
            Temp = null;
            Temp += SRight[1];
            Temp += SRight[2];
            Col = BinaryToDecimal(Temp);

            IP_PlainTextRight += DecimalToBinary(S1[Row, Col]).PadLeft(2, '0');
            //Using P4
            Temp = null;
            for (int i = 0; i < P4.Length; i++)
            {
                Temp += IP_PlainTextRight[P4[i] - 1];
            }

            //Temp Xor with the Left of IP_PlainText
            XorResult = null;
            for (int i = 0; i < Temp.Length; i++)
            {
                if (Temp[i] == Text[i])
                    XorResult += "0";
                else
                    XorResult += "1";
            }
            //Swap New Left(XorResult) With the Old Right of IP_PlainText
            Text = Text.Substring(Text.Length / 2, Text.Length / 2) + XorResult;

            return Text;
        }

        public string Round_2(string Text, int[] EP, String K2, int[,] S0, int[,] S1, int[] P4)
        {
            //Using EP
            string Round1Right = null;
            string Temp = Text.Substring(Text.Length / 2, Text.Length / 2);
            for (int i = 0; i < EP.Length; i++)
            {
                Round1Right += Temp[EP[i] - 1];
            }
            
            //Round1Right Xor K1
            string XorResult = null;
            for (int i = 0; i < Round1Right.Length; i++)
            {
                if (Round1Right[i] == K2[i])
                    XorResult += "0";
                else
                    XorResult += "1";
            }
            
            //S Boxes
            string SLeft = XorResult.Substring(0, XorResult.Length / 2);
            string SRight = XorResult.Substring(XorResult.Length / 2, XorResult.Length / 2);
            //S0
            Temp = null;
            Temp += SLeft[0];
            Temp += SLeft[3];
            int Row = BinaryToDecimal(Temp);
            Temp = null;
            Temp += SLeft[1];
            Temp += SLeft[2];
            int Col = BinaryToDecimal(Temp);
            Round1Right = null;
            Round1Right += DecimalToBinary(S0[Row, Col]).PadLeft(2, '0');
            //S1
            Temp = null;
            Temp += SRight[0];
            Temp += SRight[3];
            Row = BinaryToDecimal(Temp);
            Temp = null;
            Temp += SRight[1];
            Temp += SRight[2];
            Col = BinaryToDecimal(Temp);
            Round1Right += DecimalToBinary(S1[Row, Col]).PadLeft(2, '0');
            //Using P4
            Temp = null;
            for (int i = 0; i < P4.Length; i++)
            {
                Temp += Round1Right[P4[i] - 1];
            }

            //Temp Xor with the Left of Round1
            XorResult = null;
            for (int i = 0; i < Temp.Length; i++)
            {
                if (Temp[i] == Text[i])
                    XorResult += "0";
                else
                    XorResult += "1";
            }

            // New Left(XorResult) With the Old Right of Round1
            Text = XorResult + Text.Substring(Text.Length / 2, Text.Length / 2);

            return Text;
        }

        public string[] Final_Permutation(string[] Round2, int[] IP)
        {
            //Create IP_ Inverse
            int[] IP_Inverse = new int[IP.Length];
            for (int i = 0; i < IP.Length; i++)
            {
                IP_Inverse[IP[i] - 1] = i + 1; 
            }
            // Create FP of Round2
            string[] Output = new string[Round2.Length];
            for (int i = 0; i < Round2.Length; i++)
            {
                for (int j = 0; j < IP_Inverse.Length; j++)
                {
                    Output[i] += Round2[i][IP_Inverse[j] - 1];
                }
            }

            return Output;
        }

        public string DecimalToBinary(int data)
        {
            return Convert.ToString(data, 2);
        }
        public int BinaryToDecimal(string data)
        {
            return Convert.ToInt16(data, 2);
        }

        public string BinToHex(string S)
        {
            string Result = "";
            Dictionary<string, char> hexCharacterToBinary = new Dictionary<string, char> {
                { "0000", '0' },
                { "0001", '1' },
                { "0010", '2' },
                { "0011", '3' },
                { "0100", '4' },
                { "0101", '5' },
                { "0110", '6' },
                { "0111", '7' },
                { "1000", '8' },
                { "1001", '9' },
                { "1010", 'A' },
                { "1011", 'B' },
                { "1100", 'C' },
                { "1101", 'D' },
                { "1110", 'E' },
                { "1111", 'F' },
            };
            for (int i = 0; i < S.Length; i += 4)
            {
                string BinaryOf4 = "";
                BinaryOf4 += S[i];
                BinaryOf4 += S[i + 1];
                BinaryOf4 += S[i + 2];
                BinaryOf4 += S[i + 3];
                Result += hexCharacterToBinary[BinaryOf4];
            }
            return Result;
        }
        public string HexToBin(string S)
        {
            string Result = "";
            Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
                { '0', "0000" },
                { '1', "0001" },
                { '2', "0010" },
                { '3', "0011" },
                { '4', "0100" },
                { '5', "0101" },
                { '6', "0110" },
                { '7', "0111" },
                { '8', "1000" },
                { '9', "1001" },
                { 'A', "1010" },
                { 'B', "1011" },
                { 'C', "1100" },
                { 'D', "1101" },
                { 'E', "1110" },
                { 'F', "1111" },
            };
            for (int i = 0; i < S.Length; i++)
            {
                Result += hexCharacterToBinary[S[i]];
            }
            return Result;
        }

        public string CharToBinary(string data)
        {
            return Convert.ToString(Convert.ToChar(data), 2).PadLeft(8, '0');
        }
        public string BinaryToChar(string data)
        {
            int val = BinaryToDecimal(data);
            return Convert.ToChar(val).ToString();
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
            }
        }
        private void BinaryCheckBoxForText_CheckedChanged(object sender, EventArgs e)
        {
            if (BinaryCheckBoxForText.Checked)
            {
                TextCheckBoxForText.Checked = false;
                HexCheckBoxForText.Checked = false;
            }
        }
        private void HexCheckBoxForText_CheckedChanged(object sender, EventArgs e)
        {
            if (HexCheckBoxForText.Checked)
            {
                TextCheckBoxForText.Checked = false;
                BinaryCheckBoxForText.Checked = false;
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
            }
        }
        private void BinaryCheckBoxForResult_CheckedChanged(object sender, EventArgs e)
        {
            if (BinaryCheckBoxForResult.Checked)
            {
                TextCheckBoxForResult.Checked = false;
                HexCheckBoxForResult.Checked = false;
            }
        }
        private void HexCheckBoxForResult_CheckedChanged(object sender, EventArgs e)
        {
            if (HexCheckBoxForResult.Checked)
            {
                TextCheckBoxForResult.Checked = false;
                BinaryCheckBoxForResult.Checked = false;
            }
        }
    }
}
