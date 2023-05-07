using Microsoft.EntityFrameworkCore;

namespace GCommerce.Server.Data;

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
                Url = "books"
            },
            new Category
            {
                Id = 2,
                Name = "Movies",
                Url = "movies"
            },
            new Category
            {
                Id = 3,
                Name = "Video Games",
                Url = "video-games"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Dune 1",
                Description =
                    "Dune is a 1965 science-fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelaznys This Immortal for the Hugo Award in 1966, and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune saga, and in 2003 was cited as the worlds best-selling science fiction novel.",
                ImageUrl = "https://m.media-amazon.com/images/I/81ym3QUd3KL.jpg",
                Price = 12.59m,
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Name = "Quarantine",
                Description =
                    "Quarantine is a 1992 science fiction novel by Australian writer Greg Egan. It was first published as a hardback in 1992 by Victor Gollancz Ltd. It won the 1993 John W. Campbell Award. The story is set in a near-future world in which right-wing politicians gain power in the United States, Russia, and Australia, and a mysterious scientific discovery is made in Western Australia, which causes many countries to quarantine the entire continent. The novel follows several characters as they react to the discovery and the quarantine.",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/en/5/5d/Quarantine_%28Greg_Egan_novel%29_cover_art.jpg",
                Price = 9.29m,
                CategoryId = 1
            },
            new Product
            {
                Id = 3,
                Name = "The Martian",
                Description =
                    "The Martian is a 2011 science fiction novel written by Andy Weir. It was his debut novel under his own name. It was originally self-published in 2011; Crown Publishing purchased the rights and re-released it in 2014. The story follows an American astronaut, Mark Watney, as he becomes stranded alone on Mars in 2035 and must improvise in order to survive.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c3/The_Martian_2014.jpg",
                Price = 11.99m
            }
        );
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}