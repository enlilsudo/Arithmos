﻿/*
* Copyright (c) 2018 - 2021 Daniel Lascelles, https://github.com/dlascelles
* This code is licensed under The MIT License. See LICENSE file in the project root for full license information.
* License URL: https://github.com/dlascelles/Arithmos/blob/master/LICENSE
*/
using System;
using System.Collections.Generic;

namespace ArithmosModels.Helpers
{
    /// <summary>
    /// Contains all available characters, in all alphabets along with their corresponding values in all Calculation Methods
    /// </summary>
    public static class ValueMapper
    {
        /// <summary>
        /// Will return the value of a normalized string based on the chosen method
        /// </summary>
        /// <param name="normalizedText">The normalized string</param>
        /// <param name="calculationMethod">The CalculationMethod to be used</param>
        /// <returns>The integer value of the string</returns>
        /// <exception cref="ArgumentException">Thrown when the CalculationMethod Enum parameter contains more than one value</exception>
        public static int GetValue(string normalizedText, CalculationMethod calculationMethod)
        {
            if ((calculationMethod & (calculationMethod - 1)) != 0) throw new ArgumentException("CalculationMethod cannot have more than one flag when requesting a value.");

            int value = 0;
            foreach (Char c in normalizedText)
            {
                if (CharacterValues.TryGetValue(c, out Dictionary<CalculationMethod, int> dic))
                {
                    value += dic[calculationMethod];
                }
            }

            return value;
        }

