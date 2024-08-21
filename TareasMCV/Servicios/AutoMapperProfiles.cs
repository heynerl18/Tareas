using AutoMapper;
using TareasMCV.Entidades;
using TareasMCV.Models;

namespace TareasMCV.Servicios
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Tarea, TareaDTO>();
        }
    }
}
