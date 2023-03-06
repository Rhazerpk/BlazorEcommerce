using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Es una obra literaria de mucha importancia a nivel nacional e internacional, ya que por décadas fue utilizado por muchas personas con la maravillosa labor de enseñar, más que todo a los niños en el increíble camino de la lectura y escritura.", "https://resources.diariolibre.com/images/2022/09/29/9789945125030-es-20db2495-focus-0.17-0.59-895-573.jpg", 9.99m, "Nacho" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Es una novela de la escritora chilena Isabel Allende, publicada en el año 2009, que cuenta la historia de una esclava llamada Zarité en el Haití del siglo XVIII. Acerca de su protagonista, Allende ha declarado: «De todos los personajes que he creado, el de Zarité es para mí el que más tengo la sensación de que existió.", "https://quelibroleo.com/images/libros/libro_1363451479.jpg", 7.99m, "Isla bajo el mar" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Deja en evidencia el problema de fondo del narcotráfico en México: la complicidad del Estado. Con testimonios claves de Vicente Zambada Niebla, la autora indaga en el perfil y la historia de su padre Ismael, el Mayo, el cabecilla más importante del Cártel de Sinaloa.", "https://m.media-amazon.com/images/I/41gTtABndrL._SY291_BO1,204,203,200_QL40_FMwebp_.jpg", 6.99m, "El traidor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
