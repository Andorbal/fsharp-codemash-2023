open System

let CalculateVolume radius =
  (4.0 / 3.0 ) * Math.PI * ( radius ** 3.0 )

let CategorizeSphere radius = 
  if radius < 10 then
    "small"
  else if radius < 100 then
    "medium"
  else
    "large"

List.map CategorizeSphere [1..20]
|> List.iter (fun x -> printfn "%s" x)
  