namespace EmployeeManagerApp.Utils {
    public static class InputUtil {
        public static int GetInt(string message) {
            Console.Write(message + " (Integer): ");
            int result;
            while (!int.TryParse(Console.ReadLine(), out result)) {
                Console.Write("Invalid input. Please try again.\n" + message + ": ");
            }
            return result;
        }

        public static double GetDouble(string message) {
            Console.Write(message + " (in decimal): ");
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) {
                Console.Write("Invalid input. Please try again.\n" + message + " (Decimal): ");
            }
            return result;
        }

        public static string GetString(string message) {
            Console.Write(message + ": ");
            string? result;
            while (string.IsNullOrEmpty(result = Console.ReadLine())) {
                Console.Write("Invalid input. Please try again.\n" + message + ": ");
            }
            return result;
        }
    }
}