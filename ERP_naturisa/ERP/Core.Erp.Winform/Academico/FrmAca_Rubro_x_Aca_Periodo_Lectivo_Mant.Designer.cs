namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant
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
            this.acaCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlValores_x_Periodo = new DevExpress.XtraGrid.GridControl();
            this.gridView_Valores_x_Periodo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChequeo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucAca_Anio_Lectivo1 = new Core.Erp.Winform.Controles.UCAca_Anio_Lectivo();
            this.ucAca_Rubro1 = new Core.Erp.Winform.Controles.UCAca_Rubro();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorRubro = new DevExpress.XtraEditors.TextEdit();
            this.chkSeleccionarTodos = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlValores_x_Periodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Valores_x_Periodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorRubro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarTodos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // acaCatalogoInfoBindingSource
            // 
            this.acaCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Catalogo_Info);
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(729, 0);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(170, 25);
            this.lblAnulado.TabIndex = 48;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // ucGe_BarraEstadoInferior_Forms
            // 
            this.ucGe_BarraEstadoInferior_Forms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 782);
            this.ucGe_BarraEstadoInferior_Forms.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(900, 28);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 4;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(900, 39);
            this.ucGe_Menu.TabIndex = 3;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlValores_x_Periodo);
            this.groupControl1.Location = new System.Drawing.Point(13, 143);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(871, 498);
            this.groupControl1.TabIndex = 54;
            this.groupControl1.Text = "Valores por periodo lectivo";
            // 
            // gridControlValores_x_Periodo
            // 
            this.gridControlValores_x_Periodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlValores_x_Periodo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlValores_x_Periodo.Location = new System.Drawing.Point(2, 24);
            this.gridControlValores_x_Periodo.MainView = this.gridView_Valores_x_Periodo;
            this.gridControlValores_x_Periodo.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlValores_x_Periodo.Name = "gridControlValores_x_Periodo";
            this.gridControlValores_x_Periodo.Size = new System.Drawing.Size(867, 472);
            this.gridControlValores_x_Periodo.TabIndex = 0;
            this.gridControlValores_x_Periodo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Valores_x_Periodo});
            // 
            // gridView_Valores_x_Periodo
            // 
            this.gridView_Valores_x_Periodo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPeriodo,
            this.colFechaIni,
            this.colcolFechaFin,
            this.colValor,
            this.colChequeo});
            this.gridView_Valores_x_Periodo.GridControl = this.gridControlValores_x_Periodo;
            this.gridView_Valores_x_Periodo.Name = "gridView_Valores_x_Periodo";
            this.gridView_Valores_x_Periodo.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Valores_x_Periodo.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPeriodo
            // 
            this.colIdPeriodo.Caption = "IdPeriodo";
            this.colIdPeriodo.FieldName = "IdPeriodo";
            this.colIdPeriodo.Name = "colIdPeriodo";
            this.colIdPeriodo.Visible = true;
            this.colIdPeriodo.VisibleIndex = 0;
            this.colIdPeriodo.Width = 70;
            // 
            // colFechaIni
            // 
            this.colFechaIni.Caption = "Inicial";
            this.colFechaIni.FieldName = "FechaInicio";
            this.colFechaIni.Name = "colFechaIni";
            this.colFechaIni.Visible = true;
            this.colFechaIni.VisibleIndex = 1;
            this.colFechaIni.Width = 92;
            // 
            // colcolFechaFin
            // 
            this.colcolFechaFin.Caption = "Final";
            this.colcolFechaFin.FieldName = "FechaFin";
            this.colcolFechaFin.Name = "colcolFechaFin";
            this.colcolFechaFin.Visible = true;
            this.colcolFechaFin.VisibleIndex = 2;
            this.colcolFechaFin.Width = 103;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 3;
            this.colValor.Width = 213;
            // 
            // colChequeo
            // 
            this.colChequeo.Caption = "Chequeo";
            this.colChequeo.FieldName = "chequeo";
            this.colChequeo.Name = "colChequeo";
            this.colChequeo.Visible = true;
            this.colChequeo.VisibleIndex = 4;
            this.colChequeo.Width = 88;
            // 
            // ucAca_Anio_Lectivo1
            // 
            this.ucAca_Anio_Lectivo1.Location = new System.Drawing.Point(483, 48);
            this.ucAca_Anio_Lectivo1.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Anio_Lectivo1.Name = "ucAca_Anio_Lectivo1";
            this.ucAca_Anio_Lectivo1.Size = new System.Drawing.Size(399, 33);
            this.ucAca_Anio_Lectivo1.TabIndex = 55;
            // 
            // ucAca_Rubro1
            // 
            this.ucAca_Rubro1.Location = new System.Drawing.Point(22, 48);
            this.ucAca_Rubro1.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Rubro1.Name = "ucAca_Rubro1";
            this.ucAca_Rubro1.Size = new System.Drawing.Size(453, 33);
            this.ucAca_Rubro1.TabIndex = 56;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(433, 94);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 16);
            this.labelControl1.TabIndex = 57;
            this.labelControl1.Text = "Valor";
            // 
            // txtValorRubro
            // 
            this.txtValorRubro.Location = new System.Drawing.Point(519, 88);
            this.txtValorRubro.Name = "txtValorRubro";
            this.txtValorRubro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorRubro.Size = new System.Drawing.Size(221, 22);
            this.txtValorRubro.TabIndex = 58;
            this.txtValorRubro.Leave += new System.EventHandler(this.txtValorRubro_Leave);
            // 
            // chkSeleccionarTodos
            // 
            this.chkSeleccionarTodos.Location = new System.Drawing.Point(746, 88);
            this.chkSeleccionarTodos.Name = "chkSeleccionarTodos";
            this.chkSeleccionarTodos.Properties.Caption = "Seleccionar Todos";
            this.chkSeleccionarTodos.Size = new System.Drawing.Size(136, 21);
            this.chkSeleccionarTodos.TabIndex = 59;
            this.chkSeleccionarTodos.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodos_CheckedChanged);
            // 
            // FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 810);
            this.Controls.Add(this.chkSeleccionarTodos);
            this.Controls.Add(this.txtValorRubro);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ucAca_Rubro1);
            this.Controls.Add(this.ucAca_Anio_Lectivo1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant";
            this.Text = "FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlValores_x_Periodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Valores_x_Periodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorRubro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarTodos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.BindingSource acaCatalogoInfoBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlValores_x_Periodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Valores_x_Periodo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn colcolFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colChequeo;
        private Controles.UCAca_Anio_Lectivo ucAca_Anio_Lectivo1;
        private Controles.UCAca_Rubro ucAca_Rubro1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtValorRubro;
        private DevExpress.XtraEditors.CheckEdit chkSeleccionarTodos;
    }
}