namespace Pokus_1
{
    partial class SpravaOsobForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUploadGrid = new Button();
            vekTxt = new TextBox();
            prijmeniTxt = new TextBox();
            mistoTxt = new TextBox();
            jmenoTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pohlaviCombo = new ComboBox();
            testDataBtn = new Button();
            dataGridView1 = new DataGridView();
            exportCsvBtn = new Button();
            uploadCsvBtn = new Button();
            dtbUlozBtn = new Button();
            smazOsobuBtn = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnUploadGrid
            // 
            btnUploadGrid.Location = new Point(626, 375);
            btnUploadGrid.Name = "btnUploadGrid";
            btnUploadGrid.Size = new Size(183, 29);
            btnUploadGrid.TabIndex = 0;
            btnUploadGrid.Text = "Uploadni do Gridu";
            btnUploadGrid.UseVisualStyleBackColor = true;
            btnUploadGrid.Click += button1_Click;
            // 
            // vekTxt
            // 
            vekTxt.Location = new Point(338, 228);
            vekTxt.Name = "vekTxt";
            vekTxt.Size = new Size(125, 27);
            vekTxt.TabIndex = 1;
            // 
            // prijmeniTxt
            // 
            prijmeniTxt.Location = new Point(192, 228);
            prijmeniTxt.Name = "prijmeniTxt";
            prijmeniTxt.Size = new Size(125, 27);
            prijmeniTxt.TabIndex = 3;
            // 
            // mistoTxt
            // 
            mistoTxt.Location = new Point(653, 228);
            mistoTxt.Name = "mistoTxt";
            mistoTxt.Size = new Size(125, 27);
            mistoTxt.TabIndex = 4;
            // 
            // jmenoTxt
            // 
            jmenoTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            jmenoTxt.Location = new Point(37, 228);
            jmenoTxt.Name = "jmenoTxt";
            jmenoTxt.Size = new Size(125, 27);
            jmenoTxt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 197);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 6;
            label1.Text = "jméno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 197);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 7;
            label2.Text = "věk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(678, 197);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 8;
            label3.Text = "Místo narození";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 197);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 9;
            label4.Text = "pohlaví";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 197);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 10;
            label5.Text = "přijmení";
            // 
            // pohlaviCombo
            // 
            pohlaviCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            pohlaviCombo.FormattingEnabled = true;
            pohlaviCombo.Location = new Point(482, 228);
            pohlaviCombo.Name = "pohlaviCombo";
            pohlaviCombo.Size = new Size(151, 28);
            pohlaviCombo.TabIndex = 11;
            // 
            // testDataBtn
            // 
            testDataBtn.Location = new Point(664, 94);
            testDataBtn.Name = "testDataBtn";
            testDataBtn.Size = new Size(131, 29);
            testDataBtn.TabIndex = 12;
            testDataBtn.Text = "testovaci data";
            testDataBtn.UseVisualStyleBackColor = true;
            testDataBtn.Click += testDataBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(811, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(533, 299);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // exportCsvBtn
            // 
            exportCsvBtn.Anchor = AnchorStyles.Top;
            exportCsvBtn.Location = new Point(27, 375);
            exportCsvBtn.Name = "exportCsvBtn";
            exportCsvBtn.Size = new Size(202, 29);
            exportCsvBtn.TabIndex = 15;
            exportCsvBtn.Text = "Export do CSV Souboru";
            exportCsvBtn.UseVisualStyleBackColor = true;
            exportCsvBtn.Click += exportCsvBtn_Click;
            // 
            // uploadCsvBtn
            // 
            uploadCsvBtn.Anchor = AnchorStyles.Top;
            uploadCsvBtn.Location = new Point(262, 373);
            uploadCsvBtn.Margin = new Padding(3, 4, 3, 4);
            uploadCsvBtn.Name = "uploadCsvBtn";
            uploadCsvBtn.Size = new Size(144, 31);
            uploadCsvBtn.TabIndex = 16;
            uploadCsvBtn.Text = "Nahrání dat z CSV";
            uploadCsvBtn.UseVisualStyleBackColor = true;
            uploadCsvBtn.Click += uploadCsvBtn_Click;
            // 
            // dtbUlozBtn
            // 
            dtbUlozBtn.Anchor = AnchorStyles.Top;
            dtbUlozBtn.Location = new Point(428, 373);
            dtbUlozBtn.Name = "dtbUlozBtn";
            dtbUlozBtn.Size = new Size(178, 29);
            dtbUlozBtn.TabIndex = 17;
            dtbUlozBtn.Text = "Ulož do databáze";
            dtbUlozBtn.UseVisualStyleBackColor = true;
            dtbUlozBtn.Click += dtbUlozBtn_Click;
            // 
            // smazOsobuBtn
            // 
            smazOsobuBtn.Anchor = AnchorStyles.Top;
            smazOsobuBtn.Location = new Point(460, 314);
            smazOsobuBtn.Name = "smazOsobuBtn";
            smazOsobuBtn.Size = new Size(135, 29);
            smazOsobuBtn.TabIndex = 18;
            smazOsobuBtn.Text = "Smaž osobu";
            smazOsobuBtn.UseVisualStyleBackColor = true;
            smazOsobuBtn.Click += smazOsobuBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1346, 38);
            panel1.TabIndex = 19;
            // 
            // ZakladniMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 451);
            Controls.Add(smazOsobuBtn);
            Controls.Add(exportCsvBtn);
            Controls.Add(uploadCsvBtn);
            Controls.Add(btnUploadGrid);
            Controls.Add(dtbUlozBtn);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(pohlaviCombo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(testDataBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(jmenoTxt);
            Controls.Add(mistoTxt);
            Controls.Add(prijmeniTxt);
            Controls.Add(vekTxt);
            Name = "ZakladniMenuForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUploadGrid;
        private TextBox vekTxt;
        private TextBox prijmeniTxt;
        private TextBox mistoTxt;
        private TextBox jmenoTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox pohlaviCombo;
        private Button testDataBtn;
        private DataGridView dataGridView1;
        private Button exportCsvBtn;
        private Button uploadCsvBtn;
        private Button dtbUlozBtn;
        private Button smazOsobuBtn;
        private Panel panel1;
    }
}