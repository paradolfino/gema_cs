using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            Translate();
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
        }

        static void Translate() {
            //        temp = input
            //input = input.strip.downcase.split('')
            //alphabet = create_alphabet; translation = []
            //vowels = ["a", "e", "i", "o", "u"]; vowel_sum = []; cons_sum = []
            //input.each { | i | vowel_sum << alphabet[i] if vowels.include ? (i) }
            //        input.each { | i | cons_sum << alphabet[i] if !vowels.include ? (i) }
            //        input.each { | i | translation << (alphabet[i] || 0) }
            //        sequence = translation.join
            //p "#{temp}:: Sequence: #{sequence} Sum #{translation.reduce(&:+)}"
            //puts "Your numbers are: #{sum(vowel_sum.join + cons_sum.join, "Total")} #{sum(vowel_sum.join, "Vowels")} #{sum(cons_sum.join, "Consonants")}"
            string temp = Console.ReadLine();
            string input = Regex.Replace(temp.ToLower(), @"\s+", "");
            
        }
    }
}
