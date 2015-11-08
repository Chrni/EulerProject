// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 

    let filter35 x = 
        x%3=0 || x%5=0

    let divisible35 = Seq.initInfinite (fun f -> f) |> Seq.filter filter35 |> Seq.takeWhile (fun z -> z<1000) |> Seq.sum |> printfn "%d"

    0 // return an integer exit code
