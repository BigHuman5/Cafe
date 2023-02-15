using Cafe.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.DAL.EF
{
    internal class DbInitializer
    {
        public static void Initialize(CafeDbContext context)
        {
            //context.Database.EnsureCreated();

            if (context.GroupProducts.Any())
            {
                return;   // DB has been seeded
            }

            var groupProducts = new GroupProducts[]
            {
                new GroupProducts {
                    Name="Пицца",
                    isDeleted=false,
                },
                new GroupProducts {
                    Name="Суши",
                    isDeleted=false,
                },
                new GroupProducts {
                    Name="Супы",
                    isDeleted=true,
                },
            };

            foreach (GroupProducts s in groupProducts)
            {
                context.GroupProducts.Add(s);
            }
            context.SaveChanges();
            //
            var products = new Products[]
            {
                new Products {
                    Name="Вкусная",
                    GroupId=1,
                    Price=1000,
                    Description="Она вкусная",
                    isDeleted=false,
                },
                new Products {
                    Name="Унаги",
                    GroupId=2,
                    Price=10000,
                    Description="Дорогие",
                    isDeleted=false,
                },
                new Products {
                    Name="Не вкусная",
                    GroupId=1,
                    Price=10,
                    Description="Она не вкусная",
                    isDeleted=true,
                },
                new Products {
                    Name="Борщ",
                    GroupId=3,
                    Price=1000,
                    Description="Так",
                    isDeleted=false,
                },
            };

            foreach (Products s in products)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();
        }
    }
}
