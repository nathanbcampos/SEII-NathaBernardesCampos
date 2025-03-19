using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure.Stack
{
	public class Stack
	{
		public int MaxSize { get; set;} // Array stacks you need a maxsize to init array
		public string[] StackArray { get; set; }
		public int Top {get; set; }

		public Stack (int size)
		{
			this.MaxSize = size;
			//Creates array with size
			this.StackArray = new string[MaxSize];
			//we give the top -1 because arary is zero indez; if we do'nt it will skip first element
			this.Top = -1;
		}

		public void Push(string item)
		{
			Top++;
			StackArray[Top] = item;
		}

		public string Pop()
		{
			//Think placeholder
			int old_top = Top;
			//Decrement for the new top
			Top--;
			return StackArray[old_top];
		}

		public string Peek()
		{
			return StackArray[Top];
		}

		public bool isEmpty()
		{
			return Top == 0;
		}
	}
}
