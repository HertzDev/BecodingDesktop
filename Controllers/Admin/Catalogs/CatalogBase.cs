using BecodingDesktop.Helpers;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace BecodingDesktop.Controllers.Admin.Catalogs
{
    public class CatalogBase : ICatalogBase
    {
        DataSet result;

        public List<T> GetResults<T>(Func<DataRow, T> mapper, string[,] parameters,string procedure)
        {
            List<T> results = new List<T>();
            try
            {
                result = BDConnection.Instance.RunStoreProcedure(procedure, parameters);
                if (result != null && result.Tables != null && result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in result.Tables[0].Rows)
                    {
                        results.Add(mapper(row));
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }

        public MessageModel SetItem(string[,] parameters, string procedure)
        {
            MessageModel message = null;
            try
            {
                result = BDConnection.Instance.RunStoreProcedure(procedure, parameters);
                if (result != null && result.Tables != null && result.Tables.Count>0 && result.Tables[0].Rows.Count > 0)
                {
                    var value = (Convert.ToInt32(result.Tables[0].Rows[0].ItemArray[0].ToString()));
                    message = new MessageModel()
                    {
                        Code = value>0?200:500,
                        Message = value > 0 ? "El proceso finalizo con exito" : "Ocurrio un error durante el proceso"
                    };
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }
    }
}
