
namespace Grafische_Spielerei
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLinieFarbe = new System.Windows.Forms.Button();
            this.panelLinieFarbeVorschau = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownLinieStaerke = new System.Windows.Forms.NumericUpDown();
            this.listBoxLinieStil = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonHintergrundFarbe = new System.Windows.Forms.Button();
            this.panelHintergrundFarbeVorschau = new System.Windows.Forms.Panel();
            this.listBoxHintergrundMuster = new System.Windows.Forms.ListBox();
            this.radioButtonHintergrundMuster = new System.Windows.Forms.RadioButton();
            this.radioButtonHintergrundFarbe = new System.Windows.Forms.RadioButton();
            this.radioButtonHintergrundOhne = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonFigurKreis = new System.Windows.Forms.RadioButton();
            this.radioButtonFigurLinie = new System.Windows.Forms.RadioButton();
            this.radioButtonFigurRechteck = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonSpielerei = new System.Windows.Forms.Button();
            this.colorDialogFarbeLinie = new System.Windows.Forms.ColorDialog();
            this.numericUpDownAnimWiederholung = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownAnimGeschwindigkeit = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLinieStaerke)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimWiederholung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimGeschwindigkeit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonLinieFarbe);
            this.groupBox1.Controls.Add(this.panelLinieFarbeVorschau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownLinieStaerke);
            this.groupBox1.Controls.Add(this.listBoxLinieStil);
            this.groupBox1.Location = new System.Drawing.Point(492, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linie";
            // 
            // buttonLinieFarbe
            // 
            this.buttonLinieFarbe.Location = new System.Drawing.Point(111, 14);
            this.buttonLinieFarbe.Name = "buttonLinieFarbe";
            this.buttonLinieFarbe.Size = new System.Drawing.Size(25, 25);
            this.buttonLinieFarbe.TabIndex = 7;
            this.buttonLinieFarbe.Text = "...";
            this.buttonLinieFarbe.UseVisualStyleBackColor = true;
            this.buttonLinieFarbe.Click += new System.EventHandler(this.buttonLinieFarbe_Click);
            // 
            // panelLinieFarbeVorschau
            // 
            this.panelLinieFarbeVorschau.Location = new System.Drawing.Point(75, 14);
            this.panelLinieFarbeVorschau.Name = "panelLinieFarbeVorschau";
            this.panelLinieFarbeVorschau.Size = new System.Drawing.Size(25, 25);
            this.panelLinieFarbeVorschau.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stärke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Farbe";
            // 
            // numericUpDownLinieStaerke
            // 
            this.numericUpDownLinieStaerke.Location = new System.Drawing.Point(75, 83);
            this.numericUpDownLinieStaerke.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLinieStaerke.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLinieStaerke.Name = "numericUpDownLinieStaerke";
            this.numericUpDownLinieStaerke.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownLinieStaerke.TabIndex = 2;
            this.numericUpDownLinieStaerke.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxLinieStil
            // 
            this.listBoxLinieStil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxLinieStil.FormattingEnabled = true;
            this.listBoxLinieStil.ItemHeight = 15;
            this.listBoxLinieStil.Location = new System.Drawing.Point(75, 43);
            this.listBoxLinieStil.Name = "listBoxLinieStil";
            this.listBoxLinieStil.Size = new System.Drawing.Size(120, 34);
            this.listBoxLinieStil.TabIndex = 1;
            this.listBoxLinieStil.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxLinieStil_DrawItem);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonHintergrundFarbe);
            this.groupBox2.Controls.Add(this.panelHintergrundFarbeVorschau);
            this.groupBox2.Controls.Add(this.listBoxHintergrundMuster);
            this.groupBox2.Controls.Add(this.radioButtonHintergrundMuster);
            this.groupBox2.Controls.Add(this.radioButtonHintergrundFarbe);
            this.groupBox2.Controls.Add(this.radioButtonHintergrundOhne);
            this.groupBox2.Location = new System.Drawing.Point(492, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hintergrund";
            // 
            // buttonHintergrundFarbe
            // 
            this.buttonHintergrundFarbe.Location = new System.Drawing.Point(111, 37);
            this.buttonHintergrundFarbe.Name = "buttonHintergrundFarbe";
            this.buttonHintergrundFarbe.Size = new System.Drawing.Size(25, 25);
            this.buttonHintergrundFarbe.TabIndex = 6;
            this.buttonHintergrundFarbe.Text = "...";
            this.buttonHintergrundFarbe.UseVisualStyleBackColor = true;
            this.buttonHintergrundFarbe.Click += new System.EventHandler(this.buttonHintergrundFarbe_Click);
            // 
            // panelHintergrundFarbeVorschau
            // 
            this.panelHintergrundFarbeVorschau.Location = new System.Drawing.Point(79, 37);
            this.panelHintergrundFarbeVorschau.Name = "panelHintergrundFarbeVorschau";
            this.panelHintergrundFarbeVorschau.Size = new System.Drawing.Size(25, 25);
            this.panelHintergrundFarbeVorschau.TabIndex = 5;
            // 
            // listBoxHintergrundMuster
            // 
            this.listBoxHintergrundMuster.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxHintergrundMuster.FormattingEnabled = true;
            this.listBoxHintergrundMuster.ItemHeight = 15;
            this.listBoxHintergrundMuster.Location = new System.Drawing.Point(79, 68);
            this.listBoxHintergrundMuster.Name = "listBoxHintergrundMuster";
            this.listBoxHintergrundMuster.Size = new System.Drawing.Size(121, 34);
            this.listBoxHintergrundMuster.TabIndex = 4;
            this.listBoxHintergrundMuster.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxHintergrundMuster_DrawItem);
            // 
            // radioButtonHintergrundMuster
            // 
            this.radioButtonHintergrundMuster.AutoSize = true;
            this.radioButtonHintergrundMuster.Location = new System.Drawing.Point(12, 68);
            this.radioButtonHintergrundMuster.Name = "radioButtonHintergrundMuster";
            this.radioButtonHintergrundMuster.Size = new System.Drawing.Size(62, 19);
            this.radioButtonHintergrundMuster.TabIndex = 2;
            this.radioButtonHintergrundMuster.TabStop = true;
            this.radioButtonHintergrundMuster.Text = "Muster";
            this.radioButtonHintergrundMuster.UseVisualStyleBackColor = true;
            // 
            // radioButtonHintergrundFarbe
            // 
            this.radioButtonHintergrundFarbe.AutoSize = true;
            this.radioButtonHintergrundFarbe.Location = new System.Drawing.Point(12, 43);
            this.radioButtonHintergrundFarbe.Name = "radioButtonHintergrundFarbe";
            this.radioButtonHintergrundFarbe.Size = new System.Drawing.Size(54, 19);
            this.radioButtonHintergrundFarbe.TabIndex = 1;
            this.radioButtonHintergrundFarbe.TabStop = true;
            this.radioButtonHintergrundFarbe.Text = "Farbe";
            this.radioButtonHintergrundFarbe.UseVisualStyleBackColor = true;
            // 
            // radioButtonHintergrundOhne
            // 
            this.radioButtonHintergrundOhne.AutoSize = true;
            this.radioButtonHintergrundOhne.Checked = true;
            this.radioButtonHintergrundOhne.Location = new System.Drawing.Point(12, 22);
            this.radioButtonHintergrundOhne.Name = "radioButtonHintergrundOhne";
            this.radioButtonHintergrundOhne.Size = new System.Drawing.Size(54, 19);
            this.radioButtonHintergrundOhne.TabIndex = 0;
            this.radioButtonHintergrundOhne.TabStop = true;
            this.radioButtonHintergrundOhne.Text = "Ohne";
            this.radioButtonHintergrundOhne.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.radioButtonFigurKreis);
            this.groupBox3.Controls.Add(this.radioButtonFigurLinie);
            this.groupBox3.Controls.Add(this.radioButtonFigurRechteck);
            this.groupBox3.Location = new System.Drawing.Point(492, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 46);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Figur";
            // 
            // radioButtonFigurKreis
            // 
            this.radioButtonFigurKreis.AutoSize = true;
            this.radioButtonFigurKreis.Checked = true;
            this.radioButtonFigurKreis.Location = new System.Drawing.Point(15, 22);
            this.radioButtonFigurKreis.Name = "radioButtonFigurKreis";
            this.radioButtonFigurKreis.Size = new System.Drawing.Size(50, 19);
            this.radioButtonFigurKreis.TabIndex = 2;
            this.radioButtonFigurKreis.TabStop = true;
            this.radioButtonFigurKreis.Text = "Kreis";
            this.radioButtonFigurKreis.UseVisualStyleBackColor = true;
            // 
            // radioButtonFigurLinie
            // 
            this.radioButtonFigurLinie.AutoSize = true;
            this.radioButtonFigurLinie.Location = new System.Drawing.Point(150, 22);
            this.radioButtonFigurLinie.Name = "radioButtonFigurLinie";
            this.radioButtonFigurLinie.Size = new System.Drawing.Size(50, 19);
            this.radioButtonFigurLinie.TabIndex = 1;
            this.radioButtonFigurLinie.TabStop = true;
            this.radioButtonFigurLinie.Text = "Linie";
            this.radioButtonFigurLinie.UseVisualStyleBackColor = true;
            // 
            // radioButtonFigurRechteck
            // 
            this.radioButtonFigurRechteck.AutoSize = true;
            this.radioButtonFigurRechteck.Location = new System.Drawing.Point(71, 22);
            this.radioButtonFigurRechteck.Name = "radioButtonFigurRechteck";
            this.radioButtonFigurRechteck.Size = new System.Drawing.Size(73, 19);
            this.radioButtonFigurRechteck.TabIndex = 0;
            this.radioButtonFigurRechteck.TabStop = true;
            this.radioButtonFigurRechteck.Text = "Rechteck";
            this.radioButtonFigurRechteck.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(492, 296);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(212, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(413, 468);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(91, 28);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Zeichnen";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoeschen.Location = new System.Drawing.Point(510, 467);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(91, 28);
            this.buttonLoeschen.TabIndex = 6;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.Location = new System.Drawing.Point(607, 468);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(91, 28);
            this.buttonBeenden.TabIndex = 7;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonSpielerei
            // 
            this.buttonSpielerei.BackColor = System.Drawing.Color.Chocolate;
            this.buttonSpielerei.Location = new System.Drawing.Point(120, 418);
            this.buttonSpielerei.Name = "buttonSpielerei";
            this.buttonSpielerei.Size = new System.Drawing.Size(203, 63);
            this.buttonSpielerei.TabIndex = 8;
            this.buttonSpielerei.Text = "Animation starten";
            this.buttonSpielerei.UseVisualStyleBackColor = false;
            this.buttonSpielerei.Click += new System.EventHandler(this.buttonSpielerei_Click);
            // 
            // numericUpDownAnimWiederholung
            // 
            this.numericUpDownAnimWiederholung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownAnimWiederholung.Location = new System.Drawing.Point(636, 331);
            this.numericUpDownAnimWiederholung.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAnimWiederholung.Name = "numericUpDownAnimWiederholung";
            this.numericUpDownAnimWiederholung.Size = new System.Drawing.Size(56, 23);
            this.numericUpDownAnimWiederholung.TabIndex = 9;
            this.numericUpDownAnimWiederholung.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(504, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Animation spielen";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(492, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 47);
            this.label5.TabIndex = 12;
            this.label5.Text = "Animation geschwindigkeit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownAnimGeschwindigkeit
            // 
            this.numericUpDownAnimGeschwindigkeit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownAnimGeschwindigkeit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAnimGeschwindigkeit.Location = new System.Drawing.Point(636, 377);
            this.numericUpDownAnimGeschwindigkeit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAnimGeschwindigkeit.Name = "numericUpDownAnimGeschwindigkeit";
            this.numericUpDownAnimGeschwindigkeit.Size = new System.Drawing.Size(56, 23);
            this.numericUpDownAnimGeschwindigkeit.TabIndex = 13;
            this.numericUpDownAnimGeschwindigkeit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 507);
            this.Controls.Add(this.numericUpDownAnimGeschwindigkeit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownAnimWiederholung);
            this.Controls.Add(this.buttonSpielerei);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLinieStaerke)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimWiederholung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimGeschwindigkeit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownLinieStaerke;
        private System.Windows.Forms.ListBox listBoxLinieStil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxHintergrundMuster;
        private System.Windows.Forms.RadioButton radioButtonHintergrundMuster;
        private System.Windows.Forms.RadioButton radioButtonHintergrundFarbe;
        private System.Windows.Forms.RadioButton radioButtonHintergrundOhne;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonFigurKreis;
        private System.Windows.Forms.RadioButton radioButtonFigurLinie;
        private System.Windows.Forms.RadioButton radioButtonFigurRechteck;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonSpielerei;
        private System.Windows.Forms.Button buttonLinieFarbe;
        private System.Windows.Forms.Panel panelLinieFarbeVorschau;
        private System.Windows.Forms.ColorDialog colorDialogFarbeLinie;
        private System.Windows.Forms.Button buttonHintergrundFarbe;
        private System.Windows.Forms.Panel panelHintergrundFarbeVorschau;
        private System.Windows.Forms.NumericUpDown numericUpDownAnimWiederholung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownAnimGeschwindigkeit;
    }
}

