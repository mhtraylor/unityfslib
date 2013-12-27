[<AutoOpen>]
module FSharp.Unity3D.Base

module Option =

    let rev v = function true -> Some v | _ -> None

