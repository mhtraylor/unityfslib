[<RequireQualifiedAccess>]
module FSharp.Unity3D.Object

open UnityEngine

type t = UnityEngine.Object

let empty = Unchecked.defaultof<t>

let exists (o:#t) =  o.Equals(null) |> not |> Option.cond o

let find<'a when 'a :> t> () = Object.FindObjectOfType<'a>()

let findAll<'a when 'a :> t> () = 
    Object.FindObjectsOfType<'a>()

let instantiate (o:#t) = Object.Instantiate(o)

let instantiateAt v q (o:#t) = Object.Instantiate(o,v,q)