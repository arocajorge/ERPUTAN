namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_CentroCostos_Consulta
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
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.treeListPlanCta = new DevExpress.XtraTreeList.TreeList();
            this.colCentro_costo2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdCentroCostoPadre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdNivel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colpc_EsMovimiento = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colpc_Estado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCodCentroCosto = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCtaCble = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCentro_costo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdCentroCosto = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPlanCta)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 3, 4, 16, 23, 29, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 4, 5, 16, 23, 29, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(951, 112);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // ucGe_BarraEstadoInferior_Forms
            // 
            this.ucGe_BarraEstadoInferior_Forms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 350);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(951, 26);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.treeListPlanCta);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 112);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(951, 238);
            this.panelMain.TabIndex = 2;
            // 
            // treeListPlanCta
            // 
            this.treeListPlanCta.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colCentro_costo2,
            this.colIdCentroCostoPadre,
            this.colIdNivel,
            this.colpc_EsMovimiento,
            this.colpc_Estado,
            this.colCodCentroCosto,
            this.IdCtaCble,
            this.colCentro_costo,
            this.colIdCentroCosto});
            this.treeListPlanCta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListPlanCta.KeyFieldName = "IdCentroCosto";
            this.treeListPlanCta.Location = new System.Drawing.Point(0, 0);
            this.treeListPlanCta.Name = "treeListPlanCta";
            this.treeListPlanCta.OptionsBehavior.AutoFocusNewNode = true;
            this.treeListPlanCta.OptionsBehavior.Editable = false;
            this.treeListPlanCta.OptionsBehavior.EnableFiltering = true;
            this.treeListPlanCta.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListPlanCta.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListPlanCta.OptionsPrint.PrintAllNodes = true;
            this.treeListPlanCta.OptionsPrint.UsePrintStyles = true;
            this.treeListPlanCta.OptionsView.ShowAutoFilterRow = true;
            this.treeListPlanCta.ParentFieldName = "IdCentroCostoPadre";
            this.treeListPlanCta.Size = new System.Drawing.Size(951, 238);
            this.treeListPlanCta.TabIndex = 4;
            // 
            // colCentro_costo2
            // 
            this.colCentro_costo2.Caption = "Centro_costo";
            this.colCentro_costo2.FieldName = "Centro_costo2";
            this.colCentro_costo2.Name = "colCentro_costo2";
            this.colCentro_costo2.Visible = true;
            this.colCentro_costo2.VisibleIndex = 0;
            this.colCentro_costo2.Width = 335;
            // 
            // colIdCentroCostoPadre
            // 
            this.colIdCentroCostoPadre.Caption = "IdCentroCostoPadre";
            this.colIdCentroCostoPadre.FieldName = "IdCentroCostoPadre";
            this.colIdCentroCostoPadre.Name = "colIdCentroCostoPadre";
            this.colIdCentroCostoPadre.Visible = true;
            this.colIdCentroCostoPadre.VisibleIndex = 1;
            this.colIdCentroCostoPadre.Width = 94;
            // 
            // colIdNivel
            // 
            this.colIdNivel.Caption = "IdNivel";
            this.colIdNivel.FieldName = "IdNivel";
            this.colIdNivel.Name = "colIdNivel";
            this.colIdNivel.Visible = true;
            this.colIdNivel.VisibleIndex = 2;
            this.colIdNivel.Width = 63;
            // 
            // colpc_EsMovimiento
            // 
            this.colpc_EsMovimiento.Caption = "Es Movimiento";
            this.colpc_EsMovimiento.FieldName = "pc_EsMovimiento";
            this.colpc_EsMovimiento.Name = "colpc_EsMovimiento";
            this.colpc_EsMovimiento.Visible = true;
            this.colpc_EsMovimiento.VisibleIndex = 3;
            this.colpc_EsMovimiento.Width = 81;
            // 
            // colpc_Estado
            // 
            this.colpc_Estado.Caption = "Estado";
            this.colpc_Estado.FieldName = "pc_Estado";
            this.colpc_Estado.Name = "colpc_Estado";
            this.colpc_Estado.Visible = true;
            this.colpc_Estado.VisibleIndex = 4;
            this.colpc_Estado.Width = 62;
            // 
            // colCodCentroCosto
            // 
            this.colCodCentroCosto.Caption = "Codigo Alterno";
            this.colCodCentroCosto.FieldName = "CodCentroCosto";
            this.colCodCentroCosto.Name = "colCodCentroCosto";
            this.colCodCentroCosto.Visible = true;
            this.colCodCentroCosto.VisibleIndex = 5;
            this.colCodCentroCosto.Width = 93;
            // 
            // IdCtaCble
            // 
            this.IdCtaCble.Caption = "IdCtaCble";
            this.IdCtaCble.FieldName = "IdCtaCble";
            this.IdCtaCble.Name = "IdCtaCble";
            this.IdCtaCble.Visible = true;
            this.IdCtaCble.VisibleIndex = 6;
            this.IdCtaCble.Width = 96;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Nombre";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "IdCentroCosto";
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 7;
            this.colIdCentroCosto.Width = 109;
            // 
            // frmCon_CentroCostos_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 376);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "frmCon_CentroCostos_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCon_CentroCostos_Consulta";
            this.Load += new System.EventHandler(this.frmCon_CentroCostos_Consulta_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListPlanCta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraTreeList.TreeList treeListPlanCta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCentro_costo2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdCentroCostoPadre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdNivel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colpc_EsMovimiento;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colpc_Estado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCtaCble;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCodCentroCosto;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCentro_costo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdCentroCosto;
    }
}