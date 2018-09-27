using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gematria_sharp
{
    class Gematria
    {
        public static Hashtable vals = new Hashtable();
        static void Main(string[] args)
        {
            CreateAlphabet();
            foreach(DictionaryEntry entry in vals) {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }
        }

        static void CreateAlphabet() {
            char[] arr = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int[] nums = Enumerable.Range(1, 9).ToArray();
            int count = 1;


            foreach(char i in arr) {
                vals.Add(i, count);
                if (count < 9) {
                    count += 1;
                } else {
                    count = 1;
                }
            }

            //ICollection valKeys = vals.Keys;

            //foreach(char i in valKeys) {
            //    Console.WriteLine(i + ":" + vals[);
            //}
            //Console.ReadLine();
        }
    }
}
