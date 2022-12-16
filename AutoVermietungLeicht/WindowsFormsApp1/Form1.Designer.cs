
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KnEinzelansicht = new System.Windows.Forms.Button();
            this.KnListenansicht = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FzEinzelansicht = new System.Windows.Forms.Button();
            this.FzListenAnsicht = new System.Windows.Forms.Button();
            this.Fahrzeugliste = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KnEinzelansicht);
            this.groupBox1.Controls.Add(this.KnListenansicht);
            this.groupBox1.Location = new System.Drawing.Point(28, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunden";
            // 
            // KnEinzelansicht
            // 
            this.KnEinzelansicht.Location = new System.Drawing.Point(49, 59);
            this.KnEinzelansicht.Name = "KnEinzelansicht";
            this.KnEinzelansicht.Size = new System.Drawing.Size(92, 23);
            this.KnEinzelansicht.TabIndex = 1;
            this.KnEinzelansicht.Text = "Einzelansicht";
            this.KnEinzelansicht.UseVisualStyleBackColor = true;
            this.KnEinzelansicht.Click += new System.EventHandler(this.Einzelansicht_Click);
            // 
            // KnListenansicht
            // 
            this.KnListenansicht.Location = new System.Drawing.Point(49, 30);
            this.KnListenansicht.Name = "KnListenansicht";
            this.KnListenansicht.Size = new System.Drawing.Size(92, 23);
            this.KnListenansicht.TabIndex = 0;
            this.KnListenansicht.Text = "Listenansicht";
            this.KnListenansicht.UseVisualStyleBackColor = true;
            this.KnListenansicht.Click += new System.EventHandler(this.Listenansicht_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Fahrzeugliste);
            this.groupBox2.Controls.Add(this.FzEinzelansicht);
            this.groupBox2.Controls.Add(this.FzListenAnsicht);
            this.groupBox2.Location = new System.Drawing.Point(324, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fahrzeuge";
            // 
            // FzEinzelansicht
            // 
            this.FzEinzelansicht.Location = new System.Drawing.Point(59, 48);
            this.FzEinzelansicht.Name = "FzEinzelansicht";
            this.FzEinzelansicht.Size = new System.Drawing.Size(102, 23);
            this.FzEinzelansicht.TabIndex = 1;
            this.FzEinzelansicht.Text = "Einzelansicht";
            this.FzEinzelansicht.UseVisualStyleBackColor = true;
            this.FzEinzelansicht.Click += new System.EventHandler(this.FzEinzelansicht_Click);
            // 
            // FzListenAnsicht
            // 
            this.FzListenAnsicht.Location = new System.Drawing.Point(59, 19);
            this.FzListenAnsicht.Name = "FzListenAnsicht";
            this.FzListenAnsicht.Size = new System.Drawing.Size(102, 23);
            this.FzListenAnsicht.TabIndex = 0;
            this.FzListenAnsicht.Text = "ListenAnsicht";
            this.FzListenAnsicht.UseVisualStyleBackColor = true;
            this.FzListenAnsicht.Click += new System.EventHandler(this.FzListenAnsicht_Click);
            // 
            // Fahrzeugliste
            // 
            this.Fahrzeugliste.Location = new System.Drawing.Point(59, 104);
            this.Fahrzeugliste.Name = "Fahrzeugliste";
            this.Fahrzeugliste.Size = new System.Drawing.Size(102, 23);
            this.Fahrzeugliste.TabIndex = 2;
            this.Fahrzeugliste.Text = "Fahrzeugliste";
            this.Fahrzeugliste.UseVisualStyleBackColor = true;
            this.Fahrzeugliste.Click += new System.EventHandler(this.Fahrzeugliste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AutoVermietung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button KnListenansicht;
        private System.Windows.Forms.Button KnEinzelansicht;
        private System.Windows.Forms.Button FzEinzelansicht;
        private System.Windows.Forms.Button FzListenAnsicht;
        private System.Windows.Forms.Button Fahrzeugliste;
    }
}

