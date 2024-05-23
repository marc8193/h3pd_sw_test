namespace techmath;

public class IO
{

    public class MyConsole
    {
        private enum Modes
        {
            normal = 1,
            test = 2
        };
        private static Modes Mode = Modes.normal;
        private static ConsoleKeyInfo[]? Keys;

        public static void SetTestMode(ConsoleKeyInfo[] keys)
        {
            Mode = Modes.test;
            Keys = keys;
        }

        public static ConsoleKeyInfo ReadKey(bool output)
        {
            if (Mode == Modes.normal)
            {
                return Console.ReadKey(output);
            }
            else
            {
                if (Keys?.Length > 0)
                {
                    ConsoleKeyInfo key = Keys[0];
                    Keys = Keys.Skip(1).ToArray();
                    return key;
                }
            }
            throw new Exception("No keys");
        }
    }
    public static void PrintHello()
    {
        System.Console.WriteLine("Hello");
    }

    public static void EchoInput()
    {
        var str = System.Console.ReadLine();
        System.Console.WriteLine(str);
    }

    public static void WaitForEscape()
    {
        ConsoleKey key;
        int count = 0;
        do
        {
            // key = System.Console.ReadKey(true).Key;
            key = MyConsole.ReadKey(true).Key;

            // System.Console.WriteLine(key);
            count++;
        } while (key != ConsoleKey.Escape);

        System.Console.WriteLine($"Escape pressed {count}!");
    }
}