open Microsoft.FSharp.Collections
//В массиве все элементы, стоящие после максимального, увеличить в 10 раз.

[<EntryPoint>]
let main argv =

  let mas = [|3; 1; 1; 7; 1; 5; 4|]

  let max = mas|> Array.max

  let index = mas|> Array.findIndex(fun x -> x = max)

  mas.[index + 1..]
    |> Array.map (fun x ->  x * 10)
    |> Array.append mas.[0..index]
    |> printf "%A "

  0