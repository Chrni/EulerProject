// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    
    let square x = x*x

    let calA m n = square n - square m
    let calB m n = 2*n*m
    let calC m n = square n + square m

    let isPyth (a : int list) = 
        (square a.[0] + square a.[1] = square a.[2])

    let is1000 (a : int list) = 
        (a.[0] + a.[1] + a.[2] = 1000)


    
    let x = seq {for i in 1..1000 do
                    for j in (i+1)..1000 do 
                        yield [calA i j; calB i j; calC i j]} |> Seq.filter is1000 |> Seq.filter isPyth

    x |> Seq.map (fun b ->(List.fold(fun a x -> a*x) 1 b)) |> printfn "%A"


    0 // return an integer exit code
