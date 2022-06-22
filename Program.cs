// See https://aka.ms/new-console-template for more information

//huidige oplossing
string[] naamLetter = new string[4];
naamLetter[0] = @"          _____                                                                  
         /\    \                                                                 
        /::\    \                                                                
       /::::\    \                                                               
      /::::::\    \                                                              
     /:::/\:::\    \                                                             
    /:::/__\:::\    \                                                            
   /::::\   \:::\    \                                                           
  /::::::\   \:::\    \                                                          
 /:::/\:::\   \:::\ ___\                                                         
/:::/__\:::\   \:::|    |                                                        
\:::\   \:::\  /:::|____|                                                        
 \:::\   \:::\/:::/    /                                                         
  \:::\   \::::::/    /                                                          
   \:::\   \::::/    /                                                           
    \:::\  /:::/    /                                                            
     \:::\/:::/    /                                                             
      \::::::/    /                                                              
       \::::/    /                                                               
        \::/____/                                                                
         ~~                                                                      
                                                                                 ";
naamLetter[1] = @"                  _____                                                                  
                 /\    \                                                                 
                /::\    \                                                                
               /::::\    \                                                               
              /::::::\    \                                                              
             /:::/\:::\    \                                                             
            /:::/__\:::\    \                                                            
           /::::\   \:::\    \                                                           
          /::::::\   \:::\    \                                                          
         /:::/\:::\   \:::\    \                                                         
        /:::/  \:::\   \:::\____\                                                        
        \::/    \:::\  /:::/    /                                                        
         \/____/ \:::\/:::/    /                                                         
                  \::::::/    /                                                          
                   \::::/    /                                                           
                   /:::/    /                                                            
                  /:::/    /                                                             
                 /:::/    /                                                              
                /:::/    /                                                               
                \::/    /                                                                
                 \/____/                                                                 
                                                                                         ";
naamLetter[2] = @"                          _____                                                                  
                         /\    \                                                                 
                        /::\    \                                                                
                       /::::\    \                                                               
                      /::::::\    \                                                              
                     /:::/\:::\    \                                                             
                    /:::/__\:::\    \                                                            
                   /::::\   \:::\    \                                                           
                  /::::::\   \:::\    \                                                          
                 /:::/\:::\   \:::\____\                                                         
                /:::/  \:::\   \:::|    |                                                        
                \::/   |::::\  /:::|____|                                                        
                 \/____|:::::\/:::/    /                                                         
                       |:::::::::/    /                                                          
                       |::|\::::/    /                                                           
                       |::| \::/____/                                                            
                       |::|  ~|                                                                  
                       |::|   |                                                                  
                       \::|   |                                                                  
                        \:|   |                                                                  
                         \|___|                                                                  
                                                                                                 ";
naamLetter[3] = @"                              _____                                                                  
                             /\    \                                                                 
                            /::\    \                                                                
                            \:::\    \                                                               
                             \:::\    \                                                              
                              \:::\    \                                                             
                               \:::\    \                                                            
                               /::::\    \                                                           
                              /::::::\    \                                                          
                             /:::/\:::\    \                                                         
                            /:::/  \:::\____\                                                        
                           /:::/    \::/    /                                                        
                          /:::/    / \/____/                                                         
                         /:::/    /                                                                  
                        /:::/    /                                                                   
                        \::/    /                                                                    
                         \/____/                                                                     
                                                                                                     
                                                                                                     
                                                                                                     
                                                                                                     
                                                                                                     ";
Console.BackgroundColor = ConsoleColor.DarkGreen;

for (int i = 0; i < 4; i++)
{
    switch (i) {
        case 0:
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case 1:
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.Cyan;
            break;
    }
    Console.WriteLine(naamLetter[i]);
}
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

/* eerste oplossing
string naamRegel1 = @"           _____                    _____                    _____                _____          ";
string naamRegel2 = @"          /\    \                  /\    \                  /\    \              /\    \         ";
string naamRegel3 = @"         /::\    \                /::\    \                /::\    \            /::\    \        ";
string naamRegel4 = @"        /::::\    \              /::::\    \              /::::\    \           \:::\    \       ";
string naamRegel5 = @"       /::::::\    \            /::::::\    \            /::::::\    \           \:::\    \      ";
string naamRegel6 = @"      /:::/\:::\    \          /:::/\:::\    \          /:::/\:::\    \           \:::\    \     ";
string naamRegel7 = @"     /:::/__\:::\    \        /:::/__\:::\    \        /:::/__\:::\    \           \:::\    \    ";
string naamRegel8 = @"    /::::\   \:::\    \      /::::\   \:::\    \      /::::\   \:::\    \          /::::\    \   ";
string naamRegel9 = @"   /::::::\   \:::\    \    /::::::\   \:::\    \    /::::::\   \:::\    \        /::::::\    \  ";
string naamRegel10 = @" /:::/\:::\   \:::\ ___\  /:::/\:::\   \:::\    \  /:::/\:::\   \:::\____\      /:::/\:::\    \ ";
string naamRegel11 = @"/:::/__\:::\   \:::|    |/:::/  \:::\   \:::\____\/:::/  \:::\   \:::|    |    /:::/  \:::\____\";
string naamRegel12 = @"\:::\   \:::\  /:::|____|\::/    \:::\  /:::/    /\::/   |::::\  /:::|____|   /:::/    \::/    /";
string naamRegel13 = @" \:::\   \:::\/:::/    /  \/____/ \:::\/:::/    /  \/____|:::::\/:::/    /   /:::/    / \/____/ ";
string naamRegel14 = @"  \:::\   \::::::/    /            \::::::/    /         |:::::::::/    /   /:::/    /          ";
string naamRegel15 = @"   \:::\   \::::/    /              \::::/    /          |::|\::::/    /   /:::/    /           ";
string naamRegel16 = @"    \:::\  /:::/    /               /:::/    /           |::| \::/____/    \::/    /            ";
string naamRegel17 = @"     \:::\/:::/    /               /:::/    /            |::|  ~|           \/____/             ";
string naamRegel18 = @"      \::::::/    /               /:::/    /             |::|   |                               ";
string naamRegel19 = @"       \::::/    /               /:::/    /              \::|   |                               ";
string naamRegel20 = @"        \::/____/                \::/    /                \:|   |                               ";
string naamRegel21 = @"         ~~                       \/____/                  \|___|                               ";

Console.BackgroundColor= ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(naamRegel1);
Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine(naamRegel2);
Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(naamRegel3);
Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(naamRegel4);
Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(naamRegel5);
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(naamRegel6);
Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(naamRegel7);
Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(naamRegel8);
Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine(naamRegel9);
Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(naamRegel10);
Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(naamRegel11);
Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(naamRegel12);
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(naamRegel13);
Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(naamRegel14);
Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(naamRegel15);
Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine(naamRegel16);
Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine(naamRegel17);
Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(naamRegel18);
Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(naamRegel19);
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(naamRegel20);
Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(naamRegel21);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
*/