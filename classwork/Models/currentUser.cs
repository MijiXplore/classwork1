using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication8.Models
{
    public class currentUser
    {
        public static string? name { get; set; }
        public static string? email { get; set; }
        public static string? role { get; set; }


    }

//    public interface run()
//{

//        Console.WriteLine("Running...");
//        return 0;

//}

//public class john : currentUser
//{
//    public static string? alias { get; set; }

//}



}



//inheritance : new object creation that will have inherited properties from a different class(es)

//1. inheritance -to inherit properties and methods from parent class to child class
//// *inherits properties and methods from parent class


//ex. 

//john obj1 = new john();
//obj1.run(); //running 
//obj1.email = "obj1@gmail.com"

// "sealed" to prevent inheritance 
// e.g. public sealed class currentuser
//sealed - used when we don't want other classes to inherit from a class

/* 2. Polymorphism: the ability of the code exists in many forms 
 * it occurs when we have multiple classes that are related to each other by inheritance 
 * 
 *  *  * 
 *  
 *  
 *  
 *  
 public class currentUser
    {
        public static string? name { get; set; }
        public static string? email { get; set; }
        public static string? role { get; set; }


  

public virtual interface run()
{

        Console.WriteLine("Running at x speed...");
        return 0;

}


}

public class john : currentUser
{
   public static string? alias { get; set; }

  public overrride interface run()                          //override gives priority
{

        Console.WriteLine("Running at y speed...");
        return 0;

}


}

//john obj1 = new john();
//obj1.run(); //running 


case 1: one without virtual or override
//john obj1 = new john();
//obj1.run(); //running at x

case 2: with virtual and override 

//john obj1 = new john();
//obj1.run(); //running at y

Why to use inheritance and polymorphism?: code reusability (of fields and methods) 



3. Abstraction: 

Abstraction the process of hiding certain details and showing only required properties and methods to the user 

*Abstraction can be achieved with either abstract classes or interfaces 
*To use abstraction we need to use the keyword abstract (if implementing is done via classes) 
*abstract keyword is used for both classes and methods 
*a. Abstract class: a restricted class that cannot be used to create objects
*
*
*
ex: currentUser obj1 = new currentUser();    //throws an error if currentUser is an abstract class
*
*
*
*b. Abstract method: It can only be used inside an abstract class.
*It doesn't have a body in the parent class.
*The body is provided in the child class. 
*
*e.g. 
[in an abstract parent class]
public abstract int run();  <-- no body logic



[then in child class:]   <---in order to call the method again

public override int run(){

[it has a body]

}

why use abstract classes and methods: 
*to achieve security by hiding certails and only show relevant details for some developers to work with





4. interfaces: 
*another way to achieve abstraction
*
*what is it?: 
*It is a completely abstract class. But can only contain 
*abstract methods and properties

function eat() { // code }
function abstract eat (); 

public int i = 10;  --> works but must be public


these types of variables can't be used in a interface:
int i {get; set;}   <--- doesnt work cuz it means int i { if method == get, then return i, if method ==set, then update i}

interface User{
    abstract methods and properties

} 

abstract class -- > can have both abstract methods and non-abstract methods
but interface --> only abstract methods and properties but not fields 


naming convention: IName but the I not required just suggested
ex: interface Iuser {
    void run ();
    void eat();

}

**important: if parent and child are both classes, then it inherits
*
* if parent is interface and child is class, then it implements

class Admin : IUser {

    public void run(){
                 //console.write (...) any code   
                }

}

Few things to note... 
* - interfaces cannot be used to create objects 
* e.g. 
* 
*  IUser obj1 = new Iuser(); does not work 
*  
*  - interface methods cannot have a body 
*  - to implement the abstract methods inside interface, we have to override,
*  however the override word is NOT required in the declaration. 
* - interface members (prop + methods) are by default public and abstract 
* - interface cannot contain a constructor
* - why use interface? a. to achieve security, i.e. hide certain details 
* b. We cannot achieve multiple inheritance using classes, 
*   but we can achieve this using interfaces 
*   
*   
*   Example for b: 
*   
*   class A { //code //run() } 
*   
*   Class B { //code //eat()} 
*   
*   Class C: A, B               <-- cannot do with classes alone (multiple inheritances)
*   { //code } 
*     
*     - to achieve it we can use multiple interfaces:
*     
*     interface IA {//abstract run()}
*     interface IB { //abstract eat ()}
*     
*     class C : IA, IB {
*       run(){//code}
*       eat(){//code}
*     }
*     

*/