using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EscapedCake.Entities
{
    public class BUser
    {

        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
        public string Passwd { get; set; }
        public int Phone { get; set; }
        public DateTime CreatedDate { get; set; }


        public BUser(int id, string firstName, string lastName, string email, string passwd, int phone, DateTime createdDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Passwd = passwd;
            Phone = phone;
            CreatedDate = createdDate;
        }

        public BUser(string firstName, string lastName, string email, string passwd, int phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Passwd = passwd;
            Phone = phone;
        }
    }
}
