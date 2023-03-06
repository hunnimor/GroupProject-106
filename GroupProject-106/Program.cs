using PolishNotation;

namespace GroupProject_106
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            PostfixNotationExpression c = new PostfixNotationExpression();
            string text = "cos(x)";
            Console.WriteLine(text);

            string result = "";
            for (int i = 0; i < c.ConvertToPostfixNotation(text).Length; i++)
            {
                result += c.ConvertToPostfixNotation(text)[i];
                result += " ";
            }
            Console.WriteLine(result);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}