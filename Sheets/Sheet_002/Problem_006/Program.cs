using Problem_006.Common;
using Problem_006.Models;
using Problem_006.Services;

var first = new NumberLinkedList();
var second = new NumberLinkedList();

first.Add(9);
first.Add(9);
first.Add(9);
first.Add(9);
first.Add(9);
first.Add(9);
first.Add(9);

first.Print();

second.Add(9);
second.Add(9);
second.Add(9);
second.Add(9);

second.Print();

ISumOfTwoNumbersProblemSolver solver = new SumOfTwoNumbersProblemSolver();

var sum = solver.Solve(first, second);

sum.Print();
