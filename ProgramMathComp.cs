using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
    int n = 80000;
    double [,] numbers;
    int[,] intnumbers;
    numbers = GenRandomNumbers(n);
    intnumbers = IntGenRandomNumbers(n);
    Stopwatch timer = new Stopwatch();
//Add Numbers Double
    timer.Start();
    AddNumbers(numbers, n);
    timer.Stop();
    Console.WriteLine("Additions");
    Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    float addTicks = (float)timer.ElapsedTicks;

//Multiply Numbers Double
    timer.Restart();
    MultiplyNumbers(numbers, n);
    timer.Stop();
    Console.WriteLine("Multiplications");
    Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    float multTicks = (float)timer.ElapsedTicks; 

//Subtract Numbers Double
    timer.Restart();
    SubtractNumbers(numbers, n);
    timer.Stop();
    Console.WriteLine("Subtractions");
    Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    float subTicks = (float)timer.ElapsedTicks;

//Divide Numbers Double
    timer.Restart();
    DivideNumbers(numbers, n);
    timer.Stop();
    Console.WriteLine("Divisions");
    Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    float divTicks = (float)timer.ElapsedTicks;

//Add Numbers Integers
    timer.Start();
    intAddNumbers(intnumbers, n);
    timer.Stop();
    Console.WriteLine("Integer Additions");
    Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    float addintTicks = (float)timer.ElapsedTicks;

//Subtract Numbers Integers
    timer.Restart();
    intSubtractNumbers(intnumbers, n);
    timer.Stop();
    Console.WriteLine("Integer Subtractions");
    Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    float subintTicks = (float)timer.ElapsedTicks;
    
// Square INT Numbers via multiply
    timer.Restart();
    SquareMultiplyNumbers(intnumbers, n);
    timer.Stop();
    Console.WriteLine("Integer Sqaure Via Multiplication");
    Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    float squmultTicks = (float)timer.ElapsedTicks;

// Square Int Numbers Via Math POW
    timer.Restart();
    SquareNumbers(intnumbers, n);
    timer.Stop();
    Console.WriteLine("Integer Sqaure Via Math Pow");
    Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    float squrepowTicks = (float)timer.ElapsedTicks;


}


//Function to gen random numbers
static double[,] GenRandomNumbers(int count)
{
    Random rand = new Random();
    double[,] num = new double [count,3];
    for(int i=0; i<count; ++i){
        num[i,0] = 10000.0*rand.NextDouble();
        num[i,1] = 10000.0*rand.NextDouble();
    }
    return num;
}

static int[,] IntGenRandomNumbers(int count)
{
    Random rand = new Random();
    int[,] num = new int [count,3];
    for(int i=0; i<count; ++i){
        num[i,0] = 10000*((int)rand.NextDouble());
        num[i,1] = 10000*((int)rand.NextDouble());
    }
    return num;
}

//Function to add
static void AddNumbers(double[,] nums, int count)
{
    int i;
    for(i=0; i<count; ++i){
        nums[i,2] = nums[i,0] + nums[i,1];
    }
}
static void MultiplyNumbers(double[,] nums, int count)
{
    int i;
    for(i=0; i<count; ++i){
        nums[i,2] = nums[i,0] * nums[i,1];
    }
}
static void SubtractNumbers(double[,] nums, int count)
{
    int i;
    for(i=0; i<count; ++i){
        nums[i,2] = nums[i,0] - nums[i,1];
    }
}
static void DivideNumbers(double[,] nums, int count)
{
    int i;
    for(i=0; i<count; ++i){
        nums[i,2] = nums[i,0] / nums[i,1];
    }
}
static void intAddNumbers(int[,] nums, int count)
{
    int i;
    for(i=0; i<count; ++i){
        nums[i,2] = nums[i,0] + nums[i,1];
    }
}
static void intSubtractNumbers(int[,] nums, int count)
{
    int i;
    for(i=0; i<count; ++i){
        nums[i,2] = nums[i,0] - nums[i,1];
    }
}
static void intMultiplyNumbers(int[,] nums, int count)
{
    int i;
    for(i=0; i<count; ++i){
        nums[i,2] = nums[i,0] * nums[i,1];
    }
}
static void SquareMultiplyNumbers(int[,] nums, int count)
{
    int i;
    for(i=0; i<count; ++i){
        nums[i,2] = nums[i,0] * nums[i,0];
    }
}
static void SquareNumbers(int[,]nums, int count)
{
  
    int i;
    for(i=0; i<count; ++i){
        nums[i,2] = (int)Math.Pow(nums[i,0], 2.0);
    }
}
}