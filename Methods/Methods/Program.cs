
#region 2. Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//static void FindDividedOrNot(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("bolunur");

//    }

//    else
//    {
//        Console.WriteLine("bolunmur");
//    }
//}
//Console.WriteLine("Enter a value: ");

//int number = Convert.ToInt32(Console.ReadLine());

//FindDividedOrNot(number);

#endregion

#region 3. n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//static int FindSum(int n,int m)

//{
//    int sum = 0;

//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//    }


//    return sum;
//}

//Console.WriteLine("Enter first number");
//int number1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter second number");
//int number2 = Convert.ToInt32(Console.ReadLine());

//int sum = FindSum(number1, number2);
//Console.WriteLine(sum);

#endregion

#region 4. Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//static int FindSumOfOddNumbers(int n, int m)
//{
//    int sum = 0;


//    for (int i = n; i <= m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum += i;
//        }
//    }


//    return sum;
//}

//Console.WriteLine("Enter first number");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter second number");
//int m = Convert.ToInt32(Console.ReadLine());

//while (n > m)
//{
//    Console.WriteLine("Second number must be greater than first number");
//    Console.WriteLine("Enter first number again");
//    n = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter second number again");
//    m = Convert.ToInt32(Console.ReadLine());

//}

//int sum = FindSumOfOddNumbers(n, m);
//Console.WriteLine($"Sum of odd numbers between {n} and {m} is equal to {sum}");

#endregion

#region 5. Verilmish arrayin icindeki tek ededlerin cemini tapin.

//static int SumOfOddArrayElements(int[] nums)
//{
//    int sum = 0;
//    foreach (var num in nums)
//    {
//        if (num % 2 == 1)
//        {
//            sum += num;
//        }
//    }
//    return sum;
//}

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

//int sum =SumOfOddArrayElements(arr);

//Console.WriteLine(sum);


#endregion

#region 6. Verilmish arrayin icindeki cut ededlerin sayini tapin.

//static int CountEvenArrayElements(int[] nums)
//{
//    int count = 0;
//    foreach (var num in nums)
//    {
//        if (num % 2 == 0)
//            count++;
//    }
//    return count;
//}

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

//int count = CountEvenArrayElements(arr);

//Console.WriteLine(count);


#endregion

#region 7. Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//static int CountOddNumbers(int n, int m)
//{
//    int count = 0;


//    for (int i = n; i <= m; i++)
//    {
//        if (i % 2 != 0)
//        {
//            count ++;
//        }
//    }


//    return count;
//}

//Console.WriteLine("Enter first number");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter second number");
//int m = Convert.ToInt32(Console.ReadLine());

//while (n > m)
//{
//    Console.WriteLine("Second number must be greater than first number");
//    Console.WriteLine("Enter first number again");
//    n = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter second number again");
//    m = Convert.ToInt32(Console.ReadLine());

//}

//int count = CountOddNumbers(n, m);
//Console.WriteLine(count);


#endregion

#region 8. Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//static int SumOfEvenNumbers(int n, int m)
//{
//    int sum = 0;


//    for (int i = n; i <= m; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i;
//        }
//    }


//    return sum;
//}

//Console.WriteLine("Enter first number");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter second number");
//int m = Convert.ToInt32(Console.ReadLine());

//while (n > m)
//{
//    Console.WriteLine("Second number must be greater than first number");
//    Console.WriteLine("Enter first number again");
//    n = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter second number again");
//    m = Convert.ToInt32(Console.ReadLine());

//}

//int sum = SumOfEvenNumbers(n, m);
//Console.WriteLine($"Sum of even numbers between {n} and {m} is equal to {sum}");
#endregion

#region 9. Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.
//static int CountEvenNumbers(int n, int m)
//{
//    int count = 0;


//    for (int i = n; i <= m; i++)
//    {
//        if (i % 2 == 0)
//        {
//            count++;
//        }
//    }


//    return count;
//}

//Console.WriteLine("Enter first number");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter second number");
//int m = Convert.ToInt32(Console.ReadLine());

//while (n > m)
//{
//    Console.WriteLine("Second number must be greater than first number");
//    Console.WriteLine("Enter first number again");
//    n = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter second number again");
//    m = Convert.ToInt32(Console.ReadLine());

//}

//int count = CountEvenNumbers(n, m);
//Console.WriteLine(count);


#endregion

#region 10. Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//static int FindPrimeOrCompositeNum(int n)
//{
//    int count = 0;
//    if (n <= 0)
//    {
//        Console.WriteLine("Enter correct number");

//    }
//    else if (n == 1)
//    {
//        Console.WriteLine($"{n} is not prime or composite number.");
//    }
//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0)
//                count++;
//        }
//    }
//    return count;
//}

//Console.WriteLine("Enter a number");
//int n = Convert.ToInt32(Console.ReadLine());

//int count = FindPrimeOrCompositeNum(n);

//if (count > 2)
//{
//    Console.WriteLine($"{n} is composite number.");
//}
//else if (count == 2)
//{
//    Console.WriteLine($"{n} is prime number.");

//}
#endregion

#region 11. n ededinin faktorialini hesablamaq.


//static  int FindFactorial(int n)
//{
//    int fact = 1;
//    for (int i=1;i<=n;i++)
//    {
//        fact *= i;
//    }
//    return fact;
//}

//Console.WriteLine("Enter a number");
//int n = Convert.ToInt32(Console.ReadLine());
//int fact = 1;

//if (n < 0)
//{
//    Console.WriteLine("Negative number does not have factorial");
//}

//else if (n == 0)
//{
//    Console.WriteLine($"Factorial of {n} is equal to {fact}");
//}

//else
//{
//    fact = FindFactorial(n);
//    Console.WriteLine($"Factorial of {n} is equal to {fact}");
//}



#endregion


