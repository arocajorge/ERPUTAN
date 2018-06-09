namespace Core.Erp.Winform.Importacion
{
    partial class frmImp_Liquidacion_Import_Consulta
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
            this.gridControlOrdeCompra = new DevExpress.XtraGrid.GridControl();
            this.gridViewPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdOrdenCompraExt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodOrdenCompraExt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ci_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoLiquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Chek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdeCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlOrdeCompra
            // 
            this.gridControlOrdeCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrdeCompra.Location = new System.Drawing.Point(0, 0);
            this.gridControlOrdeCompra.MainView = this.gridViewPedidos;
            this.gridControlOrdeCompra.Name = "gridControlOrdeCompra";
            this.gridControlOrdeCompra.Size = new System.Drawing.Size(1130, 239);
            this.gridControlOrdeCompra.TabIndex = 8;
            this.gridControlOrdeCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedidos,
            this.gridView1});
            // 
            // gridViewPedidos
            // 
            this.gridViewPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Proveedor,
            this.IdOrdenCompraExt,
            this.CodOrdenCompraExt,
            this.Fecha_Transac,
            this.ci_Observacion,
            this.Estado,
            this.EstadoLiquidacion,
            this.Chek,
            this.gridColumn1});
            this.gridViewPedidos.GridControl = this.gridControlOrdeCompra;
            this.gridViewPedidos.Name = "gridViewPedidos";
            this.gridViewPedidos.OptionsBehavior.Editable = false;
            this.gridViewPedidos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPedidos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdOrdenCompraExt, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewPedidos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPedidos_RowClick);
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 1;
            this.Sucursal.Width = 135;
            // 
            // Proveedor
            // 
            this.Proveedor.Caption = "Proveedor";
            this.Proveedor.FieldName = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Visible = true;
            this.Proveedor.VisibleIndex = 2;
            this.Proveedor.Width = 135;
            // 
            // IdOrdenCompraExt
            // 
            this.IdOrdenCompraExt.Caption = "#Orden Compra";
            this.IdOrdenCompraExt.FieldName = "IdOrdenCompraExt";
            this.IdOrdenCompraExt.Name = "IdOrdenCompraExt";
            this.IdOrdenCompraExt.Visible = true;
            this.IdOrdenCompraExt.VisibleIndex = 3;
            this.IdOrdenCompraExt.Width = 135;
            // 
            // CodOrdenCompraExt
            // 
            this.CodOrdenCompraExt.Caption = "Codigo";
            this.CodOrdenCompraExt.FieldName = "CodOrdenCompraExt";
            this.CodOrdenCompraExt.Name = "CodOrdenCompraExt";
            this.CodOrdenCompraExt.Visible = true;
            this.CodOrdenCompraExt.VisibleIndex = 4;
            this.CodOrdenCompraExt.Width = 135;
            // 
            // Fecha_Transac
            // 
            this.Fecha_Transac.Caption = "Fecha Transaccion";
            this.Fecha_Transac.FieldName = "Fecha_Transac";
            this.Fecha_Transac.Name = "Fecha_Transac";
            this.Fecha_Transac.Visible = true;
            this.Fecha_Transac.VisibleIndex = 5;
            this.Fecha_Transac.Width = 135;
            // 
            // ci_Observacion
            // 
            this.ci_Observacion.Caption = "Observacion";
            this.ci_Observacion.FieldName = "ci_Observacion";
            this.ci_Observacion.Name = "ci_Observacion";
            this.ci_Observacion.Visible = true;
            this.ci_Observacion.VisibleIndex = 6;
            this.ci_Observacion.Width = 135;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 7;
            this.Estado.Width = 135;
            // 
            // EstadoLiquidacion
            // 
            this.EstadoLiquidacion.Caption = "Estado Liquidacion";
            this.EstadoLiquidacion.FieldName = "IdEstadoLiquidacion";
            this.EstadoLiquidacion.Name = "EstadoLiquidacion";
            this.EstadoLiquidacion.Visible = true;
            this.EstadoLiquidacion.VisibleIndex = 9;
            this.EstadoLiquidacion.Width = 147;
            // 
            // Chek
            // 
            this.Chek.Caption = "*";
            this.Chek.FieldName = "Chek";
            this.Chek.Name = "Chek";
            this.Chek.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Chek.Visible = true;
            this.Chek.VisibleIndex = 0;
            this.Chek.Width = 20;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo Importacion";
            this.gridColumn1.FieldName = "Tipo_Importacion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlOrdeCompra;
            this.gridView1.Name = "gridView1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1130, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 153);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControlOrdeCompra);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1130, 239);
            this.panel3.TabIndex = 17;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 5, 15, 18, 49, 936);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 5, 15, 18, 49, 936);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1130, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            // 
            // frmImp_Liquidacion_Import_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 414);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmImp_Liquidacion_Import_Consulta";
            this.Text = "Importaciones";
            this.Load += new System.EventHandler(this.frmImp_Liquidacion_Importacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdeCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOrdeCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedidos;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn IdOrdenCompraExt;
        private DevExpress.XtraGrid.Columns.GridColumn CodOrdenCompraExt;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn ci_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoLiquidacion;
        private DevExpress.XtraGrid.Columns.GridColumn Chek;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel3;
    }
}