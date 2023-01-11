let CalculateVolume radius =
  (4.0 / 3.0 ) * System.Math.PI * ( radius ** 3.0 )

let CategorizeSphere radius = 
  if radius < 10 then
    "small"
  else if radius < 100 then
    "medium"
  else
    "large"

let PrintSphereCategorization radius =
  printfn "%s" (CategorizeSphere radius)

let CategorizeSpheres _ =
  List.map PrintSphereCategorization [1..20]
  