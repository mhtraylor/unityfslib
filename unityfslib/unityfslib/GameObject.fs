[<RequireQualifiedAccess>]
module FSharp.Unity3D.GameObject

open UnityEngine

type t = GameObject
type u = Component

let add<'a when 'a :> u> (g:t) = g.AddComponent<'a>()

let get<'a when 'a :> u> (g:t) = Object.exists <| g.GetComponent<'a>()

let getInChild<'a when 'a :> u> (g:t) = Object.exists <| g.GetComponentInChildren<'a>()

let getAll<'a when 'a :> u> (g:t) = 
    g.GetComponents<'a>() 
    |> Array.map Object.exists
    |> Array.filter Option.isSome

let getAllInChild<'a when 'a :> u> (g:t) = g.GetComponentsInChildren<'a>() |> Array.map Object.exists

let activate (g:t) = g.SetActive(true)

let deactivate (g:t) = g.SetActive(false)

let empty = Unchecked.defaultof<t>

