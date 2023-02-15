List<Person> people = new List<Person>();

var person1 = new Person();
person1.Name = "Richard";
person1.PhoneNumbers.Add(new PhoneNumber {Number = "173 123 456 78"});
person1.PhoneNumbers.Add(new PhoneNumber {Number = "173 456 456 78" });
person1.PhoneNumbers.Add(new PhoneNumber {Number = "173 789 456 78" });
people.Add(person1);

var person2 = new Person();
person2.Name = "Linda";
person2.PhoneNumbers.Add(new PhoneNumber { Number = "273 123 456 78" });
person2.PhoneNumbers.Add(new PhoneNumber { Number = "273 456 456 78" });
people.Add(person2);

// Select gets a list of lists of phone numbers
// List 1 - with 3 telnum
// List 2 - with 2 telnum
IEnumerable<IEnumerable<PhoneNumber>> phoneLists = people.Select(p => p.PhoneNumbers);

// SelectMany "flattens" it to just ONE list of phone numbers.
// List 1 - returns 1 list with 5 telnum
IEnumerable<PhoneNumber> phoneNumbers = people.SelectMany(p => p.PhoneNumbers);


// Set breakpoint here!!!
// Set breakpoint here!!!
// Set breakpoint here!!!
// Set breakpoint here!!!
Console.WriteLine("Hello, World!");

public class PhoneNumber
{
    public string Number { get; set; }
}

public class Person
{
    public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
    public string Name { get; set; }
}


