// Pзадача № 1
// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

void Main()
{
    // Создаем двумерный массив символов
    char[,] charArray = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' }, { 'g', 'h', 'i' } };

    // Создаем строку для хранения символов массива
    string result = "";

    // Проходим через каждый элемент массива
    for (int i = 0; i < charArray.GetLength(0); i++)
    {
        for (int j = 0; j < charArray.GetLength(1); j++)
        {
            // Добавляем каждый символ в строку
            result += charArray[i, j];
        }
    }

    // Выводим результат
    Console.WriteLine(result);
}

Main();

// Задача № 2 
// Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные. 


void MainSecondTask()
{
    // Задаем строку с буквами в обоих регистрах
    string originalString = "HeLLo WoRLD!";

    // Преобразуем все заглавные буквы в строчные
    string lowercaseString = originalString.ToLower();

    // Выводим результат
    Console.WriteLine(lowercaseString);
}

MainSecondTask();

