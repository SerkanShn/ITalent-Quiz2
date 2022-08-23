using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITalent_Quiz2.Migrations
{
    public partial class seeddataeklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Seyahat birçok insan için büyük önem taşır. İş için, keyif için, tatil için vs. seyahat yapılabilir.", "Seyahat" },
                    { 2, "Eğitim ve okul günümüzde çok popüler bir konudur. Herkes iyi bir iş sahibi olmak istiyor. Bunun için en önemlisi eğitim. Eğitim hayat boyu sürer ve asla bitmez.", "Eğitim" },
                    { 3, "Güzellik, moda, makyaj, mücevher vs. Moda sürekli değişen bir şeydir.", "Güzellik" },
                    { 4, "Sağlık, diyet ve egzersiz insanlar için önemli konulardır. Herkes sağlıklı kalmak ve hayatını sonuna kadar yaşamak istiyor.", "Sağlık" },
                    { 5, "Yiyecek hayatın önemli bir parçasıdır. Birçoğumuz yemek yemeyi seviyor. Yemek, içmek, lokantaya gitmek insanların boş zamanlarını oluşturuyor.", "Yiyecek" },
                    { 6, "Programlama, bilgisayar sistemlerini kontrol etmemiz için süper güçler sağlayan bir alandır. Uçaklarda, trafik kontrolünde, robotlarda, sürücüsüz arabalarda, web sitelerinde, mobil uygulamalarda ve birçok alanda kullanılabilir.", "Yazılım" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
