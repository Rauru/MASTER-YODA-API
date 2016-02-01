using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterYodaAPI.DataAdapterLayer.Interfaces
{
    public class UserInterfaces
    {
        public void addUser(string _correo)
        {
            var db = new MasterYodaAPIContext();
            var newUser = new User {correo = _correo};
            db.Users.Add(newUser);
            db.SaveChanges();
        }
    }
}
