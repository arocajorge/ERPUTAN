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

using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;



namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_Sucursal_PtoVta_cmb : UserControl
    {

        

        public Cl_Enumeradores.eTipoFiltro TipoCarga { get; set; }

        public UCFa_Sucursal_PtoVta_cmb()
        {
            try
            {
                InitializeComponent();
                if (TipoCarga == null)
                { TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal; }

                Event_cmb_sucursal_EditValueChanged += UCIn_Sucursal_Bodega_Event_cmb_sucursal_EditValueChanged;
                Event_cmb_PtoVta_EditValueChanged += UCIn_Sucursal_Bodega_Event_cmb_PtoVta_EditValueChanged;


                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }  
        }



        #region declaracion de delegados

                
                
                public delegate void delegate_cmb_sucursal_EditValueChanged(object sender, EventArgs e);
                public event delegate_cmb_sucursal_EditValueChanged Event_cmb_sucursal_EditValueChanged;

                public delegate void delegate_cmb_PtoVta_EditValueChanged(object sender, EventArgs e);
                public event delegate_cmb_PtoVta_EditValueChanged Event_cmb_PtoVta_EditValueChanged;


        #endregion

        #region declaracion de objetos

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        tb_Sucursal_Bus BusSucu = new tb_Sucursal_Bus();
        fa_PuntoVta_Bus BusPtoVta = new fa_PuntoVta_Bus();
       

        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        List<fa_PuntoVta_Info> listPuntoVta = new List<fa_PuntoVta_Info>();
        
        tb_Sucursal_Info  Info_Sucursal = new tb_Sucursal_Info();
        fa_PuntoVta_Info Info_PuntoVta = new fa_PuntoVta_Info();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        #endregion

        #region metodos get



        public int get_IdSucursal()
        {
            try
            {
                return Info_Sucursal.IdSucursal;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }
        }

        public tb_Sucursal_Info get_Info_Sucursal()
        
        {
            try
            {
                return Info_Sucursal;
            }
            catch (Exception ex) 
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_Sucursal_Info();
            }
        }


        public fa_PuntoVta_Info get_Info_PuntoVta()
        {
            try
            {
                return Info_PuntoVta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_PuntoVta_Info();
            }
        }


        public int get_IdPuntoVta()
        {
            try
            {
                return Info_PuntoVta.IdPuntoVta;
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

        public void InicializarPtoVta()
        {
            try
            {
                cmb_PtoVta.EditValue = null;
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
       
        public void set_IdPuntoVta_ (int IdSucursal, int  IdPtoVta)
        {
            try
            {
                    cmb_sucursal.EditValue = IdSucursal;
                    cmb_PtoVta.EditValue = IdPtoVta == 0 ? 1 : IdPtoVta;
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

        public void set_PuntoVta(fa_PuntoVta_Info InfoPtoVta)
        {
            try
            {
                cmb_sucursal.EditValue = InfoPtoVta.IdSucursal;
                cmb_PtoVta.EditValue = InfoPtoVta.IdPuntoVta;
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
       

        void UCIn_Sucursal_Bodega_Event_cmb_PtoVta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_PtoVta.EditValue != null)
                {

                    Info_PuntoVta = (fa_PuntoVta_Info)(listPuntoVta.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmb_sucursal.EditValue) && v.IdPuntoVta == Convert.ToInt32(cmb_PtoVta.EditValue)));
                    //Event_cmb_PtoVta_EditValueChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void UCIn_Sucursal_Bodega_Event_cmb_sucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Info_Sucursal = (tb_Sucursal_Info)(listSucursal.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmb_sucursal.EditValue)));
                if (Info_Sucursal != null)
                {
                    cargar_PtoVta_en_Combo(Info_Sucursal.IdEmpresa, Info_Sucursal.IdSucursal);
                    //Event_cmb_sucursal_EditValueChanged(sender, e);
                }
                else
                    InicializarPtoVta();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        
        
        #region carga de lista de combos

        public void cargar_sucursal(int idEmpresa)
        {
            try
            {
                if (TipoCarga == Cl_Enumeradores.eTipoFiltro.Normal)
                {
                    listSucursal = BusSucu.Get_List_Sucursal(idEmpresa);
                }


                if (TipoCarga == Cl_Enumeradores.eTipoFiltro.todos)
                {
                    listSucursal = BusSucu.Get_List_Sucursal_Todos(idEmpresa);
                }

                cargar_PtoVta(param.IdEmpresa);
                listSucursal.ForEach(v => { v.Su_Descripcion = "[" + v.IdSucursal + "]-" + v.Su_Descripcion; });
                this.cmb_sucursal.Properties.DataSource = listSucursal;
                cmb_sucursal.Properties.DisplayMember = "Su_Descripcion";
                cmb_sucursal.Properties.ValueMember = "IdSucursal";

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cargar_PtoVta(int IdEmpresa)
        {
            try
            {
                if (TipoCarga == Cl_Enumeradores.eTipoFiltro.Normal)
                {
                    listPuntoVta = BusPtoVta.Get_List_PuntoVta(IdEmpresa);
                }

                if (TipoCarga == Cl_Enumeradores.eTipoFiltro.todos)
                {
                    listPuntoVta = BusPtoVta.Get_List_PuntoVta(IdEmpresa);
                    listPuntoVta.Add(new fa_PuntoVta_Info(IdEmpresa, 0, 0, "Todos", "Todos",1));
                }            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        

        public void cargar_PtoVta_en_Combo(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<fa_PuntoVta_Info> listDS_PtoVta = new List<fa_PuntoVta_Info>();

                var qPtoVta = from bo in listPuntoVta
                             where bo.IdEmpresa == IdEmpresa  
                             && bo.IdSucursal == IdSucursal
                              select bo;

                foreach (fa_PuntoVta_Info item in qPtoVta)
                {
                    fa_PuntoVta_Info obodega = new fa_PuntoVta_Info();

                    obodega.IdEmpresa = item.IdEmpresa;
                    obodega.IdSucursal = item.IdSucursal;
                    obodega.IdPuntoVta = item.IdPuntoVta;
                    obodega.cod_PuntoVta = item.cod_PuntoVta;
                    obodega.nom_PuntoVta2 = "[" + item.IdPuntoVta + "]-" + item.nom_PuntoVta;
                    obodega.nom_PuntoVta = item.nom_PuntoVta;
                    obodega.estado = item.estado;
                    
                    listDS_PtoVta.Add(obodega);
               }
                if (listDS_PtoVta != null)
               {
                   if (listDS_PtoVta.Count != 0)
                   {
                       cmb_PtoVta.Properties.DataSource = listDS_PtoVta;
                       cmb_PtoVta.Properties.DisplayMember = "nom_PuntoVta2";
                       cmb_PtoVta.Properties.ValueMember = "IdPuntoVta";
                       cmb_PtoVta.EditValue = listDS_PtoVta.FirstOrDefault().IdPuntoVta;
                   }
                   else
                   {
                       MessageBox.Show("La sucursal seleccionada no tiene Punto de Ventas asignadas.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                       cmb_PtoVta.Properties.DataSource = null;
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
               this.cmb_PtoVta.Properties.ReadOnly = true;
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
                        cmb_PtoVta.Properties.ReadOnly = false;
                        cmb_sucursal.Properties.ReadOnly = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        cmb_PtoVta.Properties.ReadOnly = true;
                        cmb_sucursal.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        cmb_PtoVta.Properties.ReadOnly = true;
                        cmb_sucursal.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        cmb_PtoVta.Properties.ReadOnly = true;
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
      
        private void UCFa_Sucursal_PtoCargo_cmb_Load(object sender, EventArgs e)
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
    }

}
