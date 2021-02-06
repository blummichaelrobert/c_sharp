using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Data
{
    public class ProjectData
    {
        public string[] getRandomStringifiedNumberArray() 
        {
            var rand = new Random();
            string[] numbers = new string[4000];
            for (var i = 0; i < 4000; i++)
            {
                numbers[i] = rand.Next(0, 15).ToString();
            }
            return numbers;
        }

        public Dictionary<int, string> getNumberMap()
        {
            return new Dictionary<int, string>() {
                { 0, "0"},
                { 1, "1"},
                { 2, "2"},
                { 3, "3"},
                { 4, "4"},
                { 5, "5"},
                { 6, "6"},
                { 7, "7"},
                { 8, "8"},
                { 9, "9"},
                { 10, "10"},
                { 11, "11"},
                { 12, "12"},
                { 13, "13"},
                { 14, "14"},
                { 15, "15"}
            };
        }

        public string[] getNumberArray()
        {
            return new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
        }
    }
}
