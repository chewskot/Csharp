namespace Pokus_1
{
    partial class UpravitOsobuForm
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
            label1 = new Label();
            uprJmenoTxt = new TextBox();
            uprPohlaviCombo = new ComboBox();
            OK = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            uprVekTxt = new TextBox();
            uprPrijmeniTxt = new TextBox();
            uprMistoTxt = new TextBox();
            zrusBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 44);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Jméno";
            // 
            // uprJmenoTxt
            // 
            uprJmenoTxt.Location = new Point(246, 37);
            uprJmenoTxt.Name = "uprJmenoTxt";
            uprJmenoTxt.Size = new Size(125, 27);
            uprJmenoTxt.TabIndex = 1;
            // 
            // uprPohlaviCombo
            // 
            uprPohlaviCombo.FormattingEnabled = true;
            uprPohlaviCombo.Location = new Point(246, 163);
            uprPohlaviCombo.Name = "uprPohlaviCombo";
            uprPohlaviCombo.Size = new Size(151, 28);
            uprPohlaviCombo.TabIndex = 2;
            // 
            // OK
            // 
            OK.Location = new Point(246, 377);
            OK.Name = "OK";
            OK.Size = new Size(94, 29);
            OK.TabIndex = 3;
            OK.Text = "Ulož";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 105);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "Příjmení";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 163);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 5;
            label3.Text = "Pohlaví";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 223);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 6;
            label4.Text = "Věk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 282);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 7;
            label5.Text = "Místo narození";
            // 
            // uprVekTxt
            // 
            uprVekTxt.Location = new Point(246, 223);
            uprVekTxt.Name = "uprVekTxt";
            uprVekTxt.Size = new Size(125, 27);
            uprVekTxt.TabIndex = 8;
            // 
            // uprPrijmeniTxt
            // 
            uprPrijmeniTxt.Location = new Point(246, 105);
            uprPrijmeniTxt.Name = "uprPrijmeniTxt";
            uprPrijmeniTxt.Size = new Size(125, 27);
            uprPrijmeniTxt.TabIndex = 9;
            // 
            // uprMistoTxt
            // 
            uprMistoTxt.Location = new Point(246, 282);
            uprMistoTxt.Name = "uprMistoTxt";
            uprMistoTxt.Size = new Size(125, 27);
            uprMistoTxt.TabIndex = 10;
            // 
            // zrusBtn
            // 
            zrusBtn.Location = new Point(437, 377);
            zrusBtn.Name = "zrusBtn";
            zrusBtn.Size = new Size(94, 29);
            zrusBtn.TabIndex = 11;
            zrusBtn.Text = "Zruš úpravu";
            zrusBtn.UseVisualStyleBackColor = true;
            zrusBtn.Click += zrusBtn_Click;
            // 
            // UpravitOsobuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(zrusBtn);
            Controls.Add(uprMistoTxt);
            Controls.Add(uprPrijmeniTxt);
            Controls.Add(uprVekTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OK);
            Controls.Add(uprPohlaviCombo);
            Controls.Add(uprJmenoTxt);
            Controls.Add(label1);
            Name = "UpravitOsobuForm";
            Text = "UpravitOsobuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox uprJmenoTxt;
        private ComboBox uprPohlaviCombo;
        private Button OK;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox uprVekTxt;
        private TextBox uprPrijmeniTxt;
        private TextBox uprMistoTxt;
        private Button zrusBtn;
    }
}