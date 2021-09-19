using System;
using System.Collections.Generic;
using System.Linq;

public class Generator
{
    public Generator()
    {
    }

    public List<string> Generate()
    {
        var list = new List<string>();

        for (int i = 0; i<= 99; ++i) {
            var value = i.ToString();

            if (i%5 == 0) value = "Buzz";
            if (i%3 == 0) value = "Fizz";
            if (i%3 == 0 && i%5 == 0) value = "FizzBuzz";
            
            list.Add(value);
        }
        return list;
    }
}