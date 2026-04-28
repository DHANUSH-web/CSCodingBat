namespace HelloWorld;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Run `dotnet test` to test your logic!!");
    }

    public static void PrintArray(int[] arr)
    {
        if (arr.Length == 0)
        {
            Console.WriteLine("0:[ ]");
            return;
        }

        if (arr.Length == 1)
        {
            Console.WriteLine("1:[ " + arr[0] + " ]");
            return;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
                Console.Write($"{arr.Length}:[ " + arr[i] + ", ");
            else if (i == arr.Length - 1)
                Console.WriteLine(arr[i] + " ]");
            else
                Console.Write(arr[i] + ", ");
        }

        return;
    }

    public static string LastChars(string a, string b) => (a + "@")[0] + "" + ("@" + b)[b.Length];

    public static string Concat(string a, string b)
    {
        int aSize = a.Length;
        int bSize = b.Length;

        if (aSize == 0) return b;
        if (bSize == 0) return a;

        return a[aSize - 1] == b[0] ? a + b.Substring(1, bSize - 1) : a + b;
    }

    public static string LastTwo(string str)
    {
        int size = str.Length;

        if (size < 2) return str;
        return size > 2 ? str.Substring(0, size - 2) + $"{str[size - 1]}{str[size - 2]}" : $"{str[1]}{str[0]}";
    }

    public static string SeeColors(string str)
    {
        return str.StartsWith("red") ? "red" : str.StartsWith("blue") ? "blue" : string.Empty;
    }

    public static bool FrontAgain(string str) => str.Length >= 2 && str[0] == str[str.Length - 2] && str[1] == str[str.Length - 1];

    public static string MinCat(string a, string b)
    {
        int aSize = a.Length;
        int bSize = b.Length;

        return aSize > bSize ? a.Substring(aSize - bSize) + b : aSize == bSize ? a + b : a + b.Substring(bSize - aSize);
    }

    public static string WithoutX(string str)
    {
        int size = str.Length;

        if (size <= 1) return string.Empty;

        return (str[0] == 'x' ? string.Empty : str[0]) + str.Substring(1, size - 1) + (str[size - 1] == 'x' ? string.Empty : str[size - 1]);
    }

    public static int[] Front11(int[] a, int[] b)
    {
        int size = (a.Length > 0 ? 1 : 0) + (b.Length > 0 ? 1 : 0);
        int[] arr = new int[size];
        int i = 0;

        if (a.Length > 0) arr[i++] = a[0];
        if (b.Length > 0) arr[i] = b[0];

        return arr;
    }

    public static bool Near10(int num) => num % 10 <= 2 || num % 10 >= 8;

    public static int TeaParty(int tea, int candy) => tea < 5 || candy < 5 ? 0 : tea >= 2 * candy || candy >= 2 * tea ? 2 : 1;

    public static string FizzString(string str)
    {
        if (str.StartsWith('f') && str.EndsWith('b')) return "FizzBuzz";
        if (str.StartsWith('f')) return "Fizz";
        if (str.EndsWith('b')) return "Buzz";

        return str;
    }

    public static string FizzString2(int n)
    {
        if (n % 3 == 0 && n % 5 == 0) return "FizzBuzz!";
        if (n % 3 == 0) return "Fizz!";
        if (n % 5 == 0) return "Buzz!";
        return n + "!";
    }

    public static bool TwoAsOne(int a, int b, int c) => a + b == c || a + c == b || b + c == a;

    public static bool InOrder(int a, int b, int c, bool bOk) => (bOk || b > a) && c > b;

    public static bool InOrderEqual(int a, int b, int c, bool equalsOk) => (equalsOk && a <= b && b <= c) || (a < b && b < c);

    public static bool LastDigit(int a, int b, int c) => a % 10 == b % 10 || b % 10 == c % 10 || a % 10 == c % 10;

    public static bool LessBy10(int a, int b, int c) => Math.Abs(a - b) >= 10 || Math.Abs(b - c) >= 10 || Math.Abs(a - c) >= 10;

    public static int WithoutDoubles(int die1, int die2, bool noDoubles)
    {
        return noDoubles && die1 == die2 ? (die1 == 6 ? 1 : die1 + 1) + die2 : die1 + die2;
    }

    public static int MaxMod5(int a, int b) => a == b ? 0 : a % 5 == b % 5 ? Math.Min(a, b) : Math.Max(a, b);

    public static int RedTicket(int a, int b, int c) => a == 2 && b == 2 && c == 2 ? 10 : a == b && b == c ? 5 : a != b && a != c ? 1 : 0;

    public static int GreenTicket(int a, int b, int c) => a == b && b == c ? 20 : a == b || b == c || a == c ? 10 : 0;

    public static bool ShareDigit(int a, int b) => a / 10 == b / 10 || a / 10 == b % 10 || a % 10 == b / 10 || a % 10 == b % 10;
    
    public static int Sum13(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1 && nums[0] == 13) return 0;

        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 13)
            {
                i++;
                continue;
            }

            sum += nums[i];
        }

        return sum;
    }

    public static int CenteredAverage(int[] nums)
    {
        int sum = 0, min = nums[0], max = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (nums[i] < min) min = nums[i];
            if (nums[i] > max) max = nums[i];
        }

        return (sum - min - max) / (nums.Length - 2);
    }

    public static int Sum67(int[] nums)
    {
        int sum = 0;
        bool skip = false;

        foreach (int n in nums)
        {
            if (n == 6) skip = true;
            else if (n == 7 && skip) skip = false;
            else if (!skip) sum += n;
        }

        return sum;
    }

    public static bool Has22(int[] nums)
    {
        for (int i = 0; i < nums.Length-1; i++)
            if (nums[i] == 2 && nums[i+1] == 2)
                return true;
        
        return false;
    }

    public static bool Lucky13(int[] nums)
    {
        foreach (int n in nums)
            if (n == 1 || n == 3)
                return false;
        return true;
    }

    public static bool Sum28(int[] nums)
    {
        int sum = 0;

        foreach (int n in nums)
            if (n == 2) sum += n;
        
        return sum == 8;
    }
}
