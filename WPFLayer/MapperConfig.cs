using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer
{
    public static class MapperConfig
    {
        private static IMapper mapper;

        public static IMapper GetMapper()
        {
            return mapper;
        }

        public static void SetMapper(IMapper value)
        {
            mapper = value;
        }
    }
}
