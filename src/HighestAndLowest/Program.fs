open System

let highAndLow (str : string) = 
    let intArr = str.Split ' ' |> Array.map int
    let max = intArr |> Array.max
    let min = intArr |> Array.min
    max.ToString() + " " + min.ToString()

[<EntryPoint>]
let main argv =
    let message = highAndLow "1 2 -3 4 5"
    printfn "Hello world %s" message
    0 // return an integer exit code