using ASP_WEB_DocumentReader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_WEB_DocumentReader.Domain.Core.Interfaces
{
    public interface IAlertService
    {
        event Action<Alert> OnAlert;
        void Success(string message, bool keepAfterRouteChange = false, bool autoClose = true);
        void Error(string message, bool keepAfterRouteChange = false, bool autoClose = true);
        void Info(string message, bool keepAfterRouteChange = false, bool autoClose = true);
        void Warn(string message, bool keepAfterRouteChange = false, bool autoClose = true);
        void Alert(Alert alert);
        void Clear(string id = null);
    }

    
}
