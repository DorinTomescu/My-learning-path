
namespace Taschenrechner_lite
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
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.labelErgebnis = new System.Windows.Forms.Label();
            this.labelAnzeige = new System.Windows.Forms.Label();
            this.comboBoxOperationen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(12, 11);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(118, 23);
            this.textBoxZahl1.TabIndex = 0;
            this.textBoxZahl1.Text = "0";
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(12, 40);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(118, 23);
            this.textBoxZahl2.TabIndex = 1;
            this.textBoxZahl2.Text = "0";
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(12, 128);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(118, 21);
            this.buttonBerechnen.TabIndex = 5;
            this.buttonBerechnen.Text = "Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(234, 128);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(129, 20);
            this.buttonBeenden.TabIndex = 6;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.ButtonBeenden_Click);
            // 
            // labelErgebnis
            // 
            this.labelErgebnis.AutoSize = true;
            this.labelErgebnis.Location = new System.Drawing.Point(12, 110);
            this.labelErgebnis.Name = "labelErgebnis";
            this.labelErgebnis.Size = new System.Drawing.Size(55, 15);
            this.labelErgebnis.TabIndex = 2;
            this.labelErgebnis.Text = "Ergebnis:";
            // 
            // labelAnzeige
            // 
            this.labelAnzeige.AutoSize = true;
            this.labelAnzeige.Location = new System.Drawing.Point(73, 110);
            this.labelAnzeige.Name = "labelAnzeige";
            this.labelAnzeige.Size = new System.Drawing.Size(13, 15);
            this.labelAnzeige.TabIndex = 3;
            this.labelAnzeige.Text = "0";
            // 
            // comboBoxOperationen
            // 
            this.comboBoxOperationen.FormattingEnabled = true;
            this.comboBoxOperationen.Items.AddRange(new object[] {
            "Addition",
            "Subtraktion",
            "Division",
            "Multiplikation"});
            this.comboBoxOperationen.Location = new System.Drawing.Point(234, 12);
            this.comboBoxOperationen.Name = "comboBoxOperationen";
            this.comboBoxOperationen.Size = new System.Drawing.Size(129, 23);
            this.comboBoxOperationen.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.comboBoxOperationen);
            this.Controls.Add(this.labelAnzeige);
            this.Controls.Add(this.labelErgebnis);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonBerechnen);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taschenrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Label labelErgebnis;
        private System.Windows.Forms.Label labelAnzeige;
        private System.Windows.Forms.ComboBox comboBoxOperationen;
    }
}

