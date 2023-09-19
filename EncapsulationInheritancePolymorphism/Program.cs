using EncapsulationInheritancePolymorphism.Encapsulation;
using EncapsulationInheritancePolymorphism.Inheritance;
using EncapsulationInheritancePolymorphism.Polymorphism;

namespace EncapsulationInheritancePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            PersonHandler handler = new PersonHandler();
            Person newPerson;
            try
            {
                newPerson = handler.CreatePerson(22, "Jane", "Doe", 165, 45);
                Console.WriteLine($"First Name: {handler.GetFName(newPerson)}\nLast Name: {handler.GetLName(newPerson)}\nAge: {handler.GetAge(newPerson)}\nHeight: {handler.GetHeight(newPerson)}\nWeight: {handler.GetWeight(newPerson)}");
            } catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new AgeInputError());
            errors.Add(new PhoneNumberInputError());
            errors.Add(new EmailAddressInputError());

            foreach (UserError error in errors) 
            {
                Console.WriteLine(error.UEMessage());
            }

            List<Animal> animals = new List<Animal>();
            animals.Add(new Bird("Duck", 1.6, 4, 116));
            animals.Add(new Dog("Eurasier", 30, 3, false));
            animals.Add(new Flamingo("Greater flamingo", 2, 30, 165, true));
            animals.Add(new Hedgehog("Long-Eared Hedgehog.", 1, 2, 5000));
            animals.Add(new Horse("Camarillo.", 1000, 25, 2.47));
            animals.Add(new Swan("Black swan.", 12, 7, 2, "Mute Swan"));
            animals.Add(new Wolf("Mongolian Wolf", 55, 10, "Wintermoon Pack"));
            animals.Add(new Wolfman("Wolverine", 100, 48, "Solo"));
            animals.Add(new Worm("Peanutworm", 0.01, 8, true));
            animals.Add(new Dog("White Swiss Shepherd Dog", 32, 5, false));

            foreach (Animal animal in animals) 
            {
                Console.WriteLine($"\n{animal.GetType().Name} says:");
                animal.DoSound();
                if (animal is IPerson animalToPerson) 
                {
                    animalToPerson.Talk();
                }
                
            }

            List<Dog> dogs = new List<Dog>();
            //dogs.Add(new Horse("Camarillo.", 1000, 25, 2.47));

            foreach (Animal animal in animals) 
            {
                Console.WriteLine($"\n{animal.GetType().Name}:");
                Console.WriteLine(animal.Stats());
            }

            Console.WriteLine("\nOnly calling Stats() on the Dog type:");
            foreach (Animal animal in animals)
            {
                if (animal is Dog toDog)
                {
                    Console.WriteLine($"{toDog.Stats()}\n");
                }
            }

            /* 
            * F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
            * A: I Bird klassen.
            * 
            *  F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
            *  A: I Animal klassen.
            *  
            *  Skapa en lista för hundar.
            * F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            * A: För att vi sagt att listan är av typen Dog, och en Horse är inte av typen Dog. En Horse är ett Animal. De båda ärver från Animal, men inte varandra.
            * 
            * F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            * A: Animal.
            * 
            * Skriv ut samtliga Animals Stats() genom en foreach loop.
            * Testa och se så det fungerar.
            * F: Förklara vad det är som händer.
            * A: Den kommer att evaluera varje animal som den typ av animal den är, och därmed alla anrop på metoderna kommer ropas till den mest specialiserade metoden,
            *   dvs de metoder vi gör override på i de klasser som ärver från Animal. Så om någon av typen animal har overridat Stats metoden, kommer den metoden ersättas och
            *   anropas istället, därav får alla sina unika utskrift.
            *   
            * Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri sträng.
            * Kommer du åt den metoden från Animals listan?
            * F: Varför inte?
            * A: För att den metoden känner enbart Dog klassen om. Animal är inte av typen Dog, men den kan castas till en Dog och då kan sen komma åt metoden.
            */

        }
    }
}