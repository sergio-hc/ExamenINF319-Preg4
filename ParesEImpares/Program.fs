// Learn more about F# at http://fsharp.org

//SERGIO LUIS HUANCA CUELLAR 
//INF 319
open System

[<EntryPoint>]
let main argv =
    let lista = [1..10]
    printf "Lista completa %A\n" lista
    let lpares = [for i in lista do if i%2 = 0 then i]
    let limpares = [for i in lista do if i%2 = 1 then i]
        
    printf "Lista de Pares %A\n" lpares
    printf "Lista de impares %A" limpares

    Console.ReadKey() |> ignore
    0 // return an integer exit code
