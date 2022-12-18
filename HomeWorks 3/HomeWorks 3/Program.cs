using System;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWorks_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        // Task-1  Verilmiş string dəyərindəki bütün sözlərin arasında bir boşluq qalacaq vəziyyətə salan metod.
        static string MakeOneSpace(ref string sentences)
        {
            sentences.Trim();
            string NewSentences = "";
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i] == ' ' && sentences[i + 1] == ' ')
                {
                    continue;
                }
                else
                {
                    NewSentences += sentences[i];
                }
            }
            sentences = NewSentences;
            return sentences;
        }

        // Task-2   Verilmiş string dəyərdəki sözlərin sayını tapan metod.
        static int HowManyWord(string sentence)
        {
            string NewSentence=MakeOneSpace(ref sentence);
            var count = 0;
            if (NewSentence == "")
            {
                return 0;
            }
            for (int i = 0; i < NewSentence.Length; i++)
            {
                if (NewSentence[i] == ' ')
                {
                    count++;
                }
            }
            count++;
            return count;
        }

        // Task-3  Parameter olaraq integer array variable-ı (reference) və bir integer value qəbul edən
        // və həmin integer value-nu integer array-ə yeni element kimi əlavə edən metod.
        static int[] IntBack(ref int[] input1, ref int input2)
        {
            int[] NewArr = new int[input1.Length + 1];
            int j = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                if (j == i)
                {
                    NewArr[j] = input1[i];
                    j++;
                }
            }
            NewArr[j++] = input2;
            return NewArr;
        }

        // Task-4  Gonderilmis fullname arrayinden yeni bir names arrayi duzeldib geri qaytaran metod.
        static string[] BackNames(string[] fullnames)
        {
            string[] names = new string[fullnames.Length];
            for (int i = 0; i < fullnames.Length; i++)
            {
                int B = fullnames[i].IndexOf(" ");
                int A = fullnames[i].Length - B;
                names[i] = fullnames[i].Remove(B, A);
            }
            return names;
        }

        // Task-5  Verilmiş string dəyərin bir fullname olub olmadığını yoxlayan metod.
        static bool IsFullName(string fullname)
        {
            bool FullName = true;
            bool IsDigit = false;
            bool TwoWord = false;
            bool IsUpper = false;
            bool IsLower = false;
            if (char.IsUpper(fullname[0]) && char.IsUpper(fullname[fullname.IndexOf(' ') + 1]))
            {
                IsUpper = true;
            }
            if (fullname.Contains(' '))
            {
                TwoWord = true;
            }
            for (int i = 1; i < fullname.IndexOf(' '); i++)
            {
                if (char.IsDigit(fullname[i]))
                {
                    IsDigit = true;
                }
                if (char.IsLower(fullname[i]))
                {
                    IsLower = true;
                }
                else
                {
                    IsLower = false;
                    break;
                }
            }
            for (int i = fullname.IndexOf(' ') + 2; i < fullname.Length; i++)
            {
                if (char.IsDigit(fullname[i]))
                {
                    IsDigit = true;
                }
                if (IsLower == false)
                {
                    break;
                }
                if (char.IsLower(fullname[i]))
                {
                    IsLower = true;
                }
                else
                {
                    IsLower = false;
                    break;
                }
            }
            if (IsDigit == false && IsUpper == true && TwoWord == true && IsLower == true)
            {
                return FullName;
            }
            else return FullName = false;
        }
    }
}
