namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_Operador_Mantenimiento
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
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.txtNombre_operador = new System.Windows.Forms.TextBox();
            this.lbnombreOperador = new System.Windows.Forms.Label();
            this.cmbEmpleados = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNomCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.txtIdOperador = new System.Windows.Forms.TextBox();
            this.lbIdOperador = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.errorPValidaObjetos = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpleados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPValidaObjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkEstado);
            this.panel1.Controls.Add(this.txtNombre_operador);
            this.panel1.Controls.Add(this.lbnombreOperador);
            this.panel1.Controls.Add(this.cmbEmpleados);
            this.panel1.Controls.Add(this.lbEmpleado);
            this.panel1.Controls.Add(this.txtIdOperador);
            this.panel1.Controls.Add(this.lbIdOperador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 92);
            this.panel1.TabIndex = 1;
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(304, 6);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(56, 17);
            this.checkEstado.TabIndex = 6;
            this.checkEstado.Text = "Activo";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // txtNombre_operador
            // 
            this.txtNombre_operador.Location = new System.Drawing.Point(133, 55);
            this.txtNombre_operador.Name = "txtNombre_operador";
            this.txtNombre_operador.Size = new System.Drawing.Size(312, 20);
            this.txtNombre_operador.TabIndex = 5;
            // 
            // lbnombreOperador
            // 
            this.lbnombreOperador.AutoSize = true;
            this.lbnombreOperador.Location = new System.Drawing.Point(12, 58);
            this.lbnombreOperador.Name = "lbnombreOperador";
            this.lbnombreOperador.Size = new System.Drawing.Size(89, 13);
            this.lbnombreOperador.TabIndex = 4;
            this.lbnombreOperador.Text = "Nombre operador";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.Location = new System.Drawing.Point(133, 29);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmpleados.Properties.DisplayMember = "NomCompleto";
            this.cmbEmpleados.Properties.ValueMember = "IdEmpleado";
            this.cmbEmpleados.Properties.View = this.searchLookUpEdit1View;
            this.cmbEmpleados.Size = new System.Drawing.Size(312, 20);
            this.cmbEmpleados.TabIndex = 3;
            this.cmbEmpleados.EditValueChanged += new System.EventHandler(this.cmbEmpleados_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdEmpleado,
            this.ColNomCompleto});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdEmpleado
            // 
            this.ColIdEmpleado.Caption = "Id Empleado";
            this.ColIdEmpleado.FieldName = "IdEmpleado";
            this.ColIdEmpleado.Name = "ColIdEmpleado";
            this.ColIdEmpleado.Visible = true;
            this.ColIdEmpleado.VisibleIndex = 0;
            // 
            // ColNomCompleto
            // 
            this.ColNomCompleto.Caption = "Nombre";
            this.ColNomCompleto.FieldName = "NomCompleto";
            this.ColNomCompleto.Name = "ColNomCompleto";
            this.ColNomCompleto.Visible = true;
            this.ColNomCompleto.VisibleIndex = 1;
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Location = new System.Drawing.Point(12, 30);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(71, 13);
            this.lbEmpleado.TabIndex = 2;
            this.lbEmpleado.Text = "Id Empleados";
            // 
            // txtIdOperador
            // 
            this.txtIdOperador.Location = new System.Drawing.Point(133, 3);
            this.txtIdOperador.Name = "txtIdOperador";
            this.txtIdOperador.Size = new System.Drawing.Size(165, 20);
            this.txtIdOperador.TabIndex = 1;
            // 
            // lbIdOperador
            // 
            this.lbIdOperador.AutoSize = true;
            this.lbIdOperador.Location = new System.Drawing.Point(12, 6);
            this.lbIdOperador.Name = "lbIdOperador";
            this.lbIdOperador.Size = new System.Drawing.Size(60, 13);
            this.lbIdOperador.TabIndex = 0;
            this.lbIdOperador.Text = "IdOperador";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(532, 29);
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // errorPValidaObjetos
            // 
            this.errorPValidaObjetos.ContainerControl = this;
            // 
            // FrmPrd_Operador_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 121);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmPrd_Operador_Mantenimiento";
            this.Text = "FrmPrd_Operador_Mantenimiento";
            this.Load += new System.EventHandler(this.FrmPrd_Operador_Mantenimiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpleados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPValidaObjetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdOperador;
        private System.Windows.Forms.Label lbIdOperador;
        private System.Windows.Forms.TextBox txtNombre_operador;
        private System.Windows.Forms.Label lbnombreOperador;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label lbEmpleado;
        private System.Windows.Forms.CheckBox checkEstado;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn ColNomCompleto;
        private System.Windows.Forms.ErrorProvider errorPValidaObjetos;

    }
}