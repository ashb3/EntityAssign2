using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ECFAssignment2
{
    public class Repo
    {
        public List<User> ListAll()
        {
            var context = new DataContext();
            var list = new List<User>();
            list = context.Users.ToList();
            return list;
        }

        public void AddUser(User user)
        {
            var context = new DataContext();
            context.Users.Add(user);
            context.SaveChanges();
        }
        
        public void UpdateUser(User user)
        {
            var context = new DataContext();
            var foundUser = context.Users.Where(x => x.Id == user.Id).First();
            foundUser.PhoneNumber = 75777777;
            foundUser.Name = "Lir";
            foundUser.EmailAddress = "Lir@gmail.com";
            context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            var context = new DataContext();
            var foundUser = context.Users.Where(x => x.Id == user.Id).First();
            context.Remove(foundUser);
            context.SaveChanges();
        }

        

    }
}
