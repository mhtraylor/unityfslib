[<RequireQualifiedAccess>]
module FSharp.Unity3D.Physics

open UnityEngine

let RayCast ray dist =
    let mutable r = new RaycastHit()
    match Physics.Raycast(ray,&r,dist) with
       | true  -> Some(r)
       | false -> None

type point = Vector3

type direction = Vector3

type radius = float32

type Shape =
    | Line of point * point
    | Sphere of point * radius
    | Capsule of point * point * radius

let line p0 p1 = Line (p0,p1)

let sphere rad pos = Sphere (pos,rad)

let capsule rad p0 p1 = Capsule (p0,p1,rad)

let checkLayer layer_mask = function
    | Line (s,e) -> Physics.Linecast(s,e,layerMask=layer_mask)
    | Sphere (p,r) -> Physics.CheckSphere(p,r,layer_mask)
    | Capsule (s,e,r) -> Physics.CheckCapsule(s,e,r,layer_mask)

let check = checkLayer Physics.DefaultRaycastLayers

let castLayer layer_mask dist dir shape =
    let mutable hit = RaycastHit()
    match shape with
    | Line (s,e) -> Physics.Linecast(s,e,&hit,layer_mask)
    | Sphere (p,r) -> Physics.SphereCast(p,r,dir,&hit,dist,layer_mask)
    | Capsule (s,e,r) -> Physics.CapsuleCast(s,e,r,dir,&hit,dist) 
    |> Option.fromBool hit

let cast dir = castLayer Physics.DefaultRaycastLayers Mathf.Infinity dir 