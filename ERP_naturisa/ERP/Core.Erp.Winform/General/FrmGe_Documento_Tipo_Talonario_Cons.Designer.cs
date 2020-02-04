namespace Core.Erp.Winform.General
{
    partial class FrmGe_Documento_Tipo_Talonario_Cons
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
            this.gridControl_Docu_Talonario = new DevExpress.XtraGrid.GridControl();
            this.gridView_Docu_Talonario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstablecimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuntoEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodDocumentoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Docu_Talonario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Docu_Talonario)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Docu_Talonario
            // 
            this.gridControl_Docu_Talonario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Docu_Talonario.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Docu_Talonario.MainView = this.gridView_Docu_Talonario;
            this.gridControl_Docu_Talonario.Name = "gridControl_Docu_Talonario";
            this.gridControl_Docu_Talonario.Size = new System.Drawing.Size(698, 275);
            this.gridControl_Docu_Talonario.TabIndex = 0;
            this.gridControl_Docu_Talonario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Docu_Talonario});
            // 
            // gridView_Docu_Talonario
            // 
            this.gridView_Docu_Talonario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colEstablecimiento,
            this.colPuntoEmision,
            this.colNumDocumento,
            this.colUsado,
            this.colCodDocumentoTipo,
            this.colNombreSucursal,
            this.colIdSucursal,
            this.colEstado});
            this.gridView_Docu_Talonario.GridControl = this.gridControl_Docu_Talonario;
            this.gridView_Docu_Talonario.Name = "gridView_Docu_Talonario";
            this.gridView_Docu_Talonario.OptionsBehavior.Editable = false;
            this.gridView_Docu_Talonario.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Docu_Talonario.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_Docu_Talonario_RowCellStyle);
            this.gridView_Docu_Talonario.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Docu_Talonario_FocusedRowChanged);
            this.gridView_Docu_Talonario.DoubleClick += new System.EventHandler(this.gridView_Docu_Talonario_DoubleClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colEstablecimiento
            // 
            this.colEstablecimiento.Caption = "Establecimiento";
            this.colEstablecimiento.FieldName = "Establecimiento";
            this.colEstablecimiento.Name = "colEstablecimiento";
            this.colEstablecimiento.Visible = true;
            this.colEstablecimiento.VisibleIndex = 1;
            this.colEstablecimiento.Width = 84;
            // 
            // colPuntoEmision
            // 
            this.colPuntoEmision.Caption = "Punto Emisión";
            this.colPuntoEmision.FieldName = "PuntoEmision";
            this.colPuntoEmision.Name = "colPuntoEmision";
            this.colPuntoEmision.Visible = true;
            this.colPuntoEmision.VisibleIndex = 2;
            this.colPuntoEmision.Width = 84;
            // 
            // colNumDocumento
            // 
            this.colNumDocumento.Caption = "# Documento";
            this.colNumDocumento.FieldName = "NumDocumento";
            this.colNumDocumento.Name = "colNumDocumento";
            this.colNumDocumento.Visible = true;
            this.colNumDocumento.VisibleIndex = 3;
            this.colNumDocumento.Width = 333;
            // 
            // colUsado
            // 
            this.colUsado.Caption = "Usado";
            this.colUsado.FieldName = "Usado";
            this.colUsado.Name = "colUsado";
            this.colUsado.Visible = true;
            this.colUsado.VisibleIndex = 4;
            this.colUsado.Width = 51;
            // 
            // colCodDocumentoTipo
            // 
            this.colCodDocumentoTipo.Caption = "Tipo Documento";
            this.colCodDocumentoTipo.FieldName = "CodDocumentoTipo";
            this.colCodDocumentoTipo.Name = "colCodDocumentoTipo";
            this.colCodDocumentoTipo.Visible = true;
            this.colCodDocumentoTipo.VisibleIndex = 0;
            this.colCodDocumentoTipo.Width = 77;
            // 
            // colNombreSucursal
            // 
            this.colNombreSucursal.Caption = "Sucursal";
            this.colNombreSucursal.FieldName = "NombreSucursal";
            this.colNombreSucursal.Name = "colNombreSucursal";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 249);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(698, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            this.colEstado.Width = 51;
            // 
            // FrmGe_Documento_Tipo_Talonario_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 275);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.gridControl_Docu_Talonario);
            this.Name = "FrmGe_Documento_Tipo_Talonario_Cons";
            this.Text = "Documento Tipo Talonario Consulta";
            this.Load += new System.EventHandler(this.FrmGe_Documento_Tipo_Talonario_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Docu_Talonario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Docu_Talonario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Docu_Talonario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Docu_Talonario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEstablecimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colPuntoEmision;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colUsado;
        private DevExpress.XtraGrid.Columns.GridColumn colCodDocumentoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}