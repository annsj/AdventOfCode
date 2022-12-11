using _2022AdvOfCode.Days;


Console.WriteLine("*  Dag 1");
Day01 day01 = new Day01("InputFiles/Input01.txt");
int maxCalories = day01.GetAnswerPart1();
Console.WriteLine($"Svar del 1: {maxCalories}");
int sumOfThreeHighest = day01.GetAnswerPart2();
Console.WriteLine($"Svar del 2: {sumOfThreeHighest}");
Console.WriteLine();


Console.WriteLine("*  Dag 2");
Day02 day02 = new Day02("InputFiles/Input02.txt");
int score = day02.GetAnswerPart1();
Console.WriteLine($"Svar del 1: {score}");
score = day02.GetAnswerPart2();
Console.WriteLine($"Svar del 2: {score}");
