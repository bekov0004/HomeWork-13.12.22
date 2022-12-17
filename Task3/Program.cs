int oilk,stzh,prot;
oilk = Convert.ToInt32(Console.ReadLine());
stzh = Convert.ToInt32(Console.ReadLine());
if (stzh>5)
{
    prot = oilk*5/100;
    System.Console.WriteLine($"prosent = {prot}");
}
else
{
    System.Console.WriteLine("oli iqai diga kor kn");
}