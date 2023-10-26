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
                .ForMember(destinationMember => destinationMember.IdentityNumber, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.Child.Parent.IdentityNumber))
                .ForMember(destinationMember => destinationMember.PhoneNumber, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.Child.Parent.PhoneNumber))
                .ForMember(destinationMember => destinationMember.EmailAddress, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.Child.Parent.EmailAddress))
                .ForMember(destinationMember => destinationMember.Address, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.Child.Parent.Address))
                .ForMember(destinationMember => destinationMember.Age, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.Child.Age))
                .ForMember(destinationMember => destinationMember.GradeId, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.Child.GradeId))
                .ForMember(destinationMember => destinationMember.ChildId, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.ChildId))
                .ForMember(destinationMember => destinationMember.ParentId, memberOptions => memberOptions.MapFrom(sourceMember => sourceMember.Child.ParentId))
                .ReverseMap();
        }
    }
}
