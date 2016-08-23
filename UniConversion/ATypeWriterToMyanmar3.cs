using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UniConversion
{
    class ATypeWriterToMyanmar3
    {
        public static string AType2Uni(string input)
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
            String virama = "္";
            String asat = "်";
            String ya = "ျ";
            String ra = "ြ";
            String wa = "ွ";
            String ha = "ှ";
            #endregion

            #region Medial ra and wa+Dependent Vowel u
            ascstr = Regex.Replace(ascstr, "[jMNB`~]", "j");//(ra) ြ
            ascstr = Regex.Replace(ascstr, "[<>]", "jG");//ra wa ြွ
            ascstr = Regex.Replace(ascstr, "[êû]", "jk");//ra u ြု
            #endregion

            #region reordering kinzi in ascii side
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])F", "F${E}${R}${con}"); //reordering kinzi
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])Ø", "F${E}${R}${con}d"); //reordering kinzi lgt
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])Ð", "F${E}${R}${con}D"); //reordering kinzi lgtsk
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])ø", "F${E}${R}${con}H"); //reordering kinzi ttt 
            ascstr = Regex.Replace(ascstr, "(?<con>[က-အ])(?<middle>[\u103B\u103C\u1031]){0,1}(?<kinzi>\u1004\u103A\u1039){1}", "${kinzi}${con}${middle}");// reording kinzi 
            #endregion

            String unistr = null;
            unistr = ascstr;

            #region Consonants
            unistr = Regex.Replace(unistr, "u", "က");
            unistr = Regex.Replace(unistr, "c", "ခ");
            unistr = Regex.Replace(unistr, "\\*", "ဂ");
            unistr = Regex.Replace(unistr, "C", "ဃ");
            unistr = Regex.Replace(unistr, "i", "င");
            unistr = Regex.Replace(unistr, "p", "စ");
            unistr = Regex.Replace(unistr, "q", "ဆ");
            unistr = Regex.Replace(unistr, "Z", "ဇ");
            unistr = Regex.Replace(unistr, "ps", "ဈ");
            unistr = Regex.Replace(unistr, "Ú", "ဉ");
            unistr = Regex.Replace(unistr, "ñ", "ည");
            unistr = Regex.Replace(unistr, "n", "ည");
            unistr = Regex.Replace(unistr, "\\#", "ဋ");
            unistr = Regex.Replace(unistr, "X", "ဌ");
            unistr = Regex.Replace(unistr, "\\!", "ဍ");
            unistr = Regex.Replace(unistr, "¡", "ဎ");
            unistr = Regex.Replace(unistr, "P", "ဏ");
            unistr = Regex.Replace(unistr, "w", "တ");
            unistr = Regex.Replace(unistr, "x", "ထ");
            unistr = Regex.Replace(unistr, "\\'", "ဒ");
            unistr = Regex.Replace(unistr, "\\\"", "ဓ");
            unistr = Regex.Replace(unistr, "[eE]", "န");
            unistr = Regex.Replace(unistr, "y", "ပ");
            unistr = Regex.Replace(unistr, "z", "ဖ");
            unistr = Regex.Replace(unistr, "A", "ဗ");
            unistr = Regex.Replace(unistr, "b", "ဘ");
            unistr = Regex.Replace(unistr, "r", "မ");
            unistr = Regex.Replace(unistr, ",", "ယ");
            unistr = Regex.Replace(unistr, "[&½]", "ရ");
            unistr = Regex.Replace(unistr, "v", "လ");
            unistr = Regex.Replace(unistr, "0", "ဝ");
            unistr = Regex.Replace(unistr, "o", "သ");
            unistr = Regex.Replace(unistr, "\\[", "ဟ");
            unistr = Regex.Replace(unistr, "V", "ဠ");
            unistr = Regex.Replace(unistr, "t", "အ");
            #endregion

            #region Medials
            unistr = Regex.Replace(unistr, "[sß]", ya);
            unistr = Regex.Replace(unistr, "R", ya + wa);
            unistr = Regex.Replace(unistr, "Q", ya + ha);
            unistr = Regex.Replace(unistr, "W", ya + wa + ha);

            unistr = Regex.Replace(unistr, "j", ra);

            unistr = Regex.Replace(unistr, "G", wa);
            unistr = Regex.Replace(unistr, "T", wa + ha);

            unistr = Regex.Replace(unistr, "[S§]", ha);
            #endregion

            #region Medial ha + Dependent vowel u and uu
            unistr = Regex.Replace(unistr, "I", ha + u);
            unistr = Regex.Replace(unistr, "ª", ha + uu);
            #endregion

            #region kinzi
            unistr = Regex.Replace(unistr, "F", "င်္");
            #endregion

            #region Dependent Vowels
            unistr = Regex.Replace(unistr, "d", vi);
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
            unistr = Regex.Replace(unistr, "ð", vi + ans);
            #endregion

            #region Independent Vowels
            unistr = Regex.Replace(unistr, "£", "ဣ");
            unistr = Regex.Replace(unistr, "þ", "ဤ");
            unistr = Regex.Replace(unistr, "[ÍO]", "ဥ");
            unistr = Regex.Replace(unistr, "{", "ဧ");
            #endregion

            #region Tone Marks
            unistr = Regex.Replace(unistr, ";", visarga);
            unistr = Regex.Replace(unistr, "f", asat);
            unistr = Regex.Replace(unistr, "[UYh]", db);
            #endregion

            #region Various Signs
            unistr = Regex.Replace(unistr, "ü", "၌");
            unistr = Regex.Replace(unistr, "í", "၍");
            unistr = Regex.Replace(unistr, "¤", "၎");
            unistr = Regex.Replace(unistr, "\\\\", "၏");
            #endregion

            #region Consonant Letter Great SA
            unistr = Regex.Replace(unistr, "ó", "ဿ");
            #endregion

            #region Stacked Consonants
            unistr = Regex.Replace(unistr, "@", 'ဏ' + virama + 'ဍ');
            unistr = Regex.Replace(unistr, "\\|", 'ဋ' + virama + 'ဌ');
            unistr = Regex.Replace(unistr, "\\’", virama + 'လ');
            unistr = Regex.Replace(unistr, "¢", virama + 'ဃ');
            unistr = Regex.Replace(unistr, "¥", 'ဋ' + virama + 'ဋ');
            unistr = Regex.Replace(unistr, "¦", virama + 'ထ');
            unistr = Regex.Replace(unistr, "¨", virama + 'ဓ');
            unistr = Regex.Replace(unistr, "©", virama + 'ခ');
            unistr = Regex.Replace(unistr, "¬", virama + 'ထ');
            unistr = Regex.Replace(unistr, "®", virama + 'မ');
            unistr = Regex.Replace(unistr, "²", virama + 'ဌ');
            unistr = Regex.Replace(unistr, "³", virama + 'ဋ');
            unistr = Regex.Replace(unistr, "´", virama + 'ဒ');
            unistr = Regex.Replace(unistr, "¹", 'ဎ' + virama + 'ဍ');
            unistr = Regex.Replace(unistr, "¾", virama + 'ဂ');
            unistr = Regex.Replace(unistr, "Á", virama + 'ဗ');
            unistr = Regex.Replace(unistr, "Å", virama + 'တ');
            unistr = Regex.Replace(unistr, "Ç", virama + 'ဘ');
            unistr = Regex.Replace(unistr, "Ö", virama + 'ဏ');
            unistr = Regex.Replace(unistr, "×", 'ဍ' + virama + 'ဍ');
            unistr = Regex.Replace(unistr, "Ü", virama + 'ပ');
            unistr = Regex.Replace(unistr, "ä", virama + 'ဆ');
            unistr = Regex.Replace(unistr, "Æ", virama + 'ဇ');
            unistr = Regex.Replace(unistr, "å", virama + 'တ');
            unistr = Regex.Replace(unistr, "æ", virama + 'ဖ');
            unistr = Regex.Replace(unistr, "é", virama + 'န');
            unistr = Regex.Replace(unistr, "ö", virama + 'စ');
            unistr = Regex.Replace(unistr, "ú", virama + 'က');
            unistr = Regex.Replace(unistr, "Ñ", virama + 'ဈ');
            #endregion

            unistr = Regex.Replace(unistr, "Ó", 'ဉ' + AA);

            #region Panctuations
            unistr = Regex.Replace(unistr, "\\?", "၊");
            unistr = Regex.Replace(unistr, "\\/", "။");
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

            #region fractions
            unistr = Regex.Replace(unistr, "ƒ", "၁/၂");
            unistr = Regex.Replace(unistr, "„", "၁/၃");
            unistr = Regex.Replace(unistr, "…", "၂/၃");
            unistr = Regex.Replace(unistr, "†", "၁/၄");
            unistr = Regex.Replace(unistr, "‡", "၃/၄");
            unistr = Regex.Replace(unistr, "ˆ", "၁/၅");
            unistr = Regex.Replace(unistr, "‰", "၂/၅");
            unistr = Regex.Replace(unistr, "Š", "၃/၅");
            unistr = Regex.Replace(unistr, "‹", "၄/၅");
            #endregion

            #region General
            unistr = Regex.Replace(unistr, "\\^", "/");
            unistr = Regex.Replace(unistr, "\\]", "'");
            unistr = Regex.Replace(unistr, "\\}", "'");
            unistr = Regex.Replace(unistr, "ç", "\u002C");

            unistr = Regex.Replace(unistr, "_", "*");
            unistr = Regex.Replace(unistr, "\\$", "ကျပ်");
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
