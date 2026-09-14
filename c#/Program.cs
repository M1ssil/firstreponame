Console.WriteLine("Hello, World!");

/*
string name = "Project nummer 1";
Console.WriteLine(name);

int dag = 1;
Console.WriteLine("dag " + dag);
*/

/*
* block comment
*/

/* Also a comment */

// single line comment


//Øvelsestime 09/09
/*
double d = 2.0;
int i = (int) d;
// når man skal få det til at blive et helt tal

//bool true eller false

/* beregner arealet af en cirkel
double Area(double radius){
    return Math.PI * radius * radius;
}
Console.WriteLine(Area(1));
Console.WriteLine(Area(3));
Console.WriteLine(Area(5));
*/


//disable ai --> false -> det er en god tool :)


/*
double celciusToFahrenheit(double celcius){
    return celcius * 9 / 5 + 32;
}
double fahrenheitToCelcius(double fahrenheit){
    return (fahrenheit - 32) * 5 / 9;
}
Console.WriteLine(celciusToFahrenheit(20));
Console.WriteLine(fahrenheitToCelcius(38));
*/


/* timestamp
long seconds = 100000000;
long days = seconds/86400;
long years = days/365;
long year = 1970 + years;
long remaining_days = days % 365;
long month = remaining_days / 30;
Console.WriteLine(year + "/" + month);
*/


/*temp difference in a week
double monday = 21.5;
double tuesday = 23.7;
double wednesday = 19.6;
double thursday = 22.5;
double friday = 25.3;
double saturday = 21.7;
double sunday = 18.9;
*/


/*
Console.WriteLine(tuesday - monday);
Console.WriteLine(wednesday - tuesday);
Console.WriteLine(thursday - wednesday);
Console.WriteLine(friday - thursday);
Console.WriteLine(saturday - friday);
Console.WriteLine(sunday - saturday);
Console.WriteLine(monday - sunday);
*/


/* exercise 5.15
int ada_lovelace = 36; // https://en.wikipedia.org/wiki/Ada_Lovelace
int dennis_ritchie = 70; // https://en.wikipedia.org/wiki/Dennis_Ritchie
int grace_hopper = 85; // https://en.wikipedia.org/wiki/Grace_Hopper
int hedy_lamarr = 85; // https://en.wikipedia.org/wiki/Hedy_Lamarr
int edsger_dijkstra = 72; // https://en.wikipedia.org/wiki/Edsger_W._Dijkstra
int douglas_engelbart = 88; // https://en.wikipedia.org/wiki/Douglas_Engelbart
float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
float avg = (male_avg + female_avg) / 2;
float diff = male_avg - female_avg;
Console.Write("Average lifespan of a male computer scientist: ");
Console.WriteLine(male_avg);
Console.Write("Average lifespan of a female computer scientist: ");
Console.WriteLine(female_avg);
Console.Write("Average lifespan of a computer scientist: ");
Console.WriteLine(avg);
Console.Write("Males live this much longer than females: ");
Console.WriteLine(diff);

In this coding we see that we first start with giving all variables a number and afterwards finding
the average lifespan of each gender and then we take both answers and see the difference between the genders 
*/


/* exercise 5.16
int ii = 42;
long ll = 56;
float ff = 3.14159F;
double dd = 3.14159 * 10;
Console.WriteLine("ii = {0} \nll = {1,4} \nff = {2} \ndd = {3,6:0.00}", ii, ll, ff, dd);
*/


// Forelæsning 14/09
// boolean types
/*
bool (name) = (t/f?);
NOT -> !(name) -> True when: an expression isnt true
AND -> (name1) && (name2) -> True when: both expressions are true
OR -> (name1) || (name2) -> True when: at least one expression is true
XOR -> (name1) ^ (name2) -> True when: exactly one expression is true
*/


/* how to use { and if statements
int i = 11;
Console.WriteLine("Input is "+i);
if (i%2==1) {
Console.WriteLine("Let me adjust that for you ...");
i++;
}
Console.WriteLine("Output is "+i);
*/


/* else statement
int i = 1, j = 2, k = 3;
if (i < j){
    if (i > k)
        Console.WriteLine("A");
Console.WriteLine("B");
}
*/


/* else if statements (change char direction to get a certain line)
char direction = 'n';
if (direction=='N') {
Console.WriteLine("Going north ...");
} else if (direction=='S') {
Console.WriteLine("Going south ...");
} else if (direction=='E') {
Console.WriteLine("Going east ...");
} else if (direction=='W') {
Console.WriteLine("Going west ...");
} else {
Console.WriteLine("I don't understand ?!?");
}
*/


/* switch statement (kører hurtigere end en else if statement) 
switch (direction) {
case 'N':
Console.WriteLine("Going north ...");
break;
case 'S':
Console.WriteLine("Going south ...");
break;
case 'E':
Console.WriteLine("Going east ...");
break;
case 'W':
Console.WriteLine("Going west ...");
break;
default:
Console.WriteLine("I don't understand ?!?");
break;
}

Break -> Without a break statement, the flow continues to the next case.
*/


/* Loops -> basically a spam in n times
Three types of loops: while, do-while, for
    Only executes if a statement is true

While:

int i = 0;
while (i<10) {
    Console.WriteLine(i);
    i++;
}


Do-while:

int i = 12345;
do {
Console.WriteLine(i%10);
i /= 10;
} while (i>0);


For:

for (int i=0 ; i<10 ; i++) {
Console.WriteLine(i);
}


Combinations:

while ( <condition> ) {
<statement>
}
if ( <condition> ) {
do {
<statement>
} while ( <condition> );
}
*/


// Øvelsestime 14/09


