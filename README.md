1. Объявляем массивы (один для исходной строки, второй для строк размером менее 4 строк)
string[] MassivStrok;
string[] newMassivStrok;
2. Вводим текст с клавиатуры
System.Console.Write("Введите исходную строку: ");
string inputStroka = Console.ReadLine();
3. Разделяем введённый текст на слова в нашем случае символом-разделителем является символ пробела " "
MassivStrok = inputStroka.Split(' ');

4. передаём в функцию вывода массив-результат работы функции по копированию из исходной строки в массив со словами менее 4 символов 
output(newMassivStrok = newMassiv(MassivStrok));

5. Функция вывода массива на экран
void output(string[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        System.Console.WriteLine(Arr[i]);
    }
}

6. Функция подсёта количества слов, удовлетворяющих условию (в нашем случае меньше 4)
int countThree(string[] Arr)
{
    int result = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].Length < 4) result++;
    }
    return result;
}


7. функция копирования из исходнова массива слов, удовлетворяющих условию
string[] newMassiv(string[] Arr)
{
    int count = 0;
    string[] result = new string[countThree(MassivStrok)];
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].Length < 4)
        {
            result[count] = Arr[i];
            count++;
        }

    }
    return result;
}
