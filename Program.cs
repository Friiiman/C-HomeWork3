void Task1(){

    /*
    Напишите программу, которая принимает на вход число 
    и проверяет, является ли оно палиндромом.
    */

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int numerals = number;
    string compare = number.ToString();
    string result = $"{number % 10}";
    

    while((numerals /= 10) != 0){
        result = result + numerals % 10;
    }

    if(compare == result){
        result = $"Число {number} палиндром";
    }
    else{
        result = $"Число {number} не палиндром";
    }

    Console.WriteLine(result);

}

void Task2(){

    // Напишите программу, которая принимает на вход координаты двух точек 
    // и находит расстояние между ними в 3D пространстве.

    Console.Write("Введите A(x): ");
    int Ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите A(y): ");
    int Ay = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите A(z): ");
    int Az = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите B(x): ");
    int Bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите B(y): ");
    int By = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите B(z): ");
    int Bz = Convert.ToInt32(Console.ReadLine());

    double distance = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));

    Console.WriteLine($"Расстояние между точками: {distance}");

}

void Task3(){

    // Напишите программу, которая принимает на вход число (N) и 
    // выдаёт таблицу кубов чисел от 1 до N.

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    for(int i = 1; i <= number; i++){
        Console.WriteLine(i + " в кубе = " + Math.Pow(i, 3));
    }

}

Task1();
// Task2();
// Task3();
