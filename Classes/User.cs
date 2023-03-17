using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace WorkRecordSystem.Classes
{
    public class User
    {
        public string Name { get; }
        public string Password { get; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public User(string name, byte[] passwordHash, byte[] passwordSalt)
        {
            Name = name;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }
        public User(string name, string password)
        {
            Name = name;
            CreatePasswordHash(password);
        }
        public bool VerifyPassword(string text)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(PasswordHash);
        }
        public void CreatePasswordHash(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}

