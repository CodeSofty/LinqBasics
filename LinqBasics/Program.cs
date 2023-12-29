// Specify the data source
List<int> scores = new List<int> {97, 92, 81, 60};

//Define the query expression.
IEnumerable<string> scoreQuery =
    (from score in scores
    where score > 80
    orderby score ascending 
    select $"score is {score}");
    
Console.WriteLine(scoreQuery.Count());
 
 //Execute the query.
foreach (string s in scoreQuery)
{
    Console.WriteLine(s);
}


