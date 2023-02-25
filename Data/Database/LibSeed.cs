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
                },
                new Book()
                {
                    Id = 4,
                    Title = "FictionTampa",
                    Cover = "TampaCover",
                    Content =
                        "FictionTwenty-six-year-old Celeste is a sexy, smart teacher married to a handsome football captain type. She’s also an unrepentant and repeated sex offender, seducing and raping her teenage students. The story of her sexual obsessions offer up a cringing response to the gendered imbalance of sexual assault. Nutting’s work is meticulous and relentless and funny, a sharp satire of romance writing with a side of death.",
                    Author = "Fiction Alissa Nutting",
                    Genre = "Fiction"
                },
                new Book()
                {
                    Id = 5,
                    Title = "To Kill a Mockingbird",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "To Kill a Mockingbird is a novel by Harper Lee published in 1960. It is set in the 1930s in Maycomb, Alabama, and tells the story of a young girl named Scout Finch and her father, Atticus, who is a lawyer. The book deals with themes of racism, prejudice, and injustice, and is widely regarded as a classic of modern American literature.",
                    Genre = "Fiction",
                    Author = "Harper Lee"
                },
                new Book()
                {
                    Id = 6,
                    Title = "The Great Gatsby",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Great Gatsby is a novel by F. Scott Fitzgerald published in 1925. It is set in the 1920s in New York and tells the story of a young man named Jay Gatsby who becomes wealthy and throws extravagant parties in the hopes of winning back his former love, Daisy Buchanan. The book is considered a masterpiece of modern literature and is widely regarded as one of the greatest American novels ever written.",
                    Genre = "Fiction",
                    Author = "F. Scott Fitzgerald"
                },
                new Book()
                {
                    Id = 7,
                    Title = "1984",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "1984 is a dystopian novel by George Orwell published in 1949. It is set in a totalitarian society where the government has complete control over every aspect of people's lives. The book deals with themes of censorship, surveillance, and totalitarianism, and is widely regarded as one of the greatest works of fiction of the 20th century.",
                    Genre = "Fiction",
                    Author = "George Orwell"
                },
                new Book()
                {
                    Id = 8,
                    Title = "Pride and Prejudice",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "Pride and Prejudice is a novel by Jane Austen published in 1813. It tells the story of the Bennet sisters, specifically the independent and strong-willed Elizabeth Bennet, who must navigate societal pressures and expectations in order to find love and happiness. The book is a classic of English literature and is known for its wit, social commentary, and engaging characters.",
                    Genre = "Fiction",
                    Author = "Jane Austen"
                },
                new Book()
                {
                    Id = 9,
                    Title = "The Catcher in the Rye",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Catcher in the Rye is a novel by J.D. Salinger published in 1951. It is a coming-of-age story about a teenage boy named Holden Caulfield who is struggling to find his place in the world. The book deals with themes of innocence, loss, and the transition to adulthood, and is known for its frank depiction of teenage angst and rebellion.",
                    Genre = "Fiction",
                    Author = "J.D. Salinger"
                },
                new Book()
                {
                    Id = 10,
                    Title = "To the Lighthouse",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "To the Lighthouse is a novel by Virginia Woolf published in 1927. It is a stream-of-consciousness narrative that follows the lives of the Ramsay family and their guests over the course of several years. The book deals with themes of memory, the passing of time, and the search for meaning in life, and is considered one of Woolf's most important works.",
                    Genre = "Fiction",
                    Author = "Virginia Woolf"
                },
                new Book()
                {
                    Id = 11,
                    Title = "The Lord of the Rings",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Lord of the Rings is a trilogy of fantasy novels by J.R.R. Tolkien published between 1954 and 1955. It follows the adventures of hobbit Frodo Baggins and his companions as they journey to destroy the One Ring and defeat the evil Sauron. The books deal with themes of power, corruption, and the struggle between good and evil, and have had a profound impact on the fantasy genre.",
                    Genre = "Fantasy",
                    Author = "J.R.R. Tolkien"
                },
                new Book()
                {
                    Id = 12,
                    Title = "The Chronicles of Narnia",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Chronicles of Narnia is a series of seven fantasy novels by C.S. Lewis published between 1950 and 1956. It tells the story of a group of children who discover a magical land called Narnia and their adventures there. The books deal with themes of faith, redemption, and the battle between good and evil, and are considered classic works of children's literature.",
                    Genre = "Fantasy",
                    Author = "C.S. Lewis"
                },
                new Book()
                {
                    Id = 13,
                    Title = "The Hunger Games",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Hunger Games is a trilogy of dystopian novels by Suzanne Collins published between 2008 and 2010. It takes place in a future North America where young people are forced to participate in a televised fight to the death called the Hunger Games. The books deal with themes of oppression, rebellion, and survival, and have been widely praised for their social commentary and strong female lead character.",
                    Genre = "Dystopian",
                    Author = "Suzanne Collins"
                },
                new Book()
                {
                    Id = 14,
                    Title = "The Da Vinci Code",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Da Vinci Code is a novel by Dan Brown published in 2003. It follows the adventures of symbologist Robert Langdon as he investigates a murder at the Louvre museum in Paris and uncovers a conspiracy involving the Holy Grail. The book deals with themes of religion, art, and history, and has been both praised and criticized for its controversial theories and fictionalized portrayals of real-life figures.",
                    Genre = "Thriller",
                    Author = "Dan Brown"
                },
                new Book()
                {
                    Id = 16,
                    Title = "The Name of the Wind",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Name of the Wind is a fantasy novel by Patrick Rothfuss published in 2007. It tells the story of Kvothe, a legendary magician and musician, who recounts his life story to a chronicler. The book is known for its intricate world-building, compelling characters, and lyrical prose.",
                    Genre = "Fantasy",
                    Author = "Patrick Rothfuss"
                },
                new Book()
                {
                    Id = 17,
                    Title = "The Way of Kings",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Way of Kings is a fantasy novel by Brandon Sanderson published in 2010. It is the first book in The Stormlight Archive series and is set in a world where powerful magic is used to fight against monstrous creatures. The book is known for its immersive world-building, complex characters, and intricate plot.",
                    Genre = "Fantasy",
                    Author = "Brandon Sanderson"
                },
                new Book()
                {
                    Id = 18,
                    Title = "The Final Empire",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Final Empire is a fantasy novel by Brandon Sanderson published in 2006. It is the first book in the Mistborn series and is set in a world where certain individuals possess magical abilities. The book follows a group of rebels as they attempt to overthrow a tyrannical ruler known as the Lord Ruler. The book is known for its unique magic system, intricate plot, and well-developed characters.",
                    Genre = "Fantasy",
                    Author = "Brandon Sanderson"
                },
                new Book()
                {
                    Id = 19,
                    Title = "The Lies of Locke Lamora",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Lies of Locke Lamora is a fantasy novel by Scott Lynch published in 2006. It follows the exploits of a group of thieves known as the Gentlemen Bastards as they carry out a series of daring heists in the city of Camorr. The book is known for its fast-paced plot, clever dialogue, and well-developed characters.",
                    Genre = "Fantasy",
                    Author = "Scott Lynch"
                },
                new Book()
                {
                    Id = 20,
                    Title = "The Eye of the World",
                    Cover = "data:image/png;base64, [base64-encoded-image-string]",
                    Content =
                        "The Eye of the World is a fantasy novel by Robert Jordan published in 1990. It is the first book in the Wheel of Time series and follows a group of young people as they embark on a quest to defeat the Dark One, a malevolent force that threatens to destroy the world. The book is known for its epic scope, complex plot, and well-developed characters.",
                    Genre = "Fantasy",
                    Author = "Robert Jordan"
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
                },
                new Review()
                {
                    Id = 4,
                    Message = "A masterpiece of literature, one of the best books I've ever read.",
                    BookId = 2,
                    Reviewer = "John Smith"
                },
                new Review()
                {
                    Id = 5,
                    Message = "Amazing! I couldn't put this book down.",
                    BookId = 3,
                    Reviewer = "Emily Jones"
                },
                new Review()
                {
                    Id = 6,
                    Message = "Boring and overrated, I couldn't get past the first few chapters.",
                    BookId = 3,
                    Reviewer = "Tom Brown"
                },
                new Review()
                {
                    Id = 7,
                    Message = "Incredible story, beautifully written, a true classic.",
                    BookId = 4,
                    Reviewer = "Sophie Williams"
                },
                new Review()
                {
                    Id = 8,
                    Message = "Not my cup of tea, I found it to be slow and uninteresting.",
                    BookId = 4,
                    Reviewer = "David Lee"
                },
                new Review()
                {
                    Id = 9,
                    Message =
                        "A thrilling page-turner, I couldn't stop reading until the very end.",
                    BookId = 5,
                    Reviewer = "Rachel Chen"
                },
                new Review()
                {
                    Id = 10,
                    Message = "Overrated and overhyped, I was disappointed by this book.",
                    BookId = 5,
                    Reviewer = "Adam Lee"
                },
                new Review()
                {
                    Id = 11,
                    Message = "An epic adventure with an unforgettable cast of characters.",
                    BookId = 18,
                    Reviewer = "Sam Patel"
                },
                new Review()
                {
                    Id = 12,
                    Message = "Too slow and boring, I couldn't get into this book.",
                    BookId = 6,
                    Reviewer = "Sarah Brown"
                },
                new Review()
                {
                    Id = 13,
                    Message = "An absolute must-read, this book blew me away.",
                    BookId = 7,
                    Reviewer = "Jake Taylor"
                },
                new Review()
                {
                    Id = 14,
                    Message = "Overhyped and underwhelming, I was expecting more from this book.",
                    BookId = 7,
                    Reviewer = "Lucy Chen"
                },
                new Review()
                {
                    Id = 15,
                    Message =
                        "One of the best books I've ever read, a true classic that everyone should read.",
                    BookId = 8,
                    Reviewer = "Michael Johnson"
                },
                new Review()
                {
                    Id = 16,
                    Message = "Too long and too boring, I couldn't finish this book.",
                    BookId = 8,
                    Reviewer = "Rachel Green"
                },
                new Review()
                {
                    Id = 17,
                    Message = "An important and thought-provoking book that everyone should read.",
                    BookId = 9,
                    Reviewer = "Benjamin Kim"
                },
                new Review()
                {
                    Id = 18,
                    Message = "I found this book to be confusing and hard to follow.",
                    BookId = 9,
                    Reviewer = "Karen Lee"
                },
                new Review()
                {
                    Id = 19,
                    Message = "A gripping and intense read that kept me on the edge of my seat.",
                    BookId = 10,
                    Reviewer = "Alex Patel"
                },
                new Review()
                {
                    Id = 20,
                    Message = "I didn't enjoy this book, I found it to be slow and dull.",
                    BookId = 10,
                    Reviewer = "Olivia Chen"
                },
                new Review()
                {
                    Id = 21,
                    Message =
                        "A thrilling and suspenseful read that kept me guessing until the very end.",
                    BookId = 9,
                    Reviewer = "William Smith"
                },
                new Review()
                {
                    Id = 22,
                    Message = "This book was too dark and violent for my taste.",
                    BookId = 9,
                    Reviewer = "Laura Lee"
                },
                new Review()
                {
                    Id = 23,
                    Message =
                        "One of the best books I've ever read, a true masterpiece of fantasy literature.",
                    BookId = 18,
                    Reviewer = "Jessica Brown"
                },
                new Review()
                {
                    Id = 24,
                    Message =
                        "I couldn't get into this book, I found it to be slow and uninteresting.",
                    BookId = 11,
                    Reviewer = "Jacob Kim"
                },
                new Review()
                {
                    Id = 25,
                    Message =
                        "An incredible journey with unforgettable characters, I highly recommend this book.",
                    BookId = 12,
                    Reviewer = "Ava Lee"
                },
                new Review()
                {
                    Id = 26,
                    Message =
                        "I was disappointed by this book, I found it to be childish and unoriginal.",
                    BookId = 18,
                    Reviewer = "Ethan Patel"
                },
                new Review()
                {
                    Id = 27,
                    Message = "An intense and heart-pounding read, I couldn't put this book down.",
                    BookId = 13,
                    Reviewer = "Isabella Chen"
                },
                new Review()
                {
                    Id = 28,
                    Message = "I found this book to be too violent and disturbing for my taste.",
                    BookId = 13,
                    Reviewer = "William Johnson"
                },
                new Review()
                {
                    Id = 29,
                    Message =
                        "A thrilling and thought-provoking read that kept me engaged from beginning to end.",
                    BookId = 14,
                    Reviewer = "Natalie Smith"
                },
                new Review()
                {
                    Id = 30,
                    Message =
                        "I didn't enjoy this book, I found it to be poorly written and unconvincing.",
                    BookId = 14,
                    Reviewer = "David Kim"
                },
                new Review()
                {
                    Id = 31,
                    Message = "An emotional and moving story, I was in tears by the end of it.",
                    BookId = 18,
                    Reviewer = "Julia Kim"
                },
                new Review()
                {
                    Id = 32,
                    Message = "I found this book to be too slow and boring for my taste.",
                    BookId = 10,
                    Reviewer = "Chris Patel"
                },
                new Review()
                {
                    Id = 33,
                    Message = "A thought-provoking and important book that everyone should read.",
                    BookId = 11,
                    Reviewer = "Samantha Brown"
                },
                new Review()
                {
                    Id = 34,
                    Message =
                        "I didn't enjoy this book, I found it to be too convoluted and confusing.",
                    BookId = 11,
                    Reviewer = "Daniel Lee"
                },
                new Review()
                {
                    Id = 35,
                    Message =
                        "An intense and suspenseful read, I was on the edge of my seat the whole time.",
                    BookId = 12,
                    Reviewer = "Michelle Patel"
                },
                new Review()
                {
                    Id = 36,
                    Message = "I found this book to be too violent and disturbing for my taste.",
                    BookId = 12,
                    Reviewer = "Steven Lee"
                },
                new Review()
                {
                    Id = 37,
                    Message = "A gripping and emotional story that left me in tears by the end.",
                    BookId = 5,
                    Reviewer = "Jessica Kim"
                },
                new Review()
                {
                    Id = 38,
                    Message =
                        "I found this book to be too predictable and unoriginal for my taste.",
                    BookId = 5,
                    Reviewer = "Tom Lee"
                },
                new Review()
                {
                    Id = 39,
                    Message = "An incredible and inspiring story that will stay with me forever.",
                    BookId = 5,
                    Reviewer = "Alex Brown"
                },
                new Review()
                {
                    Id = 40,
                    Message =
                        "I didn't enjoy this book, I found it to be too sappy and sentimental.",
                    BookId = 5,
                    Reviewer = "Emily Patel"
                },
                new Review()
                {
                    Id = 41,
                    Message =
                        "One of the best books I've ever read, a true masterpiece of literature.",
                    BookId = 5,
                    Reviewer = "David Smith"
                },
                new Review()
                {
                    Id = 42,
                    Message = "An engaging and entertaining read, I highly recommend this book.",
                    BookId = 5,
                    Reviewer = "Maria Chen"
                },
                new Review()
                {
                    Id = 43,
                    Message =
                        "A fascinating and well-written book that kept me hooked from beginning to end.",
                    BookId = 5,
                    Reviewer = "Sara Lee"
                },
                new Review()
                {
                    Id = 44,
                    Message = "I didn't enjoy this book, I found it to be slow and uninteresting.",
                    BookId = 5,
                    Reviewer = "Mark Johnson"
                },
                new Review()
                {
                    Id = 45,
                    Message =
                        "An incredible and thought-provoking book that left me questioning my own beliefs.",
                    BookId = 5,
                    Reviewer = "Sophie Kim"
                },
                new Review()
                {
                    Id = 46,
                    Message =
                        "One of the best books I've ever read, a true classic that everyone should read.",
                    BookId = 5,
                    Reviewer = "Adam Lee"
                },
                new Review()
                {
                    Id = 47,
                    Message = "A gripping and intense read that kept me on the edge of my seat.",
                    BookId = 7,
                    Reviewer = "Avery Brown"
                },
                new Review()
                {
                    Id = 48,
                    Message = "I didn't enjoy this book, I found it to be too slow and uneventful.",
                    BookId = 7,
                    Reviewer = "Noah Patel"
                },
                new Review()
                {
                    Id = 49,
                    Message = "An important and thought-provoking book that everyone should read.",
                    BookId = 7,
                    Reviewer = "Evelyn Lee"
                },
                new Review()
                {
                    Id = 50,
                    Message = "A thrilling and suspenseful read, I couldn't put this book down.",
                    BookId = 7,
                    Reviewer = "Mia Kim"
                },
                new Review()
                {
                    Id = 51,
                    Message = "I found this book to be too dark and depressing for my taste.",
                    BookId = 7,
                    Reviewer = "Luke Johnson"
                },
                new Review()
                {
                    Id = 52,
                    Message =
                        "A fascinating and eye-opening book that I would recommend to anyone.",
                    BookId = 7,
                    Reviewer = "Olivia Brown"
                },
                new Review()
                {
                    Id = 54,
                    Message =
                        "One of the best books I've read in a long time, a must-read for all.",
                    BookId = 7,
                    Reviewer = "Nathan Lee"
                },
                new Review()
                {
                    Id = 55,
                    Message = "I found this book to be too violent and disturbing for my taste.",
                    BookId = 7,
                    Reviewer = "Isabella Kim"
                },
                new Review()
                {
                    Id = 56,
                    Message =
                        "An inspiring and uplifting story that left me feeling hopeful and inspired.",
                    BookId = 7,
                    Reviewer = "Sophia Patel"
                },
                new Review()
                {
                    Id = 57,
                    Message =
                        "I didn't enjoy this book, I found it to be too preachy and didactic.",
                    BookId = 7,
                    Reviewer = "Jonathan Brown"
                },
                new Review()
                {
                    Id = 58,
                    Message = "A gripping and suspenseful read, I couldn't put this book down.",
                    BookId = 7,
                    Reviewer = "Chloe Kim"
                },
                new Review()
                {
                    Id = 59,
                    Message = "I found this book to be too slow and uneventful for my taste.",
                    BookId = 7,
                    Reviewer = "Ethan Johnson"
                },
                new Review()
                {
                    Id = 60,
                    Message =
                        "An engaging and thought-provoking book that left me with a lot to think about.",
                    BookId = 7,
                    Reviewer = "Hannah Lee"
                },
                new Review()
                {
                    Id = 61,
                    Message =
                        "A beautifully written and emotionally powerful story, I highly recommend this book.",
                    BookId = 7,
                    Reviewer = "Jacob Brown"
                },
                new Review()
                {
                    Id = 62,
                    Message = "I found this book to be too depressing and heavy for my taste.",
                    BookId = 7,
                    Reviewer = "Ava Kim"
                },
                new Review()
                {
                    Id = 63,
                    Message =
                        "An incredible and inspiring book that left me feeling motivated and inspired.",
                    BookId = 7,
                    Reviewer = "Isaac Patel"
                },
                new Review()
                {
                    Id = 64,
                    Message = "I didn't enjoy this book, I found it to be too long and rambling.",
                    BookId = 7,
                    Reviewer = "Natalie Lee"
                },
                new Review()
                {
                    Id = 65,
                    Message = "Absolutely loved this book, couldn't put it down!",
                    BookId = 18,
                    Reviewer = "Jane Doe"
                },
                new Review()
                {
                    Id = 66,
                    Message = "The Way of Kings is a fantastic book, Sanderson at his best!",
                    BookId = 17,
                    Reviewer = "John Smith"
                },
                new Review()
                {
                    Id = 67,
                    Message = "One of the best fantasy books I've ever read, highly recommended!",
                    BookId = 16,
                    Reviewer = "Emily Johnson"
                },
                new Review()
                {
                    Id = 68,
                    Message = "The Final Empire is a fantastic start to the Mistborn series!",
                    BookId = 18,
                    Reviewer = "David Lee"
                },
                new Review()
                {
                    Id = 69,
                    Message = "Great characters and an engaging plot, highly recommended!",
                    BookId = 17,
                    Reviewer = "Sarah Wilson"
                },
                new Review()
                {
                    Id = 70,
                    Message = "The Lies of Locke Lamora is a fantastic heist story!",
                    BookId = 19,
                    Reviewer = "Jessica Green"
                },
                new Review()
                {
                    Id = 71,
                    Message = "Couldn't put this book down, a must-read for any fantasy fan!",
                    BookId = 18,
                    Reviewer = "Mike Brown"
                },
                new Review()
                {
                    Id = 72,
                    Message = "The Way of Kings is an epic masterpiece of fantasy literature!",
                    BookId = 17,
                    Reviewer = "Rachel Lee"
                },
                new Review()
                {
                    Id = 73,
                    Message = "The Final Empire is a well-crafted, thrilling read!",
                    BookId = 18,
                    Reviewer = "Daniel Chen"
                },
                new Review()
                {
                    Id = 74,
                    Message =
                        "The Lies of Locke Lamora is a beautifully written book, with great characters and an engaging plot!",
                    BookId = 19,
                    Reviewer = "Michelle Kim"
                },
                new Review()
                {
                    Id = 75,
                    Message =
                        "The Way of Kings is a true masterpiece of epic fantasy, I can't recommend it enough!",
                    BookId = 17,
                    Reviewer = "Chris Davis"
                },
                new Review()
                {
                    Id = 76,
                    Message = "The Final Empire is one of the best fantasy books I've ever read!",
                    BookId = 18,
                    Reviewer = "Kate Smith"
                },
                new Review()
                {
                    Id = 77,
                    Message = "Loved this book, can't wait to read the rest of the series!",
                    BookId = 16,
                    Reviewer = "Brian Nguyen"
                },
                new Review()
                {
                    Id = 78,
                    Message = "The Eye of the World is a great start to an epic fantasy series!",
                    BookId = 20,
                    Reviewer = "Jessica Lee"
                },
                new Review()
                {
                    Id = 79,
                    Message =
                        "The world-building and character development in this book is amazing!",
                    BookId = 17,
                    Reviewer = "Lisa Chen"
                },
                new Review()
                {
                    Id = 80,
                    Message =
                        "The Eye of the World is an epic journey that any fantasy fan should experience!",
                    BookId = 20,
                    Reviewer = "David Brown"
                },
                new Review()
                {
                    Id = 81,
                    Message =
                        "The Lies of Locke Lamora is a great read for fans of heist stories and fantasy!",
                    BookId = 19,
                    Reviewer = "Samantha Lee"
                },
                new Review()
                {
                    Id = 82,
                    Message = "The Name of the Wind is a beautifully written and immersive book!",
                    BookId = 16,
                    Reviewer = "Stephanie Chen"
                },
                new Review()
                {
                    Id = 83,
                    Message =
                        "The Way of Kings is an epic masterpiece that all fantasy fans should read!",
                    BookId = 17,
                    Reviewer = "Jeffrey Davis"
                },
                new Review()
                {
                    Id = 84,
                    Message =
                        "The Final Empire is a gripping and thrilling read, highly recommended!",
                    BookId = 18,
                    Reviewer = "Tiffany Kim"
                },
                new Review()
                {
                    Id = 85,
                    Message =
                        "The Lies of Locke Lamora is a great book, with great characters and an engaging plot!",
                    BookId = 19,
                    Reviewer = "Michael Chen"
                },
                new Review()
                {
                    Id = 86,
                    Message =
                        "The Name of the Wind is a masterpiece of fantasy literature, I can't recommend it enough!",
                    BookId = 16,
                    Reviewer = "Sara Johnson"
                },
                new Review()
                {
                    Id = 87,
                    Message =
                        "The Way of Kings is a fantastic book, with great characters and an epic storyline!",
                    BookId = 17,
                    Reviewer = "Adam Smith"
                },
                new Review()
                {
                    Id = 88,
                    Message =
                        "The Final Empire is a fantastic start to the Mistborn series, I can't wait to read more!",
                    BookId = 18,
                    Reviewer = "Maria Lee"
                },
                new Review()
                {
                    Id = 89,
                    Message =
                        "The Lies of Locke Lamora is a great read, with twists and turns that keep you hooked until the end!",
                    BookId = 19,
                    Reviewer = "Daniel Kim"
                },
                new Review()
                {
                    Id = 90,
                    Message =
                        "The Name of the Wind is a beautifully written book, with great characters and an engaging story!",
                    BookId = 16,
                    Reviewer = "Jennifer Chen"
                },
                new Review()
                {
                    Id = 91,
                    Message =
                        "The Way of Kings is an epic masterpiece of fantasy literature, highly recommended!",
                    BookId = 17,
                    Reviewer = "Michael Davis"
                },
                new Review()
                {
                    Id = 92,
                    Message =
                        "The Final Empire is a well-crafted book, with great characters and an engaging storyline!",
                    BookId = 18,
                    Reviewer = "Karen Smith"
                },
                new Review()
                {
                    Id = 93,
                    Message =
                        "The Lies of Locke Lamora is a great book, with a unique setting and great characters!",
                    BookId = 19,
                    Reviewer = "Jonathan Lee"
                },
                new Review()
                {
                    Id = 94,
                    Message =
                        "The Name of the Wind is an engrossing book, with great characters and an immersive world!",
                    BookId = 16,
                    Reviewer = "Emily Chen"
                },
                new Review()
                {
                    Id = 95,
                    Message =
                        "The Way of Kings is a must-read for any fantasy fan, with great world-building and characters!",
                    BookId = 17,
                    Reviewer = "Alex Davis"
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
                },
                new Rating()
                {
                    Id = 4,
                    BookId = 2,
                    Score = 5
                },
                new Rating()
                {
                    Id = 5,
                    BookId = 3,
                    Score = 4
                },
                new Rating()
                {
                    Id = 6,
                    BookId = 3,
                    Score = 2
                },
                new Rating()
                {
                    Id = 7,
                    BookId = 4,
                    Score = 5
                },
                new Rating()
                {
                    Id = 8,
                    BookId = 4,
                    Score = 3
                },
                new Rating()
                {
                    Id = 9,
                    BookId = 5,
                    Score = 4
                },
                new Rating()
                {
                    Id = 10,
                    BookId = 5,
                    Score = 2
                },
                new Rating()
                {
                    Id = 11,
                    BookId = 6,
                    Score = 5
                },
                new Rating()
                {
                    Id = 12,
                    BookId = 6,
                    Score = 3
                },
                new Rating()
                {
                    Id = 13,
                    BookId = 7,
                    Score = 4
                },
                new Rating()
                {
                    Id = 14,
                    BookId = 7,
                    Score = 2
                },
                new Rating()
                {
                    Id = 15,
                    BookId = 8,
                    Score = 5
                },
                new Rating()
                {
                    Id = 16,
                    BookId = 8,
                    Score = 3
                },
                new Rating()
                {
                    Id = 17,
                    BookId = 9,
                    Score = 4
                },
                new Rating()
                {
                    Id = 18,
                    BookId = 9,
                    Score = 2
                },
                new Rating()
                {
                    Id = 19,
                    BookId = 10,
                    Score = 4
                },
                new Rating()
                {
                    Id = 20,
                    BookId = 10,
                    Score = 2
                },
                new Rating()
                {
                    Id = 21,
                    BookId = 11,
                    Score = 5
                },
                new Rating()
                {
                    Id = 22,
                    BookId = 11,
                    Score = 3
                },
                new Rating()
                {
                    Id = 23,
                    BookId = 12,
                    Score = 4
                },
                new Rating()
                {
                    Id = 24,
                    BookId = 12,
                    Score = 2
                },
                new Rating()
                {
                    Id = 25,
                    BookId = 13,
                    Score = 5
                },
                new Rating()
                {
                    Id = 26,
                    BookId = 13,
                    Score = 3
                },
                new Rating()
                {
                    Id = 27,
                    BookId = 14,
                    Score = 4
                },
                new Rating()
                {
                    Id = 28,
                    BookId = 14,
                    Score = 2
                },
                new Rating()
                {
                    Id = 29,
                    BookId = 1,
                    Score = 4
                },
                new Rating()
                {
                    Id = 30,
                    BookId = 4,
                    Score = 5
                },
                new Rating()
                {
                    Id = 31,
                    BookId = 4,
                    Score = 5
                },
                new Rating()
                {
                    Id = 32,
                    BookId = 4,
                    Score = 5
                },
                new Rating()
                {
                    Id = 33,
                    BookId = 1,
                    Score = 4
                },
                new Rating()
                {
                    Id = 34,
                    BookId = 1,
                    Score = 5
                },
                new Rating()
                {
                    Id = 35,
                    BookId = 2,
                    Score = 3
                },
                new Rating()
                {
                    Id = 36,
                    BookId = 2,
                    Score = 4
                },
                new Rating()
                {
                    Id = 37,
                    BookId = 3,
                    Score = 5
                },
                new Rating()
                {
                    Id = 38,
                    BookId = 3,
                    Score = 4
                },
                new Rating()
                {
                    Id = 39,
                    BookId = 4,
                    Score = 3
                },
                new Rating()
                {
                    Id = 40,
                    BookId = 4,
                    Score = 4
                },
                new Rating()
                {
                    Id = 41,
                    BookId = 5,
                    Score = 5
                },
                new Rating()
                {
                    Id = 42,
                    BookId = 5,
                    Score = 4
                },
                new Rating()
                {
                    Id = 43,
                    BookId = 6,
                    Score = 3
                },
                new Rating()
                {
                    Id = 44,
                    BookId = 6,
                    Score = 4
                },
                new Rating()
                {
                    Id = 45,
                    BookId = 7,
                    Score = 2
                },
                new Rating()
                {
                    Id = 46,
                    BookId = 7,
                    Score = 3
                },
                new Rating()
                {
                    Id = 47,
                    BookId = 8,
                    Score = 4
                },
                new Rating()
                {
                    Id = 48,
                    BookId = 8,
                    Score = 5
                },
                new Rating()
                {
                    Id = 49,
                    BookId = 9,
                    Score = 3
                },
                new Rating()
                {
                    Id = 50,
                    BookId = 9,
                    Score = 4
                },
                new Rating()
                {
                    Id = 51,
                    BookId = 10,
                    Score = 5
                },
                new Rating()
                {
                    Id = 52,
                    BookId = 10,
                    Score = 4
                },
                new Rating()
                {
                    Id = 53,
                    BookId = 11,
                    Score = 3
                },
                new Rating()
                {
                    Id = 54,
                    BookId = 11,
                    Score = 4
                },
                new Rating()
                {
                    Id = 55,
                    BookId = 12,
                    Score = 2
                },
                new Rating()
                {
                    Id = 56,
                    BookId = 12,
                    Score = 3
                },
                new Rating()
                {
                    Id = 57,
                    BookId = 13,
                    Score = 4
                },
                new Rating()
                {
                    Id = 58,
                    BookId = 13,
                    Score = 5
                },
                new Rating()
                {
                    Id = 59,
                    BookId = 14,
                    Score = 3
                },
                new Rating()
                {
                    Id = 60,
                    BookId = 14,
                    Score = 4
                },
                new Rating()
                {
                    Id = 61,
                    BookId = 15,
                    Score = 5
                },
                new Rating()
                {
                    Id = 62,
                    BookId = 15,
                    Score = 4
                },
                new Rating()
                {
                    Id = 63,
                    BookId = 15,
                    Score = 4
                },
                new Rating()
                {
                    Id = 64,
                    BookId = 15,
                    Score = 5
                },
                new Rating()
                {
                    Id = 65,
                    BookId = 16,
                    Score = 5
                },
                new Rating()
                {
                    Id = 66,
                    BookId = 16,
                    Score = 4
                },
                new Rating()
                {
                    Id = 67,
                    BookId = 17,
                    Score = 5
                },
                new Rating()
                {
                    Id = 68,
                    BookId = 17,
                    Score = 4
                },
                new Rating()
                {
                    Id = 69,
                    BookId = 18,
                    Score = 5
                },
                new Rating()
                {
                    Id = 70,
                    BookId = 18,
                    Score = 4
                },
                new Rating()
                {
                    Id = 71,
                    BookId = 19,
                    Score = 4
                },
                new Rating()
                {
                    Id = 72,
                    BookId = 19,
                    Score = 5
                },
                new Rating()
                {
                    Id = 73,
                    BookId = 20,
                    Score = 4
                },
                new Rating()
                {
                    Id = 74,
                    BookId = 20,
                    Score = 5
                },
                new Rating()
                {
                    Id = 75,
                    BookId = 15,
                    Score = 4
                },
                new Rating()
                {
                    Id = 76,
                    BookId = 15,
                    Score = 5
                },
                new Rating()
                {
                    Id = 77,
                    BookId = 16,
                    Score = 4
                },
                new Rating()
                {
                    Id = 78,
                    BookId = 16,
                    Score = 5
                },
                new Rating()
                {
                    Id = 79,
                    BookId = 17,
                    Score = 4
                },
                new Rating()
                {
                    Id = 80,
                    BookId = 17,
                    Score = 5
                },
                new Rating()
                {
                    Id = 81,
                    BookId = 18,
                    Score = 4
                },
                new Rating()
                {
                    Id = 82,
                    BookId = 18,
                    Score = 5
                },
                new Rating()
                {
                    Id = 83,
                    BookId = 19,
                    Score = 5
                },
                new Rating()
                {
                    Id = 84,
                    BookId = 19,
                    Score = 4
                },
                new Rating()
                {
                    Id = 85,
                    BookId = 20,
                    Score = 5
                },
                new Rating()
                {
                    Id = 86,
                    BookId = 20,
                    Score = 4
                }
            );
    }
}
