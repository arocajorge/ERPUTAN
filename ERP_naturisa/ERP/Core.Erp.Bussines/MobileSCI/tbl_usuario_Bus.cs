using Core.Erp.Data.MobileSCI;
using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.MobileSCI
{
    public class tbl_usuario_Bus
    {
        tbl_usuario_Data odata = new tbl_usuario_Data();

        public List<tbl_usuario_Info> get_list()
        {
            try
            {
                return odata.get_list();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool validar_existe_usuario(string IdUsuarioSCI)
        {
            try
            {
                return odata.validar_existe_usuario(IdUsuarioSCI);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool guardarDB(tbl_usuario_Info info)
        {
            try
            {
                return odata.guardarDB(info);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool modificarDB(tbl_usuario_Info info)
        {
            try
            {
                return odata.modificarDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool anularDB(tbl_usuario_Info info)
        {
            try
            {
                return odata.anularDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
