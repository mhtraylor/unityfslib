[<RequireQualifiedAccess>]
module FSharp.Unity3D.Object

open UnityEngine

type t = UnityEngine.Object

let find<'a when 'a :> t> () = Object.FindObjectOfType<'a>()

let findAll<'a when 'a :> t> () = 
    Object.FindObjectsOfType<'a>()
    |> Seq.cast<'a>

let instantiate (o:#t) = Object.Instantiate(o)

let instantiateAt v q (o:#t) = Object.Instantiate(o,v,q)


let empty = Unchecked.defaultof<t>

let exists (o:#t) = if obj.ReferenceEquals(o,null) then None else Some o



         

