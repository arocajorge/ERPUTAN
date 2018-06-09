using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Academico
{
    public class Aca_tipo_mecanismo_de_pago_Bus
    {
        Aca_Tipo_mecanismo_de_pago_Data oData = new Aca_Tipo_mecanismo_de_pago_Data();
        public List<Aca_Tipo_mecanismo_de_pago_Info> Get_Lista_tipo_mecanismo_Pago()
        {
            try
            {
                return oData.Get_Lista_tipo_mecanismo_Pago();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Mecanismo_Pago", ex.Message), ex) { EntityType = typeof(Aca_tipo_mecanismo_de_pago_Bus) };
            }
        }

        public List<Aca_Tipo_mecanismo_de_pago_Info> Get_Lista_tipo_mecanismo_Pago_x_Banco(decimal idBanco)
        {
            try
            {
                return oData.Get_Lista_tipo_mecanismo_Pago_x_Banco(idBanco);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_tipo_mecanismo_Pago_x_Banco", ex.Message), ex) { EntityType = typeof(Aca_tipo_mecanismo_de_pago_Bus) };
            }
        }

        public Aca_Tipo_mecanismo_de_pago_Info Get_Info_tipo_mecanismo_Pago(int IdTipoMecaPago)
        {
            try
            {
                return oData.Get_Info_tipo_mecanismo_Pago(IdTipoMecaPago);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Mecanismo_Pago", ex.Message), ex) { EntityType = typeof(Aca_tipo_mecanismo_de_pago_Bus) };
            }
        }

    }
}
