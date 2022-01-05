using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Donem_Projesi.WebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Sweatshirt", Description = "Sweatshirt Ürünleri"},
                new Category(){ Name = "Mont", Description = "Mont Ürünleri"},
                new Category(){ Name = "Ceket", Description = "Ceket Ürünleri"},
                new Category(){ Name = "Pantolon", Description = "Pantolon Ürünleri"},
                new Category(){ Name = "Aksesuar", Description = "Aksesuar Ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name = "Siyah Sweatshirt",Description = "Kullanmayı çok seveceğiniz Siyah Sweatshirt", Price =140 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "31.jpg"},
                new Product(){ Name = "Hardal Sweatshirt",Description = "Kullanmayı çok seveceğiniz Hardal Sweatshirt", Price =120 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "32.jpg"},
                new Product(){ Name = "Gri Sweatshirt",Description = "Kullanmayı çok seveceğiniz Gri Sweatshirt", Price =180 , Stock =500 , IsApproved =false , CategoryId = 1,IsHome = true,Image = "33.jpg"},
                new Product(){ Name = "Mor Sweatshirt",Description = "Kullanmayı çok seveceğiniz Mor Sweatshirt", Price =200 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "34.jpg"},
                new Product(){ Name = "Mavi Sweatshirt",Description = "Kullanmayı çok seveceğiniz Mavi Sweatshirt", Price =130 , Stock =500 , IsApproved =false , CategoryId = 1,Image = "35.jpg"},

                new Product(){ Name = "Siyah Mont",Description = "Kullanmayı çok seveceğiniz Siyah Mont", Price =500 , Stock =500 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "36.jpg"},
                new Product(){ Name = "Hardal Mont",Description = "Kullanmayı çok seveceğiniz Hardal Mont", Price =450 , Stock =120 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "37.jpg"},
                new Product(){ Name = "Gri Mont",Description = "Kullanmayı çok seveceğiniz Gri Mont", Price =389 , Stock =0 , IsApproved =false , CategoryId = 2,IsHome = true,Image = "38.jpg"},
                new Product(){ Name = "Mor Mont",Description = "Kullanmayı çok seveceğiniz Mor Mont", Price =433 , Stock =600 , IsApproved =true , CategoryId = 2,Image = "39.jpg"},
                new Product(){ Name = "Mavi Mont",Description = "Kullanmayı çok seveceğiniz Mavi Mont", Price =560 , Stock =500 , IsApproved =true , CategoryId = 2,Image = "40.jpg"},

                new Product(){ Name = "Siyah Ceket",Description="Kullanmayı çok seveceğiniz Siyah Ceket", Price =250 , Stock =500 , IsApproved =true , CategoryId = 3,Image = "41.jpg"},
                new Product(){ Name = "Hardal Ceket",Description = "Kullanmayı çok seveceğiniz Hardal Ceket", Price =200 , Stock =1200 , IsApproved =true , CategoryId = 3,Image = "42.jpg"},
                new Product(){ Name = "Gri Ceket",Description = "Kullanmayı çok seveceğiniz Gri Ceket", Price =290 , Stock =0 , IsApproved =false , CategoryId =3,IsHome = true,Image = "43.jpg"},
                new Product(){ Name = "Mor Ceket",Description = "Kullanmayı çok seveceğiniz Mor Ceket", Price =289 , Stock =600 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "44.jpg"},
                new Product(){ Name = "Mavi Ceket",Description = "Kullanmayı çok seveceğiniz Mavi Ceket", Price =285 , Stock =500 , IsApproved =true , CategoryId = 3,Image = "45.jpg"},

                new Product(){ Name = "Siyah Pantolon",Description = "Kullanmayı çok seveceğiniz Siyah Pantolon", Price =200 , Stock =500 , IsApproved =true , CategoryId = 4,Image = "46.jpg"},
                new Product(){ Name = "Hardal Pantolon",Description = "Kullanmayı çok seveceğiniz Hardal Pantolon", Price =199 , Stock =1200 , IsApproved =true , CategoryId = 4,IsHome = true,Image = "47.jpg"},
                new Product(){ Name = "Gri Pantolon",Description = "Kullanmayı çok seveceğiniz Gri Pantolon", Price =250 , Stock =0 , IsApproved =false , CategoryId =4,IsHome = true,Image = "48.jpg"},
                new Product(){ Name = "Mor Pantolon",Description = "Kullanmayı çok seveceğiniz Mor Pantolon", Price =189 , Stock =600 , IsApproved =true , CategoryId = 4,Image = "49.jpg"},
                new Product(){ Name = "Mavi Pantolon",Description = "Kullanmayı çok seveceğiniz Mavi Pantolon", Price =210 , Stock =500 , IsApproved =true , CategoryId = 4,Image = "50.jpg"},

                new Product(){ Name = "Siyah Bere",Description = "Kullanmayı çok seveceğiniz Siyah Bere", Price =89 , Stock =500 , IsApproved =true , CategoryId = 5,Image = "51.jpg"},
                new Product(){ Name = "Hardal Bere",Description = "Kullanmayı çok seveceğiniz Hardal Bere", Price =80 , Stock =1200 , IsApproved =true , CategoryId = 5,IsHome = true,Image = "52.jpg"},
                new Product(){ Name = "Gri Bere",Description = "Kullanmayı çok seveceğiniz Gri Bere", Price =100 , Stock =0 , IsApproved =false , CategoryId =5,IsHome = true,Image = "53.jpg"},
                new Product(){ Name = "Mor Bere",Description = "Kullanmayı çok seveceğiniz Mor Bere", Price =59 , Stock =600 , IsApproved =true , CategoryId = 5,Image = "54.jpg"},
                new Product(){ Name = "Mavi Bere",Description = "Kullanmayı çok seveceğiniz Mavi Bere", Price =75 , Stock =500 , IsApproved =true , CategoryId = 5,Image = "55.jpg"},
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}