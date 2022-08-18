 int num, rem, sum = 0, temp;
        Console.WriteLine("Введите  шестизначное число:  ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (Convert.ToBoolean(num))
        {
            rem = num % 10;  
            num = num / 10; 
            sum = sum * 10 + rem; 
                       
        }
        if (temp == sum) 
        
        {
            Console.WriteLine("Число полиндром");
        }
        else
        {
            Console.WriteLine("Число не является полиндромом");
        }
