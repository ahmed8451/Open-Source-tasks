using System;
// comment out the
/* comment */
namespace Oop;
public abstract class Person{
    public string Name;
    public int Age;
    
    public Person(string name, int age){
        Name = name;
        Age = age;
    }
        public abstract void Print();
}
public class Student : Person{
    public int Year;
    public float Gpa;
    public Student(string name, int age, int year, float gpa) : base(name, age) 
    { 
        Year = year;
        Gpa = gpa;
    }
    public override void Print() {
        Console.WriteLine
        ($"Name: {Name}, Age: {Age}, Gpa: {Gpa}");
    }
}
public class Database{
    private int _currentIndex;
    public Person[] People = new Person[50];
    public void AddStudent(Student student) {
        People[_currentIndex++] = student;
    }
}

public class Program{
    private static void Main(){
        var database = new Database();
        Console.Write("Name: ");
        var name = Console.ReadLine();
        Console.Write("Age: ");
        var age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Year: ");
        var year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Gpa: ");
        var gpa = Convert.ToInt32(Console.ReadLine());
        var student = new Student(name, age, year, gpa);
        database.AddStudent(student);
    }
}