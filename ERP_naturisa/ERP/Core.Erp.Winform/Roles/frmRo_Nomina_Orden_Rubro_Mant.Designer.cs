namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Nomina_Orden_Rubro_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridListado = new DevExpress.XtraGrid.GridControl();
            this.viewListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ronominatipoliquiordenInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNominaTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNominaTipoLiqui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioIngresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ronominatipoliquiordenInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(847, 29);
            this.ucGe_Menu.TabIndex = 6;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridListado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 423);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // gridListado
            // 
            this.gridListado.DataSource = this.ronominatipoliquiordenInfoBindingSource;
            this.gridListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListado.Location = new System.Drawing.Point(3, 16);
            this.gridListado.MainView = this.viewListado;
            this.gridListado.Name = "gridListado";
            this.gridListado.Size = new System.Drawing.Size(841, 404);
            this.gridListado.TabIndex = 0;
            this.gridListado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewListado});
            // 
            // viewListado
            // 
            this.viewListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdNominaTipo,
            this.colIdNominaTipoLiqui,
            this.colOrden,
            this.colIdRubro,
            this.colDescripcion,
            this.colFechaIngresa,
            this.colUsuarioIngresa,
            this.colFechaModifica,
            this.colUsuarioModifica});
            this.viewListado.GridControl = this.gridListado;
            this.viewListado.Name = "viewListado";
            // 
            // ronominatipoliquiordenInfoBindingSource
            // 
            this.ronominatipoliquiordenInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_nomina_tipo_liqui_orden_Info);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 0;
            // 
            // colIdNominaTipo
            // 
            this.colIdNominaTipo.FieldName = "IdNominaTipo";
            this.colIdNominaTipo.Name = "colIdNominaTipo";
            this.colIdNominaTipo.Visible = true;
            this.colIdNominaTipo.VisibleIndex = 1;
            // 
            // colIdNominaTipoLiqui
            // 
            this.colIdNominaTipoLiqui.FieldName = "IdNominaTipoLiqui";
            this.colIdNominaTipoLiqui.Name = "colIdNominaTipoLiqui";
            this.colIdNominaTipoLiqui.Visible = true;
            this.colIdNominaTipoLiqui.VisibleIndex = 2;
            // 
            // colOrden
            // 
            this.colOrden.FieldName = "Orden";
            this.colOrden.Name = "colOrden";
            this.colOrden.Visible = true;
            this.colOrden.VisibleIndex = 3;
            // 
            // colIdRubro
            // 
            this.colIdRubro.FieldName = "IdRubro";
            this.colIdRubro.Name = "colIdRubro";
            this.colIdRubro.Visible = true;
            this.colIdRubro.VisibleIndex = 4;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 5;
            // 
            // colFechaIngresa
            // 
            this.colFechaIngresa.FieldName = "FechaIngresa";
            this.colFechaIngresa.Name = "colFechaIngresa";
            this.colFechaIngresa.Visible = true;
            this.colFechaIngresa.VisibleIndex = 6;
            // 
            // colUsuarioIngresa
            // 
            this.colUsuarioIngresa.FieldName = "UsuarioIngresa";
            this.colUsuarioIngresa.Name = "colUsuarioIngresa";
            this.colUsuarioIngresa.Visible = true;
            this.colUsuarioIngresa.VisibleIndex = 7;
            // 
            // colFechaModifica
            // 
            this.colFechaModifica.FieldName = "FechaModifica";
            this.colFechaModifica.Name = "colFechaModifica";
            this.colFechaModifica.Visible = true;
            this.colFechaModifica.VisibleIndex = 8;
            // 
            // colUsuarioModifica
            // 
            this.colUsuarioModifica.FieldName = "UsuarioModifica";
            this.colUsuarioModifica.Name = "colUsuarioModifica";
            this.colUsuarioModifica.Visible = true;
            this.colUsuarioModifica.VisibleIndex = 9;
            // 
            // frmRo_Nomina_Orden_Rubro_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Nomina_Orden_Rubro_Mant";
            this.Text = "Mantenimiento - Orden de Rubros por Nómina";
            this.Load += new System.EventHandler(this.frmRo_Nomina_Orden_Rubro_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ronominatipoliquiordenInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridListado;
        private DevExpress.XtraGrid.Views.Grid.GridView viewListado;
        private System.Windows.Forms.BindingSource ronominatipoliquiordenInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNominaTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNominaTipoLiqui;
        private DevExpress.XtraGrid.Columns.GridColumn colOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngresa;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioIngresa;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModifica;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModifica;

    }
}