using System;
using System.Text.RegularExpressions;

namespace UniConversion
{
    class MMyanmar1ToMyanmar3
    {
        public static string Myanmar2Uni(string input)
        {

            string ascstr = input;

            //------------------------------------- Replacements And Rearrangements According To Unicode 5.1----------------------------------------//
            #region Declaration
            String tallAA = "ါ";
            String AA = "ာ";
            String vi = "ိ"; //lone gyi tin
            String ii = "ီ";
            String u = "ု";
            String uu = "ူ";
            String ve = "ေ";
            String ai = "ဲ";
            String ans = "ံ";
            String db = "့";
            String visarga = "း";
           // String virama = "္";
            String asat = "်";
            String ya = "ျ";
            String ra = "ြ";
            String wa = "ွ";
            String ha = "ှ";
            #endregion

            #region reordering kinzi in ascii side
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])F", "F${E}${R}${con}"); //reordering kinzi
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])Ø", "F${E}${R}${con}d"); //reordering kinzi lgt
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])Ð", "F${E}${R}${con}D"); //reordering kinzi lgtsk
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])ø", "F${E}${R}${con}H"); //reordering kinzi ttt 
            #endregion

            String unistr = null;
            unistr = ascstr;

            #region Consonants
            unistr = Regex.Replace(unistr, "u", "က");
            unistr = Regex.Replace(unistr, "c", "ခ");
            unistr = Regex.Replace(unistr, "\\*", "ဂ");
            unistr = Regex.Replace(unistr, "•", "ဃ");
            unistr = Regex.Replace(unistr, "i", "င");
            unistr = Regex.Replace(unistr, "p", "စ");
            unistr = Regex.Replace(unistr, "q", "ဆ");
            unistr = Regex.Replace(unistr, "Z", "ဇ");
            unistr = Regex.Replace(unistr, "ps", "ဈ");
            unistr = Regex.Replace(unistr, "—", "ဉ");
            unistr = Regex.Replace(unistr, "n", "ည");
            unistr = Regex.Replace(unistr, "™", "ဋ");
            unistr = Regex.Replace(unistr, "X", "ဌ");
            unistr = Regex.Replace(unistr, "¡", "ဍ");
            unistr = Regex.Replace(unistr, "˜", "ဎ");
            unistr = Regex.Replace(unistr, "\\+", "ဏ");
            unistr = Regex.Replace(unistr, "w", "တ");
            unistr = Regex.Replace(unistr, "x", "ထ");
            unistr = Regex.Replace(unistr, "'", "ဒ");  
            unistr = Regex.Replace(unistr, "\\\"", "ဓ");
            unistr = Regex.Replace(unistr, "[eE]", "န");
            unistr = Regex.Replace(unistr, "y", "ပ");
            unistr = Regex.Replace(unistr, "z", "ဖ");
            unistr = Regex.Replace(unistr, "A", "ဗ");
            unistr = Regex.Replace(unistr, "b", "ဘ");
            unistr = Regex.Replace(unistr, "r", "မ");
            unistr = Regex.Replace(unistr, ",", "ယ");
            unistr = Regex.Replace(unistr, "[&^]", "ရ");
            unistr = Regex.Replace(unistr, "v", "လ");
            //unistr = Regex.Replace(unistr, "0", "ဝ");//  no waa
            unistr = Regex.Replace(unistr, "o", "သ");
            unistr = Regex.Replace(unistr, "\\[", "ဟ");
            unistr = Regex.Replace(unistr, "–", "ဠ");
            unistr = Regex.Replace(unistr, "t", "အ");
            #endregion

            #region Medials
            unistr = Regex.Replace(unistr, "s", ya);                //ျ
            unistr = Regex.Replace(unistr, "\\`", ya + wa);    //ျွ
            unistr = Regex.Replace(unistr, "~", ya + ha);      //  ျှ

            unistr = Regex.Replace(unistr, "[\u002D\u006A]", "\u103C");       //ြ
            unistr = Regex.Replace(unistr, "G", wa);     //ွ
            unistr = Regex.Replace(unistr, "F", wa + ha);   //ွ ှ

            unistr = Regex.Replace(unistr, "[S|]", ha);  //ှ
            #endregion

            #region Medial ha + Dependent vowel u and uu
            unistr = Regex.Replace(unistr, "=", ha + u);    //ှု
            unistr = Regex.Replace(unistr, "Œ", ha + uu);   //ှူ
            #endregion

             #region kinzi
            unistr = Regex.Replace(unistr, "®", "င်္");
            unistr = Regex.Replace(unistr, "‡", "င်္");
            unistr = Regex.Replace(unistr, "‹", "င်္ိ");
            unistr = Regex.Replace(unistr, "ˆ", "င်္ီ");
            unistr = Regex.Replace(unistr, "Š", "ံင်္");

            #endregion

            #region Dependent Vowels
            unistr = Regex.Replace(unistr, "d", vi);
            unistr = Regex.Replace(unistr, "D", ii);
            unistr = Regex.Replace(unistr, "k", u);
            unistr = Regex.Replace(unistr, "K", u);
            unistr = Regex.Replace(unistr, "l", uu);
            unistr = Regex.Replace(unistr, "L", uu);
            unistr = Regex.Replace(unistr, "a", ve);
            unistr = Regex.Replace(unistr, "J", ai);
            unistr = Regex.Replace(unistr, "m", AA);
            unistr = Regex.Replace(unistr, "g", tallAA);  
            unistr = Regex.Replace(unistr, "\\:", tallAA + asat);
            unistr = Regex.Replace(unistr, "H", ans);
            unistr = Regex.Replace(unistr, "‰", vi + ans);
            #endregion

            #region Independent Vowels
            unistr = Regex.Replace(unistr, "†", "ဣ");
            unistr = Regex.Replace(unistr, "T", "ဤ");
            unistr = Regex.Replace(unistr, "O", "ဥ");
            unistr = Regex.Replace(unistr, "{", "ဧ");
            unistr = Regex.Replace(unistr, "jo", "ဩ");
            unistr = Regex.Replace(unistr, "-o", "ဩ");
            unistr = Regex.Replace(unistr, "ajomf", "ဪ");
            unistr = Regex.Replace(unistr, "a-omf", "ဪ");
            #endregion

            #region Tone Marks
            unistr = Regex.Replace(unistr, ";", visarga);
            unistr = Regex.Replace(unistr, "f", asat);
            unistr = Regex.Replace(unistr, "h", db);
            unistr = Regex.Replace(unistr, "\\\\", db);
            #endregion

            #region Various Signs
            unistr = Regex.Replace(unistr, "Y", "၌");
            unistr = Regex.Replace(unistr, "I", "၍");
            unistr = Regex.Replace(unistr, "›", "၎");
            unistr = Regex.Replace(unistr, "\\.", "၏");
            #endregion

            #region Consonant Letter Great SA
            unistr = Regex.Replace(unistr, "©", "ဿ");
            #endregion

            #region Stacked Consonants
            unistr = Regex.Replace(unistr, "\u0021", "ဏ္ဌ");
            unistr = Regex.Replace(unistr, "\u0023", "ဏ္ဏ");
            unistr = Regex.Replace(unistr, "\\$", "မ္ပ");    //if it hasn't use '\\' the  မ္ပ  will replace at the end of the line.
            unistr = Regex.Replace(unistr, "\u0025", "ဇ္ဇ");
            unistr = Regex.Replace(unistr, "\u003C", "ဒ္ဓ");
            unistr = Regex.Replace(unistr, "\u003E", "စ္ဆ");
            unistr = Regex.Replace(unistr, "\u0040", "ဏ္ဍ");
            unistr = Regex.Replace(unistr, "\u0042", "မ္ဘ");
            unistr = Regex.Replace(unistr, "\u0043", "ဂ္ဂ");
            unistr = Regex.Replace(unistr, "\u004D", "န္တ");
            unistr = Regex.Replace(unistr, "\u004E", "န္ဒ");
            unistr = Regex.Replace(unistr, "\u0050", "စ္စ");
            unistr = Regex.Replace(unistr, "\u0051", "က္ခ");
            unistr = Regex.Replace(unistr, "\u0052", "မ္မ");
            unistr = Regex.Replace(unistr, "\u0055", "က္က");
            unistr = Regex.Replace(unistr, "\u0056", "ဉ္စ");
            unistr = Regex.Replace(unistr, "\u0057", "တ္တ");
            unistr = Regex.Replace(unistr, "\u005D", "ဒ္ဒ");
            unistr = Regex.Replace(unistr, "\u005F", "ပ္ပ");
            unistr = Regex.Replace(unistr, "\u007D", "ဋ္ဌ");
            unistr = Regex.Replace(unistr, "\u201C", "ဋ္ဋ");
            unistr = Regex.Replace(unistr, "\u201D", "ဍ္ဍ");
            unistr = Regex.Replace(unistr, "\u0161", "တ္ထ");
            unistr = Regex.Replace(unistr, "\u0153", "လ္လ");
            unistr = Regex.Replace(unistr, "\u00A2", "ဉ္ဇ");
            unistr = Regex.Replace(unistr, "\u00A3", "ပ္ဖ");
            unistr = Regex.Replace(unistr, "\u00A4", "ဗ္ဗ");
            unistr = Regex.Replace(unistr, "\u00A5", "ဂ္ဃ");
            unistr = Regex.Replace(unistr, "\u00A6", "ဟ္မ");
            unistr = Regex.Replace(unistr, "\u00A8", "မ္ဖ");
            unistr = Regex.Replace(unistr, "\u00AA", "န္ထ");
            unistr = Regex.Replace(unistr, "\u00AB", "ဇ္ဈ");
            unistr = Regex.Replace(unistr, "\u00B3", "န္န");
            unistr = Regex.Replace(unistr, "\u00B4", "ဍ္ဎ");
            unistr = Regex.Replace(unistr, "\u00B5", "ဉ္ဈ");
            unistr = Regex.Replace(unistr, "\u00C5", "ဉ္ဆ");
            unistr = Regex.Replace(unistr, "\u00C4", "ဏ္ဋ");
            unistr = Regex.Replace(unistr, "\u00C3", "န္တွ");
            unistr = Regex.Replace(unistr, "\u00BA", "မ္ဗ");
            unistr = Regex.Replace(unistr, "\u00B8", "ဗ္ဘ");
            unistr = Regex.Replace(unistr, "\u00B6", "န္ဓ");
            unistr = Regex.Replace(unistr, "\u00C6", "သ္မ");
         
            #endregion

           //unistr = Regex.Replace(unistr, "", 'ဉ' + AA);  //no

            #region Panctuations
            unistr = Regex.Replace(unistr, "\\?", "။");
            unistr = Regex.Replace(unistr, "\\/", "၊");
            #endregion

            #region digits
            unistr = Regex.Replace(unistr, "1", "၁");
            unistr = Regex.Replace(unistr, "2", "၂");
            unistr = Regex.Replace(unistr, "3", "၃");
            unistr = Regex.Replace(unistr, "4", "၄");
            unistr = Regex.Replace(unistr, "5", "၅");
            unistr = Regex.Replace(unistr, "6", "၆");
            unistr = Regex.Replace(unistr, "7", "၇");
            unistr = Regex.Replace(unistr, "8", "၈");
            unistr = Regex.Replace(unistr, "9", "၉");
            unistr = Regex.Replace(unistr, "0", "ဝ");
            #endregion
            

            #region General
            unistr = Regex.Replace(unistr, "[\u00B7\u201E\u2219]", "-");
            unistr = Regex.Replace(unistr, "[\u00B2\u00DA]", "/");
            unistr = Regex.Replace(unistr, "\u00B1", "\\.");
            unistr = Regex.Replace(unistr, "\u00A7", "+");
            unistr = Regex.Replace(unistr, "[\u00C8\u00D8]", "{");
            unistr = Regex.Replace(unistr, "[\u00C9\u00D9]", "}");
            unistr = Regex.Replace(unistr, "\u00D3", "=");
            unistr = Regex.Replace(unistr, "\u00D4", "[");
             unistr = Regex.Replace(unistr, "\u00D5", "]");
             unistr = Regex.Replace(unistr, "\u00D6", "*");
             unistr = Regex.Replace(unistr, "\u00D7", "+");
             unistr = Regex.Replace(unistr, "\u2018", "‘");
             unistr = Regex.Replace(unistr, "\u2019", "’");
            #endregion

            #region Reordering Ra
            unistr = Regex.Replace(unistr, "(?<R>\u103C)(?<Wa>\u103D)?(?<Ha>\u103E)?(?<U>\u102F)?(?<con>[က-အ])(?<scon>\u1039[က-အ])?", "${con}${scon}${R}${Wa}${Ha}${U}"); //reordering ra          
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1040)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F]))", "\u101D");//zero and wa
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1047)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))", "\u101B");//seven and ra
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<con>[က-အ])(?<scon>\u1039[က-အ])?(?<upper>[\u102D\u102E\u1032\u1036])?(?<DVs>[\u1037\u1038]){0,2}(?<M>[\u103B-\u103E]*)(?<lower>[\u102F\u1030])?(?<upper>[\u102D\u102E\u1032])?", "${con}${scon}${M}${E}${upper}${lower}${DVs}"); //reordering storage order
            #endregion

            unistr = UniConversion.correct.Correction1(unistr);
            return unistr;
        }
    }
}
