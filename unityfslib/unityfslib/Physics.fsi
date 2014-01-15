namespace FSharp.Unity3D
  module Physics = begin
    val raycast :
      dist:float32 option ->
        ray:UnityEngine.Ray -> UnityEngine.RaycastHit option
    val raycastf :
      f:(UnityEngine.RaycastHit -> 'a option) ->
        dist:float32 option -> (UnityEngine.Ray -> 'a option)
  end
