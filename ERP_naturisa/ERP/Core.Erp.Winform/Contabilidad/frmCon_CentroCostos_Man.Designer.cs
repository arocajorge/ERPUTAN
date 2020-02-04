namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_CentroCostos_Man
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblCuentaContable = new System.Windows.Forms.Label();
            this.cmb_ctaCble = new Core.Erp.Winform.Controles.UCCon_Plan_de_Cuenta_x_Movimiento();
            this.chk_es_cta_movi = new System.Windows.Forms.CheckBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.cmb_nivel = new System.Windows.Forms.ComboBox();
            this.lblnivel = new System.Windows.Forms.Label();
            this.txt_codigo_alterno = new System.Windows.Forms.TextBox();
            this.lblCodigoAlterno = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmb_centro_costo_padre = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.slupVwCentroCostoPadre = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCostoPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costoPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblCuentaPadre = new System.Windows.Forms.Label();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo_padre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slupVwCentroCostoPadre)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblCuentaContable);
            this.panelMain.Controls.Add(this.cmb_ctaCble);
            this.panelMain.Controls.Add(this.chk_es_cta_movi);
            this.panelMain.Controls.Add(this.lblAnulado);
            this.panelMain.Controls.Add(this.chk_estado);
            this.panelMain.Controls.Add(this.cmb_nivel);
            this.panelMain.Controls.Add(this.lblnivel);
            this.panelMain.Controls.Add(this.txt_codigo_alterno);
            this.panelMain.Controls.Add(this.lblCodigoAlterno);
            this.panelMain.Controls.Add(this.txt_nombre);
            this.panelMain.Controls.Add(this.lblNombre);
            this.panelMain.Controls.Add(this.txt_codigo);
            this.panelMain.Controls.Add(this.lblCodigo);
            this.panelMain.Controls.Add(this.cmb_centro_costo_padre);
            this.panelMain.Controls.Add(this.lblCuentaPadre);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(649, 229);
            this.panelMain.TabIndex = 1;
            // 
            // lblCuentaContable
            // 
            this.lblCuentaContable.AutoSize = true;
            this.lblCuentaContable.Location = new System.Drawing.Point(74, 190);
            this.lblCuentaContable.Name = "lblCuentaContable";
            this.lblCuentaContable.Size = new System.Drawing.Size(89, 13);
            this.lblCuentaContable.TabIndex = 27;
            this.lblCuentaContable.Text = "Cuenta Contable:";
            // 
            // cmb_ctaCble
            // 
            this.cmb_ctaCble.Location = new System.Drawing.Point(179, 183);
            this.cmb_ctaCble.Name = "cmb_ctaCble";
            this.cmb_ctaCble.Size = new System.Drawing.Size(405, 29);
            this.cmb_ctaCble.TabIndex = 26;
            // 
            // chk_es_cta_movi
            // 
            this.chk_es_cta_movi.AutoSize = true;
            this.chk_es_cta_movi.Location = new System.Drawing.Point(107, 116);
            this.chk_es_cta_movi.Name = "chk_es_cta_movi";
            this.chk_es_cta_movi.Size = new System.Drawing.Size(170, 17);
            this.chk_es_cta_movi.TabIndex = 4;
            this.chk_es_cta_movi.Text = "Es Una Cuenta de Movimiento";
            this.chk_es_cta_movi.UseVisualStyleBackColor = true;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(226, 9);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(157, 20);
            this.lblAnulado.TabIndex = 25;
            this.lblAnulado.Text = "*****ANULADO****";
            this.lblAnulado.Visible = false;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(107, 139);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(56, 17);
            this.chk_estado.TabIndex = 6;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nivel.Enabled = false;
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.Location = new System.Drawing.Point(465, 109);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.Size = new System.Drawing.Size(119, 21);
            this.cmb_nivel.TabIndex = 5;
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.Location = new System.Drawing.Point(418, 117);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(34, 13);
            this.lblnivel.TabIndex = 22;
            this.lblnivel.Text = "Nivel:";
            // 
            // txt_codigo_alterno
            // 
            this.txt_codigo_alterno.Location = new System.Drawing.Point(434, 56);
            this.txt_codigo_alterno.Name = "txt_codigo_alterno";
            this.txt_codigo_alterno.Size = new System.Drawing.Size(150, 20);
            this.txt_codigo_alterno.TabIndex = 3;
            // 
            // lblCodigoAlterno
            // 
            this.lblCodigoAlterno.AutoSize = true;
            this.lblCodigoAlterno.Location = new System.Drawing.Point(349, 59);
            this.lblCodigoAlterno.Name = "lblCodigoAlterno";
            this.lblCodigoAlterno.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoAlterno.TabIndex = 6;
            this.lblCodigoAlterno.Text = "Codigo Alterno:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(107, 82);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(477, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(107, 56);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(152, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // cmb_centro_costo_padre
            // 
            this.cmb_centro_costo_padre.Location = new System.Drawing.Point(107, 32);
            this.cmb_centro_costo_padre.Name = "cmb_centro_costo_padre";
            this.cmb_centro_costo_padre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_centro_costo_padre.Properties.DisplayMember = "Centro_costo2";
            this.cmb_centro_costo_padre.Properties.ValueMember = "IdCentroCosto";
            this.cmb_centro_costo_padre.Properties.View = this.slupVwCentroCostoPadre;
            this.cmb_centro_costo_padre.Size = new System.Drawing.Size(477, 20);
            this.cmb_centro_costo_padre.TabIndex = 0;
            // 
            // slupVwCentroCostoPadre
            // 
            this.slupVwCentroCostoPadre.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto,
            this.colCentro_costo,
            this.colIdCentroCostoPadre,
            this.colCentro_costoPadre,
            this.colIdNivel});
            this.slupVwCentroCostoPadre.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.slupVwCentroCostoPadre.Name = "slupVwCentroCostoPadre";
            this.slupVwCentroCostoPadre.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.slupVwCentroCostoPadre.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "IdCentroCosto";
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 0;
            this.colIdCentroCosto.Width = 180;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Centro_costo";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 1;
            this.colCentro_costo.Width = 491;
            // 
            // colIdCentroCostoPadre
            // 
            this.colIdCentroCostoPadre.Caption = "IdCentroCostoPadre";
            this.colIdCentroCostoPadre.FieldName = "IdCentroCostoPadre";
            this.colIdCentroCostoPadre.Name = "colIdCentroCostoPadre";
            this.colIdCentroCostoPadre.Width = 119;
            // 
            // colCentro_costoPadre
            // 
            this.colCentro_costoPadre.Caption = "Centro_costoPadre";
            this.colCentro_costoPadre.FieldName = "Centro_costoPadre";
            this.colCentro_costoPadre.Name = "colCentro_costoPadre";
            this.colCentro_costoPadre.Visible = true;
            this.colCentro_costoPadre.VisibleIndex = 3;
            this.colCentro_costoPadre.Width = 411;
            // 
            // colIdNivel
            // 
            this.colIdNivel.Caption = "Nivel";
            this.colIdNivel.FieldName = "IdNivel";
            this.colIdNivel.Name = "colIdNivel";
            this.colIdNivel.Visible = true;
            this.colIdNivel.VisibleIndex = 2;
            this.colIdNivel.Width = 98;
            // 
            // lblCuentaPadre
            // 
            this.lblCuentaPadre.AutoSize = true;
            this.lblCuentaPadre.Location = new System.Drawing.Point(12, 35);
            this.lblCuentaPadre.Name = "lblCuentaPadre";
            this.lblCuentaPadre.Size = new System.Drawing.Size(75, 13);
            this.lblCuentaPadre.TabIndex = 0;
            this.lblCuentaPadre.Text = "Cuenta Padre:";
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 258);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(649, 26);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(649, 29);
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
            // 
            // frmCon_CentroCostos_Man
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 284);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCon_CentroCostos_Man";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Costo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_CentroCostos_Man_FormClosing);
            this.Load += new System.EventHandler(this.frmCon_CentroCostos_Man_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo_padre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slupVwCentroCostoPadre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txt_codigo_alterno;
        private System.Windows.Forms.Label lblCodigoAlterno;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lblCodigo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_centro_costo_padre;
        private DevExpress.XtraGrid.Views.Grid.GridView slupVwCentroCostoPadre;
        private System.Windows.Forms.Label lblCuentaPadre;
        private System.Windows.Forms.ComboBox cmb_nivel;
        private System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.CheckBox chk_es_cta_movi;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCostoPadre;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costoPadre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNivel;
        private System.Windows.Forms.Label lblCuentaContable;
        private Controles.UCCon_Plan_de_Cuenta_x_Movimiento cmb_ctaCble;

    }
}