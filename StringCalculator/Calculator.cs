using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers) {
            
            List<int> negitiveList = new List<int>();
            char delimiterString = ',';
            string changeDelimiterTest= "";
            if (numbers.Length >=2) changeDelimiterTest = numbers.Substring(0, 2);
            if (changeDelimiterTest == "//") {
                numbers = numbers.Substring(2);
                int cutPoint = numbers.IndexOf("\n");
                delimiterString = char.Parse(numbers.Substring(0, cutPoint));
            }

            numbers =  numbers.Replace('\n', delimiterString);
            string[] stringList = numbers.Split(delimiterString);
            List<int> intList = new List<int>();

            foreach (string s in stringList) {
                int outInt;
                bool parseWorked = false;
                parseWorked = int.TryParse(s, out outInt);
                if (parseWorked && outInt > -1) intList.Add(outInt);
                if (parseWorked && outInt <= -1) negitiveList.Add(outInt);
            }
            int totalVal = 0;
            foreach (int i in intList) {
                totalVal += i;
                
            }
            if (negitiveList.Count > 0) {
                string errorMessage = "negitives not allowed";
                foreach (var n in negitiveList) {
                    errorMessage += " " + n;
                }
                throw new System.ArgumentException (errorMessage);
            }

            

            return totalVal;
        }
    }
}
