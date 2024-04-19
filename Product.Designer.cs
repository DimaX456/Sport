namespace Sport
{
    partial class Product
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sportDBDataSet = new Sport.SportDBDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new Sport.SportDBDataSetTableAdapters.OrderTableAdapter();
            this.idOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerDataDelivery = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataOrder = new System.Windows.Forms.DateTimePicker();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxCodeOrder = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxPUP = new System.Windows.Forms.TextBox();
            this.textBoxSostav = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonNewAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderDataGridViewTextBoxColumn,
            this.numberOrderDataGridViewTextBoxColumn,
            this.sostavDataGridViewTextBoxColumn,
            this.dataOrderDataGridViewTextBoxColumn,
            this.dataDeliveryDataGridViewTextBoxColumn,
            this.pickUpPointDataGridViewTextBoxColumn,
            this.fIOClientDataGridViewTextBoxColumn,
            this.codeOrderDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(571, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(680, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // sportDBDataSet
            // 
            this.sportDBDataSet.DataSetName = "SportDBDataSet";
            this.sportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.sportDBDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // idOrderDataGridViewTextBoxColumn
            // 
            this.idOrderDataGridViewTextBoxColumn.DataPropertyName = "IdOrder";
            this.idOrderDataGridViewTextBoxColumn.HeaderText = "IdOrder";
            this.idOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOrderDataGridViewTextBoxColumn.Name = "idOrderDataGridViewTextBoxColumn";
            this.idOrderDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOrderDataGridViewTextBoxColumn
            // 
            this.numberOrderDataGridViewTextBoxColumn.DataPropertyName = "NumberOrder";
            this.numberOrderDataGridViewTextBoxColumn.HeaderText = "NumberOrder";
            this.numberOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOrderDataGridViewTextBoxColumn.Name = "numberOrderDataGridViewTextBoxColumn";
            this.numberOrderDataGridViewTextBoxColumn.Width = 125;
            // 
            // sostavDataGridViewTextBoxColumn
            // 
            this.sostavDataGridViewTextBoxColumn.DataPropertyName = "Sostav";
            this.sostavDataGridViewTextBoxColumn.HeaderText = "Sostav";
            this.sostavDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sostavDataGridViewTextBoxColumn.Name = "sostavDataGridViewTextBoxColumn";
            this.sostavDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataOrderDataGridViewTextBoxColumn
            // 
            this.dataOrderDataGridViewTextBoxColumn.DataPropertyName = "DataOrder";
            this.dataOrderDataGridViewTextBoxColumn.HeaderText = "DataOrder";
            this.dataOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataOrderDataGridViewTextBoxColumn.Name = "dataOrderDataGridViewTextBoxColumn";
            this.dataOrderDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDeliveryDataGridViewTextBoxColumn
            // 
            this.dataDeliveryDataGridViewTextBoxColumn.DataPropertyName = "DataDelivery";
            this.dataDeliveryDataGridViewTextBoxColumn.HeaderText = "DataDelivery";
            this.dataDeliveryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDeliveryDataGridViewTextBoxColumn.Name = "dataDeliveryDataGridViewTextBoxColumn";
            this.dataDeliveryDataGridViewTextBoxColumn.Width = 125;
            // 
            // pickUpPointDataGridViewTextBoxColumn
            // 
            this.pickUpPointDataGridViewTextBoxColumn.DataPropertyName = "PickUpPoint";
            this.pickUpPointDataGridViewTextBoxColumn.HeaderText = "PickUpPoint";
            this.pickUpPointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pickUpPointDataGridViewTextBoxColumn.Name = "pickUpPointDataGridViewTextBoxColumn";
            this.pickUpPointDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIOClientDataGridViewTextBoxColumn
            // 
            this.fIOClientDataGridViewTextBoxColumn.DataPropertyName = "FIOClient";
            this.fIOClientDataGridViewTextBoxColumn.HeaderText = "FIOClient";
            this.fIOClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIOClientDataGridViewTextBoxColumn.Name = "fIOClientDataGridViewTextBoxColumn";
            this.fIOClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeOrderDataGridViewTextBoxColumn
            // 
            this.codeOrderDataGridViewTextBoxColumn.DataPropertyName = "CodeOrder";
            this.codeOrderDataGridViewTextBoxColumn.HeaderText = "CodeOrder";
            this.codeOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeOrderDataGridViewTextBoxColumn.Name = "codeOrderDataGridViewTextBoxColumn";
            this.codeOrderDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateTimePickerDataDelivery
            // 
            this.dateTimePickerDataDelivery.Location = new System.Drawing.Point(571, 221);
            this.dateTimePickerDataDelivery.Name = "dateTimePickerDataDelivery";
            this.dateTimePickerDataDelivery.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDataDelivery.TabIndex = 60;
            // 
            // dateTimePickerDataOrder
            // 
            this.dateTimePickerDataOrder.Location = new System.Drawing.Point(571, 181);
            this.dateTimePickerDataOrder.Name = "dateTimePickerDataOrder";
            this.dateTimePickerDataOrder.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDataOrder.TabIndex = 59;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(571, 370);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(795, 22);
            this.textBoxStatus.TabIndex = 58;
            // 
            // textBoxCodeOrder
            // 
            this.textBoxCodeOrder.Location = new System.Drawing.Point(571, 329);
            this.textBoxCodeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodeOrder.Name = "textBoxCodeOrder";
            this.textBoxCodeOrder.Size = new System.Drawing.Size(795, 22);
            this.textBoxCodeOrder.TabIndex = 57;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(571, 296);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(795, 22);
            this.textBoxFIO.TabIndex = 56;
            // 
            // textBoxPUP
            // 
            this.textBoxPUP.Location = new System.Drawing.Point(571, 261);
            this.textBoxPUP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPUP.Name = "textBoxPUP";
            this.textBoxPUP.Size = new System.Drawing.Size(795, 22);
            this.textBoxPUP.TabIndex = 55;
            // 
            // textBoxSostav
            // 
            this.textBoxSostav.Location = new System.Drawing.Point(571, 146);
            this.textBoxSostav.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSostav.Name = "textBoxSostav";
            this.textBoxSostav.Size = new System.Drawing.Size(795, 22);
            this.textBoxSostav.TabIndex = 54;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(571, 111);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(795, 22);
            this.textBoxNumber.TabIndex = 53;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(571, 72);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(795, 22);
            this.textBoxId.TabIndex = 52;
            // 
            // buttonNewAdd
            // 
            this.buttonNewAdd.Location = new System.Drawing.Point(807, 180);
            this.buttonNewAdd.Name = "buttonNewAdd";
            this.buttonNewAdd.Size = new System.Drawing.Size(172, 23);
            this.buttonNewAdd.TabIndex = 61;
            this.buttonNewAdd.Text = "button1";
            this.buttonNewAdd.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(807, 223);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(172, 23);
            this.buttonChange.TabIndex = 62;
            this.buttonChange.Text = "button2";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1010, 180);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(172, 23);
            this.buttonDelete.TabIndex = 63;
            this.buttonDelete.Text = "button3";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1010, 223);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(172, 23);
            this.buttonSave.TabIndex = 64;
            this.buttonSave.Text = "button4";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(571, 402);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(234, 23);
            this.buttonExport.TabIndex = 65;
            this.buttonExport.Text = "button1";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 450);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonNewAdd);
            this.Controls.Add(this.dateTimePickerDataDelivery);
            this.Controls.Add(this.dateTimePickerDataOrder);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxCodeOrder);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.textBoxPUP);
            this.Controls.Add(this.textBoxSostav);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private SportDBDataSet sportDBDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private SportDBDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDelivery;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataOrder;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxCodeOrder;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxPUP;
        private System.Windows.Forms.TextBox textBoxSostav;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonNewAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExport;
    }
}