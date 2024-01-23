using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuringTests.Classes
{
    // Turing Practice Test
    public class Solution
    {
        public int CalPoints(string[] ops) {
        List <int> record = new List<int>();
        for (int i = 0; i < ops.Length; i++) {
            switch(ops[i]) {
                case "C":
                    record.RemoveAt(record.Count - 1);
                    break;
                case "D":
                    record.Add(2 * record[record.Count - 1]);
                    break;
                case "+":
                    record.Add(record[record.Count-2] + record[record.Count-1]);
                    break;
                default:
                    record.Add(int.Parse(ops[i]));
                    break;
            }
        }
        return record.Sum();
    }
    }
}