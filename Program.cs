// See https://aka.ms/new-console-template for more information
using System;

int count = 2;
List<SalesPerson> addSalesPerson= new List<SalesPerson> ();
for (int i = 0; i < count; i++)
{
    SalesPerson salesPerson = new SalesPerson();
    Console.Write("Please enter sales person name: ");
    salesPerson.Name = Console.ReadLine();
    Console.Write("Please enter your sales person title: ");
    salesPerson.Title = Console.ReadLine();
    Console.Write("How many sales values will you enter for this sales person? ");
    int howmanysales = Convert.ToInt32(Console.ReadLine());
    if (howmanysales > 0)
    {
        for( int j = 0; j < howmanysales; j++)
        {
            Console.Write("Please enter sales figure for " + salesPerson.Name + " ");
            salesPerson.Sales.Add(Convert.ToInt32(Console.ReadLine()));
        }
    }
    addSalesPerson.Add(salesPerson);
    Console.WriteLine();
}

var total = 0;
foreach (SalesPerson sp in addSalesPerson)
{
    Console.WriteLine("Sales person: " + sp.Name);
    Console.WriteLine("Total Sales: $" + sp.GetTotal());
    Console.WriteLine("Min Sales: $" + sp.GetMin());
    Console.WriteLine("Max Sales: $" + sp.GetMax());
    Console.WriteLine("Average Sales: $" + sp.GetAverage());
    Console.WriteLine("-----------------------------------------");
    total +=sp.GetTotal();
}


Console.WriteLine("Company toal sales: $"+ total );
