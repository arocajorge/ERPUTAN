namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_Consulta_OrdenCompra
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_Oc = new DevExpress.XtraGrid.GridControl();
            this.gridView_oc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.oc_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.do_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Oc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_oc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl_Oc;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "IdProducto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridControl_Oc
            // 
            this.gridControl_Oc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Oc.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Oc.MainView = this.gridView_oc;
            this.gridControl_Oc.Name = "gridControl_Oc";
            this.gridControl_Oc.Size = new System.Drawing.Size(741, 271);
            this.gridControl_Oc.TabIndex = 0;
            this.gridControl_Oc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_oc,
            this.gridView1});
            // 
            // gridView_oc
            // 
            this.gridView_oc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.IdOrdenCompra,
            this.oc_fecha,
            this.pr_nombre,
            this.do_observacion});
            this.gridView_oc.GridControl = this.gridControl_Oc;
            this.gridView_oc.Name = "gridView_oc";
            this.gridView_oc.OptionsBehavior.Editable = false;
            this.gridView_oc.OptionsView.ShowGroupPanel = false;
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Su_Descripcion";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 0;
            this.Sucursal.Width = 157;
            // 
            // IdOrdenCompra
            // 
            this.IdOrdenCompra.Caption = "#Orden Compra";
            this.IdOrdenCompra.FieldName = "IdOrdenCompra";
            this.IdOrdenCompra.Name = "IdOrdenCompra";
            this.IdOrdenCompra.Visible = true;
            this.IdOrdenCompra.VisibleIndex = 1;
            this.IdOrdenCompra.Width = 85;
            // 
            // oc_fecha
            // 
            this.oc_fecha.Caption = "Fecha";
            this.oc_fecha.FieldName = "oc_fecha";
            this.oc_fecha.Name = "oc_fecha";
            this.oc_fecha.Visible = true;
            this.oc_fecha.VisibleIndex = 2;
            this.oc_fecha.Width = 67;
            // 
            // pr_nombre
            // 
            this.pr_nombre.Caption = "Proveedor";
            this.pr_nombre.FieldName = "pr_nombre";
            this.pr_nombre.Name = "pr_nombre";
            this.pr_nombre.Visible = true;
            this.pr_nombre.VisibleIndex = 3;
            this.pr_nombre.Width = 218;
            // 
            // do_observacion
            // 
            this.do_observacion.Caption = "Observacion";
            this.do_observacion.FieldName = "oc_observacion";
            this.do_observacion.Name = "do_observacion";
            this.do_observacion.Visible = true;
            this.do_observacion.VisibleIndex = 4;
            this.do_observacion.Width = 653;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
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
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(741, 27);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btnAceptar = true;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 298);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(741, 26);
            this.ucGe_BarraEstado.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_Oc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 271);
            this.panel1.TabIndex = 2;
            // 
            // FrmCom_Consulta_OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmCom_Consulta_OrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Orden de Compras";
            this.Load += new System.EventHandler(this.FrmCom_Consulta_OrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Oc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_oc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_Oc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_oc;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn IdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn oc_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn pr_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn do_observacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}