// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Aoc 2022!");

FindElfMostCalories();


void FindElfMostCalories()
{
    var FileData = System.IO.File.ReadAllLines("Day1Input.txt");

    List<Elf> elfList = new List<Elf>();
    
    int numberoFelf = 1;
    int totalCalories = 0;
    foreach (var line in FileData)
    {
        

        if (string.IsNullOrEmpty(line.Trim()))
        {
            Elf elf = new Elf()
            {
                numberOfelf = numberoFelf,
                TotalCalories = totalCalories
            };
            elfList.Add(elf);
            totalCalories = 0;
            numberoFelf++;
        }
        else
        {
            totalCalories += int.Parse(line);
        }
    }

    var result = elfList.Select(x => x.TotalCalories).Max();

    var result2 = elfList.OrderByDescending(x => x.TotalCalories).Take(3).Sum(s => s.TotalCalories);


    Console.WriteLine(result);

}

struct Elf
{
    public int numberOfelf;
    public int TotalCalories;
}