// See https://aka.ms/new-console-template for more information

public class SalesPerson
{
    public SalesPerson()
    {
        name = "";
        title = "";
        sales = new List<int>();
    }
    private string name;
    private string title;
    private List<int> sales;

    public string Name { 
        get { return name; }         
        set { name = value; } 
    }
    public string Title {
        get {return title; }  
        set {title = value; }
    }
    public List<int> Sales {
        get { return sales; }
        set { sales = value; }
    }

    public int GetAverage()
    {

        return (int)Enumerable.Average(Sales);
    }

    public int GetMax()
    {
        return (int)Enumerable.Max(Sales);
    }

    public int GetMin()
    {
        return (int)Enumerable.Min(Sales);
    }

    public int GetTotal()
    {
        return (int)Enumerable.Sum(Sales);
    }
}
