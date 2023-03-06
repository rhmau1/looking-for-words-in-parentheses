using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCaseNo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "3. Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu (program komputer yang dapat (1) mengenali, (2) meringkas, (3) menerjemahkan, (4) memprediksi, dan (5) menghasilkan teks)";
            Console.WriteLine(text);

            int start = text.IndexOf('(');
            int end = text.IndexOf(')');
            start += 1;
            int length = end - start;

            Console.WriteLine("Output:");
            Console.WriteLine($"-{text.Substring(start, length)}");

            start = text.IndexOf('(', end += 1);
            end = text.LastIndexOf(')');
            start += 1;
            length = end - start;
            string LongText = text.Substring(start, length);
            Console.WriteLine($"-{LongText}");

            while (true)
            {
                start = LongText.IndexOf('(');
                if (start == -1) break;

                start += 1;
                end = LongText.IndexOf(')');
                length = end - start;
                Console.WriteLine($"-{LongText.Substring(start, length)}");
                LongText = LongText.Substring(end + 1);
            }
        }
    }
}
