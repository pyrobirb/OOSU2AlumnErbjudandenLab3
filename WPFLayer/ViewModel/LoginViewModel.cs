using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.ViewModel
{
    public class LoginViewModel
    {

        #region AutoMapperConfig

        public void AutoMapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AlumnContextProfile>();

            });
            var mapper = config.CreateMapper();
        }
        #endregion
    }
}
