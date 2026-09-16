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

Numbers going the sequence 2,4,6,8....
for (int i=1 ; i<=10 ; i++) {
Console.WriteLine(2*i);
}


Nested loops -> loop inside a loop
for (int y=1 ; y<=10 ; y++) {
for (int x=1 ; x<=y ; x++) {
Console.Write(string.Format("{0,4}", x*y));
}
Console.WriteLine("");
}

Fun fact: if you loop inside a loop and loop inside of that you can be able to make a "tre-diminsionel" world
*/


/* Flow control -

Break -> used to break out of the loop and continue at the first statement after the loop definition.

int i;
for (i=0 ; i<10 ; i++) {
if (i==5) {
break;
}
}
Console.WriteLine(i);
-Result will be 5-


Continue -> skips the rest of the loop body.

int i;
int sum = 0;
for (i=0 ; i<4 ; i++) {
if (i==2) {
continue;
}
sum += i;
}
Console.WriteLine(sum);
-Result 4-
*/


// Øvelsestime 14/09

/* Exercise 5.20
byte dice = 6;
bool draw = (dice & 1) != 1 && dice > 3;
Console.WriteLine(draw); 
*/


/* Exercise 6.3
int secs_since_newyear = 21816000;
float price = 599.95;
int secs_day = 86400;
int days_month = 30;

// Day-of-year (0-indexed) that this many seconds falls on
int day_of_year = secs_since_newyear / secs_day;

// Convert to month (1-12) and day-of-month (1-30)
int month = (day_of_year / days_month) + 1;
int day_of_month = (day_of_year % days_month) + 1;

bool christmas = (month == 12 && day_of_month == 25);

if (christmas){
    price = 599.95 * 0.7;
}
else{
    price = 599.95;
}

Console.WriteLine(price);
*/


/* Exercise 6.4
int month = 12;
int length = -1;
length = (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
month == 10 || month == 12 ? 31 : 0)
+ (month == 2 ? 28 : 0)
+ (month == 4 || month == 6 || month == 9 || month == 11 ? 30 : 0);
if (length == -1) {
Console.WriteLine("Error: Month \"" + month + "\" is outside of [1,12]");
} else {
Console.WriteLine(length);
}
*/


/* Exercise 6.5
int month = 9;

if (month == 10) {
    Console.WriteLine("Finally there is a holiday in autumn!");
}
else if (month == 12) {
    Console.WriteLine("Christmas time!");
}
else if (month == 4) {
    Console.WriteLine("Yay it's easter holidays!");
}
else if (month == 7 || month == 8) {
    Console.WriteLine("Lets gooo its time for some summer vacation!");
}
else {
    Console.WriteLine("No holiday month :c");
} */


/* Exercise 6.6
int celcius = -5;
float CelciusToFahrenheit(double c){
    return c * 9 / 5 + 32;
}
while (celcius < 40){
    Console.WriteLine(CelciusToFahrenheit(celcius));
    celcius++;
} */


/* Exercise 6.9
double Area(double radius){
    return Math.PI * radius * radius;
}
Console.WriteLine(Area(1));
Console.WriteLine(Area(3));
Console.WriteLine(Area(5)); */


//Exercise 6.10
// virkelig svær


// Forelæsning 14/09
/* int[] months;
months = new int[12]; */

/* 
int-array All elements in the array start with the value 0
string-array All elements in the array start with the value null
bool-array All elements in the array start with the value false 
*/

// String arrays
/* 
string[] stringArray = [
"This", "is", "an", "example", "of", "a", "String", "array"
];
for (int i = 0; i < stringArray.Length; i++) {
Console.Write(stringArray[i] + " ");
}
Console.WriteLine(""); 
*/

// Traversing array
/* int[] months = [31,28,31,30,31,30,31,31,30,31,30,31];
for (int i=0 ; i<months.Length ; i++) {
Console.WriteLine("Month "+(i+1)+" has "+months[i]+" days");
} */




// Øvelsestime 16/09
// Exercise 7.4
/* int[] numbers = [1, 10, 3, 92, 18];
int max = numbers[0];

foreach (int number in numbers){
        if (number > max){
            max = number;
        }
}
Console.WriteLine(max);
*/


// Exercise 7.15
/* class Person {
    public int height;
    public int age;
    public bool male;
    public float shoesize;
    public char birthmonth;
} */

// Exercise 7.3
// Exercise 7.5
// Exercise 7.7
// Exercise 7.12
// Exercise 7.16
// Exercise 7.14
// Exercise 7.8
