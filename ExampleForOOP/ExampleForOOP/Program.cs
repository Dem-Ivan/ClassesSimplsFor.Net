

namespace ExampleForOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Olga", Age = 22};
            Friend friend = new Friend(){Name = "Alex", Age = 30};
            Сolleague colleague = new Сolleague() {Name = "Feodor", Age = 10};
            
            Person[] people = new Person[] { person, friend, colleague};

            foreach (var item in people)
            {
                item.Display();
            }
        }
            
    }
}
