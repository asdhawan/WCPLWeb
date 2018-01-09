using AutoMapper;

namespace WCPLWebClasses {
    public class AutoMapperProfile : Profile {
        public AutoMapperProfile() {
            CreateMap<Player, WCPLWebEntities.Player>();
            CreateMap<SpecialEvent, WCPLWebEntities.SpecialEvent>();
            CreateMap<ExternalLeague, WCPLWebEntities.ExternalLeague>();
        }
    }
}
