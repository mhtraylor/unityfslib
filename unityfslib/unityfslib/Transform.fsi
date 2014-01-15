namespace FSharp.Unity3D
  module Transform = begin
    type t = UnityEngine.Transform
    val getChild : idx:int -> p:t -> UnityEngine.Transform
    val empty : t
    val toSeq : p:t -> seq<t>
    val toList : (t -> t list)
    val toArray : (t -> t [])
  end
