using Domain.Entities;

namespace ECFAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            TestDataBase();

        }
        public static void TestDataBase()
        {
            User user1 = new User();
            Repo repo = new Repo();
            user1.Name = "Bhanu";
            user1.EmailAddress = "bhanu@gmail.com";
            user1.PhoneNumber = 8723723;
            repo.AddUser(user1);
            User user2 = new User();
            user2.Name = "Sandhu";
            user2.EmailAddress = "Dal@gmail.com";
            user2.PhoneNumber = 99723748;
            repo.AddUser(user2);
            ListOfUsers(repo);

            repo.UpdateUser(user2);
            ListOfUsers(repo);

            repo.DeleteUser(user2);
            ListOfUsers(repo);
        }
        public static void ListOfUsers(Repo repo)
        {
            var listOfUsers = repo.ListAll();
            foreach(User user in listOfUsers){
                Console.WriteLine("User Name: "+user.Name);
                Console.WriteLine("User EmailAddress: " + user.EmailAddress);
                Console.WriteLine("User Phone Number: " + user.PhoneNumber);
            }
        }
    }
}