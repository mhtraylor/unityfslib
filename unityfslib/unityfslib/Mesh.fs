[<RequireQualifiedAccess>]
module FSharp.Unity3D.Mesh

open UnityEngine

type t = Mesh

type u = MeshFilter

let combine (s : seq<u>) =
    let m = Mesh()
    let f (m:u) =
        let mutable c = CombineInstance()
        c.mesh <- m.sharedMesh
        c.transform <- m.transform.localToWorldMatrix
        c
    s |> Seq.map f |> Seq.toArray |> m.CombineMeshes
    m


        
     


