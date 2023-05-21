int n = 10; // количество чисел для записи
Random rnd = new Random();

using (StreamWriter sw = new StreamWriter("accounts.txt"))
{
    for (int i = 0; i < n; i++)
    {
        int num = rnd.Next(100000); // генерируем случайное число от 0 до 99999
        string numStr = num.ToString().PadLeft(5, '0'); // дополняем число нулями до 5 знаков
        sw.WriteLine(numStr); // записываем число в файл
    }
}

Console.WriteLine("Файл accounts.txt успешно создан и заполнен.");
Console.ReadLine();