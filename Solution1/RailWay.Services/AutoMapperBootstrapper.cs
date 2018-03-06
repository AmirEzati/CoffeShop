using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace RailWayCoffee.Services
{
    public class AutoMapperBootStrapper
    {
        public static IMapper fbMapper;
        public static void ConfigureAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<Source,Destination>();
            });

            fbMapper = config.CreateMapper();
        }
    }
}
