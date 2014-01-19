[<RequireQualifiedAccess>]
module FSharp.Unity3D.Bounds

open FSharp.Unity3D
open UnityEngine

type t = Bounds

let create ctr size = Bounds(ctr,size)

let intersectRay ray (bnd:t) =
    Option.pout <| bnd.IntersectRay(ray)

let intersects (b0:t) b1 = b0.Intersects(b1)

let getAll g =
    g
    |> GameObject.getAllInChild<Renderer>
    |> Seq.map (fun rdr -> rdr.bounds)

let encap (b0:t) b1 =
    let b' = create b0.center b0.size
    b'.Encapsulate(bounds=b1)
    b'

let encapAll g =
    getAll g
    |> Seq.fold encap g.renderer.bounds

