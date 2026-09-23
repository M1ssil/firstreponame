Console.WriteLine("Velkommen agalar!");

/* Små ting
string name = "Project nummer 1";
Console.WriteLine(name);

int dag = 1;
Console.WriteLine("dag " + dag); */

/*
* block comment
*/

/* Also a comment */

// single line comment


//Øvelsestime 09/09
/* når man skal få det til at blive et helt tal
double d = 2.0;
int i = (int) d; */

//bool true eller false

/* beregner arealet af en cirkel
double Area(double radius){
    return Math.PI * radius * radius;
}
Console.WriteLine(Area(1));
Console.WriteLine(Area(3));
Console.WriteLine(Area(5)); */


//disable ai --> false -> det er en god tool :)


/* celcius to fahrenheit
double celciusToFahrenheit(double celcius){
    return celcius * 9 / 5 + 32;
}
double fahrenheitToCelcius(double fahrenheit){
    return (fahrenheit - 32) * 5 / 9;
}
Console.WriteLine(celciusToFahrenheit(20));
Console.WriteLine(fahrenheitToCelcius(38)); */


/* timestamp
long seconds = 100000000;
long days = seconds/86400;
long years = days/365;
long year = 1970 + years;
long remaining_days = days % 365;
long month = remaining_days / 30;
Console.WriteLine(year + "/" + month); */


/* temp difference in a week
double monday = 21.5;
double tuesday = 23.7;
double wednesday = 19.6;
double thursday = 22.5;
double friday = 25.3;
double saturday = 21.7;
double sunday = 18.9; */


/* exercise with weekdays
Console.WriteLine(tuesday - monday);
Console.WriteLine(wednesday - tuesday);
Console.WriteLine(thursday - wednesday);
Console.WriteLine(friday - thursday);
Console.WriteLine(saturday - friday);
Console.WriteLine(sunday - saturday);
Console.WriteLine(monday - sunday); */


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
the average lifespan of each gender and then we take both answers and see the difference between the genders  */


/* exercise 5.16
int ii = 42;
long ll = 56;
float ff = 3.14159F;
double dd = 3.14159 * 10;
Console.WriteLine("ii = {0} \nll = {1,4} \nff = {2} \ndd = {3,6:0.00}", ii, ll, ff, dd); */


// Forelæsning 14/09
/* boolean types
bool (name) = (t/f?);
NOT -> !(name) -> True when: an expression isnt true
AND -> (name1) && (name2) -> True when: both expressions are true
OR -> (name1) || (name2) -> True when: at least one expression is true
XOR -> (name1) ^ (name2) -> True when: exactly one expression is true */


/* how to use { and if statements
int i = 11;
Console.WriteLine("Input is "+i);
if (i%2==1) {
Console.WriteLine("Let me adjust that for you ...");
i++;
}
Console.WriteLine("Output is "+i); */


/* else statement
int i = 1, j = 2, k = 3;
if (i < j){
    if (i > k)
        Console.WriteLine("A");
Console.WriteLine("B");
} */


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
} */


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

Break -> Without a break statement, the flow continues to the next case. */


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
Fun fact: if you loop inside a loop and loop inside of that you can be able to make a "tre-diminsionel" world */


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
-Result 4- */


// Øvelsestime 14/09

/* Exercise 5.20
byte dice = 6;
bool draw = (dice & 1) != 1 && dice > 3;
Console.WriteLine(draw); */


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
Console.WriteLine(price); */


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
} */


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

/* int-array All elements in the array start with the value 0
string-array All elements in the array start with the value null
bool-array All elements in the array start with the value false  */

// String arrays
/* 
string[] stringArray = [
"This", "is", "an", "example", "of", "a", "String", "array"
];
for (int i = 0; i < stringArray.Length; i++) {
Console.Write(stringArray[i] + " ");
}
Console.WriteLine("");  */

// Traversing array
/* int[] months = [31,28,31,30,31,30,31,31,30,31,30,31];
for (int i=0 ; i<months.Length ; i++) {
Console.WriteLine("Month "+(i+1)+" has "+months[i]+" days");
} */

/*
double[] doubleArray = new double[12];
double total = 0;
double average;
int i;
// insert code to fill up doubleArray -> der skal skrives noget kodning her før det virker!
for (i=0; i<doubleArray.Length; i++) {
total += doubleArray[i];
}
average = total / doubleArray.Length; */


