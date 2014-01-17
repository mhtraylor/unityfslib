namespace FSharp.Unity3D

open UnityEngine

type TransformTest () =
    inherit MonoBehaviour ()

type ObjectTest () =
    inherit MonoBehaviour ()

    member x.Start () =
        let a = Object.find<TransformTest> ()
        let b = Object.findAll<GameObject> ()
        let s0 = a.name
        let s1 = b |> Array.fold (fun s t -> t.name + " " + s) " "
        Debug.Log(s0)
        Debug.Log(s1)




