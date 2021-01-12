// https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097/train/fsharp

open System

let century year =
  match year % 100 with
  | 0 -> year / 100
  | _ -> year / 100 + 1

[<EntryPoint>]
let main argv =
    let message = century 1601 // Call the function
    printfn "Hello world %i" message
    0 // return an integer exit code