using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_WEB_DocumentReader.Domain.Core.Interfaces
{
    public interface ILocalStorageService
    {
        Task<T> GetItem<T>(string key);
        Task SetItem<T>(string key, T value);
        Task RemoveItem(string key);
    }
}
