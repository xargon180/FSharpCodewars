// https://www.codewars.com/kata/54da539698b8a2ad76000228/train/fsharp

open System

let countDirection walk direction =
    walk |> List.filter (fun x -> x = direction) |> List.length


let isValidWalk walk =
    let walkDirectionCounter = countDirection walk
    let northCount = walkDirectionCounter 'n'
    let southCount = walkDirectionCounter 's'
    let eastCount = walkDirectionCounter 'e'
    let westCount = walkDirectionCounter 'w'
    walk.Length = 10 && northCount = southCount && eastCount = westCount

[<EntryPoint>]
let main argv =
    let is10MinitsWalk = isValidWalk ['n';'s';'e';'w';'n';'s';'e';'w';'n';'s']
    printfn "Hello world %b" is10MinitsWalk
    0 // return an integer exit code