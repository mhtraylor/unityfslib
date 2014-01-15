namespace FSharp.Unity3D
  module Color = begin
    type t = UnityEngine.Color
    val map : f:(float32 -> float32) -> c:t -> UnityEngine.Color
    val map2 :
      f:(float32 -> float32 -> float32) -> a:t -> b:t -> UnityEngine.Color
    val iter : f:(float32 -> unit) -> c:t -> unit
    val iter2 : f:(float32 -> float32 -> unit) -> a:t -> b:t -> unit
    val fold : f:('a -> float32 -> 'a) -> s:'a -> c:t -> 'a
    val redf : f:(float32 -> float32) -> c:t -> UnityEngine.Color
    val greenf : f:(float32 -> float32) -> c:t -> UnityEngine.Color
    val bluef : f:(float32 -> float32) -> c:t -> UnityEngine.Color
    val alphaf : f:(float32 -> float32) -> c:t -> UnityEngine.Color
    val lerp :
      n:float32 ->
        a:UnityEngine.Color -> b:UnityEngine.Color -> UnityEngine.Color
  end
  module Color32 = begin
    type t = UnityEngine.Color32
    val map : f:(byte -> byte) -> c:t -> UnityEngine.Color32
    val map2 : f:(byte -> byte -> byte) -> a:t -> b:t -> UnityEngine.Color32
    val iter : f:(byte -> unit) -> c:t -> unit
    val iter2 : f:(byte -> byte -> unit) -> a:t -> b:t -> unit
    val fold : f:(byte -> byte -> byte) -> s:'a -> c:t -> byte
    val redf : f:(byte -> byte) -> c:t -> UnityEngine.Color32
    val greenf : f:(byte -> byte) -> c:t -> UnityEngine.Color32
    val bluef : f:(byte -> byte) -> c:t -> UnityEngine.Color32
    val alphaf : f:(byte -> byte) -> c:t -> UnityEngine.Color32
    val lerp :
      n:float32 ->
        a:UnityEngine.Color32 -> b:UnityEngine.Color32 -> UnityEngine.Color32
  end
