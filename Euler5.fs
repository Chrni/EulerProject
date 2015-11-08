// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 

    let isDivisible x = 
        let rec check i = 
            match i with
                | i when i<1 -> true
                | i when x%i=0 -> check(i-1) 
                | _ -> false
        check 20


    Seq.initInfinite (fun x -> x+1)
           |> Seq.filter isDivisible
           |> Seq.take 1
           |> printf "%A"

    0 // return an integer exit code