//Reference Manipulation
/* Leapyear
int[] monthsNormal = [31,28,31,30,31,30,31,31,30,31,30,31];
int[] monthsLeap = [31,29,31,30,31,30,31,31,30,31,30,31];
for (int i=0 ; i<2020 ; i++) {
either do this -> : int[] months = monthsNormal;
                    if (i%4==0){
                    months = monthsLeap;
or do this -> : int[] months = (i%4==0 ? monthsLeap : monthsNormal);
}
Console.WriteLine("In year "+i+" February is "+months[1]+
" days long");
} */


// Arrays of Arrays
// We have seen that we can declare arrays like this:
/* int[] ints = [1,2,3,4];
double[] doubles = [1.0,2.0,3.0,4.0];
bool[] bools = [false,true,false,true];

If you can make an array of any type, can you then also make an array of arrays?

Maybe do this?
int[][] arrayofarray = [[1,2,3,4], [2,3,4,5], [3,4,5,6], [4,5,6,7]];  */


/* Layout in Memory
int[][] arrayofarray = [
[1,2,3,4],
[2,3,4,5],
[3,4,5,6],
[4,5,6,7]
];
Console.WriteLine(arrayofarray[2]);
Console.WriteLine(arrayofarray[2][3]); */

/* Tables
int[][] array = new int[4][];
// code for filling out array -> udfyld for at run kan virke
array[3] = [43, -6, 17, 100, 1, -12];

intArray[3][2] */

/* Examples with profits in stores 
double[][] profit = new double[25][];
double totalProfit = 0; // total profit of last year
int store; // variable for looping through stores
int month; // variable for looping through months
// code for filling out profit
for ( store=0 ; store<25 ; store++ ) {
for ( month=0 ; month<12 ; month++ ) {
totalProfit += profit[store][month];
}
} */

/* Jagged Arrays --> All inner arrays do not have to have the same length
int[][] jagged = new int[4][]{
new int[1]{1},
new int[2]{2,3},
new int[3]{3,4,5},
new int[4]{4,5,6,7}
};
for (int y=0 ; y<jagged.Length ; y++) {
for (int x=0 ; x<jagged[0].Length ; x++) {
Console.WriteLine("jagged["+y+"]["+x+
"] = "+jagged[y][x]);
}
} */


// Multidimensional Arrays
/* Instead of arrays of arrays, one can often use multidimensional arrays.
They are not structured as an outer array with references to inner arrays.
Instead, the sizes of the dimensions are fixed, and this allows elements to be accessed
directly. */

/* Layout in Memory
int[,] marray = {
{1,2,3,4},
{2,3,4,5},
{3,4,5,6},
{4,5,6,7}
};
int[] array = {
1,2,3,4,
2,3,4,5,
3,4,5,6,
4,5,6,7
}; */

/* vs Arrays of Arrays
Multidimensional arrays compared to arrays of arrays:
I Lookup “costs” only one lookup in memory and is therefore faster.
Arrays of arrays compared to multidimensional arrays:
I Allows 2D structures that are not rectangular, and similar for 2+ dimensional
structures.
I Allows indices in the first dimension to refer to the same inner array (and thereby
save space).
Which implementation is best depends largely on the problem you are facing.
Often, it does not matter. */

// Structs
/* Colors
In a computer, colors are typically represented as three values:
1. Red intensity, 2. Green intensity, 3. Blue intensity
By mixing these values, any visible color can be represented
Each of these color components is usually divided into 256 levels. This can be
represented using a byte for each:
byte red;
byte green;
byte blue; */

/* Definition
Problem: Sometimes values belong together, and we want to work with them as if
they were a single value.
A struct is a structure of values, that lie next to each other in memory. In C# the kind
of structs (that we care about) are called “classes”.
Declaration:
class Color {
public byte red;
public byte green;
public byte blue;
} */

/* Example
Color magenta = new Color { red=255 , green=0 , blue=255 };
Console.WriteLine("red="+magenta.red+" green="+magenta.green+"blue="+magenta.blue);

// darken color
magenta.red /=2;
magenta.green /=2;
magenta.blue /=2;
Console.WriteLine("red="+magenta.red+" green="+magenta.green+"blue="+magenta.blue);
class Color {
    public byte red;
    public byte green;
    public byte blue;
} */


// Enums
/*
Let’s look at two primitive data types:
I A bool is a type that can represent the values true and false.
I A byte is a type that can represent the values 0, 1, 2, … 255.
With an enum we can define our own type by manually listing all possible values.
Example: A playing card’s suit:
enum Suit {
Spade,
Heart,
Diamond,
Club,
} */

