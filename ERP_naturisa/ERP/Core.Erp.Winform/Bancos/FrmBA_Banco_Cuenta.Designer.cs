namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Banco_Cuenta
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControl_Banco = new DevExpress.XtraGrid.GridControl();
            this.baBancoCuentaInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView_Banco = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Num_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Moneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Ultimo_Cheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_num_digito_cheq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Banco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panel1.Controls.Add(this.gridControl_Banco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 309);
            this.panel1.TabIndex = 2;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 283);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(912, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gridControl_Banco
            // 
            this.gridControl_Banco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_Banco.DataSource = this.baBancoCuentaInfoBindingSource;
            this.gridControl_Banco.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Banco.MainView = this.gridView_Banco;
            this.gridControl_Banco.Name = "gridControl_Banco";
            this.gridControl_Banco.Size = new System.Drawing.Size(912, 287);
            this.gridControl_Banco.TabIndex = 0;
            this.gridControl_Banco.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Banco});
            // 
            // baBancoCuentaInfoBindingSource
            // 
            this.baBancoCuentaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Banco_Cuenta_Info);
            // 
            // gridView_Banco
            // 
            this.gridView_Banco.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdBanco,
            this.colba_descripcion,
            this.colba_Tipo,
            this.colba_Num_Cuenta,
            this.colba_Moneda,
            this.colba_Ultimo_Cheque,
            this.colba_num_digito_cheq,
            this.colIdCtaCble,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colnom_pc,
            this.colip,
            this.colestado});
            this.gridView_Banco.GridControl = this.gridControl_Banco;
            this.gridView_Banco.Name = "gridView_Banco";
            this.gridView_Banco.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Banco.OptionsView.ShowGroupPanel = false;
            this.gridView_Banco.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_Banco_RowCellStyle);
            this.gridView_Banco.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Banco_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colIdBanco
            // 
            this.colIdBanco.Caption = "Id";
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.OptionsColumn.AllowEdit = false;
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 0;
            this.colIdBanco.Width = 50;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "Banco";
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.OptionsColumn.AllowEdit = false;
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 1;
            this.colba_descripcion.Width = 245;
            // 
            // colba_Tipo
            // 
            this.colba_Tipo.Caption = "Tipo";
            this.colba_Tipo.FieldName = "ba_Tipo";
            this.colba_Tipo.Name = "colba_Tipo";
            this.colba_Tipo.OptionsColumn.AllowEdit = false;
            this.colba_Tipo.Visible = true;
            this.colba_Tipo.VisibleIndex = 2;
            this.colba_Tipo.Width = 79;
            // 
            // colba_Num_Cuenta
            // 
            this.colba_Num_Cuenta.Caption = "# Cta.";
            this.colba_Num_Cuenta.FieldName = "ba_Num_Cuenta";
            this.colba_Num_Cuenta.Name = "colba_Num_Cuenta";
            this.colba_Num_Cuenta.OptionsColumn.AllowEdit = false;
            this.colba_Num_Cuenta.Visible = true;
            this.colba_Num_Cuenta.VisibleIndex = 3;
            this.colba_Num_Cuenta.Width = 94;
            // 
            // colba_Moneda
            // 
            this.colba_Moneda.Caption = "Moneda";
            this.colba_Moneda.FieldName = "ba_Moneda";
            this.colba_Moneda.Name = "colba_Moneda";
            this.colba_Moneda.OptionsColumn.AllowEdit = false;
            this.colba_Moneda.Visible = true;
            this.colba_Moneda.VisibleIndex = 4;
            this.colba_Moneda.Width = 91;
            // 
            // colba_Ultimo_Cheque
            // 
            this.colba_Ultimo_Cheque.Caption = "Ult. Cheque";
            this.colba_Ultimo_Cheque.FieldName = "ba_Ultimo_Cheque";
            this.colba_Ultimo_Cheque.Name = "colba_Ultimo_Cheque";
            this.colba_Ultimo_Cheque.OptionsColumn.AllowEdit = false;
            this.colba_Ultimo_Cheque.Visible = true;
            this.colba_Ultimo_Cheque.VisibleIndex = 5;
            this.colba_Ultimo_Cheque.Width = 99;
            // 
            // colba_num_digito_cheq
            // 
            this.colba_num_digito_cheq.Caption = "# Dig. Cheque";
            this.colba_num_digito_cheq.FieldName = "ba_num_digito_cheq";
            this.colba_num_digito_cheq.Name = "colba_num_digito_cheq";
            this.colba_num_digito_cheq.OptionsColumn.AllowEdit = false;
            this.colba_num_digito_cheq.Visible = true;
            this.colba_num_digito_cheq.VisibleIndex = 6;
            this.colba_num_digito_cheq.Width = 86;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "#Cta. Cble.";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.OptionsColumn.AllowEdit = false;
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 7;
            this.colIdCtaCble.Width = 91;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.OptionsColumn.AllowEdit = false;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.OptionsColumn.AllowEdit = false;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            this.colIdUsuarioUltMod.OptionsColumn.AllowEdit = false;
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            this.colFecha_UltMod.OptionsColumn.AllowEdit = false;
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            this.colnom_pc.OptionsColumn.AllowEdit = false;
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            this.colip.OptionsColumn.AllowEdit = false;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 8;
            this.colestado.Width = 59;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 4, 21, 10, 35, 59, 37);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 6, 21, 10, 35, 59, 38);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(912, 93);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 3;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_BtnDisChqCbte_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_BtnDisChqCbte_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_BtnDisChqCbte_Click);
            // 
            // FrmBA_Banco_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "FrmBA_Banco_Cuenta";
            this.Text = "Cuenta Bancaria Consulta";
            this.Load += new System.EventHandler(this.FrmBA_Banco_Cuenta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Banco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;

        
        
        private DevExpress.XtraGrid.GridControl gridControl_Banco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Banco;
        private System.Windows.Forms.BindingSource baBancoCuentaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Num_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Moneda;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Ultimo_Cheque;
        private DevExpress.XtraGrid.Columns.GridColumn colba_num_digito_cheq;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;

    }
}