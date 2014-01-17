[<RequireQualifiedAccess>]
module FSharp.Unity3D.Plane

open UnityEngine

let upward pos = Plane (Vector3.up, inPoint=pos)

let raycast ray (plane:Plane) = plane.Raycast(ray) |> Option.pout

