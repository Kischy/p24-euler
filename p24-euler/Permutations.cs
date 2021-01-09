using System;
using System.Collections.Generic;
using System.Text;

namespace p24_euler
{
    public class Permutations
    {
        
        private struct SimpleSwitchingAdPermutationIndexes
        {
            // A Simple switching permutation is one where only the characters of two ajacent indizies have two be switched to get the next permutation
            public int firstInd;
            public int secInd;
            public bool iSSimpleSwitchingAjPermutation;
        }

        private static void SwapListElements(List<char> list,  int firstInd, int secInd)
        {
            char tmp = list[firstInd];
            list[firstInd] = list[secInd];
            list[secInd] = tmp;
        }


        private bool SecondLastCharLowerThanLastChar(List<char> perm)
        {
            return perm[perm.Count - 2] < perm[perm.Count - 1];
        }

        private void SwapLastTwoChars(List<char> perm)
        {
            SwapListElements(perm, perm.Count - 2, perm.Count - 1);
        }


        private SimpleSwitchingAdPermutationIndexes NextPermuationIsCreatedBySwitchingTwoNumbers(List<char> perm)
        {

            SimpleSwitchingAdPermutationIndexes ssi;
            ssi.iSSimpleSwitchingAjPermutation = false;
            ssi.firstInd = -1;
            ssi.secInd = -1;

            //Special case if the last two numbers are just switchable
            if (SecondLastCharLowerThanLastChar(perm))
            {
                ssi.firstInd = perm.Count - 2;
                ssi.secInd = perm.Count - 1;
                ssi.iSSimpleSwitchingAjPermutation = true;
                return ssi;
            }


            char lastChar = perm[perm.Count - 2];

            for (int i = perm.Count - 3; i >= 1; --i) //Do not use the first number
            {
                if(lastChar-1 == perm[i]) //They must be only 1 lexiographic value from each other, otherwise they can't be just switched
                {
                    ssi.firstInd = i;
                    ssi.secInd = i+1;
                    ssi.iSSimpleSwitchingAjPermutation = true;
                    return ssi;
                }
                else
                {
                    lastChar = perm[i];
                }
            }                         

            return ssi;
        }


        private char GetSmallestChar(List<char> perm)
        {
            char smChar = perm[0];
            for(int i = 1; i < perm.Count; ++i)
            {
                if(smChar > perm[i])
                {
                    smChar = perm[i];
                }
            }

            return smChar;
        }

        private char GetNextSmallerCharReverse(char c, List<char> perm)
        {
            for(int i = perm.Count-1; i >=0 ; --i)
            {
                if(perm[i] < c)
                {
                    return perm[i];
                }
            }

            return c;
        }

        private List<char> GetNewPermutation(List<char> current, int startLength, char AfterStartChar1, char AfterStartChar2, int endingStartInd, int endingLength)
        {
            List<char> newPerm = current;

            List<char> startPerm = newPerm.GetRange(0, startLength);
            List<char> endPerm = newPerm.GetRange(endingStartInd, endingLength);

            newPerm = startPerm;
            newPerm.Add(AfterStartChar1);
            newPerm.Add(AfterStartChar2);

            endPerm.Sort();

            newPerm.AddRange(endPerm);


            return newPerm;
        }


        public List<char> GetNextPermutation(List<char> current)
        {
            SimpleSwitchingAdPermutationIndexes ssi = NextPermuationIsCreatedBySwitchingTwoNumbers(current);

            if (ssi.iSSimpleSwitchingAjPermutation)
            {
                SwapListElements(current, ssi.firstInd, ssi.secInd);
                return current;                
            }

            char smallestCharOfLastTwo = GetSmallestChar(current.GetRange(current.Count-2,2));
            int smallestCharOfLastTwoIndex = current.IndexOf(smallestCharOfLastTwo);

            char nextSmallerCharFromReverse = GetNextSmallerCharReverse(smallestCharOfLastTwo, current);
            int nextSmallerCharFromReverseIndex = current.IndexOf(nextSmallerCharFromReverse);


            List<char> newPerm = GetNewPermutation(current,
                nextSmallerCharFromReverseIndex, smallestCharOfLastTwo, nextSmallerCharFromReverse,
                nextSmallerCharFromReverseIndex + 1, smallestCharOfLastTwoIndex - (nextSmallerCharFromReverseIndex + 1));


            return newPerm;
        }
    }
}
