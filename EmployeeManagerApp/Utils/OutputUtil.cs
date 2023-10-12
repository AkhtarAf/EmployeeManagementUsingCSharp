namespace EmployeeManagerApp.Utils
{
    public static class OutputUtil
    {
        public static void Print(string? message)
        {
            Console.WriteLine(message);
        }

        public static void PrintTable<T>(List<T> items)
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No items to display.");
                return;
            }

            var properties = typeof(T).GetProperties();
            var columnWidths = new int[properties.Length];

            // Get the maximum width of each column
            for (int i = 0; i < properties.Length; i++)
            {
                columnWidths[i] = properties[i].Name.Length;
                foreach (var item in items)
                {
                    var value = properties[i].GetValue(item)?.ToString() ?? "";
                    columnWidths[i] = Math.Max(columnWidths[i], value.Length);
                }
            }

            // Print the header row
            for (int i = 0; i < properties.Length; i++)
            {
                Console.Write(properties[i].Name.PadRight(columnWidths[i] + 2));
            }
            Console.WriteLine();

            // Print the separator row
            for (int i = 0; i < properties.Length; i++)
            {
                Console.Write(new string('-', columnWidths[i]).PadRight(columnWidths[i] + 2, '-'));
            }
            Console.WriteLine();

            // Print the data rows
            foreach (var item in items)
            {
                for (int i = 0; i < properties.Length; i++)
                {
                    var value = properties[i].GetValue(item)?.ToString() ?? "";
                    Console.Write(value.PadRight(columnWidths[i] + 2));
                }
                Console.WriteLine();
            }
        }
    }
}
