// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    
    let isPrime (n) =
        let rec check i =
            i > n/2L || (n % i <> 0L && check (i + 1L))
        check 2L

    let trial_division = 
        seq { for i in 1L..2000000L do
                if isPrime i then yield i }
        |> Seq.sum

    let x = trial_division |> printfn "%A"


    0 // return an integer exit code
