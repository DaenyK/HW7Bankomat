using Astana.BLL.ModelAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astana.BLL.ModelClient
{
   public  class Client
    {
        public Client():this("","")
        {
            acounts = new List<Account>();
        }
        public Client (string login, string password)
        {
            this.login = login;
            this.password= password;
        }

        public string login { get; set; }
        public string password {get; set; }

        public List<Account> acounts;

        
    }
}
