namespace _05.day5
{
    internal class Program
    {

        public struct Item //Ietm 구조체.
        {
            public string Name;
            public int id;
            public int itemSize;

            public Item(string name, int id, int itemSize) //Item의 입력값을 받음.
            {
                Name = name;
                this.id = id;
                this.itemSize = itemSize;
            }
        }
        public struct Inventory //Inventory 구조체.
        {
            public Item[] items; //Item의 입력값을 배열로 받음.

            public Inventory(int size)
            {
                items = new Item[size];
            }
        }


        public static void AllItems(Inventory inventory) // AllItems 함수. Inventory를 입력값으로 받음.
        {
            for (int i = 0; i < inventory.items.Length; i++)
            {
                if (inventory.items[i].Name != null)
                {
                    Console.WriteLine("아이템 이름 : {0}, 아이템id : {1}, 아이템 무게 : {2}", inventory.items[i].Name, inventory.items[i].id, inventory.items[i].itemSize);
                }
            }
        }

        static void Main(string[] args)
        {
            Inventory inventory = new Inventory(5);
            inventory.items[0] = new Item("대검", 1, 2);
            inventory.items[1] = new Item("태도", 2, 1);
            inventory.items[2] = new Item("한손검", 3, 1);
            inventory.items[3] = new Item("쌍검", 4, 2);
            Console.WriteLine("아이템 이름 : {0}, 아이템id : {1}, 아이템 크기 : {2}", inventory.items[0].Name, inventory.items[0].id, inventory.items[0].itemSize);
            AllItems(inventory); //null값은 반환하지 않으므로 4개의 아이템만 나옴.
        }
    }

}
