namespace Abschlussprojekt_wieSchneider
{
    partial class Configform
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
            this.DataSource = new System.Windows.Forms.Label();
            this.SelectedSource = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Present = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataSource
            // 
            this.DataSource.AutoSize = true;
            this.DataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSource.Location = new System.Drawing.Point(12, 9);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(127, 25);
            this.DataSource.TabIndex = 2;
            this.DataSource.Text = "Datenquellen";
            // 
            // SelectedSource
            // 
            this.SelectedSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedSource.Location = new System.Drawing.Point(17, 46);
            this.SelectedSource.Name = "SelectedSource";
            this.SelectedSource.ReadOnly = true;
            this.SelectedSource.Size = new System.Drawing.Size(485, 30);
            this.SelectedSource.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 308);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(352, 97);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(150, 50);
            this.btn_Import.TabIndex = 7;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Present
            // 
            this.btn_Present.Location = new System.Drawing.Point(352, 167);
            this.btn_Present.Name = "btn_Present";
            this.btn_Present.Size = new System.Drawing.Size(150, 50);
            this.btn_Present.TabIndex = 9;
            this.btn_Present.Text = "Auswahl speichern";
            this.btn_Present.UseVisualStyleBackColor = true;
            this.btn_Present.Click += new System.EventHandler(this.btn_Present_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(352, 355);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(150, 50);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "Schließen";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Configform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 422);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Present);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SelectedSource);
            this.Controls.Add(this.DataSource);
            this.Name = "Configform";
            this.Text = "Konfigurationsfenster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DataSource;
        private System.Windows.Forms.TextBox SelectedSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Present;
        private System.Windows.Forms.Button btn_Close;
    }
}