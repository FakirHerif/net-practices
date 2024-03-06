// String metotlarını araştırınız. Her bir metot için örnek yapınız.

// String Length
string test = "LOREM IPSUM Dolor Sit Amet, Consectetur Adipiscing Elit, Sed Do Eiusmod Tempor Incididunt Ut Labore Et Dolore Magna Aliqua...";
Console.WriteLine("Metnin uzunluğu: " + test.Length);

// To Upper
Console.WriteLine(test.ToUpper());  // tüm harfleri büyütür

// To Lower
Console.WriteLine(test.ToLower());  // tüm harfleri küçültür

// String Concatenation (+ and concat)
string test1 = "Ali ";
string test2 = "Veli";
string full = test1 + test2;
Console.WriteLine(full);            // Ali Veli

string full2 = string.Concat(test1, test2);
Console.WriteLine(full2);           // Ali Veli

// String Interpolation
string test3 = "Birinci";
string test4 = "İkinci";
string full3 = $"Birleştirilmiş metin: {test3} {test4}";
Console.WriteLine(full3);           // Birleştirilmiş metin: Birinci İkinci

// Access Strings
string test5 = "Hello World!";
Console.WriteLine(test5[0]);            // H
Console.WriteLine(test5[8]);            // r
// Index Position
Console.WriteLine(test5.IndexOf("d"));  // 10
Console.WriteLine(test5.IndexOf("W"));  // 6

// Substring
string test6 = "Hello World!";
int location = test5.IndexOf("W");
string test7 = test6.Substring(location);
Console.WriteLine(test7);               // World!

// Special Characters
string test8 = "We are the so-called \"Vikings\" from the north.";
Console.WriteLine(test8);               // We are the so-called "Vikings" from the north.
string test9 = "It\'s alright.";
Console.WriteLine(test9);               // It's alright.
string test10 = "The character \\ is called backslash.";
Console.WriteLine(test10);              // The character \ is called backslash.

/*
\n ---> Yeni Satır
\t ---> Tab Boğluğu
\b ---> Backspace
\0 ---> Null
*/

// Compare two strings
string test11 = "Ali";
string test12 = "Ali";
string test13 = "Veli";
Boolean result1 = test11.Equals(test12);
Console.WriteLine("test11 ve test12 eşit mi ? " + result1);   // test11 ve test12 eşit mi ? True
Boolean result2 = test11.Equals(test13);
Console.WriteLine("test11 ve test13 eşit mi ? " + result2);   // test11 ve test13 eşit mi ? False

// Replace
string test14 = "Baklava";
string test15 = test14.Replace("Bak", "Ok");
Console.WriteLine(test15);       // Oklava

// Trim
string test16 = "           Kahve        ";
Console.WriteLine(test16);          //            Kahve        
Console.WriteLine(test16.Trim());   // Kahve