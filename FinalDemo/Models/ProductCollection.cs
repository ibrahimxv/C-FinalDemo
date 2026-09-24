namespace ConsoleApp4.Models;

public class ProductCollection
{
    private string[] _product = new string[10];
    public string this[int index] 
    { 
        get
        {
            return _product[index];
        }

        set
        {
            _product[index] = value;
        }
    }
}