/* Comparison
Enum values can be compared:
Suit suit = Suit.Heart;
if (suit == Suit.Diamond) {
Console.WriteLine("Suit is diamond!");
} else {
Console.WriteLine("Suit is not diamond :-(");
} */

/* Casting to Integers
Suit suit = Suit.Heart;
int suitInt = (int) suit;
Console.WriteLine(suitInt); */

/* Example
Color[] colors = new Color[(int) ColorName.Count];
colors[(int) ColorName.Red] = new Color { red=255 , green= 0 , blue= 0 };
colors[(int) ColorName.Green] = new Color { red= 0 , green=255 , blue= 0 };
colors[(int) ColorName.Magenta] = new Color { red=255 , green= 0 , blue=255 };
ColorName c = ColorName.Magenta;
Color color = colors[(int) c];
Console.WriteLine("red="+color.red+" green="+color.green+" blue="+color.blue);
enum ColorName {
    Red,
    Green,
    Magenta,
    Count,
}
class Color {
    public byte red;
    public byte green;
    public byte blue;
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
    public string name;
} */


// Exercise 7.3
/* The array's type is T[] — its element type T is part of the type itself, 
so int[] and string[] are different types, and the compiler only lets you store T (or subtypes of it) inside. */


// Exercise 7.5
/* You use square brackets [] with the size inside, in the new expression:
int[] numbers = new int[5];
The 5 inside [] tells the compiler how many elements to allocate space for */


// Exercise 7.7
/* A Sudoku puzzle is naturally a 9×9 grid, so the simplest representation is a 2D array:
int[,] sudoku = new int[9, 9];
sudoku[0, 0] = 5;
sudoku[3, 7] = 9;

Alternative: a jagged array (int[][]), which is an array of arrays:
int[][] sudoku = new int[9][];
for (int i = 0; i < 9; i++)
    sudoku[i] = new int[9];

Memory layout — the key difference:
int[,] (a true 2D/multidimensional array) is stored as one single contiguous block of memory 
— all 81 ints laid out row by row, back to back. 
This is generally faster to access because of cache locality.
Something like this*/


// Exercise 7.12
/* int[] normaldaysinyear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int[] leapyeardays = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

for (int year = 2000; year <= 2020; year++){
    int[] pointer;
    if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        pointer = leapyeardays;
    else
        pointer = normaldaysinyear;

    int totalDays = 0;
    foreach (int days in pointer){
        totalDays += days;
    }
    Console.WriteLine($"{year}: {totalDays} days");
} // "$" is a string interpolation, which we can use instead of putting "text" + "text" */


// Exercise 7.16 Directions
/* Console.Write("Write down the direction: ");
string input = Console.ReadLine();

direction valgtRetning = Enum.Parse<direction>(input);
// for the enum

if (valgtRetning == direction.South)
    Console.WriteLine("You are heading south!");
    else if (valgtRetning == direction.North){
        Console.WriteLine("You are heading north!");
    }
    else if (valgtRetning == direction.West){
        Console.WriteLine("You are heading west!");
    }
    else if (valgtRetning == direction.East){
        Console.WriteLine("You are heading east!");
    }
enum direction {North, East, South, West,}
// enum always at last */


// Exercise 7.14
/* Fik hjælp her, det var for svært.
int[,] sudoku = {
    { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
    { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
    { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
    { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
    { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
    { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
    { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
    { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
    { 3, 4, 5, 2, 8, 6, 1, 7, 9 },
};

bool isValid = CheckSudoku(sudoku);
Console.WriteLine(isValid ? "The sudoku is correctly solved!" : "The sudoku is NOT correctly solved.");

bool CheckSudoku(int[,] grid)
{
    // Check rows
    for (int row = 0; row < 9; row++)
    {
        bool[] found = new bool[9];
        for (int col = 0; col < 9; col++)
        {
            int value = grid[row, col];
            if (value == 0)
                return false; // empty cell

            found[value - 1] = true;
        }
        if (Array.IndexOf(found, false) != -1)
            return false; // a number 1-9 is missing in this row
    }

    // Check columns
    for (int col = 0; col < 9; col++)
    {
        bool[] found = new bool[9];
        for (int row = 0; row < 9; row++)
        {
            int value = grid[row, col];
            found[value - 1] = true;
        }
        if (Array.IndexOf(found, false) != -1)
            return false;
    }

    // Check 3x3 boxes
    for (int boxRow = 0; boxRow < 9; boxRow += 3)
    {
        for (int boxCol = 0; boxCol < 9; boxCol += 3)
        {
            bool[] found = new bool[9];
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    int value = grid[boxRow + r, boxCol + c];
                    found[value - 1] = true;
                }
            }
            if (Array.IndexOf(found, false) != -1)
                return false;
        }
    }
    
    return true;
} */

