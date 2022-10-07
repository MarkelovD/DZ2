//задача 1
// Console.WriteLine("введите число:");
// int num = int.Parse(Console.ReadLine()!);
// if (num>99 && num<1000){
//     num=(num/10)%10;
//     Console.WriteLine($"второе число {num}");
// }
// else{
//     Console.WriteLine($"чсило {num} не является трехзначным");
// }

//задача 2
Console.WriteLine("введите число:");
int num = int.Parse(Console.ReadLine()!);
if (num<100){
    Console.WriteLine("число не является трехзначным");
}
else if (num>99 && num<=100000){
while (num>999 && num<=100000){
num=num/10;
}
Console.WriteLine($"третье число:{num%10}");
}
else if (num>100000){
    Console.WriteLine("превышно максимальное значение в 100000");
}