        public static readonly Dictionary<Char, Dictionary<CalculationMethod, int>> CharacterValues = new()
        {
            #region All English Characters
            {
                'A',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 1 },
                    { CalculationMethod.Ordinal, 1 },
                    { CalculationMethod.Reduced, 1 },
                    { CalculationMethod.Sumerian, 6 },
                    { CalculationMethod.Primes, 2 },
                    { CalculationMethod.Squared, 1 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'B',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 2 },
                    { CalculationMethod.Ordinal, 2 },
                    { CalculationMethod.Reduced, 2 },
                    { CalculationMethod.Sumerian, 12 },
                    { CalculationMethod.Primes, 3 },
                    { CalculationMethod.Squared, 4 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'C',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 3 },
                    { CalculationMethod.Ordinal, 3 },
                    { CalculationMethod.Reduced, 3 },
                    { CalculationMethod.Sumerian, 18 },
                    { CalculationMethod.Primes, 5 },
                    { CalculationMethod.Squared, 9 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'D',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 4 },
                    { CalculationMethod.Ordinal, 4 },
                    { CalculationMethod.Reduced, 4 },
                    { CalculationMethod.Sumerian, 24 },
                    { CalculationMethod.Primes, 7 },
                    { CalculationMethod.Squared, 16 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'E',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 5 },
                    { CalculationMethod.Ordinal, 5 },
                    { CalculationMethod.Reduced, 5 },
                    { CalculationMethod.Sumerian, 30 },
                    { CalculationMethod.Primes, 11 },
                    { CalculationMethod.Squared, 25 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'F',
                new Dictionary<CalculationMethod, int>() {
                     { CalculationMethod.Gematria, 6 },
                    { CalculationMethod.Ordinal, 6 },
                    { CalculationMethod.Reduced, 6 },
                    { CalculationMethod.Sumerian, 36 },
                    { CalculationMethod.Primes, 13 },
                    { CalculationMethod.Squared, 36 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'G',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 7 },
                    { CalculationMethod.Ordinal, 7 },
                    { CalculationMethod.Reduced, 7 },
                    { CalculationMethod.Sumerian, 42 },
                    { CalculationMethod.Primes, 17 },
                    { CalculationMethod.Squared, 49 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'H',
                new Dictionary<CalculationMethod, int>() {
                   { CalculationMethod.Gematria, 8 },
                    { CalculationMethod.Ordinal, 8 },
                    { CalculationMethod.Reduced, 8 },
                    { CalculationMethod.Sumerian, 48 },
                    { CalculationMethod.Primes, 19 },
                    { CalculationMethod.Squared, 64 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'I',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 9 },
                    { CalculationMethod.Ordinal, 9 },
                    { CalculationMethod.Reduced, 9 },
                    { CalculationMethod.Sumerian, 54 },
                    { CalculationMethod.Primes, 23 },
                    { CalculationMethod.Squared, 81 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'J',
                new Dictionary<CalculationMethod, int>() {
                   { CalculationMethod.Gematria, 10 },
                    { CalculationMethod.Ordinal, 10 },
                    { CalculationMethod.Reduced, 1 },
                    { CalculationMethod.Sumerian, 60 },
                    { CalculationMethod.Primes, 29 },
                    { CalculationMethod.Squared, 100 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'K',
                new Dictionary<CalculationMethod, int>() {
                     { CalculationMethod.Gematria, 20 },
                    { CalculationMethod.Ordinal, 11 },
                    { CalculationMethod.Reduced, 2 },
                    { CalculationMethod.Sumerian, 66 },
                    { CalculationMethod.Primes, 31 },
                    { CalculationMethod.Squared, 400 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'L',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 30 },
                    { CalculationMethod.Ordinal, 12 },
                    { CalculationMethod.Reduced, 3 },
                    { CalculationMethod.Sumerian, 72 },
                    { CalculationMethod.Primes, 37 },
                    { CalculationMethod.Squared, 900 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'M',
                new Dictionary<CalculationMethod, int>() {
                   { CalculationMethod.Gematria, 40 },
                    { CalculationMethod.Ordinal, 13 },
                    { CalculationMethod.Reduced, 4 },
                    { CalculationMethod.Sumerian, 78 },
                    { CalculationMethod.Primes, 41 },
                    { CalculationMethod.Squared, 1600 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'N',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 50 },
                    { CalculationMethod.Ordinal, 14 },
                    { CalculationMethod.Reduced, 5 },
                    { CalculationMethod.Sumerian, 84 },
                    { CalculationMethod.Primes, 43 },
                    { CalculationMethod.Squared, 2500 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'O',
                new Dictionary<CalculationMethod, int>() {
                   { CalculationMethod.Gematria, 60 },
                    { CalculationMethod.Ordinal, 15 },
                    { CalculationMethod.Reduced, 6 },
                    { CalculationMethod.Sumerian, 90 },
                    { CalculationMethod.Primes, 47 },
                    { CalculationMethod.Squared, 3600 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'P',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 70 },
                    { CalculationMethod.Ordinal, 16 },
                    { CalculationMethod.Reduced, 7 },
                    { CalculationMethod.Sumerian, 96 },
                    { CalculationMethod.Primes, 53 },
                    { CalculationMethod.Squared, 4900 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Q',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 80 },
                    { CalculationMethod.Ordinal, 17 },
                    { CalculationMethod.Reduced, 8 },
                    { CalculationMethod.Sumerian, 102 },
                    { CalculationMethod.Primes, 59 },
                    { CalculationMethod.Squared, 6400 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'R',
                new Dictionary<CalculationMethod, int>() {
                   { CalculationMethod.Gematria, 90 },
                    { CalculationMethod.Ordinal, 18 },
                    { CalculationMethod.Reduced, 9 },
                    { CalculationMethod.Sumerian, 108 },
                    { CalculationMethod.Primes, 61 },
                    { CalculationMethod.Squared, 8100 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'S',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 100 },
                    { CalculationMethod.Ordinal, 19 },
                    { CalculationMethod.Reduced, 1 },
                    { CalculationMethod.Sumerian, 114 },
                    { CalculationMethod.Primes, 67 },
                    { CalculationMethod.Squared, 10000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'T',
                new Dictionary<CalculationMethod, int>() {
                  { CalculationMethod.Gematria, 200 },
                    { CalculationMethod.Ordinal, 20 },
                    { CalculationMethod.Reduced, 2 },
                    { CalculationMethod.Sumerian, 120 },
                    { CalculationMethod.Primes, 71 },
                    { CalculationMethod.Squared, 40000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'U',
                new Dictionary<CalculationMethod, int>() {
                   { CalculationMethod.Gematria, 300 },
                    { CalculationMethod.Ordinal, 21 },
                    { CalculationMethod.Reduced, 3 },
                    { CalculationMethod.Sumerian, 126 },
                    { CalculationMethod.Primes, 73 },
                    { CalculationMethod.Squared, 90000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'V',
                new Dictionary<CalculationMethod, int>() {
                     { CalculationMethod.Gematria, 400 },
                    { CalculationMethod.Ordinal, 22 },
                    { CalculationMethod.Reduced, 4 },
                    { CalculationMethod.Sumerian, 132 },
                    { CalculationMethod.Primes, 79 },
                    { CalculationMethod.Squared, 160000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'W',
                new Dictionary<CalculationMethod, int>() {
                   { CalculationMethod.Gematria, 500 },
                    { CalculationMethod.Ordinal, 23 },
                    { CalculationMethod.Reduced, 5 },
                    { CalculationMethod.Sumerian, 138 },
                    { CalculationMethod.Primes, 83 },
                    { CalculationMethod.Squared, 250000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'X',
                new Dictionary<CalculationMethod, int>() {
                   { CalculationMethod.Gematria, 600 },
                    { CalculationMethod.Ordinal, 24 },
                    { CalculationMethod.Reduced, 6 },
                    { CalculationMethod.Sumerian, 144 },
                    { CalculationMethod.Primes, 89 },
                    { CalculationMethod.Squared, 360000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Y',
                new Dictionary<CalculationMethod, int>() {
                   { CalculationMethod.Gematria, 700 },
                    { CalculationMethod.Ordinal, 25 },
                    { CalculationMethod.Reduced, 7 },
                    { CalculationMethod.Sumerian, 150 },
                    { CalculationMethod.Primes, 97 },
                    { CalculationMethod.Squared, 490000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Z',
                new Dictionary<CalculationMethod, int>() {
                      { CalculationMethod.Gematria, 800 },
                    { CalculationMethod.Ordinal, 26 },
                    { CalculationMethod.Reduced, 8 },
                    { CalculationMethod.Sumerian, 156 },
                    { CalculationMethod.Primes, 101 },
                    { CalculationMethod.Squared, 640000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            #endregion

            #region All Greek Characters
            {
                'Α',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 1 },
                    { CalculationMethod.Ordinal, 1 },
                    { CalculationMethod.Reduced, 1 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 2 },
                    { CalculationMethod.Squared, 1 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                    }
            },
            {
                'Β',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 2 },
                    { CalculationMethod.Ordinal, 2 },
                    { CalculationMethod.Reduced, 2 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 3 },
                    { CalculationMethod.Squared, 4 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Γ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 3 },
                    { CalculationMethod.Ordinal, 3 },
                    { CalculationMethod.Reduced, 3 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 5 },
                    { CalculationMethod.Squared, 9 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Δ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 4 },
                    { CalculationMethod.Ordinal, 4 },
                    { CalculationMethod.Reduced, 4 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 7 },
                    { CalculationMethod.Squared, 16 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ε',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 5 },
                    { CalculationMethod.Ordinal, 5 },
                    { CalculationMethod.Reduced, 5 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 11 },
                    { CalculationMethod.Squared, 25 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ϛ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 6 },
                    { CalculationMethod.Ordinal, 6 },
                    { CalculationMethod.Reduced, 6 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 13 },
                    { CalculationMethod.Squared, 36 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ζ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 7 },
                    { CalculationMethod.Ordinal, 7 },
                    { CalculationMethod.Reduced, 7 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 17 },
                    { CalculationMethod.Squared, 49 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Η',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 8 },
                    { CalculationMethod.Ordinal, 8 },
                    { CalculationMethod.Reduced, 8 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 19 },
                    { CalculationMethod.Squared, 64 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Θ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 9 },
                    { CalculationMethod.Ordinal, 9 },
                    { CalculationMethod.Reduced, 9 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 23 },
                    { CalculationMethod.Squared, 81 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ι',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 10 },
                    { CalculationMethod.Ordinal, 10 },
                    { CalculationMethod.Reduced, 1 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 29 },
                    { CalculationMethod.Squared, 100 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Κ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 20 },
                    { CalculationMethod.Ordinal, 11 },
                    { CalculationMethod.Reduced, 2 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 31 },
                    { CalculationMethod.Squared, 400 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Λ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 30 },
                    { CalculationMethod.Ordinal, 12 },
                    { CalculationMethod.Reduced, 3 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 37 },
                    { CalculationMethod.Squared, 900 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Μ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 40 },
                    { CalculationMethod.Ordinal, 13 },
                    { CalculationMethod.Reduced, 4 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 41 },
                    { CalculationMethod.Squared, 1600 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ν',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 50 },
                    { CalculationMethod.Ordinal, 14 },
                    { CalculationMethod.Reduced, 5 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 43 },
                    { CalculationMethod.Squared, 2500 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ξ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 60 },
                    { CalculationMethod.Ordinal, 15 },
                    { CalculationMethod.Reduced, 6 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 47 },
                    { CalculationMethod.Squared, 3600 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ο',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 70 },
                    { CalculationMethod.Ordinal, 16 },
                    { CalculationMethod.Reduced, 7 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 53 },
                    { CalculationMethod.Squared, 4900 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Π',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 80 },
                    { CalculationMethod.Ordinal, 17 },
                    { CalculationMethod.Reduced, 8 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 59 },
                    { CalculationMethod.Squared, 6400 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ϙ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 90 },
                    { CalculationMethod.Ordinal, 18 },
                    { CalculationMethod.Reduced, 9 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 61 },
                    { CalculationMethod.Squared, 8100 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ρ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 100 },
                    { CalculationMethod.Ordinal, 19 },
                    { CalculationMethod.Reduced, 1 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 67 },
                    { CalculationMethod.Squared, 10000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Σ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 200 },
                    { CalculationMethod.Ordinal, 20 },
                    { CalculationMethod.Reduced, 2 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 71 },
                    { CalculationMethod.Squared, 40000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Τ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 300 },
                    { CalculationMethod.Ordinal, 21 },
                    { CalculationMethod.Reduced, 3 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 73 },
                    { CalculationMethod.Squared, 90000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Υ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 400 },
                    { CalculationMethod.Ordinal, 22 },
                    { CalculationMethod.Reduced, 4 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 79 },
                    { CalculationMethod.Squared, 160000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Φ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 500 },
                    { CalculationMethod.Ordinal, 23 },
                    { CalculationMethod.Reduced, 5 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 83 },
                    { CalculationMethod.Squared, 250000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Χ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 600 },
                    { CalculationMethod.Ordinal, 24 },
                    { CalculationMethod.Reduced, 6 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 89 },
                    { CalculationMethod.Squared, 360000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ψ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 700 },
                    { CalculationMethod.Ordinal, 25 },
                    { CalculationMethod.Reduced, 7 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 97 },
                    { CalculationMethod.Squared, 490000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ω',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 800 },
                    { CalculationMethod.Ordinal, 26 },
                    { CalculationMethod.Reduced, 8 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 101 },
                    { CalculationMethod.Squared, 640000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            {
                'Ϡ',
                new Dictionary<CalculationMethod, int>() {
                    { CalculationMethod.Gematria, 900 },
                    { CalculationMethod.Ordinal, 27 },
                    { CalculationMethod.Reduced, 9 },
                    { CalculationMethod.Sumerian, 0 },
                    { CalculationMethod.Primes, 103 },
                    { CalculationMethod.Squared, 810000 },
                    { CalculationMethod.MisparGadol, 0 },
                    { CalculationMethod.MisparShemi, 0 },
                }
            },
            #endregion

            #region All Hebrew Characters
            {
                'א',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 1 },
                { CalculationMethod.Ordinal, 1 },
                { CalculationMethod.Reduced, 1 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 2 },
                { CalculationMethod.Squared, 1 },
                { CalculationMethod.MisparGadol, 1 },
                { CalculationMethod.MisparShemi, 111 },

            }
            },
            {
                'ב',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 2 },
                { CalculationMethod.Ordinal, 2 },
                { CalculationMethod.Reduced, 2 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 3 },
                { CalculationMethod.Squared, 4 },
                { CalculationMethod.MisparGadol, 2 },
                { CalculationMethod.MisparShemi, 412 },
            }
            },
            {
                'ג',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 3 },
                { CalculationMethod.Ordinal, 3 },
                { CalculationMethod.Reduced, 3 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 5 },
                { CalculationMethod.Squared, 9 },
                { CalculationMethod.MisparGadol, 3 },
                { CalculationMethod.MisparShemi, 83 },
            }
            },
            {
                'ד',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 4 },
                { CalculationMethod.Ordinal, 4 },
                { CalculationMethod.Reduced, 4 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 7 },
                { CalculationMethod.Squared, 16 },
                { CalculationMethod.MisparGadol, 4 },
                { CalculationMethod.MisparShemi, 434 },
            }
            },
            {
                'ה',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 5 },
                { CalculationMethod.Ordinal, 5 },
                { CalculationMethod.Reduced, 5 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 11 },
                { CalculationMethod.Squared, 25 },
                { CalculationMethod.MisparGadol, 5 },
                { CalculationMethod.MisparShemi, 6 },
            }
            },
            {
                'ו',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 6 },
                { CalculationMethod.Ordinal, 6 },
                { CalculationMethod.Reduced, 6 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 13 },
                { CalculationMethod.Squared, 36 },
                { CalculationMethod.MisparGadol, 6 },
                { CalculationMethod.MisparShemi, 12 },
            }
            },
            {
                'ז',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 7 },
                { CalculationMethod.Ordinal, 7 },
                { CalculationMethod.Reduced, 7 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 17 },
                { CalculationMethod.Squared, 49 },
                { CalculationMethod.MisparGadol, 7 },
                { CalculationMethod.MisparShemi, 67 },
            }
            },
            {
                'ח',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 8 },
                { CalculationMethod.Ordinal, 8 },
                { CalculationMethod.Reduced, 8 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 19 },
                { CalculationMethod.Squared, 64 },
                { CalculationMethod.MisparGadol, 8 },
                { CalculationMethod.MisparShemi, 418 },
            }
            },
            {
                'ט',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 9 },
                { CalculationMethod.Ordinal, 9 },
                { CalculationMethod.Reduced, 9 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 23 },
                { CalculationMethod.Squared, 81 },
                { CalculationMethod.MisparGadol, 9 },
                { CalculationMethod.MisparShemi, 419 },
            }
            },
            {
                'י',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 10 },
                { CalculationMethod.Ordinal, 10 },
                { CalculationMethod.Reduced, 1 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 29 },
                { CalculationMethod.Squared, 100 },
                { CalculationMethod.MisparGadol, 10 },
                { CalculationMethod.MisparShemi, 20 },
            }
            },
            {
                'כ',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 20 },
                { CalculationMethod.Ordinal, 11 },
                { CalculationMethod.Reduced, 2 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 31 },
                { CalculationMethod.Squared, 400 },
                { CalculationMethod.MisparGadol, 20 },
                { CalculationMethod.MisparShemi, 100 },
            }
            },
            {
                'ל',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 30 },
                { CalculationMethod.Ordinal, 12 },
                { CalculationMethod.Reduced, 3 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 37 },
                { CalculationMethod.Squared, 900 },
                { CalculationMethod.MisparGadol, 30 },
                { CalculationMethod.MisparShemi, 74 },
            }
            },
            {
                'מ',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 40 },
                { CalculationMethod.Ordinal, 13 },
                { CalculationMethod.Reduced, 4 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 41 },
                { CalculationMethod.Squared, 1600 },
                { CalculationMethod.MisparGadol, 40 },
                { CalculationMethod.MisparShemi, 80 },
            }
            },
            {
                'נ',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 50 },
                { CalculationMethod.Ordinal, 14 },
                { CalculationMethod.Reduced, 5 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 43 },
                { CalculationMethod.Squared, 2500 },
                { CalculationMethod.MisparGadol, 50 },
                { CalculationMethod.MisparShemi, 106 },
            }
            },
            {
                'ס',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 60 },
                { CalculationMethod.Ordinal, 15 },
                { CalculationMethod.Reduced, 6 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 47 },
                { CalculationMethod.Squared, 3600 },
                { CalculationMethod.MisparGadol, 60 },
                { CalculationMethod.MisparShemi, 120 },
            }
            },
            {
                'ע',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 70 },
                { CalculationMethod.Ordinal, 16 },
                { CalculationMethod.Reduced, 7 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 53 },
                { CalculationMethod.Squared, 4900 },
                { CalculationMethod.MisparGadol, 70 },
                { CalculationMethod.MisparShemi, 130 },
            }
            },
            {
                'פ',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 80 },
                { CalculationMethod.Ordinal, 17 },
                { CalculationMethod.Reduced, 8 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 59 },
                { CalculationMethod.Squared, 6400 },
                { CalculationMethod.MisparGadol, 80 },
                { CalculationMethod.MisparShemi, 81 },
            }
            },
            {
                'צ',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 90 },
                { CalculationMethod.Ordinal, 18 },
                { CalculationMethod.Reduced, 9 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 61 },
                { CalculationMethod.Squared, 8100 },
                { CalculationMethod.MisparGadol, 90 },
                { CalculationMethod.MisparShemi, 104 },
            }
            },
            {
                'ק',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 100 },
                { CalculationMethod.Ordinal, 19 },
                { CalculationMethod.Reduced, 1 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 67 },
                { CalculationMethod.Squared, 10000 },
                { CalculationMethod.MisparGadol, 100 },
                { CalculationMethod.MisparShemi, 186 },
            }
            },
            {
                'ר',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 200 },
                { CalculationMethod.Ordinal, 20 },
                { CalculationMethod.Reduced, 2 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 71 },
                { CalculationMethod.Squared, 40000 },
                { CalculationMethod.MisparGadol, 200 },
                { CalculationMethod.MisparShemi, 510 },
            }
            },
            {
                'ש',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 300 },
                { CalculationMethod.Ordinal, 21 },
                { CalculationMethod.Reduced, 3 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 73 },
                { CalculationMethod.Squared, 90000 },
                { CalculationMethod.MisparGadol, 300 },
                { CalculationMethod.MisparShemi, 350 },
            }
            },
            {
                'ת',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 400 },
                { CalculationMethod.Ordinal, 22 },
                { CalculationMethod.Reduced, 4 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 79 },
                { CalculationMethod.Squared, 160000 },
                { CalculationMethod.MisparGadol, 400 },
                { CalculationMethod.MisparShemi, 406 },
            }
            },
            {
                'ך',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 20 },
                { CalculationMethod.Ordinal, 23 },
                { CalculationMethod.Reduced, 2 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 83 },
                { CalculationMethod.Squared, 400 },
                { CalculationMethod.MisparGadol, 500 },
                { CalculationMethod.MisparShemi, 100 },
            }
            },
            {
                'ם',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 40 },
                { CalculationMethod.Ordinal, 24 },
                { CalculationMethod.Reduced, 4 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 89 },
                { CalculationMethod.Squared, 1600 },
                { CalculationMethod.MisparGadol, 600 },
                { CalculationMethod.MisparShemi, 80 },
            }
            },
            {
                'ן',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 50 },
                { CalculationMethod.Ordinal, 25 },
                { CalculationMethod.Reduced, 5 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 97 },
                { CalculationMethod.Squared, 2500 },
                { CalculationMethod.MisparGadol, 700 },
                { CalculationMethod.MisparShemi, 106 },
            }
            },
            {
                'ף',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 80 },
                { CalculationMethod.Ordinal, 26 },
                { CalculationMethod.Reduced, 8 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 101 },
                { CalculationMethod.Squared, 6400 },
                { CalculationMethod.MisparGadol, 800 },
                { CalculationMethod.MisparShemi, 81 },
            }
            },
            {
                'ץ',
                new Dictionary<CalculationMethod, int>() {
                { CalculationMethod.Gematria, 90 },
                { CalculationMethod.Ordinal, 27 },
                { CalculationMethod.Reduced, 9 },
                { CalculationMethod.Sumerian, 0 },
                { CalculationMethod.Primes, 103 },
                { CalculationMethod.Squared, 8100 },
                { CalculationMethod.MisparGadol, 900 },
                { CalculationMethod.MisparShemi, 104 },
            }
            },
            #endregion
        };
    }
}