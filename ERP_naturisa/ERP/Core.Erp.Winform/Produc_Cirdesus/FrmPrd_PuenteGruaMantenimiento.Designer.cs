namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_PuenteGruaMantenimiento
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
            this.panelMante = new System.Windows.Forms.Panel();
            this.cmbOperador = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttoneladasSoporta = new System.Windows.Forms.TextBox();
            this.lbtoneladas = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.Lbmarca = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtIregistro = new System.Windows.Forms.TextBox();
            this.lbIdRegistro = new System.Windows.Forms.Label();
            this.errorPValidaObjetos = new System.Windows.Forms.ErrorProvider(this.components);
            this.ColIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNomEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Sucursal_combo1 = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panelMante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPValidaObjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMante
            // 
            this.panelMante.Controls.Add(this.cmbOperador);
            this.panelMante.Controls.Add(this.label3);
            this.panelMante.Controls.Add(this.ucGe_Sucursal_combo1);
            this.panelMante.Controls.Add(this.checkEstado);
            this.panelMante.Controls.Add(this.label2);
            this.panelMante.Controls.Add(this.txttoneladasSoporta);
            this.panelMante.Controls.Add(this.lbtoneladas);
            this.panelMante.Controls.Add(this.txtmarca);
            this.panelMante.Controls.Add(this.Lbmarca);
            this.panelMante.Controls.Add(this.txtnombre);
            this.panelMante.Controls.Add(this.labelNombre);
            this.panelMante.Controls.Add(this.txtIregistro);
            this.panelMante.Controls.Add(this.lbIdRegistro);
            this.panelMante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMante.Location = new System.Drawing.Point(0, 29);
            this.panelMante.Name = "panelMante";
            this.panelMante.Size = new System.Drawing.Size(566, 140);
            this.panelMante.TabIndex = 1;
            // 
            // cmbOperador
            // 
            this.cmbOperador.EditValue = "";
            this.cmbOperador.Location = new System.Drawing.Point(112, 29);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOperador.Properties.DisplayMember = "NomEmpleado";
            this.cmbOperador.Properties.ValueMember = "IdOperador";
            this.cmbOperador.Properties.View = this.gridView1;
            this.cmbOperador.Size = new System.Drawing.Size(436, 20);
            this.cmbOperador.TabIndex = 125;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdOperador,
            this.ColNomEmpleado});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Operador";
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(432, 57);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(59, 17);
            this.checkEstado.TabIndex = 12;
            this.checkEstado.Text = "Estado";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sucursal";
            // 
            // txttoneladasSoporta
            // 
            this.txttoneladasSoporta.Location = new System.Drawing.Point(298, 55);
            this.txttoneladasSoporta.Name = "txttoneladasSoporta";
            this.txttoneladasSoporta.Size = new System.Drawing.Size(114, 20);
            this.txttoneladasSoporta.TabIndex = 7;
            this.txttoneladasSoporta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttoneladasSoporta_KeyPress);
            // 
            // lbtoneladas
            // 
            this.lbtoneladas.AutoSize = true;
            this.lbtoneladas.Location = new System.Drawing.Point(204, 58);
            this.lbtoneladas.Name = "lbtoneladas";
            this.lbtoneladas.Size = new System.Drawing.Size(97, 13);
            this.lbtoneladas.TabIndex = 6;
            this.lbtoneladas.Text = "Toneladas Soporta";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(112, 110);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(435, 20);
            this.txtmarca.TabIndex = 5;
            // 
            // Lbmarca
            // 
            this.Lbmarca.AutoSize = true;
            this.Lbmarca.Location = new System.Drawing.Point(5, 110);
            this.Lbmarca.Name = "Lbmarca";
            this.Lbmarca.Size = new System.Drawing.Size(37, 13);
            this.Lbmarca.TabIndex = 4;
            this.Lbmarca.Text = "Marca";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(112, 84);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(435, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(5, 84);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(107, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre Puente Grua";
            // 
            // txtIregistro
            // 
            this.txtIregistro.Location = new System.Drawing.Point(112, 55);
            this.txtIregistro.Name = "txtIregistro";
            this.txtIregistro.Size = new System.Drawing.Size(86, 20);
            this.txtIregistro.TabIndex = 1;
            // 
            // lbIdRegistro
            // 
            this.lbIdRegistro.AutoSize = true;
            this.lbIdRegistro.Location = new System.Drawing.Point(5, 58);
            this.lbIdRegistro.Name = "lbIdRegistro";
            this.lbIdRegistro.Size = new System.Drawing.Size(58, 13);
            this.lbIdRegistro.TabIndex = 0;
            this.lbIdRegistro.Text = "Id Registro";
            // 
            // errorPValidaObjetos
            // 
            this.errorPValidaObjetos.ContainerControl = this;
            // 
            // ColIdOperador
            // 
            this.ColIdOperador.Caption = "Id Operador";
            this.ColIdOperador.FieldName = "IdOperador";
            this.ColIdOperador.Name = "ColIdOperador";
            this.ColIdOperador.Visible = true;
            this.ColIdOperador.VisibleIndex = 0;
            // 
            // ColNomEmpleado
            // 
            this.ColNomEmpleado.Caption = "Operador";
            this.ColNomEmpleado.FieldName = "NomEmpleado";
            this.ColNomEmpleado.Name = "ColNomEmpleado";
            this.ColNomEmpleado.Visible = true;
            this.ColNomEmpleado.VisibleIndex = 1;
            // 
            // ucGe_Sucursal_combo1
            // 
            this.ucGe_Sucursal_combo1.Location = new System.Drawing.Point(113, 5);
            this.ucGe_Sucursal_combo1.Name = "ucGe_Sucursal_combo1";
            this.ucGe_Sucursal_combo1.Size = new System.Drawing.Size(435, 22);
            this.ucGe_Sucursal_combo1.TabIndex = 13;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(566, 29);
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
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // FrmPrd_PuenteGruaMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 169);
            this.Controls.Add(this.panelMante);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmPrd_PuenteGruaMantenimiento";
            this.Text = "FrmPrd_PuenteGruaMantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrd_PuenteGruaMantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrd_PuenteGruaMantenimiento_Load);
            this.panelMante.ResumeLayout(false);
            this.panelMante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPValidaObjetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panelMante;
        private System.Windows.Forms.TextBox txtIregistro;
        private System.Windows.Forms.Label lbIdRegistro;
        private System.Windows.Forms.TextBox txttoneladasSoporta;
        private System.Windows.Forms.Label lbtoneladas;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label Lbmarca;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.ErrorProvider errorPValidaObjetos;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal_combo1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbOperador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn ColNomEmpleado;
    }
}