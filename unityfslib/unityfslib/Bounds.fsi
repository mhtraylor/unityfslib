namespace FSharp.Unity3D
  module Bounds = begin
    type t = UnityEngine.Bounds
    val create :
      c:UnityEngine.Vector3 -> s:UnityEngine.Vector3 -> UnityEngine.Bounds
    val intersectRay : r:UnityEngine.Ray -> b:t -> bool
    val intersectRayDist :
      d:float32 -> r:UnityEngine.Ray -> b:t -> float32 option
    val intersects : b0:t -> b1:UnityEngine.Bounds -> bool
    val sqrdist : p:UnityEngine.Vector3 -> b:t -> float32
    val getAll : g:UnityEngine.GameObject -> UnityEngine.Bounds []
    val encapAllunsafe : g:UnityEngine.GameObject -> unit
    val encapAll : g:UnityEngine.GameObject -> unit
  end
