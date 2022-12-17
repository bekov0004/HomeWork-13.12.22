  int n;
 n = Convert.ToInt32(Console.ReadLine());
int[] sorRev = new int[n];
for (int i = 0; i < n; i++)
{
    sorRev[i] = Convert.ToInt32(Console.ReadLine());
} 
System.Console.Write($"Min = {sorRev.Min()}");
    
