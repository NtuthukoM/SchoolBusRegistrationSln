using AutoMapper;
using AutoMapper.QueryableExtensions;
using SchoolBusRegistration.Core.ViewModels;
using SchoolBusRegistration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Core.Services
{
    public class TansportRequestService : ITansportRequestService
    {
        private readonly IMapper mapper;
        private readonly SchoolBusRegistrationContext context;

        public TansportRequestService(IMapper mapper, SchoolBusRegistrationContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public void AddTransportRequest(TransportRequestFormViewModel transportRequestViewModel)
        {
            //create and insert 'parent', 'child' and 'transportrequest' from view model:
            var parent = new Parent
            {
                Name = transportRequestViewModel.ParentName,
                EmailAddress = transportRequestViewModel.EmailAddress,
                PhoneNumber = transportRequestViewModel.PhoneNumber,
                IdentityNumber = transportRequestViewModel.IdentityNumber,
                Address = transportRequestViewModel.Address
            };

            var child = new Child()
            {
                Name = transportRequestViewModel.ChildName,
                Age = transportRequestViewModel.Age,
                GradeId = transportRequestViewModel.GradeId.Value,
                Parent = parent
            };
            var transportRequest = new TransportRequest()
            {
                Child = child,
                StartDate = transportRequestViewModel.StartDate,
                TransportType = transportRequestViewModel.TransportType
            };
            context.TransportRequests.Add(transportRequest);
            context.SaveChanges();

        }

        public List<TransportRequestViewModel> GetTransportRequests()
        {
            return context.TransportRequests
                .ProjectTo<TransportRequestViewModel>(mapper.ConfigurationProvider)
                .ToList();
        }

        public void UpdateTransportRequest(TransportRequestFormViewModel transportRequestViewModel)
        {
            //Nobody home!
            throw new NotImplementedException();
        }
    }
}
