[<RequireQualifiedAccess>]
module FSharp.Unity3D.Physics

open UnityEngine

let raycast dist ray =
    let d = defaultArg dist Mathf.Infinity
    let mutable r = RaycastHit ()
    Physics.Raycast(ray,&r,d)
    |> Option.cond r

let raycastf f dist =
    raycast dist >> Option.map f

// FIX -- RaycastAll may return null array!
let raycastAll dist ray =
    let d = defaultArg dist Mathf.Infinity
    let a = Physics.RaycastAll(ray,d)
    a |> Array.isEmpty |> Option.cond a
 
