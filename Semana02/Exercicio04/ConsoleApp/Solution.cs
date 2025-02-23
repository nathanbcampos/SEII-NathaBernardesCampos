using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Solution
    {
	public bool ContainsDuplicate(int[] nums)
	{
	    HashSet<int> set = new();
	    for(int i = 0; i < nums.Length; i++)
	    {
		if(set.Contains(nums[i]))
		{
		    return true;
		}
		set.Add(nums[i]);
	    }
	    return false;
	}
    }
}

