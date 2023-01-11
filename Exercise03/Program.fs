open FSharp.Data

type Courses = CsvProvider<"./Courses.csv">

Courses.GetSample().Rows
|> Seq.filter (fun x -> x.CompletionPercentage > 0.99M)
|> Seq.map (fun x -> $"%s{x.FirstName} %s{x.LastName}")
|> Seq.distinct
|> Seq.sort
|> Seq.iter (printfn "%s")
