
    using System;
    using System.Text.RegularExpressions;
    
    namespace HW2._2
    {
        class Program
        {
            public static string GetValue(string str)
            {
                Regex strRegext = new Regex(@"=\w*");
                MatchCollection matches = strRegext.Matches(str);
                int count = 0;
    
                foreach (var mat in matches)
                {
                    count++;
                }
    
                if (count != 0)
                {
                    string s = matches[0].ToString().Remove(0,1);
                    return s;
                }
                else
                {
                    if (str == "--flag")
                    {
                        return "true";
                    }
                    else
                    {
                        return "Вы передали аргумент без значения";
                    }
                }
            }
    
            static void Main(string[] args)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].StartsWith("--string"))
                    {
                        
                        Console.WriteLine("string:"+GetValue(args[i]));
                    }
                    else if (args[i].StartsWith("--number"))
                    {
                        
                        Console.WriteLine("number:"+GetValue(args[i]));
                        
                    }
                    else if(args[i].StartsWith("--flag"))
                    { 
                        Console.WriteLine("flag:"+GetValue(args[i]));
                    }
                    
                }
            }
        }
    }