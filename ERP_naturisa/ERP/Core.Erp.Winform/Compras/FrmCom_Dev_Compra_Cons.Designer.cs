namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_Dev_Compra_Cons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCom_Dev_Compra_Cons));
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.gridControl_dev_compra = new DevExpress.XtraGrid.GridControl();
            this.gridView_dev_compra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nom_sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nom_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDevCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nom_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_dev_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_dev_compra)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 2, 28, 17, 54, 7, 350);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 4, 30, 17, 54, 7, 350);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = this.gridControl_dev_compra;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1001, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;

            // 
            // gridControl_dev_compra
            // 
            this.gridControl_dev_compra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_dev_compra.Location = new System.Drawing.Point(0, 0);
            this.gridControl_dev_compra.MainView = this.gridView_dev_compra;
            this.gridControl_dev_compra.Name = "gridControl_dev_compra";
            this.gridControl_dev_compra.Size = new System.Drawing.Size(1001, 288);
            this.gridControl_dev_compra.TabIndex = 0;
            this.gridControl_dev_compra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_dev_compra});
            
            // 
            // gridView_dev_compra
            // 
            this.gridView_dev_compra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nom_sucursal,
            this.nom_bodega,
            this.IdDevCompra,
            this.nom_proveedor,
            this.dv_fecha,
            this.dv_observacion,
            this.Estado});
            this.gridView_dev_compra.GridControl = this.gridControl_dev_compra;
            this.gridView_dev_compra.Name = "gridView_dev_compra";
            this.gridView_dev_compra.OptionsBehavior.Editable = false;
            this.gridView_dev_compra.OptionsView.ShowViewCaption = true;
            this.gridView_dev_compra.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_dev_compra_RowCellStyle);
            // 
            // nom_sucursal
            // 
            this.nom_sucursal.Caption = "Sucursal";
            this.nom_sucursal.FieldName = "nom_sucursal";
            this.nom_sucursal.Name = "nom_sucursal";
            this.nom_sucursal.Visible = true;
            this.nom_sucursal.VisibleIndex = 0;
            this.nom_sucursal.Width = 146;
            // 
            // nom_bodega
            // 
            this.nom_bodega.Caption = "Bodega";
            this.nom_bodega.FieldName = "nom_bodega";
            this.nom_bodega.Name = "nom_bodega";
            this.nom_bodega.Visible = true;
            this.nom_bodega.VisibleIndex = 1;
            this.nom_bodega.Width = 130;
            // 
            // IdDevCompra
            // 
            this.IdDevCompra.Caption = "#Dev. Compra";
            this.IdDevCompra.FieldName = "IdDevCompra";
            this.IdDevCompra.Name = "IdDevCompra";
            this.IdDevCompra.Visible = true;
            this.IdDevCompra.VisibleIndex = 2;
            this.IdDevCompra.Width = 76;
            // 
            // nom_proveedor
            // 
            this.nom_proveedor.Caption = "Proveedor";
            this.nom_proveedor.FieldName = "nom_Proveedor";
            this.nom_proveedor.Name = "nom_proveedor";
            this.nom_proveedor.Visible = true;
            this.nom_proveedor.VisibleIndex = 3;
            this.nom_proveedor.Width = 156;
            // 
            // dv_fecha
            // 
            this.dv_fecha.Caption = "Fecha";
            this.dv_fecha.FieldName = "dv_fecha";
            this.dv_fecha.Name = "dv_fecha";
            this.dv_fecha.Visible = true;
            this.dv_fecha.VisibleIndex = 4;
            this.dv_fecha.Width = 156;
            // 
            // dv_observacion
            // 
            this.dv_observacion.Caption = "Observación";
            this.dv_observacion.FieldName = "dv_observacion";
            this.dv_observacion.Name = "dv_observacion";
            this.dv_observacion.Visible = true;
            this.dv_observacion.VisibleIndex = 5;
            this.dv_observacion.Width = 244;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 6;
            this.Estado.Width = 272;
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 443);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(1001, 26);
            this.ucGe_BarraEstado.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_dev_compra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 288);
            this.panel1.TabIndex = 2;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // FrmCom_Dev_Compra_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "FrmCom_Dev_Compra_Cons";
            this.Text = "Devolución en Compras";
            this.Load += new System.EventHandler(this.FrmCom_Dev_Compra_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_dev_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_dev_compra)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_dev_compra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_dev_compra;
        private DevExpress.XtraGrid.Columns.GridColumn nom_sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn nom_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn IdDevCompra;
        private DevExpress.XtraGrid.Columns.GridColumn nom_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn dv_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn dv_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.Utils.ImageCollection imageCollection1;

    }
}