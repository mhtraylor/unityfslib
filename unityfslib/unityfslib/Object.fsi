namespace FSharp.Unity3D
  module Object = begin
    type t = UnityEngine.Object
    val find : unit -> #t
    val findAll : unit -> seq<#t>
    val instantiate : o:#t -> UnityEngine.Object
    val instantiateAt :
      v:UnityEngine.Vector3 ->
        q:UnityEngine.Quaternion -> o:#t -> UnityEngine.Object
    val empty : t
    val exists : o:'a -> 'a option when 'a :> t
  end
