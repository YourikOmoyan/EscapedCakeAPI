using BLL.EscapedCake.Entities;
using BLL.EscapedCake.Mapper;
using DAL.EscapedCake.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EscapedCake.Services
{
    public class BUserService
    {
        private readonly DUserService _userService;

        public BUserService(DUserService userService)
        {
            _userService = userService;
        }

        public void Adduser(BUser entity)
        {
            _userService.AddUser(entity.ToDal());
        }

        public BUser? AuthUser(string email, string passwd)
        {
            return _userService.AuthUser(email, passwd)?.ToBll();
        }
    }
}
