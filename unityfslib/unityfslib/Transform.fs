[<RequireQualifiedAccess>]
module FSharp.Unity3D.Transform

open UnityEngine

type t = Transform

let getChild idx (p:t) = 
    match idx with
    | i when i > p.childCount -> 
        invalidArg "idx" "Transform.getChild: child index out of bounds."
    | i -> p.GetChild(i)

let empty = Unchecked.defaultof<t>

let rec flatten (p:t) = seq {
    yield p
    for tr in Seq.cast<t> p do
        yield! flatten tr
    }

let toSeq = flatten

let toList = flatten >> Seq.toList

let toArray = flatten >> Seq.toArray


 
