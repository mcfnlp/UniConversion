using System;
//using System.Collections.Generic;
//using System.Text;
using System.Text.RegularExpressions;

namespace UniConversion
{
    class Myanmar1ToMyanmar3
    {
        public static string mm1ToUni(string input)
        {

            // copy inputted string to unistr
            String unistr = "";
            unistr = input.Substring(0);

            # region Replacements And Rearrangements According To Unicode 5.1

            unistr = Regex.Replace(unistr, "\u1039\u200C", "\u103A");   // Asat

            unistr = Regex.Replace(unistr, "\u104E", "\u104E\u1004\u103A\u1038");
            unistr = Regex.Replace(unistr, "\u101E\u1039\u101E", "\u103F");
            
            unistr = Regex.Replace(unistr, "\u1039\u101A", "\u103B");   // Medial Ya
            unistr = Regex.Replace(unistr, "\u1039\u101B", "\u103C");   // Medial Ra
            unistr = Regex.Replace(unistr, "\u1039\u101D", "\u103D");   // Medial Wa
            unistr = Regex.Replace(unistr, "\u1039\u101F", "\u103E");    // Medial Ha


            unistr = Regex.Replace(unistr, "\u1004\u1039", "\u1004\u103A\u1039");

            unistr = Regex.Replace(unistr, "(?<=(?<MC>[\u1001\u1002\u1004\u1012\u1013\u1015\u101D])(?<E>\u1031)?)(?<AA>\u102C)", "\u102B");

            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<scon>\u1039[က-အ])?(?<upper>[\u102D\u102E\u1032\u1036])?(?<DVs>[\u1037\u1038]){0,2}(?<M>[\u103B-\u103E]*)" +
                "(?<lower>[\u102F\u1030])?(?<upper>[\u102D\u102E\u1032])?", "${con}${scon}${M}${upper}${lower}${DVs}"); //reordering storage order
            
            #endregion
            
            unistr = UniConversion.correct.Correction1(unistr);

            return unistr;           
        }
    }
}