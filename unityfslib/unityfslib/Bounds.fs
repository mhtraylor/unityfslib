[<RequireQualifiedAccess>]
module FSharp.Unity3D.Bounds

open FSharp.Unity3D
open UnityEngine

type t = Bounds

let create c s = Bounds(c,s)

let intersectRay r (b:t) = b.IntersectRay(ray=r)

let intersectRayDist d r (b:t) = 
    let d' = ref d
    if b.IntersectRay(ray=r,distance=d') then
        Some !d'
    else
        None

let intersects (b0:t) b1 = b0.Intersects(b1)

let sqrdist p (b:t) = b.SqrDistance(p)

let getAll (g:GameObject) =
    GameObject.getChildComponents<Renderer> g
    |> Array.map (Option.fold (fun _ x -> x.bounds) g.renderer.bounds)

let encapAllunsafe (g:GameObject) = 
    g.GetComponentsInChildren<Renderer>() 
    |> Array.iter (fun x -> g.renderer.bounds.Encapsulate(x.bounds))

let encapAll (g:GameObject) = g |> getAll |> Array.iter (fun x -> g.renderer.bounds.Encapsulate(x))

