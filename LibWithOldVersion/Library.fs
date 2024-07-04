namespace LibWithOldVersion
open FSharpx.Text.Strings

module Say =
    let hello (name:string) : int =
        for i in 0 .. name.Length do
            match name @? i with
            | EOF -> 0
            | LetterDigit _ & Upper _ -> 1
            | LetterDigit _ -> 2
            | _ -> 3
            |> ignore
        42

