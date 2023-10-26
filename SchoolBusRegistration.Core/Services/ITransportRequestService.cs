using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolBusRegistration.Core.ViewModels;

namespace SchoolBusRegistration.Core.Services
{
    public interface ITransportRequestService
    {
        void AddTransportRequest(TransportRequestFormViewModel transportRequestViewModel);
        void UpdateTransportRequest(TransportRequestFormViewModel transportRequestViewModel);
        List<TransportRequestViewModel> GetTransportRequests();
        TransportRequestViewModel GetTransportRequest(int id);
    }
}
