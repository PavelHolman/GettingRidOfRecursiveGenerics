using FluentBuilderPattern;
using Newtonsoft.Json.Linq;

var employee1 = new EmployeeBuilder()
    .WorksAt("Google")
    .Salary(60000)
    .Name("Alex")
    .Age(27)
    .IsMale(true)
    .Build();

var employee2 = new EmployeeBuilder()
    .Name("Bob")
    .WorksAt("Microsoft")
    .Age(55)
    .Salary(10)
    .IsMale(true)
    .Build();

var employee3 = new EmployeeBuilder()
    .Name("Alice")
    .WorksAt("Apple")
    .Salary(69420)
    .Age(29)
    .IsMale(false)
    .Build();

var person = new PersonBuilder()
    .Name("Benedict")
    // .WorksAt("") // Compile Error
    .Age(18)
    // .Salary(-42) // Compile Error
    .IsMale(true)
    .Build();

Console.WriteLine(JObject.FromObject(employee1));
Console.WriteLine(JObject.FromObject(employee2));
Console.WriteLine(JObject.FromObject(employee3));
Console.WriteLine(JObject.FromObject(person));
