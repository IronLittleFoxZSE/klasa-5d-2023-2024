using LoginWpfApp.Database.Context;
using LoginWpfApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWpfApp.Database.Repository
{
    class DatabaseRepository
    {
        private DatabaseContext databaseContext = new DatabaseContext();

        public bool CheckUserIsRegistered(string login, string password)
        {
            RegisteredUser registeredUser = databaseContext.RegisteredUsers.FirstOrDefault(
                r => r.Login == login && r.Password == password);
            return registeredUser != null;
        }

        public bool CheckUserIsRegistered(string login)
        {
            RegisteredUser registeredUser = databaseContext.RegisteredUsers.FirstOrDefault(
                r => r.Login == login);
            return registeredUser != null;
        }

        public bool CheckUserIsNotRegistered(string login)
        {
            return !CheckUserIsRegistered(login);
        }

        public void AddUser(string login, string password)
        {
            databaseContext.RegisteredUsers.Add(new RegisteredUser() { Login = login, Password = password });
            databaseContext.SaveChanges();
        }

    }
}
