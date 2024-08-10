using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeniAcunmedyaLisesi.Models.Dto;
using YeniAcunmedyaLisesi.Models.Models;

namespace AcunmedyaUzmanlık.Business.Shared.Service.Abstract
{
    public interface IUserService : IService<User>
    {
        User Login(LoginDto loginDto);
    }
}
