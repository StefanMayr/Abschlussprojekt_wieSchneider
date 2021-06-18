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
            this.Testbutton2 = new System.Windows.Forms.Button();
            this.DataSource = new System.Windows.Forms.Label();
            this.SelectedSource = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Testbutton2
            // 
            this.Testbutton2.Location = new System.Drawing.Point(352, 452);
            this.Testbutton2.Name = "Testbutton2";
            this.Testbutton2.Size = new System.Drawing.Size(150, 50);
            this.Testbutton2.TabIndex = 1;
            this.Testbutton2.Text = "Schließen";
            this.Testbutton2.UseVisualStyleBackColor = true;
            this.Testbutton2.Click += new System.EventHandler(this.Testbutton2_Click);
            // 
            // DataSource
            // 
            this.DataSource.AutoSize = true;
            this.DataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSource.Location = new System.Drawing.Point(12, 9);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(121, 25);
            this.DataSource.TabIndex = 2;
            this.DataSource.Text = "Data Source";
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
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(352, 97);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 50);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(352, 166);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(150, 50);
            this.btn_Remove.TabIndex = 6;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(17, 452);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(150, 50);
            this.btn_Import.TabIndex = 7;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(180, 452);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(150, 50);
            this.btn_Export.TabIndex = 8;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            // 
            // Configform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 514);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SelectedSource);
            this.Controls.Add(this.DataSource);
            this.Controls.Add(this.Testbutton2);
            this.Name = "Configform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Testbutton2;
        private System.Windows.Forms.Label DataSource;
        private System.Windows.Forms.TextBox SelectedSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Export;
    }
}