using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace buscaPalabra
{
    class ControlPermutaciones
    {

        public ControlPermutaciones()
        {

        }

        public List<String> combinationList = new List<string>();
        List<String> myDictionary = new List<string>() { "bac", "cab", "acb", "a", "b", "cba"};
        public List<String> wordsInsideDictionary = new List<string>();

        public bool foundWord(string word)
        {
            bool isFound = false;
            foreach (string sameWord in combinationList)
            {

                if (word == sameWord)
                {
                    isFound = true;
                    break;
                }

            }
            if (isFound == false)
            {
                combinationList.Add(word);
            }


            return isFound;
        }

        public void foundWordInDictionary(string word)
        {


            foreach (string wordInDictionary in myDictionary)
            {
                if (word == wordInDictionary)
                {
                    wordsInsideDictionary.Add(word);
                }
            }
        }


    }
}
