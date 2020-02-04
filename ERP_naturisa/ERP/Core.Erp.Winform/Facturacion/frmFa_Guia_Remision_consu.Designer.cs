namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Guia_Remision_consu
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
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ultrGuiaRemision1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewGuiaRemision = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdGuiaRemision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gi_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gi_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gi_fech_venc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gi_plazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Impreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodGuiaRemision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ultrGuiaRemision1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuiaRemision)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 12, 20, 14, 15, 27, 58);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 2, 20, 14, 15, 27, 58);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1009, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 6;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            // 
            // ultrGuiaRemision1
            // 
            this.ultrGuiaRemision1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultrGuiaRemision1.Location = new System.Drawing.Point(0, 0);
            this.ultrGuiaRemision1.MainView = this.gridViewGuiaRemision;
            this.ultrGuiaRemision1.Name = "ultrGuiaRemision1";
            this.ultrGuiaRemision1.Size = new System.Drawing.Size(1009, 207);
            this.ultrGuiaRemision1.TabIndex = 1;
            this.ultrGuiaRemision1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGuiaRemision});
            // 
            // gridViewGuiaRemision
            // 
            this.gridViewGuiaRemision.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Bodega,
            this.IdGuiaRemision,
            this.Cliente,
            this.Vendedor,
            this.gi_Observacion,
            this.gi_fecha,
            this.gi_fech_venc,
            this.gi_plazo,
            this.Subtotal,
            this.Iva,
            this.Total,
            this.Estado,
            this.Impreso,
            this.CodGuiaRemision});
            this.gridViewGuiaRemision.GridControl = this.ultrGuiaRemision1;
            this.gridViewGuiaRemision.Name = "gridViewGuiaRemision";
            this.gridViewGuiaRemision.OptionsBehavior.Editable = false;
            this.gridViewGuiaRemision.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewGuiaRemision_RowClick);
            this.gridViewGuiaRemision.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewGuiaRemision_RowCellStyle);
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 0;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 1;
            // 
            // IdGuiaRemision
            // 
            this.IdGuiaRemision.Caption = "Id Guia Remision";
            this.IdGuiaRemision.FieldName = "IdGuiaRemision";
            this.IdGuiaRemision.Name = "IdGuiaRemision";
            this.IdGuiaRemision.Visible = true;
            this.IdGuiaRemision.VisibleIndex = 2;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 3;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 4;
            // 
            // gi_Observacion
            // 
            this.gi_Observacion.Caption = "Observacion";
            this.gi_Observacion.FieldName = "gi_Observacion";
            this.gi_Observacion.Name = "gi_Observacion";
            this.gi_Observacion.Visible = true;
            this.gi_Observacion.VisibleIndex = 5;
            // 
            // gi_fecha
            // 
            this.gi_fecha.Caption = "Fecha";
            this.gi_fecha.FieldName = "gi_fecha";
            this.gi_fecha.Name = "gi_fecha";
            this.gi_fecha.Visible = true;
            this.gi_fecha.VisibleIndex = 6;
            // 
            // gi_fech_venc
            // 
            this.gi_fech_venc.Caption = "Fecha Vencimiento";
            this.gi_fech_venc.FieldName = "gi_fech_venc";
            this.gi_fech_venc.Name = "gi_fech_venc";
            this.gi_fech_venc.Visible = true;
            this.gi_fech_venc.VisibleIndex = 7;
            // 
            // gi_plazo
            // 
            this.gi_plazo.Caption = "Plazo";
            this.gi_plazo.FieldName = "gi_plazo";
            this.gi_plazo.Name = "gi_plazo";
            this.gi_plazo.Visible = true;
            this.gi_plazo.VisibleIndex = 8;
            // 
            // Subtotal
            // 
            this.Subtotal.Caption = "Subtotal";
            this.Subtotal.FieldName = "Subtotal";
            this.Subtotal.GroupFormat.FormatString = "n2";
            this.Subtotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Visible = true;
            this.Subtotal.VisibleIndex = 9;
            // 
            // Iva
            // 
            this.Iva.Caption = "Iva";
            this.Iva.FieldName = "Iva";
            this.Iva.GroupFormat.FormatString = "n2";
            this.Iva.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Iva.Name = "Iva";
            this.Iva.Visible = true;
            this.Iva.VisibleIndex = 10;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.FieldName = "Total";
            this.Total.GroupFormat.FormatString = "n2";
            this.Total.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 11;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 12;
            // 
            // Impreso
            // 
            this.Impreso.Caption = "Impreso";
            this.Impreso.FieldName = "Impreso";
            this.Impreso.Name = "Impreso";
            this.Impreso.Visible = true;
            this.Impreso.VisibleIndex = 13;
            // 
            // CodGuiaRemision
            // 
            this.CodGuiaRemision.Caption = "CodGuiaRemision";
            this.CodGuiaRemision.FieldName = "CodGuiaRemision";
            this.CodGuiaRemision.Name = "CodGuiaRemision";
            this.CodGuiaRemision.Visible = true;
            this.CodGuiaRemision.VisibleIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 368);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1009, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 161);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ultrGuiaRemision1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 207);
            this.panel2.TabIndex = 12;
            // 
            // frmFa_Guia_Remision_consu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmFa_Guia_Remision_consu";
            this.Text = "Guia Remision";
            this.Load += new System.EventHandler(this.frmFA_Guia_Remision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultrGuiaRemision1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuiaRemision)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridControl ultrGuiaRemision1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGuiaRemision;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn gi_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn gi_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn gi_fech_venc;
        private DevExpress.XtraGrid.Columns.GridColumn gi_plazo;
        private DevExpress.XtraGrid.Columns.GridColumn Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn Iva;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn IdGuiaRemision;
        private DevExpress.XtraGrid.Columns.GridColumn Impreso;
        private DevExpress.XtraGrid.Columns.GridColumn CodGuiaRemision;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}