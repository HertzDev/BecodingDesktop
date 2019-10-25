using BecodingDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Interfaces.General
{
    public interface ICatalogBase
    {
        List<T> GetResults<T>(Func<DataRow,T> mapper,string[,] parameters, string procedure);
        MessageModel SetItem(string[,] parameters, string procedure);

    }
}
