namespace BYSD_Camp_Registration_System
{
    partial class AccomodationManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnmenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registrationDataSet1 = new BYSD_Camp_Registration_System.RegistrationDataSet1();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new BYSD_Camp_Registration_System.RegistrationDataSet1TableAdapters.RoomsTableAdapter();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accomodateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(258, 346);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(75, 23);
            this.btnmenu.TabIndex = 1;
            this.btnmenu.Text = "Main Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomDataGridViewTextBoxColumn,
            this.accomodateDataGridViewTextBoxColumn,
            this.vacancyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 337);
            this.dataGridView1.TabIndex = 2;
            // 
            // registrationDataSet1
            // 
            this.registrationDataSet1.DataSetName = "RegistrationDataSet1";
            this.registrationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.registrationDataSet1;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // accomodateDataGridViewTextBoxColumn
            // 
            this.accomodateDataGridViewTextBoxColumn.DataPropertyName = "Accomodate";
            this.accomodateDataGridViewTextBoxColumn.HeaderText = "Accomodate";
            this.accomodateDataGridViewTextBoxColumn.Name = "accomodateDataGridViewTextBoxColumn";
            // 
            // vacancyDataGridViewTextBoxColumn
            // 
            this.vacancyDataGridViewTextBoxColumn.DataPropertyName = "Vacancy";
            this.vacancyDataGridViewTextBoxColumn.HeaderText = "Vacancy";
            this.vacancyDataGridViewTextBoxColumn.Name = "vacancyDataGridViewTextBoxColumn";
            // 
            // AccomodationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.label1);
            this.Name = "AccomodationManagement";
            this.Text = "AccomodationManagement";
            this.Load += new System.EventHandler(this.AccomodationManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RegistrationDataSet1 registrationDataSet1;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private RegistrationDataSet1TableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accomodateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyDataGridViewTextBoxColumn;
    }
}