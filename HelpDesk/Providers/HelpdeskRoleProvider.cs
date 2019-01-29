using System;
using System.Linq;
using System.Web.Security;
using HelpDesk.Models;

namespace HelpDesk.Providers
{
    public class HelpdeskRoleProvider : RoleProvider
    {
        // Возвращаем все роли пользователя
        public override string[] GetRolesForUser(string login)
        {
            string[] role = new string[] { };
            using (HelpdeskContext _db = new HelpdeskContext())
            {
                try
                {
                    //Получаем пользователя
                    User user = (from u in _db.Users
                                 where u.Login == login
                                 select u).FirstOrDefault();

                    if (user != null)
                    {
                        //Получаем роль
                        Role userRole = _db.Roles.Find(user.RoleId);

                        if (userRole != null)
                        {
                            role = new string[] { userRole.Name };
                        }
                    }
                }
                catch
                {
                    role = new string[] { };
                }
            }
            return role;
        }
        // Проверяем связь пользователя и роли
        public override bool IsUserInRole(string username, string roleName)
        {
            bool outputResult = false;

            using (HelpdeskContext _db = new HelpdeskContext())
            {
                try
                {            
                    //Находим пользователя
                    User user = (from u in _db.Users
                                 where u.Login == username
                                 select u).FirstOrDefault();

                    if(user != null)
                    {
                        //получаем роль
                        Role userRole = _db.Roles.Find(user.RoleId);

                        //Сравниваем
                        if(userRole != null && userRole.Name == roleName)
                        {
                            outputResult = true;
                        }
                    }
                }
                catch
                {
                    outputResult = false;
                }
            }
            return outputResult;
        }
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }
        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }
        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}