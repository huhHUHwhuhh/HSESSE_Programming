
public class Program {
    static void Main(string[] args) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("Введите ваше ФИО: ");
        string fullname = Console.ReadLine();
        Console.WriteLine("Здравствуйте, " + fullname);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.ResetColor();
    }
}