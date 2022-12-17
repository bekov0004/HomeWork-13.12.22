int a,b,c,d,s1,s2,raz;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());
s1 = a*100+b;
s2 = c*100+d;
raz = s2-s1;
System.Console.WriteLine($"{raz/100} {raz%100}");