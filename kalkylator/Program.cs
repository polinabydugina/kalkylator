using System.ComponentModel.Design;
using System.Transactions;

while (true)
{
    string a = Console.ReadLine();
    string[] nums = a.Split(' ');
    List<string> numsList = new List<string>(nums);
    bool c = false;
    if (nums.Length / 2 == 0)
    {
        Console.WriteLine("Выражение введено неверно");
        return;
    }

    foreach (string s in numsList)
    {
        if(s == "*" ||  s == "/")
        {
            c = true; 
            break;
        }
    }

    if (c)
    {
        int t = 0;
        for(int i = 0; i < numsList.Count; i++)
        {
            if (numsList[i] == "*")
            {
                t = Convert.ToInt32(numsList[i - 1]) * Convert.ToInt32(numsList[i + 1]);
                numsList.RemoveAt(i - 1);
                numsList.RemoveAt(i - 1);
                numsList.RemoveAt(i - 1);
                numsList.Insert(i - 1, Convert.ToString(t));
                i = 0;

            }
            else if (numsList[i] == "/")
            {
                t = Convert.ToInt32(numsList[i - 1]) / Convert.ToInt32(numsList[i + 1]);
                numsList.RemoveAt(i - 1);
                numsList.RemoveAt(i - 1);
                numsList.RemoveAt(i - 1);
                numsList.Insert(i - 1, Convert.ToString(t));
                i = 0;
            }
            
        }
    }

    int x = Convert.ToInt32(numsList[0]);
    for (int i = 1; i < numsList.Count; i += 2)
    {
        string b = numsList[i];
        int y = Convert.ToInt32(numsList[i + 1]);

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
    Console.WriteLine(x);
}