namespace FSharp.Unity3D
  module Vector2 = begin
    type t = UnityEngine.Vector2
    val map : f:(float32 -> float32) -> v:t -> UnityEngine.Vector2
    val map2 :
      f:(float32 -> float32 -> float32) -> a:t -> b:t -> UnityEngine.Vector2
    val iter : f:(float32 -> unit) -> v:t -> unit
    val iter2 : f:(float32 -> float32 -> unit) -> a:t -> b:t -> unit
    val fold : f:('a -> float32 -> 'a) -> s:'a -> v:t -> 'a
    val normalize : v:t -> UnityEngine.Vector2
    val magnitude : v:t -> float32
    val sqrmagnitude : v:t -> float32
    val move :
      n:float32 ->
        cur:UnityEngine.Vector2 ->
          tar:UnityEngine.Vector2 -> UnityEngine.Vector2
    val scale :
      a:UnityEngine.Vector2 -> b:UnityEngine.Vector2 -> UnityEngine.Vector2
    val lerp :
      n:float32 ->
        a:UnityEngine.Vector2 -> b:UnityEngine.Vector2 -> UnityEngine.Vector2
    val dot : a:UnityEngine.Vector2 -> b:UnityEngine.Vector2 -> float32
    val angle : a:UnityEngine.Vector2 -> b:UnityEngine.Vector2 -> float32
    val distance : a:UnityEngine.Vector2 -> b:UnityEngine.Vector2 -> float32
    val clampmag : len:float32 -> v:UnityEngine.Vector2 -> UnityEngine.Vector2
    val min :
      a:UnityEngine.Vector2 -> b:UnityEngine.Vector2 -> UnityEngine.Vector2
    val max :
      a:UnityEngine.Vector2 -> b:UnityEngine.Vector2 -> UnityEngine.Vector2
  end
  module Vector3 = begin
    type t = UnityEngine.Vector3
    val map : f:(float32 -> float32) -> v:t -> UnityEngine.Vector3
    val map2 :
      f:(float32 -> float32 -> float32) -> a:t -> b:t -> UnityEngine.Vector3
    val iter : f:(float32 -> unit) -> v:t -> unit
    val iter2 : f:(float32 -> float32 -> unit) -> a:t -> b:t -> unit
    val fold : f:('a -> float32 -> 'a) -> s:'a -> v:t -> 'a
    val normalize : v:t -> UnityEngine.Vector3
    val magnitude : v:t -> float32
    val sqrmagnitude : v:t -> float32
    val move :
      n:float32 ->
        cur:UnityEngine.Vector3 ->
          tar:UnityEngine.Vector3 -> UnityEngine.Vector3
    val rotate :
      rad:float32 ->
        mag:float32 ->
          cur:UnityEngine.Vector3 ->
            tar:UnityEngine.Vector3 -> UnityEngine.Vector3
    val scale :
      a:UnityEngine.Vector3 -> b:UnityEngine.Vector3 -> UnityEngine.Vector3
    val cross :
      a:UnityEngine.Vector3 -> b:UnityEngine.Vector3 -> UnityEngine.Vector3
    val reflect :
      dir:UnityEngine.Vector3 -> norm:UnityEngine.Vector3 -> UnityEngine.Vector3
    val lerp :
      n:float32 ->
        a:UnityEngine.Vector3 -> b:UnityEngine.Vector3 -> UnityEngine.Vector3
    val slerp :
      n:float32 ->
        a:UnityEngine.Vector3 -> b:UnityEngine.Vector3 -> UnityEngine.Vector3
    val dot : a:UnityEngine.Vector3 -> b:UnityEngine.Vector3 -> float32
    val angle : a:UnityEngine.Vector3 -> b:UnityEngine.Vector3 -> float32
    val distance : a:UnityEngine.Vector3 -> b:UnityEngine.Vector3 -> float32
    val clampmag : len:float32 -> v:UnityEngine.Vector3 -> UnityEngine.Vector3
    val min :
      a:UnityEngine.Vector3 -> b:UnityEngine.Vector3 -> UnityEngine.Vector3
    val max :
      a:UnityEngine.Vector3 -> b:UnityEngine.Vector3 -> UnityEngine.Vector3
  end
  module Vector4 = begin
    type t = UnityEngine.Vector4
    val map : f:(float32 -> float32) -> v:t -> UnityEngine.Vector4
    val map2 :
      f:(float32 -> float32 -> float32) -> a:t -> b:t -> UnityEngine.Vector4
    val iter : f:(float32 -> unit) -> v:t -> unit
    val iter2 : f:(float32 -> float32 -> unit) -> a:t -> b:t -> unit
    val fold : f:('a -> float32 -> 'a) -> s:'a -> v:t -> 'a
    val normalize : v:t -> UnityEngine.Vector4
    val magnitude : v:t -> float32
    val sqrmagnitude : v:t -> float32
    val move :
      n:float32 ->
        cur:UnityEngine.Vector4 ->
          tar:UnityEngine.Vector4 -> UnityEngine.Vector4
    val scale :
      a:UnityEngine.Vector4 -> b:UnityEngine.Vector4 -> UnityEngine.Vector4
    val lerp :
      n:float32 ->
        a:UnityEngine.Vector4 -> b:UnityEngine.Vector4 -> UnityEngine.Vector4
    val dot : a:UnityEngine.Vector4 -> b:UnityEngine.Vector4 -> float32
    val project :
      a:UnityEngine.Vector4 -> b:UnityEngine.Vector4 -> UnityEngine.Vector4
    val distance : a:UnityEngine.Vector4 -> b:UnityEngine.Vector4 -> float32
    val min :
      a:UnityEngine.Vector4 -> b:UnityEngine.Vector4 -> UnityEngine.Vector4
    val max :
      a:UnityEngine.Vector4 -> b:UnityEngine.Vector4 -> UnityEngine.Vector4
  end
