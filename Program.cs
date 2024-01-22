using System;
using System.Collections.Generic;
using System.Linq;

namespace New_Project;
class Program
{
    static void Main()
    {
        var astronauts = new List<Astronaut>{
            new Astronaut(1, "Neil Armstrong", 2, true),
            new Astronaut(1, "Buzz Aldrin", 3, false),
            new Astronaut(2, "Sally Ride", 2, false),
            new Astronaut(3, "Chris Hadfield", 4, false),
            new Astronaut(5, "Valentina Tereshkova", 1, true),
            new Astronaut(8, "John Glenn", 2, false),
            new Astronaut(13, "Yuri Gagarin", 1, true),
            new Astronaut(21, "Kalpana Chawla", 3, false),
            new Astronaut(34, "Michael Collins", 2, false),
            new Astronaut(55, "Eileen Collins", 4, false),
            new Astronaut(89, "Alan Shepard", 1, true),
            new Astronaut(144, "Gherman Titov", 2, false),
            new Astronaut(233, "Ellen Ochoa", 3, false),
            new Astronaut(377, "Alan Bean", 1, true),
            new Astronaut(610, "Mae Jemison", 4, false),
            new Astronaut(723, "Jim Lovell", 3, false),
            new Astronaut(778, "Guion Bluford", 2, false),
            new Astronaut(829, "Peggy Whitson", 3, false),
            new Astronaut(830, "Virgil Grissom", 1, true),
            new Astronaut(831, "Deke Slayton", 2, false),
            new Astronaut(856, "Yuri Malenchenko", 4, false),
            new Astronaut(890, "Kathryn Sullivan", 1, true),
            new Astronaut(892, "Scott Kelly", 3, false),
            new Astronaut(901, "Alexei Leonov", 2, false),
            new Astronaut(910, "Cady Coleman", 4, false),
            new Astronaut(911, "Gus Grissom", 1, true),
            new Astronaut(921, "Sunita Williams", 3, false),
            new Astronaut(942, "Sergei Krikalev", 2, false),
            new Astronaut(966, "Barbara Morgan", 4, false),
            new Astronaut(989, "Ed White", 2, false),
            new Astronaut(999, "Jeanette Epps", 3, false),
        };

        bool hasAnyAstronaut = astronauts.Any();
        Console.WriteLine($"1) Есть ли астронавт? {hasAnyAstronaut}");
        Console.WriteLine();

        int totalMissions = astronauts.Sum(a => a.Missions);
        Console.WriteLine($"2) Сумма миссий всех астронавтов: {totalMissions}");
        Console.WriteLine();

        Astronaut yuriGagarin = astronauts.FirstOrDefault(a => a.Name == "Yuri Gagarin");
        Console.WriteLine($"3) Первый астронавт по имени Yuri Gagarin: {yuriGagarin?.Name}");
        Console.WriteLine();

        var astronautsWithIdGreater = astronauts.Where(a => a.Id > 900);
        Console.WriteLine($"4) Астронавты с Id больше 900: {string.Join(", ", astronautsWithIdGreater.Select(a => a.Name))}");
        Console.WriteLine();

        var activeAstronautsWithMissions = astronauts.Where(a => a.Missions > 2 && !a.IsRetired);
        Console.WriteLine($"5) Активные астронавты с более чем 2 миссиями: {string.Join(", ", activeAstronautsWithMissions.Select(a => a.Name))}");
        Console.WriteLine();

        var sortedAstronautsByMissions = astronauts.OrderBy(a => a.Missions);
        Console.WriteLine($"6) Астронавты, отсортированные по числу миссий: {string.Join(", ", sortedAstronautsByMissions.Select(a => a.Name))}");
        Console.WriteLine();

        Astronaut lastGrissomAstronaut = astronauts.LastOrDefault(a => a.Name.Contains("Grissom"));
        Console.WriteLine($"7) Последний астронавт с фамилией Grissom: {lastGrissomAstronaut?.Name}");
        Console.WriteLine();

        Astronaut firstActiveAstronaut = astronauts.FirstOrDefault(a => a.Id > 100 && !a.IsRetired);
        Console.WriteLine($"8) Первый активный астронавт с Id больше 100: {firstActiveAstronaut?.Name}");
        Console.WriteLine();

        bool hasAstronautName = astronauts.Any(a => a.Name == "Pavel Popovich");
        Console.WriteLine($"9) Есть ли астронавт с именем Pavel Popovich? {hasAstronautName}");
        Console.WriteLine();

        List<string> astronautNames = astronauts.Select(a => a.Name).ToList();
        Console.WriteLine($"10) Список имен астронавтов: {string.Join(", ", astronautNames)}");
        Console.WriteLine();
    }
}