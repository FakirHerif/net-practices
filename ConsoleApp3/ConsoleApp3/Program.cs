// Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

/*
*** While Döngüsü ***
while döngüsü, belirli bir koşul doğru olduğu sürece döngüyü çalıştırmaya devam eder. 
Döngü başlamadan önce koşul kontrol edilir ve koşul doğru ise döngü içeriği çalışır. 
Döngü içeriği çalıştıktan sonra tekrar koşul kontrol edilir ve koşul doğru ise döngü tekrar çalışır. 
Koşul yanlış olduğunda döngü sona erer ve program akışı döngünün dışındaki kod satırına geçer.
--------------------------------------------------------------------------------------------------------

*** Do-While Döngüsü ***
do-while döngüsü de bir koşula bağlı olarak tekrar etmeyi sağlar. 
Ancak, do-while döngüsünde döngü içeriği en az bir kez çalıştırılır ve koşul döngü içinde değerlendirilir. 
Yani, koşulun doğru veya yanlış olması döngünün başında değil, sonunda kontrol edilir. 
Bu nedenle, do-while döngüsü, döngünün en az bir kez çalışmasını istediğiniz durumlarda kullanışlıdır.
--------------------------------------------------------------------------------------------------------

while döngüsünün koşulunu başlangıçta kontrol ederken, do-while döngüsü koşulu döngü içinde kontrol eder. 
Bu nedenle, do-while döngüsü, döngünün en az bir kez çalışmasını sağlamak için daha uygun olabilir, çünkü koşulun yanlış olması durumunda bile döngü içeriği en az bir kez çalıştırılır.
*/

int sayı = 0;
do
{
    Console.WriteLine("sayı = {0}", sayı);
    sayı++;

    if (sayı > 10)
        break;
}
while (sayı <= 10);

Console.WriteLine("**************");

char harf = 'A';
while (harf <= 'Z')
{
    Console.WriteLine("Harf = {0}", harf);
    harf++;
}
;