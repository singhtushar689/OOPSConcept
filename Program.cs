namespace InventoryManagement
{
     public class Program
     {
        static void Main(string[] args)
        {
            string path = "D:\\InventoryManagement\\Inventory.json";
            FetchInventoryDetails fetchInventoryDetails= new FetchInventoryDetails();
            Details data = fetchInventoryDetails.Read(path);

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {

                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
            }
        }
     }
}