using System;

namespace Full_GRASP_And_SOLID.Library
{
    //SRP
    public class ConsolePrinter
    {
       public void ConsolePrint(Recipe recipe){
           Console.WriteLine(recipe.TextToPrint());
       }
    }
}