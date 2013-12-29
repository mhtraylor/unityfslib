[<AutoOpen>]
module FSharp.Unity3D.Base


// Module extensions.
module Array =

    // In-place array modification, useful for Mesh vertices, Particles, etc.
    let apply f a =
        a |> Array.iteri (fun i x -> a.[i] <- f x)
        a

module Option =

    let fromBool v = function true -> Some v | _ -> None

