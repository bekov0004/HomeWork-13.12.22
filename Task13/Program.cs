  int n,cnt=0;
n = Convert.ToInt32(Console.ReadLine());
int[] sorRev = new int[n];
for (int i = 0; i < n; i++)
{
    sorRev[i] = Convert.ToInt32(Console.ReadLine());
}  
int a;
a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    if(sorRev[i]==a){
        cnt++;
    }
}
if (cnt>=1)
{
    System.Console.WriteLine("YES");
}
else
{
    System.Console.WriteLine("NO");
}
    
