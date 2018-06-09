namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Orden_Despacho_cons
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
            this.ultrOrdenDespacho1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrdenDespacho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdOrdenDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_TotalKilos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_TotalQuintales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_fech_venc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTransportista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_plazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_DespAbierto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ultrOrdenDespacho1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenDespacho)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 24, 12, 3, 14, 215);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 24, 12, 3, 14, 215);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(944, 154);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            // 
            // ultrOrdenDespacho1
            // 
            this.ultrOrdenDespacho1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultrOrdenDespacho1.Location = new System.Drawing.Point(0, 154);
            this.ultrOrdenDespacho1.MainView = this.gridViewOrdenDespacho;
            this.ultrOrdenDespacho1.Name = "ultrOrdenDespacho1";
            this.ultrOrdenDespacho1.Size = new System.Drawing.Size(944, 216);
            this.ultrOrdenDespacho1.TabIndex = 1;
            this.ultrOrdenDespacho1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrdenDespacho});
            // 
            // gridViewOrdenDespacho
            // 
            this.gridViewOrdenDespacho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Bodega,
            this.IdOrdenDespacho,
            this.Cliente,
            this.Vendedor,
            this.od_Observacion,
            this.od_TotalKilos,
            this.od_TotalQuintales,
            this.od_fecha,
            this.od_fech_venc,
            this.IdTransportista,
            this.od_plazo,
            this.Subtotal,
            this.Iva,
            this.Total,
            this.Estado,
            this.od_DespAbierto});
            this.gridViewOrdenDespacho.GridControl = this.ultrOrdenDespacho1;
            this.gridViewOrdenDespacho.Name = "gridViewOrdenDespacho";
            this.gridViewOrdenDespacho.OptionsBehavior.Editable = false;
            this.gridViewOrdenDespacho.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewOrdenDespacho_RowClick);
            this.gridViewOrdenDespacho.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewOrdenDespacho_RowCellStyle);
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 0;
            this.Sucursal.Width = 77;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 1;
            this.Bodega.Width = 77;
            // 
            // IdOrdenDespacho
            // 
            this.IdOrdenDespacho.Caption = "# Orden Despacho";
            this.IdOrdenDespacho.FieldName = "IdOrdenDespacho";
            this.IdOrdenDespacho.Name = "IdOrdenDespacho";
            this.IdOrdenDespacho.Visible = true;
            this.IdOrdenDespacho.VisibleIndex = 2;
            this.IdOrdenDespacho.Width = 77;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 3;
            this.Cliente.Width = 77;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 4;
            this.Vendedor.Width = 77;
            // 
            // od_Observacion
            // 
            this.od_Observacion.Caption = "Observacion";
            this.od_Observacion.FieldName = "od_Observacion";
            this.od_Observacion.Name = "od_Observacion";
            this.od_Observacion.Visible = true;
            this.od_Observacion.VisibleIndex = 5;
            this.od_Observacion.Width = 77;
            // 
            // od_TotalKilos
            // 
            this.od_TotalKilos.Caption = "Total Kilos";
            this.od_TotalKilos.FieldName = "od_TotalKilos";
            this.od_TotalKilos.Name = "od_TotalKilos";
            // 
            // od_TotalQuintales
            // 
            this.od_TotalQuintales.Caption = "Total Quintales";
            this.od_TotalQuintales.FieldName = "od_TotalQuintales";
            this.od_TotalQuintales.Name = "od_TotalQuintales";
            // 
            // od_fecha
            // 
            this.od_fecha.Caption = "Fecha";
            this.od_fecha.FieldName = "od_fecha";
            this.od_fecha.Name = "od_fecha";
            this.od_fecha.Visible = true;
            this.od_fecha.VisibleIndex = 6;
            this.od_fecha.Width = 77;
            // 
            // od_fech_venc
            // 
            this.od_fech_venc.Caption = "Fecha Vencimiento";
            this.od_fech_venc.FieldName = "od_fech_venc";
            this.od_fech_venc.Name = "od_fech_venc";
            this.od_fech_venc.Visible = true;
            this.od_fech_venc.VisibleIndex = 7;
            this.od_fech_venc.Width = 77;
            // 
            // IdTransportista
            // 
            this.IdTransportista.Caption = "IdTransportista";
            this.IdTransportista.FieldName = "IdTransportista";
            this.IdTransportista.Name = "IdTransportista";
            this.IdTransportista.Width = 77;
            // 
            // od_plazo
            // 
            this.od_plazo.Caption = "Dias Plazo";
            this.od_plazo.FieldName = "od_plazo";
            this.od_plazo.Name = "od_plazo";
            this.od_plazo.Visible = true;
            this.od_plazo.VisibleIndex = 8;
            this.od_plazo.Width = 55;
            // 
            // Subtotal
            // 
            this.Subtotal.Caption = "Subtotal";
            this.Subtotal.FieldName = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // Iva
            // 
            this.Iva.Caption = "Iva";
            this.Iva.FieldName = "Iva";
            this.Iva.Name = "Iva";
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 9;
            this.Estado.Width = 52;
            // 
            // od_DespAbierto
            // 
            this.od_DespAbierto.Caption = "Tipo Despacho";
            this.od_DespAbierto.FieldName = "od_DespAbierto";
            this.od_DespAbierto.Name = "od_DespAbierto";
            this.od_DespAbierto.Visible = true;
            this.od_DespAbierto.VisibleIndex = 10;
            this.od_DespAbierto.Width = 126;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 154);
            this.panel1.TabIndex = 8;
            // 
            // frmFa_Orden_Despacho_cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 392);
            this.Controls.Add(this.ultrOrdenDespacho1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmFa_Orden_Despacho_cons";
            this.Text = "Orden Despacho";
            this.Load += new System.EventHandler(this.frmFA_Orden_Despacho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultrOrdenDespacho1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenDespacho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridControl ultrOrdenDespacho1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrdenDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn IdOrdenDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn od_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn od_TotalKilos;
        private DevExpress.XtraGrid.Columns.GridColumn od_TotalQuintales;
        private DevExpress.XtraGrid.Columns.GridColumn od_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn od_fech_venc;
        private DevExpress.XtraGrid.Columns.GridColumn IdTransportista;
        private DevExpress.XtraGrid.Columns.GridColumn od_plazo;
        private DevExpress.XtraGrid.Columns.GridColumn Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn Iva;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn od_DespAbierto;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel1;
    }
}