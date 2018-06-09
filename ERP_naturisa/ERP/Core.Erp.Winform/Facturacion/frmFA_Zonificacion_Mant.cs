using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Zonificacion_Mant : Form
    {

        //#region DEclaración de Variables
        //tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //private Cl_Enumeradores.eTipo_action _Accion;
        ////tb_ubicacion_Info info = new tb_ubicacion_Info();
        //public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //int CountView = 0;
        //string id = "";
        //string IdUbicacionPadre = "";

        //#endregion

        public frmFa_Zonificacion_Mant()
        {
            try
            {
                InitializeComponent();
                //ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                //ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                //ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                //Log_Error_bus.Log_Error(ex.ToString());
                //MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (guardarDatos())
        //        {
        //            this.Close();
        //        }     
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        //{           
        //    try
        //    {
        //        guardarDatos();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //Boolean guardarDatos()
        //{
        //    try
        //    {
        //        Boolean bolResult = false;
        //        if (validarDatos())
        //        {
        //            get_ubicacion();
        //            string id = "";
        //            string msg = "";
        //            tb_ubicacion_Bus ubicacion_bus = new tb_ubicacion_Bus();
        //            switch (_Accion)
        //            {
        //                case Cl_Enumeradores.eTipo_action.grabar:
        //                    if (ubicacion_bus.GrabarDB(info, ref id, ref msg))
        //                    {
        //                        bolResult = true;
        //                        MessageBox.Show("Registro guardado exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        ucGe_Menu.Visible_btnGuardar = false;
        //                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
        //                    }else
        //                        MessageBox.Show("Error " + msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                    break;
        //                case Cl_Enumeradores.eTipo_action.actualizar:
        //                    if (ubicacion_bus.ModificarDB(info, ref msg))
        //                    {
        //                        bolResult = true;
        //                        MessageBox.Show("Registro guardado exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        ucGe_Menu.Visible_btnGuardar = false;
        //                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
        //                    }else
        //                        MessageBox.Show("Error " + msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                    break;

        //            }
        //        }
        //        return bolResult;
        //    }
        //    catch (Exception ex)
        //    {
        //     Log_Error_bus.Log_Error(ex.ToString());
        //     MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //     return false;
        //    }
        //}



        //private Boolean validarDatos()
        //{
        //    try
        //    {
        //        if (txt_idUbicacion.Text == "" || txt_idUbicacion.Text == null)
        //          {
        //              MessageBox.Show("Por favor Seleccione la Ubicacion Padre", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //              return false;
        //          }

        //        if (txt_descripcion.Text == "" || txt_descripcion.Text == null)
        //        {
        //            MessageBox.Show("Por favor Seleccione la Ubicacion Padre", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
                

        //            return true;
        //    }
        //    catch (Exception ex)
        //    {
        //     Log_Error_bus.Log_Error(ex.ToString());
        //     MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //}


        //public void iniciar()
        //{
        //    try
        //    {
        //      _Accion = Cl_Enumeradores.eTipo_action.actualizar; 
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        //{
        //    try
        //    {
        //     _Accion = iAccion;
        //    }
        //    catch (Exception ex)
        //    {

        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}
 
        //private void load_ubicacion()
        //{
        //    try
        //    {
        //        tb_ubicacion_Bus menu_ubicacion = new tb_ubicacion_Bus();
        //        List<tb_ubicacion_Info> lista_ubicacion = new List<tb_ubicacion_Info>();
        //        lista_ubicacion = menu_ubicacion.Get_List_Ubicacion();
        //        this.cmb_ubicacion.DataSource = lista_ubicacion;
        //        this.cmb_ubicacion.DisplayMember = "ub_descripcion";
        //        this.cmb_ubicacion.ValueMember = "IdUbicacion";
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public tb_ubicacion_Info get_ubicacion()
        //{
        //    try
        //    {
        //        info = new tb_ubicacion_Info();
        //        info.IdUbicacion = id; //(this.txt_idUbicacion.Text != "") ? this.txt_idUbicacion.Text : "";
        //        info.IdUbicacion_Padre = txt_idUbicacion.Text; //(this.cmb_ubicacion.SelectedItem != null) ? this.cmb_ubicacion.SelectedValue.ToString() : "";
        //        info.ub_descripcion = this.txt_descripcion.Text;
        //        info.ub_nivel = Convert.ToInt32(this.txt_nivel.Value);
        //        info.ub_posicion = Convert.ToInt32(this.txt_posicion.Value);
        //        info.IdUsuario = param.IdUsuario;
        //        info.Fecha_Transac = DateTime.Now;
        //        info.IdUsuarioUltMod = param.IdUsuario;
        //        info.Fecha_UltMod = DateTime.Now;
        //        info.IdUsuarioUltAnu = param.IdUsuario;
        //        info.Fecha_UltAnu = DateTime.Now;
        //        info.nom_pc = param.nom_pc;
        //        info.ip = param.ip;
        //        info.Estado = (this.chk_Estado.Checked == true) ? "A" : "I";
        //        return info;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return new tb_ubicacion_Info();
        //    }
        //}

        //public void set_ubicacion(tb_ubicacion_Info info_ubicacion)
        //{
        //    try
        //    {
        //        if (info_ubicacion != null)
        //        {
        //            id = info_ubicacion.IdUbicacion.ToString();
        //            this.txt_idUbicacion.Text = id;
        //            IdUbicacionPadre = info_ubicacion.IdUbicacion_Padre;
        //            this.cmb_ubicacion.SelectedValue = info_ubicacion.IdUbicacion_Padre;

        //            this.txt_descripcion.Text = info_ubicacion.ub_descripcion;
        //            this.txt_nivel.Value = info_ubicacion.ub_nivel;
        //            this.txt_posicion.Value = info_ubicacion.ub_posicion;
        //            this.chk_Estado.Checked = (info_ubicacion.Estado == "A") ? true : false;
        //        }
        //        info = info_ubicacion;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void load_menuTre()
        //{
        //    try
        //    {
        //        tb_ubicacion_Bus mb = new tb_ubicacion_Bus();
        //        this.treelist_Ubicacion.DataSource = mb.Get_List_Ubicacion();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void frmFA_Zonificacion_Mant_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        load_ubicacion();
        //        load_menuTre();
        //        switch (_Accion)
        //        {
        //            case Cl_Enumeradores.eTipo_action.grabar:
        //                ucGe_Menu.Visible_btnGuardar = true;
        //                ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
        //                ucGe_Menu.Visible_bntAnular = false;
        //                this.chk_Estado.Enabled = false;
        //                break;
        //            case Cl_Enumeradores.eTipo_action.actualizar:
        //                ucGe_Menu.Visible_btnGuardar = true;
        //                ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
        //                ucGe_Menu.Visible_bntAnular = false;
        //                this.chk_Estado.Enabled = true;

        //                break;
        //            case Cl_Enumeradores.eTipo_action.borrar:
        //                ucGe_Menu.Visible_btnGuardar = false;
        //                ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
        //                ucGe_Menu.Enabled_bntAnular = true;
        //                break;
        //            case Cl_Enumeradores.eTipo_action.consultar:
        //                ucGe_Menu.Visible_btnGuardar = false;
        //                ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
        //                ucGe_Menu.Visible_bntAnular = false;
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void treelist_Ubicacion_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        //{
        //    try
        //    {
        //        IdUbicacionPadre = "";

        //        TreeListColumn IdUbicacion = treelist_Ubicacion.Columns["IdUbicacion"];
        //        TreeListNode childNode = (TreeListNode)e.Node;
        //        switch (_Accion)
        //        {
        //            case Cl_Enumeradores.eTipo_action.grabar:
        //                foreach (TreeListColumn item in treelist_Ubicacion.Columns)
        //                {
        //                    switch (item.FieldName)
        //                    {
        //                        case "IdUbicacion":
        //                            IdUbicacionPadre = childNode.GetValue(IdUbicacion).ToString();
        //                            id = IdUbicacionPadre;
        //                            break;
        //                    }
        //                }
        //                CountView = CountView + 1;
        //                if (CountView > 1)
        //                {
        //                    this.cmb_ubicacion.SelectedValue = IdUbicacionPadre;
        //                    this.txt_idUbicacion.Text = id;
        //                }
        //                break;
        //            case Cl_Enumeradores.eTipo_action.actualizar:
        //                IdUbicacionPadre = info.IdUbicacion_Padre;
        //                this.cmb_ubicacion.SelectedValue = info.IdUbicacion_Padre;
        //                if (IdUbicacionPadre.Length > 3)
        //                {
        //                    IdUbicacionPadre = IdUbicacionPadre.Substring(0, IdUbicacionPadre.Length - 3);
        //                }
        //                else
        //                {
        //                    //IdUbicacionPadre="";
        //                }
        //                break;
        //            case Cl_Enumeradores.eTipo_action.borrar:
        //                break;
        //            case Cl_Enumeradores.eTipo_action.consultar:
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void treelist_Ubicacion_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //private void cmb_ubicacion_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        switch (_Accion)
        //        {
        //            case Cl_Enumeradores.eTipo_action.grabar:
        //                if (this.cmb_ubicacion.SelectedItem != null)
        //                {
        //                    tb_ubicacion_Info info_ubicacion = new tb_ubicacion_Info();
        //                    info_ubicacion = (tb_ubicacion_Info)this.cmb_ubicacion.SelectedItem;
        //                    this.txt_nivel.Value = info_ubicacion.ub_nivel + 1;
        //                    this.txt_posicion.Value = info_ubicacion.ub_posicion + 1;
        //                    this.txt_descripcion.Focus();
        //                }
        //                else
        //                {
        //                    this.txt_nivel.Value = 0;
        //                    this.txt_posicion.Value = 0;
        //                    this.txt_descripcion.Focus();
        //                }
        //                break;
        //            case Cl_Enumeradores.eTipo_action.actualizar:
        //                break;
        //            case Cl_Enumeradores.eTipo_action.borrar:
        //                break;
        //            case Cl_Enumeradores.eTipo_action.consultar:
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


      
    }
}
