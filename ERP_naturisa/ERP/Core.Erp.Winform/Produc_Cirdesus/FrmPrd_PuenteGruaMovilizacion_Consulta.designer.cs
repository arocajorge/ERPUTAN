namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_PuenteGruaMovilizacion_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_PuenteGruaMovilizacion_Consulta));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridControlMovilizacion = new DevExpress.XtraGrid.GridControl();
            this.gridViewMovilizacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdPteGrua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescripcion_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColOrigen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColToneladasMov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.splitContainerConsulta = new System.Windows.Forms.SplitContainer();
            this.cmbOperador = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNomEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPteGrua = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColidPuenteGrua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LbHasta = new System.Windows.Forms.Label();
            this.dtPFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.LbDesde = new System.Windows.Forms.Label();
            this.dtPFechadesde = new System.Windows.Forms.DateTimePicker();
            this.LbOperador = new System.Windows.Forms.Label();
            this.lbPuenteGrua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovilizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovilizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerConsulta)).BeginInit();
            this.splitContainerConsulta.Panel1.SuspendLayout();
            this.splitContainerConsulta.Panel2.SuspendLayout();
            this.splitContainerConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPteGrua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(927, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gridControlMovilizacion
            // 
            this.gridControlMovilizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMovilizacion.Location = new System.Drawing.Point(0, 0);
            this.gridControlMovilizacion.MainView = this.gridViewMovilizacion;
            this.gridControlMovilizacion.Name = "gridControlMovilizacion";
            this.gridControlMovilizacion.Size = new System.Drawing.Size(927, 223);
            this.gridControlMovilizacion.TabIndex = 14;
            this.gridControlMovilizacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMovilizacion});
            // 
            // gridViewMovilizacion
            // 
            this.gridViewMovilizacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdPteGrua,
            this.ColDescripcion_producto,
            this.ColFecha,
            this.ColOrigen,
            this.ColDestino,
            this.ColEstado,
            this.ColToneladasMov});
            this.gridViewMovilizacion.CustomizationFormBounds = new System.Drawing.Rectangle(616, 413, 216, 185);
            this.gridViewMovilizacion.GridControl = this.gridControlMovilizacion;
            this.gridViewMovilizacion.Name = "gridViewMovilizacion";
            this.gridViewMovilizacion.OptionsBehavior.Editable = false;
            this.gridViewMovilizacion.OptionsFind.AlwaysVisible = true;
            this.gridViewMovilizacion.OptionsView.ShowIndicator = false;
            this.gridViewMovilizacion.OptionsView.ShowViewCaption = true;
            this.gridViewMovilizacion.ViewCaption = "Listado de Movilización del Puente de Grúa";
            this.gridViewMovilizacion.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewMovilizacion_FocusedRowChanged);
            // 
            // ColIdPteGrua
            // 
            this.ColIdPteGrua.Caption = "Puente Grua";
            this.ColIdPteGrua.FieldName = "IdPuenteGrua";
            this.ColIdPteGrua.Name = "ColIdPteGrua";
            this.ColIdPteGrua.Visible = true;
            this.ColIdPteGrua.VisibleIndex = 0;
            this.ColIdPteGrua.Width = 101;
            // 
            // ColDescripcion_producto
            // 
            this.ColDescripcion_producto.Caption = "Descripcion Producto";
            this.ColDescripcion_producto.FieldName = "DescripcionPieza";
            this.ColDescripcion_producto.Name = "ColDescripcion_producto";
            this.ColDescripcion_producto.Visible = true;
            this.ColDescripcion_producto.VisibleIndex = 1;
            this.ColDescripcion_producto.Width = 392;
            // 
            // ColFecha
            // 
            this.ColFecha.Caption = "Fecha Hora";
            this.ColFecha.FieldName = "FechaTransaccion";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.Visible = true;
            this.ColFecha.VisibleIndex = 5;
            this.ColFecha.Width = 88;
            // 
            // ColOrigen
            // 
            this.ColOrigen.Caption = "Etapa Anterior";
            this.ColOrigen.FieldName = "Etapa_Ant";
            this.ColOrigen.Name = "ColOrigen";
            this.ColOrigen.Visible = true;
            this.ColOrigen.VisibleIndex = 2;
            this.ColOrigen.Width = 183;
            // 
            // ColDestino
            // 
            this.ColDestino.Caption = "Etapa Siguiente";
            this.ColDestino.FieldName = "Etapa_Sig";
            this.ColDestino.Name = "ColDestino";
            this.ColDestino.Visible = true;
            this.ColDestino.VisibleIndex = 3;
            this.ColDestino.Width = 226;
            // 
            // ColEstado
            // 
            this.ColEstado.Caption = "Estado";
            this.ColEstado.FieldName = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.Visible = true;
            this.ColEstado.VisibleIndex = 6;
            this.ColEstado.Width = 46;
            // 
            // ColToneladasMov
            // 
            this.ColToneladasMov.Caption = "Toneladas Mover";
            this.ColToneladasMov.FieldName = "ToneladasMover";
            this.ColToneladasMov.Name = "ColToneladasMov";
            this.ColToneladasMov.Visible = true;
            this.ColToneladasMov.VisibleIndex = 4;
            this.ColToneladasMov.Width = 118;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            // 
            // 
            // 
            this.printableComponentLink1.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.printableComponentLink1.Owner = null;
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 4, 5, 10, 15, 56, 912);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 6, 5, 10, 15, 56, 912);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(927, 111);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 16;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick_1);
            // 
            // splitContainerConsulta
            // 
            this.splitContainerConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerConsulta.Location = new System.Drawing.Point(0, 111);
            this.splitContainerConsulta.Name = "splitContainerConsulta";
            this.splitContainerConsulta.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerConsulta.Panel1
            // 
            this.splitContainerConsulta.Panel1.Controls.Add(this.cmbOperador);
            this.splitContainerConsulta.Panel1.Controls.Add(this.cmbPteGrua);
            this.splitContainerConsulta.Panel1.Controls.Add(this.BtnBuscar);
            this.splitContainerConsulta.Panel1.Controls.Add(this.LbHasta);
            this.splitContainerConsulta.Panel1.Controls.Add(this.dtPFechaHasta);
            this.splitContainerConsulta.Panel1.Controls.Add(this.LbDesde);
            this.splitContainerConsulta.Panel1.Controls.Add(this.dtPFechadesde);
            this.splitContainerConsulta.Panel1.Controls.Add(this.LbOperador);
            this.splitContainerConsulta.Panel1.Controls.Add(this.lbPuenteGrua);
            // 
            // splitContainerConsulta.Panel2
            // 
            this.splitContainerConsulta.Panel2.Controls.Add(this.gridControlMovilizacion);
            this.splitContainerConsulta.Size = new System.Drawing.Size(927, 296);
            this.splitContainerConsulta.SplitterDistance = 69;
            this.splitContainerConsulta.TabIndex = 17;
            // 
            // cmbOperador
            // 
            this.cmbOperador.Location = new System.Drawing.Point(494, 18);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOperador.Properties.DisplayMember = "NomEmpleado";
            this.cmbOperador.Properties.ValueMember = "IdOperador";
            this.cmbOperador.Properties.View = this.gridView1;
            this.cmbOperador.Size = new System.Drawing.Size(407, 20);
            this.cmbOperador.TabIndex = 127;
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
            // cmbPteGrua
            // 
            this.cmbPteGrua.Location = new System.Drawing.Point(85, 18);
            this.cmbPteGrua.Name = "cmbPteGrua";
            this.cmbPteGrua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPteGrua.Properties.DisplayMember = "nombre";
            this.cmbPteGrua.Properties.ValueMember = "idPuenteGrua";
            this.cmbPteGrua.Properties.View = this.searchLookUpEdit1View;
            this.cmbPteGrua.Size = new System.Drawing.Size(346, 20);
            this.cmbPteGrua.TabIndex = 126;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColidPuenteGrua,
            this.Colnombre});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColidPuenteGrua
            // 
            this.ColidPuenteGrua.Caption = "Id PuenteGrua";
            this.ColidPuenteGrua.FieldName = "idPuenteGrua";
            this.ColidPuenteGrua.Name = "ColidPuenteGrua";
            this.ColidPuenteGrua.Visible = true;
            this.ColidPuenteGrua.VisibleIndex = 0;
            // 
            // Colnombre
            // 
            this.Colnombre.Caption = "Nombre";
            this.Colnombre.FieldName = "nombre";
            this.Colnombre.Name = "Colnombre";
            this.Colnombre.Visible = true;
            this.Colnombre.VisibleIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(840, 41);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 125;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LbHasta
            // 
            this.LbHasta.AutoSize = true;
            this.LbHasta.Location = new System.Drawing.Point(307, 47);
            this.LbHasta.Name = "LbHasta";
            this.LbHasta.Size = new System.Drawing.Size(35, 13);
            this.LbHasta.TabIndex = 124;
            this.LbHasta.Text = "Hasta";
            // 
            // dtPFechaHasta
            // 
            this.dtPFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPFechaHasta.Location = new System.Drawing.Point(364, 44);
            this.dtPFechaHasta.Name = "dtPFechaHasta";
            this.dtPFechaHasta.Size = new System.Drawing.Size(215, 20);
            this.dtPFechaHasta.TabIndex = 123;
            // 
            // LbDesde
            // 
            this.LbDesde.AutoSize = true;
            this.LbDesde.Location = new System.Drawing.Point(12, 47);
            this.LbDesde.Name = "LbDesde";
            this.LbDesde.Size = new System.Drawing.Size(41, 13);
            this.LbDesde.TabIndex = 122;
            this.LbDesde.Text = " Desde";
            // 
            // dtPFechadesde
            // 
            this.dtPFechadesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPFechadesde.Location = new System.Drawing.Point(86, 44);
            this.dtPFechadesde.Name = "dtPFechadesde";
            this.dtPFechadesde.Size = new System.Drawing.Size(215, 20);
            this.dtPFechadesde.TabIndex = 121;
            // 
            // LbOperador
            // 
            this.LbOperador.AutoSize = true;
            this.LbOperador.Location = new System.Drawing.Point(437, 21);
            this.LbOperador.Name = "LbOperador";
            this.LbOperador.Size = new System.Drawing.Size(51, 13);
            this.LbOperador.TabIndex = 119;
            this.LbOperador.Text = "Operador";
            // 
            // lbPuenteGrua
            // 
            this.lbPuenteGrua.AutoSize = true;
            this.lbPuenteGrua.Location = new System.Drawing.Point(12, 21);
            this.lbPuenteGrua.Name = "lbPuenteGrua";
            this.lbPuenteGrua.Size = new System.Drawing.Size(67, 13);
            this.lbPuenteGrua.TabIndex = 117;
            this.lbPuenteGrua.Text = "Puente Grua";
            // 
            // FrmPrd_PuenteGruaMovilizacion_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 429);
            this.Controls.Add(this.splitContainerConsulta);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmPrd_PuenteGruaMovilizacion_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Movilización Puente Grua";
            this.Load += new System.EventHandler(this.FrmPrd_PuenteGruaMovilizacion_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovilizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovilizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.splitContainerConsulta.Panel1.ResumeLayout(false);
            this.splitContainerConsulta.Panel1.PerformLayout();
            this.splitContainerConsulta.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerConsulta)).EndInit();
            this.splitContainerConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPteGrua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridControl gridControlMovilizacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMovilizacion;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPteGrua;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion_producto;
        private DevExpress.XtraGrid.Columns.GridColumn ColFecha;
        private DevExpress.XtraGrid.Columns.GridColumn ColOrigen;
        private DevExpress.XtraGrid.Columns.GridColumn ColDestino;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstado;
        private System.Windows.Forms.SplitContainer splitContainerConsulta;
        private System.Windows.Forms.Label LbOperador;
        private System.Windows.Forms.Label lbPuenteGrua;
        private System.Windows.Forms.Label LbHasta;
        private System.Windows.Forms.DateTimePicker dtPFechaHasta;
        private System.Windows.Forms.Label LbDesde;
        private System.Windows.Forms.DateTimePicker dtPFechadesde;
        private System.Windows.Forms.Button BtnBuscar;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbOperador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn ColNomEmpleado;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPteGrua;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColidPuenteGrua;
        private DevExpress.XtraGrid.Columns.GridColumn Colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn ColToneladasMov;
    }
}