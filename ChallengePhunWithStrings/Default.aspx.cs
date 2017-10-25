using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Suhaib Al-Tamimi";
            // In my case, the result would be:
            // imimaT-lA biahuS
            for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += name[i];
            }

            resultLabel.Text += "<br/>";


            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            string[] namesArray = names.Split(',');
            string result = "";
            for (int i = namesArray.Length - 1; i >= 0; i--)
            {
                result += namesArray[i] +",";
            }
            result = result.Remove(result.Length - 1, 1);
            resultLabel.Text += result + "<br/>";




            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***
            string result2 = "";
            for (int i = 0; i < namesArray.Length; i++)
            {
                int padLeft = (14 - namesArray[i].Length) / 2;
                string temp = namesArray[i].PadLeft(namesArray[i].Length + padLeft, '*');
                result2 += temp.PadRight(14,'*') + "<br/>";
            }
            resultLabel2.Text = result2;





            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.
            puzzle = puzzle.Replace("Z", "t");

            string remove = "remove-me";
            int index = puzzle.IndexOf(remove);
            puzzle = puzzle.Remove(index, remove.Length);

            puzzle = puzzle.ToLower();

            puzzle = puzzle.Replace("now", "Now");
            // Or we can do The below to change the "n" for "N" 
            //string nValue = "now";
            //int nIndex = puzzle.IndexOf(nValue);
            //puzzle = puzzle.Remove(nIndex, 1);
            //puzzle = puzzle.Insert(nIndex, "N");

            resultLabel3.Text = puzzle;
        }
    }
}