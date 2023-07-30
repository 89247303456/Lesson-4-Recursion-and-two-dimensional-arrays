//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// Считать число с консоли 
int Prompt(string massage)
{
    System.Console.Write(massage); // вывести сообщение 
    string value = Console.ReadLine(); // считывает с консоли строку
    int result = Convert.ToInt32(value); // преобразует строку в целое число 
return result; // возвращает результат 
}



// Функция для считывания числа с консоли
//    static int Prompt(string message)
//    {
//         int number;
//         bool success;

//         do
//         {
//             Console.Write(message);
//             success = int.TryParse(Console.ReadLine(), out number);
//             if (!success)
//             {
//                 Console.WriteLine("Ошибка! Введите целое число.");
//             }
//         } while (!success);

//         return number;
//     }
    
//     static void Main(string[] args)
//     {
//         int count = 0;
//         int m = Prompt("Введите количество чисел: ");

//         for (int i = 0; i < m; i++)
//         {
//             int num = Prompt($"Введите число {i+1}: ");

//             if (num > 0)
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine("Количество чисел больше 0: " + count);
//     }