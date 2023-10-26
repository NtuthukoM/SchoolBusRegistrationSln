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
    public class TransportRequestService : ITransportRequestService
    {
        private readonly IMapper mapper;
        private readonly SchoolBusRegistrationContext context;

        public TransportRequestService(IMapper mapper, SchoolBusRegistrationContext context)
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
                Age = transportRequestViewModel.Age.Value,
                GradeId = transportRequestViewModel.GradeId.Value,
                Parent = parent
            };
            var transportRequest = new TransportRequest()
            {
                Child = child,
                StartDate = transportRequestViewModel.StartDate.Value,
                TransportType = transportRequestViewModel.TransportType.Value
            };
            context.TransportRequests.Add(transportRequest);
            context.SaveChanges();

        }

        public TransportRequestViewModel GetTransportRequest(int id)
        {
            return context.TransportRequests
                .ProjectTo<TransportRequestViewModel>(mapper.ConfigurationProvider)
                .FirstOrDefault(x => x.Id == id);
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
