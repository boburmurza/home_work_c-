// задача № 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// 
// Console.Write("введите число  a = : ");
// int number_a = Convert.ToInt32( Console.ReadLine() ); 
// Console.Write("введите число  b = : ");
// int number_b = Convert.ToInt32( Console.ReadLine() ); 
// if (number_a>number_b){
//     Console.WriteLine( " максмимальное  число = : "+number_a);}
// else if  ( number_b>number_a) {
//     Console.WriteLine (" максмимальное  число = : "+number_b );
// }
// if (number_a>number_b){
//     Console.WriteLine( " минимальное   число = : "+number_b);}
// else if  ( number_b>number_a) {
//     Console.WriteLine ("  минимальное  число = : "+number_a );


// задача №  2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// Console.Write("введите число  a = : ");
// int number_a = Convert.ToInt32( Console.ReadLine() ); 
// Console.Write("введите число  b = : ");
// int number_b = Convert.ToInt32( Console.ReadLine() ); 
// Console.Write("введите число  c = : ");
// int number_c = Convert.ToInt32( Console.ReadLine() ); 
// if (number_a>number_b& number_a>number_c)
//     Console.WriteLine( " максмимальное  число = : "+number_a);   
// else if  (number_b>number_c) 
//     Console.WriteLine( " максмимальное  число = : "+number_b );
// else if  ( number_b<number_c) 
//       Console.WriteLine (" максмимальное  число = : "+number_c) ;
// else
//     Console.WriteLine(  "error "); 
// задача №  3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

//  Console.Write("введите число  number = : ");
// int number = Convert.ToInt32( Console.ReadLine() ); 
// if (number%2==0)
//      Console.Write(number+"  --→ да ");
// else 
//      Console.Write(number+" --→ нет ");
// задача №   4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;
while (count <= number)
{
    if (count % 2 == 0){
       // if (count >0 )
    
        Console.Write(count + ", ");}
   
    count++;
}
