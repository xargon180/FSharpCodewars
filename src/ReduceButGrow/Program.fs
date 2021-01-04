open System

let Grow (x : int[]) =
    x |> Array.reduce (fun a b -> a * b)


[<EntryPoint>]
let main argv =
    let result = Grow [|1; 2; 3; 4|]
    printfn "Hello world %i" result
    0 // return an integer exit code