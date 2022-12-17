  int n;
 n = Convert.ToInt32(Console.ReadLine());
int[] sorRev = new int[n];
for (int i = 0; i < n; i++)
{
    sorRev[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if(sorRev.Max()==sorRev[i]){
    System.Console.Write(i);
    }
}