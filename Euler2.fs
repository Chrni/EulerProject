// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 

    let fib = Seq.unfold (fun (x,y) -> Some (x+y, (y, x+y))) (0L,1L) |> Seq.filter (fun f -> f%2L = 0L) |> Seq.takeWhile (fun g -> g< 4000000L) |> Seq.sum |> printfn "%d"

    0 // return an integer exit code
