//Pratik - Linq
//Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz. Bu liste üzerinden aşağıdaki linq sorgularını çalıştırarak konsol ekranına istenilenleri yazdırınız.

Random rnd = new Random();

List<int> randomList = new List<int>();

for(int i = 0; i < 10; i++)
{
    randomList.Add(rnd.Next(-30, 30));
}

foreach(int i in randomList)
{
    Console.WriteLine(i);
}


//Çift olan sayılar

Console.WriteLine("-----------EVEN NUMBERS-----------");

var evenNumbers = randomList.Where(x => x % 2 == 0);

foreach(int i in evenNumbers)
{

Console.WriteLine(i); }


//Tek olan sayılar

Console.WriteLine("-----------ODD NUMBERS-----------");

var oddNumbers = randomList.Where(x => x % 2 != 0);

foreach (int i in oddNumbers)
{

    Console.WriteLine(i);
}

//Negatif sayılar

Console.WriteLine("-----------NEGATIVE NUMBERS-----------");

var negativeNumbers = randomList.Where(x => x <0);

foreach (int i in negativeNumbers)
{

    Console.WriteLine(i);
}



//Pozitif Sayılar

Console.WriteLine("-----------POSITIVE NUMBERS-----------");

var positiveNumbers = randomList.Where(x => x > 0);

foreach (int i in positiveNumbers)
{

    Console.WriteLine(i);
}




//15'ten büyük ve 22'den küçük sayılar

Console.WriteLine("-----------Numbers greater than 15 and less than 22-----------");

var specialNumbers = randomList.Where(x => x > 15 && x<22);

foreach (int i in specialNumbers)
{

    Console.WriteLine(i);
}

//Listedeki her bir sayının karesi (Bunun için yeni bir liste oluşturup yazdırabilirsiniz.)


Console.WriteLine("-----------SQUARED NUMBERS-----------");

var squaredNumbers = randomList.Select(x=>x*x);

foreach (int i in squaredNumbers)
{

    Console.WriteLine(i);
}