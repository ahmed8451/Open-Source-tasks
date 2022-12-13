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
    public Student(string name, int age, int Year, float Gpa) : base(name, age) 
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