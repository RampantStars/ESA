using BLL.Interfaces;
using BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESA.MVVM.ViewModel
{
    public class AccountViewModel
    {
        IDbOperations dbOperations;

        public AccountViewModel(IDbOperations dbOperations)
        {
            this.dbOperations = dbOperations;
            User = dbOperations.GetUser(1);
        }

        public UserModel User { get; set; }
    }
}
