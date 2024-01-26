//lab 1 Merlin Joseph

namespace lab1
{
    class Person
    {
        //attributes
        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }
        public string favouriteColour { get; set; }

        //methods
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {firstName}, {lastName}");
            Console.WriteLine($"PersonId {personId}:  {firstName}, {lastName}'s favourite colour is {favouriteColour}");
        }

        public void ChangeFavouriteColour()
        {
            favouriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            return (age + 10);
        }

        public bool IsWorking()
        {
            return (isWorking == true);
        }

        public override object ToString()
        {
            {
                return $"PersonID: {personId}" +
                    $"Name: {firstName}, {lastName}" +
                    $"Age: {age}" +
                    $"Favourite Colour: {favouriteColour}" +
                    $"Is Working: {isWorking}";
            }
        }
    }

    class Relation
    {
        //attribute
        public string RelationshipType { get; set; }

        //method
        public void ShowRelationship(Person person1, Person person2)
        {
            //displays relationship between person1 and person2
            Console.WriteLine($"The relationship between {person1.firstName} {person1.lastName} and {person2.firstName} {person2.lastName} is {RelationshipType}");
        }
    }

    class Main
    {
        //objects
        static void Main()
        {
            Person Ian = new Person { firstName= "Ian", lastName= "Brooks", personId= 1, age= 30, favouriteColour= "Red", isWorking= true};
            Person Gina = new Person {firstName = "Gina", lastName = "James", personId = 2, age = 18, favouriteColour = "Green", isWorking = false };
            Person Mike = new Person {firstName = "Mike", lastName = "Briscoe", personId = 3, age = 45, favouriteColour = "Blue", isWorking = true };
            Person Mary = new Person { firstName = "Mary", lastName = "Beals", personId = 4, age = 28, favouriteColour = "Yellow", isWorking = true };

            Relation sisRelation = new Relation { RelationshipType = "Sisterhood" };
            Relation broRelation = new Relation { RelationshipType = "Brotherhood" };

            List<Person> personsList = new List<Person> { Ian, Gina, Mike, Mary };

            var nameStartM = personsList.Where(Person => Person.firstName.StartsWith("M"));

            var favColourBlue = personsList.FirstOrDefault(person => person.favouriteColour.Equals("Blue"));

            //Gina's info
            Console.WriteLine($"Name: {Gina.firstName} {Gina.lastName}, PersonId: {Gina.personId}, Favourite colour: {Gina.favouriteColour}");
            
            //Mike's info
            Mike.DisplayPersonInfo();
            
            //Ian's colour to white, and info
            Ian.ChangeFavouriteColour(); //calls on change made earlier
            Console.WriteLine($"Name: {Ian.firstName} {Ian.lastName}, PersonId: {Ian.personId}, Favourite colour: {Ian.favouriteColour}");

            //Mary's info after 10 years
            Console.WriteLine($"Mary's age after 10 years: {Mary.GetAgeInTenYears()}");


            //Gina and Mary sisters
            sisRelation.ShowRelationship(Gina, Mary);

            //Ian and Mike brothers
            broRelation.ShowRelationship(Ian, Mike);

            //average age 
            double avgAge = personsList.Average(person  => person.age);
            Console.WriteLine($"Average age of people: {avgAge}");

            //youngest
            Person youngPerson = personsList.OrderBy(person => person.age).First();
            Console.WriteLine($"Youngest person is: {youngPerson}");

            //oldest
            Person oldPerson = personsList.OrderByDescending(person => person.age).First();
            Console.WriteLine($"Oldest person is: {oldPerson}");
        }
    }
}