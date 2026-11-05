namespace cifrario_cesare
{
    partial class Form1
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
            lbl_n1 = new Label();
            txt_stringa1 = new TextBox();
            btn_cripta1 = new Button();
            txt_stringa2 = new TextBox();
            btn_cripta2 = new Button();
            lbl_n2 = new Label();
            lbl_n3 = new Label();
            lbl_n4 = new Label();
            txt_chiave = new TextBox();
            lbl_risultato1 = new Label();
            lbl_risultato2 = new Label();
            SuspendLayout();
            // 
            // lbl_n1
            // 
            lbl_n1.AutoSize = true;
            lbl_n1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_n1.ForeColor = Color.Turquoise;
            lbl_n1.Location = new Point(144, 24);
            lbl_n1.Name = "lbl_n1";
            lbl_n1.Size = new Size(493, 65);
            lbl_n1.TabIndex = 0;
            lbl_n1.Text = "CIFRARIO DI CESARE";
            // 
            // txt_stringa1
            // 
            txt_stringa1.Location = new Point(133, 135);
            txt_stringa1.Name = "txt_stringa1";
            txt_stringa1.Size = new Size(100, 23);
            txt_stringa1.TabIndex = 1;
            // 
            // btn_cripta1
            // 
            btn_cripta1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_cripta1.ForeColor = Color.Turquoise;
            btn_cripta1.Location = new Point(131, 295);
            btn_cripta1.Name = "btn_cripta1";
            btn_cripta1.Size = new Size(108, 55);
            btn_cripta1.TabIndex = 2;
            btn_cripta1.Text = "CRIPTA";
            btn_cripta1.UseVisualStyleBackColor = true;
            btn_cripta1.Click += btn_n1_Click;
            // 
            // txt_stringa2
            // 
            txt_stringa2.Location = new Point(645, 135);
            txt_stringa2.Name = "txt_stringa2";
            txt_stringa2.Size = new Size(100, 23);
            txt_stringa2.TabIndex = 3;
            // 
            // btn_cripta2
            // 
            btn_cripta2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_cripta2.ForeColor = Color.Turquoise;
            btn_cripta2.Location = new Point(645, 199);
            btn_cripta2.Name = "btn_cripta2";
            btn_cripta2.Size = new Size(100, 55);
            btn_cripta2.TabIndex = 4;
            btn_cripta2.Text = "CRIPTA";
            btn_cripta2.UseVisualStyleBackColor = true;
            // 
            // lbl_n2
            // 
            lbl_n2.AutoSize = true;
            lbl_n2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_n2.Location = new Point(12, 138);
            lbl_n2.Name = "lbl_n2";
            lbl_n2.Size = new Size(106, 15);
            lbl_n2.TabIndex = 5;
            lbl_n2.Text = "insersci la stringa";
            // 
            // lbl_n3
            // 
            lbl_n3.AutoSize = true;
            lbl_n3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_n3.Location = new Point(518, 138);
            lbl_n3.Name = "lbl_n3";
            lbl_n3.Size = new Size(110, 15);
            lbl_n3.TabIndex = 6;
            lbl_n3.Text = "inserisci la stringa";
            // 
            // lbl_n4
            // 
            lbl_n4.AutoSize = true;
            lbl_n4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_n4.ForeColor = Color.Red;
            lbl_n4.Location = new Point(133, 206);
            lbl_n4.Name = "lbl_n4";
            lbl_n4.Size = new Size(106, 15);
            lbl_n4.TabIndex = 7;
            lbl_n4.Text = "inserisci la chiave";
            // 
            // txt_chiave
            // 
            txt_chiave.Location = new Point(136, 231);
            txt_chiave.Name = "txt_chiave";
            txt_chiave.Size = new Size(100, 23);
            txt_chiave.TabIndex = 8;
            // 
            // lbl_risultato1
            // 
            lbl_risultato1.AutoSize = true;
            lbl_risultato1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_risultato1.Location = new Point(144, 401);
            lbl_risultato1.Name = "lbl_risultato1";
            lbl_risultato1.Size = new Size(71, 20);
            lbl_risultato1.TabIndex = 11;
            lbl_risultato1.Text = "risultato";
            // 
            // lbl_risultato2
            // 
            lbl_risultato2.AutoSize = true;
            lbl_risultato2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_risultato2.Location = new Point(659, 295);
            lbl_risultato2.Name = "lbl_risultato2";
            lbl_risultato2.Size = new Size(71, 20);
            lbl_risultato2.TabIndex = 12;
            lbl_risultato2.Text = "risultato";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_risultato2);
            Controls.Add(lbl_risultato1);
            Controls.Add(txt_chiave);
            Controls.Add(lbl_n4);
            Controls.Add(lbl_n3);
            Controls.Add(lbl_n2);
            Controls.Add(btn_cripta2);
            Controls.Add(txt_stringa2);
            Controls.Add(btn_cripta1);
            Controls.Add(txt_stringa1);
            Controls.Add(lbl_n1);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_n1;
        private TextBox txt_stringa1;
        private Button btn_cripta1;
        private TextBox txt_stringa2;
        private Button btn_cripta2;
        private Label lbl_n2;
        private Label lbl_n3;
        private Label lbl_n4;
        private TextBox txt_chiave;
        private Label lbl_risultato1;
        private Label lbl_risultato2;
    }
}
