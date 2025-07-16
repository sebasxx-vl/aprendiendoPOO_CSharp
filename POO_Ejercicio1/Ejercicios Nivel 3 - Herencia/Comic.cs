using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book
{
    protected string title;

    public Book(string title)
    {
        this.title = title;
    }

    public void ShowTitle()
    {
        Console.WriteLine($"The book is {title}");
    }
}

public class Comic : Book
{
    private string Gender;
    public Comic(string title, string Gender) : base(title) 
    {
        this.Gender = Gender;
    }

    public void ShowGender()
    {
        Console.WriteLine($"The gender is {Gender}");
    }
}

