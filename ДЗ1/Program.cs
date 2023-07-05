       Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int a = number / 10000;
        int b = (number / 1000) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;

        if (a == d && b == c)
        {
            Console.WriteLine("Да, число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом.");
        }