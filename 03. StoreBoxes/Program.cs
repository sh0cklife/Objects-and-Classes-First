namespace _03._StoreBoxes
{
    public class Program
    {
        public class Item
        {
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }
            public decimal Price { get; set; }
        }
        public class Box
        {
            public Box(string serialNumber, Item item, int itemQTY)
            {
                SerialNumber = serialNumber;
                Item = item;
                ItemQTY = itemQTY;
                PriceForBox = item.Price * itemQTY;
            }

            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQTY { get; set; }
            public decimal PriceForBox { get; set; }

        }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (command != "end")
            {

                string[] data = command.Split(" ");
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQTY = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item currentItem = new Item(itemName, itemPrice);
                Box currentBox = new Box(serialNumber,currentItem,itemQTY);

                boxes.Add(currentBox);

                command = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(box => box.PriceForBox).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQTY}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }
}