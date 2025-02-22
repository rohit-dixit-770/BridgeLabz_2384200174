//1. Validate a Username
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a username:");
        string username = Console.ReadLine();

        if (IsValidUsername(username))
        {
            Console.WriteLine("Valid username");
        }
        else
        {
            Console.WriteLine("Invalid username");
        }
    }

    static bool IsValidUsername(string username)
    {
        // Check if the length is between 5 and 15 characters
        if (username.Length < 5 || username.Length > 15)
        {
            return false;
        }

        // Check if the first character is a letter
        if (!char.IsLetter(username[0]))
        {
            return false;
        }

        // Check if all characters are letters, numbers, or underscores
        foreach (char c in username)
        {
            if (!char.IsLetterOrDigit(c) && c != '_')
            {
                return false;
            }
        }

        // All checks passed, the username is valid
        return true;
    }
}


//2. Validate a License Plate Number

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a license plate number:");
        string licensePlate = Console.ReadLine();

        if (IsValidLicensePlate(licensePlate))
        {
            Console.WriteLine("Valid license plate number");
        }
        else
        {
            Console.WriteLine("Invalid license plate number");
        }
    }

    static bool IsValidLicensePlate(string licensePlate)
    {
        // Check if the length is exactly 6 characters
        if (licensePlate.Length != 6)
        {
            return false;
        }

        // Check if the first two characters are uppercase letters
        if (!char.IsUpper(licensePlate[0]) || !char.IsUpper(licensePlate[1]))
        {
            return false;
        }

        // Check if the remaining four characters are digits
        for (int i = 2; i < 6; i++)
        {
            if (!char.IsDigit(licensePlate[i]))
            {
                return false;
            }
        }

        // All checks passed, the license plate number is valid
        return true;
    }
}


//3. Validate a Hax Color Code
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a hex color code:");
        string hexColor = Console.ReadLine();

        if (IsValidHexColor(hexColor))
        {
            Console.WriteLine("Valid hex color code");
        }
        else
        {
            Console.WriteLine("Invalid hex color code");
        }
    }

    static bool IsValidHexColor(string hexColor)
    {
        // Check if the length is 7 characters (including '#')
        if (hexColor.Length != 7)
        {
            return false;
        }

        // Check if the first character is '#'
        if (hexColor[0] != '#')
        {
            return false;
        }

        // Check if the remaining characters are valid hexadecimal characters
        for (int i = 1; i < 7; i++)
        {
            char c = hexColor[i];
            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
            {
                return false;
            }
        }

        // All checks passed, the hex color code is valid
        return true;
    }
}




//4. Extract All Email Addresses from a Text
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text to extract email addresses:");
        string text = Console.ReadLine();

        List<string> emails = ExtractEmailAddresses(text);

        if (emails.Count > 0)
        {
            Console.WriteLine("Extracted Email Addresses:");
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
        }
        else
        {
            Console.WriteLine("No valid email addresses found.");
        }
    }

    static List<string> ExtractEmailAddresses(string text)
    {
        List<string> emails = new List<string>();
        int textLength = text.Length;

        for (int i = 0; i < textLength; i++)
        {
            // Check for '@' symbol in the text
            if (text[i] == '@')
            {
                // Find the start of the email address
                int start = i - 1;
                while (start >= 0 && (char.IsLetterOrDigit(text[start]) || text[start] == '.' || text[start] == '_'))
                {
                    start--;
                }
                start++;

                // Find the end of the email address
                int end = i + 1;
                while (end < textLength && (char.IsLetterOrDigit(text[end]) || text[end] == '.' || text[end] == '_'))
                {
                    end++;
                }

                // Extract the potential email address
                string email = text.Substring(start, end - start);

                // Validate the extracted email address
                if (IsValidEmail(email))
                {
                    emails.Add(email);
                }
            }
        }

        return emails;
    }

    static bool IsValidEmail(string email)
    {
        // Check if the email contains '@' symbol
        int atIndex = email.IndexOf('@');
        if (atIndex == -1) return false;

        // Split the email into local and domain parts
        string localPart = email.Substring(0, atIndex);
        string domainPart = email.Substring(atIndex + 1);

        // Validate the local and domain parts
        if (localPart.Length == 0 || domainPart.Length == 0) return false;
        if (!char.IsLetterOrDigit(localPart[0]) || !char.IsLetterOrDigit(domainPart[0])) return false;

        return true;
    }
}


