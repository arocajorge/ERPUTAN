namespace Core.Erp.Winform.General
{
    partial class frmGe_PersonaConsulta
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlPersona = new DevExpress.XtraGrid.GridControl();
            this.gridViewPersona = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_razonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_apellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_telefonoCasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_celular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_correo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_fax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_sexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_fechaNacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 114);
            this.panel1.TabIndex = 5;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 2, 27, 12, 41, 10, 548);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 4, 27, 12, 41, 10, 549);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(1028, 114);
            this.ucGe_Menu.TabIndex = 4;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 441);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1028, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlPersona);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 327);
            this.panel2.TabIndex = 8;
            // 
            // gridControlPersona
            // 
            this.gridControlPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPersona.Location = new System.Drawing.Point(0, 0);
            this.gridControlPersona.MainView = this.gridViewPersona;
            this.gridControlPersona.Name = "gridControlPersona";
            this.gridControlPersona.Size = new System.Drawing.Size(1028, 327);
            this.gridControlPersona.TabIndex = 0;
            this.gridControlPersona.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPersona});
            this.gridControlPersona.Click += new System.EventHandler(this.gridControlPersona_Click);
            // 
            // gridViewPersona
            // 
            this.gridViewPersona.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPersona,
            this.colpe_razonSocial,
            this.colpe_apellido,
            this.colpe_nombre,
            this.colpe_cedulaRuc,
            this.colpe_direccion,
            this.colpe_telefonoCasa,
            this.colpe_celular,
            this.colpe_correo,
            this.colpe_fax,
            this.colpe_sexo,
            this.colpe_fechaNacimiento,
            this.colpe_estado});
            this.gridViewPersona.GridControl = this.gridControlPersona;
            this.gridViewPersona.Name = "gridViewPersona";
            this.gridViewPersona.OptionsBehavior.Editable = false;
            this.gridViewPersona.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPersona.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewPersona_RowCellStyle);
            // 
            // colIdPersona
            // 
            this.colIdPersona.Caption = "IdPersona";
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.Visible = true;
            this.colIdPersona.VisibleIndex = 0;
            this.colIdPersona.Width = 60;
            // 
            // colpe_razonSocial
            // 
            this.colpe_razonSocial.Caption = "Razon Social";
            this.colpe_razonSocial.FieldName = "pe_razonSocial";
            this.colpe_razonSocial.Name = "colpe_razonSocial";
            this.colpe_razonSocial.Visible = true;
            this.colpe_razonSocial.VisibleIndex = 1;
            this.colpe_razonSocial.Width = 104;
            // 
            // colpe_apellido
            // 
            this.colpe_apellido.Caption = "Apellido";
            this.colpe_apellido.FieldName = "pe_apellido";
            this.colpe_apellido.Name = "colpe_apellido";
            this.colpe_apellido.Visible = true;
            this.colpe_apellido.VisibleIndex = 2;
            this.colpe_apellido.Width = 141;
            // 
            // colpe_nombre
            // 
            this.colpe_nombre.Caption = "Nombre";
            this.colpe_nombre.FieldName = "pe_nombre";
            this.colpe_nombre.Name = "colpe_nombre";
            this.colpe_nombre.Visible = true;
            this.colpe_nombre.VisibleIndex = 3;
            this.colpe_nombre.Width = 141;
            // 
            // colpe_cedulaRuc
            // 
            this.colpe_cedulaRuc.Caption = "Cedula/RUC";
            this.colpe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.colpe_cedulaRuc.Name = "colpe_cedulaRuc";
            this.colpe_cedulaRuc.Visible = true;
            this.colpe_cedulaRuc.VisibleIndex = 4;
            this.colpe_cedulaRuc.Width = 132;
            // 
            // colpe_direccion
            // 
            this.colpe_direccion.Caption = "Direccion";
            this.colpe_direccion.FieldName = "pe_direccion";
            this.colpe_direccion.Name = "colpe_direccion";
            this.colpe_direccion.Visible = true;
            this.colpe_direccion.VisibleIndex = 5;
            this.colpe_direccion.Width = 127;
            // 
            // colpe_telefonoCasa
            // 
            this.colpe_telefonoCasa.Caption = "Telefono";
            this.colpe_telefonoCasa.FieldName = "pe_telefonoCasa";
            this.colpe_telefonoCasa.Name = "colpe_telefonoCasa";
            this.colpe_telefonoCasa.Visible = true;
            this.colpe_telefonoCasa.VisibleIndex = 6;
            this.colpe_telefonoCasa.Width = 110;
            // 
            // colpe_celular
            // 
            this.colpe_celular.Caption = "Celular";
            this.colpe_celular.FieldName = "pe_celular";
            this.colpe_celular.Name = "colpe_celular";
            this.colpe_celular.Visible = true;
            this.colpe_celular.VisibleIndex = 7;
            this.colpe_celular.Width = 55;
            // 
            // colpe_correo
            // 
            this.colpe_correo.Caption = "Correo";
            this.colpe_correo.FieldName = "pe_correo";
            this.colpe_correo.Name = "colpe_correo";
            this.colpe_correo.Visible = true;
            this.colpe_correo.VisibleIndex = 8;
            this.colpe_correo.Width = 55;
            // 
            // colpe_fax
            // 
            this.colpe_fax.Caption = "Fax";
            this.colpe_fax.FieldName = "pe_fax";
            this.colpe_fax.Name = "colpe_fax";
            this.colpe_fax.Visible = true;
            this.colpe_fax.VisibleIndex = 9;
            this.colpe_fax.Width = 55;
            // 
            // colpe_sexo
            // 
            this.colpe_sexo.Caption = "Sexo";
            this.colpe_sexo.FieldName = "pe_sexo";
            this.colpe_sexo.Name = "colpe_sexo";
            this.colpe_sexo.Visible = true;
            this.colpe_sexo.VisibleIndex = 10;
            this.colpe_sexo.Width = 55;
            // 
            // colpe_fechaNacimiento
            // 
            this.colpe_fechaNacimiento.Caption = "Fecha Nacimiento";
            this.colpe_fechaNacimiento.FieldName = "pe_fechaNacimiento";
            this.colpe_fechaNacimiento.Name = "colpe_fechaNacimiento";
            this.colpe_fechaNacimiento.Visible = true;
            this.colpe_fechaNacimiento.VisibleIndex = 11;
            this.colpe_fechaNacimiento.Width = 55;
            // 
            // colpe_estado
            // 
            this.colpe_estado.Caption = "Estado";
            this.colpe_estado.FieldName = "pe_estado";
            this.colpe_estado.Name = "colpe_estado";
            this.colpe_estado.Visible = true;
            this.colpe_estado.VisibleIndex = 12;
            this.colpe_estado.Width = 90;
            // 
            // frmGe_PersonaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.panel1);
            this.Name = "frmGe_PersonaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Personas";
            this.Load += new System.EventHandler(this.FrmGe_PersonaConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControlPersona;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_razonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_apellido;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_direccion;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_telefonoCasa;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_celular;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_correo;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_fax;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_sexo;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_fechaNacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_estado;
    }
}