Console.WriteLine("Hello, World!");

string name = "Project nummer 1";
Console.WriteLine(name);

int dag = 1;
Console.WriteLine("dag " + dag);

/*
* block comment
*/

/* Also a comment */

// single line comment

double d = 2.0;
int i = (int) d;
// når man skal få det til at blive et helt tal

//bool true eller false

// beregner arealet af en cirkel
double Area(double radius){
    return Math.PI * radius * radius;
}
Console.WriteLine(Area(1));
Console.WriteLine(Area(3));
Console.WriteLine(Area(5));

//disable ai --> false -> det er en god tool :)

double celciusToFahrenheit(double celcius){
    return celcius * 9 / 5 + 32;
}
double fahrenheitToCelcius(double fahrenheit){
    return (fahrenheit - 32) * 5 / 9;
}
Console.WriteLine(celciusToFahrenheit(20));
Console.WriteLine(fahrenheitToCelcius(38));


// timestamp
long seconds = 100000000;
long days = seconds/86400;
long years = days/365;
long year = 1970 + years;
long remaining_days = days % 365;
long month = remaining_days / 30;
Console.WriteLine(year + "/" + month);

