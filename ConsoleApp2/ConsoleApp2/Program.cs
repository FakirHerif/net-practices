// Kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(Input için Scanner ve döngü için for döngüsü kullanınız)

Console.Write("Kaç adet ürün almak istiyorsunuz? ");
int orderNumber = Convert.ToInt32(Console.ReadLine());

double totalPrice = 0;

for (int i = 1; i <= orderNumber; i++)
{
    Console.Write("{0}. Ürünün Fiyatı: ", i);
    double orderPrice = Convert.ToDouble(Console.ReadLine());
    totalPrice += orderPrice;
}

Console.WriteLine("Toplam alışveriş tutarı: " + totalPrice);