using BuilderMethod;
using System.Xml.Linq;

HeroBuilder heroBuilder = new HeroBuilder();
Director director = new Director(heroBuilder);
director.Build("Ben", 90, 75, 100, 95, "Grand Sword of Kindness");
Character hero = heroBuilder.Get();

EnemyBuilder enemyBuilder = new EnemyBuilder();
director = new Director(enemyBuilder);
director.Build("Krook", 90, 75, 100, 95, "Super Evil Gun");
Character enemy = enemyBuilder.Get();

Console.WriteLine($"{hero}\n\n{enemy}");