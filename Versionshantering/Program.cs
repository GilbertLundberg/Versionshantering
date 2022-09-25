string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };
string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };
string className = "Klass 2022";

WebsiteGenerator website = new WebsiteGenerator(className, messagesToClass, techniques);
Console.WriteLine("Printing Website...\n");
website.PrintPage();
Console.WriteLine("Website printed successfully!");

class WebsiteGenerator
{
    private string[] techniques;
    private string[] messageToClass;
    private string className;

    public WebsiteGenerator(string className, string[] messageToClass, string[] techniques)
    {
        this.className = className;
        this.messageToClass = messageToClass;
        this.techniques = techniques;
    }

    public void PrintPage()
    {
        PrintStart();
        PrintHeader();
        PrintCourses();
        PrintEnd();
    }


    void PrintStart()
    {
        string start = "<!DOCTYPE html>\n<html>\n<body>\n<main>\n";
        Console.WriteLine(start);
    }

    private void PrintHeader()
    {
        Console.WriteLine($"<h1>Välkomna {this.className}</h1>");
        foreach (string msg in this.messageToClass)
        {
            Console.WriteLine($"<p><b>Meddelande: </b>{msg}</p>");
        }
    }

    void PrintCourses()
    {
        string kurser = CourseGenerator(this.techniques);
        Console.WriteLine(kurser);
    }


    private void PrintEnd()
    {
        string end = "</main>\n</body>\n</html>";
        Console.WriteLine(end);
    }

    string CourseGenerator(string[] techniques)
    {
        string kurser = "";

        foreach (string technique in techniques)
        {
            string tmp = technique.Trim();
            kurser += "<p>" + tmp[0].ToString().ToUpper() + tmp.Substring(1).ToLower() + "</p>\n";
        }

        return kurser;
    }
}