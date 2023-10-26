using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Core.MappingProfile
{
    public class SchoolBusMappingProfile:Profile
    {
        public SchoolBusMappingProfile()
        {
            CreateMap<SchoolBusRegistration.Domain.Grade, SchoolBusRegistration.Core.ViewModels.GradeViewModel>()
                .ReverseMap();
            CreateMap<Domain.TransportRequest, ViewModels.TransportRequestViewModel>()
                .ForMember(destinationMember => destinationMember.GradeName, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.Child.Grade.Title))
                .ForMember(destinationMember => destinationMember.ChildName, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.Child.Name))
                .ForMember(destinationMember => destinationMember.ParentName, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.Child.Parent.Name))
                .ReverseMap();
        }
    }
}
