
namespace WindowsFormsApp1
{
    partial class Kundenliste
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kundenliste));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kundeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kundeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kundeDataGridView = new System.Windows.Forms.DataGridView();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoDataSet = new WindowsFormsApp1.AutoDataSet();
            this.kundeTableAdapter = new WindowsFormsApp1.AutoDataSetTableAdapters.KundeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.AutoDataSetTableAdapters.TableAdapterManager();
            this.kNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postleitzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingNavigator)).BeginInit();
            this.kundeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kundeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kundeBindingNavigator
            // 
            this.kundeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kundeBindingNavigator.BindingSource = this.kundeBindingSource;
            this.kundeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kundeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kundeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kundeBindingNavigatorSaveItem});
            this.kundeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kundeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kundeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kundeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kundeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kundeBindingNavigator.Name = "kundeBindingNavigator";
            this.kundeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kundeBindingNavigator.Size = new System.Drawing.Size(845, 25);
            this.kundeBindingNavigator.TabIndex = 0;
            this.kundeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // kundeBindingNavigatorSaveItem
            // 
            this.kundeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kundeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kundeBindingNavigatorSaveItem.Image")));
            this.kundeBindingNavigatorSaveItem.Name = "kundeBindingNavigatorSaveItem";
            this.kundeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kundeBindingNavigatorSaveItem.Text = "Save Data";
            this.kundeBindingNavigatorSaveItem.Click += new System.EventHandler(this.kundeBindingNavigatorSaveItem_Click);
            // 
            // kundeDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.kundeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kundeDataGridView.AutoGenerateColumns = false;
            this.kundeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kundeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kNummer,
            this.kName,
            this.vorname,
            this.strasse,
            this.postleitzahl,
            this.ort,
            this.telefon1,
            this.telefon2});
            this.kundeDataGridView.DataSource = this.kundeBindingSource;
            this.kundeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kundeDataGridView.Location = new System.Drawing.Point(0, 25);
            this.kundeDataGridView.Name = "kundeDataGridView";
            this.kundeDataGridView.Size = new System.Drawing.Size(845, 360);
            this.kundeDataGridView.TabIndex = 1;
            this.kundeDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.kundeDataGridView_CellEndEdit);
            this.kundeDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.kundeDataGridView_CellMouseEnter);
            this.kundeDataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.kundeDataGridView_CellMouseLeave);
            this.kundeDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.kundeDataGridView_CellValidating);
            this.kundeDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.kundeDataGridView_DataError);
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            this.kundeBindingSource.DataSource = this.autoDataSet;
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "AutoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = this.kundeTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.AutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kNummer
            // 
            this.kNummer.DataPropertyName = "kNummer";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.kNummer.DefaultCellStyle = dataGridViewCellStyle2;
            this.kNummer.HeaderText = "kNummer";
            this.kNummer.Name = "kNummer";
            this.kNummer.ReadOnly = true;
            this.kNummer.ToolTipText = "Klicken Sie hier, um die Anzeige nach der Kundennummer zu sortieren";
            // 
            // kName
            // 
            this.kName.DataPropertyName = "kName";
            this.kName.HeaderText = "kName";
            this.kName.MaxInputLength = 50;
            this.kName.Name = "kName";
            this.kName.ToolTipText = "Klicken Sie hier, um die Anzeige nach der Kundenname zu sortieren";
            // 
            // vorname
            // 
            this.vorname.DataPropertyName = "vorname";
            this.vorname.HeaderText = "vorname";
            this.vorname.MaxInputLength = 50;
            this.vorname.Name = "vorname";
            this.vorname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // strasse
            // 
            this.strasse.DataPropertyName = "strasse";
            this.strasse.HeaderText = "strasse";
            this.strasse.MaxInputLength = 50;
            this.strasse.Name = "strasse";
            this.strasse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // postleitzahl
            // 
            this.postleitzahl.DataPropertyName = "postleitzahl";
            this.postleitzahl.HeaderText = "postleitzahl";
            this.postleitzahl.MaxInputLength = 5;
            this.postleitzahl.Name = "postleitzahl";
            this.postleitzahl.ToolTipText = "Klicken Sie hier, um die Anzeige nach der Postleitzahl zu sortieren";
            // 
            // ort
            // 
            this.ort.DataPropertyName = "ort";
            this.ort.HeaderText = "ort";
            this.ort.MaxInputLength = 50;
            this.ort.Name = "ort";
            this.ort.ToolTipText = "Klicken Sie hier, um die Anzeige nach der Ort zu sortieren";
            // 
            // telefon1
            // 
            this.telefon1.DataPropertyName = "telefon1";
            this.telefon1.HeaderText = "telefon1";
            this.telefon1.MaxInputLength = 20;
            this.telefon1.Name = "telefon1";
            this.telefon1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // telefon2
            // 
            this.telefon2.DataPropertyName = "telefon2";
            this.telefon2.HeaderText = "telefon2";
            this.telefon2.MaxInputLength = 20;
            this.telefon2.Name = "telefon2";
            this.telefon2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Kundenliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 385);
            this.Controls.Add(this.kundeDataGridView);
            this.Controls.Add(this.kundeBindingNavigator);
            this.Name = "Kundenliste";
            this.Text = "Kundenliste";
            this.Load += new System.EventHandler(this.Kundenliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingNavigator)).EndInit();
            this.kundeBindingNavigator.ResumeLayout(false);
            this.kundeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kundeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private AutoDataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private AutoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kundeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kundeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kundeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn kNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn kName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn strasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn postleitzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ort;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon2;
    }
}