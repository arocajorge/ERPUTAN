using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;


namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ClienteConsulta : Form
    {
        public FrmPrd_ClienteConsulta()
        {
            try
            {
                InitializeComponent();
                load_sucursales();
               // this.gridControl_Clientes.DataSource = Grid_Cliente(0);


              
                ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
                ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
                ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
                ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
                ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

          
        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
       public Boolean llamadoFuera { get; set; }
        public fa_Cliente_Tabla_Info info_otroLLamado { get; set; }
        //fa_Cliente_Tabla_Info tmp_info = new fa_Cliente_Tabla_Info();
        private ToolStripControlHost dtTScomponent;
        private ToolStripControlHost dtTScomponent2;
        private Label lbl_sucursal = new Label();
        private ComboBox cmb_sucursal = new ComboBox();
        

        List<tb_Sucursal_Info> lista_surcusales = new List<tb_Sucursal_Info>();
        List<tb_persona_Info> lista_persona = new List<tb_persona_Info>();
        BindingList<fa_Cliente_Info> lista_clientes = new BindingList<fa_Cliente_Info>();
        fa_Cliente_Info tabla_info = new fa_Cliente_Info();
        fa_Cliente_Info info = new fa_Cliente_Info();
        int idSucursal;

        private cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        private void load_Información()
        {
            try
            {
                tb_persona_bus bus_pers = new tb_persona_bus();
                lista_persona = bus_pers.Get_List_Persona();

                fa_Cliente_Bus bus_client = new fa_Cliente_Bus();
                lista_clientes = new BindingList<fa_Cliente_Info>(bus_client.Get_List_Clientes(param.IdEmpresa));
                gridControl_Clientes.DataSource = lista_clientes;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private List<fa_Cliente_Tabla_Info> Grid_Cliente(int sucursal)
        {
            try
            {
                List<fa_Cliente_Tabla_Info> lm = new List<fa_Cliente_Tabla_Info>();
                fa_Cliente_Info info_cliente = new fa_Cliente_Info();

                return lm;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<fa_Cliente_Tabla_Info>();
            }



        }
        private void load_sucursales()
        {
            try
            {
                lbl_sucursal.Text = "Sucursal:";
                lbl_sucursal.TextAlign = ContentAlignment.MiddleLeft;
                cmb_sucursal.Size = new System.Drawing.Size(250, 21);
                cmb_sucursal.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb_sucursal.SelectedValueChanged += new System.EventHandler(cmb_sucursal_SelectedValueChanged);

                tb_Sucursal_Bus bus_sucursales = new tb_Sucursal_Bus();


                lista_surcusales = bus_sucursales.Get_List_Sucursal(param.IdEmpresa);
                this.cmb_sucursal.DataSource = lista_surcusales;
                this.cmb_sucursal.DisplayMember = "Su_Descripcion";
                this.cmb_sucursal.ValueMember = "IdSucursal";

                dtTScomponent = new ToolStripControlHost(lbl_sucursal);
                dtTScomponent2 = new ToolStripControlHost(cmb_sucursal);


                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_sucursal_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();
                info_sucursal = (tb_Sucursal_Info)this.cmb_sucursal.SelectedItem;
                idSucursal = info_sucursal.IdSucursal;

                //uGrid_Cliente.DataSource = Grid_Cliente(idSucursal);
                gridControl_Clientes.DataSource = Grid_Cliente(idSucursal);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_ClienteMantenimiento  frm = new FrmPrd_ClienteMantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.Show();
                frm.event_FrmPrd_ClienteMantenimiento_FormClosing += frm_event_FrmPrd_ClienteMantenimiento_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void frm_event_FrmPrd_ClienteMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_Información();
                gridControl_Clientes.DataSource = lista_clientes;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
            
        }


        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (fa_Cliente_Info)gridView_Clientes.GetFocusedRow();//fa_Cliente_Tabla_Info
                if (info != null)
                {
                    FrmPrd_ClienteMantenimiento frm = new FrmPrd_ClienteMantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.set_Cliente(info);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***";
                    frm.Show();
                    frm.event_FrmPrd_ClienteMantenimiento_FormClosing+=frm_event_FrmPrd_ClienteMantenimiento_FormClosing;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

           
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (fa_Cliente_Info)gridView_Clientes.GetFocusedRow();//fa_Cliente_Tabla_Info

                if (info.Persona_Info.pe_cedulaRuc != null)
                {
                    FrmPrd_ClienteMantenimiento frm = new FrmPrd_ClienteMantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.set_Cliente(info);
                    load_Información();
                    frm.Text = frm.Text + " ***CONSULTAR***";
                    frm.MdiParent = this.MdiParent;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Cliente: " + tabla_info.Persona_Info.pe_nombre + " " + tabla_info.Persona_Info.pe_apellido + " ?", "Anulación de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (info.Estado == "A")
                        {
                            string msg = "";
                            fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();
                            info.IdUsuarioUltMod = param.IdUsuario;
                            info.Fecha_UltMod = DateTime.Now;
                            info.IdUsuarioUltAnu = param.IdUsuario;
                            info.Fecha_UltAnu = DateTime.Now;
                            bus_cliente.EliminarDB(info, ref msg);
                            MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_Información();
                        }
                        else
                            MessageBox.Show("No se pudo anular el Cliente: " + tabla_info.Persona_Info.pe_nombre + " " + tabla_info.Persona_Info.pe_apellido + " debido a que ya se encuentra anulado", "Anulación de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmFA_Clientes_General_Load(object sender, EventArgs e)
         {
            try
            {
                load_Información();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

            
        }

        private void gridView_Clientes_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                //var data = gridView_Clientes.GetRow(e.RowHandle) as fa_Cliente_Tabla_Info;
                //if (data == null)
                //    return;
                //if (data.info_cliente.Estado == "I")
                //    e.Appearance.ForeColor = Color.Red;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private fa_Cliente_Tabla_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (fa_Cliente_Tabla_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new fa_Cliente_Tabla_Info();
            }
        }

        private void gridView_Clientes_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

                //tmp_info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
                //info = tmp_info.info_cliente;

                //info.Persona_Info.pe_apellido = tmp_info.pe_apellido.Trim();
                //info.Persona_Info.pe_nombre = tmp_info.pe_nombre.Trim();
                //info.Persona_Info.pe_nombreCompleto = tmp_info.pe_nombre.Trim() + " " + tmp_info.pe_apellido.Trim();
                //info.Persona_Info.pe_cedulaRuc = tmp_info.pe_cedulaRuc.Trim();
                //info.Persona_Info.pe_direccion = tmp_info.pe_direccion.Trim();
                //  // info.Persona_Info.pe_estado = (tmp_info.Estado ==true)?"A": "I";
                //info.Persona_Info.pe_razonSocial = tmp_info.pe_razonSocial.Trim();
                //info.Persona_Info.pe_telefonoOfic = tmp_info.pe_telefonoOfic.Trim();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void gridView_Clientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (llamadoFuera == true)
                {
                   //info_otroLLamado = tmp_info;
                   this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void toolStripButtonSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (llamadoFuera == true)
                {
                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridControl_Clientes_Click(object sender, EventArgs e){}

        private void tool_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}

        private void gridView_Clientes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var data = gridView_Clientes.GetRow(e.RowHandle) as fa_Cliente_Tabla_Info;
        }

    }
}
