namespace FSharp.Unity3D
  module Mesh = begin
    type t = UnityEngine.Mesh
    type u = UnityEngine.MeshFilter
    val combine : s:seq<u> -> UnityEngine.Mesh
  end
