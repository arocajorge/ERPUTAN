namespace Core.Erp.Winform.Roles
{
    partial class frmRo_TablaSectorial_Cons
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
            this.gridCtrlTablaSectorial = new DevExpress.XtraGrid.GridControl();
            this.gridViewTablaSectorial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdSectorial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCodIess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColActividad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstOcup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlTablaSectorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTablaSectorial)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCtrlTablaSectorial
            // 
            this.gridCtrlTablaSectorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlTablaSectorial.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlTablaSectorial.MainView = this.gridViewTablaSectorial;
            this.gridCtrlTablaSectorial.Name = "gridCtrlTablaSectorial";
            this.gridCtrlTablaSectorial.Size = new System.Drawing.Size(624, 200);
            this.gridCtrlTablaSectorial.TabIndex = 13;
            this.gridCtrlTablaSectorial.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTablaSectorial});
            // 
            // gridViewTablaSectorial
            // 
            this.gridViewTablaSectorial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdSectorial,
            this.ColCodIess,
            this.ColActividad,
            this.ColEstOcup,
            this.ColEstado});
            this.gridViewTablaSectorial.CustomizationFormBounds = new System.Drawing.Rectangle(512, 442, 216, 185);
            this.gridViewTablaSectorial.GridControl = this.gridCtrlTablaSectorial;
            this.gridViewTablaSectorial.Name = "gridViewTablaSectorial";
            this.gridViewTablaSectorial.OptionsBehavior.Editable = false;
            this.gridViewTablaSectorial.OptionsBehavior.ReadOnly = true;
            this.gridViewTablaSectorial.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTablaSectorial.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ColIdSectorial, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewTablaSectorial.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewTablaSectorial_RowStyle);
            this.gridViewTablaSectorial.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTablaSectorial_FocusedRowChanged);
            // 
            // ColIdSectorial
            // 
            this.ColIdSectorial.Caption = "Código";
            this.ColIdSectorial.FieldName = "IdCodSectorial";
            this.ColIdSectorial.Name = "ColIdSectorial";
            this.ColIdSectorial.Visible = true;
            this.ColIdSectorial.VisibleIndex = 0;
            this.ColIdSectorial.Width = 55;
            // 
            // ColCodIess
            // 
            this.ColCodIess.Caption = "Código IESS";
            this.ColCodIess.FieldName = "CodigoIESS";
            this.ColCodIess.Name = "ColCodIess";
            this.ColCodIess.Visible = true;
            this.ColCodIess.VisibleIndex = 1;
            this.ColCodIess.Width = 169;
            // 
            // ColActividad
            // 
            this.ColActividad.Caption = "Actividad";
            this.ColActividad.FieldName = "Actividad";
            this.ColActividad.Name = "ColActividad";
            this.ColActividad.Visible = true;
            this.ColActividad.VisibleIndex = 2;
            this.ColActividad.Width = 136;
            // 
            // ColEstOcup
            // 
            this.ColEstOcup.Caption = "Estructura Ocupacional";
            this.ColEstOcup.FieldName = "EstructuraOcupacional";
            this.ColEstOcup.Name = "ColEstOcup";
            this.ColEstOcup.Visible = true;
            this.ColEstOcup.VisibleIndex = 3;
            this.ColEstOcup.Width = 121;
            // 
            // ColEstado
            // 
            this.ColEstado.Caption = "Estado";
            this.ColEstado.FieldName = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.Visible = true;
            this.ColEstado.VisibleIndex = 4;
            this.ColEstado.Width = 125;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 294);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 94);
            this.panel1.TabIndex = 15;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 2, 23, 9, 19, 29, 835);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 4, 23, 9, 19, 29, 835);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(624, 97);
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
            this.panel2.Controls.Add(this.gridCtrlTablaSectorial);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 200);
            this.panel2.TabIndex = 16;
            // 
            // frmRo_TablaSectorial_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 316);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_TablaSectorial_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta TablaSectorial";
            this.Load += new System.EventHandler(this.frmRo_TablaSectorial_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlTablaSectorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTablaSectorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlTablaSectorial;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTablaSectorial;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdSectorial;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodIess;
        private DevExpress.XtraGrid.Columns.GridColumn ColActividad;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstOcup;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    }
}