namespace Abschlussprojekt_wieSchneider
{
    partial class Chartform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monat2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monat3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monat4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monat9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monat10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monat11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monat12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basisstructureDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_conf = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_progend = new System.Windows.Forms.Button();
            this.Testbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basisstructureDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1022, 324);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sourceDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.monat2DataGridViewTextBoxColumn,
            this.monat3DataGridViewTextBoxColumn,
            this.monat4DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.monat9DataGridViewTextBoxColumn,
            this.monat10DataGridViewTextBoxColumn,
            this.monat11DataGridViewTextBoxColumn,
            this.monat12DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.basisstructureDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 99);
            this.dataGridView1.TabIndex = 1;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Monat1";
            this.dataGridViewTextBoxColumn1.HeaderText = "Monat1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // monat2DataGridViewTextBoxColumn
            // 
            this.monat2DataGridViewTextBoxColumn.DataPropertyName = "Monat2";
            this.monat2DataGridViewTextBoxColumn.HeaderText = "Monat2";
            this.monat2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monat2DataGridViewTextBoxColumn.Name = "monat2DataGridViewTextBoxColumn";
            this.monat2DataGridViewTextBoxColumn.Width = 125;
            // 
            // monat3DataGridViewTextBoxColumn
            // 
            this.monat3DataGridViewTextBoxColumn.DataPropertyName = "Monat3";
            this.monat3DataGridViewTextBoxColumn.HeaderText = "Monat3";
            this.monat3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monat3DataGridViewTextBoxColumn.Name = "monat3DataGridViewTextBoxColumn";
            this.monat3DataGridViewTextBoxColumn.Width = 125;
            // 
            // monat4DataGridViewTextBoxColumn
            // 
            this.monat4DataGridViewTextBoxColumn.DataPropertyName = "Monat4";
            this.monat4DataGridViewTextBoxColumn.HeaderText = "Monat4";
            this.monat4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monat4DataGridViewTextBoxColumn.Name = "monat4DataGridViewTextBoxColumn";
            this.monat4DataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Monat5";
            this.dataGridViewTextBoxColumn2.HeaderText = "Monat5";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Monat6";
            this.dataGridViewTextBoxColumn3.HeaderText = "Monat6";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Monat7";
            this.dataGridViewTextBoxColumn4.HeaderText = "Monat7";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Monat8";
            this.dataGridViewTextBoxColumn5.HeaderText = "Monat8";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // monat9DataGridViewTextBoxColumn
            // 
            this.monat9DataGridViewTextBoxColumn.DataPropertyName = "Monat9";
            this.monat9DataGridViewTextBoxColumn.HeaderText = "Monat9";
            this.monat9DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monat9DataGridViewTextBoxColumn.Name = "monat9DataGridViewTextBoxColumn";
            this.monat9DataGridViewTextBoxColumn.Width = 125;
            // 
            // monat10DataGridViewTextBoxColumn
            // 
            this.monat10DataGridViewTextBoxColumn.DataPropertyName = "Monat10";
            this.monat10DataGridViewTextBoxColumn.HeaderText = "Monat10";
            this.monat10DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monat10DataGridViewTextBoxColumn.Name = "monat10DataGridViewTextBoxColumn";
            this.monat10DataGridViewTextBoxColumn.Width = 125;
            // 
            // monat11DataGridViewTextBoxColumn
            // 
            this.monat11DataGridViewTextBoxColumn.DataPropertyName = "Monat11";
            this.monat11DataGridViewTextBoxColumn.HeaderText = "Monat11";
            this.monat11DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monat11DataGridViewTextBoxColumn.Name = "monat11DataGridViewTextBoxColumn";
            this.monat11DataGridViewTextBoxColumn.Width = 125;
            // 
            // monat12DataGridViewTextBoxColumn
            // 
            this.monat12DataGridViewTextBoxColumn.DataPropertyName = "Monat12";
            this.monat12DataGridViewTextBoxColumn.HeaderText = "Monat12";
            this.monat12DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monat12DataGridViewTextBoxColumn.Name = "monat12DataGridViewTextBoxColumn";
            this.monat12DataGridViewTextBoxColumn.Width = 125;
            // 
            // basisstructureDataBindingSource
            // 
            this.basisstructureDataBindingSource.DataSource = typeof(Abschlussprojekt_wieSchneider.BasisstructureData);
            // 
            // btn_conf
            // 
            this.btn_conf.Location = new System.Drawing.Point(1040, 12);
            this.btn_conf.Name = "btn_conf";
            this.btn_conf.Size = new System.Drawing.Size(150, 75);
            this.btn_conf.TabIndex = 2;
            this.btn_conf.Text = "Konfiguration";
            this.btn_conf.UseVisualStyleBackColor = true;
            this.btn_conf.Click += new System.EventHandler(this.btn_conf_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(1040, 93);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(150, 75);
            this.btn_reload.TabIndex = 3;
            this.btn_reload.Text = "Aktualisieren";
            this.btn_reload.UseVisualStyleBackColor = true;
            // 
            // btn_progend
            // 
            this.btn_progend.Location = new System.Drawing.Point(1040, 371);
            this.btn_progend.Name = "btn_progend";
            this.btn_progend.Size = new System.Drawing.Size(150, 75);
            this.btn_progend.TabIndex = 4;
            this.btn_progend.Text = "Beenden";
            this.btn_progend.UseVisualStyleBackColor = true;
            // 
            // Testbutton
            // 
            this.Testbutton.Location = new System.Drawing.Point(1040, 194);
            this.Testbutton.Name = "Testbutton";
            this.Testbutton.Size = new System.Drawing.Size(150, 75);
            this.Testbutton.TabIndex = 5;
            this.Testbutton.Text = "Open Config";
            this.Testbutton.UseVisualStyleBackColor = true;
            this.Testbutton.Click += new System.EventHandler(this.Testbutton_Click);
            // 
            // Chartform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 505);
            this.Controls.Add(this.Testbutton);
            this.Controls.Add(this.btn_progend);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_conf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "Chartform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basisstructureDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_conf;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_progend;
        private System.Windows.Forms.DataGridViewTextBoxColumn confimredCasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recoveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intensiveCareUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testingPCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testingAnitgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource basisstructureDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOnat1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOnat5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOnat6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOnat7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOnat8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn monat2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monat3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monat4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn monat9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monat10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monat11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monat12DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Testbutton;
    }
}

