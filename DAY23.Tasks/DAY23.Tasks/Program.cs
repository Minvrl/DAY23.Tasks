using DAY23.Tasks;

int numOdd = 6;
Console.WriteLine(numOdd.IsOdd());

int numEven = 4;
Console.WriteLine(numEven.IsEven());

string str3 = "salam 3 necesiz";
Console.WriteLine(str3.IsContaintsDigit());


string str4 = "caAPiTalIzIng";
Console.WriteLine(str4.ToCapitalize());


string text = "salaam";
char chr = 'a';
int[] charIndexes = text.GetValueIndexes(chr);

for (int i = 0; i < charIndexes.Length; i++)
{
    Console.WriteLine($"[{charIndexes[i]}]");
}


string metn = "Men yagisi sevirem. Amma qari daha cox sevirem. Qış en gozel fesildir.";
Console.WriteLine(metn.GetFirstSentence());


//Bosluqlar nezere alinmadan
string str = "salam necesiz doslar";

Console.WriteLine(str.GetSecondWord());


//Bosluqlar nezere alinarsa
string str2 = "  A      snow  storm  ";
string fixedString = str2.FixSpacing();
Console.WriteLine(fixedString.GetSecondWord()); 
