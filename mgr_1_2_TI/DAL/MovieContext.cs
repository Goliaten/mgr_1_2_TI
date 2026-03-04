using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgr_1_2_TI.Models;
using Microsoft.EntityFrameworkCore;

namespace mgr_1_2_TI.DAL
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> T_Movies { get; set; }
        public DbSet<Category> T_Categories { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categories = new List<Category>()
            {
                new() { Id = 1, Name = "Action", Description = "Fast-paced movies with intense physical action, stunts, and battles." },
                new() { Id = 2, Name = "Comedy", Description = "Light-hearted films designed to make the audience laugh." },
                new() { Id = 3, Name = "Drama", Description = "Serious films focusing on realistic characters and emotional themes." },
                new() { Id = 4, Name = "Sci-Fi", Description = "Movies exploring futuristic concepts, advanced technology, and space exploration." },
                new() { Id = 5, Name = "Horror", Description = "Films intended to frighten, shock, or suspense the audience." },
                new() { Id = 6, Name = "Romance", Description = "Stories centered on passionate, emotional, and romantic involvement." },
                new() { Id = 7, Name = "Thriller", Description = "Suspenseful movies with tension, excitement, and a sense of danger." },
                new() { Id = 8, Name = "Animation", Description = "Films created using animation techniques, often aimed at children and families." },
                new() { Id = 9, Name = "Documentary", Description = "Non-fictional films intended to document reality, primarily for instruction or maintaining a historical record." },
                new() { Id = 10, Name = "Fantasy", Description = "Movies set in imaginary worlds, often involving magic, mythical creatures, and supernatural events." }
            };

            var movies = new List<Movie>()
            {
                // Action
                new() { Id = 1, Title = "The Dark Knight", Description = "A superhero film about Batman facing the Joker in Gotham City.", Director = "Christopher Nolan", Price = 19.99m, CategoryId = 1},
                new() { Id = 2, Title = "Mad Max: Fury Road", Description = "In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the aid of a group of female prisoners, a psychotic worshiper, and a drifter named Max.", Director = "George Miller", Price = 18.99m, CategoryId = 1},
                new() { Id = 3, Title = "John Wick", Description = "An ex-hit-man comes out of retirement to track down the gangsters that killed his dog and took everything from him.", Director = "Chad Stahelski", Price = 17.99m, CategoryId = 1},
                new() { Id = 4, Title = "Die Hard", Description = "An NYPD officer tries to save his wife and several others taken hostage by German terrorists during a Christmas party at the Nakatomi Plaza in Los Angeles.", Director = "John McTiernan", Price = 16.99m, CategoryId = 1},
                new() { Id = 5, Title = "The Avengers", Description = "Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.", Director = "Joss Whedon", Price = 21.99m, CategoryId = 1},
                new() { Id = 6, Title = "Gladiator", Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", Director = "Ridley Scott", Price = 20.99m, CategoryId = 1},
                new() { Id = 7, Title = "Mission: Impossible - Fallout", Description = "Ethan Hunt and his IMF team, along with some familiar allies, race against time after a mission gone wrong.", Director = "Christopher McQuarrie", Price = 22.99m, CategoryId = 1},
                new() { Id = 8, Title = "The Bourne Identity", Description = "A man is picked up by a fishing boat, bullet-riddled and suffering from amnesia, before racing to elude assassins and regain his memory.", Director = "Doug Liman", Price = 15.99m, CategoryId = 1},
                new() { Id = 9, Title = "Speed", Description = "A young police officer must prevent a bomb exploding aboard a city bus by keeping its speed above 50 mph.", Director = "Jan de Bont", Price = 14.99m, CategoryId = 1},
                new() { Id = 10, Title = "The Terminator", Description = "A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.", Director = "James Cameron", Price = 13.99m, CategoryId = 1},
                new() { Id = 11, Title = "Casino Royale", Description = "After earning 00 status and a licence to kill, Secret Agent James Bond sets out on his first mission as 007. Bond must defeat a private banker funding terrorists in a high-stakes game of poker at Casino Royale, Montenegro.", Director = "Martin Campbell", Price = 19.99m, CategoryId = 1},
                new() { Id = 12, Title = "The Raid", Description = "A S.W.A.T. team becomes trapped in a tenement run by a ruthless mobster and his army of killers and thugs.", Director = "Gareth Evans", Price = 16.99m, CategoryId = 1},

                // Comedy
                new() { Id = 13, Title = "Superbad", Description = "Two co-dependent high school seniors are forced to deal with separation anxiety after their plan to stage a booze-soaked party goes awry.", Director = "Greg Mottola", Price = 9.99m, CategoryId = 2},
                new() { Id = 14, Title = "The Hangover", Description = "Three buddies wake up from a bachelor party in Las Vegas, with no memory of the previous night and the bachelor missing.", Director = "Todd Phillips", Price = 11.99m, CategoryId = 2},
                new() { Id = 15, Title = "Bridesmaids", Description = "Competition between the maid of honor and a bridesmaid, over who is the bride's best friend, threatens to upend the life of an out-of-work pastry chef.", Director = "Paul Feig", Price = 10.99m, CategoryId = 2},
                new() { Id = 16, Title = "Step Brothers", Description = "Two aimless middle-aged losers still living at home are forced against their will to become roommates when their parents marry.", Director = "Adam McKay", Price = 12.99m, CategoryId = 2},
                new() { Id = 17, Title = "Anchorman: The Legend of Ron Burgundy", Description = "Ron Burgundy is San Diego's top-rated newsman in the male-dominated broadcasting of the 1970s, but that's all about to change for Ron and his cronies when an ambitious woman shows up.", Director = "Adam McKay", Price = 13.99m, CategoryId = 2},
                new() { Id = 18, Title = "Dumb and Dumber", Description = "The cross-country adventures of two good-hearted but incredibly stupid friends.", Director = "Peter Farrelly", Price = 14.99m, CategoryId = 2},
                new() { Id = 19, Title = "The 40-Year-Old Virgin", Description = "Goaded by his buddies, a nerdy guy who's never 'done the deed' only finds the pressure mounting when he meets a single mother.", Director = "Judd Apatow", Price = 15.99m, CategoryId = 2},
                new() { Id = 20, Title = "Zoolander", Description = "At the end of his career, a clueless fashion model is brainwashed to kill the Prime Minister of Malaysia.", Director = "Ben Stiller", Price = 16.99m, CategoryId = 2},
                new() { Id = 21, Title = "Old School", Description = "Three friends attempt to recapture their glory days by opening up a fraternity near their old alma mater.", Director = "Todd Phillips", Price = 17.99m, CategoryId = 2},
                new() { Id = 22, Title = "Airplane!", Description = "A man afraid to fly must ensure that a plane lands safely after the pilots become sick.", Director = "Jim Abrahams", Price = 18.99m, CategoryId = 2},
                new() { Id = 23, Title = "The Other Guys", Description = "Two mismatched New York City detectives seize an opportunity to step up like the city's top cops, whom they idolize, only things don't quite go as planned.", Director = "Adam McKay", Price = 19.99m, CategoryId = 2},
                new() { Id = 24, Title = "Tropic Thunder", Description = "Through a series of freak occurrences, a group of actors shooting a big-budget war movie are forced to become the soldiers they are portraying.", Director = "Ben Stiller", Price = 20.99m, CategoryId = 2},

                // Drama
                new() { Id = 25, Title = "The Shawshank Redemption", Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", Director = "Frank Darabont", Price = 14.99m, CategoryId = 3},
                new() { Id = 26, Title = "Forrest Gump", Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75.", Director = "Robert Zemeckis", Price = 13.99m, CategoryId = 3},
                new() { Id = 27, Title = "The Godfather", Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", Director = "Francis Ford Coppola", Price = 19.99m, CategoryId = 3},
                new() { Id = 28, Title = "Schindler's List", Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", Director = "Steven Spielberg", Price = 18.99m, CategoryId = 3},
                new() { Id = 29, Title = "The Pursuit of Happyness", Description = "A struggling salesman takes custody of his son as he's poised to begin a life-changing professional career.", Director = "Gabriele Muccino", Price = 17.99m, CategoryId = 3},
                new() { Id = 30, Title = "Good Will Hunting", Description = "Will Hunting, a janitor at M.I.T., has a gift for mathematics, but needs help from a psychologist to find direction in his life.", Director = "Gus Van Sant", Price = 16.99m, CategoryId = 3},
                new() { Id = 31, Title = "A Beautiful Mind", Description = "After John Nash, a brilliant but asocial mathematician, accepts secret work in cryptography, his life takes a turn for the nightmarish.", Director = "Ron Howard", Price = 15.99m, CategoryId = 3},
                new() { Id = 32, Title = "The Social Network", Description = "Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, but is later sued by two brothers who claimed he stole their idea.", Director = "David Fincher", Price = 16.99m, CategoryId = 3},
                new() { Id = 33, Title = "Rain Man", Description = "Selfish yuppie Charlie Babbitt's father left a fortune to his savant brother Raymond and a pittance to Charlie; they travel cross-country.", Director = "Barry Levinson", Price = 14.99m, CategoryId = 3},
                new() { Id = 34, Title = "The Green Mile", Description = "The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape but who has a mysterious gift.", Director = "Frank Darabont", Price = 13.99m, CategoryId = 3},
                new() { Id = 35, Title = "The Pianist", Description = "A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II.", Director = "Roman Polanski", Price = 12.99m, CategoryId = 3},
                new() { Id = 36, Title = "12 Angry Men", Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", Director = "Sidney Lumet", Price = 11.99m, CategoryId = 3},

                // Sci-Fi
                new() { Id = 37, Title = "Inception", Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", Director = "Christopher Nolan", Price = 22.99m, CategoryId = 4},
                new() { Id = 38, Title = "The Matrix", Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", Director = "Lana Wachowski", Price = 20.99m, CategoryId = 4},
                new() { Id = 39, Title = "Interstellar", Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", Director = "Christopher Nolan", Price = 21.99m, CategoryId = 4},
                new() { Id = 40, Title = "Blade Runner 2049", Description = "A young blade runner's discovery of a long-buried secret leads him to track down former blade runner Rick Deckard, who's been missing for thirty years.", Director = "Denis Villeneuve", Price = 23.99m, CategoryId = 4},
                new() { Id = 41, Title = "Arrival", Description = "A linguist works with the military to communicate with alien lifeforms after twelve mysterious spacecraft appear around the world.", Director = "Denis Villeneuve", Price = 22.99m, CategoryId = 4},
                new() { Id = 42, Title = "The Martian", Description = "An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive.", Director = "Ridley Scott", Price = 21.99m, CategoryId = 4},
                new() { Id = 43, Title = "Ex Machina", Description = "A young programmer is selected to participate in a ground-breaking experiment in synthetic intelligence by evaluating the human qualities of a breathtaking female A.I.", Director = "Alex Garland", Price = 20.99m, CategoryId = 4},
                new() { Id = 44, Title = "Dune", Description = "A noble family becomes entangled in a war for control over the galaxy's most valuable asset while its heir becomes troubled by visions of a dark future.", Director = "Denis Villeneuve", Price = 24.99m, CategoryId = 4},
                new() { Id = 45, Title = "Star Wars: Episode IV - A New Hope", Description = "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.", Director = "George Lucas", Price = 19.99m, CategoryId = 4},
                new() { Id = 46, Title = "The Fifth Element", Description = "In the colorful future, a cab driver unwittingly becomes the central figure in the search for a legendary cosmic weapon to keep Evil and Mr. Zorg at bay.", Director = "Luc Besson", Price = 18.99m, CategoryId = 4},
                new() { Id = 47, Title = "E.T. the Extra-Terrestrial", Description = "A troubled child summons the courage to help a friendly alien escape Earth and return to his home world.", Director = "Steven Spielberg", Price = 17.99m, CategoryId = 4},
                new() { Id = 48, Title = "Minority Report", Description = "In a future where a special police unit is able to arrest murderers before they commit their crimes, an officer from that unit is himself accused of a future murder.", Director = "Steven Spielberg", Price = 16.99m, CategoryId = 4},

                // Horror
                new() { Id = 49, Title = "The Conjuring", Description = "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by a dark presence in their farmhouse.", Director = "James Wan", Price = 16.99m, CategoryId = 5},
                new() { Id = 50, Title = "Get Out", Description = "A young African-American visits his white girlfriend's parents for the weekend, where his uneasiness about their reception of him eventually reaches a boiling point.", Director = "Jordan Peele", Price = 17.99m, CategoryId = 5},
                new() { Id = 51, Title = "Hereditary", Description = "A grieving family is haunted by tragic and disturbing occurrences.", Director = "Ari Aster", Price = 18.99m, CategoryId = 5},
                new() { Id = 52, Title = "The Exorcist", Description = "When a 12-year-old girl is possessed by a mysterious entity, her mother seeks the help of two priests to save her.", Director = "William Friedkin", Price = 19.99m, CategoryId = 5},
                new() { Id = 53, Title = "A Quiet Place", Description = "In a post-apocalyptic world, a family is forced to live in silence while hiding from monsters with ultra-sensitive hearing.", Director = "John Krasinski", Price = 20.99m, CategoryId = 5},
                new() { Id = 54, Title = "The Shining", Description = "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.", Director = "Stanley Kubrick", Price = 21.99m, CategoryId = 5},
                new() { Id = 55, Title = "It", Description = "In the summer of 1989, a group of bullied kids band together to destroy a shapeshifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.", Director = "Andy Muschietti", Price = 22.99m, CategoryId = 5},
                new() { Id = 56, Title = "The Ring", Description = "A journalist must investigate a mysterious videotape which seems to cause the death of anyone in a week of viewing it.", Director = "Gore Verbinski", Price = 23.99m, CategoryId = 5},
                new() { Id = 57, Title = "Paranormal Activity", Description = "After moving into a suburban home, a couple becomes increasingly disturbed by a nightly demonic presence.", Director = "Oren Peli", Price = 24.99m, CategoryId = 5},
                new() { Id = 58, Title = "The Babadook", Description = "A single mother, plagued by the violent death of her husband, battles with her son's fear of a monster lurking in the house, but soon discovers a sinister presence all around her.", Director = "Jennifer Kent", Price = 25.99m, CategoryId = 5},
                new() { Id = 59, Title = "Sinister", Description = "Found footage helps a true-crime novelist realize how and why a family was murdered in his new home, though his discoveries put his entire family in the path of a supernatural entity.", Director = "Scott Derrickson", Price = 26.99m, CategoryId = 5},
                new() { Id = 60, Title = "Insidious", Description = "A family looks to prevent evil spirits from trapping their comatose child in a realm called The Further.", Director = "James Wan", Price = 27.99m, CategoryId = 5},

                // Romance
                new() { Id = 61, Title = "La La Land", Description = "A jazz pianist falls for an aspiring actress in Los Angeles.", Director = "Damien Chazelle", Price = 15.99m, CategoryId = 6},
                new() { Id = 62, Title = "The Notebook", Description = "A poor yet passionate young man falls in love with a rich young woman, giving her a sense of freedom, but they are soon separated because of their social differences.", Director = "Nick Cassavetes", Price = 14.99m, CategoryId = 6},
                new() { Id = 63, Title = "Titanic", Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.", Director = "James Cameron", Price = 13.99m, CategoryId = 6},
                new() { Id = 64, Title = "Pride & Prejudice", Description = "Sparks fly when spirited Elizabeth Bennet meets single, rich, and proud Mr. Darcy. But Mr. Darcy reluctantly finds himself falling in love with a woman beneath his class.", Director = "Joe Wright", Price = 12.99m, CategoryId = 6},
                new() { Id = 65, Title = "Before Sunrise", Description = "A young man and woman meet on a train in Europe, and wind up spending one evening together in Vienna. Unfortunately, both know that this will probably be their only night together.", Director = "Richard Linklater", Price = 11.99m, CategoryId = 6},
                new() { Id = 66, Title = "Crazy, Stupid, Love", Description = "A middle-aged husband's life changes dramatically when his wife asks him for a divorce. He seeks to rediscover his manhood with the help of a newfound friend.", Director = "Glenn Ficarra", Price = 10.99m, CategoryId = 6},
                new() { Id = 67, Title = "Eternal Sunshine of the Spotless Mind", Description = "When their relationship turns sour, a couple undergoes a medical procedure to have each other erased from their memories.", Director = "Michel Gondry", Price = 9.99m, CategoryId = 6},
                new() { Id = 68, Title = "A Star Is Born", Description = "A musician helps a young singer find fame, even as age and alcoholism send his own career into a downward spiral.", Director = "Bradley Cooper", Price = 8.99m, CategoryId = 6},
                new() { Id = 69, Title = "The Fault in Our Stars", Description = "Two teenage cancer patients begin a life-affirming journey to visit a reclusive author in Amsterdam.", Director = "Josh Boone", Price = 7.99m, CategoryId = 6},
                new() { Id = 70, Title = "Notting Hill", Description = "The life of a simple bookshop owner changes when he meets the most famous film star in the world.", Director = "Roger Michell", Price = 6.99m, CategoryId = 6},
                new() { Id = 71, Title = "Love Actually", Description = "Follows the lives of eight very different couples in dealing with their love lives in various loosely interrelated tales all set during a frantic month before Christmas in London, England.", Director = "Richard Curtis", Price = 5.99m, CategoryId = 6},
                new() { Id = 72, Title = "The Vow", Description = "A car accident puts Paige in a coma, and when she wakes up with severe memory loss, her husband Leo works to win her heart again.", Director = "Michael Sucsy", Price = 4.99m, CategoryId = 6},

                // Thriller
                new() { Id = 73, Title = "Pulp Fiction", Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", Director = "Quentin Tarantino", Price = 17.99m, CategoryId = 7},
                new() { Id = 74, Title = "Se7en", Description = "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.", Director = "David Fincher", Price = 18.99m, CategoryId = 7},
                new() { Id = 75, Title = "The Silence of the Lambs", Description = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer.", Director = "Jonathan Demme", Price = 19.99m, CategoryId = 7},
                new() { Id = 76, Title = "Gone Girl", Description = "With his wife's disappearance having become the focus of an intense media circus, a man sees the spotlight turned on him when it's suspected that he may not be innocent.", Director = "David Fincher", Price = 20.99m, CategoryId = 7},
                new() { Id = 77, Title = "Shutter Island", Description = "In 1954, a U.S. Marshal investigates the disappearance of a murderer who escaped from a hospital for the criminally insane.", Director = "Martin Scorsese", Price = 21.99m, CategoryId = 7},
                new() { Id = 78, Title = "The Girl with the Dragon Tattoo", Description = "Journalist Mikael Blomkvist is aided in his search for a woman who has been missing for forty years by Lisbeth Salander, a young computer hacker.", Director = "David Fincher", Price = 22.99m, CategoryId = 7},
                new() { Id = 79, Title = "Prisoners", Description = "When Keller Dover's daughter and her friend go missing, he takes matters into his own hands as the police pursue multiple leads and the pressure mounts.", Director = "Denis Villeneuve", Price = 23.99m, CategoryId = 7},
                new() { Id = 80, Title = "Zodiac", Description = "In the late 1960s/early 1970s, a San Francisco cartoonist becomes an amateur detective obsessed with tracking down the Zodiac Killer.", Director = "David Fincher", Price = 24.99m, CategoryId = 7},
                new() { Id = 81, Title = "The Departed", Description = "An undercover cop and a mole in the Massachusetts State Police infiltrate an Irish gang in South Boston.", Director = "Martin Scorsese", Price = 25.99m, CategoryId = 7},
                new() { Id = 82, Title = "Memento", Description = "A man with short-term memory loss attempts to track down his wife's murderer.", Director = "Christopher Nolan", Price = 26.99m, CategoryId = 7},
                new() { Id = 83, Title = "Oldboy", Description = "After being kidnapped and imprisoned for fifteen years, Oh Dae-Su is released, only to find that he must find his captor in five days.", Director = "Park Chan-wook", Price = 27.99m, CategoryId = 7},
                new() { Id = 84, Title = "The Usual Suspects", Description = "A sole survivor tells of the twisty events leading up to a horrific gun battle on a boat, which began when five criminals met at a seemingly random police lineup.", Director = "Bryan Singer", Price = 28.99m, CategoryId = 7},

                // Animation
                new() { Id = 85, Title = "Toy Story", Description = "A cowboy doll is profoundly threatened and jealous when a new spaceman action figure supplants him as top toy in a boy's room.", Director = "John Lasseter", Price = 12.99m, CategoryId = 8},
                new() { Id = 86, Title = "Frozen", Description = "When the newly crowned Queen Elsa accidentally uses her power to turn things into ice to curse her home in infinite winter, her sister Anna teams up with a mountain man, his playful reindeer, and a snowman to change the weather condition.", Director = "Chris Buck", Price = 13.99m, CategoryId = 8},
                new() { Id = 87, Title = "The Lion King", Description = "A young lion prince is cast out of his pride by his cruel uncle, who claims he killed his father. While the uncle rules with an iron paw, the prince grows up beyond the Savannah, living by a philosophy: No worries for the rest of your days.", Director = "Jon Favreau", Price = 14.99m, CategoryId = 8},
                new() { Id = 88, Title = "Finding Nemo", Description = "After his son is captured in the Great Barrier Reef and taken to Sydney, a timid clownfish sets out on a journey to bring him home.", Director = "Andrew Stanton", Price = 15.99m, CategoryId = 8},
                new() { Id = 89, Title = "Up", Description = "Seventy-eight year old Carl Fredricksen travels to Paradise Falls in his home equipped with balloons, inadvertently taking a young stowaway.", Director = "Pete Docter", Price = 16.99m, CategoryId = 8},
                new() { Id = 90, Title = "Inside Out", Description = "After young Riley is uprooted from her Midwest life and moved to San Francisco, her emotions - Joy, Fear, Anger, Disgust and Sadness - conflict on how best to navigate a new city, house, and school.", Director = "Pete Docter", Price = 17.99m, CategoryId = 8},
                new() { Id = 91, Title = "Shrek", Description = "A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.", Director = "Andrew Adamson", Price = 18.99m, CategoryId = 8},
                new() { Id = 92, Title = "Zootopia", Description = "In a city of anthropomorphic animals, a rookie bunny cop and a cynical con artist fox must work together to uncover a conspiracy.", Director = "Byron Howard", Price = 19.99m, CategoryId = 8},
                new() { Id = 93, Title = "Moana", Description = "In Ancient Polynesia, when a terrible curse incurred by the Demigod Maui reaches Moana's island, she answers the Ocean's call to seek out the Demigod to set things right.", Director = "Ron Clements", Price = 20.99m, CategoryId = 8},
                new() { Id = 94, Title = "Coco", Description = "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead to find his great-great-grandfather, a legendary singer.", Director = "Lee Unkrich", Price = 21.99m, CategoryId = 8},
                new() { Id = 95, Title = "The Incredibles", Description = "A family of undercover superheroes, while trying to live the quiet suburban life, are forced into action to save the world.", Director = "Brad Bird", Price = 22.99m, CategoryId = 8},
                new() { Id = 96, Title = "Despicable Me", Description = "When a criminal mastermind uses a trio of orphan girls as pawns for a grand scheme, he finds their love is profoundly changing him for the better.", Director = "Pierre Coffin", Price = 23.99m, CategoryId = 8},

                // Documentary
                new() { Id = 97, Title = "The Act of Killing", Description = "A documentary that challenges former Indonesian death-squad leaders to reenact their real-life mass-killings in the style of the American movies they love.", Director = "Joshua Oppenheimer", Price = 12.99m, CategoryId = 9},
                new() { Id = 98, Title = "Blackfish", Description = "A documentary following the controversial captivity of killer whales, and its dangers for both humans and whales.", Director = "Gabriela Cowperthwaite", Price = 13.99m, CategoryId = 9},
                new() { Id = 99, Title = "Jiro Dreams of Sushi", Description = "A documentary on 85-year-old sushi master Jiro Ono, his renowned Tokyo restaurant, and his relationship with his son and eventual heir, Yoshikazu.", Director = "David Gelb", Price = 14.99m, CategoryId = 9},
                new() { Id = 100, Title = "March of the Penguins", Description = "In the Antarctic, every March since the beginning of time, the quest begins to find the perfect mate and start a family.", Director = "Luc Jacquet", Price = 15.99m, CategoryId = 9},
                new() { Id = 101, Title = "An Inconvenient Truth", Description = "Filmmaker Davis Guggenheim follows Al Gore on the lecture circuit, as the former presidential candidate campaigns to raise public awareness of the dangers of global warming.", Director = "Davis Guggenheim", Price = 16.99m, CategoryId = 9},
                new() { Id = 102, Title = "The Last Dance", Description = "Charting the rise of Michael Jordan's iconic career, with rare and never-before-seen footage.", Director = "Jason Hehir", Price = 17.99m, CategoryId = 9},
                new() { Id = 103, Title = "Free Solo", Description = "Alex Honnold attempts to become the first person to ever free solo climb El Capitan.", Director = "Elizabeth Chai Vasarhelyi", Price = 18.99m, CategoryId = 9},
                new() { Id = 104, Title = "Won't You Be My Neighbor?", Description = "An exploration of the life, lessons, and legacy of iconic children's television host, Fred Rogers.", Director = "Morgan Neville", Price = 19.99m, CategoryId = 9},
                new() { Id = 105, Title = "The Cove", Description = "Using state-of-the-art equipment, a group of activists, led by renowned dolphin trainer Ric O'Barry, infiltrate a cove near Taiji, Japan to expose both a shocking instance of animal abuse and a serious threat to human health.", Director = "Louie Psihoyos", Price = 20.99m, CategoryId = 9},
                new() { Id = 106, Title = "Citizenfour", Description = "A documentarian and a reporter travel to Hong Kong for the first of many meetings with Edward Snowden.", Director = "Laura Poitras", Price = 21.99m, CategoryId = 9},
                new() { Id = 107, Title = "Man on Wire", Description = "A look at tightrope walker Philippe Petit's daring, but illegal, high-wire routine performed between New York City's World Trade Center's twin towers in 1974, what some consider the artistic crime of the century.", Director = "James Marsh", Price = 22.99m, CategoryId = 9},
                new() { Id = 108, Title = "Amy", Description = "Archival footage and personal testimonies present an intimate portrait of the life and career of British singer-songwriter Amy Winehouse.", Director = "Asif Kapadia", Price = 23.99m, CategoryId = 9},

                // Fantasy
                new() { Id = 109, Title = "The Lord of the Rings: The Fellowship of the Ring", Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", Director = "Peter Jackson", Price = 24.99m, CategoryId = 10},
                new() { Id = 110, Title = "Harry Potter and the Sorcerer's Stone", Description = "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.", Director = "Chris Columbus", Price = 23.99m, CategoryId = 10},
                new() { Id = 111, Title = "Pan's Labyrinth", Description = "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.", Director = "Guillermo del Toro", Price = 22.99m, CategoryId = 10},
                new() { Id = 112, Title = "The Princess Bride", Description = "While home sick in bed, a young boy's grandfather reads him the story of a farmboy-turned-pirate who encounters numerous obstacles, enemies and allies in his quest to be reunited with his true love.", Director = "Rob Reiner", Price = 21.99m, CategoryId = 10},
                new() { Id = 113, Title = "Stardust", Description = "In a countryside town bordering on a magical land, a young man makes a promise to his beloved that he'll retrieve a fallen star by venturing into the magical realm.", Director = "Matthew Vaughn", Price = 20.99m, CategoryId = 10},
                new() { Id = 114, Title = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe", Description = "Four siblings step through a wardrobe door and into the land of Narnia, a land frozen in eternal winter and enslaved by the power of the White Witch.", Director = "Andrew Adamson", Price = 19.99m, CategoryId = 10},
                new() { Id = 115, Title = "Willow", Description = "A reluctant dwarf must play a critical role in protecting a special baby from an evil queen.", Director = "Ron Howard", Price = 18.99m, CategoryId = 10},
                new() { Id = 116, Title = "The NeverEnding Story", Description = "A troubled boy dives into a wondrous fantasy world through the pages of a mysterious book.", Director = "Wolfgang Petersen", Price = 17.99m, CategoryId = 10},
                new() { Id = 117, Title = "Legend", Description = "A young man must stop the Lord of Darkness from both destroying daylight and marrying the woman he loves.", Director = "Ridley Scott", Price = 16.99m, CategoryId = 10},
                new() { Id = 118, Title = "The Dark Crystal", Description = "On another planet in the distant past, a Gelfling embarks on a quest to find the missing shard of a magical crystal, and so restore order to his world.", Director = "Jim Henson", Price = 15.99m, CategoryId = 10},
                new() { Id = 119, Title = "Labyrinth", Description = "Sixteen-year-old Sarah is given thirteen hours to solve a labyrinth and rescue her baby brother Toby when her wish for him to be taken away is granted by the Goblin King.", Director = "Jim Henson", Price = 14.99m, CategoryId = 10},
                new() { Id = 120, Title = "The Spiderwick Chronicles", Description = "Upon moving into the run-down Spiderwick Estate with their mother, twin brothers Jared and Simon Grace, along with their sister Mallory, find themselves pulled into an alternate world full of faeries and other creatures.", Director = "Mark Waters", Price = 13.99m, CategoryId = 10}
            };




            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Movie>().HasData(movies);
        }
    }
}