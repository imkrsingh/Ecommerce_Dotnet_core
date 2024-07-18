using AutoMapper;
using EFCoreTutorialConsole.Models.Responses;

namespace AutomapperDemo.Models
{
    public class MyMappingProfile : Profile
    {
        public MyMappingProfile()
        {
            //Configure the Mappings

            //Mapping Employee to EmployeeDTO
            //Source: Employee and Destination: EmployeeDTO
            CreateMap<Student, StudentDtoResponse>()
                .ForMember(dest => dest.FullName, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest=>dest.GradeName, act=> act.MapFrom(src=>src.Grade.GradeName))
                .ForMember(dest => dest.GradeDescription, act => act.MapFrom(src => src.Grade.GradeDescription))
                .ReverseMap();

            //Mapping EmployeeDTO to Employee
            //Source: EmployeeDTO and Destination: Employee
            CreateMap<Grade, GradeDto>()
                     .ForMember(dest => dest.GradeName, act => act.MapFrom(src => src.GradeDescription)).ReverseMap();
                 //.ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email)); ;



        }
    }
}