namespace FSharp.Unity3D

open UnityEngine

[<RequireQualifiedAccess>]
module Vector2 =

    type t = Vector2

    let map f (v:t) = Vector2(f v.x, f v.y)

    let map2 f (a:t) (b:t) = Vector2(f a.x b.x, f a.y b.y)

    let iter f (v:t) = f v.x; f v.y

    let iter2 f (a:t) (b:t) = f a.x b.x; f a.y b.y

    let fold f s (v:t) =
        let rec aux s' (v:t) = function
            | 0 -> s'
            | n -> aux (f s' v.[n - 1]) v (n - 1)
        aux s v 2

    let normalize (v:t) = v.normalized

    let magnitude (v:t) = v.magnitude

    let sqrmagnitude (v:t) = v.sqrMagnitude

    let move n cur tar = Vector2.MoveTowards(cur, tar, n)

    let scale a b = Vector2.Scale(a, b)

    let lerp n a b = Vector2.Lerp(a, b, n)

    let dot a b = Vector2.Dot(a, b)

    let angle a b = Vector2.Angle(a, b)

    let distance a b = Vector2.Distance(a, b)

    let clampmag len v = Vector2.ClampMagnitude(v, len)

    let min a b = Vector2.Min(a, b)

    let max a b = Vector2.Max(a, b)

[<RequireQualifiedAccess>]
module Vector3 =

    type t = Vector3

    let map f (v:t) = Vector3(f v.x, f v.y, f v.z)

    let map2 f (a:t) (b:t) = Vector3(f a.x b.x, f a.y b.y, f a.z b.z)

    let iter f (v:t) = f v.x; f v.y; f v.z

    let iter2 f (a:t) (b:t) = f a.x b.x; f a.y b.y; f a.z b.z

    let fold f s (v:t) =
        let rec aux s' (v:t) = function
            | 0 -> s'
            | n -> aux (f s' v.[n - 1]) v (n - 1)
        aux s v 3

    let normalize (v:t) = v.normalized

    let magnitude (v:t) = v.magnitude

    let sqrmagnitude (v:t) = v.sqrMagnitude
    
    let move n cur tar = Vector3.MoveTowards(cur, tar, n)

    let rotate rad mag cur tar = Vector3.RotateTowards(cur, tar, rad, mag)

    let scale a b = Vector3.Scale(a, b)

    let cross a b = Vector3.Cross(a, b)

    let reflect dir norm = Vector3.Reflect(dir, norm)

    let lerp n a b = Vector3.Lerp(a, b, n)

    let slerp n a b = Vector3.Slerp(a, b, n)

    let dot a b = Vector3.Dot(a, b)

    let angle a b = Vector3.Angle(a, b)

    let distance a b = Vector3.Distance(a, b)

    let clampmag len v = Vector3.ClampMagnitude(v, len)

    let min a b = Vector3.Min(a, b)

    let max a b = Vector3.Max(a, b)

[<RequireQualifiedAccess>]
module Vector4 =

    type t = Vector4
        
    let map f (v:t) = Vector4(f v.x, f v.y, f v.z, f v.w) 
       
    let map2 f (a:t) (b:t) = Vector4(f a.x b.x, f a.y b.y, f a.z b.z, f a.z b.z)  
      
    let iter f (v:t) = f v.x; f v.y; f v.z; f v.w

    let iter2 f (a:t) (b:t) = f a.x b.x; f a.y b.y; f a.z b.z; f a.z b.z

    let fold f s (v:t) =
        let rec aux s' (v:t) = function
            | 0 -> s'
            | n -> aux (f s' v.[n - 1]) v (n - 1)
        aux s v 4

    let normalize (v:t) = v.normalized

    let magnitude (v:t) = v.magnitude

    let sqrmagnitude (v:t) = v.sqrMagnitude

    let move n cur tar = Vector4.MoveTowards(cur, tar, n)

    let scale a b = Vector4.Scale(a, b)

    let lerp n a b = Vector4.Lerp(a, b, n)

    let dot a b = Vector4.Dot(a, b)

    let project a b = Vector4.Project(a, b)

    let distance a b = Vector4.Distance(a, b)

    let min a b = Vector4.Min(a, b)

    let max a b = Vector4.Max(a, b)
