using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUL8
{
	public partial class DevUL8Challenge : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{	
			// PART 1
			// reverse a string
			string myName = "BOB TABOR !!!";
			string reverse = "";
			for (int i = myName.Length - 1; i >= 0; i--)
			{
				reverse += myName[i];
			}
			Label1.Text = reverse;

			// PART 2
			//

			string names ="Luke, Leia, Han, Chewbacca";
			// split function can use ' but not "
			string [] arrayOfNames = names.Split(',');
			string output = "";
			for (int i = arrayOfNames.Length - 1; i >= 0; i--)
			{
				output += arrayOfNames[i] +", ";
			}
			Label2.Text = output;
			//char[] reverse2 = names.ToCharArray(",");
			//Array.Reverse(reverse2);
			// Label2.Text = reversedNames;

			// PART 3//
			//
			// desired: 5luke5, 5leia5,5han6,2chewbacca3
			// actual: 55,45,55,22
		
			string outputFor3 = "";
			for (int i = 0; i <= arrayOfNames.Length-1; i++)
			{
				int spaces = 14 - arrayOfNames[i].Length;
				int padLeft = spaces / 2 + arrayOfNames[i].Length;
				outputFor3 += arrayOfNames[i].PadLeft(padLeft, '*').PadRight(14, '*')+"<br>";
				Label3.Text = "<br>"+outputFor3;
			}

			// PART 4//
			//
			string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNTRY.";
			int index = puzzle.IndexOf("remove-me");
			puzzle = puzzle.Remove(index, "remove-me".Length);
			puzzle = puzzle.ToLower();
			puzzle = puzzle.Replace("z", "t");
			puzzle = char.ToUpper(puzzle[0]) + puzzle.Substring(1);
			//puzzle = puzzle.CapitalizeFirst();

			Label4.Text = puzzle; 

			/*

			// PART 4
			string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNTRY.";
			string firstStep=puzzle.ToLower();
			//char [] secondStep = firstStep.Split("remove-me","");
			int index = firstStep.IndexOf("remove-me");
			
			string result=RemoveMe(firstStep);
			public string RemoveMe(firstStep) {
				
			}
			
			for (int i = index; i < index+9; i++)
			{
				string[]fsArray=firstStep.Split("").ToArray();
				fsArray[i] = "";

			}
			string []secondStep = fsArray.Split(" "),
			//string secondStep = firstStep.Replace("remove-me", "");
			Label4.Text = index.ToString();
			
			*/

		}
		/* me attempting to iterate part 3 array items
		 * through another function
		public string padBoth(string name)
		{
			int spaces = 14 - name.Length;
			int padLeft = spaces / 2 + name.Length;
			string outputFor3 = "";
			outputFor3 += name.PadLeft(padLeft, '*').PadRight(14, '*');
			return outputFor3;
		}
		*/
	}
}