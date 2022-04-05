using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management
{
    public class AccountLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<AccountLevel> GetAccountLevel()
        {
            return new List<AccountLevel>
            {
                new AccountLevel {Id = 0 , Name = "User" },
                new AccountLevel {Id = 1 , Name = "Admin"}
            };
        }
    }
}
