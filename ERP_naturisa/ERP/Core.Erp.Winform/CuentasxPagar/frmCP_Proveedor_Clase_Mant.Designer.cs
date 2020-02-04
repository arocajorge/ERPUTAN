namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_Proveedor_Clase_Mant
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
            this.label7 = new System.Windows.Forms.Label();
            this.lblanulado = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_sub_centro_costo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ucCon_CentroCosto_ctas_Movi1 = new Core.Erp.Winform.Controles.UCCon_CentroCosto_ctas_Movi();
            this.cmb_ctacble_gastos = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_ctacble_anticipo = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.cmb_CtaCble_CXP = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sub_centro_costo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cuenta Cble CXP:";
            // 
            // lblanulado
            // 
            this.lblanulado.AutoSize = true;
            this.lblanulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanulado.ForeColor = System.Drawing.Color.Red;
            this.lblanulado.Location = new System.Drawing.Point(277, 6);
            this.lblanulado.Name = "lblanulado";
            this.lblanulado.Size = new System.Drawing.Size(150, 20);
            this.lblanulado.TabIndex = 15;
            this.lblanulado.Text = "****ANULADO****";
            this.lblanulado.Visible = false;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(498, 20);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo:";
            // 
            // cmb_sub_centro_costo
            // 
            this.cmb_sub_centro_costo.Location = new System.Drawing.Point(149, 237);
            this.cmb_sub_centro_costo.Name = "cmb_sub_centro_costo";
            this.cmb_sub_centro_costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sub_centro_costo.Properties.DisplayMember = "Centro_costo2";
            this.cmb_sub_centro_costo.Properties.ValueMember = "IdCentroCosto_sub_centro_costo";
            this.cmb_sub_centro_costo.Properties.View = this.gridView3;
            this.cmb_sub_centro_costo.Size = new System.Drawing.Size(448, 20);
            this.cmb_sub_centro_costo.TabIndex = 12;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto2,
            this.colIdCentroCosto_sub_centro_costo,
            this.colCentro_costo1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto2
            // 
            this.colIdCentroCosto2.Caption = "IdCentroCosto";
            this.colIdCentroCosto2.FieldName = "IdCentroCosto";
            this.colIdCentroCosto2.Name = "colIdCentroCosto2";
            this.colIdCentroCosto2.Visible = true;
            this.colIdCentroCosto2.VisibleIndex = 0;
            this.colIdCentroCosto2.Width = 133;
            // 
            // colIdCentroCosto_sub_centro_costo
            // 
            this.colIdCentroCosto_sub_centro_costo.Caption = "Id Sub Centro Costo";
            this.colIdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Name = "colIdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Visible = true;
            this.colIdCentroCosto_sub_centro_costo.VisibleIndex = 1;
            this.colIdCentroCosto_sub_centro_costo.Width = 162;
            // 
            // colCentro_costo1
            // 
            this.colCentro_costo1.Caption = "Sub Centro Costo";
            this.colCentro_costo1.FieldName = "Centro_costo";
            this.colCentro_costo1.Name = "colCentro_costo1";
            this.colCentro_costo1.Visible = true;
            this.colCentro_costo1.VisibleIndex = 2;
            this.colCentro_costo1.Width = 885;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sub Centro de Costo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Centro de Costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cuenta Cble x Gastos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cuenta Cble x Anticipo:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(149, 53);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(449, 20);
            this.txtdescripcion.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(149, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(92, 20);
            this.txtId.TabIndex = 3;
            this.txtId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(26, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(97, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id Clase Proveedor";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucCon_CentroCosto_ctas_Movi1);
            this.panelControl1.Controls.Add(this.cmb_ctacble_gastos);
            this.panelControl1.Controls.Add(this.cmb_ctacble_anticipo);
            this.panelControl1.Controls.Add(this.cmb_CtaCble_CXP);
            this.panelControl1.Controls.Add(this.chkEstado);
            this.panelControl1.Controls.Add(this.lblanulado);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.lblId);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtcodigo);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.txtId);
            this.panelControl1.Controls.Add(this.cmb_sub_centro_costo);
            this.panelControl1.Controls.Add(this.txtdescripcion);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(677, 296);
            this.panelControl1.TabIndex = 3;
            // 
            // ucCon_CentroCosto_ctas_Movi1
            // 
            this.ucCon_CentroCosto_ctas_Movi1.IdCentroCostoPadre = null;
            this.ucCon_CentroCosto_ctas_Movi1.InfoCentroCosto = null;
            this.ucCon_CentroCosto_ctas_Movi1.Location = new System.Drawing.Point(146, 201);
            this.ucCon_CentroCosto_ctas_Movi1.Name = "ucCon_CentroCosto_ctas_Movi1";
            this.ucCon_CentroCosto_ctas_Movi1.Size = new System.Drawing.Size(456, 30);
            this.ucCon_CentroCosto_ctas_Movi1.TabIndex = 22;
            // 
            // cmb_ctacble_gastos
            // 
            this.cmb_ctacble_gastos.Location = new System.Drawing.Point(147, 155);
            this.cmb_ctacble_gastos.Name = "cmb_ctacble_gastos";
            this.cmb_ctacble_gastos.Size = new System.Drawing.Size(455, 26);
            this.cmb_ctacble_gastos.TabIndex = 21;
            // 
            // cmb_ctacble_anticipo
            // 
            this.cmb_ctacble_anticipo.Location = new System.Drawing.Point(147, 125);
            this.cmb_ctacble_anticipo.Name = "cmb_ctacble_anticipo";
            this.cmb_ctacble_anticipo.Size = new System.Drawing.Size(455, 26);
            this.cmb_ctacble_anticipo.TabIndex = 20;
            // 
            // cmb_CtaCble_CXP
            // 
            this.cmb_CtaCble_CXP.Location = new System.Drawing.Point(146, 98);
            this.cmb_CtaCble_CXP.Name = "cmb_CtaCble_CXP";
            this.cmb_CtaCble_CXP.Size = new System.Drawing.Size(455, 26);
            this.cmb_CtaCble_CXP.TabIndex = 19;
            // 
            // chkEstado
            // 
            this.chkEstado.Location = new System.Drawing.Point(545, 77);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "Activo";
            this.chkEstado.Size = new System.Drawing.Size(54, 19);
            this.chkEstado.TabIndex = 18;
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 325);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(677, 26);
            this.ucGe_BarraEstado.TabIndex = 1;
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
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(677, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // frmCP_Proveedor_Clase_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 351);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCP_Proveedor_Clase_Mant";
            this.Text = "Mantenimiento de Clase de Proveedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCP_Proveedor_Clase_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCP_Proveedor_Clase_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sub_centro_costo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_sub_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblanulado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_sub_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private Controles.UCCon_PlanCtaCmb cmb_CtaCble_CXP;
        private Controles.UCCon_PlanCtaCmb cmb_ctacble_gastos;
        private Controles.UCCon_PlanCtaCmb cmb_ctacble_anticipo;
        private Controles.UCCon_CentroCosto_ctas_Movi ucCon_CentroCosto_ctas_Movi1;
    }
}