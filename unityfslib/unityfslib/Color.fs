namespace FSharp.Unity3D

open UnityEngine

[<RequireQualifiedAccess>]
module Color =

    type t = Color

    let map f (c:t) = Color(f c.r, f c.g, f c.b, f c.a)
        
    let map2 f (a:t) (b:t) = Color(f a.r b.r, f a.g b.g, f a.b b.b, f a.a b.a) 
       
    let iter f (c:t) = f c.r; f c.g; f c.b; f c.a

    let iter2 f (a:t) (b:t) = f a.r b.r; f a.g b.g; f a.b b.b; f a.a b.a

    let fold f s (c:t) =
        let rec aux s' (c:t) = function
            | 0 -> s'
            | n -> aux (f s' c.[n - 1]) c (n - 1)
        aux s c 4

    let redf f (c:t) = Color(f c.r, c.g, c.b, c.a)

    let greenf f (c:t) = Color(c.r, f c.g, c.b, c.a)

    let bluef f (c:t) = Color(c.r, c.g, f c.b, c.a)

    let alphaf f (c:t) = Color(c.r, c.g, c.b, f c.a)

    let lerp n a b = Color.Lerp(a, b, n)

[<RequireQualifiedAccess>]
module Color32 =

    type t = Color32

    let map f (c:t) = Color32(f c.r, f c.g, f c.b, f c.a)
        
    let map2 f (a:t) (b:t) = Color32(f a.r b.r, f a.g b.g, f a.b b.b, f a.a b.a)
        
    let iter f (c:t) = f c.r; f c.g; f c.b; f c.a

    let iter2 f (a:t) (b:t) = f a.r b.r; f a.g b.g; f a.b b.b; f a.a b.a

    let fold f s (c:t) =
        [c.r;c.g;c.b;c.a]
        |> List.fold f 0uy

    let redf f (c:t) = Color32(f c.r, c.g, c.b, c.a)

    let greenf f (c:t) = Color32(c.r, f c.g, c.b, c.a)

    let bluef f (c:t) = Color32(c.r, c.g, f c.b, c.a)

    let alphaf f (c:t) = Color32(c.r, c.g, c.b, f c.a)

    let lerp n a b = Color32.Lerp(a, b, n)