// Exercise 7.8 Area of a circle with using more proffesional items :b
/* double Area(double r){
    return Math.PI * r * r;
}
for (int r = 0; r < 10; r++)
{
    Console.WriteLine(Area(r));
    } */

    
// Lille hygge opgave inden PA1
/* Opgave: Ugentlig temperaturstatistik

Du har disse 7 temperaturer for en uge (brug dem som double[] eller lav dem selv):
18.5, 21.2, 19.8, 23.1, 25.6, 20.3, 17.9

Skriv et program der:
Gemmer temperaturerne i et array.
Finder og printer højeste og laveste temperatur i ugen (brug en for- eller foreach-loop, ikke en indbygget metode).
Beregner og printer gennemsnitstemperaturen.
Går igennem hver dag og printer, om det var en "varm dag" (over 22°C), "normal dag" (15–22°C) 
eller "kold dag" (under 15°C) — brug if/else if/else eller switch.
Bonus (hvis du har tid): brug en enum til at repræsentere ugedagene (Monday, Tuesday, ...) 
og print ugedagsnavnet sammen med temperaturen og kategorien, fx:
Monday: 18.5°C - Normal dag

Krav til stil:
Brug en funktion til gennemsnitsberegningen, fx double Average(double[] temps).
Brug string interpolation ($"...") til print.
Det her tester stort set det samme, som dine noter dækker (arrays, loops, betingelser, funktioner, evt. enum), 
bare i en anden kontekst end det du allerede har lavet, så du ikke bare genkender løsningen udenad. */

// del 1
/* double[] temps = {18.5, 21.2, 19.8, 23.1, 25.6, 20.3, 17.9};

// del 2
double highest = temps[0];
double lowest = temps[0];

for (int i = 1; i < temps.Length; i++){
    if (temps[i] > highest){
        highest = temps[i];
    }
    if (temps[i] < lowest){
        lowest = temps[i];
    }
}
Console.WriteLine($"Highest temperature: {highest}°C");
Console.WriteLine($"Lowest temperature: {lowest}°C");

// del 3
double Average(double[] temps){
    double total = 0;
    foreach (double temp in temps){
        total += temp;
    }
    return total / temps.Length;
}
Console.WriteLine($"Average temperature: {Average(temps)}°C");

// del 4
foreach (double temp in temps){ //brug temp, da temps er brugt og vil give error
    if (temp >= 22){
        Console.WriteLine($"{temp}°C - It is a warm day!");
    }
    else if (temp >= 15 && temp <= 22){
        Console.WriteLine($"{temp}°C - Today is the temperature normal!");
    }
    else{
        Console.WriteLine($"{temp}°C - It is a cold day!");
    }
}

// del 5
Day[] days = { Day.Monday, Day.Tuesday, Day.Wednesday, Day.Thursday, Day.Friday, Day.Saturday, Day.Sunday };

for (int i = 0; i < temps.Length; i++){
    string category;

    if (temps[i] > 22){
        category = "Varm dag";
    }
    else if (temps[i] >= 15){
        category = "Normal dag";
    }
    else{
        category = "Kold dag";
    }

    Console.WriteLine($"{days[i]}: {temps[i]}°C - {category}");
}
enum Day {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
} */
// der er lige noget jeg ikke kan fatte ved del 5 men synes ellers det gik fint.


// How to use switch (there is shown 3 ways)
/* int day = 7;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Some other day");
        break;
}

string name = day switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    _ => "Other"
};

string command = "start";
switch (command)
{
    case "start":
        Console.WriteLine("Starting...");
        break;
    case "stop":
        Console.WriteLine("Stopping...");
        break;
} */


