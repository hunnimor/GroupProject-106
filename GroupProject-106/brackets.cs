using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_106
{
    class brackets
    {
        private string line { get; set; }
        public brackets(string line)
        {
            this.line = line;
        }
        public int CorrectBrackets()
        {
            var stack = new Stack<char>();
            var stackIndex = new Stack<int>();
            for (int i = 0; i < line.Length; i++)
            {
                switch (line[i])
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(line[i]);
                        stackIndex.Push(i);
                        break;

                    case '}':
                        if (stack.Count == 0) return i;
                        if (stack.Pop() != '{') return i;
                        break;
                    case ']':
                        if (stack.Count == 0) return i;
                        if (stack.Pop() != '[') return i;
                        break;
                    case ')':
                        if (stack.Count == 0) return i;
                        if (stack.Pop() != '(') return i;
                        break;
                }
            }
            if (stack.Count > 0)
            {

                return stackIndex.Pop();
            }
            stack.Clear();
            stackIndex.Clear();
            return -1;
        }
    }
}