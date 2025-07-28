using Songify.Functionality.Dto;
using Songify.Storage;
using Songify.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Songify.Functionality.Services
{
    public class UserService
    {
        private readonly SongifyDbContext _context;

        public UserService(SongifyDbContext context)
        {
            _context = context;
        }

        
        public User Login(LoginRequest login)
        {
            var user = _context.Users.SingleOrDefault(u => u.UserName == login.Username);

            if (user == null || user.Password != login.Password) //HashPassword(login.Password))
            {
                throw new UnauthorizedAccessException("Niepoprawny email lub hasło.");
            }
            return user;

        }

        public User Register(RegisterRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
            {
                throw new ArgumentException("Nazwa użytkownika i hasło są wymagane.");
            }

            if (_context.Users.Any(u => u.UserName == request.Username))
            {
                throw new InvalidOperationException("Użytkownik o tej nazwie już istnieje.");
            }

            var user = new User
            {
                UserName = request.Username,
                Password = request.Password /*HashPassword(request.Password)*/
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }
        
        
        //private string HashPassword(string password)
        //{
        //    var sha256 = SHA256.Create();
        //    var bytes = Encoding.UTF8.GetBytes(password);
        //    var hash = sha256.ComputeHash(bytes);
        //    return Convert.ToBase64String(hash);
        //}
    }
}
