namespace Pokus_1.Formy
{
    partial class SpravaObchoduForm
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            odebraniObchoduBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(460, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(55, 239);
            button1.Name = "button1";
            button1.Size = new Size(172, 29);
            button1.TabIndex = 1;
            button1.Text = "Přidání obchodu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // odebraniObchoduBtn
            // 
            odebraniObchoduBtn.Location = new Point(55, 298);
            odebraniObchoduBtn.Name = "odebraniObchoduBtn";
            odebraniObchoduBtn.Size = new Size(172, 29);
            odebraniObchoduBtn.TabIndex = 2;
            odebraniObchoduBtn.Text = "Odebrání Obchodu";
            odebraniObchoduBtn.UseVisualStyleBackColor = true;
            odebraniObchoduBtn.Click += odebraniObchoduBtn_Click;
            // 
            // SpravaObchoduForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(odebraniObchoduBtn);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "SpravaObchoduForm";
            Text = "SpravaObchoduForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button odebraniObchoduBtn;
    }
}