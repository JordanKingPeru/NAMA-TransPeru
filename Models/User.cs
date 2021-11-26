using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nama.Models
{
    /**
     * User Model 
     */
    public class User
    {
        [Key]
        public string Username { get; set; }

        [StringLength(64)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Entidad { get; set; }

        [StringLength(50)]
        public string Rol { get; set; }

        public string ComputeStringToSha256Hash(string stringtext) {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(stringtext));

                StringBuilder stringbuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringbuilder.Append(bytes[i].ToString("x2"));
                }
                return stringbuilder.ToString();
            }
        }
    }
}
