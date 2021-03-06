using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UniConversion
{
    class CEtoMyanmar3
    {
        public static string CE2Uni(string input)
        {
            // copy inputted string to unistr
            String unistr = "";
            unistr = input.Substring(0);

          //  #region call

          //  System.Data.DataSet ds = new System.Data.DataSet();
          //  //String st=System.IO.Directory.GetCurrentDirectory() + "\\CEtoMyanmar3.xml";
          //  //ds.ReadXml(@"C:\Documents and Settings\ag\Desktop\JustWork\UnicodeConverter\addPinny(Unicode Converter)LastReleased\UniConversion\UniConversion\bin\Debug\CEtoMyanmar3.xml");
          //// ds.ReadXml(@st);
          //  string dir = System.IO.Directory.GetCurrentDirectory() + "\\CEtoMyanmar3.xml";
          //  ds.ReadXml(dir);
          //  System.Data.DataRowCollection drc = ds.Tables["fontTable"].Rows;
          //  foreach (System.Data.DataRow dr in drc)
          //  {
          //      if (unistr.Contains(dr[0].ToString()))
          //      {
          //          unistr = unistr.Replace(dr[0].ToString(), dr[1].ToString());
          //      }
          //  }
          //  #endregion call
            #region Kinzi

            unistr = Regex.Replace(unistr, "F", "င်္");
            unistr = Regex.Replace(unistr, "Ù", "င်္ံ");
            unistr = Regex.Replace(unistr, "ô", "င်္ီ");
            unistr = Regex.Replace(unistr, "Ì", "င်္ိ");

            #endregion

            #region Consonants

            unistr = Regex.Replace(unistr, "u", "က");//KA
            unistr = Regex.Replace(unistr, "c", "ခ");//KHA
            unistr = Regex.Replace(unistr, "\\*", "ဂ");//GA
            unistr = Regex.Replace(unistr, "C", "ဃ");//GHA
            unistr = Regex.Replace(unistr, "i", "င");//NGA
            unistr = Regex.Replace(unistr, "p", "စ");//CA
            unistr = Regex.Replace(unistr, "q", "ဆ");//CHA
            unistr = Regex.Replace(unistr, "Z", "ဇ");//JA
            unistr = Regex.Replace(unistr, "ps", "ဈ");//JHA
            unistr = Regex.Replace(unistr, "Ü", "ဈ");//JHA
            unistr = Regex.Replace(unistr, "]", "ဉ");//NYA
            unistr = Regex.Replace(unistr, "[n!]", "ည");//NNYA
            unistr = Regex.Replace(unistr, "[ùã]", "ဋ");//TTA
            unistr = Regex.Replace(unistr, "X", "ဌ");//TTHA
            unistr = Regex.Replace(unistr, "ä", "ဍ");//DDA
            unistr = Regex.Replace(unistr, "å", "ဎ");//DDHA
            unistr = Regex.Replace(unistr, "%", "ဏ");//NNA
            unistr = Regex.Replace(unistr, "w", "တ");//TA
            unistr = Regex.Replace(unistr, "x", "ထ");//THA
            unistr = Regex.Replace(unistr, "'", "ဒ");//DA
            unistr = Regex.Replace(unistr, "\"", "ဓ");//DHA
            unistr = Regex.Replace(unistr, "[eE]", "န");//NA
            unistr = Regex.Replace(unistr, "y", "ပ");//PA
            unistr = Regex.Replace(unistr, "z", "ဖ");//PHA
            unistr = Regex.Replace(unistr, "A", "ဗ");//BA
            unistr = Regex.Replace(unistr, "b", "ဘ");//NHA
            unistr = Regex.Replace(unistr, "r", "မ");//MA
            unistr = Regex.Replace(unistr, ",", "ယ");//YA
            unistr = Regex.Replace(unistr, "[&@]", "ရ");//RA
            unistr = Regex.Replace(unistr, "v", "လ");//LA
            unistr = Regex.Replace(unistr, "0", "ဝ");//WA
            unistr = Regex.Replace(unistr, "o", "သ");//SA
            unistr = Regex.Replace(unistr, "[[]", "ဟ");//HA
            unistr = Regex.Replace(unistr, "[Væî]", "ဠ");//LLA

            #endregion

            #region Stacked  Consonants
            unistr = Regex.Replace(unistr, "U", "\u1039" + 'က');
            unistr = Regex.Replace(unistr, "Q", "\u1039" + 'ခ');
            unistr = Regex.Replace(unistr, "~", "\u1039" + 'ဂ');
            unistr = Regex.Replace(unistr, "ï", "\u1039" + 'ဃ');
            unistr = Regex.Replace(unistr, "P", "\u1039" + 'စ');
            unistr = Regex.Replace(unistr, ">", "\u1039" + 'ဆ');
            unistr = Regex.Replace(unistr, "ò", "\u1039" + 'ဇ');
            unistr = Regex.Replace(unistr, "W", "\u1039" + 'တ');
            unistr = Regex.Replace(unistr, "Ô", "\u1039" + 'ထ');
            unistr = Regex.Replace(unistr, "Û", "\u1039" + 'လ');
            unistr = Regex.Replace(unistr, "N", "\u1039" + 'ဒ');
            unistr = Regex.Replace(unistr, "<", "\u1039" + 'ဓ');
            unistr = Regex.Replace(unistr, "M", "\u1039" + 'န');
            unistr = Regex.Replace(unistr, "`", "\u1039" + 'ပ');
            unistr = Regex.Replace(unistr, "ÿ", "\u1039" + 'ဖ');
            unistr = Regex.Replace(unistr, "ý", "\u1039" + 'ဗ');
            unistr = Regex.Replace(unistr, "B", "\u1039" + 'ဘ');
            unistr = Regex.Replace(unistr, "R", "\u1039" + 'မ');
            #endregion

            # region Medials

            unistr = Regex.Replace(unistr, "s", "ျ"); // ya
            unistr = Regex.Replace(unistr, "Á", "ျွ"); // ya + wa
            unistr = Regex.Replace(unistr, "#", "ျှ"); // ya + ha
            unistr = Regex.Replace(unistr, "„", "ျွှ"); // ya + wa + ha

            unistr = Regex.Replace(unistr, "[_^j}]", "ြ"); // ra
            unistr = Regex.Replace(unistr, "[ÓÒ]", "ြု"); // ra + vowel u
            unistr = Regex.Replace(unistr, "[ÎÏ]", "ြွ"); // ra + wa
            unistr = Regex.Replace(unistr, "Õ", "ြှ"); // ra + ha


            unistr = Regex.Replace(unistr, "G", "ွ"); // wa            
            unistr = Regex.Replace(unistr, "\\$", "ွ" + "ှ"); // wa + ha

            unistr = Regex.Replace(unistr, "S", "ှ"); // ha
            unistr = Regex.Replace(unistr, "\\+", "ှု");// ha + ta chaung yin
            unistr = Regex.Replace(unistr, "ö", "ှူ");// ha + na chaung yin
            unistr = Regex.Replace(unistr, "ü", "ှ့");
            #endregion

            # region  Independent Vowels
            unistr = Regex.Replace(unistr, "t", "အ");
            unistr = Regex.Replace(unistr, "Ä", "ဣ"); // I
            unistr = Regex.Replace(unistr, "T", "ဤ"); // II
            unistr = Regex.Replace(unistr, "O", "ဥ"); // U
            unistr = Regex.Replace(unistr, "ë", "ဦ"); // UU
            unistr = Regex.Replace(unistr, "OD", "ဦ"); // UU
            unistr = Regex.Replace(unistr, "Of", "ဉ်");
            unistr = Regex.Replace(unistr, "]f", "ဉ်");
            unistr = Regex.Replace(unistr, "E", "ဧ"); // E
            unistr = Regex.Replace(unistr, "Í", "ဩ"); // ASCII letters combined, O
            unistr = Regex.Replace(unistr, "jo", "ဩ");
            unistr = Regex.Replace(unistr, "aÍmf", "ဪ"); // ASCII letters combined, AU
            unistr = Regex.Replace(unistr, "ajomf", "ဪ");
            #endregion

            # region Dependent Vowels

            unistr = Regex.Replace(unistr, "g", "ါ"); // Tall AA
            unistr = Regex.Replace(unistr, "Å", "ါ်"); // Tall AA + asat
            unistr = Regex.Replace(unistr, "m", "ာ"); // AA
            unistr = Regex.Replace(unistr, "d", "ိ"); // I
            unistr = Regex.Replace(unistr, "D", "ီ"); // II
            unistr = Regex.Replace(unistr, "[kK]", "ု"); // U
            unistr = Regex.Replace(unistr, "[lL]", "ူ"); // UU

            unistr = Regex.Replace(unistr, "a", "ေ"); // E
            unistr = Regex.Replace(unistr, "J", "ဲ"); // AI
            unistr = Regex.Replace(unistr, "H", "ံ"); // ANUSVARA
            unistr = Regex.Replace(unistr, "þ", "ိံ");

            # endregion

            # region Asat

            unistr = Regex.Replace(unistr, "f", "်");

            # endregion

            # region Tone Marks

            unistr = Regex.Replace(unistr, "h", "့"); // Aukmyit
            unistr = Regex.Replace(unistr, "Ú", "ဲ့"); 
            unistr = Regex.Replace(unistr, ";", "း");//Visarga

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

            unistr = Regex.Replace(unistr, "\\/", "၊");
            unistr = Regex.Replace(unistr, "\\?", "။");

            # endregion

            # region Various Signs

            unistr = Regex.Replace(unistr, "Y", "၌");
            unistr = Regex.Replace(unistr, "I", "၍");
            unistr = Regex.Replace(unistr, "Ö", "၎");
            unistr = Regex.Replace(unistr, "\\.", "၏");

            # endregion

            # region Consonant Letter Great SA

            unistr = Regex.Replace(unistr, "\\\\", "ဿ");

            # endregion

            # region combine characters

            unistr = Regex.Replace(unistr, "=", "က္ခ");
            unistr = Regex.Replace(unistr, "Ð", "ဏ္ဍ");
            unistr = Regex.Replace(unistr, "Ñ", "ပ္ပ");
            unistr = Regex.Replace(unistr, "Ý", "မ္ဘ");
            unistr = Regex.Replace(unistr, "ç", "စ္စ");
            unistr = Regex.Replace(unistr, "è", "က္က");
            unistr = Regex.Replace(unistr, "é", "ဏ္ဌ");
            unistr = Regex.Replace(unistr, "ê", "န္ဒ");
            unistr = Regex.Replace(unistr, "í", "ဂ္ဂ");
            unistr = Regex.Replace(unistr, "ì", "ဇ္ဇ");
            unistr = Regex.Replace(unistr, "ð", "စ္ဆ");
            unistr = Regex.Replace(unistr, "ó", "ဉ္စ");
            unistr = Regex.Replace(unistr, "÷", "န္တ");
            unistr = Regex.Replace(unistr, "õ", "ဋ္ဌ");
            unistr = Regex.Replace(unistr, "û", "ဏ္ဏ");
            unistr = Regex.Replace(unistr, "ø", "မြို့");
            unistr = Regex.Replace(unistr, "ú", "ပါဠိ");

            # endregion

            # region General

            unistr = Regex.Replace(unistr, "Ø", "‘");
            unistr = Regex.Replace(unistr, "×", "’");
            unistr = Regex.Replace(unistr, "Þ", "“");
            unistr = Regex.Replace(unistr, "ß", "”");

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

        } // end of CE2Uni()

        //internal static string  2Uni(string srcTxt)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
