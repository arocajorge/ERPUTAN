using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_Sucursal_Bodega : UserControl
    {
      

        #region declaracion de delegados
        public delegate void delegate_cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e);
        public delegate void delegate_cmb_bodega_SelectedIndexChanged(object sender, EventArgs e);
        public delegate void delegate_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e);
        public delegate void delegate_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e);

        public event delegate_cmb_sucursal_SelectedIndexChanged Event_cmb_sucursal_SelectedIndexChanged;
        public event delegate_cmb_bodega_SelectedIndexChanged Event_cmb_bodega_SelectedIndexChanged;
        public event delegate_cmb_sucursal_SelectionChangeCommitted Event_cmb_sucursal_SelectionChangeCommitted;
        public event delegate_cmb_bodega_SelectionChangeCommitted Event_cmb_bodega_SelectionChangeCommitted;


        public delegate void delegate_cmb_sucursal1_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_sucursal1_EditValueChanged Event_cmb_sucursal1_EditValueChanged;

        public delegate void delegate_cmb_bodega1_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_bodega1_EditValueChanged Event_cmb_bodega1_EditValueChanged;

        #endregion

        #region declaracion de objetos
        tb_Sucursal_Bus sucuB = new tb_Sucursal_Bus();
        tb_Bodega_Bus bodeB = new tb_Bodega_Bus();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        List<tb_Bodega_Info> listBodega = new List<tb_Bodega_Info>();
        
        tb_Sucursal_Info  _SucursalInfo = new tb_Sucursal_Info();
        tb_Bodega_Info  _BodegaInfo = new tb_Bodega_Info();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        #region metodos get


        public int get_IdSucursal()
        {
            try
            {
                return _SucursalInfo.IdSucursal;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }
        }

        public tb_Sucursal_Info get_sucursal()
        
        {
            try
            {
                return _SucursalInfo;
            }
            catch (Exception ex) 
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_Sucursal_Info();
            }
        }

        public tb_Bodega_Info get_bodega()
        {
            try
            {
                return _BodegaInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_Bodega_Info();
            }
        }

        public int  get_IdBodega()
        {
            try
            {
                return _BodegaInfo.IdBodega;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }
        }

        #endregion

        public Cl_Enumeradores.eTipoFiltro TipoCarga { get; set; }

        public bool Visible_cmb_bodega { get { return (this.lblBodega.Visible && this.cmb_bodega.Visible); } set { this.lblBodega.Visible = this.cmb_bodega.Visible = value; } }
        

        #region metodos set

        

        public void InicializarSucursal()
        {
            try
            {
                cmb_sucursal.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void InicializarBodega()
        {
            try
            {
                cmb_bodega.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Idsucursal(int  idsucursal)
        {
            try
            {

                cmb_sucursal.EditValue = idsucursal;
        
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
       
        public void set_Idbodega (int IdSucursal, int  IdBodega)
        {
            try
            {
                    cmb_sucursal.EditValue = IdSucursal;
                    cmb_bodega.EditValue = IdBodega;

                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_sucursal(tb_Sucursal_Info InfoSucursal)
        {
            try
            {

                cmb_sucursal.EditValue = InfoSucursal.IdSucursal;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_bodega(tb_Bodega_Info InfoBodega)
        {
            try
            {
                cmb_sucursal.EditValue = InfoBodega.IdSucursal;
                cmb_bodega.EditValue = InfoBodega.IdBodega;


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        #region constructor
        public UCIn_Sucursal_Bodega()
        {
            try
            {
                InitializeComponent();
                if (TipoCarga == null)
                { TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal; }

                Event_cmb_sucursal1_EditValueChanged += UCIn_Sucursal_Bodega_Event_cmb_sucursal1_EditValueChanged;
                Event_cmb_bodega1_EditValueChanged += UCIn_Sucursal_Bodega_Event_cmb_bodega1_EditValueChanged;


                this.Event_cmb_bodega_SelectedIndexChanged += new delegate_cmb_bodega_SelectedIndexChanged(UCIn_Sucursal_Bodega_Event_cmb_bodega_SelectedIndexChanged);
                this.Event_cmb_sucursal_SelectedIndexChanged += new delegate_cmb_sucursal_SelectedIndexChanged(UCIn_Sucursal_Bodega_Event_cmb_sucursal_SelectedIndexChanged);
                this.Event_cmb_sucursal_SelectionChangeCommitted += UCIn_Sucursal_Bodega_Event_cmb_sucursal_SelectionChangeCommitted;
                this.Event_cmb_bodega_SelectionChangeCommitted += new delegate_cmb_bodega_SelectionChangeCommitted(UCIn_Sucursal_Bodega_Event_cmb_bodega_SelectionChangeCommitted);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());              
            }            
        }

        void UCIn_Sucursal_Bodega_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void UCIn_Sucursal_Bodega_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region eventos delegados
        public void UCIn_Sucursal_Bodega_Event_cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e) { }
        public void UCIn_Sucursal_Bodega_Event_cmb_bodega_SelectedIndexChanged(object sender, EventArgs e) { }
        void UCIn_Sucursal_Bodega_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e) { }
        void UCIn_Sucursal_Bodega_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e) { }
        #endregion
        
        public void UCIn_Sucursal_Bodega_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_sucursal(param.IdEmpresa);
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        #region carga de lista de combos

        public void cargar_sucursal(int idEmpresa)
        {
            try
            {
                if (TipoCarga == Cl_Enumeradores.eTipoFiltro.Normal)
                {
                    listSucursal = sucuB.Get_List_Sucursal(idEmpresa);
                }


                if (TipoCarga == Cl_Enumeradores.eTipoFiltro.todos)
                {
                    listSucursal = sucuB.Get_List_Sucursal_Todos(idEmpresa);
                }

                cargar_bodega(param.IdEmpresa);
                listSucursal.ForEach(v => { v.Su_Descripcion = "[" + v.IdSucursal + "]-" + v.Su_Descripcion; });
                this.cmb_sucursal.Properties.DataSource = listSucursal;
                cmb_sucursal.Properties.DisplayMember = "Su_Descripcion";
                cmb_sucursal.Properties.ValueMember = "IdSucursal";
                //cmb_sucursal.EditValue = listSucursal.First().IdSucursal;              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cargar_bodega(int IdEmpresa)
        {
            try
            {
                if (TipoCarga == Cl_Enumeradores.eTipoFiltro.Normal)
                {
                    listBodega = bodeB.Get_List_Bodega(IdEmpresa);
                }
                if (TipoCarga == Cl_Enumeradores.eTipoFiltro.todos)
                {
                    listBodega = bodeB.Get_List_Bodega(IdEmpresa,TipoCarga);
                }            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        List<tb_Bodega_Info> lbodega ;

        public void cargar_bodega_en_Combo(int IdEmpresa, int IdSucursal)
        {
            try
            {

              // List<tb_Bodega_Info> lbodega = new List<tb_Bodega_Info>();
                lbodega = new List<tb_Bodega_Info>();
               var qbodega = from bo in listBodega
                             where bo.IdEmpresa == IdEmpresa  && bo.IdSucursal == IdSucursal
                              select bo;
               //if (TipoCarga == Cl_Enumeradores.eTipoFiltro.todos)
               //{
               //    tb_Bodega_Info info = new tb_Bodega_Info();
               //    info.bo_Descripcion = "todas las bodegas";
               //    info.IdBodega = 0;
               //    lbodega.Add(info);
               //}
               foreach (tb_Bodega_Info item in qbodega)
                {
                    tb_Bodega_Info obodega= new tb_Bodega_Info();
                    obodega.bo_Descripcion = "[" + item.IdBodega+ "]-" + item.bo_Descripcion;
                    obodega.bo_esBodega = item.bo_esBodega;
                    obodega.cod_bodega = item.cod_bodega;
                    obodega.bo_manejaFacturacion = item.bo_manejaFacturacion;
                    obodega.cod_punto_emision = item.cod_punto_emision;
                    obodega.Estado = item.Estado;
                    obodega.IdBodega = item.IdBodega;
                    obodega.IdEmpresa = item.IdEmpresa;
                    obodega.IdSucursal = item.IdSucursal;
                    lbodega.Add(obodega);
               }
               if (lbodega != null)
               {
                   if (lbodega.Count != 0)
                   {
                       cmb_bodega.Properties.DataSource = lbodega;
                       cmb_bodega.Properties.DisplayMember = "bo_Descripcion";
                       cmb_bodega.Properties.ValueMember = "IdBodega";
                       //cmb_bodega.EditValue = lbodega.FirstOrDefault().IdBodega;
                   }
                   else
                   {
                       MessageBox.Show("La sucursal seleccionada no tiene bodegas asignadas.\nEscoja una sucursal con bodegas", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       cmb_bodega.Properties.DataSource = null;
                   }
               }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }       

        #endregion

        public void Bloquerar_Combos()
        {
            try
            {
               this.cmb_sucursal.Properties.ReadOnly = true;
               this.cmb_bodega.Properties.ReadOnly = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }        
        
        }

        public void Campos_consulta(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        cmb_bodega.Properties.ReadOnly = false;
                        cmb_sucursal.Properties.ReadOnly = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        cmb_bodega.Properties.ReadOnly = true;
                        cmb_sucursal.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        cmb_bodega.Properties.ReadOnly = true;
                        cmb_sucursal.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        cmb_bodega.Properties.ReadOnly = true;
                        cmb_sucursal.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        private void cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _SucursalInfo = (tb_Sucursal_Info)(listSucursal.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmb_sucursal.EditValue)));
                if (_SucursalInfo != null)
                {
                    cmb_bodega.EditValue = null;
                    cargar_bodega_en_Combo(_SucursalInfo.IdEmpresa, _SucursalInfo.IdSucursal);
                    // this.Event_cmb_sucursal_SelectedIndexChanged(sender, e);
                    
                    Event_cmb_sucursal1_EditValueChanged(sender, e);
                }
                else
                    InicializarBodega();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _BodegaInfo = (tb_Bodega_Info)(listBodega.FirstOrDefault(v =>v.IdSucursal == Convert.ToInt32(cmb_sucursal.EditValue) && v.IdBodega == Convert.ToInt32(cmb_bodega.EditValue)));               
                Event_cmb_bodega1_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
