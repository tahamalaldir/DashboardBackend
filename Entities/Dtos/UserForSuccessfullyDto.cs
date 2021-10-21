using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Entities.Concrete;

namespace Entities.Dtos
{
    public class UserForSuccessfullyDto : IDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public Boolean IsApproved { get; set; }
        public int RoleId { get; set; }
        public string Token { get; set; }
    }
}
