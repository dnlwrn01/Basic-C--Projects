# C#/ASP.NET Projects
*Developed for educational purposes*
## Overview
These are Python and Django Projects/Applications. This repository covers python fundamentals, a few projects, and an MVT application. Explore the code below:

---
### Basics
- [Hello World](#hello-world)
- [String Concatenation](#string-concatenation)
- [Lambda Functions](#lambda-functions)
- [Method Inheritance](#method-inheritance)
- [Loops and Arrays](#loops-and-arrays)
- *many more are shown in repo.*

### Projects
-  [Console Apps](#console-apps)
-  [Car Insurance](#car-insurance)
-  [Newsletter MVC](#newsletter-mvc)
-  [Students MVC](#students-mvc)
-  [Twenty One Game](#twenty-one-game)

---

### Hello World
```c#
namespace HelloWorld
{
class Program
{
static void Main()
{
Console.WriteLine("Welcome to Acme Accounting Systems \nRemember, we're \"accounting\" on you!");
Console.Read();
}
}
}
```
### String Concatenation
```c#
namespace String_Concatenation
{
class Program
{
static void Main(string[] args)
{
//inputs
Console.WriteLine("What is your first name?");
string fName = Console.ReadLine();
Console.WriteLine("What is your middle name?");
string mName = Console.ReadLine();
Console.WriteLine("What is your last name?");
string lName = Console.ReadLine();
Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is your favorite hobby? (1/3)");
StringBuilder bio = new StringBuilder(Console.ReadLine() + ", ");
Console.WriteLine("What is your favorite hobby? (2/3)");
bio.Append(Console.ReadLine() + ", ");
Console.WriteLine("What is your favorite hobby? (3/3)");
bio.Append("& " + Console.ReadLine() + ".");
//string manipulation
string fullName = (fName + " " + mName + " " + lName);
string initials = fName.Substring(0, 1) + lName.Substring(0, 1);
initials = initials.ToUpper();
//display results
Console.WriteLine("\n\nName: " + fullName + "\nInitials: " + initials + "\nAge:" + age + "\nHobbies Include: " + bio);
Console.Read();
}
}
}
```
### Lambda Functions
```c#
namespace LambdaFunctions
{
class Program
{
static void Main(string[] args)
{
//declare new list
List<Employee> employee= new List<Employee>();
//add objects
employee.Add( new Employee("Dan", "Smith", 1) );
employee.Add( new Employee("Shelly", "Jones", 2) );
employee.Add( new Employee("Joe", "Davis", 3) );
employee.Add( new Employee("Wanda", "Thomas", 4) );
employee.Add( new Employee("Kevin", "Kennedy", 5) );
employee.Add( new Employee("Jan", "Obama", 6) );
employee.Add( new Employee("Jackie", "Biden", 7) );
employee.Add( new Employee("Joe", "Stevenson", 8) );
employee.Add( new Employee("Amy", "Lincoln", 9) );
employee.Add( new Employee("Mike", "Jefferson", 10) );

//list of joes
List<Employee> joes = new List<Employee>();
//add employees named joe to new list

foreach ( Employee i in employee )
{
if (i.fName == "Joe")
{
joes.Add(i);
}
}
//display each joe from joes list
foreach (Employee joe in joes)
{
Console.WriteLine(joe.fName + " " + joe.lName + " " + joe.empID);
}

//list of joes2
List<Employee> joesList = employee.Where(x => x.fName == "Joe").ToList();
joesList.ForEach(n => Console.WriteLine(n.fName + " " + n.lName + " " + n.empID));
Console.WriteLine(joesList.Count());

//list of empID's over 5
//list of joes2
List<Employee> higherClearance = employee.Where(x => x.empID > 5).ToList();
higherClearance.ForEach(n => Console.WriteLine(n.fName + " " + n.lName + " " + n.empID));
Console.WriteLine(higherClearance.Count());
Console.Read();
}
}
}
```
### Method Inheritance
```c#
namespace MethodInheritance
{
class Program
{
static void Main(string[] args)
{
Employee employee = new Employee();
employee.FirstName = "Sample";
employee.LastName = "Student";
employee.SayName();
Console.Read();
}
}
}
```
```c#
namespace MethodInheritance
{
class Employee : Person
{
public int ID { get; set; }
}
}
```
```c#
namespace MethodInheritance
{
class Person
{
public string FirstName { get; set; }
public string LastName { get; set; }
public void SayName()
{
Console.WriteLine("Name: " + FirstName + " " + LastName);
}
}
}
```
### Loops and Arrays
```c#

```
### Console Apps
```c#
namespace DailyReport
{
class Program
{
static void Main()
{
Console.WriteLine("The Tech Academy");
Console.WriteLine("--Submit Daily Report--");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("What course are you on?");
string course = Console.ReadLine();
Console.WriteLine("What page number?");
int pageNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Do you need help with anything? Please answer with \"true\" or \"false\".");
bool help = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
string experience = Console.ReadLine();
Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
string feedback = Console.ReadLine();
Console.WriteLine("How many hours did you study today?");
string hoursStudied = Console.ReadLine();
Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
Console.WriteLine("\n\n--RESULTS--");
Console.WriteLine(name + "\n" + course + "\n" + pageNum + "\n" + help + "\n" + experience + "\n" + feedback + "\n" + hoursStudied);
Console.Read();
}
}
}
```
```c#
namespace ShippingQuote
{
class Program
{
static void Main()
{
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
Console.WriteLine("Please enter the weight of the package:");
decimal packageWeight = Convert.ToDecimal(Console.ReadLine());
if (packageWeight > 50)
{
Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
}
else
{
//get dimentions
Console.WriteLine("Please enter the width of the package:");
decimal packageWidth = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Please enter the height of the package:");
decimal packageHeight = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Please enter the length of the package:");
decimal packageLength = Convert.ToDecimal(Console.ReadLine());
decimal dementionsSum = packageWidth + packageHeight + packageLength;
if (dementionsSum > 50)
{
Console.WriteLine("Package too big to be shipped via Package Express.");
}
else
{
decimal dementionsTotal = packageWidth * packageHeight * packageLength;
decimal quoteTotal = (dementionsTotal * packageWeight) / 100;
Console.WriteLine("Your estimated total shipping cost is: $" + quoteTotal + "! \nThank You!");
Console.Read();
}
}
Console.Read();
}
}
}
```
### Car Insurance
```c#
//program intro
Console.WriteLine("Welcome to [Car Insurance Company Here]");
Console.WriteLine("Check your coverage now!");
```
```c#
//user input
Console.WriteLine("\nWhat is your age?");
int userAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Have you ever had a DUI or OWI? [Enter \"True\" or \"False\"]");
bool DUI = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("How many speeding tickets do you have?");
int speedingTicket = Convert.ToInt32(Console.ReadLine());
```
```c#
//check
bool qualifies = ((userAge > 15) && (DUI == false) && (speedingTicket < 3));
```
```c#
//display result if user qualifies for insurance
if (qualifies)
{
Console.WriteLine("Congradulations! You have been approved. Our team will contact you soon for more pricing information.");
}
else
{
Console.WriteLine("Unfortunately, you could not be approved at this time. If you believe this is a mistake, please call our offices.");
}
```
```c#
//run again
Console.WriteLine("Would you like to check coverage for another driver? \n[Enter \"Y\" / \"y\" or \"N\" / \"n\"]");
string newEnrty = Console.ReadLine();
if ((newEnrty == "Y") || (newEnrty == "y"))
{
runAgain = true;
}
else if ((newEnrty == "N") || (newEnrty == "n"))
{
runAgain = false;
}
else
{
Console.WriteLine("Please try again later.");
}
```
### Newsletter MVC
```c#
// Home Controller 
namespace NewsletterAppMVC.Controllers
{
public class HomeController : Controller
{

public ActionResult Index()
{
return View();
}

public ActionResult About()
{
ViewBag.Message = "Your application description page.";
return View();
}

public ActionResult Contact()
{
ViewBag.Message = "Your contact page.";
return View();
}
}
}
```
### Students MVC
```c#
// program.cs
namespace StudentsApp
{
public class Program
{
public static void Main(string[] args)
{
CreateHostBuilder(args).Build().Run();
using (var ctx = new SchoolContext())
{
var stud = new Student() { StudentName = "Bill" };
ctx.Students.Add(stud);
ctx.SaveChanges();
}
}
public class SchoolContext : DbContext
{
public SchoolContext():base()
{
}
public DbSet<Student> Students { get; set; }
public DbSet<Grade> Grades { get; set; }
}
public class Student
{
public int StudentID { get; set; }
public string StudentName { get; set; }
public DateTime? DateOfBirth { get; set; }
public byte[] Photo { get; set; }
public decimal Height { get; set; }
public float Weight { get; set; }
public Grade Grade { get; set; }
}
public class Grade
{
public int GradeID { get; set; }
public string GradeName { get; set; }
public string Section { get; set; }
public ICollection<Student> Students { get; set; }
}

public static IHostBuilder CreateHostBuilder(string[] args) =>
Host.CreateDefaultBuilder(args)
.ConfigureWebHostDefaults(webBuilder =>
{
webBuilder.UseStartup<Startup>();
});
}
}
```
### Twenty One Game
```c#
// Game Class
namespace Casino
{
public abstract class Game
{
private List<Player> _players = new List<Player>();
private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
public List<Player> Players { get { return _players; } set { _players = value; } }
public string Name { get; set; }
public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
public abstract void Play();
public virtual void ListPlayers()
{
foreach (Player player in Players)
{
Console.WriteLine(player.Name);
}
}
}
}
```
```c#
// Deck Class
namespace Casino
{
public class Deck
{
public Deck()
{
Cards = new List<Card>();
for (int i = 0; i < 13; i++)
{
for (int j = 0; j < 4; j++)
{
Card card = new Card();
card.Face = (Face)i;
card.Suit = (Suit)j;
Cards.Add(card);
}
}
//List<string> Suits = new List<string>() { "Clubs", "Hearts", "Dimonds", "Spades" };
//List<string> Faces = new List<string>()
//{
// "Two", "Three", "Four", "Five", "Six", "Seven",
// "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
//};
//foreach (string face in Faces)
//{
// foreach (string suit in Suits)
// {
// Card card = new Card();
// card.Suit = suit;
// card.Face = face;
// Cards.Add(card);
// }
//}
}

public List<Card> Cards { get; set; }
public void Shuffle(int times = 1)
{
for (int i = 0; i < times; i++)
{

List<Card> TempList = new List<Card>();
Random random = new Random();
while (Cards.Count > 0)
{

int randomIndex = random.Next(0, Cards.Count);
TempList.Add(Cards[randomIndex]);
Cards.RemoveAt(randomIndex);
}

this.Cards = TempList;
}
}
}
}
```
```c#
// Dealer Class
namespace Casino.TwentyOne
{
public class TwentyOneDealer : Dealer
{
private List<Card> _hand = new List<Card>();
public List<Card> Hand { get { return _hand; } set { _hand = value; } }
public bool Stay { get; set; }
public bool isBusted { get; set; }
}
}
```
