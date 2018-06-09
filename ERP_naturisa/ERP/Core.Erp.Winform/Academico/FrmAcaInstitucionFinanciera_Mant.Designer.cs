namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaInstitucionFinanciera_Mant
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
            this.chkbEstado = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new DevExpress.XtraEditors.LabelControl();
            this.cmbTipoCuenta = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblIdInstitucionFinanciera = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigoInstitucion = new DevExpress.XtraEditors.LabelControl();
            this.lblNombreInstitucion = new DevExpress.XtraEditors.LabelControl();
            this.lblPorcentajeComision = new DevExpress.XtraEditors.LabelControl();
            this.txtIdInstitucionFinanciera = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoInstitucion = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreInstitucion = new DevExpress.XtraEditors.TextEdit();
            this.txtPorcentajeComision = new DevExpress.XtraEditors.TextEdit();
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_Cod_Banco = new DevExpress.XtraGrid.GridControl();
            this.gridView_Cod_Banco = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_num_esta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_cod_fee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_con_representa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoAlterno = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreAlterno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdInstitucionFinanciera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreInstitucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeComision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Cod_Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Cod_Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoAlterno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreAlterno.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbEstado
            // 
            this.chkbEstado.AutoSize = true;
            this.chkbEstado.Checked = true;
            this.chkbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbEstado.Location = new System.Drawing.Point(582, 126);
            this.chkbEstado.Name = "chkbEstado";
            this.chkbEstado.Size = new System.Drawing.Size(56, 17);
            this.chkbEstado.TabIndex = 9;
            this.chkbEstado.Text = "Activo";
            this.chkbEstado.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(381, 45);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(128, 16);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "****ANULADO****";
            this.lblEstado.Visible = false;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.Location = new System.Drawing.Point(25, 45);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(62, 13);
            this.lblTipoCuenta.TabIndex = 10;
            this.lblTipoCuenta.Text = "Tipo Cuenta:";
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.Location = new System.Drawing.Point(115, 42);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoCuenta.Properties.DataSource = this.acaCatalogoInfoBindingSource;
            this.cmbTipoCuenta.Properties.DisplayMember = "Descripcion";
            this.cmbTipoCuenta.Properties.ValueMember = "IdCatalogo";
            this.cmbTipoCuenta.Properties.View = this.searchLookUpEdit1View;
            this.cmbTipoCuenta.Size = new System.Drawing.Size(194, 20);
            this.cmbTipoCuenta.TabIndex = 11;
            // 
            // acaCatalogoInfoBindingSource
            // 
            this.acaCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Catalogo_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colIdCatalogo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            this.colIdCatalogo.OptionsColumn.AllowEdit = false;
            this.colIdCatalogo.Visible = true;
            this.colIdCatalogo.VisibleIndex = 1;
            // 
            // lblIdInstitucionFinanciera
            // 
            this.lblIdInstitucionFinanciera.Location = new System.Drawing.Point(547, 45);
            this.lblIdInstitucionFinanciera.Name = "lblIdInstitucionFinanciera";
            this.lblIdInstitucionFinanciera.Size = new System.Drawing.Size(14, 13);
            this.lblIdInstitucionFinanciera.TabIndex = 12;
            this.lblIdInstitucionFinanciera.Text = "Id:";
            // 
            // lblCodigoInstitucion
            // 
            this.lblCodigoInstitucion.Location = new System.Drawing.Point(281, 127);
            this.lblCodigoInstitucion.Name = "lblCodigoInstitucion";
            this.lblCodigoInstitucion.Size = new System.Drawing.Size(37, 13);
            this.lblCodigoInstitucion.TabIndex = 13;
            this.lblCodigoInstitucion.Text = "Código:";
            // 
            // lblNombreInstitucion
            // 
            this.lblNombreInstitucion.Location = new System.Drawing.Point(25, 75);
            this.lblNombreInstitucion.Name = "lblNombreInstitucion";
            this.lblNombreInstitucion.Size = new System.Drawing.Size(54, 13);
            this.lblNombreInstitucion.TabIndex = 14;
            this.lblNombreInstitucion.Text = "Institucion:";
            // 
            // lblPorcentajeComision
            // 
            this.lblPorcentajeComision.Location = new System.Drawing.Point(25, 127);
            this.lblPorcentajeComision.Name = "lblPorcentajeComision";
            this.lblPorcentajeComision.Size = new System.Drawing.Size(60, 13);
            this.lblPorcentajeComision.TabIndex = 17;
            this.lblPorcentajeComision.Text = "% Comisión:";
            // 
            // txtIdInstitucionFinanciera
            // 
            this.txtIdInstitucionFinanciera.EditValue = "0";
            this.txtIdInstitucionFinanciera.Enabled = false;
            this.txtIdInstitucionFinanciera.Location = new System.Drawing.Point(582, 38);
            this.txtIdInstitucionFinanciera.Name = "txtIdInstitucionFinanciera";
            this.txtIdInstitucionFinanciera.Size = new System.Drawing.Size(64, 20);
            this.txtIdInstitucionFinanciera.TabIndex = 18;
            // 
            // txtCodigoInstitucion
            // 
            this.txtCodigoInstitucion.Location = new System.Drawing.Point(115, 72);
            this.txtCodigoInstitucion.Name = "txtCodigoInstitucion";
            this.txtCodigoInstitucion.Properties.MaxLength = 4;
            this.txtCodigoInstitucion.Size = new System.Drawing.Size(73, 20);
            this.txtCodigoInstitucion.TabIndex = 19;
            // 
            // txtNombreInstitucion
            // 
            this.txtNombreInstitucion.Location = new System.Drawing.Point(194, 72);
            this.txtNombreInstitucion.Name = "txtNombreInstitucion";
            this.txtNombreInstitucion.Size = new System.Drawing.Size(452, 20);
            this.txtNombreInstitucion.TabIndex = 20;
            // 
            // txtPorcentajeComision
            // 
            this.txtPorcentajeComision.Location = new System.Drawing.Point(115, 124);
            this.txtPorcentajeComision.Name = "txtPorcentajeComision";
            this.txtPorcentajeComision.Properties.Mask.EditMask = "P3";
            this.txtPorcentajeComision.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcentajeComision.Size = new System.Drawing.Size(43, 20);
            this.txtPorcentajeComision.TabIndex = 23;
            // 
            // ucGe_BarraEstadoInferior_Forms
            // 
            this.ucGe_BarraEstadoInferior_Forms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 350);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(658, 23);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 3;
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
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(658, 32);
            this.ucGe_Menu.TabIndex = 2;
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl_Cod_Banco);
            this.groupControl1.Location = new System.Drawing.Point(12, 170);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(634, 174);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Codigo Para el Banco & Facturacion Electronica";
            // 
            // gridControl_Cod_Banco
            // 
            this.gridControl_Cod_Banco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Cod_Banco.Location = new System.Drawing.Point(2, 21);
            this.gridControl_Cod_Banco.MainView = this.gridView_Cod_Banco;
            this.gridControl_Cod_Banco.Name = "gridControl_Cod_Banco";
            this.gridControl_Cod_Banco.Size = new System.Drawing.Size(630, 151);
            this.gridControl_Cod_Banco.TabIndex = 0;
            this.gridControl_Cod_Banco.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Cod_Banco});
            // 
            // gridView_Cod_Banco
            // 
            this.gridView_Cod_Banco.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_num_esta,
            this.gridColumn_cod_fee,
            this.gridColumn_con_representa});
            this.gridView_Cod_Banco.GridControl = this.gridControl_Cod_Banco;
            this.gridView_Cod_Banco.Name = "gridView_Cod_Banco";
            this.gridView_Cod_Banco.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_Cod_Banco.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn_num_esta
            // 
            this.gridColumn_num_esta.Caption = "#Establ.";
            this.gridColumn_num_esta.Name = "gridColumn_num_esta";
            this.gridColumn_num_esta.Visible = true;
            this.gridColumn_num_esta.VisibleIndex = 0;
            this.gridColumn_num_esta.Width = 125;
            // 
            // gridColumn_cod_fee
            // 
            this.gridColumn_cod_fee.Caption = "Cod. Fee";
            this.gridColumn_cod_fee.Name = "gridColumn_cod_fee";
            this.gridColumn_cod_fee.Visible = true;
            this.gridColumn_cod_fee.VisibleIndex = 1;
            this.gridColumn_cod_fee.Width = 123;
            // 
            // gridColumn_con_representa
            // 
            this.gridColumn_con_representa.Caption = "Concepto que representa";
            this.gridColumn_con_representa.Name = "gridColumn_con_representa";
            this.gridColumn_con_representa.Visible = true;
            this.gridColumn_con_representa.VisibleIndex = 2;
            this.gridColumn_con_representa.Width = 932;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(212, 127);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Código:";
            // 
            // txtCodigoAlterno
            // 
            this.txtCodigoAlterno.Location = new System.Drawing.Point(115, 98);
            this.txtCodigoAlterno.Name = "txtCodigoAlterno";
            this.txtCodigoAlterno.Properties.MaxLength = 4;
            this.txtCodigoAlterno.Size = new System.Drawing.Size(73, 20);
            this.txtCodigoAlterno.TabIndex = 26;
            // 
            // txtNombreAlterno
            // 
            this.txtNombreAlterno.Location = new System.Drawing.Point(194, 98);
            this.txtNombreAlterno.Name = "txtNombreAlterno";
            this.txtNombreAlterno.Size = new System.Drawing.Size(452, 20);
            this.txtNombreAlterno.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Alterno:";
            // 
            // FrmAcaInstitucionFinanciera_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 373);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNombreAlterno);
            this.Controls.Add(this.txtCodigoAlterno);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtPorcentajeComision);
            this.Controls.Add(this.txtNombreInstitucion);
            this.Controls.Add(this.txtCodigoInstitucion);
            this.Controls.Add(this.txtIdInstitucionFinanciera);
            this.Controls.Add(this.lblPorcentajeComision);
            this.Controls.Add(this.lblNombreInstitucion);
            this.Controls.Add(this.lblCodigoInstitucion);
            this.Controls.Add(this.lblIdInstitucionFinanciera);
            this.Controls.Add(this.cmbTipoCuenta);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.chkbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaInstitucionFinanciera_Mant";
            this.Text = "FrmAcaInstitucionFinanciera_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaInstitucionFinanciera_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaInstitucionFinanciera_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdInstitucionFinanciera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreInstitucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeComision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Cod_Banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Cod_Banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoAlterno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreAlterno.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private System.Windows.Forms.CheckBox chkbEstado;
        private System.Windows.Forms.Label lblEstado;
        private DevExpress.XtraEditors.LabelControl lblTipoCuenta;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoCuenta;
        private System.Windows.Forms.BindingSource acaCatalogoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraEditors.LabelControl lblIdInstitucionFinanciera;
        private DevExpress.XtraEditors.LabelControl lblCodigoInstitucion;
        private DevExpress.XtraEditors.LabelControl lblNombreInstitucion;
        private DevExpress.XtraEditors.LabelControl lblPorcentajeComision;
        private DevExpress.XtraEditors.TextEdit txtIdInstitucionFinanciera;
        private DevExpress.XtraEditors.TextEdit txtCodigoInstitucion;
        private DevExpress.XtraEditors.TextEdit txtNombreInstitucion;
        private DevExpress.XtraEditors.TextEdit txtPorcentajeComision;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl_Cod_Banco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Cod_Banco;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_num_esta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_cod_fee;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_con_representa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCodigoAlterno;
        private DevExpress.XtraEditors.TextEdit txtNombreAlterno;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}