using System;
using System.ComponentModel;
using System.Security.Cryptography;


class Person{
    
    public string name; //readable and writable

    private int age; // not readable not writable

    //we can make it readable and writable both 
    // using setter function we can make it writable
    // using getter function we can make it readble

    public void Setter(int a){
        age = a;
    }

    public int Getter(){
        return age;
    }


}

class MainClass{

    // main Method
    public static void Main(string[] args){
     
        Person p1 = new Person();

        p1.name = "Ashik";
        p1.Setter(29);

        Console.WriteLine(p1.Getter());
       
    }

}




