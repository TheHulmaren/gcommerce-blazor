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
                Name = "Rendezvous with Rama",
                Description =
                    "Rendezvous with Rama is a science fiction novel by British writer Arthur C. Clarke first published in 1973. Set in the 2130s, the story involves a 50-by-20-kilometre (31 by 12 mi) cylindrical alien starship that enters Earths solar system. The story is told from the point of view of a group of human explorers who intercept the ship in an attempt to unlock its mysteries. This novel won both the Hugo and Nebula awards upon its release, and is regarded as one of the cornerstones in Clarkes bibliography. The concept was later extended with several sequels, written by Clarke in collaboration with Gentry Lee.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e1/Rama_copy.jpg",
                Price = 11.99m,
                CategoryId = 1
            },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "The Matrix",
                Description =
                    "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                Price =  14.99m,
            },
            new Product
            {
                Id = 5,
                CategoryId = 2,
                Name = "Back to the Future",
                Description =
                    "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                Price =  9.99m,
            },
            new Product
            {
                Id = 6,
                CategoryId = 2,
                Name = "Toy Story",
                Description =
                    "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                Price =  19.99m,
            },
            new Product
            {
                Id = 7,
                CategoryId = 3,
                Name = "Half-Life 2",
                Description =
                    "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                Price =  9.99m,
            },
            new Product
            {
                Id = 8,
                CategoryId = 3,
                Name = "Diablo II",
                Description =
                    "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                Price =  49.99m,
            },
            new Product
            {
                Id = 9,
                CategoryId = 3,
                Name = "Day of the Tentacle",
                Description =
                    "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                Price =  9.99m,
            },
            new Product
            {
                Id = 10,
                CategoryId = 3,
                Name = "Xbox",
                Description =
                    "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                Price =  99.99m,
            },
            new Product
            {
                Id = 11,
                CategoryId = 3,
                Name = "Super Nintendo Entertainment System",
                Description =
                    "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                Price =  49.99m,
            }
        );
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}