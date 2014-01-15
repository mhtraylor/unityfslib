namespace FSharp.Unity3D
  module GameObject = begin
    type t = UnityEngine.GameObject
    type u = UnityEngine.Component
    val add : g:t -> #u
    val get : g:t -> #u option
    val getInChild : g:t -> #u option
    val getAll : g:t -> #u option []
    val getAllInChild : g:t -> #u option []
    val activate : g:t -> unit
    val deactivate : g:t -> unit
    val empty : t
  end
