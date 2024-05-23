using EFCoreExample;
using System.Text.Json;

public class EFDemo
{

    public EFDemo()
    {

    }
    public static void dump(Object obj)
    {
        System.Console.WriteLine(JsonSerializer.Serialize(obj,
        new JsonSerializerOptions { WriteIndented = true, }));
    }
    public static void DeleteAll()
    {
        using (var context = new AppDBContext())
        {
            context.Inventories.RemoveRange(context.Inventories);
            context.OrderLines.RemoveRange(context.OrderLines);
            context.Orders.RemoveRange(context.Orders);
            context.Locations.RemoveRange(context.Locations);
            context.Items.RemoveRange(context.Items);
            context.Stocks.RemoveRange(context.Stocks);
            context.Customers.RemoveRange(context.Customers);

            context.SaveChanges();
        }
    }
    public static void CreateItems()
    {
        var i1 = new Item() { Name = "Tuborg Classic", Description = "33 cl, can, 4.6% Vol", Price = 10.0 };
        var i2 = new Item() { Name = "Tuborg light", Description = "33 cl, can, 0.0% Vol", Price = 10.0 };
        var i3 = new Item() { Name = "Coca Cola", Description = "50 cl, bottle", Price = 12.0 };
        var i4 = new Item() { Name = "Pepsi", Description = "50 cl, bottle", Price = 13.5 };
        using (var context = new AppDBContext())
        {
            context.Items.AddRange([i1, i2, i3, i4]);
            context.SaveChanges();
        }
    }

    public static void CreateLocations(string stock_desc, int no_aisles, int no_zones)
    {
        using (var context = new AppDBContext())
        {
            for (int aisle = 0; aisle < no_aisles; aisle++)
            {
                for (int zone = 0; zone < no_zones; zone++)
                {
                    var loc = new Location()
                    {
                        Aisle = aisle,
                        Zone = zone,
                        Stock = context.Stocks.Where(s => s.Description == stock_desc).First()
                    };
                    context.Locations.Add(loc);
                }
            }
            context.SaveChanges();
        }
    }

    public static void CreateStocks()
    {
        var s1 = new Stock() { Description = "Netto" };
        var s2 = new Stock() { Description = "Fakta" };
        using (var context = new AppDBContext())
        {
            context.Stocks.AddRange([s1, s2]);
            context.SaveChanges();
        }
    }

    public static void CreateCustomers()
    {
        var c1 = new Customer() { Name = "Egon Olsen", Address1 = "Vridsløse lille" };
        var c2 = new Customer() { Name = "Anders And", Address1 = "Paradis Æblevej 13" };
        var c3 = new Customer() { Name = "Benny Hill", Address1 = "Somewhere in the UK" };
        var c4 = new Customer() { Name = "Fakta", Address1 = "Odinsgade 2" };
        var c5 = new Customer() { Name = "Netto", Address1 = "Hadsundvej 2" };
        using (var context = new AppDBContext())
        {
            context.Customers.AddRange([c1, c2, c3, c4, c5]);
            context.SaveChanges();
        }
        System.Console.WriteLine(c1);
        System.Console.WriteLine(c2);
    }

    public static Order CreateOrder(string order_name, string customer_name, Dictionary<string, int> order)
    {
        Order o;
        using (var context = new AppDBContext())
        {
            o = new Order()
            {
                Description = order_name,
                Customer = context.Customers.Where(c => c.Name == customer_name).First()
            };

            foreach (KeyValuePair<string, int> line in order)
            {
                var item = context.Items.Where(c => c.Name == line.Key).First();
                o.OrderLines.Add(new OrderLine() { Item = item, Qty = line.Value });
            }

            context.Orders.Add(o);
            context.SaveChanges();
        }
        return o;
    }

    public static void CreateInventory()
    {
        using (var context = new AppDBContext())
        {
            Stock stock = context.Stocks.First();

            var inv = new Inventory()
            {
                Item = context.Items.First(),
                Location = context.Locations.Where(l => l.Stock == stock).First(),
                Qty = 4
            };
            context.Inventories.Add(inv);
            context.SaveChanges();
        }
    }

    public static void StoreOrder(Order sto, string stock_name)
    {
        using (var context = new AppDBContext())
        {
            Stock stock = context.Stocks.Where(s => s.Description == stock_name).First();

            foreach (OrderLine ol in sto.OrderLines)
            {
                var inv = new Inventory()
                {
                    Item = context.Items.Where(i => i.Name == ol.Item.Name).First(),

                    // setting Item directly gives an exception, why???
                    // Item = ol.Item,
                    Qty = ol.Qty,
                    Location = context.Locations.Where(l => l.Stock == stock).First(),
                };

                dump(inv.Item);
                context.Inventories.Add(inv);
                context.SaveChanges();
            }
        }
    }

    public static void ExecuteOrder(Order sales, string stock_name)
    {
        using (var context = new AppDBContext())
        {
            Stock stock = context.Stocks.Where(s => s.Description == stock_name).First();

            foreach (OrderLine ol in sales.OrderLines)
            {
                System.Console.WriteLine("Orderline");

                var inv = context.Inventories.Where(i => i.Item  == ol.Item ).Where(i => i.Qty > ol.Qty ).First();

                inv.Qty -= ol.Qty;
            }
            // sales.State = OrderState.Done;
            System.Console.WriteLine($"saved: {context.SaveChanges()}");
            
        }


        // check items in stock/inventory

        // remove from inventory
        // mark order done

    }


    public static void Main(string[] args)
    {
        DeleteAll();

        // Basic data - no relations

        CreateItems();
        CreateStocks();
        CreateCustomers();

        // depends on Stocks
        CreateLocations("Fakta", 10, 20);
        CreateLocations("Netto", 12, 12);

        // create inventory 
        CreateInventory();

        var sto_order1 = new Dictionary<string, int>(){
            {"Pepsi", 100},
            {"Coca cola", 110},
            {"Tuborg Light", 50},
            {"Tuborg Classic", 55}};

        var sto_order2 = new Dictionary<string, int>(){
            {"Pepsi", 30},
            {"Coca cola", 20},
            {"Tuborg Light", 1},
            {"Tuborg Classic", 1}};

        var sto1 = CreateOrder("Levering torsdag", "Fakta", sto_order1);
        // var sto2 = CreateOrder("Levering torsdag", "Netto", sto_order2);

        StoreOrder(sto1, "Fakta");
        // StoreOrder(sto2, "Netto");

        // depends on Items and Customers
        var items_1 = new Dictionary<string, int>(){
            {"Pepsi", 3},
            {"Coca cola", 3},
            {"Tuborg Classic", 5} };

        var salesorder_1 = CreateOrder("Anders lørdag", "Anders And", items_1);
        var items_2 = new Dictionary<string, int>(){
            {"Pepsi", 13},
            {"Coca cola", 3},
            {"Tuborg Light", 5} };

        var salesorder_2 = CreateOrder("Egon fredag", "Egon Olsen", items_2);

        ExecuteOrder(salesorder_1, "Fakta");
        //ExecuteOrder(salesorder_2, "Netto");
    }
}