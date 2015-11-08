// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 

    let stringReverse (s: string) =
        System.String(Array.rev (s.ToCharArray()))

    let isPalindrom x = 
        let y = x.ToString()

        match y with
            | y when y = stringReverse y -> true
            | y -> false

    let numbers max = seq {for i in 100..max do for j in 100..max do yield (i*j) } |> Seq.filter isPalindrom |> Seq.max

    let n = numbers 999 |> printfn "%d"

    0 // return an integer exit code
