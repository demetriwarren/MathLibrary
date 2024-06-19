namespace StringLib;

public class StringLibrary
{
    public string Concat(string str1, string str2)
    {
        return $"{str1} {str2}";
    }
    public string ToUpperEveryOther(string str)
    {
        var toUpper = true;                     //created var to tell if letter is going to be upper if true or lower case if false
        var converted = string.Empty;           //str var to load in converted string for letters upper and lower
        foreach(var ch in str.ToCharArray())    //ToCharArray is an array of all characters A-Z, str.ToCharArray returns the string that was entered into an array of characters (easier than using an index)
        {
            if (!char.IsLetter(ch))             //uses the ch class to use method (IsLetter) which will return true if upper lowercase letter and false if its a number or symbol
            {
                converted += ch;                //
                continue;                       //
            }
            if (toUpper)                        //if bool value toUpper is true, same as using "if(boolvalue == true) {...}
            {
                converted += ch.ToString().ToUpper();      //if true change ch to a string, then change whatever the value is to upper case
                continue;
            } else
                {
                    converted += ch.ToString().ToLower();   //if true change ch to a string, then change whatever the value is to lower case
                }
        }
                toUpper = !toUpper;                        // if to upper is true it flips to false
        return converted;                       //return everything as the string from line 12 (converted)
    }
}
