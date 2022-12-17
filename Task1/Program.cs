int n,h,m,s;
n = Convert.ToInt32(Console.ReadLine());
h = n/3600%24;
m = n/60%60;
s = n%60;
System.Console.WriteLine($"{h}:{m/10}{m%10}:{s/10}{s%10}");