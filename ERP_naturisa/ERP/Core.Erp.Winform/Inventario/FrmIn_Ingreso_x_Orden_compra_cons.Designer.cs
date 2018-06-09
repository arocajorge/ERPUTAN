namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Ingreso_x_Orden_compra_cons
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl_movi_inv_ing = new DevExpress.XtraGrid.GridControl();
            this.gridView_Movi_Inven_Ing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Su_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bo_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo_Movi_Inven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sucursal_OC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.oc_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.oc_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_movi_inv_ing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Movi_Inven_Ing)).BeginInit();
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 5, 5, 11, 10, 27, 742);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 7, 5, 11, 10, 27, 742);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1010, 155);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 454);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1010, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_movi_inv_ing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 299);
            this.panel1.TabIndex = 2;
            // 
            // gridControl_movi_inv_ing
            // 
            this.gridControl_movi_inv_ing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_movi_inv_ing.Location = new System.Drawing.Point(0, 0);
            this.gridControl_movi_inv_ing.MainView = this.gridView_Movi_Inven_Ing;
            this.gridControl_movi_inv_ing.Name = "gridControl_movi_inv_ing";
            this.gridControl_movi_inv_ing.Size = new System.Drawing.Size(1010, 299);
            this.gridControl_movi_inv_ing.TabIndex = 0;
            this.gridControl_movi_inv_ing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Movi_Inven_Ing});
            // 
            // gridView_Movi_Inven_Ing
            // 
            this.gridView_Movi_Inven_Ing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Su_Descripcion,
            this.bo_Descripcion,
            this.IdNumMovi,
            this.Tipo_Movi_Inven,
            this.cm_fecha,
            this.cm_observacion,
            this.Sucursal_OC,
            this.IdOrdenCompra,
            this.oc_fecha,
            this.oc_observacion,
            this.pr_nombre});
            this.gridView_Movi_Inven_Ing.GridControl = this.gridControl_movi_inv_ing;
            this.gridView_Movi_Inven_Ing.Name = "gridView_Movi_Inven_Ing";
            this.gridView_Movi_Inven_Ing.OptionsBehavior.Editable = false;
            this.gridView_Movi_Inven_Ing.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Movi_Inven_Ing_RowClick);
            this.gridView_Movi_Inven_Ing.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_Movi_Inven_Ing_RowCellStyle);
            // 
            // Su_Descripcion
            // 
            this.Su_Descripcion.Caption = "Sucursal";
            this.Su_Descripcion.FieldName = "Su_Descripcion";
            this.Su_Descripcion.Name = "Su_Descripcion";
            this.Su_Descripcion.Visible = true;
            this.Su_Descripcion.VisibleIndex = 0;
            this.Su_Descripcion.Width = 87;
            // 
            // bo_Descripcion
            // 
            this.bo_Descripcion.Caption = "Bodega";
            this.bo_Descripcion.FieldName = "bo_Descripcion";
            this.bo_Descripcion.Name = "bo_Descripcion";
            this.bo_Descripcion.Visible = true;
            this.bo_Descripcion.VisibleIndex = 1;
            this.bo_Descripcion.Width = 82;
            // 
            // IdNumMovi
            // 
            this.IdNumMovi.Caption = "#Movimiento";
            this.IdNumMovi.FieldName = "IdNumMovi";
            this.IdNumMovi.Name = "IdNumMovi";
            this.IdNumMovi.Visible = true;
            this.IdNumMovi.VisibleIndex = 2;
            this.IdNumMovi.Width = 69;
            // 
            // Tipo_Movi_Inven
            // 
            this.Tipo_Movi_Inven.Caption = "Tipo Movimiento";
            this.Tipo_Movi_Inven.FieldName = "Tipo_Movi_Inven";
            this.Tipo_Movi_Inven.Name = "Tipo_Movi_Inven";
            this.Tipo_Movi_Inven.Visible = true;
            this.Tipo_Movi_Inven.VisibleIndex = 3;
            this.Tipo_Movi_Inven.Width = 115;
            // 
            // cm_fecha
            // 
            this.cm_fecha.Caption = "Fecha";
            this.cm_fecha.FieldName = "cm_fecha";
            this.cm_fecha.Name = "cm_fecha";
            this.cm_fecha.Visible = true;
            this.cm_fecha.VisibleIndex = 4;
            this.cm_fecha.Width = 80;
            // 
            // cm_observacion
            // 
            this.cm_observacion.Caption = "Observavion Inven";
            this.cm_observacion.FieldName = "cm_observacion";
            this.cm_observacion.Name = "cm_observacion";
            this.cm_observacion.Visible = true;
            this.cm_observacion.VisibleIndex = 5;
            this.cm_observacion.Width = 247;
            // 
            // Sucursal_OC
            // 
            this.Sucursal_OC.Caption = "Sucursal OC";
            this.Sucursal_OC.FieldName = "Sucursal_OC";
            this.Sucursal_OC.Name = "Sucursal_OC";
            this.Sucursal_OC.Visible = true;
            this.Sucursal_OC.VisibleIndex = 6;
            this.Sucursal_OC.Width = 96;
            // 
            // IdOrdenCompra
            // 
            this.IdOrdenCompra.Caption = "#OC";
            this.IdOrdenCompra.FieldName = "IdOrdenCompra";
            this.IdOrdenCompra.Name = "IdOrdenCompra";
            this.IdOrdenCompra.Visible = true;
            this.IdOrdenCompra.VisibleIndex = 7;
            this.IdOrdenCompra.Width = 57;
            // 
            // oc_fecha
            // 
            this.oc_fecha.Caption = "Fecha OC";
            this.oc_fecha.FieldName = "oc_fecha";
            this.oc_fecha.Name = "oc_fecha";
            this.oc_fecha.Visible = true;
            this.oc_fecha.VisibleIndex = 8;
            this.oc_fecha.Width = 76;
            // 
            // oc_observacion
            // 
            this.oc_observacion.Caption = "Observacion OC";
            this.oc_observacion.FieldName = "oc_observacion";
            this.oc_observacion.Name = "oc_observacion";
            this.oc_observacion.Visible = true;
            this.oc_observacion.VisibleIndex = 9;
            this.oc_observacion.Width = 121;
            // 
            // pr_nombre
            // 
            this.pr_nombre.Caption = "Proveedor";
            this.pr_nombre.FieldName = "pr_nombre";
            this.pr_nombre.Name = "pr_nombre";
            this.pr_nombre.Visible = true;
            this.pr_nombre.VisibleIndex = 10;
            this.pr_nombre.Width = 150;
            // 
            // FrmIn_Ingreso_x_Orden_compra_cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "FrmIn_Ingreso_x_Orden_compra_cons";
            this.Text = "Ingreso por Orden de Compra Local";
            this.Load += new System.EventHandler(this.FrmIn_Ingreso_x_Orden_compra_cons_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_movi_inv_ing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Movi_Inven_Ing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_movi_inv_ing;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Movi_Inven_Ing;
        private DevExpress.XtraGrid.Columns.GridColumn Su_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn bo_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn IdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo_Movi_Inven;
        private DevExpress.XtraGrid.Columns.GridColumn cm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn cm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal_OC;
        private DevExpress.XtraGrid.Columns.GridColumn IdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn oc_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn oc_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn pr_nombre;

    }
}