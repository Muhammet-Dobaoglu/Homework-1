#region Girilen 2 Sayı Arasındaki Sayıları Toplayan ve Çarpan Program

int toplam = 0;
int carpim = 1;

Console.Write("1.Sayı : ");
int sayi_1 = int.Parse(Console.ReadLine());

Console.Write("2.Sayı : ");
int sayi_2 = int.Parse(Console.ReadLine());

start:

Console.Write("\nİşlem Seçiniz [+,*] : ");
string islem = Console.ReadLine();

if(islem == "+")
{
    if(sayi_2>sayi_1)
    {
        for (int i = sayi_1; i <= sayi_2; i++)
        {
            toplam = toplam + i;
        }

    }
    else
    {
        for (int i = sayi_2; i <= sayi_1; i++)
        {
            toplam = toplam + i;
        }
    }
    Console.WriteLine($"\n{sayi_1} ve {sayi_2} arasındaki sayıların toplamı = {toplam}");

}

else if(islem == "*")
{
    for (int i = sayi_1; i <= sayi_2; i++)
    {
        carpim = carpim * i;
    }
    Console.WriteLine($"\n{sayi_1} ve {sayi_2} arasındaki sayıların çarpımı = {carpim}");
}

else
{
    Console.WriteLine("\nHatalı Karakter Girdiniz.");
    goto start;
}

Console.ReadKey();

#endregion 