
namespace Bildbetrachter
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEinzel = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxNeuesFenster = new System.Windows.Forms.CheckBox();
            this.checkBoxOptimaleGrosse = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonOffnen = new System.Windows.Forms.Button();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.tabPageSchau = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonBeenden1 = new System.Windows.Forms.Button();
            this.buttonStarten = new System.Windows.Forms.Button();
            this.buttonAuswaehlen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageEinzel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageSchau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEinzel);
            this.tabControl1.Controls.Add(this.tabPageSchau);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEinzel
            // 
            this.tabPageEinzel.Controls.Add(this.pictureBox1);
            this.tabPageEinzel.Controls.Add(this.checkBoxNeuesFenster);
            this.tabPageEinzel.Controls.Add(this.checkBoxOptimaleGrosse);
            this.tabPageEinzel.Controls.Add(this.textBox1);
            this.tabPageEinzel.Controls.Add(this.buttonBeenden);
            this.tabPageEinzel.Controls.Add(this.buttonOffnen);
            this.tabPageEinzel.Controls.Add(this.buttonAnzeigen);
            this.tabPageEinzel.Location = new System.Drawing.Point(4, 24);
            this.tabPageEinzel.Name = "tabPageEinzel";
            this.tabPageEinzel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEinzel.Size = new System.Drawing.Size(768, 399);
            this.tabPageEinzel.TabIndex = 0;
            this.tabPageEinzel.Text = "Einzelbild";
            this.tabPageEinzel.UseVisualStyleBackColor = true;
            this.tabPageEinzel.Enter += new System.EventHandler(this.tabPageEinzel_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxNeuesFenster
            // 
            this.checkBoxNeuesFenster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNeuesFenster.AutoSize = true;
            this.checkBoxNeuesFenster.Location = new System.Drawing.Point(122, 374);
            this.checkBoxNeuesFenster.Name = "checkBoxNeuesFenster";
            this.checkBoxNeuesFenster.Size = new System.Drawing.Size(100, 19);
            this.checkBoxNeuesFenster.TabIndex = 5;
            this.checkBoxNeuesFenster.Text = "Neues Fenster";
            this.checkBoxNeuesFenster.UseVisualStyleBackColor = true;
            // 
            // checkBoxOptimaleGrosse
            // 
            this.checkBoxOptimaleGrosse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxOptimaleGrosse.AutoSize = true;
            this.checkBoxOptimaleGrosse.Location = new System.Drawing.Point(6, 374);
            this.checkBoxOptimaleGrosse.Name = "checkBoxOptimaleGrosse";
            this.checkBoxOptimaleGrosse.Size = new System.Drawing.Size(110, 19);
            this.checkBoxOptimaleGrosse.TabIndex = 4;
            this.checkBoxOptimaleGrosse.Text = "Optimale Große";
            this.checkBoxOptimaleGrosse.UseVisualStyleBackColor = true;
            this.checkBoxOptimaleGrosse.CheckedChanged += new System.EventHandler(this.checkBoxOptimaleGrosse_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(6, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 23);
            this.textBox1.TabIndex = 3;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.Location = new System.Drawing.Point(687, 62);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 2;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonOffnen
            // 
            this.buttonOffnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOffnen.Location = new System.Drawing.Point(687, 33);
            this.buttonOffnen.Name = "buttonOffnen";
            this.buttonOffnen.Size = new System.Drawing.Size(75, 23);
            this.buttonOffnen.TabIndex = 1;
            this.buttonOffnen.Text = "Offnen";
            this.buttonOffnen.UseVisualStyleBackColor = true;
            this.buttonOffnen.Click += new System.EventHandler(this.buttonOffnen_Click);
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnzeigen.Location = new System.Drawing.Point(687, 4);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.buttonAnzeigen.TabIndex = 0;
            this.buttonAnzeigen.Text = "Anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // tabPageSchau
            // 
            this.tabPageSchau.Controls.Add(this.label1);
            this.tabPageSchau.Controls.Add(this.numericUpDown1);
            this.tabPageSchau.Controls.Add(this.listBox1);
            this.tabPageSchau.Controls.Add(this.buttonBeenden1);
            this.tabPageSchau.Controls.Add(this.buttonStarten);
            this.tabPageSchau.Controls.Add(this.buttonAuswaehlen);
            this.tabPageSchau.Location = new System.Drawing.Point(4, 24);
            this.tabPageSchau.Name = "tabPageSchau";
            this.tabPageSchau.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchau.Size = new System.Drawing.Size(768, 399);
            this.tabPageSchau.TabIndex = 1;
            this.tabPageSchau.Text = "Bilderschau";
            this.tabPageSchau.UseVisualStyleBackColor = true;
            this.tabPageSchau.Enter += new System.EventHandler(this.tabPageSchau_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(720, 53);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 23);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(614, 304);
            this.listBox1.TabIndex = 0;
            // 
            // buttonBeenden1
            // 
            this.buttonBeenden1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden1.Location = new System.Drawing.Point(624, 133);
            this.buttonBeenden1.Name = "buttonBeenden1";
            this.buttonBeenden1.Size = new System.Drawing.Size(138, 29);
            this.buttonBeenden1.TabIndex = 3;
            this.buttonBeenden1.Text = "Beenden";
            this.buttonBeenden1.UseVisualStyleBackColor = true;
            this.buttonBeenden1.Click += new System.EventHandler(this.buttonBeenden1_Click);
            // 
            // buttonStarten
            // 
            this.buttonStarten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStarten.Location = new System.Drawing.Point(624, 82);
            this.buttonStarten.Name = "buttonStarten";
            this.buttonStarten.Size = new System.Drawing.Size(138, 29);
            this.buttonStarten.TabIndex = 2;
            this.buttonStarten.Text = "Starten";
            this.buttonStarten.UseVisualStyleBackColor = true;
            this.buttonStarten.Click += new System.EventHandler(this.buttonStarten_Click);
            // 
            // buttonAuswaehlen
            // 
            this.buttonAuswaehlen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAuswaehlen.Location = new System.Drawing.Point(624, 6);
            this.buttonAuswaehlen.Name = "buttonAuswaehlen";
            this.buttonAuswaehlen.Size = new System.Drawing.Size(138, 29);
            this.buttonAuswaehlen.TabIndex = 1;
            this.buttonAuswaehlen.Text = "Auswaehlen";
            this.buttonAuswaehlen.UseVisualStyleBackColor = true;
            this.buttonAuswaehlen.Click += new System.EventHandler(this.buttonAuswaehlen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Grafikdateien|*.bmp;*.gif;*.jpg;*.png;*.tif;*.wmf|Nur_BMP|*.bmp|Nur_GIF|*.gif|Nur" +
    "_JPG|*.jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Grafikdateien|*.bmp;*.gif;*.jpg;*.png;*.tif;*.wmf|Alle Dateien|*.*";
            this.openFileDialog2.Multiselect = true;
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(624, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sekunden zwischen bilder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bildbetrachter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPageEinzel.ResumeLayout(false);
            this.tabPageEinzel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageSchau.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEinzel;
        private System.Windows.Forms.TabPage tabPageSchau;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonOffnen;
        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.CheckBox checkBoxNeuesFenster;
        private System.Windows.Forms.CheckBox checkBoxOptimaleGrosse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBeenden1;
        private System.Windows.Forms.Button buttonStarten;
        private System.Windows.Forms.Button buttonAuswaehlen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

