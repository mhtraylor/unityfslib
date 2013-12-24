[<RequireQualifiedAccess>]
module FSharp.Unity3D.Physics

open UnityEngine

let RayCast ray dist =
    let mutable r = new RaycastHit()
    match Physics.Raycast(ray,&r,dist) with
       | true  -> Some(r)
       | false -> None