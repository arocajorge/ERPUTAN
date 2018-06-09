namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class Frm_ProductividadSubgrupoTrabajo_Consulta
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
            this.gridControlProductividad_consulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductividad_consulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdGrupoTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Su_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductividad_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductividad_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProductividad_consulta
            // 
            this.gridControlProductividad_consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductividad_consulta.Location = new System.Drawing.Point(0, 96);
            this.gridControlProductividad_consulta.MainView = this.gridViewProductividad_consulta;
            this.gridControlProductividad_consulta.Name = "gridControlProductividad_consulta";
            this.gridControlProductividad_consulta.Size = new System.Drawing.Size(788, 401);
            this.gridControlProductividad_consulta.TabIndex = 15;
            this.gridControlProductividad_consulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductividad_consulta});
            // 
            // gridViewProductividad_consulta
            // 
            this.gridViewProductividad_consulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdGrupoTrabajo,
            this.Descripcion,
            this.Estado,
            this.DescripModelo,
            this.NombreEtapa,
            this.pe_nombreCompleto,
            this.CodCentroCosto,
            this.Su_Descripcion,
            this.colFechaCreacion});
            this.gridViewProductividad_consulta.GridControl = this.gridControlProductividad_consulta;
            this.gridViewProductividad_consulta.Name = "gridViewProductividad_consulta";
            this.gridViewProductividad_consulta.OptionsBehavior.Editable = false;
            this.gridViewProductividad_consulta.OptionsFind.AlwaysVisible = true;
            this.gridViewProductividad_consulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProductividad_consulta.OptionsView.ShowFooter = true;
            this.gridViewProductividad_consulta.OptionsView.ShowIndicator = false;
            this.gridViewProductividad_consulta.OptionsView.ShowViewCaption = true;
            this.gridViewProductividad_consulta.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdGrupoTrabajo, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewProductividad_consulta.ViewCaption = "Listado de Grupos de Trabajo";
            // 
            // IdGrupoTrabajo
            // 
            this.IdGrupoTrabajo.AppearanceCell.Options.UseTextOptions = true;
            this.IdGrupoTrabajo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdGrupoTrabajo.AppearanceHeader.Options.UseTextOptions = true;
            this.IdGrupoTrabajo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdGrupoTrabajo.Caption = "Reg #";
            this.IdGrupoTrabajo.FieldName = "IdGrupoTrabajo";
            this.IdGrupoTrabajo.Name = "IdGrupoTrabajo";
            this.IdGrupoTrabajo.OptionsColumn.AllowEdit = false;
            this.IdGrupoTrabajo.Visible = true;
            this.IdGrupoTrabajo.VisibleIndex = 2;
            this.IdGrupoTrabajo.Width = 55;
            // 
            // Descripcion
            // 
            this.Descripcion.AppearanceCell.Options.UseTextOptions = true;
            this.Descripcion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Descripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.Descripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Descripcion.Caption = "Grupo";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.OptionsColumn.AllowEdit = false;
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 3;
            this.Descripcion.Width = 129;
            // 
            // Estado
            // 
            this.Estado.AppearanceCell.Options.UseTextOptions = true;
            this.Estado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Estado.AppearanceHeader.Options.UseTextOptions = true;
            this.Estado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 7;
            this.Estado.Width = 69;
            // 
            // DescripModelo
            // 
            this.DescripModelo.AppearanceCell.Options.UseTextOptions = true;
            this.DescripModelo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DescripModelo.AppearanceHeader.Options.UseTextOptions = true;
            this.DescripModelo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DescripModelo.Caption = "Modelo Producción";
            this.DescripModelo.FieldName = "DescripModelo";
            this.DescripModelo.Name = "DescripModelo";
            this.DescripModelo.OptionsColumn.AllowEdit = false;
            this.DescripModelo.Visible = true;
            this.DescripModelo.VisibleIndex = 5;
            this.DescripModelo.Width = 38;
            // 
            // NombreEtapa
            // 
            this.NombreEtapa.AppearanceCell.Options.UseTextOptions = true;
            this.NombreEtapa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NombreEtapa.AppearanceHeader.Options.UseTextOptions = true;
            this.NombreEtapa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NombreEtapa.Caption = "Etapa Producción";
            this.NombreEtapa.FieldName = "NombreEtapa";
            this.NombreEtapa.Name = "NombreEtapa";
            this.NombreEtapa.OptionsColumn.AllowEdit = false;
            this.NombreEtapa.Visible = true;
            this.NombreEtapa.VisibleIndex = 6;
            this.NombreEtapa.Width = 67;
            // 
            // pe_nombreCompleto
            // 
            this.pe_nombreCompleto.AppearanceCell.Options.UseTextOptions = true;
            this.pe_nombreCompleto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pe_nombreCompleto.AppearanceHeader.Options.UseTextOptions = true;
            this.pe_nombreCompleto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pe_nombreCompleto.Caption = "Líder";
            this.pe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.pe_nombreCompleto.Name = "pe_nombreCompleto";
            this.pe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.pe_nombreCompleto.Visible = true;
            this.pe_nombreCompleto.VisibleIndex = 4;
            this.pe_nombreCompleto.Width = 140;
            // 
            // CodCentroCosto
            // 
            this.CodCentroCosto.AppearanceCell.Options.UseTextOptions = true;
            this.CodCentroCosto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CodCentroCosto.AppearanceHeader.Options.UseTextOptions = true;
            this.CodCentroCosto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CodCentroCosto.Caption = "Cod Obra";
            this.CodCentroCosto.FieldName = "CodObra";
            this.CodCentroCosto.Name = "CodCentroCosto";
            this.CodCentroCosto.OptionsColumn.AllowEdit = false;
            this.CodCentroCosto.Width = 47;
            // 
            // Su_Descripcion
            // 
            this.Su_Descripcion.AppearanceCell.Options.UseTextOptions = true;
            this.Su_Descripcion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Su_Descripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.Su_Descripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Su_Descripcion.Caption = "Sucursal";
            this.Su_Descripcion.FieldName = "Su_Descripcion";
            this.Su_Descripcion.Name = "Su_Descripcion";
            this.Su_Descripcion.OptionsColumn.AllowEdit = false;
            this.Su_Descripcion.Visible = true;
            this.Su_Descripcion.VisibleIndex = 1;
            this.Su_Descripcion.Width = 40;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.Caption = "Fecha";
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.Visible = true;
            this.colFechaCreacion.VisibleIndex = 0;
            this.colFechaCreacion.Width = 69;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu.Enable_boton_Importar_XML = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 6, 27, 9, 24, 41, 225);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 8, 27, 9, 24, 41, 225);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(788, 96);
            this.ucGe_Menu.TabIndex = 14;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            // 
            // Frm_ProductividadSubgrupoTrabajo_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 497);
            this.Controls.Add(this.gridControlProductividad_consulta);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "Frm_ProductividadSubgrupoTrabajo_Consulta";
            this.Text = "                            Productividad  por SubGrupo de trabajo";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductividad_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductividad_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProductividad_consulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductividad_consulta;
        private DevExpress.XtraGrid.Columns.GridColumn IdGrupoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn DescripModelo;
        private DevExpress.XtraGrid.Columns.GridColumn NombreEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn pe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn CodCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn Su_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
    }
}