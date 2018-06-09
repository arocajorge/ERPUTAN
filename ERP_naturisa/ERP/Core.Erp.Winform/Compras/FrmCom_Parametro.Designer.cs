namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_Parametro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_estado_aprobacion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmb_tipo_movi_inven_x_oc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_estado_anulacion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoMovInven_x_devCom = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbestadoAprobacion_solCom = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_estado_cierre_oc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmb_sucursalxaprobacionsc = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.colIdEstado_cierre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_est_cierre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogocompra_ap_sol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_es_ap_sol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo_dev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_descripcion_dev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogocompra_an = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_anu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_mv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Superior_Mant = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado_aprobacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_movi_inven_x_oc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado_anulacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoMovInven_x_devCom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbestadoAprobacion_solCom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado_cierre_oc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_sucursalxaprobacionsc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmb_estado_cierre_oc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbestadoAprobacion_solCom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbTipoMovInven_x_devCom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_estado_anulacion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_tipo_movi_inven_x_oc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_estado_aprobacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 448);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado de Aprobacion Para las Ordenes/Compra que se crean por primera vez:";
            // 
            // cmb_estado_aprobacion
            // 
            this.cmb_estado_aprobacion.Location = new System.Drawing.Point(31, 40);
            this.cmb_estado_aprobacion.Name = "cmb_estado_aprobacion";
            this.cmb_estado_aprobacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_estado_aprobacion.Properties.DisplayMember = "descripcion";
            this.cmb_estado_aprobacion.Properties.ValueMember = "IdCatalogocompra";
            this.cmb_estado_aprobacion.Properties.View = this.searchLookUpEdit1View;
            this.cmb_estado_aprobacion.Size = new System.Drawing.Size(483, 20);
            this.cmb_estado_aprobacion.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoCatalogo,
            this.coldescripcion,
            this.colEstado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cmb_tipo_movi_inven_x_oc
            // 
            this.cmb_tipo_movi_inven_x_oc.Location = new System.Drawing.Point(31, 100);
            this.cmb_tipo_movi_inven_x_oc.Name = "cmb_tipo_movi_inven_x_oc";
            this.cmb_tipo_movi_inven_x_oc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_movi_inven_x_oc.Properties.DisplayMember = "tm_descripcion2";
            this.cmb_tipo_movi_inven_x_oc.Properties.ValueMember = "IdMovi_inven_tipo";
            this.cmb_tipo_movi_inven_x_oc.Properties.View = this.gridView7;
            this.cmb_tipo_movi_inven_x_oc.Size = new System.Drawing.Size(483, 20);
            this.cmb_tipo_movi_inven_x_oc.TabIndex = 4;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMovi_inven_tipo,
            this.coltm_descripcion,
            this.colestado_mv});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Movimiento de Inventario (Ingreso)  por cada Orden/Compra:";
            // 
            // cmb_estado_anulacion
            // 
            this.cmb_estado_anulacion.Location = new System.Drawing.Point(31, 157);
            this.cmb_estado_anulacion.Name = "cmb_estado_anulacion";
            this.cmb_estado_anulacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_estado_anulacion.Properties.DisplayMember = "descripcion";
            this.cmb_estado_anulacion.Properties.ValueMember = "IdCatalogocompra";
            this.cmb_estado_anulacion.Properties.View = this.gridView8;
            this.cmb_estado_anulacion.Size = new System.Drawing.Size(483, 20);
            this.cmb_estado_anulacion.TabIndex = 6;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogocompra_an,
            this.coldescripcion_anu});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado/Anulacion por defecto para las Orden/Compra cuando se anulan:";
            // 
            // cmbTipoMovInven_x_devCom
            // 
            this.cmbTipoMovInven_x_devCom.Location = new System.Drawing.Point(31, 216);
            this.cmbTipoMovInven_x_devCom.Name = "cmbTipoMovInven_x_devCom";
            this.cmbTipoMovInven_x_devCom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoMovInven_x_devCom.Properties.DisplayMember = "tm_descripcion2";
            this.cmbTipoMovInven_x_devCom.Properties.ValueMember = "IdMovi_inven_tipo";
            this.cmbTipoMovInven_x_devCom.Properties.View = this.gridView9;
            this.cmbTipoMovInven_x_devCom.Size = new System.Drawing.Size(483, 20);
            this.cmbTipoMovInven_x_devCom.TabIndex = 8;
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMovi_inven_tipo_dev,
            this.coltm_descripcion_dev});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de Movimiento de Inventario (Egreso)  por cada devolucion en compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(461, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sucursal que se asignara a las ordenes de compra cuando se apruebe las solicitude" +
    "s de compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(419, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de estado de aprobacion cuando se crea por primera vez una solicitud de comp" +
    "ra:";
            // 
            // cmbestadoAprobacion_solCom
            // 
            this.cmbestadoAprobacion_solCom.Location = new System.Drawing.Point(31, 274);
            this.cmbestadoAprobacion_solCom.Name = "cmbestadoAprobacion_solCom";
            this.cmbestadoAprobacion_solCom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbestadoAprobacion_solCom.Properties.DisplayMember = "descripcion";
            this.cmbestadoAprobacion_solCom.Properties.ValueMember = "IdCatalogocompra";
            this.cmbestadoAprobacion_solCom.Properties.View = this.gridView11;
            this.cmbestadoAprobacion_solCom.Size = new System.Drawing.Size(483, 20);
            this.cmbestadoAprobacion_solCom.TabIndex = 12;
            // 
            // gridView11
            // 
            this.gridView11.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogocompra_ap_sol,
            this.coldescripcion_es_ap_sol});
            this.gridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView11.Name = "gridView11";
            this.gridView11.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView11.OptionsView.ShowGroupPanel = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(363, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Estado de cierre por defecto para cuando se haga una ordenes de compra:";
            // 
            // cmb_estado_cierre_oc
            // 
            this.cmb_estado_cierre_oc.Location = new System.Drawing.Point(31, 391);
            this.cmb_estado_cierre_oc.Name = "cmb_estado_cierre_oc";
            this.cmb_estado_cierre_oc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_estado_cierre_oc.Properties.DisplayMember = "Descripcion";
            this.cmb_estado_cierre_oc.Properties.ValueMember = "IdEstado_cierre";
            this.cmb_estado_cierre_oc.Properties.View = this.gridView12;
            this.cmb_estado_cierre_oc.Size = new System.Drawing.Size(483, 20);
            this.cmb_estado_cierre_oc.TabIndex = 14;
            // 
            // gridView12
            // 
            this.gridView12.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstado_cierre,
            this.colDescripcion_est_cierre});
            this.gridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView12.Name = "gridView12";
            this.gridView12.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView12.OptionsView.ShowGroupPanel = false;
            // 
            // cmb_sucursalxaprobacionsc
            // 
            this.cmb_sucursalxaprobacionsc.Location = new System.Drawing.Point(31, 333);
            this.cmb_sucursalxaprobacionsc.Name = "cmb_sucursalxaprobacionsc";
            this.cmb_sucursalxaprobacionsc.Size = new System.Drawing.Size(483, 26);
            this.cmb_sucursalxaprobacionsc.TabIndex = 16;
            // 
            // colIdEstado_cierre
            // 
            this.colIdEstado_cierre.Caption = "IdEstado_cierre";
            this.colIdEstado_cierre.FieldName = "IdEstado_cierre";
            this.colIdEstado_cierre.Name = "colIdEstado_cierre";
            this.colIdEstado_cierre.Visible = true;
            this.colIdEstado_cierre.VisibleIndex = 0;
            this.colIdEstado_cierre.Width = 210;
            // 
            // colDescripcion_est_cierre
            // 
            this.colDescripcion_est_cierre.Caption = "Descripcion";
            this.colDescripcion_est_cierre.FieldName = "Descripcion";
            this.colDescripcion_est_cierre.Name = "colDescripcion_est_cierre";
            this.colDescripcion_est_cierre.Visible = true;
            this.colDescripcion_est_cierre.VisibleIndex = 1;
            this.colDescripcion_est_cierre.Width = 954;
            // 
            // colIdCatalogocompra_ap_sol
            // 
            this.colIdCatalogocompra_ap_sol.Caption = "IdCatalogocompra";
            this.colIdCatalogocompra_ap_sol.FieldName = "IdCatalogocompra";
            this.colIdCatalogocompra_ap_sol.Name = "colIdCatalogocompra_ap_sol";
            this.colIdCatalogocompra_ap_sol.Visible = true;
            this.colIdCatalogocompra_ap_sol.VisibleIndex = 0;
            // 
            // coldescripcion_es_ap_sol
            // 
            this.coldescripcion_es_ap_sol.Caption = "descripcion";
            this.coldescripcion_es_ap_sol.FieldName = "descripcion";
            this.coldescripcion_es_ap_sol.Name = "coldescripcion_es_ap_sol";
            this.coldescripcion_es_ap_sol.Visible = true;
            this.coldescripcion_es_ap_sol.VisibleIndex = 1;
            // 
            // colIdMovi_inven_tipo_dev
            // 
            this.colIdMovi_inven_tipo_dev.Caption = "gridColumn1";
            this.colIdMovi_inven_tipo_dev.Name = "colIdMovi_inven_tipo_dev";
            this.colIdMovi_inven_tipo_dev.Visible = true;
            this.colIdMovi_inven_tipo_dev.VisibleIndex = 0;
            // 
            // coltm_descripcion_dev
            // 
            this.coltm_descripcion_dev.Caption = "Descripcion";
            this.coltm_descripcion_dev.FieldName = "tm_descripcion";
            this.coltm_descripcion_dev.Name = "coltm_descripcion_dev";
            this.coltm_descripcion_dev.Visible = true;
            this.coltm_descripcion_dev.VisibleIndex = 1;
            // 
            // colIdCatalogocompra_an
            // 
            this.colIdCatalogocompra_an.Caption = "IdCatalogocompra";
            this.colIdCatalogocompra_an.FieldName = "IdCatalogocompra";
            this.colIdCatalogocompra_an.Name = "colIdCatalogocompra_an";
            this.colIdCatalogocompra_an.Visible = true;
            this.colIdCatalogocompra_an.VisibleIndex = 0;
            this.colIdCatalogocompra_an.Width = 210;
            // 
            // coldescripcion_anu
            // 
            this.coldescripcion_anu.Caption = "descripcion";
            this.coldescripcion_anu.FieldName = "descripcion";
            this.coldescripcion_anu.Name = "coldescripcion_anu";
            this.coldescripcion_anu.Visible = true;
            this.coldescripcion_anu.VisibleIndex = 1;
            this.coldescripcion_anu.Width = 954;
            // 
            // colIdMovi_inven_tipo
            // 
            this.colIdMovi_inven_tipo.Caption = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Name = "colIdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Visible = true;
            this.colIdMovi_inven_tipo.VisibleIndex = 0;
            this.colIdMovi_inven_tipo.Width = 147;
            // 
            // coltm_descripcion
            // 
            this.coltm_descripcion.Caption = "Descripcion";
            this.coltm_descripcion.FieldName = "tm_descripcion";
            this.coltm_descripcion.Name = "coltm_descripcion";
            this.coltm_descripcion.Visible = true;
            this.coltm_descripcion.VisibleIndex = 1;
            this.coltm_descripcion.Width = 862;
            // 
            // colestado_mv
            // 
            this.colestado_mv.Caption = "estado";
            this.colestado_mv.FieldName = "estado";
            this.colestado_mv.Name = "colestado_mv";
            this.colestado_mv.Visible = true;
            this.colestado_mv.VisibleIndex = 2;
            this.colestado_mv.Width = 155;
            // 
            // colIdTipoCatalogo
            // 
            this.colIdTipoCatalogo.Caption = "IdTipoCatalogo";
            this.colIdTipoCatalogo.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo.Name = "colIdTipoCatalogo";
            this.colIdTipoCatalogo.Visible = true;
            this.colIdTipoCatalogo.VisibleIndex = 0;
            this.colIdTipoCatalogo.Width = 95;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 940;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 129;
            // 
            // ucGe_Menu_Superior_Mant
            // 
            this.ucGe_Menu_Superior_Mant.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant.Name = "ucGe_Menu_Superior_Mant";
            this.ucGe_Menu_Superior_Mant.Size = new System.Drawing.Size(701, 27);
            this.ucGe_Menu_Superior_Mant.TabIndex = 3;
            this.ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnproductos = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 475);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(701, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 2;
            // 
            // FrmCom_Parametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmCom_Parametro";
            this.Text = "Parámetros de Compras";
            this.Load += new System.EventHandler(this.FrmCom_Parametro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado_aprobacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_movi_inven_x_oc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado_anulacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoMovInven_x_devCom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbestadoAprobacion_solCom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado_cierre_oc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_estado_cierre_oc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbestadoAprobacion_solCom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoMovInven_x_devCom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_estado_anulacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_tipo_movi_inven_x_oc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_estado_aprobacion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private Controles.UCGe_Sucursal_combo cmb_sucursalxaprobacionsc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_mv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogocompra_an;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_anu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo_dev;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_descripcion_dev;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogocompra_ap_sol;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_es_ap_sol;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado_cierre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_est_cierre;
    }
}