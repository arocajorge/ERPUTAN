using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Core.Erp.Info.MobileSCI;
using Core.Erp.Business.MobileSCI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Linq;

namespace Core.Erp.Winform.MobileSCI
{
    public partial class frmApp_usuario_mant : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        tbl_usuario_Info info_usuario;
        tbl_usuario_Bus bus_usuario;
        cl_parametrosGenerales_Bus param;
        Cl_Enumeradores.eTipo_action Accion;
        List<tb_Empresa_Info> lst_empresa;
        tb_Empresa_Bus bus_empresa;
        BindingList<tbl_usuario_x_bodega_Info> blst_bodega;
        BindingList<tbl_usuario_x_subcentro_Info> blst_subcentro;
        tbl_usuario_x_bodega_Bus bus_bodega;
        tbl_usuario_x_subcentro_Bus bus_subcentro;
        List<tbl_usuario_x_subcentro_Info> lst_subcentro;
        List<tbl_usuario_x_bodega_Info> lst_bodega;
        #endregion

        #region Delegados
        public delegate void delegate_frmApp_usuario_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmApp_usuario_mant_FormClosed event_delegate_frmApp_usuario_mant_FormClosed;
        void frmApp_usuario_mant_event_delegate_frmApp_usuario_mant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmApp_usuario_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmApp_usuario_mant_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        public frmApp_usuario_mant()
        {
            InitializeComponent();
            info_usuario = new tbl_usuario_Info();
            bus_usuario = new tbl_usuario_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            lst_empresa = new List<tb_Empresa_Info>();
            bus_empresa = new tb_Empresa_Bus();
            lst_subcentro = new List<tbl_usuario_x_subcentro_Info>();
            lst_bodega = new List<tbl_usuario_x_bodega_Info>();
            bus_bodega = new tbl_usuario_x_bodega_Bus();
            bus_subcentro = new tbl_usuario_x_subcentro_Bus();            
            event_delegate_frmApp_usuario_mant_FormClosed += frmApp_usuario_mant_event_delegate_frmApp_usuario_mant_FormClosed;
        }        

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_guardar())
                {
                    this.limpiar();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_guardar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_guardar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_info(tbl_usuario_Info _info)
        {
            info_usuario = _info;
        }

        private void set_info()
        {
            try
            {
                txt_clave.Text = info_usuario.clave;
                txt_usuario.Text = info_usuario.IdUsuarioSCI;
                txt_nombre.Text = info_usuario.nom_usuario;
                lst_bodega = bus_bodega.get_list(info_usuario.IdUsuarioSCI, true);
                lst_subcentro = bus_subcentro.get_list(info_usuario.IdUsuarioSCI, true);
                cargar_grillas_x_empresa();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion()
        {
            try
            {
                cargar_combos();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        txt_usuario.Properties.ReadOnly = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        lst_subcentro = bus_subcentro.get_list("", true);
                        lst_bodega = bus_bodega.get_list("", true);
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        txt_usuario.Properties.ReadOnly = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        set_info();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        txt_usuario.Properties.ReadOnly = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        set_info();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        txt_usuario.Properties.ReadOnly = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        set_info();
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_usuario.Text))
                {
                    MessageBox.Show("Ingrese el usuario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (string.IsNullOrEmpty(txt_clave.Text))
                {
                    MessageBox.Show("Ingrese la clave", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (Accion == Cl_Enumeradores.eTipo_action.grabar && bus_usuario.validar_existe_usuario(txt_usuario.Text))
                {
                    MessageBox.Show("El usuario ya se encuentra registrado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void get_info()
        {
            try
            {
                info_usuario = new tbl_usuario_Info
                {
                    IdUsuarioSCI = txt_usuario.Text,
                    clave = txt_clave.Text,
                    nom_usuario = txt_nombre.Text,
                    lst_usuario_x_bodega = lst_bodega.Where(q=>q.seleccionado == true).ToList(),
                    lst_usuario_x_subcentro = lst_subcentro.Where(q => q.seleccionado == true).ToList(),
                };
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                blst_bodega = new BindingList<tbl_usuario_x_bodega_Info>();
                gridControlBodegas.DataSource = blst_bodega;
                blst_subcentro = new BindingList<tbl_usuario_x_subcentro_Info>();
                gridControlSubcentros.DataSource = blst_subcentro;

                lst_empresa = bus_empresa.Get_List_Empresa();
                cmb_empresa.Properties.DataSource = lst_empresa;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool accion_guardar()
        {
            try
            {
                bool res = false;
                if (!validar())
                    return false;
                get_info();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = guardarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res = modificarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        res = anularDB();
                        break;
                }

                return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void limpiar()
        {
            try
            {
                txt_clave.Text = string.Empty;
                txt_usuario.Text = string.Empty;
                txt_nombre.Text = string.Empty;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool guardarDB()
        {
            try
            {
                if (bus_usuario.guardarDB(info_usuario))
                {
                    MessageBox.Show("Registro guardado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool modificarDB()
        {
            try
            {
                if (bus_usuario.modificarDB(info_usuario))
                {
                    MessageBox.Show("Registro actualizado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool anularDB()
        {
            try
            {
                if (bus_usuario.anularDB(info_usuario))
                {
                    MessageBox.Show("Registro anulado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            Accion = _Accion;
        }

        private void frmApp_usuario_mant_Load(object sender, EventArgs e)
        {
            set_accion();
        }

        private void cmb_empresa_EditValueChanged(object sender, EventArgs e)
        {
            cargar_grillas_x_empresa();
        }

        private void cargar_grillas_x_empresa()
        {
            try
            {
                var lst_temp_cc = (from q in lst_subcentro
                                    join f in blst_subcentro
                                        on new { q.IdEmpresa, q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { f.IdEmpresa, f.IdCentroCosto, f.IdCentroCosto_sub_centro_costo }
                                    into gr
                                    from p in gr.DefaultIfEmpty()
                                    select new tbl_usuario_x_subcentro_Info
                                    {
                                        IdEmpresa = q.IdEmpresa,
                                        IdCentroCosto = q.IdCentroCosto,
                                        IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                        nom_centro = q.nom_centro,
                                        nom_subcentro = q.nom_subcentro,
                                        seleccionado = p == null ? q.seleccionado : p.seleccionado
                                    }).ToList();
                lst_subcentro = lst_temp_cc;

                var lst_temp_sb = (from q in lst_bodega
                                   join f in blst_bodega
                                   on new { q.IdEmpresa, q.IdSucursal, q.IdBodega } equals new { f.IdEmpresa, f.IdSucursal, f.IdBodega }
                                   into gr
                                   from p in gr.DefaultIfEmpty()
                                   select new tbl_usuario_x_bodega_Info
                                   {
                                       IdEmpresa = q.IdEmpresa,
                                       IdSucursal = q.IdSucursal,
                                       IdBodega = q.IdBodega,
                                       nom_sucursal = q.nom_sucursal,
                                       nom_bodega = q.nom_bodega,
                                       seleccionado = p == null ? q.seleccionado : p.seleccionado
                                   }).ToList();
                lst_bodega = lst_temp_sb;


                blst_bodega = new BindingList<tbl_usuario_x_bodega_Info>();
                blst_subcentro = new BindingList<tbl_usuario_x_subcentro_Info>();
                if (cmb_empresa.EditValue != null)
                {
                    int IdEmpresa = Convert.ToInt32(cmb_empresa.EditValue);
                    blst_bodega = new BindingList<tbl_usuario_x_bodega_Info>(lst_bodega.Where(q => q.IdEmpresa == IdEmpresa).ToList());
                    blst_subcentro = new BindingList<tbl_usuario_x_subcentro_Info>(lst_subcentro.Where(q => q.IdEmpresa == IdEmpresa).ToList());
                }
                gridControlBodegas.DataSource = blst_bodega;
                gridControlSubcentros.DataSource = blst_subcentro;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}