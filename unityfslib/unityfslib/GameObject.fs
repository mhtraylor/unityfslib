[<RequireQualifiedAccess>]
module FSharp.Unity3D.GameObject

open UnityEngine

type t = GameObject
type u = Component

let empty = Unchecked.defaultof<t>

let add<'a when 'a :> u> (g:t) = 
    g.AddComponent<'a>()

let get<'a when 'a :> u> (g:t) = 
    g.GetComponent<'a>() |> Object.exists    

let getInChild<'a when 'a :> u> (g:t) = 
    g.GetComponentInChildren<'a>() |> Object.exists

// FIX -- GetComponents can return null array!
let getAll<'a when 'a :> u> (g:t) = 
    g.GetComponents<'a>()
    |> Seq.choose Object.exists

// FIX -- GetComponents can return null array!
let getAllInChild<'a when 'a :> u> (g:t) = 
    g.GetComponentsInChildren<'a>() 
    |> Seq.choose Object.exists

let activate (g:t) = g.SetActive(true)

let deactivate (g:t) = g.SetActive(false)

