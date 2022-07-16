
// Soru 1

/*
Console.WriteLine("Lütfen bir sayı giriniz: "); 
int n = Convert.ToInt32(Console.ReadLine());  
List<int> ciftSayiListesi=new List<int>();

Console.WriteLine("Lütfen " + n + " adet sayı giriniz: "); 

for(int i=0; i < n; i++)
{ 
    int sayi = Convert.ToInt32(Console.ReadLine()); 
    if (sayi % 2 == 0)
    {
        ciftSayiListesi.Add(sayi);
    }
}

Console.Write("Çift sayılar: ");
foreach(var sayi in ciftSayiListesi)
{
    Console.Write(sayi + " ");
} 

*/


// Soru 2

/*
Console.WriteLine("Lütfen 2 adet pozitif sayı giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen " + n + " adet pozitif sayı giriniz: ");
List<int> tam=new List<int>();  

for(int i=0; i < n+1; i++)
{
    
    if (i!=0)
    {
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (m % sayi == 0)
        {
            tam.Add(sayi);
        }

    }
   
}
Console.Write(m + "sayısının bölenleri: ");
foreach (var sayi in tam)
{
    Console.Write(sayi + " ");
}
*/


// Soru 3

/*
Console.WriteLine("Lütfen pozitif bir sayı giriniz : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n + " adet kelime giriniz : ");
string str = Console.ReadLine();
string[] new_str = str.Split(' ');



for(int i=n-1; i >= 0; i--)
{
    Console.Write(new_str[i]+" "); 
}

*/

// Soru 4

/*
Console.Write("Lütfen bir cümle yazınız: ");
string str = Console.ReadLine();
string[] words = str.Split(' ');
int letter_count = 0;
int word_count = 0;

for (int i = words.Length - 1; i >= 0; i--)
{
    word_count++;

}

for(int i = 0; i < str.Length; i++)
{
    if (str[i]==' ') { continue; }
    else
    {
        letter_count++;
    }
}

Console.WriteLine("Girdiğiniz metinde " + word_count + " adet kelime ve " + letter_count + " adet harf bulunmaktadır");

*/