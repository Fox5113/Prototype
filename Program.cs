namespace Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = """Реализуем паттерн "Прототип" """;

            Gator originalGator = new Gator("Gator", DateTime.Now, 500702);
            Gator clonedGator = (Gator)originalGator.Clone();
            Gator iCloneableGator = (Gator)(originalGator as ICloneable).Clone();

            PrintInfo("Оригинальный вирус", originalGator);
            PrintInfo("Клон вируса (IMyCloneable)", clonedGator);
            PrintInfo("Клон вируса (ICloneable)", iCloneableGator);

            originalGator.Name = "GatorV2";
            originalGator.DateOccurrence = DateTime.Now.AddDays(2);
            originalGator.InfectedDevices = 11;

            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 64)));

            Console.WriteLine($"После изменений");
            PrintInfo("Оригинальный вирус", originalGator);
            PrintInfo("Клон вируса (IMyCloneable)", clonedGator);
            PrintInfo("Клон вируса (ICloneable)", iCloneableGator);

            Console.WriteLine();
            Console.WriteLine("Преимущества и недостатки интерфейсов:");
            Console.WriteLine("IMyCloneable:");
            Console.WriteLine("  + Четкое определение клонирования с явным типом возврата.");
            Console.WriteLine("  + Удобен для расширения.");
            Console.WriteLine("  - Не является стандартным интерфейсом .NET, может быть менее понятен для других разработчиков.");
            Console.WriteLine("ICloneable:");
            Console.WriteLine("  + Является стандартным интерфейсом .NET, легко используется с коллекциями.");
            Console.WriteLine("  - Возвращает object, что требует приведения типа и может вызывать проблемы с безопасностью типов.");

            Console.ReadKey();
        }

        static void PrintInfo(string title, Gator gator)
        {
            Console.WriteLine($"{title}:");
            Console.WriteLine($"  Название: {gator.Name}");
            Console.WriteLine($"  Дата возникновения: {gator.DateOccurrence}");
            Console.WriteLine($"  Инфицированно устройств: {gator.InfectedDevices}");
        }
    }
}
