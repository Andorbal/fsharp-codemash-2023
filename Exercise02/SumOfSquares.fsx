let SumTheSquares list =
  list
  |> List.filter (fun x -> x % 2 = 0)
  |> List.map (fun x -> x * x)
  |> List.sum