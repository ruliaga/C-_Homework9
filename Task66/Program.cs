Console.Clear();
Console.WriteLine("Введите M:");
int m=int.Parse(Console.ReadLine());
Console.WriteLine("Введите N:");
int n=int.Parse(Console.ReadLine());
Console.WriteLine("------------------");
Console.Write($"M={m}; N={n} ->");
Function(m,n,0);

void Function (int m, int n, int sum){

if ((m<=n)){
        sum=sum+m;
        Function(m+1,n,sum);
} else {Console.Write(sum);}

}
