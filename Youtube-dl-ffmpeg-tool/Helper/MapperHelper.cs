using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_dl_ffmpeg_tool.Helper
{
    public class MapperHelper
    {
        private static IMapper mapper;
        public static IMapper Mapper { 
            get 
            {
                if(mapper == null)
                {
                    var config = new MapperConfiguration(conf =>
                    {
                        conf.AddProfile(new MappingProfile());
                    });
                    mapper = config.CreateMapper();
                }
                return mapper;
            } 
            set { mapper = value; } }
        private MapperHelper()
        {
        }
    }
}
