﻿using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Helpers;

public class PasswordHasher
{
    public static (string, string) GenerateSecurePassword(string password)
    {
        try
        {
            using var hmac = new HMACSHA512();
            var securityKey = hmac.Key;
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            return (Convert.ToBase64String(securityKey), Convert.ToBase64String(computedHash));
        }
        catch { }
        return (null!, null!);
    }

    public static bool ValidateSecurePassword(string password, string hashedPassword, string securityKey)
    {
        try
        {
            using var hmac = new HMACSHA512(Convert.FromBase64String(securityKey));
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            var hash = Convert.FromBase64String(hashedPassword);

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
        catch { }
        return false;
    }
}
