
namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category 
                { 
                    Id = 1,
                    Name = "Books",
                    Url = "books",

                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies",

                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games",

                }
                );

            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Title = "Nacho",
                    Description = "Es una obra literaria de mucha importancia a nivel nacional e internacional, ya que por décadas fue utilizado por muchas personas con la maravillosa labor de enseñar, más que todo a los niños en el increíble camino de la lectura y escritura.",
                    ImageUrl = "https://resources.diariolibre.com/images/2022/09/29/9789945125030-es-20db2495-focus-0.17-0.59-895-573.jpg",
                    Price = 9.99m,
                    CategoryId = 1
                    
                },
                new Product
                {
                    Id = 2,
                    Title = "Isla bajo el mar",
                    Description = "Es una novela de la escritora chilena Isabel Allende, publicada en el año 2009, que cuenta la historia de una esclava llamada Zarité en el Haití del siglo XVIII. Acerca de su protagonista, Allende ha declarado: «De todos los personajes que he creado, el de Zarité es para mí el que más tengo la sensación de que existió.",
                    ImageUrl = "https://quelibroleo.com/images/libros/libro_1363451479.jpg",
                    Price = 7.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "El traidor",
                    Description = "Deja en evidencia el problema de fondo del narcotráfico en México: la complicidad del Estado. Con testimonios claves de Vicente Zambada Niebla, la autora indaga en el perfil y la historia de su padre Ismael, el Mayo, el cabecilla más importante del Cártel de Sinaloa.",
                    ImageUrl = "https://m.media-amazon.com/images/I/41gTtABndrL._SY291_BO1,204,203,200_QL40_FMwebp_.jpg",
                    Price = 6.99m,
                    CategoryId = 1
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
