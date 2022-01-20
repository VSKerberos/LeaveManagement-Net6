using AutoMapper;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
