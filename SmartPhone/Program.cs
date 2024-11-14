using System.Text;
using SmartPhone;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Въведете телефонни номера разделени с интервали.");
string phones = Console.ReadLine();
Console.WriteLine("Въведете URL адреси разделени с интервали.");
string sites = Console.ReadLine();

string[] phonesArr = phones.Split(null);
string[] sitesArr = sites.Split(null);

Phone phone = new Phone();
foreach (string p in phonesArr)
{
    phone.Call(p);
}

foreach (string b in sitesArr)
{
    phone.Browse(b);
}
