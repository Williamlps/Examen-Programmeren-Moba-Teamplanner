using Examen___Programmeren___Moba_Teamplanner.Enums;
using Examen___Programmeren___Moba_Teamplanner.Models;

namespace Examen___Programmeren___Moba_Teamplanner.Data
{
    public static class SeedData
    {
        public static void SeedChampions(AppDbContext context)
        {
            var champions = new List<Champ>
            {
                new Champ { Name = "Garen", MainRole = Role.Top, Difficulty = Difficulty.Easy, Type = ChampionType.Fighter | ChampionType.Tank, IsFavorite = true },
                new Champ { Name = "Darius", MainRole = Role.Top, Difficulty = Difficulty.Medium, Type = ChampionType.Fighter | ChampionType.Tank, IsFavorite = false },
                new Champ { Name = "Fiora", MainRole = Role.Top, Difficulty = Difficulty.Hard, Type = ChampionType.Fighter | ChampionType.Assasin, IsFavorite = false },

                new Champ { Name = "Amumu", MainRole = Role.Jungle, Difficulty = Difficulty.Easy, Type = ChampionType.Tank | ChampionType.Support, IsFavorite = false },
                new Champ { Name = "Lee Sin", MainRole = Role.Jungle, Difficulty = Difficulty.Hard, Type = ChampionType.Fighter | ChampionType.Assasin, IsFavorite = true },
                new Champ { Name = "Kha'Zix", MainRole = Role.Jungle, Difficulty = Difficulty.Medium, Type = ChampionType.Assasin, IsFavorite = false },

                new Champ { Name = "Lux", MainRole = Role.Mid, Difficulty = Difficulty.Easy, Type = ChampionType.Mage | ChampionType.Support, IsFavorite = true },
                new Champ { Name = "Ahri", MainRole = Role.Mid, Difficulty = Difficulty.Medium, Type = ChampionType.Mage | ChampionType.Assasin, IsFavorite = false },
                new Champ { Name = "Zed", MainRole = Role.Mid, Difficulty = Difficulty.Hard, Type = ChampionType.Assasin, IsFavorite = false },

                new Champ { Name = "Ashe", MainRole = Role.ADC, Difficulty = Difficulty.Easy, Type = ChampionType.Marksman | ChampionType.Support, IsFavorite = false },
                new Champ { Name = "Jinx", MainRole = Role.ADC, Difficulty = Difficulty.Medium, Type = ChampionType.Marksman, IsFavorite = true },
                new Champ { Name = "Kai'Sa", MainRole = Role.ADC, Difficulty = Difficulty.Hard, Type = ChampionType.Marksman | ChampionType.Assasin, IsFavorite = false },

                new Champ { Name = "Leona", MainRole = Role.Support, Difficulty = Difficulty.Easy, Type = ChampionType.Tank | ChampionType.Support, IsFavorite = false },
                new Champ { Name = "Thresh", MainRole = Role.Support, Difficulty = Difficulty.Hard, Type = ChampionType.Support | ChampionType.Tank, IsFavorite = true },
                new Champ { Name = "Lulu", MainRole = Role.Support, Difficulty = Difficulty.Medium, Type = ChampionType.Support | ChampionType.Mage, IsFavorite = false },
            };

            foreach (var champ in champions)
            {
                bool alreadyExists = context.Champions
                    .Any(c => c.Name == champ.Name);

                if (!alreadyExists)
                {
                    context.Champions.Add(champ);
                }
            }

            context.SaveChanges();
        }
    }
}