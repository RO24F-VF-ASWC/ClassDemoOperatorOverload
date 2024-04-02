// See https://aka.ms/new-console-template for more information
using ClassDemoOperatorOverload;

Console.WriteLine("Demo Operator overload");

Position pos1 = new Position(3,4);
Position pos2 = new Position(5,6);

Console.WriteLine("pos1: " + pos1);
Console.WriteLine("pos2: " + pos2);

PosStruct poss1 = new PosStruct() { X=9, Y=7 };
Console.WriteLine($"poss1: {poss1.X},{poss1.Y}");

Console.WriteLine(" + operator " + (pos1 + pos2));

Console.WriteLine(" == operator " + (pos1 == pos2));

Console.WriteLine(" != operator " + (pos1 != pos2));

PosStruct ps2 = pos1;
Console.WriteLine($"ps2: {ps2.X},{ps2.Y}");

Position pos4 = (Position)poss1;
Console.WriteLine("pos4 " + pos4);


Console.WriteLine(  "Er pos4 valid " + pos4.IsValid());