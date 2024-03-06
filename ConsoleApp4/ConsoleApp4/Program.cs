// Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve doğru tahmin edene kadar devam eden bir program yazınız.(While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)

Random random = new Random();
int randomNumber = random.Next(1, 10);

bool answer = false;

while (!answer)
{
    Console.Write("1 ile 10 arasında sayı giriniz: ");
    int number;
    bool isNumber = int.TryParse(Console.ReadLine(), out number);

    if (!isNumber || number < 1 || number > 10)
    {
        Console.WriteLine("1 ile 10 arasında bir sayı girmelisiniz !!!");
        continue;
    }
    if (number == randomNumber)
    {
        answer = true;
        Console.WriteLine("Tebrikler Doğru Tahmin !!!");
    }
    else if (number < randomNumber)
    {
        Console.WriteLine("Tahmin ettiğiniz sayı küçük. Daha büyük bir sayı giriniz.");
    }
    else
    {
        Console.WriteLine("Tahmin ettiğiniz sayı büyük. Daha küçük bir sayı giriniz.");
    }
}