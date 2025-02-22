using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApp
{
    public class RealState
    {

	private string _adress;
	/*public string? Address { get; set; }*/
	/*public int Price { get; set; }*/
	/*public int SquareFootage { get; set; }*/
	/*public int CalculatePricePerSquareFoot() => Price / SquareFootage;*/

	public RealState(string address)
	{
	    _adress = address;
	}

	public string Address 
	{
	    get => _adress;
	    set => _adress = value;
	}
    }
}
