namespace FluentBuilderPatternPersonEmployee;

public class EmployeeBuilder(Employee? employee = null) : PersonBuilder(employee ?? new Employee())
{
    public void SetCompany(string company) => ((Employee)this.Person).Company = company;
    public void SetSalary(int salary) => ((Employee)this.Person).Salary = salary;
}

public static class EmployeeBuilderExt
{
    public static T Company<T>(this T builder, string company)
        where T : EmployeeBuilder
    {
        builder.SetCompany(company);
        return builder;
    }

    public static T Salary<T>(this T builder, int salary)
        where T : EmployeeBuilder
    {
        builder.SetSalary(salary);
        return builder;
    }
}
