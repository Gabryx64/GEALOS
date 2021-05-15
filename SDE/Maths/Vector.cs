namespace SDE.Maths
{
    struct Vector2i
    {
        public int x, y;

        public Vector2i(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static explicit operator Vector2f(Vector2i val)
        {
            return new Vector2f((float)val.x, (float)val.y);
        }

        public static Vector2i operator +(Vector2i a) => a;
        public static Vector2i operator +(Vector2i a, Vector2i b) => new Vector2i(a.x + b.x, a.y + b.y);
        public static Vector2i operator ++(Vector2i a) => new Vector2i(a.x + 1, a.y + 1);

        public static Vector2i operator -(Vector2i a) => new Vector2i(0 - a.x, 0 - a.y);
        public static Vector2i operator -(Vector2i a, Vector2i b) => new Vector2i(a.x - b.x, a.y - b.y);
        public static Vector2i operator --(Vector2i a) => new Vector2i(a.x - 1, a.y - 1);

        public static Vector2i operator *(Vector2i a, Vector2i b) => new Vector2i(a.x * b.x, a.y * b.y);
        public static Vector2i operator *(Vector2i a, int b) => new Vector2i(a.x * b, a.y * b);

        public static Vector2i operator /(Vector2i a, Vector2i b) => new Vector2i(a.x / b.x, a.y / b.y);
        public static Vector2i operator /(Vector2i a, int b) => new Vector2i(a.x / b, a.y / b);

        public static Vector2i operator %(Vector2i a, Vector2i b) => new Vector2i(a.x % b.x, a.y % b.y);
        public static Vector2i operator %(Vector2i a, int b) => new Vector2i(a.x % b, a.y % b);

        public static Vector2i operator ^(Vector2i a, Vector2i b) => new Vector2i(a.x ^ b.x, a.y ^ b.x);
        public static Vector2i operator ^(Vector2i a, int b) => new Vector2i(a.x ^ b, a.y ^ b);

        public override string ToString() => $"{{{x}, {y}}}";
    }

    struct Vector3i
    {
        int x, y, z;

        public Vector3i(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static explicit operator Vector3f(Vector3i val)
        {
            return new Vector3f((float)val.x, (float)val.y, (float)val.z);
        }

        public static Vector3i operator +(Vector3i a) => a;
        public static Vector3i operator +(Vector3i a, Vector3i b) => new Vector3i(a.x + b.x, a.y + b.y, a.z + b.z);
        public static Vector3i operator ++(Vector3i a) => new Vector3i(a.x + 1, a.y + 1, a.z + 1);

        public static Vector3i operator -(Vector3i a) => new Vector3i(0 - a.x, 0 - a.y, 0 - a.z);
        public static Vector3i operator -(Vector3i a, Vector3i b) => new Vector3i(a.x - b.x, a.y - b.y, a.z - b.z);
        public static Vector3i operator --(Vector3i a) => new Vector3i(a.x - 1, a.y - 1, a.z - 1);

        public static Vector3i operator *(Vector3i a, Vector3i b) => new Vector3i(a.x * b.x, a.y * b.y, a.z * b.z);
        public static Vector3i operator *(Vector3i a, int b) => new Vector3i(a.x * b, a.y * b, a.z * b);

        public static Vector3i operator /(Vector3i a, Vector3i b) => new Vector3i(a.x / b.x, a.y / b.y, a.z / b.z);
        public static Vector3i operator /(Vector3i a, int b) => new Vector3i(a.x / b, a.y / b, a.z / b);

        public static Vector3i operator %(Vector3i a, Vector3i b) => new Vector3i(a.x % b.x, a.y % b.y, a.z % b.z);
        public static Vector3i operator %(Vector3i a, int b) => new Vector3i(a.x % b, a.y % b, a.z % b);

        public static Vector3i operator ^(Vector3i a, Vector3i b) => new Vector3i(a.x ^ b.x, a.y ^ b.x, a.z ^ b.z);
        public static Vector3i operator ^(Vector3i a, int b) => new Vector3i(a.x ^ b, a.y ^ b, a.z ^ b);

        public override string ToString() => $"{{{x}, {y}, {z}}}";
    }

    struct Vector2f
    {
        public float x, y;

        public Vector2f(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static explicit operator Vector2i(Vector2f val)
        {
            return new Vector2i((int)val.x, (int)val.y);
        }

        public static Vector2f operator +(Vector2f a) => a;
        public static Vector2f operator +(Vector2f a, Vector2f b) => new Vector2f(a.x + b.x, a.y + b.y);
        public static Vector2f operator ++(Vector2f a) => new Vector2f(a.x + 1, a.y + 1);

        public static Vector2f operator -(Vector2f a) => new Vector2f(0 - a.x, 0 - a.y);
        public static Vector2f operator -(Vector2f a, Vector2f b) => new Vector2f(a.x - b.x, a.y - b.y);
        public static Vector2f operator --(Vector2f a) => new Vector2f(a.x - 1, a.y - 1);

        public static Vector2f operator *(Vector2f a, Vector2f b) => new Vector2f(a.x * b.x, a.y * b.y);
        public static Vector2f operator *(Vector2f a, int b) => new Vector2f(a.x * b, a.y * b);

        public static Vector2f operator /(Vector2f a, Vector2f b) => new Vector2f(a.x / b.x, a.y / b.y);
        public static Vector2f operator /(Vector2f a, int b) => new Vector2f(a.x / b, a.y / b);

        public static Vector2f operator %(Vector2f a, Vector2f b) => new Vector2f(a.x % b.x, a.y % b.y);
        public static Vector2f operator %(Vector2f a, int b) => new Vector2f(a.x % b, a.y % b);

        public override string ToString() => $"{{{x}, {y}}}";
    }

    struct Vector3f
    {
        float x, y, z;

        public Vector3f(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static explicit operator Vector3i(Vector3f val)
        {
            return new Vector3i((int)val.x, (int)val.y, (int)val.z);
        }

        public static Vector3f operator +(Vector3f a) => a;
        public static Vector3f operator +(Vector3f a, Vector3f b) => new Vector3f(a.x + b.x, a.y + b.y, a.z + b.z);
        public static Vector3f operator ++(Vector3f a) => new Vector3f(a.x + 1, a.y + 1, a.z + 1);

        public static Vector3f operator -(Vector3f a) => new Vector3f(0 - a.x, 0 - a.y, 0 - a.z);
        public static Vector3f operator -(Vector3f a, Vector3f b) => new Vector3f(a.x - b.x, a.y - b.y, a.z - b.z);
        public static Vector3f operator --(Vector3f a) => new Vector3f(a.x - 1, a.y - 1, a.z - 1);

        public static Vector3f operator *(Vector3f a, Vector3f b) => new Vector3f(a.x * b.x, a.y * b.y, a.z * b.z);
        public static Vector3f operator *(Vector3f a, int b) => new Vector3f(a.x * b, a.y * b, a.z * b);

        public static Vector3f operator /(Vector3f a, Vector3f b) => new Vector3f(a.x / b.x, a.y / b.y, a.z / b.z);
        public static Vector3f operator /(Vector3f a, int b) => new Vector3f(a.x / b, a.y / b, a.z / b);

        public static Vector3f operator %(Vector3f a, Vector3f b) => new Vector3f(a.x % b.x, a.y % b.y, a.z % b.z);
        public static Vector3f operator %(Vector3f a, int b) => new Vector3f(a.x % b, a.y % b, a.z % b);

        public override string ToString() => $"{{{x}, {y}, {z}}}";
    }
}
