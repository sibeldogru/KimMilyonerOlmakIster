

Console.WriteLine("Kim Milyoner Olmak İster'e Hoş Geldiniz!");


Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir?");
Console.Write("a) Lama ");
Console.WriteLine("b) Deve");
string answer1 = Console.ReadLine().ToLower();

if (answer1 == "a")
{

    Console.WriteLine("Tebrikler, doğru cevap!");
}
else

    Console.WriteLine("Yanlış cevap!");


Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ?");
Console.Write("a) Venüs "); 
Console.WriteLine("b) Mars");
string answer2 = Console.ReadLine().ToLower();

if (answer2 == "a")
{
    Console.WriteLine("Tebrikler, doğru cevap!");
}
else
    Console.WriteLine("Yanlış cevap!");



if (answer1 == "b" && answer2 == "b")

    Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");

else if (answer1 == "a" && answer2 == "b" || answer1 == "b" && answer2 == "a")
{
    Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
    Console.Write("a) 7 "); 
    Console.WriteLine("b) 12");
    string answer3 = Console.ReadLine().ToLower();

    if (answer3 == "b")
        Console.WriteLine("Tebrikler büyük ödülü kazandınız!");

    else
        Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");
}



