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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_progend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Config = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1143, 418);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 436);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 145);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_progend
            // 
            this.btn_progend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_progend.Location = new System.Drawing.Point(1177, 506);
            this.btn_progend.Name = "btn_progend";
            this.btn_progend.Size = new System.Drawing.Size(150, 75);
            this.btn_progend.TabIndex = 4;
            this.btn_progend.Text = "Beenden";
            this.btn_progend.UseVisualStyleBackColor = false;
            this.btn_progend.Click += new System.EventHandler(this.btn_progend_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1177, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Config.Location = new System.Drawing.Point(1177, 12);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(150, 75);
            this.btn_Config.TabIndex = 7;
            this.btn_Config.Text = "Konfiguration";
            this.btn_Config.UseVisualStyleBackColor = false;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // Chartform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1350, 598);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_progend);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "Chartform";
            this.Text = "Covid-Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_progend;
        private System.Windows.Forms.DataGridViewTextBoxColumn confimredCasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recoveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intensiveCareUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testingPCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testingAnitgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOnat1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOnat5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOnat6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOnat7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOnat8DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Config;
    }
}

