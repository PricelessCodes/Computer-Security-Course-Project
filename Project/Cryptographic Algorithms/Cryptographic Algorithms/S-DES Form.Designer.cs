namespace Cryptographic_Algorithms
{
    partial class S_DES_Form
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
            this.En_Decryption_Button = new System.Windows.Forms.Button();
            this.BinaryCheckBoxForResult = new System.Windows.Forms.CheckBox();
            this.TextCheckBoxForResult = new System.Windows.Forms.CheckBox();
            this.HexCheckBoxForText = new System.Windows.Forms.CheckBox();
            this.BinaryCheckBoxForText = new System.Windows.Forms.CheckBox();
            this.TextCheckBoxForText = new System.Windows.Forms.CheckBox();
            this.DecrypytCheckBox = new System.Windows.Forms.CheckBox();
            this.EncryptCheckBox = new System.Windows.Forms.CheckBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HexCheckBoxForResult = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // En_Decryption_Button
            // 
            this.En_Decryption_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.En_Decryption_Button.Location = new System.Drawing.Point(550, 580);
            this.En_Decryption_Button.Name = "En_Decryption_Button";
            this.En_Decryption_Button.Size = new System.Drawing.Size(120, 61);
            this.En_Decryption_Button.TabIndex = 0;
            this.En_Decryption_Button.Text = "En/Decrypt";
            this.En_Decryption_Button.UseVisualStyleBackColor = true;
            this.En_Decryption_Button.Click += new System.EventHandler(this.En_Decryption_Button_Click);
            // 
            // BinaryCheckBoxForResult
            // 
            this.BinaryCheckBoxForResult.AutoSize = true;
            this.BinaryCheckBoxForResult.Location = new System.Drawing.Point(259, 372);
            this.BinaryCheckBoxForResult.Name = "BinaryCheckBoxForResult";
            this.BinaryCheckBoxForResult.Size = new System.Drawing.Size(70, 21);
            this.BinaryCheckBoxForResult.TabIndex = 46;
            this.BinaryCheckBoxForResult.Text = "Binary";
            this.BinaryCheckBoxForResult.UseVisualStyleBackColor = true;
            this.BinaryCheckBoxForResult.CheckedChanged += new System.EventHandler(this.BinaryCheckBoxForResult_CheckedChanged);
            // 
            // TextCheckBoxForResult
            // 
            this.TextCheckBoxForResult.AutoSize = true;
            this.TextCheckBoxForResult.Location = new System.Drawing.Point(196, 372);
            this.TextCheckBoxForResult.Name = "TextCheckBoxForResult";
            this.TextCheckBoxForResult.Size = new System.Drawing.Size(57, 21);
            this.TextCheckBoxForResult.TabIndex = 45;
            this.TextCheckBoxForResult.Text = "Text";
            this.TextCheckBoxForResult.UseVisualStyleBackColor = true;
            this.TextCheckBoxForResult.CheckedChanged += new System.EventHandler(this.TextCheckBoxForResult_CheckedChanged);
            // 
            // HexCheckBoxForText
            // 
            this.HexCheckBoxForText.AutoSize = true;
            this.HexCheckBoxForText.Location = new System.Drawing.Point(334, 143);
            this.HexCheckBoxForText.Name = "HexCheckBoxForText";
            this.HexCheckBoxForText.Size = new System.Drawing.Size(54, 21);
            this.HexCheckBoxForText.TabIndex = 42;
            this.HexCheckBoxForText.Text = "Hex";
            this.HexCheckBoxForText.UseVisualStyleBackColor = true;
            this.HexCheckBoxForText.CheckedChanged += new System.EventHandler(this.HexCheckBoxForText_CheckedChanged);
            // 
            // BinaryCheckBoxForText
            // 
            this.BinaryCheckBoxForText.AutoSize = true;
            this.BinaryCheckBoxForText.Location = new System.Drawing.Point(259, 143);
            this.BinaryCheckBoxForText.Name = "BinaryCheckBoxForText";
            this.BinaryCheckBoxForText.Size = new System.Drawing.Size(70, 21);
            this.BinaryCheckBoxForText.TabIndex = 41;
            this.BinaryCheckBoxForText.Text = "Binary";
            this.BinaryCheckBoxForText.UseVisualStyleBackColor = true;
            this.BinaryCheckBoxForText.CheckedChanged += new System.EventHandler(this.BinaryCheckBoxForText_CheckedChanged);
            // 
            // TextCheckBoxForText
            // 
            this.TextCheckBoxForText.AutoSize = true;
            this.TextCheckBoxForText.Location = new System.Drawing.Point(196, 142);
            this.TextCheckBoxForText.Name = "TextCheckBoxForText";
            this.TextCheckBoxForText.Size = new System.Drawing.Size(57, 21);
            this.TextCheckBoxForText.TabIndex = 40;
            this.TextCheckBoxForText.Text = "Text";
            this.TextCheckBoxForText.UseVisualStyleBackColor = true;
            this.TextCheckBoxForText.CheckedChanged += new System.EventHandler(this.TextCheckBoxForText_CheckedChanged);
            // 
            // DecrypytCheckBox
            // 
            this.DecrypytCheckBox.AutoSize = true;
            this.DecrypytCheckBox.Location = new System.Drawing.Point(98, 142);
            this.DecrypytCheckBox.Name = "DecrypytCheckBox";
            this.DecrypytCheckBox.Size = new System.Drawing.Size(79, 21);
            this.DecrypytCheckBox.TabIndex = 39;
            this.DecrypytCheckBox.Text = "Decrypt";
            this.DecrypytCheckBox.UseVisualStyleBackColor = true;
            this.DecrypytCheckBox.CheckedChanged += new System.EventHandler(this.DecrypytCheckBox_CheckedChanged);
            // 
            // EncryptCheckBox
            // 
            this.EncryptCheckBox.AutoSize = true;
            this.EncryptCheckBox.Location = new System.Drawing.Point(14, 142);
            this.EncryptCheckBox.Name = "EncryptCheckBox";
            this.EncryptCheckBox.Size = new System.Drawing.Size(78, 21);
            this.EncryptCheckBox.TabIndex = 38;
            this.EncryptCheckBox.Text = "Encrypt";
            this.EncryptCheckBox.UseVisualStyleBackColor = true;
            this.EncryptCheckBox.CheckedChanged += new System.EventHandler(this.EncryptCheckBox_CheckedChanged);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextBox.Location = new System.Drawing.Point(17, 223);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(584, 34);
            this.KeyTextBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Key (In Binary[10 bits]):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "/";
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(12, 332);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(584, 34);
            this.ResultBox.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Result:";
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(12, 102);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(584, 34);
            this.TextBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Text: (Plaint Text or Cipher Text)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "S-DES Algorithm";
            // 
            // HexCheckBoxForResult
            // 
            this.HexCheckBoxForResult.AutoSize = true;
            this.HexCheckBoxForResult.Location = new System.Drawing.Point(334, 372);
            this.HexCheckBoxForResult.Name = "HexCheckBoxForResult";
            this.HexCheckBoxForResult.Size = new System.Drawing.Size(54, 21);
            this.HexCheckBoxForResult.TabIndex = 47;
            this.HexCheckBoxForResult.Text = "Hex";
            this.HexCheckBoxForResult.UseVisualStyleBackColor = true;
            this.HexCheckBoxForResult.CheckedChanged += new System.EventHandler(this.HexCheckBoxForResult_CheckedChanged);
            // 
            // S_DES_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.HexCheckBoxForResult);
            this.Controls.Add(this.BinaryCheckBoxForResult);
            this.Controls.Add(this.TextCheckBoxForResult);
            this.Controls.Add(this.HexCheckBoxForText);
            this.Controls.Add(this.BinaryCheckBoxForText);
            this.Controls.Add(this.TextCheckBoxForText);
            this.Controls.Add(this.DecrypytCheckBox);
            this.Controls.Add(this.EncryptCheckBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.En_Decryption_Button);
            this.Name = "S_DES_Form";
            this.Text = "S_DES_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button En_Decryption_Button;
        private System.Windows.Forms.CheckBox BinaryCheckBoxForResult;
        private System.Windows.Forms.CheckBox TextCheckBoxForResult;
        private System.Windows.Forms.CheckBox HexCheckBoxForText;
        private System.Windows.Forms.CheckBox BinaryCheckBoxForText;
        private System.Windows.Forms.CheckBox TextCheckBoxForText;
        private System.Windows.Forms.CheckBox DecrypytCheckBox;
        private System.Windows.Forms.CheckBox EncryptCheckBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox HexCheckBoxForResult;

    }
}