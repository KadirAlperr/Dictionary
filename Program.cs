
using Dictionary;
/*
Dictionary<int, string> sehirler = new Dictionary<int, string>();

sehirler.Add(70, "Karaman");
sehirler.Add(09, "Aydın");
sehirler.Add(33, "Mersin");

sehirler.Add(06, "Ankara");

sehirler.Remove(09);

foreach(var sehir in sehirler)
{
    Console.WriteLine("plaka : " + sehir.Key + " şehir : " + sehir.Value);
}

bool VarMi = sehirler.ContainsKey(90);
Console.WriteLine(VarMi);

sehirler[09] = "Yeni Aydın";
Console.WriteLine(sehirler[09]);

Console.WriteLine("**********************************************************");
*/




MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
myDictionary.Add(33, "Mersin");
myDictionary.Add(70, "Karaman");
myDictionary.Add(9, "Aydın");
myDictionary.Get();