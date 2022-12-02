// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Aoc 2022!");

//FindElfMostCalories();

RockScisors();

void RockScisors()
{
    var FileData = System.IO.File.ReadAllLines(".\\Days\\Day2Input.txt");

    int score = 0;
    foreach (var item in FileData)
    {
        var parts = item.Split(' ');
        switch (parts[0])
        {
            case "A": //rock
                game A1 = game.Rock;
                game B1 = GetValue(parts[1]);
                score = score + CalculateScore(A1, B1);
                break;
            case "B": //paper
                game A2 = game.Paper;
                game B2 = GetValue(parts[1]);
                score = score + CalculateScore(A2, B2);
                break;
            case "C": //scisor
                game A3 = game.Scissors;
                game B3 = GetValue(parts[1]);
                score = score + CalculateScore(A3, B3);
                break;
        }
        
    }

    Console.WriteLine(score);
}

int CalculateScore(game a1, game b1)
{
    if (a1 == b1)
        return 3 + (int)b1;

    if (a1 == game.Rock && b1 == game.Scissors)
        return 0 + (int)b1;

    if (a1 == game.Rock && b1 == game.Paper)
        return 6 + (int)b1;

    if (a1 == game.Scissors && b1 == game.Paper)
        return 0 + (int)b1;

    if (a1 == game.Scissors && b1 == game.Rock)
        return 6 + (int)b1;

    if (a1 == game.Paper && b1 == game.Rock)
        return 0 + (int)b1;

    if (a1 == game.Paper && b1 == game.Scissors)
        return 6 + (int)b1;

    return 0;
}

game GetValue(string v)
{
    switch (v)
    {
        case "Y": 
            return game.Paper;
        case "X": 
            return game.Rock;
        case "Z": 
            return game.Scissors;
    }

    return game.Paper;
}

enum game
{
    Rock = 1,
    Paper = 2,
    Scissors = 3    
}



#region "Day 1"

struct Elf
{
    public int numberOfelf;
    public int TotalCalories;
}


//void FindElfMostCalories()
//{
//    var FileData = System.IO.File.ReadAllLines("Day1Input.txt");

//    List<Elf> elfList = new List<Elf>();
    
//    int numberoFelf = 1;
//    int totalCalories = 0;
//    foreach (var line in FileData)
//    {
        

//        if (string.IsNullOrEmpty(line.Trim()))
//        {
//            Elf elf = new Elf()
//            {
//                numberOfelf = numberoFelf,
//                TotalCalories = totalCalories
//            };
//            elfList.Add(elf);
//            totalCalories = 0;
//            numberoFelf++;
//        }
//        else
//        {
//            totalCalories += int.Parse(line);
//        }
//    }

//    var result = elfList.Select(x => x.TotalCalories).Max();

//    var result2 = elfList.OrderByDescending(x => x.TotalCalories).Take(3).Sum(s => s.TotalCalories);


//    Console.WriteLine(result);

//}


#endregion