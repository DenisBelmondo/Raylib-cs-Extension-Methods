using System.Numerics;
using System.Runtime.CompilerServices;
using static Raylib_cs.Raymath;

namespace Belmondo.Extensions.Raylib
{
    public static class Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(this Vector2 @this, Vector2 v)
            => Vector2DotProduct(@this, v);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float DistanceTo(this Vector2 @this, Vector2 v)
            => Vector2Distance(@this, v);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float AngleTo(this Vector2 @this, Vector2 v)
            => Vector2Angle(@this, v);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Negated(this Vector2 @this)
            => new Vector2(-@this.X, -@this.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Normalized(this Vector2 @this)
        {
            if (@this.LengthSquared() <= float.Epsilon)
            {
                return Vector2.Zero;
            }

            return Vector2Normalize(@this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Lerp(this Vector2 @this, Vector2 v, float t)
            => Vector2Lerp(@this, v, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Rotated(this Vector2 @this, float degs)
            => Vector2Rotate(@this, degs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (int X, int Y) Quantize(this Vector2 @this)
            => ((int)@this.X, (int)@this.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Normalized(this Vector3 @this)
        {
            if (@this.LengthSquared() <= float.Epsilon)
            {
                return Vector3.Zero;
            }

            return Vector3Normalize(@this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Cross(this Vector3 @this, Vector3 v)
            => Vector3CrossProduct(@this, v);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Perp(this Vector3 @this)
            => Vector3Perpendicular(@this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(this Vector3 @this, Vector3 v)
            => Vector3DotProduct(@this, v);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float DistanceTo(this Vector3 @this, Vector3 v)
            => Vector3Distance(@this, v);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Negated(this Vector3 @this)
            => Vector3Negate(@this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Transformed(this Vector3 @this, Matrix4x4 m)
            => Vector3Transform(@this, m);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Rotated(this Vector3 @this, Quaternion q)
            => Vector3RotateByQuaternion(@this, q);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Lerp(this Vector3 @this, Vector3 v, float t)
            => Vector3Lerp(@this, v, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Reflected(this Vector3 @this, Vector3 normal)
            => Vector3Reflect(@this, normal);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Extrude(this Vector2 @this)
            => new Vector3(@this.X, 0.0f, @this.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Flatten(this Vector3 @this)
            => new Vector2(@this.X, @this.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (int X, int Y, int Z) Quantize(this Vector3 @this)
            => ((int)@this.X, (int)@this.Y, (int)@this.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 ToVector2(this (int X, int Y) @this)
            => new Vector2(@this.X, @this.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ToVector3(this (int X, int Y, int Z) @this)
            => new Vector3(@this.X, @this.Y, @this.Z);
    }
}
