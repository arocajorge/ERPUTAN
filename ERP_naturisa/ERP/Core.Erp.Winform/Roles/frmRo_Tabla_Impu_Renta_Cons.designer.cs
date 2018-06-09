namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Tabla_Impu_Renta_Cons
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
            this.gridControlTablaIR = new DevExpress.XtraGrid.GridControl();
            this.rotablaImpuRentaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewTablaIR = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAnioFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFraccionBasica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExcesoHasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpFraccionBasica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPor_ImpFraccion_Exce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTablaIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotablaImpuRentaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTablaIR)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlTablaIR
            // 
            this.gridControlTablaIR.DataSource = this.rotablaImpuRentaInfoBindingSource;
            this.gridControlTablaIR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTablaIR.Location = new System.Drawing.Point(0, 0);
            this.gridControlTablaIR.MainView = this.gridViewTablaIR;
            this.gridControlTablaIR.Name = "gridControlTablaIR";
            this.gridControlTablaIR.Size = new System.Drawing.Size(822, 197);
            this.gridControlTablaIR.TabIndex = 8;
            this.gridControlTablaIR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTablaIR});
            // 
            // gridViewTablaIR
            // 
            this.gridViewTablaIR.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAnioFiscal,
            this.colSecuencia,
            this.colFraccionBasica,
            this.colExcesoHasta,
            this.colImpFraccionBasica,
            this.colPor_ImpFraccion_Exce});
            this.gridViewTablaIR.GridControl = this.gridControlTablaIR;
            this.gridViewTablaIR.Name = "gridViewTablaIR";
            this.gridViewTablaIR.OptionsBehavior.Editable = false;
            this.gridViewTablaIR.OptionsBehavior.ReadOnly = true;
            this.gridViewTablaIR.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTablaIR.OptionsView.ShowGroupPanel = false;
            this.gridViewTablaIR.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTablaIR_FocusedRowChanged);
            // 
            // colAnioFiscal
            // 
            this.colAnioFiscal.Caption = "Año Fiscal";
            this.colAnioFiscal.FieldName = "AnioFiscal";
            this.colAnioFiscal.Name = "colAnioFiscal";
            this.colAnioFiscal.Visible = true;
            this.colAnioFiscal.VisibleIndex = 0;
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            this.colSecuencia.Visible = true;
            this.colSecuencia.VisibleIndex = 1;
            // 
            // colFraccionBasica
            // 
            this.colFraccionBasica.Caption = "Fracción Básica";
            this.colFraccionBasica.FieldName = "FraccionBasica";
            this.colFraccionBasica.Name = "colFraccionBasica";
            this.colFraccionBasica.Visible = true;
            this.colFraccionBasica.VisibleIndex = 2;
            this.colFraccionBasica.Width = 92;
            // 
            // colExcesoHasta
            // 
            this.colExcesoHasta.FieldName = "ExcesoHasta";
            this.colExcesoHasta.Name = "colExcesoHasta";
            this.colExcesoHasta.Visible = true;
            this.colExcesoHasta.VisibleIndex = 3;
            this.colExcesoHasta.Width = 84;
            // 
            // colImpFraccionBasica
            // 
            this.colImpFraccionBasica.Caption = "Impuesto Fracción Básica";
            this.colImpFraccionBasica.FieldName = "ImpFraccionBasica";
            this.colImpFraccionBasica.Name = "colImpFraccionBasica";
            this.colImpFraccionBasica.Visible = true;
            this.colImpFraccionBasica.VisibleIndex = 4;
            this.colImpFraccionBasica.Width = 140;
            // 
            // colPor_ImpFraccion_Exce
            // 
            this.colPor_ImpFraccion_Exce.Caption = "%";
            this.colPor_ImpFraccion_Exce.FieldName = "Por_ImpFraccion_Exce";
            this.colPor_ImpFraccion_Exce.Name = "colPor_ImpFraccion_Exce";
            this.colPor_ImpFraccion_Exce.Visible = true;
            this.colPor_ImpFraccion_Exce.VisibleIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 291);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(822, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 94);
            this.panel1.TabIndex = 10;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 2, 23, 9, 19, 8, 74);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 4, 23, 9, 19, 8, 74);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(822, 97);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlTablaIR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 197);
            this.panel2.TabIndex = 11;
            // 
            // frmRo_Tabla_Impu_Renta_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 313);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_Tabla_Impu_Renta_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Tabla del Impuesto a la Renta";
            this.Load += new System.EventHandler(this.frmRo_Tabla_Impu_Renta_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTablaIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotablaImpuRentaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTablaIR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlTablaIR;
        private System.Windows.Forms.BindingSource rotablaImpuRentaInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTablaIR;
        private DevExpress.XtraGrid.Columns.GridColumn colAnioFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colFraccionBasica;
        private DevExpress.XtraGrid.Columns.GridColumn colExcesoHasta;
        private DevExpress.XtraGrid.Columns.GridColumn colImpFraccionBasica;
        private DevExpress.XtraGrid.Columns.GridColumn colPor_ImpFraccion_Exce;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
    }
}