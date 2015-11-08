// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 

    let kvadrat x = x*x

    let sumaKvadrata n = 
        [1..n] 
        |> List.map kvadrat
        |> List.sum

    let aritmetickiNiz a1 an = 
        50*(a1+an)

    let y = aritmetickiNiz 1 100 
    let x = sumaKvadrata 100

    let z = y*y - x |> printfn "%d"

    0 // return an integer exit code
