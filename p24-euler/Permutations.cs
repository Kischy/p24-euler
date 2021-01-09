using System;
using System.Collections.Generic;
using System.Text;

namespace p24_euler
{
    public class Permutations
    {

        List<String> permutations;
        String chars;


        public Permutations(List<char> characters)
        {
            characters.Sort();
            chars = new String(characters.ToArray());
            permutations = new List<String>();

            CalcAllPermutations(chars, 0);
            permutations.Sort();
        }


        private void CalcAllPermutations(String str, int ind)
        {
            if (ind == str.Length-1)
            {
                permutations.Add(str);
            }
            else
            {
                for (int i = ind; i < str.Length; i++)
                {
                    if(ind == i)
                    {
                        CalcAllPermutations(str, ind + 1);
                    }
                    else
                    {
                        str = SwapCharacters(str, ind, i);
                        CalcAllPermutations(str, ind + 1);
                        str = SwapCharacters(str, ind, i);
                    }
                }
            }
        }

        public static String SwapCharacters(String str, int i, int j)
        {
            char[] charArray = str.ToCharArray();

            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;

            return new string(charArray);
        }


        public String GetPermutation(int index)
        {
            return permutations[index];
        }



    }
}
