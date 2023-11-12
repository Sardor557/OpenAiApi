using Microsoft.EntityFrameworkCore;
using OpenAiApi.Database.Models;
using OpenAiApi.Shared.Utils;
using System;

namespace OpenAiApi.Database.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbUser>().HasData(new tbUser
            {
                Id = 1,
                Login = "Admin",
                Password = CHash.EncryptMD5("s8064025"),
                CreateDate = DateTime.Now,
                CreateUser = 1,
                Status = 1
            });           
        }
    }
}
