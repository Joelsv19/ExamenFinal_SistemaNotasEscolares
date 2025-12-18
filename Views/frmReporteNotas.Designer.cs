namespace SistemaNotasEscolares.Views
{
    partial class frmReporteNotas
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
            label1 = new Label();
            btnBuscar = new Button();
            cbMaterias = new ComboBox();
            dgvReporte = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 48);
            label1.Name = "label1";
            label1.Size = new Size(243, 20);
            label1.TabIndex = 0;
            label1.Text = " REPORTE DE NOTAS POR MATERIA";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(259, 132);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbMaterias
            // 
            cbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaterias.FormattingEnabled = true;
            cbMaterias.Location = new Point(52, 133);
            cbMaterias.Name = "cbMaterias";
            cbMaterias.Size = new Size(151, 28);
            cbMaterias.TabIndex = 2;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(82, 222);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(434, 188);
            dgvReporte.TabIndex = 3;
            // 
            // frmReporteNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 450);
            Controls.Add(dgvReporte);
            Controls.Add(cbMaterias);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Name = "frmReporteNotas";
            Text = "frmReporteNotas";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBuscar;
        private ComboBox cbMaterias;
        private DataGridView dgvReporte;
    }
}