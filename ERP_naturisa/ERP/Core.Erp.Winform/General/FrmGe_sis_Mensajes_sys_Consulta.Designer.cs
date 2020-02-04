namespace Core.Erp.Winform.General
{
    partial class FrmGe_sis_Mensajes_sys_Consulta
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
            this.gridControlMensajes = new DevExpress.XtraGrid.GridControl();
            this.tbsisMensajessysInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridMensajes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMensaje_Englesh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMensaje_Esp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisMensajessysInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMensajes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlMensajes
            // 
            this.gridControlMensajes.DataSource = this.tbsisMensajessysInfoBindingSource;
            this.gridControlMensajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMensajes.Location = new System.Drawing.Point(0, 0);
            this.gridControlMensajes.MainView = this.GridMensajes;
            this.gridControlMensajes.Name = "gridControlMensajes";
            this.gridControlMensajes.Size = new System.Drawing.Size(633, 220);
            this.gridControlMensajes.TabIndex = 13;
            this.gridControlMensajes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridMensajes});
            // 
            // tbsisMensajessysInfoBindingSource
            // 
            this.tbsisMensajessysInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_sis_Mensajes_sys_Info);
            // 
            // GridMensajes
            // 
            this.GridMensajes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMensaje,
            this.colEstado,
            this.colMensaje_Englesh,
            this.colMensaje_Esp});
            this.GridMensajes.GridControl = this.gridControlMensajes;
            this.GridMensajes.Name = "GridMensajes";
            this.GridMensajes.OptionsBehavior.Editable = false;
            this.GridMensajes.OptionsView.AllowHtmlDrawHeaders = true;
            this.GridMensajes.OptionsView.ShowAutoFilterRow = true;
            this.GridMensajes.OptionsView.ShowGroupPanel = false;
            this.GridMensajes.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.GridMensajes.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridMensaje_RowCellStyle);
            // 
            // colIdMensaje
            // 
            this.colIdMensaje.FieldName = "IdMensaje";
            this.colIdMensaje.Name = "colIdMensaje";
            this.colIdMensaje.Visible = true;
            this.colIdMensaje.VisibleIndex = 0;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            // 
            // colMensaje_Englesh
            // 
            this.colMensaje_Englesh.Caption = "Mensaje en Ingles";
            this.colMensaje_Englesh.FieldName = "Mensaje_Englesh";
            this.colMensaje_Englesh.Name = "colMensaje_Englesh";
            this.colMensaje_Englesh.Visible = true;
            this.colMensaje_Englesh.VisibleIndex = 2;
            // 
            // colMensaje_Esp
            // 
            this.colMensaje_Esp.Caption = "Mensaje en Español";
            this.colMensaje_Esp.FieldName = "Mensaje_Esp";
            this.colMensaje_Esp.Name = "colMensaje_Esp";
            this.colMensaje_Esp.Visible = true;
            this.colMensaje_Esp.VisibleIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 96);
            this.panel1.TabIndex = 15;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 30, 12, 57, 21, 744);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 30, 12, 57, 21, 744);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(633, 93);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlMensajes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 220);
            this.panel2.TabIndex = 16;
            // 
            // FrmGe_sis_Mensajes_sys_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmGe_sis_Mensajes_sys_Consulta";
            this.Text = "Consulta de Mensajes de Sistema..";
            this.Load += new System.EventHandler(this.FrmGe_sis_Mensajes_sys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisMensajessysInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMensajes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMensajes;
        private DevExpress.XtraGrid.Views.Grid.GridView GridMensajes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colMensaje_Englesh;
        private DevExpress.XtraGrid.Columns.GridColumn colMensaje_Esp;
        private System.Windows.Forms.BindingSource tbsisMensajessysInfoBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;

    }
}