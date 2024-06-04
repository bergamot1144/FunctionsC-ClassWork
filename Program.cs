// See https://aka.ms/new-console-template for more information


//int number;

//Sum(10, 24, out number);

//Console.WriteLine(number);





//void Sum(int x, int y, out int result)
//{
//    result = x + y;
//}




//------------------------------

//int x = 5;

//Console.WriteLine($"Число до метода Increment: {x}");
//Increment(ref x);
//Console.WriteLine($"Число после метода Increment: {x}");




//void Increment(ref int n)
//{
//    n++;
//    Console.WriteLine($"Число в методе Increment: {n}");
//}





//--------------------------


//Say("Yurii");
//Say("Sofiia");
//Say("Dmitro");


//Console.WriteLine(Sum(4,5));

//void Say(string x)
//{
//    Console.WriteLine($"Hello {x}");
//}



//int Sum(int x, int y)
//{
//    return x + y;
//}



void Sum(double x, double y, out double result)
{
    result = x + y;
}

double Kvadrat(double x)
{
    return x * x;
}
void Proverka(int x)
{
    if (x%2==0)
    {
        Console.WriteLine($"Proverka Vipolnena {x} - Chetnoe");
    }
    else
    {
        Console.WriteLine($"Proverka vipolnena {x} - Ne Chetnoe");    
    }
}
double Translate(double x) 
{
    return (x * 1.8) + 32;
}
void Max(double x, double y)
{
    if (x > y) { Console.WriteLine(x); }
    else if (x < y) { Console.WriteLine(y); }
    else if (x==y) { Console.WriteLine($"{x}={y}"); }
}
void Dlina (string x)
{
    int LenthOfStr = 0;
    for (int letter=0; letter<x.Length; letter++) 
    { 
        LenthOfStr += 1; 
    }
    Console.WriteLine($"Dlina stroki = { LenthOfStr} ");
}
void PustayaStroka (string x)
{
int LenthOfStr = 0;
    for (int letter = 0; letter < x.Length; letter++)
    {
        LenthOfStr += 1;
    }
    if(LenthOfStr==0) { 
        Console.WriteLine("Stroka pustaya");
    }
    else
    { 
        Console.WriteLine("Stroka ne pustaya");
    }
}

int Factorial(int x)
{
    int result=1;
    while (x >= 1)
    {
        result*=x;
        x--;
    }
    return result;
}

void sredneeZnachenie(int[] mass)
{
    int sum = 0;
    int length = mass.Length; 

    for (int i = 0; i < length; i++)
    {
        sum += mass[i];
    }

    double result = (double)sum / length; 

    Console.WriteLine($"Srednee chislo = {result}");
}

int[] numbers = { 5, 8, 3 };
sredneeZnachenie(numbers);

Console.WriteLine($"Factorial = {Factorial(5)}"); // #9

Dlina("RandomniyText");         //#7
PustayaStroka("qwe");    //#8

double C = 23;
Console.WriteLine($"Celsius = {C}           Fahrenheit = {Translate(C)}\n");  //#5

Proverka(5);    //#4
Proverka(6);    //#4

Sum(55, 44, out double number);
Console.WriteLine($"\nSum = {number}");    //#2

double result = Kvadrat(15.5);
Console.WriteLine($"Kvadrat = { result}\n"); //#3

Console.WriteLine($"Func Max:");     //#6
Max(100, 100);    
