   // Найти наибольшее и наименьшее из 2-х чисел.
   
   int a, b;
 
        Console.WriteLine("Введите два числа : ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{0} Наибольшее число", a);
 
        }
 
        else
        {
 
            Console.WriteLine("{0} Наибольшее число ", b);
 
        }
 
        Console.ReadLine();