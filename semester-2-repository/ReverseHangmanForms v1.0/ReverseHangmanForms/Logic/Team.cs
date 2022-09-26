using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseHangmanForms.Logic
{
    enum Adjectives
    {
        Abandoned,
        Agressive,
        Alcoholic,
        Blessed,
        Bouncy,
        Biodegradable,
        Crazy,
        Coordinated,
        Curvy,
        Duky,
        Dusty,
        Dirty,
        Elite,
        Excited,
        Evanescent,
        Fat,
        Fabulous,
        Fake,
        Groovy,
        Goofy,
        Glemmer,
        Homeless,
        Hungry,
        Horrific,
        Intelligent,
        Ignorant,
        Invincible,
        Junior,
        Jealous,
        Juicy,
        Kaleidoscopic,
        Kindhearted,
        Klutzy,
        Lying,
        Lackadaisical,
        Lethal,
        Magic,
        Massive,
        Macho,
        Nasty,
        Naughty,
        Noxious,
        Obese,
        Offensive,
        Oily,
        Poopy,
        Parsimonious,
        Pure,
        Quality,
        Quintessential,
        Quirky,
        Racist,
        Royal,
        Ruthless,
        Salty,
        Soggy,
        Suspicious,
        Tricky,
        Typical,
        Trustworthy,
        Useless,
        Unfinished,
        Unconscious,
        Victorious,
        Venomous,
        Vivid,
        Wiggly,
        Weird,
        Wonderful,
        Xylotomous,
        Xanthophyll,
        Xenops,
        Yummy,
        Yellowish,
        Young,
        Zealous,
        Zonked,
        Zigzag
    }
    enum Nouns
    {
        Angels,
        Astronaut,
        Army,
        Business,
        Boyz,
        Brothers,
        Coconuts,
        Chickens,
        Clowns,
        Duo,
        Dudes,
        Dawg,
        Energy,
        Earring,
        Elders,
        Farts,
        Fighters,
        Furniture,
        Gamers,
        Garbage,
        Guardians,
        Hamburger,
        Hell,
        Heaven,
        Irritations,
        Iceberg,
        Idealists,
        Joke,
        Jail,
        Jam,
        Killers,
        Kaleidoscope,
        Kazoo,
        Lovers,
        Liars,
        Ladies,
        Monkeys,
        Marriage,
        Management,
        Noodle,
        Needles,
        Nails,
        Oysters,
        Okra,
        Objects,
        Pigs,
        Poop,
        Planets,
        Query,
        Quarantine,
        Queens,
        Relationship,
        Rascals,
        Rockers,
        Superheroes,
        Stinkers,
        Santa,
        Trash,
        Teachers,
        Tumbleweed,
        Users,
        Ukulele,
        Upgrades,
        Vegetables,
        Ventriloquists,
        Victory,
        Wordmasters,
        Words,
        Witches,
        Xenophobia,
        Xyris,
        Xanthorrhoea,
        Yahoo,
        Yeomanry,
        Yetis,
        Zombies,
        Zoo,
        Zygapophysis
    }
    public enum Roles
    {
        Wordmaster,
        Guesser
    }

    public class Team
    {
        // Constructors
        public Team(string name)
        {
            Name = name;
        }

        // Fields
        static Random rnd = new Random();

        // Properties
        public string Name { get; private set; }
        public int Points { get; private set; }
        public int Lives { get; private set; }
        public Roles Role { get; set; }

        // Methods
        public void LoseLife()
        {
            Lives--;
        }

        // Methods - Static
        public static string CreateRandomTeamName()
        {
            string randomTeamName = "";
            randomTeamName += AddRandomAdjective(rnd);
            randomTeamName += AddBlankSpace();
            randomTeamName += AddRandomNoun(rnd);
            return randomTeamName;
        }
        private static string AddRandomAdjective(Random rnd)
        {
            Array values = Enum.GetValues(typeof(Adjectives));
            string randomAdjective = "" + (Adjectives)values.GetValue(rnd.Next(values.Length));
            return randomAdjective;
        }
        private static string AddBlankSpace()
        {
            string blankSpace = " ";
            return blankSpace;
        }
        private static string AddRandomNoun(Random rnd)
        {
            Array values = Enum.GetValues(typeof(Nouns));
            string randomNoun = "" + (Nouns)values.GetValue(rnd.Next(values.Length));
            return randomNoun;
        }
    }
}
