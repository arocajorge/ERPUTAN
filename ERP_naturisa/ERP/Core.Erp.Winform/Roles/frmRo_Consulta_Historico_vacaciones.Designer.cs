namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Consulta_Historico_vacaciones
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
            this.roHistoricoVacacionesInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rosolicitudPermisoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlConsultaH = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsultaH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasTomados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasGanados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasPendientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRetorno = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roHistoricoVacacionesInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosolicitudPermisoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsultaH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsultaH)).BeginInit();
            this.SuspendLayout();
            // 
            // roHistoricoVacacionesInfoBindingSource
            // 
            this.roHistoricoVacacionesInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_historico_vacaciones_x_empleado_Info);
            // 
            // rosolicitudPermisoInfoBindingSource
            // 
            this.rosolicitudPermisoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_SolicitudVacaciones_Info);
            // 
            // gridControlConsultaH
            // 
            this.gridControlConsultaH.DataSource = this.roHistoricoVacacionesInfoBindingSource;
            this.gridControlConsultaH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConsultaH.Location = new System.Drawing.Point(0, 0);
            this.gridControlConsultaH.MainView = this.gridViewConsultaH;
            this.gridControlConsultaH.Name = "gridControlConsultaH";
            this.gridControlConsultaH.Size = new System.Drawing.Size(803, 304);
            this.gridControlConsultaH.TabIndex = 0;
            this.gridControlConsultaH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsultaH});
            // 
            // gridViewConsultaH
            // 
            this.gridViewConsultaH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaInicio,
            this.colFechaFin,
            this.colDiasTomados,
            this.colObservacion,
            this.colDiasGanados,
            this.colDiasPendientes,
            this.colIco,
            this.colTipo,
            this.colFechaRetorno});
            this.gridViewConsultaH.GridControl = this.gridControlConsultaH;
            this.gridViewConsultaH.Name = "gridViewConsultaH";
            this.gridViewConsultaH.OptionsView.ShowGroupPanel = false;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 0;
            this.colFechaInicio.Width = 157;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 1;
            this.colFechaFin.Width = 157;
            // 
            // colDiasTomados
            // 
            this.colDiasTomados.FieldName = "DiasTomados";
            this.colDiasTomados.Name = "colDiasTomados";
            this.colDiasTomados.Visible = true;
            this.colDiasTomados.VisibleIndex = 3;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 4;
            this.colObservacion.Width = 239;
            // 
            // colDiasGanados
            // 
            this.colDiasGanados.FieldName = "DiasGanados";
            this.colDiasGanados.Name = "colDiasGanados";
            // 
            // colDiasPendientes
            // 
            this.colDiasPendientes.FieldName = "DiasPendientes";
            this.colDiasPendientes.Name = "colDiasPendientes";
            // 
            // colIco
            // 
            this.colIco.FieldName = "Ico";
            this.colIco.Name = "colIco";
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            // 
            // colFechaRetorno
            // 
            this.colFechaRetorno.FieldName = "FechaRetorno";
            this.colFechaRetorno.Name = "colFechaRetorno";
            this.colFechaRetorno.Visible = true;
            this.colFechaRetorno.VisibleIndex = 2;
            this.colFechaRetorno.Width = 157;
            // 
            // frmRo_Consulta_Historico_vacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 304);
            this.Controls.Add(this.gridControlConsultaH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Consulta_Historico_vacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta  - Detalle de Vacaciones Gozadas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Consulta_Historico_vacaciones_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Consulta_Historico_vacaciones_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.roHistoricoVacacionesInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosolicitudPermisoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsultaH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsultaH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource roHistoricoVacacionesInfoBindingSource;
        private System.Windows.Forms.BindingSource rosolicitudPermisoInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlConsultaH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsultaH;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasTomados;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasGanados;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasPendientes;
        private DevExpress.XtraGrid.Columns.GridColumn colIco;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRetorno;

    }
}