//5. Extract All Capitalized Words from a Sentence
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a sentence
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // List to store capitalized words
        List<string> capitalizedWords = new List<string>();

        // Split the input sentence into words
        string[] words = input.Split(' ');

        // Loop through each word to check if it starts with a capital letter
        foreach (string word in words)
        {
            if (word.Length > 0 && Char.IsUpper(word[0]))
            {
                capitalizedWords.Add(word);
            }
        }

        // Print the matched words
        Console.WriteLine("Capitalized words found:");
        foreach (string capitalizedWord in capitalizedWords)
        {
            Console.WriteLine(capitalizedWord);
        }
    }
}


//6. Extract Dates in dd/mm/yyyy Format
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a sentence
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // List to store dates
        List<string> dates = new List<string>();

        // Split the input sentence into words
        string[] words = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        // Check each word to see if it matches the dd/mm/yyyy format
        foreach (string word in words)
        {
            if (IsValidDate(word))
            {
                dates.Add(word);
            }
        }

        // Print the matched dates
        Console.WriteLine("Dates found:");
        foreach (string date in dates)
        {
            Console.WriteLine(date);
        }
    }

    static bool IsValidDate(string word)
    {
        // Check length and format dd/mm/yyyy
        if (word.Length != 10 || word[2] != '/' || word[5] != '/')
        {
            return false;
        }

        // Extract day, month, and year
        string dayStr = word.Substring(0, 2);
        string monthStr = word.Substring(3, 2);
        string yearStr = word.Substring(6, 4);

        // Convert to integers
        if (int.TryParse(dayStr, out int day) && int.TryParse(monthStr, out int month) && int.TryParse(yearStr, out int year))
        {
            // Validate day, month, and year ranges
            if (day >= 1 && day <= 31 && month >= 1 && month <= 12 && year >= 1000 && year <= 9999)
            {
                return true;
            }
        }

        return false;
    }
}


//7. Extract Links from a Web Page
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a sentence
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // List to store extracted links
        List<string> links = new List<string>();

        // Split the input sentence into words
        string[] words = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        // Check each word to see if it is a link (starts with "http://" or "https://")
        foreach (string word in words)
        {
            if (IsLink(word))
            {
                links.Add(word);
            }
        }

        // Print the extracted links
        Console.WriteLine("Links found:");
        foreach (string link in links)
        {
            Console.WriteLine(link);
        }
    }

    static bool IsLink(string word)
    {
        // Check if the word starts with "http://" or "https://"
        return (word.StartsWith("http://") || word.StartsWith("https://"));
    }
}



//8. Replace Multiple Spaces with a Single Space
using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a sentence
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // Result string with single spaces
        string result = RemoveExtraSpaces(input);

        // Print the result
        Console.WriteLine("Result:");
        Console.WriteLine(result);
    }

    static string RemoveExtraSpaces(string input)
    {
        char[] chars = input.ToCharArray();
        int length = chars.Length;
        int index = 0;

        // Create a new character array to store the result
        char[] result = new char[length];
        bool spaceFound = false;

        // Loop through each character in the input
        for (int i = 0; i < length; i++)
        {
            if (chars[i] != ' ')
            {
                result[index++] = chars[i];
                spaceFound = false;
            }
            else if (!spaceFound)
            {
                result[index++] = ' ';
                spaceFound = true;
            }
        }

        // Convert the result array to a string and trim the trailing spaces
        return new string(result, 0, index).Trim();
    }
}


//9. Censor Bad Words in a Sentence
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a sentence
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // List of bad words to censor
        List<string> badWords = new List<string> { "damn", "stupid" };

        // Censor the bad words
        string censoredSentence = CensorBadWords(input, badWords);

        // Print the censored sentence
        Console.WriteLine("Censored sentence:");
        Console.WriteLine(censoredSentence);
    }

    static string CensorBadWords(string input, List<string> badWords)
    {
        // Split the input sentence into words
        string[] words = input.Split(' ');

        // Loop through each word and replace bad words
        for (int i = 0; i < words.Length; i++)
        {
            foreach (string badWord in badWords)
            {
                if (words[i].Equals(badWord, StringComparison.OrdinalIgnoreCase))
                {
                    words[i] = "****";
                }
            }
        }

        // Join the words back into a sentence
        return string.Join(" ", words);
    }
}


