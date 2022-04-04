
namespace Pong_Spiel
{
    partial class NameDialog
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
            this.textBoxNameDialogNamen = new System.Windows.Forms.TextBox();
            this.buttonNameDialogUbernehmen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNameDialogNamen
            // 
            this.textBoxNameDialogNamen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameDialogNamen.Location = new System.Drawing.Point(12, 27);
            this.textBoxNameDialogNamen.Name = "textBoxNameDialogNamen";
            this.textBoxNameDialogNamen.Size = new System.Drawing.Size(179, 23);
            this.textBoxNameDialogNamen.TabIndex = 0;
            // 
            // buttonNameDialogUbernehmen
            // 
            this.buttonNameDialogUbernehmen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNameDialogUbernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonNameDialogUbernehmen.Location = new System.Drawing.Point(58, 56);
            this.buttonNameDialogUbernehmen.Name = "buttonNameDialogUbernehmen";
            this.buttonNameDialogUbernehmen.Size = new System.Drawing.Size(92, 26);
            this.buttonNameDialogUbernehmen.TabIndex = 1;
            this.buttonNameDialogUbernehmen.Text = "Übernehmen";
            this.buttonNameDialogUbernehmen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bitte geben Sie Ihren Namen ein:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 94);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNameDialogUbernehmen);
            this.Controls.Add(this.textBoxNameDialogNamen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NameDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameDialogNamen;
        private System.Windows.Forms.Button buttonNameDialogUbernehmen;
        private System.Windows.Forms.Label label1;
    }
}