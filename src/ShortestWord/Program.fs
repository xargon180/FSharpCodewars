open System

let findShort (str : string) = 
    str.Split([|' '|], StringSplitOptions.RemoveEmptyEntries)
    |> Array.map (fun s -> s.Trim().Length)
    |> Array.min

[<EntryPoint>]
let main argv =
    let message = findShort "abc dde    ela udz asm dddddddddddddd" // Call the function
    printfn "Hello world %i" message
    0 // return an integer exit code