namespace Cryptographic_Algorithms
{
    partial class ELGamal_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Encryption_Button = new System.Windows.Forms.Button();
            this.PlainTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.q_TextBox = new System.Windows.Forms.TextBox();
            this.XA_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CipherTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.q_TextBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.XA_TextBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EncryptResultTextBox = new System.Windows.Forms.TextBox();
            this.DecryptResultTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Decryption_Button = new System.Windows.Forms.Button();
            this.a_TextBox = new System.Windows.Forms.TextBox();
            this.HexCheckBoxForTextEncryption = new System.Windows.Forms.CheckBox();
            this.BinaryCheckBoxForTextEncryption = new System.Windows.Forms.CheckBox();
            this.TextCheckBoxForTextEncryption = new System.Windows.Forms.CheckBox();
            this.HexCheckBoxForResultEncryption = new System.Windows.Forms.CheckBox();
            this.BinaryCheckBoxForResultEncryption = new System.Windows.Forms.CheckBox();
            this.TextCheckBoxForResultEncryption = new System.Windows.Forms.CheckBox();
            this.DecimalCheckBoxForTextEncryption = new System.Windows.Forms.CheckBox();
            this.DecimalCheckBoxForResultEncryption = new System.Windows.Forms.CheckBox();
            this.DecimalCheckBoxForResultDecryption = new System.Windows.Forms.CheckBox();
            this.DecimalCheckBoxForTextDecryption = new System.Windows.Forms.CheckBox();
            this.HexCheckBoxForResultDecryption = new System.Windows.Forms.CheckBox();
            this.BinaryCheckBoxForResultDecryption = new System.Windows.Forms.CheckBox();
            this.TextCheckBoxForResultDecryption = new System.Windows.Forms.CheckBox();
            this.HexCheckBoxForTextDecryption = new System.Windows.Forms.CheckBox();
            this.BinaryCheckBoxForTextDecryption = new System.Windows.Forms.CheckBox();
            this.TextCheckBoxForTextDecryption = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Encryption_Button
            // 
            this.Encryption_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encryption_Button.Location = new System.Drawing.Point(367, 600);
            this.Encryption_Button.Name = "Encryption_Button";
            this.Encryption_Button.Size = new System.Drawing.Size(105, 55);
            this.Encryption_Button.TabIndex = 0;
            this.Encryption_Button.Text = "Encrypt";
            this.Encryption_Button.UseVisualStyleBackColor = true;
            this.Encryption_Button.Click += new System.EventHandler(this.Encryption_Button_Click);
            // 
            // PlainTextBox
            // 
            this.PlainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextBox.Location = new System.Drawing.Point(12, 109);
            this.PlainTextBox.Name = "PlainTextBox";
            this.PlainTextBox.Size = new System.Drawing.Size(349, 34);
            this.PlainTextBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "PlainText:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "ELGamal Algorithm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Primitive Root (a):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Large Prime Number (q):";
            // 
            // q_TextBox
            // 
            this.q_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_TextBox.Location = new System.Drawing.Point(12, 205);
            this.q_TextBox.Name = "q_TextBox";
            this.q_TextBox.Size = new System.Drawing.Size(349, 34);
            this.q_TextBox.TabIndex = 41;
            // 
            // XA_TextBox
            // 
            this.XA_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XA_TextBox.Location = new System.Drawing.Point(12, 355);
            this.XA_TextBox.Name = "XA_TextBox";
            this.XA_TextBox.Size = new System.Drawing.Size(349, 34);
            this.XA_TextBox.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Secret Key of User A (XA <  q - 1):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "CipherText (C1, C2):";
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherTextBox.Location = new System.Drawing.Point(497, 109);
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.Size = new System.Drawing.Size(349, 34);
            this.CipherTextBox.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "CipherText (C1, C2):";
            // 
            // q_TextBox2
            // 
            this.q_TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_TextBox2.Location = new System.Drawing.Point(497, 205);
            this.q_TextBox2.Name = "q_TextBox2";
            this.q_TextBox2.Size = new System.Drawing.Size(349, 34);
            this.q_TextBox2.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(497, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "Large Prime Number (q):";
            // 
            // XA_TextBox2
            // 
            this.XA_TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XA_TextBox2.Location = new System.Drawing.Point(497, 283);
            this.XA_TextBox2.Name = "XA_TextBox2";
            this.XA_TextBox2.Size = new System.Drawing.Size(349, 34);
            this.XA_TextBox2.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(497, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(314, 25);
            this.label9.TabIndex = 61;
            this.label9.Text = "Secret Key of User A (XA <  q - 1):";
            // 
            // EncryptResultTextBox
            // 
            this.EncryptResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptResultTextBox.Location = new System.Drawing.Point(12, 532);
            this.EncryptResultTextBox.Name = "EncryptResultTextBox";
            this.EncryptResultTextBox.Size = new System.Drawing.Size(349, 34);
            this.EncryptResultTextBox.TabIndex = 63;
            // 
            // DecryptResultTextBox
            // 
            this.DecryptResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptResultTextBox.Location = new System.Drawing.Point(497, 532);
            this.DecryptResultTextBox.Name = "DecryptResultTextBox";
            this.DecryptResultTextBox.Size = new System.Drawing.Size(349, 34);
            this.DecryptResultTextBox.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(497, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 64;
            this.label10.Text = "PlainText:";
            // 
            // Decryption_Button
            // 
            this.Decryption_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decryption_Button.Location = new System.Drawing.Point(865, 600);
            this.Decryption_Button.Name = "Decryption_Button";
            this.Decryption_Button.Size = new System.Drawing.Size(105, 55);
            this.Decryption_Button.TabIndex = 66;
            this.Decryption_Button.Text = "Decrypt";
            this.Decryption_Button.UseVisualStyleBackColor = true;
            this.Decryption_Button.Click += new System.EventHandler(this.Decryption_Button_Click);
            // 
            // a_TextBox
            // 
            this.a_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_TextBox.Location = new System.Drawing.Point(12, 283);
            this.a_TextBox.Name = "a_TextBox";
            this.a_TextBox.Size = new System.Drawing.Size(349, 34);
            this.a_TextBox.TabIndex = 67;
            // 
            // HexCheckBoxForTextEncryption
            // 
            this.HexCheckBoxForTextEncryption.AutoSize = true;
            this.HexCheckBoxForTextEncryption.Location = new System.Drawing.Point(219, 149);
            this.HexCheckBoxForTextEncryption.Name = "HexCheckBoxForTextEncryption";
            this.HexCheckBoxForTextEncryption.Size = new System.Drawing.Size(54, 21);
            this.HexCheckBoxForTextEncryption.TabIndex = 70;
            this.HexCheckBoxForTextEncryption.Text = "Hex";
            this.HexCheckBoxForTextEncryption.UseVisualStyleBackColor = true;
            this.HexCheckBoxForTextEncryption.CheckedChanged += new System.EventHandler(this.HexCheckBoxForTextEncryption_CheckedChanged);
            // 
            // BinaryCheckBoxForTextEncryption
            // 
            this.BinaryCheckBoxForTextEncryption.AutoSize = true;
            this.BinaryCheckBoxForTextEncryption.Location = new System.Drawing.Point(144, 149);
            this.BinaryCheckBoxForTextEncryption.Name = "BinaryCheckBoxForTextEncryption";
            this.BinaryCheckBoxForTextEncryption.Size = new System.Drawing.Size(70, 21);
            this.BinaryCheckBoxForTextEncryption.TabIndex = 69;
            this.BinaryCheckBoxForTextEncryption.Text = "Binary";
            this.BinaryCheckBoxForTextEncryption.UseVisualStyleBackColor = true;
            this.BinaryCheckBoxForTextEncryption.CheckedChanged += new System.EventHandler(this.BinaryCheckBoxForTextEncryption_CheckedChanged);
            // 
            // TextCheckBoxForTextEncryption
            // 
            this.TextCheckBoxForTextEncryption.AutoSize = true;
            this.TextCheckBoxForTextEncryption.Location = new System.Drawing.Point(81, 148);
            this.TextCheckBoxForTextEncryption.Name = "TextCheckBoxForTextEncryption";
            this.TextCheckBoxForTextEncryption.Size = new System.Drawing.Size(57, 21);
            this.TextCheckBoxForTextEncryption.TabIndex = 68;
            this.TextCheckBoxForTextEncryption.Text = "Text";
            this.TextCheckBoxForTextEncryption.UseVisualStyleBackColor = true;
            this.TextCheckBoxForTextEncryption.CheckedChanged += new System.EventHandler(this.TextCheckBoxForTextEncryption_CheckedChanged);
            // 
            // HexCheckBoxForResultEncryption
            // 
            this.HexCheckBoxForResultEncryption.AutoSize = true;
            this.HexCheckBoxForResultEncryption.Location = new System.Drawing.Point(220, 572);
            this.HexCheckBoxForResultEncryption.Name = "HexCheckBoxForResultEncryption";
            this.HexCheckBoxForResultEncryption.Size = new System.Drawing.Size(54, 21);
            this.HexCheckBoxForResultEncryption.TabIndex = 73;
            this.HexCheckBoxForResultEncryption.Text = "Hex";
            this.HexCheckBoxForResultEncryption.UseVisualStyleBackColor = true;
            this.HexCheckBoxForResultEncryption.CheckedChanged += new System.EventHandler(this.HexCheckBoxForResultEncryption_CheckedChanged);
            // 
            // BinaryCheckBoxForResultEncryption
            // 
            this.BinaryCheckBoxForResultEncryption.AutoSize = true;
            this.BinaryCheckBoxForResultEncryption.Location = new System.Drawing.Point(144, 572);
            this.BinaryCheckBoxForResultEncryption.Name = "BinaryCheckBoxForResultEncryption";
            this.BinaryCheckBoxForResultEncryption.Size = new System.Drawing.Size(70, 21);
            this.BinaryCheckBoxForResultEncryption.TabIndex = 72;
            this.BinaryCheckBoxForResultEncryption.Text = "Binary";
            this.BinaryCheckBoxForResultEncryption.UseVisualStyleBackColor = true;
            this.BinaryCheckBoxForResultEncryption.CheckedChanged += new System.EventHandler(this.BinaryCheckBoxForResultEncryption_CheckedChanged);
            // 
            // TextCheckBoxForResultEncryption
            // 
            this.TextCheckBoxForResultEncryption.AutoSize = true;
            this.TextCheckBoxForResultEncryption.Location = new System.Drawing.Point(81, 572);
            this.TextCheckBoxForResultEncryption.Name = "TextCheckBoxForResultEncryption";
            this.TextCheckBoxForResultEncryption.Size = new System.Drawing.Size(57, 21);
            this.TextCheckBoxForResultEncryption.TabIndex = 71;
            this.TextCheckBoxForResultEncryption.Text = "Text";
            this.TextCheckBoxForResultEncryption.UseVisualStyleBackColor = true;
            this.TextCheckBoxForResultEncryption.CheckedChanged += new System.EventHandler(this.TextCheckBoxForResultEncryption_CheckedChanged);
            // 
            // DecimalCheckBoxForTextEncryption
            // 
            this.DecimalCheckBoxForTextEncryption.AutoSize = true;
            this.DecimalCheckBoxForTextEncryption.Location = new System.Drawing.Point(279, 149);
            this.DecimalCheckBoxForTextEncryption.Name = "DecimalCheckBoxForTextEncryption";
            this.DecimalCheckBoxForTextEncryption.Size = new System.Drawing.Size(80, 21);
            this.DecimalCheckBoxForTextEncryption.TabIndex = 74;
            this.DecimalCheckBoxForTextEncryption.Text = "Decimal";
            this.DecimalCheckBoxForTextEncryption.UseVisualStyleBackColor = true;
            this.DecimalCheckBoxForTextEncryption.CheckedChanged += new System.EventHandler(this.DecimalCheckBoxForTextEncryption_CheckedChanged);
            // 
            // DecimalCheckBoxForResultEncryption
            // 
            this.DecimalCheckBoxForResultEncryption.AutoSize = true;
            this.DecimalCheckBoxForResultEncryption.Location = new System.Drawing.Point(280, 572);
            this.DecimalCheckBoxForResultEncryption.Name = "DecimalCheckBoxForResultEncryption";
            this.DecimalCheckBoxForResultEncryption.Size = new System.Drawing.Size(80, 21);
            this.DecimalCheckBoxForResultEncryption.TabIndex = 75;
            this.DecimalCheckBoxForResultEncryption.Text = "Decimal";
            this.DecimalCheckBoxForResultEncryption.UseVisualStyleBackColor = true;
            this.DecimalCheckBoxForResultEncryption.CheckedChanged += new System.EventHandler(this.DecimalCheckBoxForResultEncryption_CheckedChanged);
            // 
            // DecimalCheckBoxForResultDecryption
            // 
            this.DecimalCheckBoxForResultDecryption.AutoSize = true;
            this.DecimalCheckBoxForResultDecryption.Location = new System.Drawing.Point(767, 572);
            this.DecimalCheckBoxForResultDecryption.Name = "DecimalCheckBoxForResultDecryption";
            this.DecimalCheckBoxForResultDecryption.Size = new System.Drawing.Size(80, 21);
            this.DecimalCheckBoxForResultDecryption.TabIndex = 83;
            this.DecimalCheckBoxForResultDecryption.Text = "Decimal";
            this.DecimalCheckBoxForResultDecryption.UseVisualStyleBackColor = true;
            this.DecimalCheckBoxForResultDecryption.CheckedChanged += new System.EventHandler(this.DecimalCheckBoxForResultDecryption_CheckedChanged);
            // 
            // DecimalCheckBoxForTextDecryption
            // 
            this.DecimalCheckBoxForTextDecryption.AutoSize = true;
            this.DecimalCheckBoxForTextDecryption.Location = new System.Drawing.Point(766, 149);
            this.DecimalCheckBoxForTextDecryption.Name = "DecimalCheckBoxForTextDecryption";
            this.DecimalCheckBoxForTextDecryption.Size = new System.Drawing.Size(80, 21);
            this.DecimalCheckBoxForTextDecryption.TabIndex = 82;
            this.DecimalCheckBoxForTextDecryption.Text = "Decimal";
            this.DecimalCheckBoxForTextDecryption.UseVisualStyleBackColor = true;
            this.DecimalCheckBoxForTextDecryption.CheckedChanged += new System.EventHandler(this.DecimalCheckBoxForTextDecryption_CheckedChanged);
            // 
            // HexCheckBoxForResultDecryption
            // 
            this.HexCheckBoxForResultDecryption.AutoSize = true;
            this.HexCheckBoxForResultDecryption.Location = new System.Drawing.Point(707, 572);
            this.HexCheckBoxForResultDecryption.Name = "HexCheckBoxForResultDecryption";
            this.HexCheckBoxForResultDecryption.Size = new System.Drawing.Size(54, 21);
            this.HexCheckBoxForResultDecryption.TabIndex = 81;
            this.HexCheckBoxForResultDecryption.Text = "Hex";
            this.HexCheckBoxForResultDecryption.UseVisualStyleBackColor = true;
            this.HexCheckBoxForResultDecryption.CheckedChanged += new System.EventHandler(this.HexCheckBoxForResultDecryption_CheckedChanged);
            // 
            // BinaryCheckBoxForResultDecryption
            // 
            this.BinaryCheckBoxForResultDecryption.AutoSize = true;
            this.BinaryCheckBoxForResultDecryption.Location = new System.Drawing.Point(631, 572);
            this.BinaryCheckBoxForResultDecryption.Name = "BinaryCheckBoxForResultDecryption";
            this.BinaryCheckBoxForResultDecryption.Size = new System.Drawing.Size(70, 21);
            this.BinaryCheckBoxForResultDecryption.TabIndex = 80;
            this.BinaryCheckBoxForResultDecryption.Text = "Binary";
            this.BinaryCheckBoxForResultDecryption.UseVisualStyleBackColor = true;
            this.BinaryCheckBoxForResultDecryption.CheckedChanged += new System.EventHandler(this.BinaryCheckBoxForResultDecryption_CheckedChanged);
            // 
            // TextCheckBoxForResultDecryption
            // 
            this.TextCheckBoxForResultDecryption.AutoSize = true;
            this.TextCheckBoxForResultDecryption.Location = new System.Drawing.Point(568, 572);
            this.TextCheckBoxForResultDecryption.Name = "TextCheckBoxForResultDecryption";
            this.TextCheckBoxForResultDecryption.Size = new System.Drawing.Size(57, 21);
            this.TextCheckBoxForResultDecryption.TabIndex = 79;
            this.TextCheckBoxForResultDecryption.Text = "Text";
            this.TextCheckBoxForResultDecryption.UseVisualStyleBackColor = true;
            this.TextCheckBoxForResultDecryption.CheckedChanged += new System.EventHandler(this.TextCheckBoxForResultDecryption_CheckedChanged);
            // 
            // HexCheckBoxForTextDecryption
            // 
            this.HexCheckBoxForTextDecryption.AutoSize = true;
            this.HexCheckBoxForTextDecryption.Location = new System.Drawing.Point(706, 149);
            this.HexCheckBoxForTextDecryption.Name = "HexCheckBoxForTextDecryption";
            this.HexCheckBoxForTextDecryption.Size = new System.Drawing.Size(54, 21);
            this.HexCheckBoxForTextDecryption.TabIndex = 78;
            this.HexCheckBoxForTextDecryption.Text = "Hex";
            this.HexCheckBoxForTextDecryption.UseVisualStyleBackColor = true;
            this.HexCheckBoxForTextDecryption.CheckedChanged += new System.EventHandler(this.HexCheckBoxForTextDecryption_CheckedChanged);
            // 
            // BinaryCheckBoxForTextDecryption
            // 
            this.BinaryCheckBoxForTextDecryption.AutoSize = true;
            this.BinaryCheckBoxForTextDecryption.Location = new System.Drawing.Point(631, 149);
            this.BinaryCheckBoxForTextDecryption.Name = "BinaryCheckBoxForTextDecryption";
            this.BinaryCheckBoxForTextDecryption.Size = new System.Drawing.Size(70, 21);
            this.BinaryCheckBoxForTextDecryption.TabIndex = 77;
            this.BinaryCheckBoxForTextDecryption.Text = "Binary";
            this.BinaryCheckBoxForTextDecryption.UseVisualStyleBackColor = true;
            this.BinaryCheckBoxForTextDecryption.CheckedChanged += new System.EventHandler(this.BinaryCheckBoxForTextDecryption_CheckedChanged);
            // 
            // TextCheckBoxForTextDecryption
            // 
            this.TextCheckBoxForTextDecryption.AutoSize = true;
            this.TextCheckBoxForTextDecryption.Location = new System.Drawing.Point(568, 148);
            this.TextCheckBoxForTextDecryption.Name = "TextCheckBoxForTextDecryption";
            this.TextCheckBoxForTextDecryption.Size = new System.Drawing.Size(57, 21);
            this.TextCheckBoxForTextDecryption.TabIndex = 76;
            this.TextCheckBoxForTextDecryption.Text = "Text";
            this.TextCheckBoxForTextDecryption.UseVisualStyleBackColor = true;
            this.TextCheckBoxForTextDecryption.CheckedChanged += new System.EventHandler(this.TextCheckBoxForTextDecryption_CheckedChanged);
            // 
            // ELGamal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 667);
            this.Controls.Add(this.DecimalCheckBoxForResultDecryption);
            this.Controls.Add(this.DecimalCheckBoxForTextDecryption);
            this.Controls.Add(this.HexCheckBoxForResultDecryption);
            this.Controls.Add(this.BinaryCheckBoxForResultDecryption);
            this.Controls.Add(this.TextCheckBoxForResultDecryption);
            this.Controls.Add(this.HexCheckBoxForTextDecryption);
            this.Controls.Add(this.BinaryCheckBoxForTextDecryption);
            this.Controls.Add(this.TextCheckBoxForTextDecryption);
            this.Controls.Add(this.DecimalCheckBoxForResultEncryption);
            this.Controls.Add(this.DecimalCheckBoxForTextEncryption);
            this.Controls.Add(this.HexCheckBoxForResultEncryption);
            this.Controls.Add(this.BinaryCheckBoxForResultEncryption);
            this.Controls.Add(this.TextCheckBoxForResultEncryption);
            this.Controls.Add(this.HexCheckBoxForTextEncryption);
            this.Controls.Add(this.BinaryCheckBoxForTextEncryption);
            this.Controls.Add(this.TextCheckBoxForTextEncryption);
            this.Controls.Add(this.a_TextBox);
            this.Controls.Add(this.Decryption_Button);
            this.Controls.Add(this.DecryptResultTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EncryptResultTextBox);
            this.Controls.Add(this.XA_TextBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.q_TextBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.XA_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.q_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlainTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Encryption_Button);
            this.Name = "ELGamal_Form";
            this.Text = "ELGamal_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encryption_Button;
        private System.Windows.Forms.TextBox PlainTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox q_TextBox;
        private System.Windows.Forms.TextBox XA_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CipherTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox q_TextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox XA_TextBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EncryptResultTextBox;
        private System.Windows.Forms.TextBox DecryptResultTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Decryption_Button;
        private System.Windows.Forms.TextBox a_TextBox;
        private System.Windows.Forms.CheckBox HexCheckBoxForTextEncryption;
        private System.Windows.Forms.CheckBox BinaryCheckBoxForTextEncryption;
        private System.Windows.Forms.CheckBox TextCheckBoxForTextEncryption;
        private System.Windows.Forms.CheckBox HexCheckBoxForResultEncryption;
        private System.Windows.Forms.CheckBox BinaryCheckBoxForResultEncryption;
        private System.Windows.Forms.CheckBox TextCheckBoxForResultEncryption;
        private System.Windows.Forms.CheckBox DecimalCheckBoxForTextEncryption;
        private System.Windows.Forms.CheckBox DecimalCheckBoxForResultEncryption;
        private System.Windows.Forms.CheckBox DecimalCheckBoxForResultDecryption;
        private System.Windows.Forms.CheckBox DecimalCheckBoxForTextDecryption;
        private System.Windows.Forms.CheckBox HexCheckBoxForResultDecryption;
        private System.Windows.Forms.CheckBox BinaryCheckBoxForResultDecryption;
        private System.Windows.Forms.CheckBox TextCheckBoxForResultDecryption;
        private System.Windows.Forms.CheckBox HexCheckBoxForTextDecryption;
        private System.Windows.Forms.CheckBox BinaryCheckBoxForTextDecryption;
        private System.Windows.Forms.CheckBox TextCheckBoxForTextDecryption;
    }
}