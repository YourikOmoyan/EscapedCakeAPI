using System;
using DBconnectionTool;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using DAL.EscapedCake.Entities;
using DAL.EscapedCake.Mapper;
using System.ComponentModel;

namespace DAL.EscapedCake.Services
{
    public class DUserService
    {

        private readonly DbConnection _connextion;

        public DUserService(DbConnection connextion)
        {
            _connextion = connextion;
        }


        public void AddUser(DUser entity)
        {
            try
            {
                _connextion.ExecuteNonQuery("YSP_newUser", true, new { entity.FirstName, entity.LastName, entity.Email, entity.Passwd, entity.Phone });
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public DUser? AuthUser(string email , string passwd)
        {
            return _connextion.ExecuteReader("YSP_authUser", reader => reader.ToUser(), true, new { email, password = passwd }).SingleOrDefault();
        }






    }
}

