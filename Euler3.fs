// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 

    let isPrime (n:int64) =
        let rec check i =
            i > n/2L || (n % i <> 0L && check (i + 1L))
        check 2L

    let largestPrime = Seq.unfold(fun (x:int64, y:int64) ->
        match x with
            | x when x>y -> None
            | x when y%x=0L -> Some(x, (x+1L, y/x))
            | x -> Some(0L, (x+1L, y)))(2L, 600851475143L) |> Seq.filter isPrime |> Seq.max |> printfn "%d"

    0 // return an integer exit code
