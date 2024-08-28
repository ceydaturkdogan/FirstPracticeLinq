//Pratik - Linq
//Create a list of 10 random numbers. Run the following linq queries through this list and print the desired information on the console screen.

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


//Even numbers

Console.WriteLine("-----------EVEN NUMBERS-----------");

var evenNumbers = randomList.Where(x => x % 2 == 0);

foreach(int i in evenNumbers)
{

Console.WriteLine(i); }


//Odd Numbers

Console.WriteLine("-----------ODD NUMBERS-----------");

var oddNumbers = randomList.Where(x => x % 2 != 0);

foreach (int i in oddNumbers)
{

    Console.WriteLine(i);
}

//Negative Numbers

Console.WriteLine("-----------NEGATIVE NUMBERS-----------");

var negativeNumbers = randomList.Where(x => x <0);

foreach (int i in negativeNumbers)
{

    Console.WriteLine(i);
}



//Positive Numbers

Console.WriteLine("-----------POSITIVE NUMBERS-----------");

var positiveNumbers = randomList.Where(x => x > 0);

foreach (int i in positiveNumbers)
{

    Console.WriteLine(i);
}




//Greater than 15 and less than 22

Console.WriteLine("-----------Numbers greater than 15 and less than 22-----------");

var specialNumbers = randomList.Where(x => x > 15 && x<22);

foreach (int i in specialNumbers)
{

    Console.WriteLine(i);
}

//Find Square of each number in the list 


Console.WriteLine("-----------SQUARED NUMBERS-----------");

var squaredNumbers = randomList.Select(x=>x*x);

foreach (int i in squaredNumbers)
{

    Console.WriteLine(i);
}