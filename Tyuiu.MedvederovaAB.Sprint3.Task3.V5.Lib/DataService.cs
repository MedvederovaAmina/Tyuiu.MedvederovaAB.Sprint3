﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedvederovaAB.Sprint3.Task3.V5.Lib
{
    public class DataService : ISprint3Task3V5
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            foreach (char c in value)
            {
                if (c == replaceable) 
                {
                  value = value.Replace(c, replacement);
                }
            }return value;
        }
    }
}