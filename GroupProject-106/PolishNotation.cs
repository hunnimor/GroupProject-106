namespace GroupProject_106
{
    public class PostfixNotationExpression
    {
        public PostfixNotationExpression()
        {
            operators = new List<string>(standart_operators);

        }
        private List<string> operators;
        private List<string> standart_operators = new List<string>(new string[] { "(", ")", "+", "-", "*", "/", "^", "cos", "sin", "tg", "ctg", "ln", "log", "sqrt" });

        public List<string> Separate(string input, double x)
        {

            List<string> arr = new List<string>();
            int pos = 0;
            while (pos < input.Length)
            {
                string s = string.Empty;
                if (standart_operators.Contains(input[pos].ToString()) && pos != 0 && input[pos - 1] != '(')
                {
                    s += input[pos];
                }
                else if (input[pos] == '-')
                {
                    s += input[pos];
                    for (int i = pos + 1; i < input.Length &&
                            (Char.IsLetter(input[i]) || Char.IsDigit(input[i])); i++)
                        s += input[i];
                }
                else if (!standart_operators.Contains(input[pos].ToString()))
                {
                    if (Char.IsDigit(input[pos]))
                        for (int i = pos; i < input.Length &&
                            (Char.IsDigit(input[i]) || input[i] == '.'); i++)
                            s += input[i];
                    else if (Char.IsLetter(input[pos]))
                        for (int i = pos; i < input.Length &&
                            (Char.IsLetter(input[i]) || Char.IsDigit(input[i])); i++)
                            s += input[i];
                }
                if (s.Length == 0)
                {
                    pos += 1;
                }
                else
                {
                    pos += s.Length;
                    arr.Add(s);
                }
            }
            Dictionary<string, string> constanti = new Dictionary<string, string>()
            {
                {"E", (Math.E).ToString()},
                {"-E", '-'+(Math.E).ToString()},
                {"Pi", (Math.PI).ToString()},
                {"-Pi", '-'+(Math.PI).ToString()},
                {"x",  x.ToString()},
                {"-x", x <= 0 ? Math.Abs(x).ToString() : ('-'+x.ToString())}
            };
            foreach (var c in constanti)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (c.Key == arr[i])
                    {
                        arr[i] = c.Value;
                    }
                }
            }
            return arr;
        }
        private byte GetPriority(string s)
        {
            switch (s)
            {
                case "(":
                case ")":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "^":
                case "cos":
                case "sin":
                case "tg":
                case "ctg":
                case "ln":
                case "log":
                case "sqrt":
                    return 3;
                default:
                    return 4;
            }
        }

        public string[] ConvertToPostfixNotation(string input, double x)
        {
            List<string> outputSeparated = new List<string>();
            Stack<string> stack = new Stack<string>();
            foreach (string c in Separate(input, x))
            {
                if (operators.Contains(c))
                {
                    if (stack.Count > 0 && !c.Equals("("))
                    {
                        if (c.Equals(")"))
                        {
                            string s = stack.Pop();
                            while (s != "(")
                            {
                                outputSeparated.Add(s);
                                s = stack.Pop();
                            }
                        }
                        else if (GetPriority(c) > GetPriority(stack.Peek()))
                            stack.Push(c);
                        else
                        {
                            while (stack.Count > 0 && GetPriority(c) <= GetPriority(stack.Peek()))
                                outputSeparated.Add(stack.Pop());
                            stack.Push(c);
                        }
                    }
                    else
                        stack.Push(c);
                }
                else
                    outputSeparated.Add(c);
            }
            if (stack.Count > 0)
                foreach (string c in stack)
                    outputSeparated.Add(c);

            return outputSeparated.ToArray();
        }


        public double result(string input, double x)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>(ConvertToPostfixNotation(input, x));
            string str = queue.Dequeue();

            while (queue.Count >= 0)
            {
                if (!operators.Contains(str))
                {
                    stack.Push(str);
                    str = queue.Dequeue();
                }
                else
                {
                    double summ = 0;
                    try
                    {

                        switch (str)
                        {

                            case "+":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    double b = Convert.ToDouble(stack.Pop());
                                    summ = a + b;
                                    break;
                                }
                            case "-":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    double b = Convert.ToDouble(stack.Pop());
                                    summ = b - a;
                                    break;
                                }
                            case "*":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    double b = Convert.ToDouble(stack.Pop());
                                    summ = b * a;
                                    break;
                                }
                            case "/":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    double b = Convert.ToDouble(stack.Pop());
                                    if (a == 0) summ = 0;
                                    if (a != 0) summ = b / a;
                                    break;
                                }
                            case "^":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    double b = Convert.ToDouble(stack.Pop());
                                    summ = Math.Pow(b, a);
                                    break;
                                }
                            case "cos":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    summ = Convert.ToDouble(Math.Cos(a));
                                    break;
                                }
                            case "sin":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    summ = Convert.ToDouble(Math.Sin(a));
                                    break;
                                }
                            case "tg":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    summ = Convert.ToDouble(Math.Tan(a));
                                    break;
                                }
                            case "ctg":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    summ = Convert.ToDouble(1 / Math.Tan(a));
                                    break;
                                }
                            case "ln":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    summ = Convert.ToDouble(Math.Log(a));
                                    break;
                                }
                            case "log":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    double b = Convert.ToDouble(stack.Pop());
                                    summ = Math.Log(a, b);
                                    break;
                                }
                            case "sqrt":
                                {
                                    double a = Convert.ToDouble(stack.Pop());
                                    summ = Math.Sqrt(a);
                                    break;
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR!");
                        Console.WriteLine(ex);
                        Console.ReadLine();
                    }
                    stack.Push(summ.ToString());
                    if (queue.Count > 0)
                        str = queue.Dequeue();
                    else
                        break;
                }

            }
            return Convert.ToDouble(stack.Pop());
        }

    }
}
