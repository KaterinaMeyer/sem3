Console.Write("Введите координату x точка А: ");
        int xA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату y точка А: ");
        int yA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату z точка А: ");
        int zA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату x точка B: ");
        int xB = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату y точка B:");
        int yB = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату z точка B: ");
        int zB = Convert.ToInt32(Console.ReadLine());


        double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
        
        Console.WriteLine($"Расстояние между точкой A и точкой B: {distance:f2}");
