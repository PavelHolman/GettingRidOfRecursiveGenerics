namespace FluentBuilderPatternPersonEmployee;

public class PersonBuilder
{
    protected readonly Person Person = new();
    public void SetName(string name) => this.Person.Name = name;
    public void SetAge(int age) => this.Person.Age = age;
    public void SetIsMale(bool isMale) => this.Person.IsMale = isMale;

    public Person Build() => this.Person;
}

public static class PersonBuilderExt
{
    public static T Name<T>(this T builder, string name)
        where T : PersonBuilder
    {
        builder.SetName(name);
        return builder;
    }

    public static T Age<T>(this T builder, int age)
        where T : PersonBuilder
    {
        builder.SetAge(age);
        return builder;
    }

    public static T IsMale<T>(this T builder, bool isMale)
        where T : PersonBuilder
    {
        builder.SetIsMale(isMale);
        return builder;
    }
}