//10. Validate an IP Address
using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter an IP address
        Console.WriteLine("Enter an IPv4 address:");
        string input = Console.ReadLine();

        // Validate the IP address
        bool isValid = IsValidIPAddress(input);

        // Print the result
        Console.WriteLine(isValid ? "The IP address is valid." : "The IP address is invalid.");
    }

    static bool IsValidIPAddress(string ipAddress)
    {
        // Split the IP address into segments based on '.'
        string[] segments = ipAddress.Split('.');

        // Check if there are exactly 4 segments
        if (segments.Length != 4)
        {
            return false;
        }

        // Validate each segment
        foreach (string segment in segments)
        {
            // Check if the segment is an integer and within the range 0-255
            if (!int.TryParse(segment, out int value) || value < 0 || value > 255)
            {
                return false;
            }
        }

        return true;
    }
}


//11. using System;

using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a credit card number
        Console.WriteLine("Enter a credit card number:");
        string input = Console.ReadLine();

        // Validate the credit card number
        bool isValid = IsValidCreditCardNumber(input);

        // Print the result
        Console.WriteLine(isValid ? "The credit card number is valid." : "The credit card number is invalid.");
    }

    static bool IsValidCreditCardNumber(string cardNumber)
    {
        // Check if the length is 16 digits
        if (cardNumber.Length != 16)
        {
            return false;
        }

        // Check if it is a Visa card (starts with 4) or a MasterCard (starts with 5)
        if (cardNumber[0] != '4' && cardNumber[0] != '5')
        {
            return false;
        }

        // Check if all characters are digits
        foreach (char c in cardNumber)
        {
            if (!Char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}


//12. Extract Programming Language Names from a Text
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a sentence
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // List of programming languages to look for
        List<string> programmingLanguages = new List<string> { "Java", "Python", "JavaScript", "Go", "C++", "C#", "Ruby", "Swift", "PHP" };

        // List to store extracted programming languages
        List<string> extractedLanguages = new List<string>();

        // Split the input sentence into words
        string[] words = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        // Check each word to see if it is a known programming language
        foreach (string word in words)
        {
            if (programmingLanguages.Contains(word))
            {
                extractedLanguages.Add(word);
            }
        }

        // Print the extracted programming languages
        Console.WriteLine("Programming languages found:");
        foreach (string language in extractedLanguages)
        {
            Console.WriteLine(language);
        }
    }
}


//13. Extract Currency Values from a Text
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a sentence
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // List to store extracted currency values
        List<string> currencyValues = new List<string>();

        // Split the input sentence into words
        string[] words = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        // Check each word to see if it is a currency value
        foreach (string word in words)
        {
            if (IsCurrencyValue(word))
            {
                currencyValues.Add(word);
            }
        }

        // Print the extracted currency values
        Console.WriteLine("Currency values found:");
        foreach (string value in currencyValues)
        {
            Console.WriteLine(value);
        }
    }

    static bool IsCurrencyValue(string word)
    {
        // Check if the word starts with a dollar sign (Rs)
        if (word.StartsWith("Rs"))
        {
            return true;
        }

        // Check if the word can be converted to a valid double
        if (double.TryParse(word, out double value))
        {
            return true;
        }

        return false;
    }
}


//14. Find Repeating Words in a Sentence
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a sentence
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        // List to store repeating words
        List<string> repeatingWords = new List<string>();

        // Split the input sentence into words
        string[] words = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        // Check for repeating words
        for (int i = 0; i < words.Length - 1; i++)
        {
            if (words[i].Equals(words[i + 1], StringComparison.OrdinalIgnoreCase) && !repeatingWords.Contains(words[i]))
            {
                repeatingWords.Add(words[i]);
            }
        }

        // Print the repeating words
        Console.WriteLine("Repeating words found:");
        foreach (string word in repeatingWords)
        {
            Console.WriteLine(word);
        }
    }
}


//15. Validate a Social Security Number (SSN)
using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter an SSN
        Console.WriteLine("Enter a Social Security Number (SSN):");
        string input = Console.ReadLine();

        // Validate the SSN
        bool isValid = IsValidSSN(input);

        // Print the result
        Console.WriteLine(isValid ? $"\"{input}\" is valid." : $"\"{input}\" is invalid.");
    }

    static bool IsValidSSN(string ssn)
    {
        // Check the length of the SSN
        if (ssn.Length != 11)
        {
            return false;
        }

        // Check the format xxx-xx-xxxx
        for (int i = 0; i < ssn.Length; i++)
        {
            if (i == 3 || i == 6)
            {
                // Check if the character is a dash
                if (ssn[i] != '-')
                {
                    return false;
                }
            }
            else
            {
                // Check if the character is a digit
                if (!Char.IsDigit(ssn[i]))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
*/
