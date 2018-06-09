namespace Core.Erp.Winform.Controles
{
    partial class UCIn_Movimiento_Inventario
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblsucursal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblbodega = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl_producto = new DevExpress.XtraGrid.GridControl();
            this.gridView_producto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubcentrocosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblNum_Transaccion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTipoMovi_Inven = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblobservacion = new System.Windows.Forms.Label();
            this.lblanulado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal:";
            // 
            // lblsucursal
            // 
            this.lblsucursal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsucursal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsucursal.Location = new System.Drawing.Point(85, 40);
            this.lblsucursal.Name = "lblsucursal";
            this.lblsucursal.Size = new System.Drawing.Size(268, 24);
            this.lblsucursal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bodega:";
            // 
            // lblbodega
            // 
            this.lblbodega.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblbodega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbodega.Location = new System.Drawing.Point(85, 75);
            this.lblbodega.Name = "lblbodega";
            this.lblbodega.Size = new System.Drawing.Size(268, 24);
            this.lblbodega.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha:";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Enabled = false;
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(583, 69);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(164, 20);
            this.dtpfecha.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl_producto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 279);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // gridControl_producto
            // 
            this.gridControl_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_producto.Location = new System.Drawing.Point(3, 16);
            this.gridControl_producto.MainView = this.gridView_producto;
            this.gridControl_producto.Name = "gridControl_producto";
            this.gridControl_producto.Size = new System.Drawing.Size(800, 260);
            this.gridControl_producto.TabIndex = 0;
            this.gridControl_producto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_producto});
            // 
            // gridView_producto
            // 
            this.gridView_producto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colcod_producto,
            this.colpr_descripcion,
            this.colSecuencia,
            this.coldm_cantidad,
            this.coldm_observacion,
            this.colIdCentroCosto,
            this.colsubcentrocosto,
            this.colmv_costo,
            this.coldm_precio});
            this.gridView_producto.GridControl = this.gridControl_producto;
            this.gridView_producto.Name = "gridView_producto";
            this.gridView_producto.OptionsView.ShowAutoFilterRow = true;
            this.gridView_producto.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "IdProducto";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 7;
            this.colIdProducto.Width = 33;
            // 
            // colcod_producto
            // 
            this.colcod_producto.Caption = "codigo";
            this.colcod_producto.FieldName = "CodProducto";
            this.colcod_producto.Name = "colcod_producto";
            this.colcod_producto.Visible = true;
            this.colcod_producto.VisibleIndex = 1;
            this.colcod_producto.Width = 49;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "producto";
            this.colpr_descripcion.FieldName = "NomProducto";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 2;
            this.colpr_descripcion.Width = 313;
            // 
            // colSecuencia
            // 
            this.colSecuencia.Caption = "Secuencia";
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            this.colSecuencia.Visible = true;
            this.colSecuencia.VisibleIndex = 0;
            this.colSecuencia.Width = 31;
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "Cantidad";
            this.coldm_cantidad.FieldName = "dm_cantidad";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 3;
            this.coldm_cantidad.Width = 96;
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Observacion";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Visible = true;
            this.coldm_observacion.VisibleIndex = 4;
            this.coldm_observacion.Width = 137;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "Centro costo";
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 5;
            this.colIdCentroCosto.Width = 77;
            // 
            // colsubcentrocosto
            // 
            this.colsubcentrocosto.Caption = "Sub Centro Costo";
            this.colsubcentrocosto.FieldName = "IdCentroCosto_sub_centro_costo";
            this.colsubcentrocosto.Name = "colsubcentrocosto";
            this.colsubcentrocosto.Visible = true;
            this.colsubcentrocosto.VisibleIndex = 6;
            this.colsubcentrocosto.Width = 46;
            // 
            // colmv_costo
            // 
            this.colmv_costo.Caption = "Costo";
            this.colmv_costo.FieldName = "mv_costo";
            this.colmv_costo.Name = "colmv_costo";
            // 
            // coldm_precio
            // 
            this.coldm_precio.Caption = "Precio";
            this.coldm_precio.FieldName = "dm_precio";
            this.coldm_precio.Name = "coldm_precio";
            // 
            // lblNum_Transaccion
            // 
            this.lblNum_Transaccion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNum_Transaccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum_Transaccion.Location = new System.Drawing.Point(580, 34);
            this.lblNum_Transaccion.Name = "lblNum_Transaccion";
            this.lblNum_Transaccion.Size = new System.Drawing.Size(167, 24);
            this.lblNum_Transaccion.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "#Transaccion:";
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(806, 29);
            this.ucGe_Menu.TabIndex = 9;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntSalir = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tipo de Movimiento:";
            // 
            // lblTipoMovi_Inven
            // 
            this.lblTipoMovi_Inven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipoMovi_Inven.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTipoMovi_Inven.Location = new System.Drawing.Point(542, 105);
            this.lblTipoMovi_Inven.Name = "lblTipoMovi_Inven";
            this.lblTipoMovi_Inven.Size = new System.Drawing.Size(205, 24);
            this.lblTipoMovi_Inven.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Observacion:";
            // 
            // lblobservacion
            // 
            this.lblobservacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblobservacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblobservacion.Location = new System.Drawing.Point(97, 140);
            this.lblobservacion.Name = "lblobservacion";
            this.lblobservacion.Size = new System.Drawing.Size(650, 64);
            this.lblobservacion.TabIndex = 13;
            // 
            // lblanulado
            // 
            this.lblanulado.AutoSize = true;
            this.lblanulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanulado.ForeColor = System.Drawing.Color.Red;
            this.lblanulado.Location = new System.Drawing.Point(257, 109);
            this.lblanulado.Name = "lblanulado";
            this.lblanulado.Size = new System.Drawing.Size(122, 20);
            this.lblanulado.TabIndex = 14;
            this.lblanulado.Text = "**ANULADO**";
            this.lblanulado.Visible = false;
            // 
            // UCIn_Movimiento_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblanulado);
            this.Controls.Add(this.lblobservacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTipoMovi_Inven);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.lblNum_Transaccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblbodega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsucursal);
            this.Controls.Add(this.label1);
            this.Name = "UCIn_Movimiento_Inventario";
            this.Size = new System.Drawing.Size(806, 497);
            this.Load += new System.EventHandler(this.UCIn_Movimiento_Inventario_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblbodega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNum_Transaccion;
        private System.Windows.Forms.Label label6;
        private UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControl_producto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colsubcentrocosto;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTipoMovi_Inven;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblobservacion;
        private System.Windows.Forms.Label lblanulado;
    }
}
