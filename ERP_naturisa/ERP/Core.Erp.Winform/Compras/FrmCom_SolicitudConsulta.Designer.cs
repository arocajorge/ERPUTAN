namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_SolicitudConsulta
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
            this.cmbSucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tbSucursalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlConsulta = new DevExpress.XtraGrid.GridControl();
            this.comsolicitudcompraInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona_Solicita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona_comprador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vtc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaHoraAnul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSolicitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComprador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comsolicitudcompraInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbSucursal);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaIni);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 92);
            this.panel1.TabIndex = 0;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(331, 12);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSucursal.Properties.DataSource = this.tbSucursalInfoBindingSource;
            this.cmbSucursal.Properties.DisplayMember = "Su_Descripcion";
            this.cmbSucursal.Properties.ValueMember = "IdSucursal";
            this.cmbSucursal.Properties.View = this.searchLookUpEdit1View;
            this.cmbSucursal.Size = new System.Drawing.Size(139, 20);
            this.cmbSucursal.TabIndex = 6;
            // 
            // tbSucursalInfoBindingSource
            // 
            this.tbSucursalInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Sucursal_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSu_Descripcion,
            this.colIdSucursal1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Descripción";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 0;
            this.colSu_Descripcion.Width = 931;
            // 
            // colIdSucursal1
            // 
            this.colIdSucursal1.FieldName = "IdSucursal";
            this.colIdSucursal1.Name = "colIdSucursal1";
            this.colIdSucursal1.Visible = true;
            this.colIdSucursal1.VisibleIndex = 1;
            this.colIdSucursal1.Width = 249;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(332, 64);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaFin.TabIndex = 5;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(331, 38);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaIni.TabIndex = 4;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(476, 39);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 45);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal:";
            // 
            // gridControlConsulta
            // 
            this.gridControlConsulta.DataSource = this.comsolicitudcompraInfoBindingSource;
            this.gridControlConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConsulta.Location = new System.Drawing.Point(0, 92);
            this.gridControlConsulta.MainView = this.gridViewConsulta;
            this.gridControlConsulta.Name = "gridControlConsulta";
            this.gridControlConsulta.Size = new System.Drawing.Size(811, 230);
            this.gridControlConsulta.TabIndex = 7;
            this.gridControlConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // comsolicitudcompraInfoBindingSource
            // 
            this.comsolicitudcompraInfoBindingSource.DataSource = typeof(Core.Erp.Info.Compras.com_solicitud_compra_Info);
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdSolicitudCompra,
            this.colIdProveedor,
            this.colChecked,
            this.colNumDocumento,
            this.colIdPersona_Solicita,
            this.colIdPersona_comprador,
            this.colIdDepartamento,
            this.colfecha,
            this.coldo_Cantidad,
            this.colplazo,
            this.colfecha_vtc,
            this.colIdProducto,
            this.colobservacion,
            this.colEstado,
            this.colFecha_Transac,
            this.colFecha_UltMod,
            this.colNomProducto,
            this.colIdUsuarioUltMod,
            this.colFechaHoraAnul,
            this.colIdUsuarioUltAnu,
            this.colMotivoAnulacion,
            this.colReferencia,
            this.colSucursal,
            this.colSolicitante,
            this.colComprador,
            this.coldepartamento});
            this.gridViewConsulta.GridControl = this.gridControlConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsBehavior.Editable = false;
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewConsulta_RowClick);
            this.gridViewConsulta.DoubleClick += new System.EventHandler(this.gridViewConsulta_DoubleClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colIdSolicitudCompra
            // 
            this.colIdSolicitudCompra.Caption = "IdSolicitud";
            this.colIdSolicitudCompra.FieldName = "IdSolicitudCompra";
            this.colIdSolicitudCompra.Name = "colIdSolicitudCompra";
            this.colIdSolicitudCompra.Visible = true;
            this.colIdSolicitudCompra.VisibleIndex = 0;
            this.colIdSolicitudCompra.Width = 109;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colChecked
            // 
            this.colChecked.Caption = "*";
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.Width = 54;
            // 
            // colNumDocumento
            // 
            this.colNumDocumento.Caption = "# Documento";
            this.colNumDocumento.FieldName = "NumDocumento";
            this.colNumDocumento.Name = "colNumDocumento";
            this.colNumDocumento.Visible = true;
            this.colNumDocumento.VisibleIndex = 1;
            this.colNumDocumento.Width = 157;
            // 
            // colIdPersona_Solicita
            // 
            this.colIdPersona_Solicita.FieldName = "IdPersona_Solicita";
            this.colIdPersona_Solicita.Name = "colIdPersona_Solicita";
            // 
            // colIdPersona_comprador
            // 
            this.colIdPersona_comprador.FieldName = "IdPersona_comprador";
            this.colIdPersona_comprador.Name = "colIdPersona_comprador";
            // 
            // colIdDepartamento
            // 
            this.colIdDepartamento.FieldName = "IdDepartamento";
            this.colIdDepartamento.Name = "colIdDepartamento";
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            this.colfecha.Width = 161;
            // 
            // coldo_Cantidad
            // 
            this.coldo_Cantidad.Caption = "Cantidad";
            this.coldo_Cantidad.FieldName = "do_Cantidad";
            this.coldo_Cantidad.Name = "coldo_Cantidad";
            this.coldo_Cantidad.Width = 440;
            // 
            // colplazo
            // 
            this.colplazo.FieldName = "plazo";
            this.colplazo.Name = "colplazo";
            // 
            // colfecha_vtc
            // 
            this.colfecha_vtc.FieldName = "fecha_vtc";
            this.colfecha_vtc.Name = "colfecha_vtc";
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Width = 152;
            // 
            // colobservacion
            // 
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            // 
            // colNomProducto
            // 
            this.colNomProducto.Caption = "Producto";
            this.colNomProducto.FieldName = "NomProducto";
            this.colNomProducto.Name = "colNomProducto";
            this.colNomProducto.Width = 534;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            // 
            // colFechaHoraAnul
            // 
            this.colFechaHoraAnul.FieldName = "FechaHoraAnul";
            this.colFechaHoraAnul.Name = "colFechaHoraAnul";
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            // 
            // colMotivoAnulacion
            // 
            this.colMotivoAnulacion.FieldName = "MotivoAnulacion";
            this.colMotivoAnulacion.Name = "colMotivoAnulacion";
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Referencia";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.Width = 227;
            // 
            // colSucursal
            // 
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 3;
            this.colSucursal.Width = 158;
            // 
            // colSolicitante
            // 
            this.colSolicitante.Caption = "Solicitante";
            this.colSolicitante.FieldName = "Solicitante";
            this.colSolicitante.Name = "colSolicitante";
            this.colSolicitante.Visible = true;
            this.colSolicitante.VisibleIndex = 4;
            this.colSolicitante.Width = 215;
            // 
            // colComprador
            // 
            this.colComprador.Caption = "Comprador";
            this.colComprador.FieldName = "Comprador";
            this.colComprador.Name = "colComprador";
            this.colComprador.Visible = true;
            this.colComprador.VisibleIndex = 5;
            this.colComprador.Width = 196;
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 6;
            this.coldepartamento.Width = 184;
            // 
            // FrmCom_SolicitudConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 322);
            this.Controls.Add(this.gridControlConsulta);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCom_SolicitudConsulta";
            this.Text = "FrmCom_SolicitudConsulta";
            this.Load += new System.EventHandler(this.FrmCom_SolicitudConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comsolicitudcompraInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private System.Windows.Forms.BindingSource comsolicitudcompraInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona_Solicita;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona_comprador;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colplazo;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vtc;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaHoraAnul;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colSolicitante;
        private DevExpress.XtraGrid.Columns.GridColumn colComprador;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private System.Windows.Forms.BindingSource tbSucursalInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal1;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked;
    }
}