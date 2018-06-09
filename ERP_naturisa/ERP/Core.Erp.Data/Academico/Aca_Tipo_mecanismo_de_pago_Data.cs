using Core.Erp.Data.General;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Academico
{
    public class Aca_Tipo_mecanismo_de_pago_Data
    {
        string mensaje = "";
        public List<Aca_Tipo_mecanismo_de_pago_Info> Get_Lista_tipo_mecanismo_Pago()
        {
         try
            {
            List<Aca_Tipo_mecanismo_de_pago_Info> Lista = new List<Aca_Tipo_mecanismo_de_pago_Info>();
              Entities_Academico conex = new Entities_Academico();

               var meca = from q in conex.Aca_Tipo_Mecanismo_Pago
                              select q;
                foreach (var item in meca)
                {
                    Aca_Tipo_mecanismo_de_pago_Info info = new Aca_Tipo_mecanismo_de_pago_Info();
                    info.Id_tipo_meca_pago = item.Id_tipo_meca_pago;
                    info.Id_tb_banco_x_mgbanco = item.Id_tb_banco_x_mgbanco;
                    info.nombre = item.Nombre;
                    Lista.Add(info);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
         }

        public List<Aca_Tipo_mecanismo_de_pago_Info> Get_Lista_tipo_mecanismo_Pago_x_Banco(decimal idBanco)
        {
            try
            {
                List<Aca_Tipo_mecanismo_de_pago_Info> Lista = new List<Aca_Tipo_mecanismo_de_pago_Info>();
                Entities_Academico conex = new Entities_Academico();

                var meca = from q in conex.Aca_Tipo_Mecanismo_Pago
                           where q.Id_tb_banco_x_mgbanco == idBanco
                           select q;
                foreach (var item in meca)
                {
                    Aca_Tipo_mecanismo_de_pago_Info info = new Aca_Tipo_mecanismo_de_pago_Info();
                    info.Id_tipo_meca_pago = item.Id_tipo_meca_pago;
                    info.Id_tb_banco_x_mgbanco = item.Id_tb_banco_x_mgbanco;
                    info.nombre = item.Nombre;
                    Lista.Add(info);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        public Aca_Tipo_mecanismo_de_pago_Info Get_Info_tipo_mecanismo_Pago(int IdTipoMecaPago)
        {
            try
            {
                Aca_Tipo_mecanismo_de_pago_Info infoTipo = new Aca_Tipo_mecanismo_de_pago_Info();
                Entities_Academico conex = new Entities_Academico();

                var meca = from q in conex.Aca_Tipo_Mecanismo_Pago
                           where q.Id_tipo_meca_pago == IdTipoMecaPago
                           select q;
                foreach (var item in meca)
                {

                    infoTipo.Id_tipo_meca_pago = item.Id_tipo_meca_pago;
                    infoTipo.Id_tb_banco_x_mgbanco = item.Id_tb_banco_x_mgbanco;
                    infoTipo.nombre = item.Nombre;
                  
                }
                return infoTipo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
    }
}
