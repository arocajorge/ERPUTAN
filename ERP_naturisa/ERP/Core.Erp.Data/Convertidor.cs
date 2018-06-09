using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;


namespace Core.Erp
{
    public static class Convertidor<T> where T : new()
    {

        public static DataTable Convert(List<T> items)
        {
            try
            {


                // Instancia del objeto a devolver

                DataTable returnValue = new DataTable();

                // Información del tipo de datos de los elementos del List

                Type itemsType = typeof(T);

                // Recorremos las propiedades para crear las columnas del datatable

                foreach (PropertyInfo prop in itemsType.GetProperties())
                {

                    // Crearmos y agregamos una columna por cada propiedad de la entidad

                    DataColumn column = new DataColumn(prop.Name);

                    column.DataType = prop.PropertyType;

                    returnValue.Columns.Add(column);

                }



                int j;

                // ahora recorremos la colección para guardar los datos

                // en el DataTable

                foreach (T item in items)
                {

                    j = 0;

                    object[] newRow = new object[returnValue.Columns.Count];

                    // Volvemos a recorrer las propiedades de cada item para

                    // obtener su valor guardarlo en la fila de la tabla

                    foreach (PropertyInfo prop in itemsType.GetProperties())
                    {

                        newRow[j] = prop.GetValue(item, null);

                        j++;

                    }

                    returnValue.Rows.Add(newRow);

                }

                // Devolver el objeto creado

                return returnValue;

            }


            catch (Exception)
            {

                return null;
            }



        }
    }

}
