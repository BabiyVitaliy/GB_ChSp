// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна трём символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не реккомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] MassivStrok;
string[] newMassivStrok;
System.Console.Write("Введите исходную строку: ");
string inputStroka = Console.ReadLine();
MassivStrok = inputStroka.Split(' ');
output(newMassivStrok = newMassiv(MassivStrok));

void output(string[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        System.Console.WriteLine(Arr[i]);
    }
}

int countThree(string[] Arr)
{
    int result = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].Length < 4) result++;
    }
    return result;
}



