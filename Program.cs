string nome, nomeninja;
Console.Write("Digite seu nome, e descubra seu apelido Ninja: ");
nome = Console.ReadLine()!
.ToLower();

nomeninja = nome
.Replace("a", "KA" )
.Replace("b", "ZU" )
.Replace("c", "MI" )
.Replace("d", "TE" )
.Replace("e", "KU" )
.Replace("f", "LU" )        
.Replace("g", "JI" )        
.Replace("h", "RI" )        
.Replace("i", "KI" )        
.Replace("j", "ZUS" )       
.Replace("k", "ME" )
.Replace("l", "TA" )        
.Replace("m", "RIN" )       
.Replace("n", "TO" )         
.Replace("o", "MO" )        
.Replace("p", "NO" )        
.Replace("q", "KE" )        
.Replace("r", "SHI" )       
.Replace("s", "ARI" )       
.Replace("t", "CHI" )       
.Replace("u", "DO" )        
.Replace("v", "RU" )        
.Replace("w", "MEI" )       
.Replace("x", "NA" )        
.Replace("y", "FU" )         
.Replace("z", "ZI" );
Console.WriteLine(nome);
Console.ForegroundColor = ConsoleColor.DarkRed;

Console.WriteLine(nomeninja);
Console.ResetColor();