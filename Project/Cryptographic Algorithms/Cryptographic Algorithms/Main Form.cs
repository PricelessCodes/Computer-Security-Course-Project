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
    public partial class Main : Form
    {
        Timer T = new Timer();
        public Main()
        {
            InitializeComponent();

            T.Start();
            T.Tick += new EventHandler(T_Tick);  
            T.Interval = 500;
        }

        void T_Tick(object sender, EventArgs e)
        {
            Random R = new Random();

            S_DES_Button.BackColor = Color.FromArgb(R.Next(255), R.Next(255), R.Next(255));

            RC4_Button.BackColor = Color.FromArgb(R.Next(255), R.Next(255), R.Next(255));
            
            Diffie_Hellman_Button.BackColor = Color.FromArgb(R.Next(255), R.Next(255), R.Next(255));

            RSA_Button.BackColor = Color.FromArgb(R.Next(255), R.Next(255), R.Next(255));
            ElGamal_Button.BackColor = Color.FromArgb(R.Next(255), R.Next(255), R.Next(255));
        }

        private void S_DES_Button_Click(object sender, EventArgs e)
        {
            S_DES_Form S_DESForm = new S_DES_Form();
            S_DESForm.Show();
            this.Visible = false;
            S_DESForm.FormClosed += new FormClosedEventHandler(S_DESForm_FormClosed);
        }

        void S_DESForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void RC4_Button_Click(object sender, EventArgs e)
        {
            RC4_Form RC4Form = new RC4_Form();
            RC4Form.Show();
            this.Visible = false;
            RC4Form.FormClosed += new FormClosedEventHandler(RC4Form_FormClosed); 
        }

        void RC4Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void Diffie_Hellman_Button_Click(object sender, EventArgs e)
        {
            Diffie_Hellman_Form DHForm = new Diffie_Hellman_Form();
            DHForm.Show();
            this.Visible = false;
            DHForm.FormClosed += new FormClosedEventHandler(DHForm_FormClosed);
        }

        void DHForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void RSA_Button_Click(object sender, EventArgs e)
        {
            RSA_Form RSAForm = new RSA_Form();
            RSAForm.Show();
            this.Visible = false;
            RSAForm.FormClosed += new FormClosedEventHandler(RSAForm_FormClosed);
        }

        void RSAForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void ElGamal_Button_Click(object sender, EventArgs e)
        {
            ELGamal_Form ELGamalForm = new ELGamal_Form();
            ELGamalForm.Show();
            this.Visible = false;
            ELGamalForm.FormClosed += new FormClosedEventHandler(ELGamalForm_FormClosed);
        }

        void ELGamalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
