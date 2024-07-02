using System;
using System.ComponentModel;
using System.Security.Cryptography;


class Person{

    private string? name; //for making those nullable
    private int? age; //for making those nullable


    // traditional ways of setter and getter

    public void SetName(string nam){
        name = nam;
    }

    public void SetAge(int agee){
        age = agee;
    }

    public void DisplayInfo(){
        Console.WriteLine($"Name is {name} and age is {age}");
    }


}


// Another person class to see the differet version of getter and setter
class AnotherPerson{

    private string name;
    private int age;


    // creating accessors

    // getter
    public string Name{
        get{
            return name;
        }
        set{
            name = value;
        }
    }

    public int Age{
        get{
            return age;
        }
        set{
            if(value > 25){
                age = value;
            }
            
        }

    }

}



class MainClass{

    // main Method
    public static void Main(string[] args){

        Person p1 = new Person();

        p1.SetName("Ashik");
        p1.SetAge(39);

        p1.DisplayInfo();

        // object for new AnotherPerson Class
        AnotherPerson ap1 = new AnotherPerson();
        ap1.Name = "Ashik";
        ap1.Age = 22;

        Console.WriteLine($"Another person name is {ap1.Name} and age is {ap1.Age}");




       
    }

}