// Point-givende Aktivitet V
/*
// This exercise is about finding the highest negative number using an array of integers

int[] numbers = [-5, 0, 13, 42, -19, -21]; // Making an array of numbers.

int max = numbers[0]; // Defining max with an integer, and give it a value, where the number 0 was chosen.

foreach (int number in numbers) // Using "foreach" because it has to go through every number
                                // and define which one is the number we are searching for.
                                // Defining the integer number in numbers.
{
        if (number < max) // Using "if" statement to tell the program 
                          // that if the number is smaller than max (where max is anything above 0)
                          // that it should give us that number.
        {
            max = number; // The number is now the new maximum
        }
}

Console.WriteLine(max); // At last we print out the highest negative value,
                        // where the number that will be printed is the number -21.
*/
// Point-givende Aktivitet ^


// Øvelsestime 21/09

// Exercise 5.4
/*
int i = 42;
long l = i;        // implicit — int always fits in a long
i = (int)l;         // explicit — long might not fit in an int

float f = 3.14f;
double d = f;       // implicit — float always fits in a double
f = (float)d;        // explicit — double might not fit in a float
*/


// Exercise 5.12
/*
for (double i = 1; i <= 12; i += 0.5)
{
    switch (i)
    {
        case 1: Console.WriteLine("January"); break;
        case 2: Console.WriteLine("February"); break;
        case 3: Console.WriteLine("March"); break;
        case 4: Console.WriteLine("April"); break;
        case 5: Console.WriteLine("May"); break;
        case 6: Console.WriteLine("June"); break;
        case 7: Console.WriteLine("July"); break;
        case 8: Console.WriteLine("August"); break;
        case 9: Console.WriteLine("September"); break;
        case 10: Console.WriteLine("October"); break;
        case 11: Console.WriteLine("November"); break;
        case 12: Console.WriteLine("December"); break;
        default: Console.WriteLine("In the middle of the month: " + i); break;
    }
}
*/


// Exercise 5.19
/* 
double price = 599.95;
double budget = 1000.0;
bool requiredReading = true;
bool shouldBuy = price < budget && requiredReading; 
*/ 
// idk what is this focused on (må løse den senere)


// Exercise 5.21
/* 
int b = a + 1;
Does this mean that a is an integer?
- yes because if b = a + 1 that means still that b has to be a full number that makes a also be an integer
Would the code compile if a is a non-numeric datatype?
- idfk
Would the code compile if a is a numeric datatype other than int? Which ones?
- anything that is a full number 
*/


// Exercise 6.1
//senere

// Exercise 7.6
/*
int size = 30;
int[] table = new int[size];

for (int n = 0; n < size; n++)
{
    table[n] = 3 * n;
}

for (int n = 0; n < size; n++)
{
    Console.WriteLine(table[n]);
}
*/


// Exercise 7.13
//holy shit spring det her over


// Exercise 7.17
/*
double meters = 1.234;
Unit unit = Unit.mm;

double factor = unit switch
{
    Unit.m => 1,
    Unit.cm => 100,
    Unit.mm => 1000,
    Unit.inch => 1 / 0.0254
};

Console.WriteLine(meters * factor + " " + unit);

enum Unit { m, cm, mm, inch }
*/


// Forelæsning 23/09
// Its about "return" statement


// Linæer funktioner
/*
double f (double x) {
return 2*x-1;
}
for (double x=-3 ; x<=3 ; x+=0.5) {
double y = f(x);
Console.WriteLine("f("+x+") = "+y);
}
*/

// Area of a rectangle
/*
int area (int w, int h) {
return w*h;
}
for (int h=0 ; h<=4 ; h+=1) {
for (int w=0 ; w<=8 ; w+=1) {
int a = area(w, h);
Console.Write(" {0,2}", a);
}
Console.WriteLine("");
}
*/



// Exercises 23/09

// Exercise 8.4
/*
int result = Sum(3, 5);
Console.WriteLine($"3 + 5 = {result}");

int Sum(int a, int b)
{
    return a + b;
}
*/

// Exercise 8.3
/*
int[][] puzzle = {
new int[] {7, 3, 6, 4, 5, 2, 9, 8, 1},
new int[] {1, 9, 8, 6, 3, 7, 4, 5, 2},
new int[] {4, 2, 5, 9, 8, 1, 3, 7, 6},
new int[] {3, 6, 4, 5, 2, 8, 1, 9, 7},
new int[] {9, 5, 2, 7, 1, 4, 6, 3, 8},
new int[] {8, 1, 7, 3, 9, 6, 2, 4, 5},
new int[] {2, 8, 9, 1, 7, 3, 5, 6, 4},
new int[] {6, 7, 3, 2, 4, 5, 8, 1, 9},
new int[] {5, 4, 1, 8, 6, 9, 7, 2, 3},
};
*/