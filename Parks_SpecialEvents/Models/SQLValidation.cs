using System;
using System.Collections.Generic;

namespace Parks_SpecialEvents.Models
{
    public class SQLValidation
    {
        private List<string> keyWords;
        public SQLValidation()
        {
            keyWords = new List<string>();
            keyWords.Add("DELETE");
            keyWords.Add("FROM");
            keyWords.Add("WHERE");
            keyWords.Add("UPDATE");
            keyWords.Add("SET");
            keyWords.Add("SELECT");
            keyWords.Add("*");
            keyWords.Add("DROP");
            keyWords.Add("DROP TABLE");
            keyWords.Add(";");
            keyWords.Add("'");
            keyWords.Add("xp_");
            keyWords.Add("--");
            keyWords.Add("/*");
            keyWords.Add("*/");
        }

        public bool isValid(string search)
        {
            Console.WriteLine("INSIDE IS VALID SQL");
            if (search == "" || search == null)
            {
                return false;
            }

            foreach (string keyword in keyWords)
            {
                Console.WriteLine(keyword);
                if (search.ToUpper().Contains(keyword))
                {
                    Console.WriteLine($"KEY WORD FOUND: {keyword}");
                    return false;
                }
            }
            return true;
        }
    }
}
