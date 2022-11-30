// задача № 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.Write("введите число  a = : ");
// int number_a = Convert.ToInt32( Console.ReadLine() ); 
// Console.Write("введите число  b = : ");
// int number_b = Convert.ToInt32( Console.ReadLine() ); 
// if (number_a>number_b){
//     Console.WriteLine( " максмимальное  число = : "+number_a);}
// else if  ( number_b>number_a) {
//     Console.WriteLine (" максмимальное  число = : "+number_b );
// }
 


// задача №  2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("введите число  a = : ");
int number_a = Convert.ToInt32( Console.ReadLine() ); 
Console.Write("введите число  b = : ");
int number_b = Convert.ToInt32( Console.ReadLine() ); 
Console.Write("введите число  c = : ");
int number_c = Convert.ToInt32( Console.ReadLine() ); 
if (number_a>number_b& number_a>number_c)
    Console.WriteLine( " максмимальное  число = : "+number_a);   
else if  (number_b>number_c) 
    Console.WriteLine( " максмимальное  число = : "+number_b );
else if  ( number_b<number_c) 
      Console.WriteLine (" максмимальное  число = : "+number_c) ;
else
    Console.WriteLine(  "error "); 
