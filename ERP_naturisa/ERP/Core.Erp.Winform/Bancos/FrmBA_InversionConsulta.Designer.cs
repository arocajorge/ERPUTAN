namespace Core.Erp.Winform.Bancos

{
    partial class FrmBA_InversionConsulta
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
            this.gridControlCons = new DevExpress.XtraGrid.GridControl();
            this.baInversionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCons = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCod_Inversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdInversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPor_Retencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTasa_interes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_recibir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor_interes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor_retencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbBanco = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.baBancoCuentaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baInversionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlCons
            // 
            this.gridControlCons.DataSource = this.baInversionInfoBindingSource;
            this.gridControlCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCons.Location = new System.Drawing.Point(0, 0);
            this.gridControlCons.MainView = this.gridViewCons;
            this.gridControlCons.Name = "gridControlCons";
            this.gridControlCons.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbBanco});
            this.gridControlCons.Size = new System.Drawing.Size(699, 238);
            this.gridControlCons.TabIndex = 10;
            this.gridControlCons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCons});
            // 
            // baInversionInfoBindingSource
            // 
            this.baInversionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Inversion_Info);
            // 
            // gridViewCons
            // 
            this.gridViewCons.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCapital,
            this.colCod_Inversion,
            this.colEstado,
            this.colFecha,
            this.colIdBanco,
            this.colIdEmpresa,
            this.colIdInversion,
            this.colIdUsuario,
            this.colMonto,
            this.colObservacion,
            this.colOtros,
            this.colPlazo,
            this.colPor_Retencion,
            this.colTasa,
            this.colTasa_interes,
            this.colTotal_recibir,
            this.colValor_interes,
            this.colValor_retencion,
            this.colNomBanco});
            this.gridViewCons.GridControl = this.gridControlCons;
            this.gridViewCons.Name = "gridViewCons";
            this.gridViewCons.OptionsBehavior.ReadOnly = true;
            this.gridViewCons.OptionsFind.AlwaysVisible = true;
            this.gridViewCons.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCons.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTasa_interes, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewCons.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCons_RowCellStyle);
            // 
            // colCapital
            // 
            this.colCapital.FieldName = "Capital";
            this.colCapital.Name = "colCapital";
            // 
            // colCod_Inversion
            // 
            this.colCod_Inversion.Caption = "Código";
            this.colCod_Inversion.FieldName = "Cod_Inversion";
            this.colCod_Inversion.Name = "colCod_Inversion";
            this.colCod_Inversion.Visible = true;
            this.colCod_Inversion.VisibleIndex = 2;
            this.colCod_Inversion.Width = 47;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 12;
            this.colEstado.Width = 49;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            this.colFecha.Width = 47;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Width = 69;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 69;
            // 
            // colIdInversion
            // 
            this.colIdInversion.Caption = "ID";
            this.colIdInversion.FieldName = "IdInversion";
            this.colIdInversion.Name = "colIdInversion";
            this.colIdInversion.Visible = true;
            this.colIdInversion.VisibleIndex = 3;
            this.colIdInversion.Width = 24;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Width = 69;
            // 
            // colMonto
            // 
            this.colMonto.Caption = "Monto";
            this.colMonto.FieldName = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.Visible = true;
            this.colMonto.VisibleIndex = 4;
            this.colMonto.Width = 50;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 11;
            this.colObservacion.Width = 50;
            // 
            // colOtros
            // 
            this.colOtros.FieldName = "Otros";
            this.colOtros.Name = "colOtros";
            this.colOtros.Width = 69;
            // 
            // colPlazo
            // 
            this.colPlazo.FieldName = "Plazo";
            this.colPlazo.Name = "colPlazo";
            this.colPlazo.Visible = true;
            this.colPlazo.VisibleIndex = 5;
            this.colPlazo.Width = 50;
            // 
            // colPor_Retencion
            // 
            this.colPor_Retencion.Caption = "% Ret";
            this.colPor_Retencion.FieldName = "Por_Retencion";
            this.colPor_Retencion.Name = "colPor_Retencion";
            this.colPor_Retencion.Visible = true;
            this.colPor_Retencion.VisibleIndex = 6;
            this.colPor_Retencion.Width = 50;
            // 
            // colTasa
            // 
            this.colTasa.FieldName = "Tasa";
            this.colTasa.Name = "colTasa";
            this.colTasa.Visible = true;
            this.colTasa.VisibleIndex = 8;
            this.colTasa.Width = 50;
            // 
            // colTasa_interes
            // 
            this.colTasa_interes.FieldName = "Tasa_interes";
            this.colTasa_interes.Name = "colTasa_interes";
            this.colTasa_interes.Width = 69;
            // 
            // colTotal_recibir
            // 
            this.colTotal_recibir.Caption = "Total";
            this.colTotal_recibir.FieldName = "Total_recibir";
            this.colTotal_recibir.Name = "colTotal_recibir";
            this.colTotal_recibir.Visible = true;
            this.colTotal_recibir.VisibleIndex = 10;
            this.colTotal_recibir.Width = 50;
            // 
            // colValor_interes
            // 
            this.colValor_interes.Caption = "Interés";
            this.colValor_interes.FieldName = "Valor_interes";
            this.colValor_interes.Name = "colValor_interes";
            this.colValor_interes.Visible = true;
            this.colValor_interes.VisibleIndex = 9;
            this.colValor_interes.Width = 50;
            // 
            // colValor_retencion
            // 
            this.colValor_retencion.Caption = "Retención";
            this.colValor_retencion.FieldName = "Valor_retencion";
            this.colValor_retencion.Name = "colValor_retencion";
            this.colValor_retencion.Visible = true;
            this.colValor_retencion.VisibleIndex = 7;
            this.colValor_retencion.Width = 69;
            // 
            // colNomBanco
            // 
            this.colNomBanco.Caption = "Banco";
            this.colNomBanco.FieldName = "NomBanco";
            this.colNomBanco.Name = "colNomBanco";
            this.colNomBanco.Visible = true;
            this.colNomBanco.VisibleIndex = 0;
            this.colNomBanco.Width = 95;
            // 
            // cmbBanco
            // 
            this.cmbBanco.AutoHeight = false;
            this.cmbBanco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBanco.DataSource = this.baBancoCuentaInfoBindingSource;
            this.cmbBanco.DisplayMember = "ba_descripcion";
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.ValueMember = "IdBanco";
            this.cmbBanco.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // baBancoCuentaInfoBindingSource
            // 
            this.baBancoCuentaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Banco_Cuenta_Info);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 95);
            this.panel1.TabIndex = 12;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 25, 17, 26, 34, 999);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 25, 17, 26, 34, 999);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(699, 95);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlCons);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 238);
            this.panel2.TabIndex = 13;
            // 
            // FrmBA_InversionConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 355);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmBA_InversionConsulta";
            this.Text = "Inversión Consulta";
            this.Load += new System.EventHandler(this.FrmBA_InversionConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baInversionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCons;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCons;
        private System.Windows.Forms.BindingSource baInversionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCapital;
        private DevExpress.XtraGrid.Columns.GridColumn colCod_Inversion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInversion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colOtros;
        private DevExpress.XtraGrid.Columns.GridColumn colPlazo;
        private DevExpress.XtraGrid.Columns.GridColumn colPor_Retencion;
        private DevExpress.XtraGrid.Columns.GridColumn colTasa;
        private DevExpress.XtraGrid.Columns.GridColumn colTasa_interes;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_recibir;
        private DevExpress.XtraGrid.Columns.GridColumn colValor_interes;
        private DevExpress.XtraGrid.Columns.GridColumn colValor_retencion;
        private DevExpress.XtraGrid.Columns.GridColumn colNomBanco;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmbBanco;
        private System.Windows.Forms.BindingSource baBancoCuentaInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
    }
}