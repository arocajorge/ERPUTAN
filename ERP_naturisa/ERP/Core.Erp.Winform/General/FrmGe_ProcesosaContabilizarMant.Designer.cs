namespace Core.Erp.Winform.General
{
    partial class FrmGe_ProcesosaContabilizarMant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGe_ProcesosaContabilizarMant));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_guardarysalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.tbsisDocumentoTipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTipoContable = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tbsisParamContTipoContabilizacionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo_Conta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtParamConta = new DevExpress.XtraEditors.TextEdit();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo_Conta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo_Conta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoDocu = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodDocumentoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisDocumentoTipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoContable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisParamContTipoContabilizacionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParamConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDocu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.toolStripSeparator5,
            this.btn_guardarysalir,
            this.toolStripSeparator6,
            this.btn_salir,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(403, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(69, 22);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_guardarysalir
            // 
            this.btn_guardarysalir.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardarysalir.Image")));
            this.btn_guardarysalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardarysalir.Name = "btn_guardarysalir";
            this.btn_guardarysalir.Size = new System.Drawing.Size(103, 22);
            this.btn_guardarysalir.Text = "Guardar y Salir";
            this.btn_guardarysalir.Click += new System.EventHandler(this.btn_guardarysalir_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(95, 22);
            this.toolStripLabel2.Text = "V21112013  11:28";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 13);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Tipo de Documento:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "Descripción:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "Tipo Contable:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 112);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 13);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "Parametros Contables:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(152, 50);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescripcion.Properties.Appearance.Options.UseForeColor = true;
            this.txtDescripcion.Properties.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(220, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // tbsisDocumentoTipoInfoBindingSource
            // 
            this.tbsisDocumentoTipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_sis_Documento_Tipo_Info);
            // 
            // cmbTipoContable
            // 
            this.cmbTipoContable.Location = new System.Drawing.Point(152, 79);
            this.cmbTipoContable.Name = "cmbTipoContable";
            this.cmbTipoContable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoContable.Properties.DataSource = this.tbsisParamContTipoContabilizacionInfoBindingSource;
            this.cmbTipoContable.Properties.DisplayMember = "IdTipo_Conta";
            this.cmbTipoContable.Properties.NullText = "";
            this.cmbTipoContable.Properties.ValueMember = "IdTipo_Conta";
            this.cmbTipoContable.Properties.View = this.gridView1;
            this.cmbTipoContable.Size = new System.Drawing.Size(220, 20);
            this.cmbTipoContable.TabIndex = 2;
            this.cmbTipoContable.EditValueChanged += new System.EventHandler(this.cmbTipoContable_EditValueChanged);
            // 
            // tbsisParamContTipoContabilizacionInfoBindingSource
            // 
            this.tbsisParamContTipoContabilizacionInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_sis_Param_Cont_Tipo_Contabilizacion_Info);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion2,
            this.colIdTipo_Conta2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion2
            // 
            this.colDescripcion2.FieldName = "Descripcion";
            this.colDescripcion2.Name = "colDescripcion2";
            this.colDescripcion2.Visible = true;
            this.colDescripcion2.VisibleIndex = 1;
            // 
            // colIdTipo_Conta2
            // 
            this.colIdTipo_Conta2.Caption = "Id Tipo Contable";
            this.colIdTipo_Conta2.FieldName = "IdTipo_Conta";
            this.colIdTipo_Conta2.Name = "colIdTipo_Conta2";
            this.colIdTipo_Conta2.Visible = true;
            this.colIdTipo_Conta2.VisibleIndex = 0;
            // 
            // txtParamConta
            // 
            this.txtParamConta.Location = new System.Drawing.Point(152, 109);
            this.txtParamConta.Name = "txtParamConta";
            this.txtParamConta.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtParamConta.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtParamConta.Properties.Appearance.Options.UseBackColor = true;
            this.txtParamConta.Properties.Appearance.Options.UseForeColor = true;
            this.txtParamConta.Properties.ReadOnly = true;
            this.txtParamConta.Size = new System.Drawing.Size(220, 20);
            this.txtParamConta.TabIndex = 3;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 0;
            // 
            // colIdTipo_Conta
            // 
            this.colIdTipo_Conta.FieldName = "IdTipo_Conta";
            this.colIdTipo_Conta.Name = "colIdTipo_Conta";
            // 
            // colIdTipo_Conta1
            // 
            this.colIdTipo_Conta1.FieldName = "IdTipo_Conta";
            this.colIdTipo_Conta1.Name = "colIdTipo_Conta1";
            this.colIdTipo_Conta1.Visible = true;
            this.colIdTipo_Conta1.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            // 
            // cmbTipoDocu
            // 
            this.cmbTipoDocu.Location = new System.Drawing.Point(152, 19);
            this.cmbTipoDocu.Name = "cmbTipoDocu";
            this.cmbTipoDocu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoDocu.Properties.DataSource = this.tbsisDocumentoTipoInfoBindingSource;
            this.cmbTipoDocu.Properties.DisplayMember = "codDocumentoTipo";
            this.cmbTipoDocu.Properties.NullText = "";
            this.cmbTipoDocu.Properties.ValueMember = "codDocumentoTipo";
            this.cmbTipoDocu.Properties.View = this.searchLookUpEdit1View;
            this.cmbTipoDocu.Size = new System.Drawing.Size(220, 20);
            this.cmbTipoDocu.TabIndex = 0;
            this.cmbTipoDocu.EditValueChanged += new System.EventHandler(this.cmbTipoDocu_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodDocumentoTipo,
            this.coldescripcion3,
            this.colestado,
            this.colPosicion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colcodDocumentoTipo
            // 
            this.colcodDocumentoTipo.FieldName = "codDocumentoTipo";
            this.colcodDocumentoTipo.Name = "colcodDocumentoTipo";
            // 
            // coldescripcion3
            // 
            this.coldescripcion3.Caption = "Descripción";
            this.coldescripcion3.FieldName = "descripcion";
            this.coldescripcion3.Name = "coldescripcion3";
            this.coldescripcion3.Visible = true;
            this.coldescripcion3.VisibleIndex = 0;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            // 
            // colPosicion
            // 
            this.colPosicion.FieldName = "Posicion";
            this.colPosicion.Name = "colPosicion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtParamConta);
            this.groupBox1.Controls.Add(this.cmbTipoDocu);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.cmbTipoContable);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FrmGe_ProcesosaContabilizarMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(403, 182);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmGe_ProcesosaContabilizarMant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Procesos Contables";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGe_ProcesosaContabilizarMant_FormClosing);
            this.Load += new System.EventHandler(this.FrmGe_ProcesosaContabilizarMant_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisDocumentoTipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoContable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisParamContTipoContabilizacionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParamConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDocu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_guardarysalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.GridLookUpEdit cmbTipoContable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tbsisDocumentoTipoInfoBindingSource;
        private System.Windows.Forms.BindingSource tbsisParamContTipoContabilizacionInfoBindingSource;
        private DevExpress.XtraEditors.TextEdit txtParamConta;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_Conta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_Conta1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_Conta2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoDocu;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colcodDocumentoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion3;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colPosicion;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}