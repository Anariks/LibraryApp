using Contracts.Database;
using Microsoft.EntityFrameworkCore;

namespace Data.Database;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Book>()
            .HasData(
                new Book()
                {
                    Id = 1,
                    Title = "Zombie",
                    Cover = "cover",
                    Content =
                        "A novella based on the life and crimes of Jeffrey Dahmer. It jumps into a creepily precise first person, an expert frame for the violence to come. And it does, bearing descriptions of corpsifying and sawing heads open without a bit of sentiment for the individuals attached. Oates is at her ribald, manic best here, employing her insatiable curiosity towards the psychotic mind. The resulting work is gorier than a slow-motion freeway pileup, with equal glory.",
                    Author = "Joyce Carol Oates",
                    Genre = "Fiction"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Tampa",
                    Cover = "TampaCover",
                    Content =
                        "Twenty-six-year-old Celeste is a sexy, smart teacher married to a handsome football captain type. She’s also an unrepentant and repeated sex offender, seducing and raping her teenage students. The story of her sexual obsessions offer up a cringing response to the gendered imbalance of sexual assault. Nutting’s work is meticulous and relentless and funny, a sharp satire of romance writing with a side of death.",
                    Author = "Alissa Nutting",
                    Genre = "Fiction"
                },
                new Book()
                {
                    Id = 3,
                    Title = "A Brief History of Time",
                    Cover = "BriefCover",
                    Content =
                        "A landmark volume in science writing by one of the great minds of our time, Stephen Hawking’s book explores such profound questions as: How did the universe begin—and what made its start possible? Does time always flow forward? Is the universe unending—or are there boundaries? Are there other dimensions in space? What will happen when it allTold in language we all can understand, A Brief History of Time plunges into the exotic realms of black holes and quarks, of antimatter and “arrows of time,” of the big bang and a bigger God—where the possibilities are wondrous and unexpected. With exciting images and profound imagination, Stephen Hawking brings us closer to the ultimate secrets at the very hear",
                    Author = "Stephen Hawking",
                    Genre = "Cosmology"
                }
            );

        modelBuilder
            .Entity<Review>()
            .HasData(
                new Review()
                {
                    Id = 1,
                    Message = "Best book ever, read it 10 times in a row",
                    BookId = 1,
                    Reviewer = "Paul John Smith"
                },
                new Review()
                {
                    Id = 2,
                    Message = "Some kind of shit.. don't ever try to read it",
                    BookId = 1,
                    Reviewer = "Santa Mariia"
                },
                new Review()
                {
                    Id = 3,
                    Message = "I'd better drink 4 pints of beer instead of byuing it",
                    BookId = 2,
                    Reviewer = "Markus Ellis"
                }
            );

        modelBuilder
            .Entity<Rating>()
            .HasData(
                new Rating()
                {
                    Id = 1,
                    BookId = 1,
                    Score = 4
                },
                new Rating()
                {
                    Id = 2,
                    BookId = 1,
                    Score = 5
                },
                new Rating()
                {
                    Id = 3,
                    BookId = 2,
                    Score = 3
                }
            );
    }
}
