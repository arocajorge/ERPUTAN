namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Tipo_Nota_Mantenimiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.baCbteBantipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCreditoDebito = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodTipoCbteBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ctPlanctaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctCentrocostoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.ctCbtecbletipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.cmbCuentaContable = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmbCuentaCosto = new Core.Erp.Winform.Controles.UCCon_CentroCosto_ctas_Movi();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baCbteBantipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCreditoDebito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuenta Contable";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Location = new System.Drawing.Point(129, 98);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipo.Properties.DataSource = this.baCbteBantipoInfoBindingSource;
            this.cmbTipo.Properties.DisplayMember = "Descripcion";
            this.cmbTipo.Properties.ValueMember = "CodTipoCbteBan";
            this.cmbTipo.Properties.View = this.gridViewCreditoDebito;
            this.cmbTipo.Size = new System.Drawing.Size(275, 20);
            this.cmbTipo.TabIndex = 3;
            // 
            // baCbteBantipoInfoBindingSource
            // 
            this.baCbteBantipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Cbte_Ban_tipo_Info);
            // 
            // gridViewCreditoDebito
            // 
            this.gridViewCreditoDebito.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodTipoCbteBan,
            this.colDescripcion});
            this.gridViewCreditoDebito.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewCreditoDebito.Name = "gridViewCreditoDebito";
            this.gridViewCreditoDebito.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCreditoDebito.OptionsView.ShowGroupPanel = false;
            // 
            // colCodTipoCbteBan
            // 
            this.colCodTipoCbteBan.Caption = "Codigo";
            this.colCodTipoCbteBan.FieldName = "CodTipoCbteBan";
            this.colCodTipoCbteBan.Name = "colCodTipoCbteBan";
            this.colCodTipoCbteBan.Visible = true;
            this.colCodTipoCbteBan.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // ctPlanctaInfoBindingSource
            // 
            this.ctPlanctaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Plancta_Info);
            // 
            // ctCentrocostoInfoBindingSource
            // 
            this.ctCentrocostoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Centro_costo_Info);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Centro de Costo";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(129, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(129, 70);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(275, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // ctCbtecbletipoInfoBindingSource
            // 
            this.ctCbtecbletipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Cbtecble_tipo_Info);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(456, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // cmbCuentaContable
            // 
            this.cmbCuentaContable.Location = new System.Drawing.Point(127, 123);
            this.cmbCuentaContable.Name = "cmbCuentaContable";
            this.cmbCuentaContable.Size = new System.Drawing.Size(320, 26);
            this.cmbCuentaContable.TabIndex = 26;
            // 
            // cmbCuentaCosto
            // 
            this.cmbCuentaCosto.IdCentroCostoPadre = null;
            this.cmbCuentaCosto.InfoCentroCosto = null;
            this.cmbCuentaCosto.Location = new System.Drawing.Point(125, 155);
            this.cmbCuentaCosto.Name = "cmbCuentaCosto";
            this.cmbCuentaCosto.Size = new System.Drawing.Size(319, 30);
            this.cmbCuentaCosto.TabIndex = 34;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(348, 35);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 35;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(140, 198);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(183, 18);
            this.lblEstado.TabIndex = 36;
            this.lblEstado.Text = "****ANULADO****";
            this.lblEstado.Visible = false;
            // 
            // FrmBA_Tipo_Nota_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 237);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.cmbCuentaCosto);
            this.Controls.Add(this.cmbCuentaContable);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBA_Tipo_Nota_Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Nota Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_Tipo_Nota_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmBA_Tipo_Nota_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baCbteBantipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCreditoDebito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCreditoDebito;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.BindingSource ctCbtecbletipoInfoBindingSource;
        private System.Windows.Forms.BindingSource ctCentrocostoInfoBindingSource;
        private System.Windows.Forms.BindingSource baCbteBantipoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoCbteBan;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private System.Windows.Forms.BindingSource ctPlanctaInfoBindingSource;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCCon_PlanCtaCmb cmbCuentaContable;
        private Controles.UCCon_CentroCosto_ctas_Movi cmbCuentaCosto;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblEstado;

    }
}