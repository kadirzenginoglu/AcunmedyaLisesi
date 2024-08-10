using AcunmedyaLisesi.Repository.Shared.Abstract;
using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Concrete;
using AcunmedyaUzmanlık.Business.Shared.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeniAcunmedyaLisesi.Models.Dto;
using YeniAcunmedyaLisesi.Models.Models;

namespace AcunmedyaUzmanlık.Business.Shared.Service.Concrete
{
    public class UserService : Service<User>, IUserService
    {
        private readonly IRepository<User> _repo;

        public UserService(IRepository<User> repo) : base(repo)
        {
            _repo = repo;
        }

        public User Login(LoginDto loginDto)
        {
           return _repo.GetFirstOrDefault(x => x.Email == loginDto.Email && x.Password == loginDto.Password);

        }
    }
}
