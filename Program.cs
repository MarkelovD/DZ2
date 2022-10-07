//задача 1
Console.WriteLine("введите число:");
int num = int.Parse(Console.ReadLine()!);
if (num>99 && num<1000){
    num=(num/10)%10;
    Console.WriteLine($"второе число {num}");
}
else{
    Console.WriteLine($"чсило {num} не является трехзначным");
}