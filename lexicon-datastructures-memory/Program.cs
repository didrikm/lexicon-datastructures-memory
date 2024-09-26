using System.Collections;

namespace lexicon_datastructures_memory;

class Program
{
    /// <summary>
    /// The main method, vill handle the menues for the program
    /// </summary>
    /// <param name="args"></param>
    static void Main()
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine(
                "Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n5. ReverseText"
                    + "\n6. RecurseEven"
                    + "\n7. RecurseFibonacci"
                    + "\n8. IterateEven"
                    + "\n9. IterateFibonacci"
                    + "\n0. Exit the application"
            );
            char input = ' '; //Creates the character input to be used with the switch-case below.
            try
            {
                input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                Console.Clear();
                Console.WriteLine("Please enter some input!");
            }
            switch (input)
            {
                case '1':
                    ExamineList();
                    break;
                case '2':
                    ExamineQueue();
                    break;
                case '3':
                    ExamineStack();
                    break;
                case '4':
                    CheckParenthesis();
                    break;
                case '5':
                    ReverseText();
                    break;
                case '6':
                    RecurseEven();
                    break;
                case '7':
                    RecurseFibonacci();
                    break;
                case '8':
                    IterateEven();
                    break;
                case '9':
                    IterateFibonacci();
                    break;
                /*
                 * Extend the menu to include the recursive
                 * and iterative exercises.
                 */
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                    break;
            }
        }
    }

    /// <summary>
    /// Examines the datastructure List
    /// </summary>
    static void ExamineList()
    {
        /*
         * Loop this method untill the user inputs something to exit to main menue.
         * Create a switch statement with cases '+' and '-'
         * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
         * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
         * In both cases, look at the count and capacity of the list
         * As a default case, tell them to use only + or -
         * Below you can see some inspirational code to begin working.
        */

        List<string> theList = new List<string>();
        System.Console.WriteLine($"Capacity 1: {theList.Capacity}");
        bool running = true;
        string value;
        string input;
        char nav = 'x';

        while (running)
        {
            System.Console.Write(
                "Input + followed by a string or - followed by a string, 0 to quit: "
            );
            input = Console.ReadLine();
            nav = input[0];
            value = input.Substring(1);

            switch (nav)
            {
                case '+':
                    theList.Add(value);
                    System.Console.WriteLine($"Capacity added: {theList.Capacity}");
                    break;
                case '-':
                    theList.Remove(value);
                    System.Console.WriteLine($"Capacity removed: {theList.Capacity}");
                    break;
                case '0':
                    running = false;
                    break;
                default:
                    System.Console.WriteLine("Only use + or -");
                    break;
            }
        }
    }

    /// <summary>
    /// Examines the datastructure Queue
    /// </summary>
    /// 1. -
    /// 2. När man lägger till utanför dess range
    /// 3. Dubbleras
    /// 4. För varje utökning kräver en resurskrävande minnes-reallokering.
    /// 5. Nej
    /// 6. När vi vet hur många element vi kommer ha.
    static void ExamineQueue()
    {
        /*
         * Loop this method untill the user inputs something to exit to main menue.
         * Create a switch with cases to enqueue items or dequeue items
         * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
        */
        Queue queue = new();
        bool running = true;
        string value;
        string input;
        char nav = 'x';

        while (running)
        {
            System.Console.Write(
                "\nICA öppnar och kön till kassan är tom\nInput + followed by a string or - followed by a string, 0 to quit: "
            );
            input = Console.ReadLine();
            nav = input[0];
            value = input.Substring(1);

            switch (nav)
            {
                case '+':
                    queue.Enqueue(value);
                    System.Console.WriteLine($"\n{value} ställer sig i kön.");
                    break;
                case '-':
                    System.Console.WriteLine($"\n{queue.Peek()} blir expedierad och lämnar kön.");
                    queue.Dequeue();
                    break;
                case '0':
                    running = false;
                    break;
                default:
                    System.Console.WriteLine("Only use + or -");
                    break;
            }
        }
    }

    /// <summary>
    /// Examines the datastructure Stack
    /// </summary>
    static void ExamineStack()
    {
        /*
         * Loop this method until the user inputs something to exit to main menue.
         * Create a switch with cases to push or pop items
         * Make sure to look at the stack after pushing and and poping to see how it behaves
        */
        Stack stack = new();
        bool running = true;
        string value;
        string input;
        char nav = 'x';

        while (running)
        {
            System.Console.Write("Input + with a string to push and - to pop, 0 to exit: ");
            input = Console.ReadLine();
            nav = input[0];
            value = input.Substring(1);
            switch (nav)
            {
                case '+':
                    stack.Push(value);
                    System.Console.WriteLine(stack.ToString());
                    break;
                case '-':
                    stack.Pop();
                    System.Console.WriteLine(stack.ToString());
                    break;
                case '0':
                    running = false;
                    break;
                default:
                    System.Console.WriteLine("Only use + or -");
                    break;
            }
            foreach (var item in stack)
            {
                System.Console.WriteLine(item);
            }
        }
    }

    static void ReverseText()
    {
        string input;
        string output = "";

        System.Console.Write("\nEnter a word to be reversed: ");
        input = Console.ReadLine();
        Stack<char> charStack = new Stack<char>(input);
        System.Console.WriteLine();
        foreach (var c in charStack)
            System.Console.Write(c);
        System.Console.WriteLine("\n");
    }

    static void CheckParenthesis()
    {
        /*
         * Use this method to check if the paranthesis in a string is Correct or incorrect.
         * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
         * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
         */
        System.Console.Write("\nEnter a string of parentheses to be checked: ");
        string input = Console.ReadLine();
        char[] inputSplit = input.ToArray();
        List<char> lefts = new List<char> { '(', '[', '{' };
        List<char> rights = new List<char> { ')', ']', '}' };
        Stack stack = new();
        bool noTrouble = true;
        Dictionary<char, char> parenDict = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' },
        };
        foreach (var c in inputSplit)
        {
            if (lefts.Contains(c))
                stack.Push(c);
            else if (rights.Contains(c))
            {
                if ((char)stack.Peek() == parenDict[c])
                    stack.Pop();
                else
                {
                    noTrouble = false;
                    break;
                }
            }
        }
        if (stack.Count == 0 && noTrouble)
            System.Console.WriteLine("\nWell formed parenthesis\n");
        else
            System.Console.WriteLine("\nBad parenthesis\n");
    }

    static void RecurseEven()
    {
        System.Console.Write("\nEnter a number: ");
        int input = int.Parse(Console.ReadLine());
        System.Console.WriteLine($"\nThe {input}th even number is {EvenRecursion(input)}\n");
    }

    static int EvenRecursion(int n)
    {
        if (n == 1)
            return 2;
        return EvenRecursion(n - 1) + 2;
    }

    static void RecurseFibonacci()
    {
        System.Console.WriteLine(
            "\nWhich recursive function do you wish to use? Hint: try with n=100\n1. Naive\n2. With memory"
        );
        string choice = Console.ReadLine();
        uint input;
        switch (choice)
        {
            case "1":
                System.Console.Write("\nEnter a number: ");
                input = uint.Parse(Console.ReadLine());
                for (uint i = 0; i < input; i++)
                {
                    System.Console.Write($"{FibonacciRecursion(i)} ");
                }
                System.Console.WriteLine("\n");
                break;
            case "2":
                System.Console.Write("\nEnter a number: ");
                input = uint.Parse(Console.ReadLine());
                Dictionary<uint, ulong> fiboDict = new();
                FibonacciRecursionWithMem(input, fiboDict);
                for (uint i = 0; i < input; i++)
                    System.Console.Write($"{fiboDict[i]} ");
                System.Console.WriteLine("\n");
                break;
            default:
                System.Console.WriteLine("You crashed it you dummy...");
                break;
        }
    }

    static ulong FibonacciRecursionWithMem(uint n, Dictionary<uint, ulong> fiboDict)
    {
        if (n <= 1)
        {
            fiboDict[n] = n;
            return n;
        }
        if (fiboDict.TryGetValue(n, out ulong value))
            return value;
        value =
            FibonacciRecursionWithMem(n - 1, fiboDict) + FibonacciRecursionWithMem(n - 2, fiboDict);
        fiboDict[n] = value;
        return value;
    }

    static ulong FibonacciRecursion(uint n)
    {
        if (n <= 1)
            return n;
        return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
    }

    static void IterateEven()
    {
        System.Console.Write("\nEnter a number: ");
        int input = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < input; i++)
        {
            result += 2;
        }
        System.Console.WriteLine($"\nThe {input}th even number is {result}\n");
    }

    static void IterateFibonacci()
    {
        System.Console.Write("\nEnter a number: ");
        int input = int.Parse(Console.ReadLine());
        int prev = 0;
        int curr = 1;
        {
            for (int i = 0; i < input; i++)
            {
                System.Console.Write($"{prev} ");
                curr = curr + prev;
                prev = curr - prev;
            }
        }
        System.Console.WriteLine("\n");
        //Iteration är mer minneseffektivt eftersom varje rekursivt anrop skapar en ny stack frame.
        //Risk för stack overflow vid stora n.
    }
}
