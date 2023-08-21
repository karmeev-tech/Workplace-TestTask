using System;
using System.Collections.Generic;
using System.Linq;
using Workplace.Domain.User;
using Workplace.Infrastructure.Interfaces;
using Workplace.Infrastructure.Model;

namespace Workplace.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IRepository<UserEntity>
    {
        public UserEntity Create(User person)
        {
            using (var context = new UserContext())
            {
                var query = from user in context.Users
                            select user;

                var result = query.ToList()
                                  .Where(user => user.Email == person.Email);
                if(result.Any())
                {
                    return null;
                }

                var userData = new UserEntity
                {
                    NickName = person.NickName,
                    Email = person.Email,
                    Comments = person.Comments,
                    CreateDate = person.CreateDate
                };

                context.Users.Add(userData);
                context.SaveChanges();
                return userData;
            };
        }

        public void Delete(string email)
        {
            using (var context = new UserContext())
            {
                var query = from user in context.Users
                            select user;

                var result = query.ToList()
                                  .Where(user => user.Email == email);
                if (!result.Any())
                {
                    throw new Exception();
                }

                context.Users.Remove(result.FirstOrDefault());
                context.SaveChanges();
            };
        }

        public UserEntity Get(string email)
        {
            using (var context = new UserContext())
            {
                var query = from user in context.Users
                            select user;

                var result = query.ToList()
                                  .Where(user => user.Email == email)
                                  .FirstOrDefault();
                return result;
            };
        }

        public List<UserEntity> GetAll()
        {
            using (var context = new UserContext())
            {
                var query = from user in context.Users
                            select user;

                var result = query.ToList();
                return result;
            }
        }

        public void Update(UserEntity entity)
        {
            using (var context = new UserContext())
            {
                var query = from user in context.Users
                            select user;

                var result = query.ToList()
                                  .Where(user => user.Email == entity.Email);
                if (!result.Any())
                {
                    throw new Exception();
                }

                var person = result.FirstOrDefault();
                person.NickName = entity.NickName;
                person.Email = entity.Email;
                person.Comments = entity.Comments;

                context.SaveChanges();
            };
        }
    }
}
