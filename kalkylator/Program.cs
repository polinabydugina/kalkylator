while (true)
{
    string a = Console.ReadLine();
    string[] nums = a.Split(' ');
    if (nums.Length / 2 == 0)
    {
        Console.WriteLine("Выражение введено неверно");
        return;
    }

    double x = Convert.ToDouble(nums[0]);
    for (int i = 1; i < nums.Length; i += 2)
    {
        string b = nums[i];
        double y = Convert.ToDouble(nums[i + 1]);

        switch (b)
        {
            case "+":
                x = x + y;
                break;
            case "-":
                x = x - y;
                break;
            case "*":
                x = x * y;
                break;
            case "/":
                if (y == 0)
                {
                    Console.WriteLine("Деление на ноль невозможно");
                    return;
                }
                x = x / y;
                break;
            default:
                Console.WriteLine("Нет такой операции");
                return;
        }
    }
    Console.Write(x);
}