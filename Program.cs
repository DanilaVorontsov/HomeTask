int nA = Convert.ToInt32(Console.ReadLine());
int nB = Convert.ToInt32(Console.ReadLine());
int nC = Convert.ToInt32(Console.ReadLine());
int max = nA;

if (nB > nA) max = nB;
if (nC > max) max = nC;

Console.WriteLine(max);
