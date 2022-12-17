int EvenCount(int n){
    int cnt=0;
    for (int i = n; i > 0; i/=10)
    {
        if((i%10)%2==0)
        {
            cnt++;
        }
    }
    return cnt;
}

int OddCount(int n){
    int cnt=0;
    for (int i = n; i > 0; i/=10)
    {
        if((i%10)%2!=0)
        {
            cnt++;
        }
    }
    return cnt;
}

int DigitCount(int n){
    int cnt=0;
    for (int i = n; i > 0; i/=10)
    {
            cnt++;
    }
    return cnt;
}

int SumDigit(int n){
    int sum=0;
    for (int i = n; i > 0; i/=10)
    {
        sum+=i%10;
    }
    return sum;
}

int n;
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"EvenCount:{EvenCount(n)}");
Console.WriteLine($"OddCount:{OddCount(n)}");
Console.WriteLine($"DigitCount:{DigitCount(n)}");
Console.WriteLine($"SumDigit:{SumDigit(n)}");

