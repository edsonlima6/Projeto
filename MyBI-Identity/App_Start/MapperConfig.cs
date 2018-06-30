using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBI_Identity.App_Start
{
    public class MapperConfig
    {
        public static IMapper _Mapper { get; private set; }
        public static void RegisterMappings()
        {

            var config = new MapperConfiguration((mapper) =>
            {
                mapper.AddProfile<DomainToViewModelMappingProfile>();
                mapper.AddProfile<ViewModelToDomainMappingProfile>();
            });

            _Mapper = config.CreateMapper();


        }
    }
}