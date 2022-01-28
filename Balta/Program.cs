// See https://aka.ms/new-console-template for more information
using Balta.ContentContext;
using Balta.SubscriptionContext;

Console.WriteLine("Hello, World!");

var articles = new List<Article>();

articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "chsarp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

foreach (var article in articles)
{
    System.Console.WriteLine(article.Id);
    System.Console.WriteLine(article.Title);
    System.Console.WriteLine(article.Url);
}

var courses = new List<Course>();

var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

var careers = new List<Career>();

var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");

var careerItem = new CareerItem(1, "Começe por aqui", "", courseCsharp);
var careerItem2 = new CareerItem(2, "Aprenda OOP ", "", courseOOP);
var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
var careerItem4 = new CareerItem(3, "Aprenda .NET", "", null);

careerDotnet.Items.Add(careerItem2);
careerDotnet.Items.Add(careerItem);
careerDotnet.Items.Add(careerItem3);
careerDotnet.Items.Add(careerItem4);

careers.Add(careerDotnet);

foreach (var career in careers)
{
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.Level);

        foreach (var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }
}

var student = new Student();
var payPalSubscription = new PayPalSubscription();

student.CreateSubscription(payPalSubscription);
