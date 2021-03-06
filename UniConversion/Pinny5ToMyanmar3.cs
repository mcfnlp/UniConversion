using System;
//using System.Collections.Generic;
//using System.Text;
using System.Text.RegularExpressions;


namespace UniConversion
{
    class  Pinny5ToMyanmar3
    {
        public static string Pinny52Uni(string input)
        {
            // copy inputted string to unistr
            String unistr = "";
            unistr = input.Substring(0);


            //#region call
           
            //System.Data.DataSet ds = new System.Data.DataSet();
            ////string src = UniConversion.Properties.Resources.Pinny5ToMyanmar3;
            ////ds.ReadXml(@"C:\Documents and Settings\ag\Desktop\JustWork\UnicodeConverter\addPinny(Unicode Converter)LastReleased\UniConversion\UniConversion\bin\Debug\Pinny5ToMyanmar3.xml");
            //string dir = System.IO.Directory.GetCurrentDirectory() + "\\Pinny5ToMyanmar3.xml";
            //ds.ReadXml(dir);
            //System.Data.DataRowCollection drc = ds.Tables["fontTable"].Rows;
            //foreach (System.Data.DataRow dr in drc)
            //{
            //    if (unistr.Contains(dr[0].ToString()))
            //    {
            //        unistr = unistr.Replace(dr[0].ToString(), dr[1].ToString());
            //    }
            //}
            //#endregion call

            #region Kinzi
            unistr = Regex.Replace(unistr, "F", "င်္");
            unistr = Regex.Replace(unistr, "ø", "င်္ံ");
            unistr = Regex.Replace(unistr, "Ð", "င်္ီ");
            unistr = Regex.Replace(unistr, "Ø", "င်္ိ");
            unistr = Regex.Replace(unistr, "ð", "ံိ");
            #endregion Kinzi

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
            //unistr = Regex.Replace(unistr, "Ü", "ဈ");//JHA
            unistr = Regex.Replace(unistr, "[ÚÍ]", "ဉ");//NYA
            unistr = Regex.Replace(unistr, "[nñ]", "ည");//NNYA
            unistr = Regex.Replace(unistr, "#", "ဋ");//TTA
            unistr = Regex.Replace(unistr, "X", "ဌ");//TTHA
            unistr = Regex.Replace(unistr, "!", "ဍ");//DDA
            unistr = Regex.Replace(unistr, "¡", "ဎ");//DDHA
            unistr = Regex.Replace(unistr, "P", "ဏ");//NNA
            unistr = Regex.Replace(unistr, "w", "တ");//TA
            unistr = Regex.Replace(unistr, "x", "ထ");//THA
            unistr = Regex.Replace(unistr, "\'", "ဒ");//DA
            unistr = Regex.Replace(unistr, "\"", "ဓ");//DHA
            unistr = Regex.Replace(unistr, "[eE]", "န");//NA
            unistr = Regex.Replace(unistr, "y", "ပ");//PA
            unistr = Regex.Replace(unistr, "z", "ဖ");//PHA
            unistr = Regex.Replace(unistr, "A", "ဗ");//BA
            unistr = Regex.Replace(unistr, "b", "ဘ");//NHA
            unistr = Regex.Replace(unistr, "r", "မ");//MA
            unistr = Regex.Replace(unistr, ",", "ယ");//YA
            unistr = Regex.Replace(unistr, "[&½]", "ရ");//RA
            unistr = Regex.Replace(unistr, "v", "လ");//LA
            unistr = Regex.Replace(unistr, "0", "ဝ");//WA
            unistr = Regex.Replace(unistr, "o", "သ");//SA
            unistr = Regex.Replace(unistr, "[[]", "ဟ");//HA
            unistr = Regex.Replace(unistr, "V", "ဠ");//LLA
            #endregion Consonants
            //worked
            #region StackConsonants
            unistr = Regex.Replace(unistr,"ú", "\u1039" + 'က');
            unistr = Regex.Replace(unistr, "©", "\u1039" + 'ခ');
            unistr = Regex.Replace(unistr, "¾", "\u1039" + 'ဂ');
            unistr = Regex.Replace(unistr, "ö", "\u1039" + 'စ');
            unistr = Regex.Replace(unistr, "ä", "\u1039" + 'ဆ');
            unistr = Regex.Replace(unistr, "Æ", "\u1039" + 'ဇ');
            unistr = Regex.Replace(unistr, "Ö", "\u1039" + 'ဏ');
            unistr = Regex.Replace(unistr, "Å", "\u1039" + 'တ');
            unistr = Regex.Replace(unistr, "å", "\u1039" + 'တ');
            unistr = Regex.Replace(unistr, "¦", "\u1039" + 'ထ');
            unistr = Regex.Replace(unistr, "¬", "\u1039" + 'ထ');
            unistr = Regex.Replace(unistr, "´", "\u1039" + 'ဒ');
            unistr = Regex.Replace(unistr, "¨", "\u1039" + 'ဓ');
            unistr = Regex.Replace(unistr, "é", "\u1039" + 'န');
            unistr = Regex.Replace(unistr, "Ü", "\u1039" + 'ပ');
            unistr = Regex.Replace(unistr, "æ", "\u1039" + 'ဖ');
            unistr = Regex.Replace(unistr, "Á", "\u1039" + 'ဗ');
            unistr = Regex.Replace(unistr, "Ç", "\u1039" + 'ဘ');
            #endregion 

            #region Medial
            unistr = Regex.Replace(unistr, "s", "ျ"); // ya
            unistr = Regex.Replace(unistr, "R", "ျွ"); // ya + wa
            unistr = Regex.Replace(unistr, "Q", "ျှ"); // ya + ha
            unistr = Regex.Replace(unistr, "W", "ျွှ"); // ya + wa + ha

            unistr = Regex.Replace(unistr, "[jNMB]", "ြ"); // ra
            unistr = Regex.Replace(unistr, "[<>`~]", "ြွ"); // ra + wa
           
            unistr = Regex.Replace(unistr, "G", "ွ"); // wa            
            unistr = Regex.Replace(unistr, "T", "ွ" + "ှ"); // wa + ha

            unistr = Regex.Replace(unistr, "[S§]", "ှ"); // ha
            unistr = Regex.Replace(unistr, "I", "ှု");// ha + ta chaung yin
            unistr = Regex.Replace(unistr, "ª", "ှူ");// ha + na chaung yin

            #endregion 

            #region Independent Vowels
            unistr = Regex.Replace(unistr, "t", "အ");
            unistr = Regex.Replace(unistr, "£", "ဣ"); // I
            unistr = Regex.Replace(unistr, "[þÖ]", "ဤ"); // II
            unistr = Regex.Replace(unistr, "[OÍ]", "ဥ"); // U
            unistr = Regex.Replace(unistr, "\\$", "ဦ"); // UU
            unistr = Regex.Replace(unistr, "OD", "ဦ"); // UU
            unistr = Regex.Replace(unistr, "ÍD", "ဦ"); // UU
            unistr = Regex.Replace(unistr, "Of", "ဉ်");
            unistr = Regex.Replace(unistr, "Íf", "ဉ်");
            unistr = Regex.Replace(unistr, "E", "ဧ"); // E
            unistr = Regex.Replace(unistr, "Bo", "ဩ"); // ASCII letters combined, O
            unistr = Regex.Replace(unistr, "Mo", "ဩ");
            unistr = Regex.Replace(unistr, "aBomf", "ဪ"); // ASCII letters combined, AU
            unistr = Regex.Replace(unistr, "aMomf", "ဪ");
            #endregion

            #region Vowels

            unistr = Regex.Replace(unistr, "g", "ါ"); // Tall AA
            unistr = Regex.Replace(unistr, ":", "ါ်"); // Tall AA + asat
            unistr = Regex.Replace(unistr, "m", "ာ"); // AA
            unistr = Regex.Replace(unistr, "d", "ိ"); // I
            unistr = Regex.Replace(unistr, "D", "ီ"); // II
            unistr = Regex.Replace(unistr, "[kK]", "ု"); // U
            unistr = Regex.Replace(unistr, "[lL]", "ူ"); // UU

            unistr = Regex.Replace(unistr, "a", "ေ"); // E
            unistr = Regex.Replace(unistr, "J", "ဲ"); // AI
            unistr = Regex.Replace(unistr, "H", "ံ"); // ANUSVARA

            #endregion
            # region Asat

            unistr = Regex.Replace(unistr, "f", "်");

            # endregion

            # region Tone Marks

            unistr = Regex.Replace(unistr, "[hUY]", "့"); // Aukmyit
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

            unistr = Regex.Replace(unistr, "\\?", "၊");
            unistr = Regex.Replace(unistr, "\\/", "။");

            # endregion
            # region Various Signs

            unistr = Regex.Replace(unistr, "ü", "၌");
            unistr = Regex.Replace(unistr, "í", "၍");
            unistr = Regex.Replace(unistr, "¤", "၎");
            unistr = Regex.Replace(unistr, "\\\\", "၏");

            # endregion

            # region Consonant Letter Great SA

            unistr = Regex.Replace(unistr, "ó", "ဿ");

            # endregion
            #region General

            unistr = Regex.Replace(unistr, "@", "ဏ္ဍ");
            unistr = Regex.Replace(unistr, "÷", "ဋ္ဌ");
            unistr = Regex.Replace(unistr, "»", " န္တ");
            unistr = Regex.Replace(unistr, "¼", "န္ထ");
            unistr = Regex.Replace(unistr, "Ä", "*");
            unistr = Regex.Replace(unistr, "^", "/");
            unistr = Regex.Replace(unistr, "Ó", "ဉာ");
            unistr = Regex.Replace(unistr, "}", "’");
            unistr = Regex.Replace(unistr, "]", "‘");
            unistr = Regex.Replace(unistr, "_", "x");
            unistr = Regex.Replace(unistr, "Ë", "သူရိန်ထွန်း");

            #endregion 

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
            
        } // end of  Pinny5ToMyanmar3()
    }
}
