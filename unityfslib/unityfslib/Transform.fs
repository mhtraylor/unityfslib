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

let toSeq (p:t) = Seq.cast<t> p

let toList = toSeq >> Seq.toList

let toArray = toSeq >> Seq.toArray


