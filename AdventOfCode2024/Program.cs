namespace AdventOfCode2024
{
    public class Day1
    {
        public static int PartOne(string[] input)
        {
            var leftList = input.Select(line => int.Parse(line.Split(@"   ")[0])).ToList();
            var rightList = input.Select(line => int.Parse(line.Split(@"   ")[1])).ToList();

            leftList.Sort();
            rightList.Sort();

            return leftList.Select((t, i) => Math.Abs(t - rightList[i])).Sum();
        }
        public static int PartTwo(string[] input)
        {
            var leftList = input.Select(line => int.Parse(line.Split(@"   ")[0])).ToList();
            var rightList = input.Select(line => int.Parse(line.Split(@"   ")[1])).ToList();

            var rightListFrequency = new Dictionary<int, int>();

            foreach (var i in rightList)
            {
                rightListFrequency[i] = rightListFrequency.GetValueOrDefault(i, 0) + 1;
            }

            return leftList.Sum(i => i * rightListFrequency.GetValueOrDefault(i, 0));
        }

        public static void Main()
        {
            var input = File.ReadAllLines(@"C:\Users\Ethan.Browning\source\repos\AdventOfCode2024\AdventOfCode2024\Input.txt");
            var totalDistance = PartOne(input);
            var similarityScore = PartTwo(input);
            Console.WriteLine("Similarity score: " + similarityScore);
            Console.WriteLine($"Total distance: {totalDistance}");
        }
    }
}