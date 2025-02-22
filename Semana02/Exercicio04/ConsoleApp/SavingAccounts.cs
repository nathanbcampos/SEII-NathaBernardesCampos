using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp 
{
    public class SavingAccount
    {
	public static double currInterestRate;
	public static double bondRate;

	static SavingAccount()
	{
	    currInterestRate = 0.4;
	}

	public static void AddBondRate()
	{
	    currInterestRate = bondRate + 0.1;
	}

    }
}
