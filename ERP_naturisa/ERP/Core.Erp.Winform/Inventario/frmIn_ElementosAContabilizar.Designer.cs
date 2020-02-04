namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_ElementosAContabilizar
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.vwInVistaParaContabilizarInventarioInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colchek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_tipo_movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_stock_ante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_stock_actu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Inven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentro_Costo_Inventario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentro_Costo_Costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInVistaParaContabilizarInventarioInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.vwInVistaParaContabilizarInventarioInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1227, 304);
            this.gridControl.TabIndex = 0;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwInVistaParaContabilizarInventarioInfoBindingSource
            // 
            
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colchek,
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdBodega,
            this.colIdMovi_inven_tipo,
            this.colIdNumMovi,
            this.colSecuencia,
            this.colmv_tipo_movi,
            this.colIdProducto,
            this.coldm_cantidad,
            this.coldm_stock_ante,
            this.coldm_stock_actu,
            this.coldm_observacion,
            this.coldm_precio,
            this.colmv_costo,
            this.coldm_peso,
            this.colIdCtaCble_Inven,
            this.colIdCtaCble_Costo,
            this.colIdCentro_Costo_Inventario,
            this.colIdCentro_Costo_Costo,
            this.colcm_fecha,
            this.colIdTipoCbte,
            this.colpr_descripcion,
            this.coltm_descripcion,
            this.coltc_TipoCbte,
            this.colSucursal,
            this.colBodega,
            this.colObservacion});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(485, 271, 216, 185);
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveHorzScroll;
            
            // 
            // colchek
            // 
            this.colchek.Caption = "*";
            this.colchek.FieldName = "chek";
            this.colchek.Name = "colchek";
            this.colchek.Visible = true;
            this.colchek.VisibleIndex = 0;
            this.colchek.Width = 20;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // colIdMovi_inven_tipo
            // 
            this.colIdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Name = "colIdMovi_inven_tipo";
            // 
            // colIdNumMovi
            // 
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            this.colIdNumMovi.Visible = true;
            this.colIdNumMovi.VisibleIndex = 4;
            this.colIdNumMovi.Width = 78;
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            // 
            // colmv_tipo_movi
            // 
            this.colmv_tipo_movi.FieldName = "mv_tipo_movi";
            this.colmv_tipo_movi.Name = "colmv_tipo_movi";
            this.colmv_tipo_movi.Visible = true;
            this.colmv_tipo_movi.VisibleIndex = 6;
            this.colmv_tipo_movi.Width = 20;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "Cantidad";
            this.coldm_cantidad.FieldName = "dm_cantidad";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 8;
            this.coldm_cantidad.Width = 49;
            // 
            // coldm_stock_ante
            // 
            this.coldm_stock_ante.FieldName = "dm_stock_ante";
            this.coldm_stock_ante.Name = "coldm_stock_ante";
            // 
            // coldm_stock_actu
            // 
            this.coldm_stock_actu.FieldName = "dm_stock_actu";
            this.coldm_stock_actu.Name = "coldm_stock_actu";
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Observación";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Visible = true;
            this.coldm_observacion.VisibleIndex = 7;
            this.coldm_observacion.Width = 83;
            // 
            // coldm_precio
            // 
            this.coldm_precio.Caption = "Precio";
            this.coldm_precio.FieldName = "dm_precio";
            this.coldm_precio.Name = "coldm_precio";
            this.coldm_precio.Width = 86;
            // 
            // colmv_costo
            // 
            this.colmv_costo.Caption = "Costo";
            this.colmv_costo.FieldName = "mv_costo";
            this.colmv_costo.Name = "colmv_costo";
            this.colmv_costo.Visible = true;
            this.colmv_costo.VisibleIndex = 9;
            this.colmv_costo.Width = 83;
            // 
            // coldm_peso
            // 
            this.coldm_peso.FieldName = "dm_peso";
            this.coldm_peso.Name = "coldm_peso";
            // 
            // colIdCtaCble_Inven
            // 
            this.colIdCtaCble_Inven.Caption = "Cta Cble Inventario";
            this.colIdCtaCble_Inven.FieldName = "IdCtaCble_Inven";
            this.colIdCtaCble_Inven.Name = "colIdCtaCble_Inven";
            this.colIdCtaCble_Inven.Visible = true;
            this.colIdCtaCble_Inven.VisibleIndex = 12;
            this.colIdCtaCble_Inven.Width = 72;
            // 
            // colIdCtaCble_Costo
            // 
            this.colIdCtaCble_Costo.Caption = "Cta Cble Costo";
            this.colIdCtaCble_Costo.FieldName = "IdCtaCble_Costo";
            this.colIdCtaCble_Costo.Name = "colIdCtaCble_Costo";
            this.colIdCtaCble_Costo.Visible = true;
            this.colIdCtaCble_Costo.VisibleIndex = 13;
            this.colIdCtaCble_Costo.Width = 64;
            // 
            // colIdCentro_Costo_Inventario
            // 
            this.colIdCentro_Costo_Inventario.FieldName = "IdCentro_Costo_Inventario";
            this.colIdCentro_Costo_Inventario.Name = "colIdCentro_Costo_Inventario";
            // 
            // colIdCentro_Costo_Costo
            // 
            this.colIdCentro_Costo_Costo.FieldName = "IdCentro_Costo_Costo";
            this.colIdCentro_Costo_Costo.Name = "colIdCentro_Costo_Costo";
            // 
            // colcm_fecha
            // 
            this.colcm_fecha.Caption = "Fecha";
            this.colcm_fecha.FieldName = "cm_fecha";
            this.colcm_fecha.Name = "colcm_fecha";
            this.colcm_fecha.Visible = true;
            this.colcm_fecha.VisibleIndex = 10;
            this.colcm_fecha.Width = 57;
            // 
            // colIdTipoCbte
            // 
            this.colIdTipoCbte.FieldName = "IdTipoCbte";
            this.colIdTipoCbte.Name = "colIdTipoCbte";
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Producto";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 5;
            this.colpr_descripcion.Width = 149;
            // 
            // coltm_descripcion
            // 
            this.coltm_descripcion.Caption = "Tipo Movimiento";
            this.coltm_descripcion.FieldName = "tm_descripcion";
            this.coltm_descripcion.Name = "coltm_descripcion";
            this.coltm_descripcion.Visible = true;
            this.coltm_descripcion.VisibleIndex = 3;
            this.coltm_descripcion.Width = 109;
            // 
            // coltc_TipoCbte
            // 
            this.coltc_TipoCbte.Caption = "Tipo Comprobante";
            this.coltc_TipoCbte.FieldName = "tc_TipoCbte";
            this.coltc_TipoCbte.Name = "coltc_TipoCbte";
            this.coltc_TipoCbte.Visible = true;
            this.coltc_TipoCbte.VisibleIndex = 11;
            this.coltc_TipoCbte.Width = 89;
            // 
            // colSucursal
            // 
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 1;
            this.colSucursal.Width = 63;
            // 
            // colBodega
            // 
            this.colBodega.FieldName = "Bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 2;
            this.colBodega.Width = 62;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 14;
            this.colObservacion.Width = 211;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1140, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Contabilizar";
            
            // 
            // frmIn_ElementosAContabilizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 304);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl);
            this.Name = "frmIn_ElementosAContabilizar";
            this.Text = "Elementos a contabilizar";
            this.Load += new System.EventHandler(this.frmIn_ElementosAContabilizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInVistaParaContabilizarInventarioInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource vwInVistaParaContabilizarInventarioInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_tipo_movi;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_stock_ante;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_stock_actu;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_precio;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_peso;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Inven;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Costo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentro_Costo_Inventario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentro_Costo_Costo;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colchek;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
    }
}