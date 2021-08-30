namespace Cryptographic_Algorithms
{
    partial class Diffie_Hellman_Form
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
            this.Diffie_Button = new System.Windows.Forms.Button();
            this.a_TextBox = new System.Windows.Forms.TextBox();
            this.XA_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.q_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.XB_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YA_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.YB_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.KAB_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Diffie_Button
            // 
            this.Diffie_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diffie_Button.Location = new System.Drawing.Point(536, 618);
            this.Diffie_Button.Name = "Diffie_Button";
            this.Diffie_Button.Size = new System.Drawing.Size(134, 61);
            this.Diffie_Button.TabIndex = 0;
            this.Diffie_Button.Text = "Generate Keys";
            this.Diffie_Button.UseVisualStyleBackColor = true;
            this.Diffie_Button.Click += new System.EventHandler(this.Diffie_Button_Click);
            // 
            // a_TextBox
            // 
            this.a_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_TextBox.Location = new System.Drawing.Point(12, 168);
            this.a_TextBox.Name = "a_TextBox";
            this.a_TextBox.Size = new System.Drawing.Size(584, 34);
            this.a_TextBox.TabIndex = 55;
            // 
            // XA_TextBox
            // 
            this.XA_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XA_TextBox.Location = new System.Drawing.Point(12, 240);
            this.XA_TextBox.Name = "XA_TextBox";
            this.XA_TextBox.Size = new System.Drawing.Size(584, 34);
            this.XA_TextBox.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Secret Key of User A (XA <  q):";
            // 
            // q_TextBox
            // 
            this.q_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_TextBox.Location = new System.Drawing.Point(12, 96);
            this.q_TextBox.Name = "q_TextBox";
            this.q_TextBox.Size = new System.Drawing.Size(584, 34);
            this.q_TextBox.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Large Prime Integer (q):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "Diffie-Hellman Keys Generator Algorithm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Primitive Root (a):";
            // 
            // XB_TextBox
            // 
            this.XB_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB_TextBox.Location = new System.Drawing.Point(12, 312);
            this.XB_TextBox.Name = "XB_TextBox";
            this.XB_TextBox.Size = new System.Drawing.Size(584, 34);
            this.XB_TextBox.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Secret Key of User B (XB <  q):";
            // 
            // YA_TextBox
            // 
            this.YA_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YA_TextBox.Location = new System.Drawing.Point(12, 417);
            this.YA_TextBox.Name = "YA_TextBox";
            this.YA_TextBox.Size = new System.Drawing.Size(584, 34);
            this.YA_TextBox.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Public Key of User A (YA):";
            // 
            // YB_TextBox
            // 
            this.YB_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YB_TextBox.Location = new System.Drawing.Point(12, 488);
            this.YB_TextBox.Name = "YB_TextBox";
            this.YB_TextBox.Size = new System.Drawing.Size(584, 34);
            this.YB_TextBox.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 25);
            this.label7.TabIndex = 60;
            this.label7.Text = "Public Key of User B (YB):";
            // 
            // KAB_TextBox
            // 
            this.KAB_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KAB_TextBox.Location = new System.Drawing.Point(12, 558);
            this.KAB_TextBox.Name = "KAB_TextBox";
            this.KAB_TextBox.Size = new System.Drawing.Size(584, 34);
            this.KAB_TextBox.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 25);
            this.label8.TabIndex = 62;
            this.label8.Text = "Shared Private Key of User A and B (KAB):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(220, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 29);
            this.label9.TabIndex = 64;
            this.label9.Text = "Results";
            // 
            // Diffie_Hellman_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 691);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.KAB_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.YB_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.YA_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.XB_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.a_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.XA_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.q_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Diffie_Button);
            this.Name = "Diffie_Hellman_Form";
            this.Text = "Diffie_Hellman_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Diffie_Button;
        private System.Windows.Forms.TextBox a_TextBox;
        private System.Windows.Forms.TextBox XA_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox q_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox XB_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YA_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox YB_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KAB_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}