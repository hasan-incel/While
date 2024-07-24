int i = 0;

while (i < 10) // while kullanarak ve i++ ekleyerek, 10 tane verdiğim metini yazdırıyorum.
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

Console.WriteLine();//Boşluk

i  = 1;// i'yi 1'e eşitliyorum.While kullanarak ve i++ ekleyerek, 1 ile 20 arası sayıyı konsola yazdırıyorum.

while (i <= 20)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine();//Boşluk

i = 1;

while (i <= 20) // i'yi 1'e eşitliyorum.While kullanarak ve i++ ekleyerek, 1 ile 20 arası çift sayıları konsola yazdırıyorum.
{
    if( i % 2 == 0 )// Çift sayı almamızı sağlıyor. Sayı 2'ye bölündüğünde elde kalan sayının 0 olması gerekiyor.
        Console.WriteLine(i);
        i++;
}

Console.WriteLine();//Boşluk

int toplam = 0;
i = 50;

while (i <= 150) // 50 ile 150 arasındaki sayıların toplamını while kullanarak konsola yazdırıyorum.
{
    toplam += i;
    i++;
}

Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

Console.WriteLine();//Boşluk

int cift = 0;
int tek = 0;
i = 1;
while (i <= 120) // 1 ile 120 arasındaki tek ve çift sayıların toplamını aşağıdaki yazdığım kod ile sağlıyorum.
{
    if (i % 2 == 0)
        cift += i;
    else
        tek += i;
    i++;
}

//tek ve çift sayılar toplamını konsola yazdırıyorum.
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tek);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + cift);