
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvFinanca = new System.Windows.Forms.DataGridView();
            this.dtFiltroAte = new System.Windows.Forms.DateTimePicker();
            this.dtFiltroDe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFiltroFinancas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFinanca)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFinanca
            // 
            this.DgvFinanca.AllowUserToAddRows = false;
            this.DgvFinanca.AllowUserToDeleteRows = false;
            this.DgvFinanca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvFinanca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvFinanca.BackgroundColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFinanca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvFinanca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFinanca.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvFinanca.GridColor = System.Drawing.Color.DimGray;
            this.DgvFinanca.Location = new System.Drawing.Point(12, 79);
            this.DgvFinanca.Name = "DgvFinanca";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFinanca.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvFinanca.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvFinanca.Size = new System.Drawing.Size(679, 226);
            this.DgvFinanca.TabIndex = 0;
            this.DgvFinanca.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvFinanca_CellFormatting);
            // 
            // dtFiltroAte
            // 
            this.dtFiltroAte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFiltroAte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFiltroAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFiltroAte.Location = new System.Drawing.Point(421, 50);
            this.dtFiltroAte.Margin = new System.Windows.Forms.Padding(4);
            this.dtFiltroAte.Name = "dtFiltroAte";
            this.dtFiltroAte.Size = new System.Drawing.Size(105, 22);
            this.dtFiltroAte.TabIndex = 75;
            this.dtFiltroAte.ValueChanged += new System.EventHandler(this.dtFiltroAte_ValueChanged);
            // 
            // dtFiltroDe
            // 
            this.dtFiltroDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFiltroDe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFiltroDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFiltroDe.Location = new System.Drawing.Point(299, 50);
            this.dtFiltroDe.Margin = new System.Windows.Forms.Padding(4);
            this.dtFiltroDe.Name = "dtFiltroDe";
            this.dtFiltroDe.Size = new System.Drawing.Size(105, 22);
            this.dtFiltroDe.TabIndex = 76;
            this.dtFiltroDe.ValueChanged += new System.EventHandler(this.dtFiltroDe_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "De:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 80;
            this.label1.Text = "Até:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 85;
            this.label6.Text = "Consultar Finanças";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Exibir:";
            // 
            // cbFiltroFinancas
            // 
            this.cbFiltroFinancas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFiltroFinancas.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbFiltroFinancas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroFinancas.FormattingEnabled = true;
            this.cbFiltroFinancas.Items.AddRange(new object[] {
            "Valor Total",
            "Valor Detalhado"});
            this.cbFiltroFinancas.Location = new System.Drawing.Point(556, 47);
            this.cbFiltroFinancas.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiltroFinancas.Name = "cbFiltroFinancas";
            this.cbFiltroFinancas.Size = new System.Drawing.Size(135, 25);
            this.cbFiltroFinancas.TabIndex = 86;
            this.cbFiltroFinancas.SelectedValueChanged += new System.EventHandler(this.cbFiltroFinancas_SelectedValueChanged);
            // 
            // Financas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 317);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFiltroFinancas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFiltroDe);
            this.Controls.Add(this.dtFiltroAte);
            this.Controls.Add(this.DgvFinanca);
            this.Name = "Financas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financas";
            this.Load += new System.EventHandler(this.Financas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFinanca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFinanca;
        private System.Windows.Forms.DateTimePicker dtFiltroAte;
        private System.Windows.Forms.DateTimePicker dtFiltroDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFiltroFinancas;
    }
}