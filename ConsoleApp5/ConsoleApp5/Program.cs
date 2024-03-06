// Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

Console.Write("Bir sayı girin: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= number / 2 ; i++)
{
    if (number % i == 0)
    {
        sum += i;
    }
}

if (sum == number)
{
    Console.WriteLine("Girdiğiniz sayı " + number + " sayı mükemmel sayıdır");
}
else
{
    Console.WriteLine("Girdiğiniz sayı " + number + " mükemmel sayı değildir.");
}

