Console.Clear();

double carne = 0.4, acompanhamento = 0.2, cerveja = 2, refrigerante = 0.5, agua = 0.4, totalcarne1=0, totalcarne2=0, totalacom=0, totalcerv=0, totalrefri=0, totalagua=0, crianca_carne=0;
int adulto1, adulto2, crianca;

Console.WriteLine("--- Churrasco ---");

Console.WriteLine("");

Console.Write("Digite o número de adultos que consomem bebidas alcoólicas: ");
adulto1 = int.Parse(Console.ReadLine());

Console.Write("Digite o número de adultos que não consomem bebidas alcoólicas: ");
adulto2 = int.Parse(Console.ReadLine());

Console.Write("Digite o número de crianças: ");
crianca = int.Parse(Console.ReadLine());

Console.WriteLine("");

if (crianca > 0){
    crianca_carne = crianca * 0.2;
}
totalcarne1 = (adulto1 + adulto2) * carne;
totalcarne2 = totalcarne1 + crianca_carne;
totalacom = (adulto1 + adulto2 + crianca) * acompanhamento;
totalcerv = adulto1 * cerveja;
totalrefri = (adulto2 + crianca) * refrigerante;
totalagua = (adulto1 + adulto2 + crianca) * agua;

Console.WriteLine("Adultos (que consomem bebidas alcoólicas).......: {0}", adulto1);
Console.WriteLine("Adultos (que não consomem bebidas alcoólicas)...: {0}", adulto2);
Console.WriteLine("Crianças........................................: {0}", crianca);

Console.WriteLine("");

Console.WriteLine("Carne.............: {0:f1}kg", totalcarne2);
Console.WriteLine("Acompanhamentos...: {0:f1}kg", totalacom);
Console.WriteLine("Cerveja...........: {0:f1}l", totalcerv);
Console.WriteLine("Refrigerante......: {0:f1}l", totalrefri);
Console.WriteLine("Água..............: {0:f1}l", totalagua);