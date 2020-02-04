namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_Punto_Cargo_Grupo_Cons
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
            this.gc_Punto_Cargo_Grup = new DevExpress.XtraGrid.GridControl();
            this.gw_Punto_Cargo_Grup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdentificador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaContable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu_Mantenimiento_x_usuario1 = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Punto_Cargo_Grup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Punto_Cargo_Grup)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Punto_Cargo_Grup
            // 
            this.gc_Punto_Cargo_Grup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Punto_Cargo_Grup.Location = new System.Drawing.Point(0, 94);
            this.gc_Punto_Cargo_Grup.MainView = this.gw_Punto_Cargo_Grup;
            this.gc_Punto_Cargo_Grup.Name = "gc_Punto_Cargo_Grup";
            this.gc_Punto_Cargo_Grup.Size = new System.Drawing.Size(787, 222);
            this.gc_Punto_Cargo_Grup.TabIndex = 5;
            this.gc_Punto_Cargo_Grup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw_Punto_Cargo_Grup});
            // 
            // gw_Punto_Cargo_Grup
            // 
            this.gw_Punto_Cargo_Grup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentificador,
            this.colCodigo,
            this.colDescripcion,
            this.colCuentaContable,
            this.colEstado});
            this.gw_Punto_Cargo_Grup.GridControl = this.gc_Punto_Cargo_Grup;
            this.gw_Punto_Cargo_Grup.Name = "gw_Punto_Cargo_Grup";
            this.gw_Punto_Cargo_Grup.OptionsView.ShowAutoFilterRow = true;
            this.gw_Punto_Cargo_Grup.OptionsView.ShowGroupPanel = false;
            this.gw_Punto_Cargo_Grup.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gw_Punto_Cargo_Grup_RowCellStyle);
            // 
            // colIdentificador
            // 
            this.colIdentificador.Caption = "Identificador";
            this.colIdentificador.FieldName = "IdPunto_cargo_grupo";
            this.colIdentificador.Name = "colIdentificador";
            this.colIdentificador.OptionsColumn.AllowEdit = false;
            this.colIdentificador.Visible = true;
            this.colIdentificador.VisibleIndex = 2;
            this.colIdentificador.Width = 69;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "cod_Punto_cargo_grupo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 94;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "nom_punto_cargo_grupo";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 238;
            // 
            // colCuentaContable
            // 
            this.colCuentaContable.Caption = "Cuenta Contable";
            this.colCuentaContable.FieldName = "IdCtaCble";
            this.colCuentaContable.Name = "colCuentaContable";
            this.colCuentaContable.OptionsColumn.AllowEdit = false;
            this.colCuentaContable.Width = 302;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Width = 66;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 316);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(787, 25);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 4;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario1
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2016, 9, 7, 16, 35, 40, 159);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2016, 11, 7, 16, 35, 40, 159);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(787, 94);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 3;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = false;
            // 
            // frmCon_Punto_Cargo_Grupo_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 341);
            this.Controls.Add(this.gc_Punto_Cargo_Grup);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.Name = "frmCon_Punto_Cargo_Grupo_Cons";
            this.Text = " Grupo de Punto Cargo";
            this.Load += new System.EventHandler(this.frmCon_Punto_Cargo_Grupo_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Punto_Cargo_Grup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Punto_Cargo_Grup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Punto_Cargo_Grup;
        private DevExpress.XtraGrid.Views.Grid.GridView gw_Punto_Cargo_Grup;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificador;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaContable;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}