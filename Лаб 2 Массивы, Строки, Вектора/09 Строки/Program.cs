static void Main(string[] args)
        {
            var counter = 0;
            using (var sr = new StreamReader("input.txt"))
            {
                var textString = sr.ReadToEnd();
                var text = textString.Split(' ');
                string symbol = textString.Substring(textString.Length-1);
                for (int i = 0; i< text.Length; i++)
                {
                    if (text[i].EndsWith(symbol))
                        counter++;
                }
            }
            using (var sw = new StreamWriter("out.txt"))
            {
                if (counter == 1)
                    sw.WriteLine(-1);
                else
                    sw.WriteLine(counter-1);
            }
        }
