namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaCatalogo_Mant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.txtIdCatalogo = new DevExpress.XtraEditors.TextEdit();
            this.txtOrden = new DevExpress.XtraEditors.TextEdit();
            this.lblOrden = new DevExpress.XtraEditors.LabelControl();
            this.cmbTipoCatalogo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaCatalogoTipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkbEstado = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_Menu_Superior_Catalogo_Mant = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCatalogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCatalogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoTipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtIdCatalogo);
            this.panel1.Controls.Add(this.txtOrden);
            this.panel1.Controls.Add(this.lblOrden);
            this.panel1.Controls.Add(this.cmbTipoCatalogo);
            this.panel1.Controls.Add(this.chkbEstado);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 190);
            this.panel1.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(127, 90);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(293, 20);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtIdCatalogo
            // 
            this.txtIdCatalogo.Location = new System.Drawing.Point(125, 38);
            this.txtIdCatalogo.Name = "txtIdCatalogo";
            this.txtIdCatalogo.Size = new System.Drawing.Size(82, 20);
            this.txtIdCatalogo.TabIndex = 11;
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(127, 116);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(80, 20);
            this.txtOrden.TabIndex = 10;
            this.txtOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrden_KeyPress);
            // 
            // lblOrden
            // 
            this.lblOrden.Location = new System.Drawing.Point(33, 119);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(34, 13);
            this.lblOrden.TabIndex = 9;
            this.lblOrden.Text = "Orden:";
            // 
            // cmbTipoCatalogo
            // 
            this.cmbTipoCatalogo.Location = new System.Drawing.Point(126, 62);
            this.cmbTipoCatalogo.Name = "cmbTipoCatalogo";
            this.cmbTipoCatalogo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoCatalogo.Properties.DataSource = this.acaCatalogoTipoInfoBindingSource;
            this.cmbTipoCatalogo.Properties.DisplayMember = "Descripcion";
            this.cmbTipoCatalogo.Properties.ValueMember = "IdTipoCatalogo";
            this.cmbTipoCatalogo.Properties.View = this.searchLookUpEdit1View;
            this.cmbTipoCatalogo.Size = new System.Drawing.Size(205, 20);
            this.cmbTipoCatalogo.TabIndex = 8;
            // 
            // acaCatalogoTipoInfoBindingSource
            // 
            this.acaCatalogoTipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_CatalogoTipo_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoCatalogo,
            this.colDescripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoCatalogo
            // 
            this.colIdTipoCatalogo.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo.Name = "colIdTipoCatalogo";
            this.colIdTipoCatalogo.OptionsColumn.AllowEdit = false;
            this.colIdTipoCatalogo.Visible = true;
            this.colIdTipoCatalogo.VisibleIndex = 0;
            this.colIdTipoCatalogo.Width = 248;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 926;
            // 
            // chkbEstado
            // 
            this.chkbEstado.AutoSize = true;
            this.chkbEstado.Checked = true;
            this.chkbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbEstado.Location = new System.Drawing.Point(388, 157);
            this.chkbEstado.Name = "chkbEstado";
            this.chkbEstado.Size = new System.Drawing.Size(56, 17);
            this.chkbEstado.TabIndex = 7;
            this.chkbEstado.Text = "Activo";
            this.chkbEstado.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(230, 158);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(143, 16);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "****ANULADO****";
            this.lblEstado.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Catalogo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Catalogo:";
            // 
            // ucGe_Menu_Superior_Catalogo_Mant
            // 
            this.ucGe_Menu_Superior_Catalogo_Mant.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Catalogo_Mant.Name = "ucGe_Menu_Superior_Catalogo_Mant";
            this.ucGe_Menu_Superior_Catalogo_Mant.Size = new System.Drawing.Size(456, 29);
            this.ucGe_Menu_Superior_Catalogo_Mant.TabIndex = 1;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Catalogo_Mant.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_Catalogo_Mant_event_btnGuardar_Click);
            this.ucGe_Menu_Superior_Catalogo_Mant.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_Catalogo_Mant_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior_Catalogo_Mant.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_Catalogo_Mant_event_btnAnular_Click);
            this.ucGe_Menu_Superior_Catalogo_Mant.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 219);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(456, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // FrmAcaCatalogo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 245);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Catalogo_Mant);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmAcaCatalogo_Mant";
            this.Text = "FrmAcaCatalogo_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaCatalogo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaCatalogo_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCatalogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCatalogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoTipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Catalogo_Mant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox chkbEstado;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoCatalogo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource acaCatalogoTipoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.TextEdit txtOrden;
        private DevExpress.XtraEditors.LabelControl lblOrden;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.TextEdit txtIdCatalogo;
    }
}