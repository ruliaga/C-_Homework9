Console.Clear();
Console.WriteLine("Введите M:");
int m=int.Parse(Console.ReadLine());
Console.WriteLine("Введите N:");
int n=int.Parse(Console.ReadLine());

Function(m,n);

void Function (int m, int n){

if ((m<=n)&(m%2==0)){
        Console.Write($"{m} ");
        Function(m+1,n);
} 
if ((m<=n)&(m%2!=0)){
        Console.Write(" ");
        Function(m+1,n);

}
}