
namespace Pong_Spiel
{
    partial class EinstellungenDialog
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
            this.EinstellungenDialogGroupBoxGroesse = new System.Windows.Forms.GroupBox();
            this.radioButtonMaximal = new System.Windows.Forms.RadioButton();
            this.radioButton1024 = new System.Windows.Forms.RadioButton();
            this.radioButton640 = new System.Windows.Forms.RadioButton();
            this.radioButton320 = new System.Windows.Forms.RadioButton();
            this.buttonUbernehmen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.EinstellungenDialogGroupBoxFarben = new System.Windows.Forms.GroupBox();
            this.buttonSpielfeldFarbe = new System.Windows.Forms.Button();
            this.buttonRahmenFarbe = new System.Windows.Forms.Button();
            this.labelSpielfeld = new System.Windows.Forms.Label();
            this.labelRahmen = new System.Windows.Forms.Label();
            this.labelVorschau = new System.Windows.Forms.Label();
            this.panelRahmenVorschau = new System.Windows.Forms.Panel();
            this.panelSpielfeldVorschau = new System.Windows.Forms.Panel();
            this.panelBallVorschau = new System.Windows.Forms.Panel();
            this.panelSchlaegerVorschau = new System.Windows.Forms.Panel();
            this.colorEinstellungenDialog = new System.Windows.Forms.ColorDialog();
            this.EinstellungenDialogGroupBoxGroesse.SuspendLayout();
            this.EinstellungenDialogGroupBoxFarben.SuspendLayout();
            this.panelRahmenVorschau.SuspendLayout();
            this.panelSpielfeldVorschau.SuspendLayout();
            this.SuspendLayout();
            // 
            // EinstellungenDialogGroupBoxGroesse
            // 
            this.EinstellungenDialogGroupBoxGroesse.Controls.Add(this.radioButtonMaximal);
            this.EinstellungenDialogGroupBoxGroesse.Controls.Add(this.radioButton1024);
            this.EinstellungenDialogGroupBoxGroesse.Controls.Add(this.radioButton640);
            this.EinstellungenDialogGroupBoxGroesse.Controls.Add(this.radioButton320);
            this.EinstellungenDialogGroupBoxGroesse.Location = new System.Drawing.Point(16, 14);
            this.EinstellungenDialogGroupBoxGroesse.Name = "EinstellungenDialogGroupBoxGroesse";
            this.EinstellungenDialogGroupBoxGroesse.Size = new System.Drawing.Size(324, 74);
            this.EinstellungenDialogGroupBoxGroesse.TabIndex = 0;
            this.EinstellungenDialogGroupBoxGroesse.TabStop = false;
            this.EinstellungenDialogGroupBoxGroesse.Text = "Größe";
            // 
            // radioButtonMaximal
            // 
            this.radioButtonMaximal.AutoSize = true;
            this.radioButtonMaximal.Location = new System.Drawing.Point(240, 22);
            this.radioButtonMaximal.Name = "radioButtonMaximal";
            this.radioButtonMaximal.Size = new System.Drawing.Size(71, 19);
            this.radioButtonMaximal.TabIndex = 3;
            this.radioButtonMaximal.Text = "Maximal";
            this.radioButtonMaximal.UseVisualStyleBackColor = true;
            // 
            // radioButton1024
            // 
            this.radioButton1024.AutoSize = true;
            this.radioButton1024.Location = new System.Drawing.Point(156, 22);
            this.radioButton1024.Name = "radioButton1024";
            this.radioButton1024.Size = new System.Drawing.Size(78, 19);
            this.radioButton1024.TabIndex = 2;
            this.radioButton1024.Text = "1024 * 768";
            this.radioButton1024.UseVisualStyleBackColor = true;
            // 
            // radioButton640
            // 
            this.radioButton640.AutoSize = true;
            this.radioButton640.Location = new System.Drawing.Point(84, 22);
            this.radioButton640.Name = "radioButton640";
            this.radioButton640.Size = new System.Drawing.Size(66, 19);
            this.radioButton640.TabIndex = 1;
            this.radioButton640.Text = "640*480";
            this.radioButton640.UseVisualStyleBackColor = true;
            // 
            // radioButton320
            // 
            this.radioButton320.AutoSize = true;
            this.radioButton320.Location = new System.Drawing.Point(6, 22);
            this.radioButton320.Name = "radioButton320";
            this.radioButton320.Size = new System.Drawing.Size(72, 19);
            this.radioButton320.TabIndex = 0;
            this.radioButton320.Text = "320 * 320";
            this.radioButton320.UseVisualStyleBackColor = true;
            // 
            // buttonUbernehmen
            // 
            this.buttonUbernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUbernehmen.Location = new System.Drawing.Point(16, 371);
            this.buttonUbernehmen.Name = "buttonUbernehmen";
            this.buttonUbernehmen.Size = new System.Drawing.Size(100, 25);
            this.buttonUbernehmen.TabIndex = 1;
            this.buttonUbernehmen.Text = "Übernehmen";
            this.buttonUbernehmen.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(244, 371);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(100, 25);
            this.buttonAbbrechen.TabIndex = 2;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // EinstellungenDialogGroupBoxFarben
            // 
            this.EinstellungenDialogGroupBoxFarben.Controls.Add(this.buttonSpielfeldFarbe);
            this.EinstellungenDialogGroupBoxFarben.Controls.Add(this.buttonRahmenFarbe);
            this.EinstellungenDialogGroupBoxFarben.Controls.Add(this.labelSpielfeld);
            this.EinstellungenDialogGroupBoxFarben.Controls.Add(this.labelRahmen);
            this.EinstellungenDialogGroupBoxFarben.Location = new System.Drawing.Point(16, 94);
            this.EinstellungenDialogGroupBoxFarben.Name = "EinstellungenDialogGroupBoxFarben";
            this.EinstellungenDialogGroupBoxFarben.Size = new System.Drawing.Size(324, 94);
            this.EinstellungenDialogGroupBoxFarben.TabIndex = 3;
            this.EinstellungenDialogGroupBoxFarben.TabStop = false;
            this.EinstellungenDialogGroupBoxFarben.Text = "Farben";
            // 
            // buttonSpielfeldFarbe
            // 
            this.buttonSpielfeldFarbe.Location = new System.Drawing.Point(84, 53);
            this.buttonSpielfeldFarbe.Name = "buttonSpielfeldFarbe";
            this.buttonSpielfeldFarbe.Size = new System.Drawing.Size(30, 25);
            this.buttonSpielfeldFarbe.TabIndex = 5;
            this.buttonSpielfeldFarbe.Text = "...";
            this.buttonSpielfeldFarbe.UseVisualStyleBackColor = true;
            this.buttonSpielfeldFarbe.Click += new System.EventHandler(this.buttonSpielfeldFarbe_Click);
            // 
            // buttonRahmenFarbe
            // 
            this.buttonRahmenFarbe.Location = new System.Drawing.Point(84, 22);
            this.buttonRahmenFarbe.Name = "buttonRahmenFarbe";
            this.buttonRahmenFarbe.Size = new System.Drawing.Size(30, 25);
            this.buttonRahmenFarbe.TabIndex = 4;
            this.buttonRahmenFarbe.Text = "...";
            this.buttonRahmenFarbe.UseVisualStyleBackColor = true;
            this.buttonRahmenFarbe.Click += new System.EventHandler(this.buttonRahmenFarbe_Click);
            // 
            // labelSpielfeld
            // 
            this.labelSpielfeld.AutoSize = true;
            this.labelSpielfeld.Location = new System.Drawing.Point(27, 63);
            this.labelSpielfeld.Name = "labelSpielfeld";
            this.labelSpielfeld.Size = new System.Drawing.Size(52, 15);
            this.labelSpielfeld.TabIndex = 1;
            this.labelSpielfeld.Text = "Spielfeld";
            // 
            // labelRahmen
            // 
            this.labelRahmen.AutoSize = true;
            this.labelRahmen.Location = new System.Drawing.Point(27, 32);
            this.labelRahmen.Name = "labelRahmen";
            this.labelRahmen.Size = new System.Drawing.Size(51, 15);
            this.labelRahmen.TabIndex = 0;
            this.labelRahmen.Text = "Rahmen";
            // 
            // labelVorschau
            // 
            this.labelVorschau.AutoSize = true;
            this.labelVorschau.Location = new System.Drawing.Point(22, 200);
            this.labelVorschau.Name = "labelVorschau";
            this.labelVorschau.Size = new System.Drawing.Size(58, 15);
            this.labelVorschau.TabIndex = 4;
            this.labelVorschau.Text = "Vorschau:";
            // 
            // panelRahmenVorschau
            // 
            this.panelRahmenVorschau.Controls.Add(this.panelSpielfeldVorschau);
            this.panelRahmenVorschau.Location = new System.Drawing.Point(16, 218);
            this.panelRahmenVorschau.Name = "panelRahmenVorschau";
            this.panelRahmenVorschau.Size = new System.Drawing.Size(324, 116);
            this.panelRahmenVorschau.TabIndex = 5;
            // 
            // panelSpielfeldVorschau
            // 
            this.panelSpielfeldVorschau.Controls.Add(this.panelBallVorschau);
            this.panelSpielfeldVorschau.Controls.Add(this.panelSchlaegerVorschau);
            this.panelSpielfeldVorschau.Location = new System.Drawing.Point(10, 10);
            this.panelSpielfeldVorschau.Name = "panelSpielfeldVorschau";
            this.panelSpielfeldVorschau.Size = new System.Drawing.Size(305, 97);
            this.panelSpielfeldVorschau.TabIndex = 0;
            // 
            // panelBallVorschau
            // 
            this.panelBallVorschau.Location = new System.Drawing.Point(89, 23);
            this.panelBallVorschau.Name = "panelBallVorschau";
            this.panelBallVorschau.Size = new System.Drawing.Size(15, 15);
            this.panelBallVorschau.TabIndex = 1;
            // 
            // panelSchlaegerVorschau
            // 
            this.panelSchlaegerVorschau.Location = new System.Drawing.Point(14, 23);
            this.panelSchlaegerVorschau.Name = "panelSchlaegerVorschau";
            this.panelSchlaegerVorschau.Size = new System.Drawing.Size(15, 60);
            this.panelSchlaegerVorschau.TabIndex = 0;
            // 
            // EinstellungenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 440);
            this.Controls.Add(this.panelRahmenVorschau);
            this.Controls.Add(this.labelVorschau);
            this.Controls.Add(this.EinstellungenDialogGroupBoxFarben);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonUbernehmen);
            this.Controls.Add(this.EinstellungenDialogGroupBoxGroesse);
            this.Name = "EinstellungenDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EinstellungenDialog";
            this.EinstellungenDialogGroupBoxGroesse.ResumeLayout(false);
            this.EinstellungenDialogGroupBoxGroesse.PerformLayout();
            this.EinstellungenDialogGroupBoxFarben.ResumeLayout(false);
            this.EinstellungenDialogGroupBoxFarben.PerformLayout();
            this.panelRahmenVorschau.ResumeLayout(false);
            this.panelSpielfeldVorschau.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EinstellungenDialogGroupBoxGroesse;
        private System.Windows.Forms.Button buttonUbernehmen;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.RadioButton radioButtonMaximal;
        private System.Windows.Forms.RadioButton radioButton1024;
        private System.Windows.Forms.RadioButton radioButton640;
        private System.Windows.Forms.RadioButton radioButton320;
        private System.Windows.Forms.GroupBox EinstellungenDialogGroupBoxFarben;
        private System.Windows.Forms.Label labelSpielfeld;
        private System.Windows.Forms.Label labelRahmen;
        private System.Windows.Forms.Label labelVorschau;
        private System.Windows.Forms.Button buttonSpielfeldFarbe;
        private System.Windows.Forms.Button buttonRahmenFarbe;
        private System.Windows.Forms.Panel panelRahmenVorschau;
        private System.Windows.Forms.ColorDialog colorEinstellungenDialog;
        private System.Windows.Forms.Panel panelSpielfeldVorschau;
        private System.Windows.Forms.Panel panelBallVorschau;
        private System.Windows.Forms.Panel panelSchlaegerVorschau;
    }
}