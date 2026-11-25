
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }

    public void Input()
    {
        do
        {
            Console.Write("Nhap ma hoc sinh: ");
            Id = int.Parse(Console.ReadLine()!);
        }
        while (Id <= 0);

        Console.Write("Nhap ten hoc sinh: ");
        Name = Console.ReadLine()!;
        do
        {
            Console.Write("Nhap tuoi: ");
            Age = int.Parse(Console.ReadLine()!);
        }
        while (Age <= 0);

    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        Console.Write("Nhap so luong hoc sinh (toi thieu 5): ");
        int n = int.Parse(Console.ReadLine()!);

        while (n < 5)
        {
            Console.Write("Nhap lai (n >= 5): ");
            n = int.Parse(Console.ReadLine()!);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap hoc sinh thu {i + 1}:");
            Student s = new Student();
            s.Input();
            students.Add(s);
        }
        Console.WriteLine("In ra danh sach toan bo hoc sinh:");
        foreach (var s in students)
            Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");
        Console.WriteLine("In ra danh sach hoc sinh tu 15 den 18:");
        foreach (var s in students.Where(s => s.Age >= 15 && s.Age <= 18))
            Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");
        Console.WriteLine("In ra danh sach hoc sinh ten bat dau bang chu A:");
        foreach (var s in students.Where(s => s.Name.StartsWith("A")))
            Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");
      
        Console.WriteLine($"Tong tuoi: {students.Sum(s => s.Age)}");
        Console.WriteLine("In ra hoc sinh co tuoi lon nhat:");
        int maxAge = students.Max(s => s.Age);
        foreach (var s in students.Where(s => s.Age == maxAge))
            Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");
        Console.WriteLine("In ra danh sach hoc sinh co tuoi tu nho den lon");
        foreach (var s in students.OrderBy(s => s.Age))
            Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");

    }
}
