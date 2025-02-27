// See https://aka.ms/new-console-template for more information
using PetSound;

//here instance of type Animal , which will called overrided method in dog class
Animal sound = new Dog();
Console.WriteLine(sound.speak((short)0));

//here instance of type Dog so it will called second speak method which doesn't OVERRIDE keyword
Dog dogsound = new Dog();
Console.WriteLine(dogsound.speak(0));
