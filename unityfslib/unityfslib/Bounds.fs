[<RequireQualifiedAccess>]
module FSharp.Unity3D.Bounds

open FSharp.Unity3D
open UnityEngine

type t = Bounds

let create ctr size = Bounds(ctr,size)

let contains (b0:t) v = b0.Contains(v)

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

let split (bnd:t) =
    let ext = bnd.extents |> Vector3.map (( * ) 0.5f)
    let ctr = bnd.center
    let chd =
      [ Vector3(ctr.x + ext.x, ctr.y + ext.y, ctr.z + ext.z);
        Vector3(ctr.x + ext.x, ctr.y + ext.y, ctr.z - ext.z);
        Vector3(ctr.x + ext.x, ctr.y - ext.y, ctr.z + ext.z);
        Vector3(ctr.x + ext.x, ctr.y - ext.y, ctr.z - ext.z);
        Vector3(ctr.x - ext.x, ctr.y + ext.y, ctr.z + ext.z);
        Vector3(ctr.x - ext.x, ctr.y + ext.y, ctr.z - ext.z);
        Vector3(ctr.x - ext.x, ctr.y - ext.y, ctr.z + ext.z);
        Vector3(ctr.x - ext.x, ctr.y - ext.y, ctr.z - ext.z) ]
    chd |> List.map (fun x -> create x bnd.extents)

