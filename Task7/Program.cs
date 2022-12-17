int n,cnt=0;
n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n-1; i++)
{
    if(a[i]>a[i+1] && a[i]>a[i-1]){
        cnt++;
    }
}
System.Console.WriteLine("-----------------");
System.Console.WriteLine(cnt);