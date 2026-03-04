using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mgr_1_2_TI.Migrations
{
    /// <inheritdoc />
    public partial class migr_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "T_Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Fast-paced movies with intense physical action, stunts, and battles.", "Action" },
                    { 2, "Light-hearted films designed to make the audience laugh.", "Comedy" },
                    { 3, "Serious films focusing on realistic characters and emotional themes.", "Drama" },
                    { 4, "Movies exploring futuristic concepts, advanced technology, and space exploration.", "Sci-Fi" },
                    { 5, "Films intended to frighten, shock, or suspense the audience.", "Horror" },
                    { 6, "Stories centered on passionate, emotional, and romantic involvement.", "Romance" },
                    { 7, "Suspenseful movies with tension, excitement, and a sense of danger.", "Thriller" },
                    { 8, "Films created using animation techniques, often aimed at children and families.", "Animation" },
                    { 9, "Non-fictional films intended to document reality, primarily for instruction or maintaining a historical record.", "Documentary" },
                    { 10, "Movies set in imaginary worlds, often involving magic, mythical creatures, and supernatural events.", "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "T_Movies",
                columns: new[] { "Id", "CategoryId", "Description", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "A superhero film about Batman facing the Joker in Gotham City.", "Christopher Nolan", 19.99m, "The Dark Knight" },
                    { 2, 1, "In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the aid of a group of female prisoners, a psychotic worshiper, and a drifter named Max.", "George Miller", 18.99m, "Mad Max: Fury Road" },
                    { 3, 1, "An ex-hit-man comes out of retirement to track down the gangsters that killed his dog and took everything from him.", "Chad Stahelski", 17.99m, "John Wick" },
                    { 4, 1, "An NYPD officer tries to save his wife and several others taken hostage by German terrorists during a Christmas party at the Nakatomi Plaza in Los Angeles.", "John McTiernan", 16.99m, "Die Hard" },
                    { 5, 1, "Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.", "Joss Whedon", 21.99m, "The Avengers" },
                    { 6, 1, "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", "Ridley Scott", 20.99m, "Gladiator" },
                    { 7, 1, "Ethan Hunt and his IMF team, along with some familiar allies, race against time after a mission gone wrong.", "Christopher McQuarrie", 22.99m, "Mission: Impossible - Fallout" },
                    { 8, 1, "A man is picked up by a fishing boat, bullet-riddled and suffering from amnesia, before racing to elude assassins and regain his memory.", "Doug Liman", 15.99m, "The Bourne Identity" },
                    { 9, 1, "A young police officer must prevent a bomb exploding aboard a city bus by keeping its speed above 50 mph.", "Jan de Bont", 14.99m, "Speed" },
                    { 10, 1, "A human soldier is sent from 2029 to 1984 to stop an almost indestructible cyborg killing machine, sent from the same year, which has been programmed to execute a young woman whose unborn son is the key to humanity's future salvation.", "James Cameron", 13.99m, "The Terminator" },
                    { 11, 1, "After earning 00 status and a licence to kill, Secret Agent James Bond sets out on his first mission as 007. Bond must defeat a private banker funding terrorists in a high-stakes game of poker at Casino Royale, Montenegro.", "Martin Campbell", 19.99m, "Casino Royale" },
                    { 12, 1, "A S.W.A.T. team becomes trapped in a tenement run by a ruthless mobster and his army of killers and thugs.", "Gareth Evans", 16.99m, "The Raid" },
                    { 13, 2, "Two co-dependent high school seniors are forced to deal with separation anxiety after their plan to stage a booze-soaked party goes awry.", "Greg Mottola", 9.99m, "Superbad" },
                    { 14, 2, "Three buddies wake up from a bachelor party in Las Vegas, with no memory of the previous night and the bachelor missing.", "Todd Phillips", 11.99m, "The Hangover" },
                    { 15, 2, "Competition between the maid of honor and a bridesmaid, over who is the bride's best friend, threatens to upend the life of an out-of-work pastry chef.", "Paul Feig", 10.99m, "Bridesmaids" },
                    { 16, 2, "Two aimless middle-aged losers still living at home are forced against their will to become roommates when their parents marry.", "Adam McKay", 12.99m, "Step Brothers" },
                    { 17, 2, "Ron Burgundy is San Diego's top-rated newsman in the male-dominated broadcasting of the 1970s, but that's all about to change for Ron and his cronies when an ambitious woman shows up.", "Adam McKay", 13.99m, "Anchorman: The Legend of Ron Burgundy" },
                    { 18, 2, "The cross-country adventures of two good-hearted but incredibly stupid friends.", "Peter Farrelly", 14.99m, "Dumb and Dumber" },
                    { 19, 2, "Goaded by his buddies, a nerdy guy who's never 'done the deed' only finds the pressure mounting when he meets a single mother.", "Judd Apatow", 15.99m, "The 40-Year-Old Virgin" },
                    { 20, 2, "At the end of his career, a clueless fashion model is brainwashed to kill the Prime Minister of Malaysia.", "Ben Stiller", 16.99m, "Zoolander" },
                    { 21, 2, "Three friends attempt to recapture their glory days by opening up a fraternity near their old alma mater.", "Todd Phillips", 17.99m, "Old School" },
                    { 22, 2, "A man afraid to fly must ensure that a plane lands safely after the pilots become sick.", "Jim Abrahams", 18.99m, "Airplane!" },
                    { 23, 2, "Two mismatched New York City detectives seize an opportunity to step up like the city's top cops, whom they idolize, only things don't quite go as planned.", "Adam McKay", 19.99m, "The Other Guys" },
                    { 24, 2, "Through a series of freak occurrences, a group of actors shooting a big-budget war movie are forced to become the soldiers they are portraying.", "Ben Stiller", 20.99m, "Tropic Thunder" },
                    { 25, 3, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "Frank Darabont", 14.99m, "The Shawshank Redemption" },
                    { 26, 3, "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75.", "Robert Zemeckis", 13.99m, "Forrest Gump" },
                    { 27, 3, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "Francis Ford Coppola", 19.99m, "The Godfather" },
                    { 28, 3, "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "Steven Spielberg", 18.99m, "Schindler's List" },
                    { 29, 3, "A struggling salesman takes custody of his son as he's poised to begin a life-changing professional career.", "Gabriele Muccino", 17.99m, "The Pursuit of Happyness" },
                    { 30, 3, "Will Hunting, a janitor at M.I.T., has a gift for mathematics, but needs help from a psychologist to find direction in his life.", "Gus Van Sant", 16.99m, "Good Will Hunting" },
                    { 31, 3, "After John Nash, a brilliant but asocial mathematician, accepts secret work in cryptography, his life takes a turn for the nightmarish.", "Ron Howard", 15.99m, "A Beautiful Mind" },
                    { 32, 3, "Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, but is later sued by two brothers who claimed he stole their idea.", "David Fincher", 16.99m, "The Social Network" },
                    { 33, 3, "Selfish yuppie Charlie Babbitt's father left a fortune to his savant brother Raymond and a pittance to Charlie; they travel cross-country.", "Barry Levinson", 14.99m, "Rain Man" },
                    { 34, 3, "The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape but who has a mysterious gift.", "Frank Darabont", 13.99m, "The Green Mile" },
                    { 35, 3, "A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II.", "Roman Polanski", 12.99m, "The Pianist" },
                    { 36, 3, "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "Sidney Lumet", 11.99m, "12 Angry Men" },
                    { 37, 4, "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "Christopher Nolan", 22.99m, "Inception" },
                    { 38, 4, "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", "Lana Wachowski", 20.99m, "The Matrix" },
                    { 39, 4, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "Christopher Nolan", 21.99m, "Interstellar" },
                    { 40, 4, "A young blade runner's discovery of a long-buried secret leads him to track down former blade runner Rick Deckard, who's been missing for thirty years.", "Denis Villeneuve", 23.99m, "Blade Runner 2049" },
                    { 41, 4, "A linguist works with the military to communicate with alien lifeforms after twelve mysterious spacecraft appear around the world.", "Denis Villeneuve", 22.99m, "Arrival" },
                    { 42, 4, "An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive.", "Ridley Scott", 21.99m, "The Martian" },
                    { 43, 4, "A young programmer is selected to participate in a ground-breaking experiment in synthetic intelligence by evaluating the human qualities of a breathtaking female A.I.", "Alex Garland", 20.99m, "Ex Machina" },
                    { 44, 4, "A noble family becomes entangled in a war for control over the galaxy's most valuable asset while its heir becomes troubled by visions of a dark future.", "Denis Villeneuve", 24.99m, "Dune" },
                    { 45, 4, "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.", "George Lucas", 19.99m, "Star Wars: Episode IV - A New Hope" },
                    { 46, 4, "In the colorful future, a cab driver unwittingly becomes the central figure in the search for a legendary cosmic weapon to keep Evil and Mr. Zorg at bay.", "Luc Besson", 18.99m, "The Fifth Element" },
                    { 47, 4, "A troubled child summons the courage to help a friendly alien escape Earth and return to his home world.", "Steven Spielberg", 17.99m, "E.T. the Extra-Terrestrial" },
                    { 48, 4, "In a future where a special police unit is able to arrest murderers before they commit their crimes, an officer from that unit is himself accused of a future murder.", "Steven Spielberg", 16.99m, "Minority Report" },
                    { 49, 5, "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by a dark presence in their farmhouse.", "James Wan", 16.99m, "The Conjuring" },
                    { 50, 5, "A young African-American visits his white girlfriend's parents for the weekend, where his uneasiness about their reception of him eventually reaches a boiling point.", "Jordan Peele", 17.99m, "Get Out" },
                    { 51, 5, "A grieving family is haunted by tragic and disturbing occurrences.", "Ari Aster", 18.99m, "Hereditary" },
                    { 52, 5, "When a 12-year-old girl is possessed by a mysterious entity, her mother seeks the help of two priests to save her.", "William Friedkin", 19.99m, "The Exorcist" },
                    { 53, 5, "In a post-apocalyptic world, a family is forced to live in silence while hiding from monsters with ultra-sensitive hearing.", "John Krasinski", 20.99m, "A Quiet Place" },
                    { 54, 5, "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.", "Stanley Kubrick", 21.99m, "The Shining" },
                    { 55, 5, "In the summer of 1989, a group of bullied kids band together to destroy a shapeshifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.", "Andy Muschietti", 22.99m, "It" },
                    { 56, 5, "A journalist must investigate a mysterious videotape which seems to cause the death of anyone in a week of viewing it.", "Gore Verbinski", 23.99m, "The Ring" },
                    { 57, 5, "After moving into a suburban home, a couple becomes increasingly disturbed by a nightly demonic presence.", "Oren Peli", 24.99m, "Paranormal Activity" },
                    { 58, 5, "A single mother, plagued by the violent death of her husband, battles with her son's fear of a monster lurking in the house, but soon discovers a sinister presence all around her.", "Jennifer Kent", 25.99m, "The Babadook" },
                    { 59, 5, "Found footage helps a true-crime novelist realize how and why a family was murdered in his new home, though his discoveries put his entire family in the path of a supernatural entity.", "Scott Derrickson", 26.99m, "Sinister" },
                    { 60, 5, "A family looks to prevent evil spirits from trapping their comatose child in a realm called The Further.", "James Wan", 27.99m, "Insidious" },
                    { 61, 6, "A jazz pianist falls for an aspiring actress in Los Angeles.", "Damien Chazelle", 15.99m, "La La Land" },
                    { 62, 6, "A poor yet passionate young man falls in love with a rich young woman, giving her a sense of freedom, but they are soon separated because of their social differences.", "Nick Cassavetes", 14.99m, "The Notebook" },
                    { 63, 6, "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.", "James Cameron", 13.99m, "Titanic" },
                    { 64, 6, "Sparks fly when spirited Elizabeth Bennet meets single, rich, and proud Mr. Darcy. But Mr. Darcy reluctantly finds himself falling in love with a woman beneath his class.", "Joe Wright", 12.99m, "Pride & Prejudice" },
                    { 65, 6, "A young man and woman meet on a train in Europe, and wind up spending one evening together in Vienna. Unfortunately, both know that this will probably be their only night together.", "Richard Linklater", 11.99m, "Before Sunrise" },
                    { 66, 6, "A middle-aged husband's life changes dramatically when his wife asks him for a divorce. He seeks to rediscover his manhood with the help of a newfound friend.", "Glenn Ficarra", 10.99m, "Crazy, Stupid, Love" },
                    { 67, 6, "When their relationship turns sour, a couple undergoes a medical procedure to have each other erased from their memories.", "Michel Gondry", 9.99m, "Eternal Sunshine of the Spotless Mind" },
                    { 68, 6, "A musician helps a young singer find fame, even as age and alcoholism send his own career into a downward spiral.", "Bradley Cooper", 8.99m, "A Star Is Born" },
                    { 69, 6, "Two teenage cancer patients begin a life-affirming journey to visit a reclusive author in Amsterdam.", "Josh Boone", 7.99m, "The Fault in Our Stars" },
                    { 70, 6, "The life of a simple bookshop owner changes when he meets the most famous film star in the world.", "Roger Michell", 6.99m, "Notting Hill" },
                    { 71, 6, "Follows the lives of eight very different couples in dealing with their love lives in various loosely interrelated tales all set during a frantic month before Christmas in London, England.", "Richard Curtis", 5.99m, "Love Actually" },
                    { 72, 6, "A car accident puts Paige in a coma, and when she wakes up with severe memory loss, her husband Leo works to win her heart again.", "Michael Sucsy", 4.99m, "The Vow" },
                    { 73, 7, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Quentin Tarantino", 17.99m, "Pulp Fiction" },
                    { 74, 7, "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.", "David Fincher", 18.99m, "Se7en" },
                    { 75, 7, "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer.", "Jonathan Demme", 19.99m, "The Silence of the Lambs" },
                    { 76, 7, "With his wife's disappearance having become the focus of an intense media circus, a man sees the spotlight turned on him when it's suspected that he may not be innocent.", "David Fincher", 20.99m, "Gone Girl" },
                    { 77, 7, "In 1954, a U.S. Marshal investigates the disappearance of a murderer who escaped from a hospital for the criminally insane.", "Martin Scorsese", 21.99m, "Shutter Island" },
                    { 78, 7, "Journalist Mikael Blomkvist is aided in his search for a woman who has been missing for forty years by Lisbeth Salander, a young computer hacker.", "David Fincher", 22.99m, "The Girl with the Dragon Tattoo" },
                    { 79, 7, "When Keller Dover's daughter and her friend go missing, he takes matters into his own hands as the police pursue multiple leads and the pressure mounts.", "Denis Villeneuve", 23.99m, "Prisoners" },
                    { 80, 7, "In the late 1960s/early 1970s, a San Francisco cartoonist becomes an amateur detective obsessed with tracking down the Zodiac Killer.", "David Fincher", 24.99m, "Zodiac" },
                    { 81, 7, "An undercover cop and a mole in the Massachusetts State Police infiltrate an Irish gang in South Boston.", "Martin Scorsese", 25.99m, "The Departed" },
                    { 82, 7, "A man with short-term memory loss attempts to track down his wife's murderer.", "Christopher Nolan", 26.99m, "Memento" },
                    { 83, 7, "After being kidnapped and imprisoned for fifteen years, Oh Dae-Su is released, only to find that he must find his captor in five days.", "Park Chan-wook", 27.99m, "Oldboy" },
                    { 84, 7, "A sole survivor tells of the twisty events leading up to a horrific gun battle on a boat, which began when five criminals met at a seemingly random police lineup.", "Bryan Singer", 28.99m, "The Usual Suspects" },
                    { 85, 8, "A cowboy doll is profoundly threatened and jealous when a new spaceman action figure supplants him as top toy in a boy's room.", "John Lasseter", 12.99m, "Toy Story" },
                    { 86, 8, "When the newly crowned Queen Elsa accidentally uses her power to turn things into ice to curse her home in infinite winter, her sister Anna teams up with a mountain man, his playful reindeer, and a snowman to change the weather condition.", "Chris Buck", 13.99m, "Frozen" },
                    { 87, 8, "A young lion prince is cast out of his pride by his cruel uncle, who claims he killed his father. While the uncle rules with an iron paw, the prince grows up beyond the Savannah, living by a philosophy: No worries for the rest of your days.", "Jon Favreau", 14.99m, "The Lion King" },
                    { 88, 8, "After his son is captured in the Great Barrier Reef and taken to Sydney, a timid clownfish sets out on a journey to bring him home.", "Andrew Stanton", 15.99m, "Finding Nemo" },
                    { 89, 8, "Seventy-eight year old Carl Fredricksen travels to Paradise Falls in his home equipped with balloons, inadvertently taking a young stowaway.", "Pete Docter", 16.99m, "Up" },
                    { 90, 8, "After young Riley is uprooted from her Midwest life and moved to San Francisco, her emotions - Joy, Fear, Anger, Disgust and Sadness - conflict on how best to navigate a new city, house, and school.", "Pete Docter", 17.99m, "Inside Out" },
                    { 91, 8, "A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.", "Andrew Adamson", 18.99m, "Shrek" },
                    { 92, 8, "In a city of anthropomorphic animals, a rookie bunny cop and a cynical con artist fox must work together to uncover a conspiracy.", "Byron Howard", 19.99m, "Zootopia" },
                    { 93, 8, "In Ancient Polynesia, when a terrible curse incurred by the Demigod Maui reaches Moana's island, she answers the Ocean's call to seek out the Demigod to set things right.", "Ron Clements", 20.99m, "Moana" },
                    { 94, 8, "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead to find his great-great-grandfather, a legendary singer.", "Lee Unkrich", 21.99m, "Coco" },
                    { 95, 8, "A family of undercover superheroes, while trying to live the quiet suburban life, are forced into action to save the world.", "Brad Bird", 22.99m, "The Incredibles" },
                    { 96, 8, "When a criminal mastermind uses a trio of orphan girls as pawns for a grand scheme, he finds their love is profoundly changing him for the better.", "Pierre Coffin", 23.99m, "Despicable Me" },
                    { 97, 9, "A documentary that challenges former Indonesian death-squad leaders to reenact their real-life mass-killings in the style of the American movies they love.", "Joshua Oppenheimer", 12.99m, "The Act of Killing" },
                    { 98, 9, "A documentary following the controversial captivity of killer whales, and its dangers for both humans and whales.", "Gabriela Cowperthwaite", 13.99m, "Blackfish" },
                    { 99, 9, "A documentary on 85-year-old sushi master Jiro Ono, his renowned Tokyo restaurant, and his relationship with his son and eventual heir, Yoshikazu.", "David Gelb", 14.99m, "Jiro Dreams of Sushi" },
                    { 100, 9, "In the Antarctic, every March since the beginning of time, the quest begins to find the perfect mate and start a family.", "Luc Jacquet", 15.99m, "March of the Penguins" },
                    { 101, 9, "Filmmaker Davis Guggenheim follows Al Gore on the lecture circuit, as the former presidential candidate campaigns to raise public awareness of the dangers of global warming.", "Davis Guggenheim", 16.99m, "An Inconvenient Truth" },
                    { 102, 9, "Charting the rise of Michael Jordan's iconic career, with rare and never-before-seen footage.", "Jason Hehir", 17.99m, "The Last Dance" },
                    { 103, 9, "Alex Honnold attempts to become the first person to ever free solo climb El Capitan.", "Elizabeth Chai Vasarhelyi", 18.99m, "Free Solo" },
                    { 104, 9, "An exploration of the life, lessons, and legacy of iconic children's television host, Fred Rogers.", "Morgan Neville", 19.99m, "Won't You Be My Neighbor?" },
                    { 105, 9, "Using state-of-the-art equipment, a group of activists, led by renowned dolphin trainer Ric O'Barry, infiltrate a cove near Taiji, Japan to expose both a shocking instance of animal abuse and a serious threat to human health.", "Louie Psihoyos", 20.99m, "The Cove" },
                    { 106, 9, "A documentarian and a reporter travel to Hong Kong for the first of many meetings with Edward Snowden.", "Laura Poitras", 21.99m, "Citizenfour" },
                    { 107, 9, "A look at tightrope walker Philippe Petit's daring, but illegal, high-wire routine performed between New York City's World Trade Center's twin towers in 1974, what some consider the artistic crime of the century.", "James Marsh", 22.99m, "Man on Wire" },
                    { 108, 9, "Archival footage and personal testimonies present an intimate portrait of the life and career of British singer-songwriter Amy Winehouse.", "Asif Kapadia", 23.99m, "Amy" },
                    { 109, 10, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "Peter Jackson", 24.99m, "The Lord of the Rings: The Fellowship of the Ring" },
                    { 110, 10, "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.", "Chris Columbus", 23.99m, "Harry Potter and the Sorcerer's Stone" },
                    { 111, 10, "In the falangist Spain of 1944, the bookish young stepdaughter of a sadistic army officer escapes into an eerie but captivating fantasy world.", "Guillermo del Toro", 22.99m, "Pan's Labyrinth" },
                    { 112, 10, "While home sick in bed, a young boy's grandfather reads him the story of a farmboy-turned-pirate who encounters numerous obstacles, enemies and allies in his quest to be reunited with his true love.", "Rob Reiner", 21.99m, "The Princess Bride" },
                    { 113, 10, "In a countryside town bordering on a magical land, a young man makes a promise to his beloved that he'll retrieve a fallen star by venturing into the magical realm.", "Matthew Vaughn", 20.99m, "Stardust" },
                    { 114, 10, "Four siblings step through a wardrobe door and into the land of Narnia, a land frozen in eternal winter and enslaved by the power of the White Witch.", "Andrew Adamson", 19.99m, "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe" },
                    { 115, 10, "A reluctant dwarf must play a critical role in protecting a special baby from an evil queen.", "Ron Howard", 18.99m, "Willow" },
                    { 116, 10, "A troubled boy dives into a wondrous fantasy world through the pages of a mysterious book.", "Wolfgang Petersen", 17.99m, "The NeverEnding Story" },
                    { 117, 10, "A young man must stop the Lord of Darkness from both destroying daylight and marrying the woman he loves.", "Ridley Scott", 16.99m, "Legend" },
                    { 118, 10, "On another planet in the distant past, a Gelfling embarks on a quest to find the missing shard of a magical crystal, and so restore order to his world.", "Jim Henson", 15.99m, "The Dark Crystal" },
                    { 119, 10, "Sixteen-year-old Sarah is given thirteen hours to solve a labyrinth and rescue her baby brother Toby when her wish for him to be taken away is granted by the Goblin King.", "Jim Henson", 14.99m, "Labyrinth" },
                    { 120, 10, "Upon moving into the run-down Spiderwick Estate with their mother, twin brothers Jared and Simon Grace, along with their sister Mallory, find themselves pulled into an alternate world full of faeries and other creatures.", "Mark Waters", 13.99m, "The Spiderwick Chronicles" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "T_Movies",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "T_Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "T_Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "T_Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "T_Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "T_Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "T_Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "T_Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "T_Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "T_Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "T_Categories",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
