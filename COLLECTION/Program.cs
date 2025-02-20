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

