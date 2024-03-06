// Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.Input için Scanner kullanınız

Console.Write("Sipariş Numarası Giriniz: ");
int orderNumber = Convert.ToInt32(Console.ReadLine());

switch(orderNumber)
{
    case 1:
        Console.WriteLine("Sipariş Edilen Ürün: Tshirt");
        break;
    case 2: 
        Console.WriteLine("Sipariş Edilen Ürün: Pantolon");
        break;
    case 3:
        Console.WriteLine("Sipariş Edilen Ürün: Mont");
        break;
    case 4:
        Console.WriteLine("Sipariş Edilen Ürün: Kaban");
        break;
    case 5:
        Console.WriteLine("Sipariş Edilen Ürün: Kazak");
        break;
    default:
        Console.WriteLine("Lütfen 1 ile 5 arasında bir sipariş numarası giriniz.");
        break;
}
