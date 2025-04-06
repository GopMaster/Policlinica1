namespace MediciForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DataGridMedici = new System.Windows.Forms.DataGridView();
            this.buttonIntoarcere = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMedici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabelul medicilor";
            // 
            // DataGridMedici
            // 
            this.DataGridMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMedici.Location = new System.Drawing.Point(58, 86);
            this.DataGridMedici.Name = "DataGridMedici";
            this.DataGridMedici.Size = new System.Drawing.Size(682, 258);
            this.DataGridMedici.TabIndex = 1;
            // 
            // buttonIntoarcere
            // 
            this.buttonIntoarcere.Location = new System.Drawing.Point(58, 388);
            this.buttonIntoarcere.Name = "buttonIntoarcere";
            this.buttonIntoarcere.Size = new System.Drawing.Size(75, 23);
            this.buttonIntoarcere.TabIndex = 2;
            this.buttonIntoarcere.Text = "Inapoi";
            this.buttonIntoarcere.UseVisualStyleBackColor = true;
            this.buttonIntoarcere.Click += new System.EventHandler(this.buttonIntoarcere_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(646, 388);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonIntoarcere);
            this.Controls.Add(this.DataGridMedici);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMedici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       


        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView DataGridMedici;
        private System.Windows.Forms.Button buttonIntoarcere;
        private System.Windows.Forms.Button buttonRefresh;
    }
}