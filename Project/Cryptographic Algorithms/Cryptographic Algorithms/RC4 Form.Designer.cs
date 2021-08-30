namespace Cryptographic_Algorithms
{
    partial class RC4_Form
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
            this.Run_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EncryptCheckBox = new System.Windows.Forms.CheckBox();
            this.DecrypytCheckBox = new System.Windows.Forms.CheckBox();
            this.TextCheckBoxForText = new System.Windows.Forms.CheckBox();
            this.BinaryCheckBoxForText = new System.Windows.Forms.CheckBox();
            this.HexCheckBoxForText = new System.Windows.Forms.CheckBox();
            this.BinaryCheckBoxForKey = new System.Windows.Forms.CheckBox();
            this.HexCheckBoxForKey = new System.Windows.Forms.CheckBox();
            this.TextCheckBoxForResult = new System.Windows.Forms.CheckBox();
            this.BinaryCheckBoxForResult = new System.Windows.Forms.CheckBox();
            this.HexCheckBoxForResult = new System.Windows.Forms.CheckBox();
            this.DecimalCheckBoxForText = new System.Windows.Forms.CheckBox();
            this.DecimalCheckBoxForResult = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Run_Button
            // 
            this.Run_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run_Button.Location = new System.Drawing.Point(551, 458);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(119, 55);
            this.Run_Button.TabIndex = 0;
            this.Run_Button.Text = "En/Decrypt";
            this.Run_Button.UseVisualStyleBackColor = true;
            this.Run_Button.Click += new System.EventHandler(this.Run_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "RC4 Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text: (Plaint Text or Cipher Text)";
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(12, 103);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(584, 34);
            this.TextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result:";
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(12, 333);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(584, 34);
            this.ResultBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "/";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextBox.Location = new System.Drawing.Point(17, 224);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(584, 34);
            this.KeyTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Key";
            // 
            // EncryptCheckBox
            // 
            this.EncryptCheckBox.AutoSize = true;
            this.EncryptCheckBox.Location = new System.Drawing.Point(14, 143);
            this.EncryptCheckBox.Name = "EncryptCheckBox";
            this.EncryptCheckBox.Size = new System.Drawing.Size(78, 21);
            this.EncryptCheckBox.TabIndex = 19;
            this.EncryptCheckBox.Text = "Encrypt";
            this.EncryptCheckBox.UseVisualStyleBackColor = true;
            this.EncryptCheckBox.CheckedChanged += new System.EventHandler(this.EncryptCheckBox_CheckedChanged);
            // 
            // DecrypytCheckBox
            // 
            this.DecrypytCheckBox.AutoSize = true;
            this.DecrypytCheckBox.Location = new System.Drawing.Point(98, 143);
            this.DecrypytCheckBox.Name = "DecrypytCheckBox";
            this.DecrypytCheckBox.Size = new System.Drawing.Size(79, 21);
            this.DecrypytCheckBox.TabIndex = 20;
            this.DecrypytCheckBox.Text = "Decrypt";
            this.DecrypytCheckBox.UseVisualStyleBackColor = true;
            this.DecrypytCheckBox.CheckedChanged += new System.EventHandler(this.DecrypytCheckBox_CheckedChanged);
            // 
            // TextCheckBoxForText
            // 
            this.TextCheckBoxForText.AutoSize = true;
            this.TextCheckBoxForText.Location = new System.Drawing.Point(196, 143);
            this.TextCheckBoxForText.Name = "TextCheckBoxForText";
            this.TextCheckBoxForText.Size = new System.Drawing.Size(57, 21);
            this.TextCheckBoxForText.TabIndex = 21;
            this.TextCheckBoxForText.Text = "Text";
            this.TextCheckBoxForText.UseVisualStyleBackColor = true;
            this.TextCheckBoxForText.CheckedChanged += new System.EventHandler(this.TextCheckBoxForText_CheckedChanged);
            // 
            // BinaryCheckBoxForText
            // 
            this.BinaryCheckBoxForText.AutoSize = true;
            this.BinaryCheckBoxForText.Location = new System.Drawing.Point(259, 144);
            this.BinaryCheckBoxForText.Name = "BinaryCheckBoxForText";
            this.BinaryCheckBoxForText.Size = new System.Drawing.Size(70, 21);
            this.BinaryCheckBoxForText.TabIndex = 22;
            this.BinaryCheckBoxForText.Text = "Binary";
            this.BinaryCheckBoxForText.UseVisualStyleBackColor = true;
            this.BinaryCheckBoxForText.CheckedChanged += new System.EventHandler(this.BinaryCheckBoxForText_CheckedChanged);
            // 
            // HexCheckBoxForText
            // 
            this.HexCheckBoxForText.AutoSize = true;
            this.HexCheckBoxForText.Location = new System.Drawing.Point(334, 144);
            this.HexCheckBoxForText.Name = "HexCheckBoxForText";
            this.HexCheckBoxForText.Size = new System.Drawing.Size(54, 21);
            this.HexCheckBoxForText.TabIndex = 23;
            this.HexCheckBoxForText.Text = "Hex";
            this.HexCheckBoxForText.UseVisualStyleBackColor = true;
            this.HexCheckBoxForText.CheckedChanged += new System.EventHandler(this.HexCheckBoxForText_CheckedChanged);
            // 
            // BinaryCheckBoxForKey
            // 
            this.BinaryCheckBoxForKey.AutoSize = true;
            this.BinaryCheckBoxForKey.Location = new System.Drawing.Point(259, 265);
            this.BinaryCheckBoxForKey.Name = "BinaryCheckBoxForKey";
            this.BinaryCheckBoxForKey.Size = new System.Drawing.Size(70, 21);
            this.BinaryCheckBoxForKey.TabIndex = 24;
            this.BinaryCheckBoxForKey.Text = "Binary";
            this.BinaryCheckBoxForKey.UseVisualStyleBackColor = true;
            this.BinaryCheckBoxForKey.CheckedChanged += new System.EventHandler(this.BinaryCheckBoxForKey_CheckedChanged);
            // 
            // HexCheckBoxForKey
            // 
            this.HexCheckBoxForKey.AutoSize = true;
            this.HexCheckBoxForKey.Location = new System.Drawing.Point(333, 265);
            this.HexCheckBoxForKey.Name = "HexCheckBoxForKey";
            this.HexCheckBoxForKey.Size = new System.Drawing.Size(54, 21);
            this.HexCheckBoxForKey.TabIndex = 25;
            this.HexCheckBoxForKey.Text = "Hex";
            this.HexCheckBoxForKey.UseVisualStyleBackColor = true;
            this.HexCheckBoxForKey.CheckedChanged += new System.EventHandler(this.HexCheckBoxForKey_CheckedChanged);
            // 
            // TextCheckBoxForResult
            // 
            this.TextCheckBoxForResult.AutoSize = true;
            this.TextCheckBoxForResult.Location = new System.Drawing.Point(196, 373);
            this.TextCheckBoxForResult.Name = "TextCheckBoxForResult";
            this.TextCheckBoxForResult.Size = new System.Drawing.Size(57, 21);
            this.TextCheckBoxForResult.TabIndex = 26;
            this.TextCheckBoxForResult.Text = "Text";
            this.TextCheckBoxForResult.UseVisualStyleBackColor = true;
            this.TextCheckBoxForResult.CheckedChanged += new System.EventHandler(this.TextCheckBoxForResult_CheckedChanged);
            // 
            // BinaryCheckBoxForResult
            // 
            this.BinaryCheckBoxForResult.AutoSize = true;
            this.BinaryCheckBoxForResult.Location = new System.Drawing.Point(259, 373);
            this.BinaryCheckBoxForResult.Name = "BinaryCheckBoxForResult";
            this.BinaryCheckBoxForResult.Size = new System.Drawing.Size(70, 21);
            this.BinaryCheckBoxForResult.TabIndex = 27;
            this.BinaryCheckBoxForResult.Text = "Binary";
            this.BinaryCheckBoxForResult.UseVisualStyleBackColor = true;
            this.BinaryCheckBoxForResult.CheckedChanged += new System.EventHandler(this.BinaryCheckBoxForResult_CheckedChanged);
            // 
            // HexCheckBoxForResult
            // 
            this.HexCheckBoxForResult.AutoSize = true;
            this.HexCheckBoxForResult.Location = new System.Drawing.Point(335, 373);
            this.HexCheckBoxForResult.Name = "HexCheckBoxForResult";
            this.HexCheckBoxForResult.Size = new System.Drawing.Size(54, 21);
            this.HexCheckBoxForResult.TabIndex = 28;
            this.HexCheckBoxForResult.Text = "Hex";
            this.HexCheckBoxForResult.UseVisualStyleBackColor = true;
            this.HexCheckBoxForResult.CheckedChanged += new System.EventHandler(this.HexCheckBoxForResult_CheckedChanged);
            // 
            // DecimalCheckBoxForText
            // 
            this.DecimalCheckBoxForText.AutoSize = true;
            this.DecimalCheckBoxForText.Location = new System.Drawing.Point(394, 144);
            this.DecimalCheckBoxForText.Name = "DecimalCheckBoxForText";
            this.DecimalCheckBoxForText.Size = new System.Drawing.Size(80, 21);
            this.DecimalCheckBoxForText.TabIndex = 75;
            this.DecimalCheckBoxForText.Text = "Decimal";
            this.DecimalCheckBoxForText.UseVisualStyleBackColor = true;
            this.DecimalCheckBoxForText.CheckedChanged += new System.EventHandler(this.DecimalCheckBoxForText_CheckedChanged);
            // 
            // DecimalCheckBoxForResult
            // 
            this.DecimalCheckBoxForResult.AutoSize = true;
            this.DecimalCheckBoxForResult.Location = new System.Drawing.Point(394, 373);
            this.DecimalCheckBoxForResult.Name = "DecimalCheckBoxForResult";
            this.DecimalCheckBoxForResult.Size = new System.Drawing.Size(80, 21);
            this.DecimalCheckBoxForResult.TabIndex = 76;
            this.DecimalCheckBoxForResult.Text = "Decimal";
            this.DecimalCheckBoxForResult.UseVisualStyleBackColor = true;
            this.DecimalCheckBoxForResult.CheckedChanged += new System.EventHandler(this.DecimalCheckBoxForResult_CheckedChanged);
            // 
            // RC4_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 525);
            this.Controls.Add(this.DecimalCheckBoxForResult);
            this.Controls.Add(this.DecimalCheckBoxForText);
            this.Controls.Add(this.HexCheckBoxForResult);
            this.Controls.Add(this.BinaryCheckBoxForResult);
            this.Controls.Add(this.TextCheckBoxForResult);
            this.Controls.Add(this.HexCheckBoxForKey);
            this.Controls.Add(this.BinaryCheckBoxForKey);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Run_Button);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "RC4_Form";
            this.Text = "RC4_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox EncryptCheckBox;
        private System.Windows.Forms.CheckBox DecrypytCheckBox;
        private System.Windows.Forms.CheckBox TextCheckBoxForText;
        private System.Windows.Forms.CheckBox BinaryCheckBoxForText;
        private System.Windows.Forms.CheckBox HexCheckBoxForText;
        private System.Windows.Forms.CheckBox BinaryCheckBoxForKey;
        private System.Windows.Forms.CheckBox HexCheckBoxForKey;
        private System.Windows.Forms.CheckBox TextCheckBoxForResult;
        private System.Windows.Forms.CheckBox BinaryCheckBoxForResult;
        private System.Windows.Forms.CheckBox HexCheckBoxForResult;
        private System.Windows.Forms.CheckBox DecimalCheckBoxForText;
        private System.Windows.Forms.CheckBox DecimalCheckBoxForResult;
    }
}