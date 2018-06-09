using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Facturacion
{
   public class fa_formaPago_Data
    {

        string mensaje = "";


        public List<fa_formaPago_Info> Get_List_fa_formaPago()
        {
            try
            {
                List<fa_formaPago_Info> Lst = new List<fa_formaPago_Info>();
                EntitiesFacturacion oEnti = new EntitiesFacturacion();
                var Query = from q in oEnti.fa_formaPago
                            select q;

                

                foreach (var item in Query)
                {
                    fa_formaPago_Info Obj = new fa_formaPago_Info();
                    Obj.IdFormaPago = item.IdFormaPago;
                    Obj.nom_FormaPago = item.nom_FormaPago;
                    
                
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(fa_formaPago_Info Info,  ref string msjError)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var Address = new fa_formaPago();

                    Address.IdFormaPago = Info.IdFormaPago;
                    Address.nom_FormaPago = Info.nom_FormaPago;

                    Context.fa_formaPago.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(fa_formaPago_Info info, ref string msjError)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                var contenido = context.fa_formaPago.FirstOrDefault(var => var.IdFormaPago == info.IdFormaPago);
                if (contenido != null)
                {
                    contenido.nom_FormaPago = info.nom_FormaPago;

                    
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }


    }
}
