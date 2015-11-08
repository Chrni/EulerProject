// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 

    let isPrime (n) =
        let rec check i =
            i > n/2 || (n % i <> 0 && check (i + 1))
        check 2

    
    let findPrime = Seq.initInfinite (fun (x) -> x+2) |> Seq.filter isPrime |> Seq.take  10001 |> Seq.max |> printfn "%d"

    0 // return an integer exit code
