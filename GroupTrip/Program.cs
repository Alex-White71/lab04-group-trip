/*
* Name: Alex White
* Course: CSCI 1250, Section 002
* Assignment: Lab 04, The Group Trip
* Date: October 7, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
* reports on a whole group instead of one person.
*/
// Declare constant variables needed later in the program

const double TAX_RATE = .18;
const int NUMBERS_OF_SLICES = 8;

// Ask the user questions about the trip and pizzas

Console.Write("How many miles is the trip both ways? ");
double miles = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the miles per gallon of the car during the trip? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How much is the Price per gallon of gas? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas are needed? ");
int pizzaCount = Convert.ToInt32(Console.ReadLine());

Console.Write("How much does a pizza cost? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

// Displays the fuel cost, pizza cost, and the trip total 

Console.WriteLine("=== Part 1: The Trip ===");

double fuelCostTotal = FuelCost(miles, milesPerGallon, pricePerGallon);
Console.WriteLine("Fuel Cost: " + fuelCostTotal.ToString("C"));

double pizzaCostTotal = pizzaCount * pricePerPizza;
Console.WriteLine("Pizza Cost: " + pizzaCostTotal.ToString("C"));

double tripTotal = fuelCostTotal + pizzaCostTotal;
Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine();

// calculates the fuel cost

static double FuelCost (double miles, double milesPerGallon, double pricePerGallon)
{
    double gallonsNeeded = miles/milesPerGallon;
    return gallonsNeeded * pricePerGallon;
    
}

// calculates the take home pay

static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double grossPay = hourlyRate * hours;
    double taxWithheld = grossPay * taxRate;
    return grossPay - taxWithheld;
}

// calculates the hours to cover needed for the trip
static double HoursToCover(double amountOwed, double takeHomePerHour)
{
  return amountOwed/takeHomePerHour;
}