        static List<string> correctness(List<string> roktx)
        {
            List<string> results = new List<string>();

            //prepare possible combinations
            foreach (var item in roktx)
            {
                var result = correctCheck(item);
                results.Add(result ? "YES" : "NO");

            }
            return results;
        }
        static bool correctCheck(string name)
        {
            Hashtable map = new Hashtable();
            map['('] = ')';
            map['['] = ']';
            map['{'] = '}';
            Stack<char> stack = new Stack<char>();
            foreach (char c in name)
            {
                if (map.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if ((stack.Count > 0 && (map[stack.Peek()]).Equals(c)))
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }

            }

            return stack.Count == 0;
        }
