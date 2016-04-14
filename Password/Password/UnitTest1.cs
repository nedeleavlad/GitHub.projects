using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetSize()
        {
            Assert.AreEqual(5, GeneratePassword(5).Length);
        }

        [TestMethod]
        public void CountUpperCases()
        {
            Assert.AreEqual(9, CountTheNumbers(GeneratePassword(20, 10, 9)));
        }

        [TestMethod]
        public void HowManySymbolsContains()
        {
            Assert.AreEqual(5, CountSymbols("*+-()a"));
        }

        [TestMethod]
        public void HowManyDigits()
        {
            Assert.AreEqual(3, CountTheNumbers("s113"));
            Assert.AreEqual(5, CountTheNumbers("a11113"));
        }

        [TestMethod]
        public void AmbigueCharacters()
        {
            Assert.AreEqual(true, CheckForAmbiguousCharacters('>'));
            Assert.AreEqual(false, CheckForAmbiguousCharacters('1'));
        }

        [TestMethod]
        public void GetSimilarCharacters()
        {
            Assert.AreEqual(true, CheckForSimilarCharacters('1'));
            Assert.AreEqual(false, CheckForSimilarCharacters('>'));
        }

        [TestMethod]
        public void CountDigits()
        {
            Assert.AreEqual(9, CountUppercases(GeneratePassword(20, 9)));
        }

        [TestMethod]
        public void WhatUppercaseContingPassword()
        {
            Assert.AreEqual(3, CountUppercases("ssaaGGF"));
            Assert.AreEqual(0, CountUppercases("aaaa"));
        }

        [TestMethod]
        public void CountSymbols()
        {
            Assert.AreEqual(10, CountSymbols(GeneratePassword(20, 0, 0, 10)));
        }

        private string GeneratePassword(int number, int uppercase = 0, int digits = 0, int symbols = 0)
        {
            string result = string.Empty;

            Random rnd = new Random();

            result = GetConditions(number, uppercase, digits, rnd, symbols);

            return result;
        }

        private static string GetConditions(int number, int uppercase, int digits, Random rnd, int symbols)
        {
            string result = string.Empty;

            result = GetPasword((number - uppercase - digits - symbols), rnd, result, 'a', (char)('z' + 1));

            result = GetPasword(uppercase, rnd, result, 'A', (char)('Z' + 1));

            result = GetPasword(digits, rnd, result, (char)48, (char)(58));

            result = GenerateSymbols(rnd, symbols, result);

            return result;
        }

        private static string GenerateSymbols(Random rnd, int symbols, string result)
        {
            string symbolsString = "!#$%&()+,-./:;<>*=?@[_{}]\\";
            char symbolsGenerate = ' ';
            int counter = 0;
            for (int i = 0; i < symbols; i++)
            {
                while (counter == 0)
                {
                    symbolsGenerate = symbolsString[rnd.Next(symbolsString.Length)];
                    if (!CheckForSimilarCharacters(symbolsGenerate) && !CheckForAmbiguousCharacters(symbolsGenerate))
                    {
                        result += symbolsGenerate;
                        counter = 1;
                    }
                    else symbolsGenerate = ' ';
                }
                counter = 0;
            }
            return result;
        }

        private static string GetPasword(int dimension, Random rnd, string result, char x, char y)
        {
            char symbolsGenerate = ' ';

            int counter = 0;

            for (int i = 0; i < dimension; i++)
            {
                while (counter == 0)
                {
                    symbolsGenerate = (char)rnd.Next(x, y);
                    if (!CheckForSimilarCharacters(symbolsGenerate) && !CheckForAmbiguousCharacters(symbolsGenerate))
                    {
                        result += symbolsGenerate;
                        counter = 1;
                    }
                    else symbolsGenerate = ' ';
                }
                counter = 0;
            }
            return result;
        }

        private int CountTheNumbers(string word)
        {
            int counter = 0;

            foreach (char c in word)
            {
                if (char.IsNumber(c))
                    counter++;
            }
            return counter;
        }

        private int CountUppercases(string word)
        {
            int counter = 0;

            foreach (char c in word)
            {
                if (char.IsUpper(c))
                    counter++;
            }
            return counter;
        }

        private int CountSymbols(string symbols)
        {
            int counter = 0;

            string symbolsString = "!#$%&()+,-./:;<>*=?@[_{}]\\";

            for (int i = 0; i < symbols.Length; i++)

                for (int j = 0; j < symbolsString.Length; j++)
                {
                    if (symbols[i] == symbolsString[j])
                    {
                        counter++;
                    }
                }
            return counter;
        }

        private static bool CheckForAmbiguousCharacters(char character)
        {
            return VerifyCharactersSimilareAmbigue(character, "ambiguous");
        }

        private static bool CheckForSimilarCharacters(char character)
        {
            return VerifyCharactersSimilareAmbigue(character, "similar");
        }

        private static bool VerifyCharactersSimilareAmbigue(char character, string similarOrAmbigue)
        {
            string symbolsSimilar = "l1Io0O";

            string symbolsAmbiguous = "{}[]()/\'~,;.<>";

            string symbols = string.Empty;

            if (similarOrAmbigue == "ambiguous") symbols = symbolsAmbiguous;
            else symbols = symbolsSimilar;

            for (int i = 0; i < symbols.Length; i++)
            {
                if (character == (char)symbols[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}