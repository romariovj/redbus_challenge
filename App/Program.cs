namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryBike deliveryBike = new DeliveryBike();
            int[] packagesWeights = { 5, 3, 2, 5, 6, 1, 4, 7, 9 };

            int groupWeight = 10;
            int totalBikes = deliveryBike.Count(packagesWeights, groupWeight);
            Console.WriteLine("Total Bikes: {0}", totalBikes);
            
        }
    }
}
