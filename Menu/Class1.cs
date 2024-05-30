namespace Menu
{
    public class Menu 
    {
        string header = "======= CRUD BANCO =======";
       
        public void CrudMenu()
        {
            Console.WriteLine(header);
            Console.WriteLine("[1] - INSERT");
            Console.WriteLine("[2] - DELETE");
            Console.WriteLine("[3] - UPDATE");
            Console.WriteLine("[4] - GET AS SPECIFIC ID");
            Console.WriteLine("[5] - GET ALL");
        }

    }
}
