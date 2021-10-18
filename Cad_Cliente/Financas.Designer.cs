
namespace Cad_Cliente
{
    partial class Financas
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
            this.DgvFinancas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFinancas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFinancas
            // 
            this.DgvFinancas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFinancas.Location = new System.Drawing.Point(3, 7);
            this.DgvFinancas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvFinancas.Name = "DgvFinancas";
            this.DgvFinancas.Size = new System.Drawing.Size(729, 330);
            this.DgvFinancas.TabIndex = 45;
            this.DgvFinancas.TabStop = false;
            // 
            // Financas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 341);
            this.Controls.Add(this.DgvFinancas);
            this.Name = "Financas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financas";
            this.Load += new System.EventHandler(this.Financas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFinancas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFinancas;
    }
}