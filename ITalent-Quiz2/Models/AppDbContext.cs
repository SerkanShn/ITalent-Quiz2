using Microsoft.EntityFrameworkCore;

namespace ITalent_Quiz2.Models
{
    public class AppDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                    .Property(c => c.Title)
                    .HasMaxLength(50);
            modelBuilder.Entity<Category>()
                    .Property(c => c.Description)
                    .HasMaxLength(250);


            modelBuilder.Entity<Post>()
                    .Property(p => p.Title)
                    .HasMaxLength(100);
            modelBuilder.Entity<Post>()
                    .Property(p => p.Summary)
                    .HasMaxLength(450);
            modelBuilder.Entity<Post>()
                    .Property(p => p.PostBanner)
                    .HasMaxLength(250);
            modelBuilder.Entity<Post>()
                    .Property(p => p.EditedOn)
                    .IsRequired(false);



            modelBuilder.Entity<Category>().HasData(
         new Category { Id = 1, Title = "Seyahat", Description = "Seyahat birçok insan için büyük önem taşır. İş için, keyif için, tatil için vs. seyahat yapılabilir." },
         new Category { Id = 2, Title = "Eğitim", Description = "Eğitim ve okul günümüzde çok popüler bir konudur. Herkes iyi bir iş sahibi olmak istiyor. Bunun için en önemlisi eğitim. Eğitim hayat boyu sürer ve asla bitmez." },
         new Category { Id = 3, Title = "Güzellik", Description = "Güzellik, moda, makyaj, mücevher vs. Moda sürekli değişen bir şeydir." },
         new Category { Id = 4, Title = "Sağlık", Description = "Sağlık, diyet ve egzersiz insanlar için önemli konulardır. Herkes sağlıklı kalmak ve hayatını sonuna kadar yaşamak istiyor." },
         new Category { Id = 5, Title = "Yiyecek", Description = "Yiyecek hayatın önemli bir parçasıdır. Birçoğumuz yemek yemeyi seviyor. Yemek, içmek, lokantaya gitmek insanların boş zamanlarını oluşturuyor." },
         new Category { Id = 6, Title = "Yazılım", Description = "Programlama, bilgisayar sistemlerini kontrol etmemiz için süper güçler sağlayan bir alandır. Uçaklarda, trafik kontrolünde, robotlarda, sürücüsüz arabalarda, web sitelerinde, mobil uygulamalarda ve birçok alanda kullanılabilir." }
         );

        }


    }
}
