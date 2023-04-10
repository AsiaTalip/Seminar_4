using System;

class Program {
    static void Main(string[] args) {
        // Создаем массив из 8 элементов
        int[] numbers = {1, 2, 5, 7, 19, 6, 1, 33};

        // Выводим элементы массива на экран
        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }
}
