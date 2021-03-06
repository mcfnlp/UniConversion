using System;
//using System.Collections.Generic;
//using System.Text;
using System.Text.RegularExpressions;

namespace UniConversion
{
    class AvaToMyanmar3
    {
        public static string Ava2Uni(string input)
        {
            // copy inputted string to unistr
            String unistr = "";
            unistr = input.Substring(0);

            #region Kinzi

            unistr = Regex.Replace(unistr, "ç", "င်္");
            unistr = Regex.Replace(unistr, "C", "င်္ံ");
            unistr = Regex.Replace(unistr, "Ç", "င်္ီ");

            #endregion

            #region Consonants 

            unistr = Regex.Replace(unistr, "k", "က");
            unistr = Regex.Replace(unistr, "K", "ခ");
            unistr = Regex.Replace(unistr, "g", "ဂ");
            unistr = Regex.Replace(unistr, "G", "ဃ");
            unistr = Regex.Replace(unistr, "c", "င");
            unistr = Regex.Replace(unistr, "s", "စ");
            unistr = Regex.Replace(unistr, "S", "ဆ");
            unistr = Regex.Replace(unistr, "z", "ဇ");
            unistr = Regex.Replace(unistr, "Z", "ဈ");
            unistr = Regex.Replace(unistr, "[Uˆ◊š]", "ဉ");
            unistr = Regex.Replace(unistr, "[vVŽ]", "ည");
            unistr = Regex.Replace(unistr, "[!ġ]", "ဋ");
            unistr = Regex.Replace(unistr, "@", "ဌ");
            unistr = Regex.Replace(unistr, "£", "ဍ");
            unistr = Regex.Replace(unistr, "'$'", "ဎ");
            unistr = Regex.Replace(unistr, "%", "ဏ");
            unistr = Regex.Replace(unistr, "t", "တ");
            unistr = Regex.Replace(unistr, "T", "ထ");
            unistr = Regex.Replace(unistr, "d", "ဒ");
            unistr = Regex.Replace(unistr, "D", "ဓ");
            unistr = Regex.Replace(unistr, "[nN]", "န");
            unistr = Regex.Replace(unistr, "p", "ပ");
            unistr = Regex.Replace(unistr, "P", "ဖ");
            unistr = Regex.Replace(unistr, "b", "ဗ");
            unistr = Regex.Replace(unistr, "B", "ဘ");
            unistr = Regex.Replace(unistr, "m", "မ");
            unistr = Regex.Replace(unistr, "y", "ယ");
            unistr = Regex.Replace(unistr, "[rR]", "ရ");
            unistr = Regex.Replace(unistr, "l", "လ");
            unistr = Regex.Replace(unistr, "w", "ဝ");
            unistr = Regex.Replace(unistr, "q", "သ");
            unistr = Regex.Replace(unistr, "h", "ဟ");
            unistr = Regex.Replace(unistr, "L", "ဠ");

            #endregion

            #region Stacked  Consonants
            unistr = Regex.Replace(unistr, "[˚½]", "\u1039" + 'က');
            unistr = Regex.Replace(unistr, "[\uF8FFŠ]", "\u1039" + 'ခ');
            unistr = Regex.Replace(unistr, "©", "\u1039" + 'ဂ');
            unistr = Regex.Replace(unistr, "Ì", "\u1039" + 'ဃ');
            unistr = Regex.Replace(unistr, "ß", "\u1039" + 'စ');
            unistr = Regex.Replace(unistr, "Í", "\u1039" + 'ဆ');
            unistr = Regex.Replace(unistr, "ý", "\u1039" + 'ဇ');
            unistr = Regex.Replace(unistr, "Û", "\u1039" + 'ဈ');
            unistr = Regex.Replace(unistr, "†", "\u1039" + 'တ');
            unistr = Regex.Replace(unistr, "Ê", "\u1039" + 'ထ');
            unistr = Regex.Replace(unistr, "[∂ð]", "\u1039" + 'ဒ');
            unistr = Regex.Replace(unistr, "Î", "\u1039" + 'ဓ');
            unistr = Regex.Replace(unistr, "~", "\u1039" + 'န');
            unistr = Regex.Replace(unistr, "[πþ]", "\u1039" + 'ပ');
            unistr = Regex.Replace(unistr, "∏", "\u1039" + 'ဖ');
            unistr = Regex.Replace(unistr, "[∫¾]", "\u1039" + 'ဗ');
            unistr = Regex.Replace(unistr, "[\u008F\u0131]", "\u1039" + 'ဘ');
            unistr = Regex.Replace(unistr, "µ", "\u1039" + 'မ');
            unistr = Regex.Replace(unistr, "¬", "\u1039" + 'လ');
             
            #endregion

            # region Medials
            unistr = Regex.Replace(unistr, "¥", "ျ"); // ya
            unistr = Regex.Replace(unistr, "Á", "ျွ"); // ya + wa
            unistr = Regex.Replace(unistr, "Y", "ျှ"); // ya + ha
            unistr = Regex.Replace(unistr, "„", "ျွှ"); // ya + wa + ha

            unistr = Regex.Replace(unistr, "[®Â“”]", "ြ"); // ra
            unistr = Regex.Replace(unistr, "[\u2018\u2019]", "ြု"); // ra + vowel u

            unistr = Regex.Replace(unistr, "[∑Ý]", "ွ"); // wa            
            unistr = Regex.Replace(unistr, "W", "ွှ"); // wa + ha

            unistr = Regex.Replace(unistr, "[˙¹H]", "ှ"); // ha
            unistr = Regex.Replace(unistr, "O", "ှု");// ha + ta chaung yin
            unistr = Regex.Replace(unistr, "Ø", "ှူ");// ha + na chaung yin
            
            #endregion

            # region  Independent Vowels
            unistr = Regex.Replace(unistr, "A", "အ");
            unistr = Regex.Replace(unistr, "I", "ဣ"); // I
            unistr = Regex.Replace(unistr, "È", "ဤ"); // II
            unistr = Regex.Replace(unistr, "[U√ˆ◊š]", "ဥ"); // U
            unistr = Regex.Replace(unistr, "Ë", "္ဦ"); // UU
            unistr = Regex.Replace(unistr, "[U√◊]+'^'", "္ဦ"); // UU
            unistr = Regex.Replace(unistr, "[U√šˆ◊]+'\\005C'", "ဉ်");
            unistr = Regex.Replace(unistr, "E", "ဧ"); // E
            unistr = Regex.Replace(unistr, "Âq", "ဩ"); // ASCII letters combined, O
            unistr = Regex.Replace(unistr, "eÂqa", "ဪ"); // ASCII letters combined, AU
            
            #endregion

            # region Dependent Vowels
            
            unistr = Regex.Replace(unistr, "å", "ါ"); // Tall AA
            unistr = Regex.Replace(unistr, "Å", "ါ်"); // Tall AA + asat
            unistr = Regex.Replace(unistr, "a", "ာ"); // AA
            unistr = Regex.Replace(unistr, "i", "ိ"); // I
            unistr = Regex.Replace(unistr, "\\^", "ီ"); // II
            unistr = Regex.Replace(unistr, "[uo]", "ု"); // U
            unistr = Regex.Replace(unistr, "[ø¨]", "ူ"); // UU

            unistr = Regex.Replace(unistr, "e", "ေ"); // E
            unistr = Regex.Replace(unistr, "´", "ဲ"); // AI
            unistr = Regex.Replace(unistr, "M", "ံ"); // ANUSVARA
            unistr = Regex.Replace(unistr, "˜", "ိံ");

            # endregion

            # region Asat

            unistr = Regex.Replace(unistr, "\\u005C", "်");

            # endregion

            # region Tone Marks

            unistr = Regex.Replace(unistr, "[≥ž>.]", "့"); // Aukmyit
            unistr = Regex.Replace(unistr, "[\u003A\u003B]", "း");//Visarga

            # endregion

            # region Digits
            
            unistr = Regex.Replace(unistr, "0", "၀");
            unistr = Regex.Replace(unistr, "1", "၁");
            unistr = Regex.Replace(unistr, "2", "၂");
            unistr = Regex.Replace(unistr, "3", "၃");
            unistr = Regex.Replace(unistr, "4", "၄");
            unistr = Regex.Replace(unistr, "5", "၅");
            unistr = Regex.Replace(unistr, "6", "၆");
            unistr = Regex.Replace(unistr, "7", "၇");
            unistr = Regex.Replace(unistr, "8", "၈");
            unistr = Regex.Replace(unistr, "9", "၉");

            # endregion

            # region Punctuation

            unistr = Regex.Replace(unistr, "\u0027", "၊");
            unistr = Regex.Replace(unistr, "\u0022", "။");
            
            # endregion

            # region Various Signs

            unistr = Regex.Replace(unistr, "Ò", "၌");
            unistr = Regex.Replace(unistr, "j", "၍");
            unistr = Regex.Replace(unistr, "&", "၎");
            unistr = Regex.Replace(unistr, "f", "၏");

            # endregion

            # region Consonant Letter Great SA

            unistr = Regex.Replace(unistr, "œ", "ဿ");

            # endregion

            # region combine characters

            unistr = Regex.Replace(unistr, "‹", "ဏ္ဍ");
            unistr = Regex.Replace(unistr, "›", "ဏ္ဎ");
            unistr = Regex.Replace(unistr, "#", "ဍ္ဍ");
            unistr = Regex.Replace(unistr, "¢", "ဍ္ဎ");
            unistr = Regex.Replace(unistr, "¤", "ဏ္ဌ");
            unistr = Regex.Replace(unistr, "[ﬁ∞]", "ဏ္ဏ");
            unistr = Regex.Replace(unistr, "⁄", "ဏ္ဋ");
            unistr = Regex.Replace(unistr, "™", "ဋ္ဌ");
            unistr = Regex.Replace(unistr, "¡", "ဋ္ဋ");

            # endregion

            # region General

            unistr = Regex.Replace(unistr, "{", "“");
            unistr = Regex.Replace(unistr, "}", "”");
            unistr = Regex.Replace(unistr, "¼", "\u0020");
            unistr = Regex.Replace(unistr, "\u00AF", "\u2018");
            unistr = Regex.Replace(unistr, "\u02D8", "\u2019");

            # endregion

            # region reordering process

            unistr = Regex.Replace(unistr, "(?<R>\u103C)(?<Wa>\u103D)?(?<Ha>\u103E)?(?<U>\u102F)?(?<con>[က-အ])(?<scon>\u1039[က-အ])?", "${con}${scon}${R}${Wa}${Ha}${U}"); //reordering ra
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1040)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F]))", "\u101D");//zero and wa
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<con>[က-အ])?(?<scon>\u1039[က-အ])?(?<upper>[\u102D\u102E\u1032\u1036])?(?<DVs>[\u1037\u1038]){0,2}(?<M>[\u103B-\u103E]*)(?<lower>[\u102F\u1030])?(?<upper>[\u102D\u102E\u1032])?", "${con}${scon}${M}${E}${upper}${lower}${DVs}"); //reordering storage order
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<middle>[\u103B\u103C\u1031]){0,1}(?<kinzi>\u1004\u103A\u1039){1}", "${kinzi}${con}${middle}");//kinzi
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<Medial>[\u103B\u103C\u103D\u103E]){0,1}(?<anusvara>\u1036)(?<vowelU>[\u102F])", "${con}${Medial}${vowelU}${anusvara}");//taytaytin and ta chaung yin    
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<tone>[\u1037\u1038]){0,1}(?<asat>\u103A)", "${con}${asat}${tone}");//asat and tone
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<uvowel>[\u102F\u102E\u1032]){0,1}(?<lvowel>[\u102D\u1030]){0,1}", "${con}${lvowel}${uvowel}");// upper vowel and lower vowel
            unistr = Regex.Replace(unistr, "(?<ivU>ဥ)(?<vowelII>ီ)", "\u1026"); // u and nyakalay                
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<middle>[\u1031\u102D]){0,1}(?<space>[\u0020\u00A0])?(?<space>[\u0020\u00A0])?(?<scon>\u1039[က-အ])?", "${con}${scon}${middle}"); // space with stack consonant
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<middle>[\u102F\u1030\u103D])?(?<upper>\u1032)?(?<space>[\u0020\u00A0])?(?<aukmyit>\u1037)", "${con}${middle}${upper}${aukmyit}");
            unistr = Regex.Replace(unistr, "(?<Nya>ဉ)(?<con>[က-အဿ])", "\u1025${con}");
            unistr = Regex.Replace(unistr, "(?<Nya>ဉ)(?<II>[ီ])", "\u1026"); //U
            unistr = Regex.Replace(unistr, "(?<stacker>\u1039)(?<uu>\u1026){1}", "\u1026"); //U

            #endregion

            unistr = UniConversion.correct.Correction1(unistr);
            return unistr;
            
        } // end of Ava2Uni()
    }
}
