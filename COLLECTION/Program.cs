int[] nums2 = new int[4] { 1, 2, 3, 5 };
int[] nums3 = new int[] { 1, 2, 3, 5 };
int[] nums4 = new[] { 1, 2, 3, 5 };
int[] nums5 = { 1, 2, 3, 5 };

int[] grades = { 1, 2, 3 };
//grades[1] = int.Parse(Console.ReadLine());

Console.WriteLine(grades.Length);

for (int i = 0; i < nums2.Length; i++)
{
    nums2[i] = i+10;
    Console.WriteLine(nums2[i]);
}

Console.WriteLine("--------------------------------");
foreach (var k in nums3)
{
    Console.WriteLine(k);
}
Console.WriteLine("----------------ultidimencional arrays---------------");

//Multidimencional arrays
string[,,] matrix = new string[2,3,3]
{
    {
        { "a", "b", "c" },
        { "d", "e", "f" },
        { "g", "h", "i" }
    },
    {
        { "a", "b", "c" },
        { "d", "e", "f" },
        { "g", "h", "i" }
    }
    
};
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write(matrix[i, j, k] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("----------------------");
}

Console.WriteLine(matrix[1,1,1]);
Console.WriteLine($"Number of dimenciions is {matrix.Rank}");
