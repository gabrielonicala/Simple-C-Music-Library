using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Database
{
    public static class FakeDatabase
    {
        public static List<Song> Songs = new List<Song>()
        {
            new Song()
            {
                Id = Guid.NewGuid(),
                Title = "Acele",
                Artist = "Carla's Dreams",
                Category = CategoryNames.Pop
            },
            new Song
            {
                Id = Guid.NewGuid(),
                Title = "Solo",
                Artist = "Future",
                Category = CategoryNames.Rap
            },
            new Song
            {
                Id = Guid.NewGuid(),
                Title = "Something In The Way",
                Artist = "Nirvana",
                Category = CategoryNames.Rock
            },
            new Song
            {
                Id = Guid.NewGuid(),
                Title = "De ziua ta",
                Artist = "3 Sud Est",
                Category = CategoryNames.Pop
            },
            new Song
            {
                Id = Guid.NewGuid(),
                Title = "In The End",
                Artist = "Linkin Park",
                Category = CategoryNames.Rock
            },
            new Song
            {
                Id = Guid.NewGuid(),
                Title = "Ya BB",
                Artist = "Play'n'Win",
                Category = CategoryNames.House
            },
            new Song
            {
                Id = Guid.NewGuid(),
                Title = "Already Over",
                Artist = "Red",
                Category = CategoryNames.Rock
            },
            new Song
            {
                Id = Guid.NewGuid(),
                Title = "This Life",
                Artist = "Denzel Curry",
                Category = CategoryNames.Rap
            },
            new Song
            {
                Id = Guid.NewGuid(),
                Title = "American Dream",
                Artist = "Simplu",
                Category = CategoryNames.Pop
            }
        };

        public static List<Client> Clients = new List<Client>()
        { 
            new Client
            {
                Id = Guid.NewGuid(),
                Name = "Marius Popescu",
                Age = 24,
                Preference = CategoryNames.Rock
            },
            new Client
            {
                Id = Guid.NewGuid(),
                Name = "Adrian Radulescu",
                Age = 19,
                Preference = CategoryNames.Rap
            },
            new Client
            {
                Id = Guid.NewGuid(),
                Name = "Evelina Ionescu",
                Age = 28,
                Preference = CategoryNames.Pop,
            },
            new Client
            {
                Id = Guid.NewGuid(),
                Name = "Diana Anton",
                Age = 24,
                Preference = CategoryNames.House
            }
        }
        ;

        public static List<Category> Categories = new List<Category>()
        {
            new Category
            {
                Name = CategoryNames.Pop,
                Popularity = 5
            },
            new Category
            {
                Name = CategoryNames.House,
                Popularity = 3
            },
            new Category
            {
                Name = CategoryNames.Rap,
                Popularity = 4
            },
            new Category
            {
                Name = CategoryNames.Rock,
                Popularity = 4
            }  
        };
    }
}
