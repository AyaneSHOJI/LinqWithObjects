using static System.Console;

// a string array is a sequence that implements IEnumerable<string>
string[] names = new string[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };

WriteLine("Deferred execution");

// Question: Which names end with an M?

// LINQ extension method
var query1 = names.Where(name => name.EndsWith("m"));
// LINQ query comprehension syntax
var query2 = from name in names where name.EndsWith("m") select name;

string[] result1 = query1.ToArray(); 
List<string> result2 = query2.ToList(); 

foreach(string name in query1)
{
    WriteLine(name); // output Pam
    names[2] = "Jimmy"; //change Jim to Jimmy
    // on the second iteration Jimmy does not end with an M
}

// First example of NameLongerThanFour method 
//var query = names.Where(
//    new Func<string, bool>(NameLongerThanFour));

// Second example of NameLongerThanFour method 
//var query = names.Where(NameLongerThanFour);

// SIMPLEST and Third example of NameLongerThanFour method 
var query = names
    .Where(name => name.Length > 4)
    .OrderBy(name => name.Length);

    foreach(string item in query)
{
    WriteLine(item);
}

static bool NameLongerThanFour(string name)
{
    return name.Length > 4;
}

