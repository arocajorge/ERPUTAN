using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_TipoDocumento_Mant : Form
    {
        #region Declaracion de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Catalogo_Bus BusCatalogo = new tb_Catalogo_Bus();
        cp_codigo_SRI_Bus BusCodigoSRI = new cp_codigo_SRI_Bus();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_TipoDocumento_Bus Bus_Documento = new cp_TipoDocumento_Bus();
        cp_TipoDocumento_Info Info_Documento = new cp_TipoDocumento_Info();
        public cp_TipoDocumento_Info Set_Documento { get; set; }
        public delegate void delegate_frmCP_TipoDocumento_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_TipoDocumento_Mant_FormClosing event_frmCP_TipoDocumento_Mant_FormClosing;

        #endregion


        List<cp_codigo_SRI_Info> List_Codigo_SRI = new List<cp_codigo_SRI_Info>();
        BindingList<cp_codigo_SRI_Info> BingdingListCodigo_SRI  = new BindingList<cp_codigo_SRI_Info>();

        public frmCP_TipoDocumento_Mant()
        {
            try
            {
                InitializeComponent();   
                List<tb_Catalogo_Info> LstTipoDoc = new List<tb_Catalogo_Info>();
                foreach (var item in BusCatalogo.Get_List_TipoDoc_Personales())
	            {
                    tb_Catalogo_Info o = new tb_Catalogo_Info();
                    o.ca_descripcion = item.descripcion;
                    o.CodCatalogo = item.codigo;
                    o.IdCatalogo = item.id;
                    LstTipoDoc.Add(o); gridViewTipodDOc.AddNewRow();
	            }
                gridControlTipoDoc.DataSource = new BindingList<tb_Catalogo_Info>() { new tb_Catalogo_Info(), new tb_Catalogo_Info(), new tb_Catalogo_Info() };
                cmbTipoDocumento.DataSource = LstTipoDoc;


                List_Codigo_SRI=BusCodigoSRI.Get_List_codigo_SRI ("COD_IDCREDITO");
                cmbTipoSustento.DataSource = List_Codigo_SRI;

                foreach (var item in List_Codigo_SRI)
                {
                    BingdingListCodigo_SRI.Add(new cp_codigo_SRI_Info());
                }
                gridControlTipoSustento.DataSource = BingdingListCodigo_SRI;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                  Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       void Set()
       {
           try
           {
               //txtIdDocumento.Text = Convert.ToString(Set_Documento.IdTipoDocumento);
               textCodigo.Text = Set_Documento.CodTipoDocumento;
               textNombreC.Text = Set_Documento.Descripcion;
               textCodigoSRI.Text = Set_Documento.CodSRI;
               txtOrden.Value = Set_Documento.Orden;
               checkDeclara.Checked = (Set_Documento.DeclaraSRI == "S") ? true : false;
               ckbGeneraRetencion.Checked = Set_Documento.GeneraRetencion == "S" ? true : false;
               chkEstado.Checked = Set_Documento.Estado == "A" ? true : false;
               if (Set_Documento.Estado == "I")
               {
                   chkEstado.Checked = false;
                   lblEstado.Visible = true;
               }
               else
               {
                   chkEstado.Checked = true;
                   lblEstado.Visible = false;
               }

               string[] TiposDoc = Set_Documento.Codigo_Secuenciales_Transaccion.Split(',');
               BindingList<tb_Catalogo_Info> Datos = new BindingList<tb_Catalogo_Info>();


               foreach (var item in TiposDoc)
               {
                   tb_Catalogo_Info o = new tb_Catalogo_Info();
                   if (item == "01")
                       o.ca_descripcion = "RUC";
                   if (item == "02")
                       o.ca_descripcion = "CED";
                   if (item == "03")
                       o.ca_descripcion = "PAS";
                   Datos.Add(o);
               }
               int numerodoc = BusCatalogo.Get_List_TipoDoc_Personales().Count;
               if (numerodoc != Datos.Count)
               {
                   int cantidad = numerodoc - Datos.Count;
                   for (int i = 0; i < cantidad; i++)
                   {
                       Datos.Add(new tb_Catalogo_Info());
                   }
               }
               gridControlTipoDoc.DataSource = Datos;

               string[] SustentoTributario_x_Documento = Set_Documento.Sustento_Tributario.Split(',');

               BingdingListCodigo_SRI = new BindingList<cp_codigo_SRI_Info>();
               foreach (var item in SustentoTributario_x_Documento)
               {
                   cp_codigo_SRI_Info InfoEncontrado = List_Codigo_SRI.FirstOrDefault(v => v.codigoSRI == item);
                   BingdingListCodigo_SRI.Add(InfoEncontrado);
               }

               for (int i = SustentoTributario_x_Documento.Count(); i < List_Codigo_SRI.Count(); i++)
               {
                   BingdingListCodigo_SRI.Add(new cp_codigo_SRI_Info());
               }
               gridControlTipoSustento.DataSource = BingdingListCodigo_SRI;
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       void Get_Documento()
        {
            try 
	        {	        
                //if (txtc .Text == "" || txtIdDocumento.Text == null)
                //{
                //    Info_Documento.IdTipoDocumento = 0;
                //}
                //else { Info_Documento.IdTipoDocumento = Convert.ToInt32(txtIdDocumento.Text); }
                Info_Documento.CodTipoDocumento = textCodigo.Text;
                Info_Documento.Descripcion = textNombreC.Text;
                Info_Documento.CodSRI = textCodigoSRI.Text;
                Info_Documento.Orden = Convert.ToInt32(txtOrden.Value);
                Info_Documento.GeneraRetencion = ckbGeneraRetencion.Checked ? "S" : "N"; 
                Info_Documento.DeclaraSRI = (checkDeclara.Checked == true) ? "S" : "N";
                Info_Documento.Estado = (chkEstado.Checked == true) ? "A" : "I";
                BindingList<tb_Catalogo_Info> Datos = (BindingList<tb_Catalogo_Info>)gridControlTipoDoc.DataSource;
                string TiposDocumentos = "";
                foreach (var item in Datos)
                {
                    if (item.ca_descripcion != null && item.ca_descripcion != "")
                    {
                        if (item.ca_descripcion == "RUC")
                            TiposDocumentos = TiposDocumentos + "01" + ",";
                        if (item.ca_descripcion == "CED")
                            TiposDocumentos = TiposDocumentos + "02" + ",";
                        if (item.ca_descripcion == "PAS")
                            TiposDocumentos = TiposDocumentos + "03" + ",";
                    }
                }
                Info_Documento.Codigo_Secuenciales_Transaccion = TiposDocumentos.Substring(0, TiposDocumentos.Length-1);
                //BindingList<cp_codigo_SRI_Info> ListDataSource = (BindingList<cp_codigo_SRI_Info>)gridControlTipoSustento.DataSource;
                string TipoSustento = "";
                foreach (var item in BingdingListCodigo_SRI)
                {
                    if (item.co_descripcion != null && item.co_descripcion != "")
                    TipoSustento = TipoSustento + item.codigoSRI + ",";
                }
                Info_Documento.Sustento_Tributario = TipoSustento.Substring(0, TipoSustento.Length - 1);
	        }
	        catch (Exception ex)
	        {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

       private void getparamAnular()
       {
           try
           {
               Info_Documento.Fecha_UltAnu = param.Fecha_Transac;
               Info_Documento.IdUsuarioUltAnu = param.IdUsuario;
               Info_Documento.nom_pc = param.nom_pc;
               Info_Documento.ip = param.ip;
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void getparamIng()
       {
           try
           {
               Info_Documento.IdUsuario = param.IdUsuario;
               Info_Documento.Fecha_Transac = param.Fecha_Transac;
               Info_Documento.nom_pc = param.nom_pc;
               Info_Documento.ip = param.ip;
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void getparamModifica()
       {
           try
           {
               Info_Documento.IdUsuarioUltMod = param.IdUsuario;
               Info_Documento.Fecha_UltMod = param.Fecha_Transac;
               Info_Documento.nom_pc = param.nom_pc;
               Info_Documento.ip = param.ip;
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       public void Guardar()
       {
           try
           {
                getparamIng();
                if (Bus_Documento.GuardarDB(ref Info_Documento))
                {
                    MessageBox.Show("Se ha Guardado con éxito el Registro : " + Info_Documento.CodTipoDocumento);
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu.Visible_btnGuardar = false;
                    LimpiarDatos();
                }
                else
                    return;
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       public void Actualizar()
       {
           try
           {
               getparamModifica();
               if (Bus_Documento.ModificarDB(Info_Documento))
               {
                   MessageBox.Show("Se ha Modificado con éxito el Registro: " + Info_Documento.CodTipoDocumento);
                   LimpiarDatos();
               }
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       Boolean Validar()
       {
           try
           {
               if (textCodigo.Text == null || textCodigo.Text.Trim() == "")
               {
                   MessageBox.Show("Por Favor Ingrese el Código del Documento");
                   return false;
               }

               if (textNombreC.Text == null || textNombreC.Text.Trim() == "")
               {
                   MessageBox.Show("Por Favor Ingrese la Descripción");
                   return false;
               }

               if (textCodigoSRI.Text == null || textCodigoSRI.Text.Trim() == "")
               {
                   MessageBox.Show("Por Favor Ingrese el Código SRI del Documento");
                   return false;
               }

               BindingList<tb_Catalogo_Info> Datos = (BindingList<tb_Catalogo_Info>)gridControlTipoDoc.DataSource;

               Dictionary<string, string> objtos = new Dictionary<string, string>();
               foreach (tb_Catalogo_Info item  in Datos)
               {
                   try
                   {if(item.ca_descripcion!= null && item.ca_descripcion!="")
                        objtos.Add(item.ca_descripcion, item.ca_descripcion);
                   }
                   catch (Exception)
                   {
                       MessageBox.Show("No pueden existir Tipos de documentos repetidos","Sistemas");
                       return false;
                   }
               }


               BindingList<cp_codigo_SRI_Info> ListDataSource = (BindingList<cp_codigo_SRI_Info>)gridControlTipoSustento.DataSource;
               Dictionary<string, string> objtoscodigo = new Dictionary<string, string>();
               foreach (cp_codigo_SRI_Info item in ListDataSource)
               {
                   try
                   {
                       if(item.co_descripcion!=null&& item.co_descripcion!="")
                       objtoscodigo.Add(item.co_descripcion, item.co_descripcion);
                   }
                   catch (Exception ex)
                   {
                       Log_Error_bus.Log_Error(ex.ToString());
                       MessageBox.Show("No pueden existir Tipos de Sustento repetidos o registros en blancos.\n Elimine los registros en blanco si hay","Sistemas");
                       return false;
                   }
               }

               return true;
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
           }
       }

       private void frmCP_TipoDocumento_Mant_Load(object sender, EventArgs e)
        {
             try
            {
                this.event_frmCP_TipoDocumento_Mant_FormClosing += new delegate_frmCP_TipoDocumento_Mant_FormClosing(frmCP_TipoDocumento_Mant_event_frmCP_TipoDocumento_Mant_FormClosing);
                
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        textCodigo.ReadOnly = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        textCodigo.ReadOnly = true;
                        textNombreC.ReadOnly = true;
                        textCodigoSRI.ReadOnly = true;
                        txtOrden.ReadOnly = true;
                        checkDeclara.Enabled = false;
                        ckbGeneraRetencion.Enabled = false;

                        gridViewTipodDOc.OptionsBehavior.Editable = false;
                        gridViewTipoSustento.OptionsBehavior.Editable = false;



                        Set();
                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    default:
                        break;


                }
             }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       void frmCP_TipoDocumento_Mant_event_frmCP_TipoDocumento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void textDescripcion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string mensaje = "";

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Bus_Documento.VericarCodigoExiste(textCodigo.Text.Trim(), ref mensaje) == true)
                    {
                        MessageBox.Show("Por favor cambie de código. Este código se encuentra asignado a: " + mensaje, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //txtIdDocumento.Text = "";
                        textCodigo.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void frmCP_TipoDocumento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              event_frmCP_TipoDocumento_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Documento();
                if (MessageBox.Show("Está Seguro que desea Anular el Documento ?", "Anulación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    getparamAnular();
                    if (Bus_Documento.AnularDB(Info_Documento))
                    {
                        MessageBox.Show("Anulado Existosamente ok");
                        lblEstado.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtOrden.Focus();
                Get_Documento();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    ucGe_Menu_event_btnGuardar_Click(sender,e);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
       {
           try
           {
               LimpiarDatos();
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       void LimpiarDatos()
       {
           try
           {
               Info_Documento = new cp_TipoDocumento_Info();
               set_Accion(Cl_Enumeradores.eTipo_action.grabar);

               textCodigo.Text = "";
               textNombreC.Text = "";
               textCodigoSRI.Text = "";
               txtOrden.Value = 0;
               ckbGeneraRetencion.Checked = true;
               checkDeclara.Checked = true;
               gridControlTipoDoc.DataSource = new BindingList<tb_Catalogo_Info>();
               gridControlTipoSustento.DataSource = new BindingList<cp_codigo_SRI_Info>();
        
              
           }
           catch (Exception ex)
           { 
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void gridViewTipoSustento_KeyDown(object sender, KeyEventArgs e)
       {
           try
           {
               if (e.KeyValue == (char)Keys.Delete)
               {
                   if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                   {
                       gridViewTipoSustento.DeleteRow(gridViewTipoSustento.FocusedRowHandle);
                   }
               }
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
           }
       }
    }
}
