//Parallel.For(0, 100, SampleMethod);

//Parallel.For(0, 100, i=> 
//{
//    Console.WriteLine("Something...");
//    Console.WriteLine(i.ToString());

//});


Parallel.For(0, 100, (i, state) =>
{
    Console.WriteLine($"Beginning iteration {i}");
    Console.WriteLine(state.IsExceptional);
});



    //Parallel.For(0, 100, new ParallelOptions { MaxDegreeOfParallelism = 1 }, i =>
    //{
    //    Console.WriteLine(i.ToString());
    //});




    //Parallel.For(0, 100, delegate(int i)
    //{
    //    Console.WriteLine(i.ToString());
    //});



    //static void SampleMethod(int i)
    //{
    //    Console.WriteLine(i.ToString());
    //}


    Console.WriteLine("Finished!");

