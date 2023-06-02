namespace Ejemplo12C2023G1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idespecialidadLabel;
            System.Windows.Forms.Label nom_especialidadLabel;
            System.Windows.Forms.Label area_especialiadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database1DataSet = new Ejemplo12C2023G1.Database1DataSet();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadTableAdapter = new Ejemplo12C2023G1.Database1DataSetTableAdapters.especialidadTableAdapter();
            this.tableAdapterManager = new Ejemplo12C2023G1.Database1DataSetTableAdapters.TableAdapterManager();
            this.especialidadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.especialidadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.especialidadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idespecialidadTextBox = new System.Windows.Forms.TextBox();
            this.nom_especialidadTextBox = new System.Windows.Forms.TextBox();
            this.area_especialiadTextBox = new System.Windows.Forms.TextBox();
            idespecialidadLabel = new System.Windows.Forms.Label();
            nom_especialidadLabel = new System.Windows.Forms.Label();
            area_especialiadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingNavigator)).BeginInit();
            this.especialidadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idespecialidadLabel
            // 
            idespecialidadLabel.AutoSize = true;
            idespecialidadLabel.Location = new System.Drawing.Point(30, 68);
            idespecialidadLabel.Name = "idespecialidadLabel";
            idespecialidadLabel.Size = new System.Drawing.Size(78, 13);
            idespecialidadLabel.TabIndex = 2;
            idespecialidadLabel.Text = "Idespecialidad:";
            // 
            // nom_especialidadLabel
            // 
            nom_especialidadLabel.AutoSize = true;
            nom_especialidadLabel.Location = new System.Drawing.Point(30, 94);
            nom_especialidadLabel.Name = "nom_especialidadLabel";
            nom_especialidadLabel.Size = new System.Drawing.Size(92, 13);
            nom_especialidadLabel.TabIndex = 4;
            nom_especialidadLabel.Text = "nom especialidad:";
            // 
            // area_especialiadLabel
            // 
            area_especialiadLabel.AutoSize = true;
            area_especialiadLabel.Location = new System.Drawing.Point(30, 120);
            area_especialiadLabel.Name = "area_especialiadLabel";
            area_especialiadLabel.Size = new System.Drawing.Size(87, 13);
            area_especialiadLabel.TabIndex = 6;
            area_especialiadLabel.Text = "area especialiad:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especialidadBindingSource
            // 
            this.especialidadBindingSource.DataMember = "especialidad";
            this.especialidadBindingSource.DataSource = this.database1DataSet;
            // 
            // especialidadTableAdapter
            // 
            this.especialidadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.consultorioTableAdapter = null;
            this.tableAdapterManager.especialidadTableAdapter = this.especialidadTableAdapter;
            this.tableAdapterManager.facturaTableAdapter = null;
            this.tableAdapterManager.farmaciaTableAdapter = null;
            this.tableAdapterManager.pacienteTableAdapter = null;
            this.tableAdapterManager.personalmedicoTableAdapter = null;
            this.tableAdapterManager.salaTableAdapter = null;
            this.tableAdapterManager.turnoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ejemplo12C2023G1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // especialidadBindingNavigator
            // 
            this.especialidadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.especialidadBindingNavigator.BindingSource = this.especialidadBindingSource;
            this.especialidadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.especialidadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.especialidadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.especialidadBindingNavigatorSaveItem});
            this.especialidadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.especialidadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.especialidadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.especialidadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.especialidadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.especialidadBindingNavigator.Name = "especialidadBindingNavigator";
            this.especialidadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.especialidadBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.especialidadBindingNavigator.TabIndex = 0;
            this.especialidadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // especialidadBindingNavigatorSaveItem
            // 
            this.especialidadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.especialidadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("especialidadBindingNavigatorSaveItem.Image")));
            this.especialidadBindingNavigatorSaveItem.Name = "especialidadBindingNavigatorSaveItem";
            this.especialidadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.especialidadBindingNavigatorSaveItem.Text = "Guardar datos";
            this.especialidadBindingNavigatorSaveItem.Click += new System.EventHandler(this.especialidadBindingNavigatorSaveItem_Click);
            // 
            // especialidadDataGridView
            // 
            this.especialidadDataGridView.AutoGenerateColumns = false;
            this.especialidadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.especialidadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.especialidadDataGridView.DataSource = this.especialidadBindingSource;
            this.especialidadDataGridView.Location = new System.Drawing.Point(320, 68);
            this.especialidadDataGridView.Name = "especialidadDataGridView";
            this.especialidadDataGridView.Size = new System.Drawing.Size(344, 220);
            this.especialidadDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Idespecialidad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Idespecialidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom_especialidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "nom_especialidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "area_especialiad";
            this.dataGridViewTextBoxColumn3.HeaderText = "area_especialiad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // idespecialidadTextBox
            // 
            this.idespecialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadBindingSource, "Idespecialidad", true));
            this.idespecialidadTextBox.Location = new System.Drawing.Point(128, 65);
            this.idespecialidadTextBox.Name = "idespecialidadTextBox";
            this.idespecialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.idespecialidadTextBox.TabIndex = 3;
            // 
            // nom_especialidadTextBox
            // 
            this.nom_especialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadBindingSource, "nom_especialidad", true));
            this.nom_especialidadTextBox.Location = new System.Drawing.Point(128, 91);
            this.nom_especialidadTextBox.Name = "nom_especialidadTextBox";
            this.nom_especialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.nom_especialidadTextBox.TabIndex = 5;
            // 
            // area_especialiadTextBox
            // 
            this.area_especialiadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadBindingSource, "area_especialiad", true));
            this.area_especialiadTextBox.Location = new System.Drawing.Point(128, 117);
            this.area_especialiadTextBox.Name = "area_especialiadTextBox";
            this.area_especialiadTextBox.Size = new System.Drawing.Size(100, 20);
            this.area_especialiadTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idespecialidadLabel);
            this.Controls.Add(this.idespecialidadTextBox);
            this.Controls.Add(nom_especialidadLabel);
            this.Controls.Add(this.nom_especialidadTextBox);
            this.Controls.Add(area_especialiadLabel);
            this.Controls.Add(this.area_especialiadTextBox);
            this.Controls.Add(this.especialidadDataGridView);
            this.Controls.Add(this.especialidadBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingNavigator)).EndInit();
            this.especialidadBindingNavigator.ResumeLayout(false);
            this.especialidadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private Database1DataSetTableAdapters.especialidadTableAdapter especialidadTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator especialidadBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton especialidadBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView especialidadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox idespecialidadTextBox;
        private System.Windows.Forms.TextBox nom_especialidadTextBox;
        private System.Windows.Forms.TextBox area_especialiadTextBox;
    }
}