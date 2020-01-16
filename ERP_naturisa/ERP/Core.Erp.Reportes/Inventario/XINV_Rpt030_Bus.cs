﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt030_Bus
    {
        XINV_Rpt030_Data Odata = new XINV_Rpt030_Data();
        public List<XINV_Rpt030_Info> Get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime fecha_corte)
        {
            try
            {
                return Odata.Get_list(IdEmpresa, IdSucursal, IdBodega, IdProducto, fecha_corte);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt030_Info>();
            }
        }
    }
}