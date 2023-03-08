#region ParallelFor
//Parallel.For(0, 100, SampleMethod);

//Parallel.For(0, 100, i=> 
//{
//    Console.WriteLine("Something...");
//    Console.WriteLine(i.ToString());

//});


//Parallel.For(0, 100, (i, state) =>
//{
//    Console.WriteLine($"Beginning iteration {i}");
//    Console.WriteLine(state.IsExceptional);
//});



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


#endregion



#region ParallelForEach

var ArrayOfString = new[] {"1-Benz", "2-BMW", "3-Nisan", "4-Kia" };

await Parallel.ForEachAsync(ArrayOfString, async (item,token) => 
Console.WriteLine(await Add2023ToCarBrandAsync(item)));


async Task<string> Add2023ToCarBrandAsync(string carBrand)
{
    return await Task.FromResult(carBrand+"-2023");
}



#endregion


Console.WriteLine("Finished!");

