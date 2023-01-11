let GetFizzBuzzValue num =
  if num % 3 = 0 && num % 5 = 0 then
    "fizz buzz"
  else if num % 3 = 0 then
    "fizz"
  else if num % 5 = 0 then 
    "buzz"
  else
    num.ToString()

let PrintFizzBuzzValue num =
  let value = GetFizzBuzzValue num
  printfn "%s" value

let GetBasicFizzBuzzValues _ =
  let values = [1..20]
  List.iter PrintFizzBuzzValue values