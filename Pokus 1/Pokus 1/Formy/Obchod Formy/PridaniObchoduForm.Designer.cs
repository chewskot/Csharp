namespace Pokus_1.Formy.Obchod_Formy
{
    partial class PridaniObchoduForm
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
            nazevObchoduTxt = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            telefonTxt = new TextBox();
            uliceTxt = new TextBox();
            cisloTxt = new TextBox();
            statTxt = new TextBox();
            mestoTxt = new TextBox();
            pscTxt = new TextBox();
            label8 = new Label();
            manazerCombo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Název obchodu";
            // 
            // nazevObchoduTxt
            // 
            nazevObchoduTxt.Location = new Point(347, 19);
            nazevObchoduTxt.Name = "nazevObchoduTxt";
            nazevObchoduTxt.Size = new Size(125, 27);
            nazevObchoduTxt.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(143, 392);
            button1.Name = "button1";
            button1.Size = new Size(224, 29);
            button1.TabIndex = 2;
            button1.Text = "Přidat Obchod do řetezce";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 70);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 119);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Název Ulice";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 222);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 5;
            label4.Text = "Stát";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 170);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 6;
            label5.Text = "Číslo baráku";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 315);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 7;
            label6.Text = "PSČ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(143, 272);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 8;
            label7.Text = "Město";
            // 
            // button2
            // 
            button2.Location = new Point(402, 392);
            button2.Name = "button2";
            button2.Size = new Size(224, 29);
            button2.TabIndex = 9;
            button2.Text = "Zrušit přidávání";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // telefonTxt
            // 
            telefonTxt.Location = new Point(347, 70);
            telefonTxt.Name = "telefonTxt";
            telefonTxt.Size = new Size(125, 27);
            telefonTxt.TabIndex = 10;
            // 
            // uliceTxt
            // 
            uliceTxt.Location = new Point(347, 119);
            uliceTxt.Name = "uliceTxt";
            uliceTxt.Size = new Size(125, 27);
            uliceTxt.TabIndex = 11;
            // 
            // cisloTxt
            // 
            cisloTxt.Location = new Point(347, 170);
            cisloTxt.Name = "cisloTxt";
            cisloTxt.Size = new Size(125, 27);
            cisloTxt.TabIndex = 12;
            // 
            // statTxt
            // 
            statTxt.Location = new Point(347, 222);
            statTxt.Name = "statTxt";
            statTxt.Size = new Size(125, 27);
            statTxt.TabIndex = 13;
            // 
            // mestoTxt
            // 
            mestoTxt.Location = new Point(347, 272);
            mestoTxt.Name = "mestoTxt";
            mestoTxt.Size = new Size(125, 27);
            mestoTxt.TabIndex = 14;
            // 
            // pscTxt
            // 
            pscTxt.Location = new Point(347, 315);
            pscTxt.Name = "pscTxt";
            pscTxt.Size = new Size(125, 27);
            pscTxt.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(144, 358);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 16;
            label8.Text = "Manažer";
            // 
            // manazerCombo
            // 
            manazerCombo.FormattingEnabled = true;
            manazerCombo.Location = new Point(347, 358);
            manazerCombo.Name = "manazerCombo";
            manazerCombo.Size = new Size(151, 28);
            manazerCombo.TabIndex = 17;
            // 
            // PridaniObchoduForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(manazerCombo);
            Controls.Add(label8);
            Controls.Add(pscTxt);
            Controls.Add(mestoTxt);
            Controls.Add(statTxt);
            Controls.Add(cisloTxt);
            Controls.Add(uliceTxt);
            Controls.Add(telefonTxt);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(nazevObchoduTxt);
            Controls.Add(label1);
            Name = "PridaniObchoduForm";
            Text = "PridaniObchoduForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nazevObchoduTxt;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private TextBox telefonTxt;
        private TextBox uliceTxt;
        private TextBox cisloTxt;
        private TextBox statTxt;
        private TextBox mestoTxt;
        private TextBox pscTxt;
        private Label label8;
        private ComboBox manazerCombo;
    }
}