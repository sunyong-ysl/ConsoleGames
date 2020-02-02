using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    static class Welcome
    {
        static public char DisplayWelcomeScreen()
        {
            Console.WriteLine(@" 
$$$$$$$$\ $$$$$$\  $$$$$$\        $$$$$$$$\  $$$$$$\   $$$$$$\        $$$$$$$$\  $$$$$$\  $$$$$$$$\ 
\__$$  __|\_$$  _|$$  __$$\       \__$$  __|$$  __$$\ $$  __$$\       \__$$  __|$$  __$$\ $$  _____|
   $$ |     $$ |  $$ /  \__|         $$ |   $$ /  $$ |$$ /  \__|         $$ |   $$ /  $$ |$$ |      
   $$ |     $$ |  $$ |               $$ |   $$$$$$$$ |$$ |               $$ |   $$ |  $$ |$$$$$\    
   $$ |     $$ |  $$ |               $$ |   $$  __$$ |$$ |               $$ |   $$ |  $$ |$$  __|   
   $$ |     $$ |  $$ |  $$\          $$ |   $$ |  $$ |$$ |  $$\          $$ |   $$ |  $$ |$$ |      
   $$ |   $$$$$$\ \$$$$$$  |         $$ |   $$ |  $$ |\$$$$$$  |         $$ |    $$$$$$  |$$$$$$$$\ 
   \__|   \______| \______/          \__|   \__|  \__| \______/          \__|    \______/ \________|
                

");
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
            char j = 'y';
            return j;
        }
    }
}
