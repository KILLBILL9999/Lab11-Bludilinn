// step 1
// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1000; // числа нет в массиве (для проверки найденного поставьте 1071)
// bool found = false;

// foreach (int number in recordBooks) {
//     if (number == target) {
//         found = true;
//         break;
//     }
// }

// Console.WriteLine(found ? "Студент найден" : "Студент не найден");


// step 2
// int variant = 17; // проверьте также 1 и 2

// if (variant < 2)
// {
//     Console.WriteLine("Число меньше 2: оно не простое и не составное");
// }
// else
// {
//     bool isPrime = true;

//     for (int divisor = 2; divisor < variant; divisor++)
//     {
//         if (variant % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }

//     Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
// }


// step 3
// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int submitted = 0;

// foreach (int points in pointsPerLab) {
//     if (points < 0) {
//         continue; // -1 означает несданную работу
//     }
//     sum += points;
//     submitted++;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Сдано работ: {submitted}");


// step 4
// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length && !hasDuplicates; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             Console.WriteLine($"Первая пара дубликатов: {groupIds[i]} и {groupIds[j]}");
//             break;
//         }
//     }
// }

// Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");


// step 5
// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;

// for (int day = 1; day <= days && !found; day++) {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++) {
//         bool isFree = (day == 3 && lesson == 4); // заглушка: окно только тут

//         if (isFree) {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }

// if (!found) {
//     Console.WriteLine("Свободных слотов нет");
// }


// task a
// int[] numbers = { 5, 12, 8, 21, 3 };
// int target = 21;
// bool found = false;
// int index = -1;

// for (int i = 0; i < numbers.Length; i++) {
//     if (numbers[i] == target) {
//         found = true;
//         index = i;
//         break;
//     }
// }

// if (found) {
//     Console.WriteLine($"Число {target} найдено, индекс: {index}");
// } else {
//     Console.WriteLine($"Числа {target} в массиве нет");
// }


// task v
// int[] numbers = { 3, 8, 5, 12, 7, 4 };
// int sum = 0;

// foreach (int n in numbers) {
//     if (n % 2 != 0) {
//         continue; // пропускаем нечётные
//     }
//     sum += n;
// }

// Console.WriteLine($"Сумма чётных чисел: {sum}");

// variant
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// var 1
// int[] numbers = { 4, 7, -2, 9, -5 };
// bool found = false;
// int index = -1;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < 0)
//     {
//         found = true;
//         index = i;
//         break;
//     }
// }

// if (found)
// {
//     Console.WriteLine($"Первое отрицательное число: {numbers[index]}, индекс: {index}");
// }
// else
// {
//     Console.WriteLine("Не найдено");
// }


// var 10
// int n = 100;
// int a = 1;
// int b = 1;

// while (true)
// {
//     if (a > n)
//     {
//         Console.WriteLine($"Первое число Фибоначчи больше {n}: {a}");
//         break;
//     }

//     int next = a + b;
//     a = b;
//     b = next;
// }
