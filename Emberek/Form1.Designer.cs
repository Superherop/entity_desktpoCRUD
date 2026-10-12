namespace Emberek
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
            lstEmberek = new ListBox();
            lblNev = new Label();
            txtNev = new TextBox();
            lblEletkor = new Label();
            txtEletkor = new TextBox();
            btnMentes = new Button();
            btnModositas = new Button();
            btnTorles = new Button();
            SuspendLayout();
            // 
            // lstEmberek
            // 
            lstEmberek.FormattingEnabled = true;
            lstEmberek.Location = new Point(12, 12);
            lstEmberek.Name = "lstEmberek";
            lstEmberek.Size = new Size(202, 304);
            lstEmberek.TabIndex = 0;
            // 
            // lblNev
            // 
            lblNev.AutoSize = true;
            lblNev.Location = new Point(229, 9);
            lblNev.Name = "lblNev";
            lblNev.Size = new Size(28, 15);
            lblNev.TabIndex = 1;
            lblNev.Text = "Név";
            // 
            // txtNev
            // 
            txtNev.Location = new Point(229, 36);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(100, 23);
            txtNev.TabIndex = 2;
            // 
            // lblEletkor
            // 
            lblEletkor.AutoSize = true;
            lblEletkor.Location = new Point(229, 73);
            lblEletkor.Name = "lblEletkor";
            lblEletkor.Size = new Size(43, 15);
            lblEletkor.TabIndex = 1;
            lblEletkor.Text = "Életkor";
            // 
            // txtEletkor
            // 
            txtEletkor.Location = new Point(229, 105);
            txtEletkor.Name = "txtEletkor";
            txtEletkor.Size = new Size(100, 23);
            txtEletkor.TabIndex = 2;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(232, 153);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(75, 50);
            btnMentes.TabIndex = 3;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // btnModositas
            // 
            btnModositas.Location = new Point(334, 153);
            btnModositas.Name = "btnModositas";
            btnModositas.Size = new Size(75, 50);
            btnModositas.TabIndex = 3;
            btnModositas.Text = "Módosítás";
            btnModositas.UseVisualStyleBackColor = true;
            // 
            // btnTorles
            // 
            btnTorles.Location = new Point(232, 255);
            btnTorles.Name = "btnTorles";
            btnTorles.Size = new Size(75, 50);
            btnTorles.TabIndex = 3;
            btnTorles.Text = "Törlés";
            btnTorles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 450);
            Controls.Add(btnTorles);
            Controls.Add(btnModositas);
            Controls.Add(btnMentes);
            Controls.Add(txtEletkor);
            Controls.Add(txtNev);
            Controls.Add(lblEletkor);
            Controls.Add(lblNev);
            Controls.Add(lstEmberek);
            Name = "Form1";
            Text = "Emberek Nyílvántartása";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmberek;
        private Label lblNev;
        private TextBox txtNev;
        private Label lblEletkor;
        private TextBox txtEletkor;
        private Button btnMentes;
        private Button btnModositas;
        private Button btnTorles;
    }
}
