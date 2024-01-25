namespace Ventas.UI.Informes
{
    partial class Frm_Rpt_Productos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVentas = new Ventas.UI.Informes.DsVentas();
            this.dsVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.spProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spProductosBindingSource
            // 
            this.spProductosBindingSource.DataMember = "spProductos";
            this.spProductosBindingSource.DataSource = this.dsVentas;
            // 
            // dsVentas
            // 
            this.dsVentas.DataSetName = "DsVentas";
            this.dsVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsVentasBindingSource
            // 
            this.dsVentasBindingSource.DataSource = this.dsVentas;
            this.dsVentasBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ventas.UI.Informes.InformeProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(30, 26);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(512, 271);
            this.reportViewer1.TabIndex = 0;
            // 
            // Frm_Rpt_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Rpt_Productos";
            this.Text = "Frm_Rpt_Productos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DsVentas dsVentas;
        private System.Windows.Forms.BindingSource dsVentasBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spProductosBindingSource;
    }
}