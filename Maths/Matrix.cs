namespace SDE.Maths
{
    struct Matrix2
    {
        private int[,] matrix;

        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public Matrix2(int initValue)
        {
            matrix = new int[2, 2];
            for (int row = 0; row < 2; row++)
                for (int col = 0; col < 2; col++)
                    matrix[row, col] = initValue;
        }

        public Matrix2(int v00, int v01, int v10, int v11)
        {
            matrix = new int[2, 2];

            matrix[0, 0] = v00; matrix[0, 1] = v01;
            matrix[1, 0] = v10; matrix[1, 1] = v11;
        }

        public static Matrix2 operator +(Matrix2 a) => a;

        public static Matrix2 operator +(Matrix2 a, Matrix2 b)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = a[i, j] + b[i, j];

            return ret;
        }

        public static Matrix2 operator -(Matrix2 a)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = 0 - a[i, j];

            return ret;
        }

        public static Matrix2 operator -(Matrix2 a, Matrix2 b)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = a[i, j] - b[i, j];

            return ret;
        }

        public static Matrix2 operator *(Matrix2 a, Matrix2 b)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = a[i, j] * b[i, j];

            return ret;
        }

        public static Matrix2 operator *(Matrix2 a, int b)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = a[i, j] * b;

            return ret;
        }

        public static Matrix2 operator /(Matrix2 a, Matrix2 b)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = a[i, j] / b[i, j];

            return ret;
        }

        public static Matrix2 operator /(Matrix2 a, int b)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = a[i, j] / b;

            return ret;
        }

        public static Matrix2 operator %(Matrix2 a, Matrix2 b)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = a[i, j] % b[i, j];

            return ret;
        }

        public static Matrix2 operator %(Matrix2 a, int b)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = a[i, j] % b;

            return ret;
        }

        public static Matrix2 operator ^(Matrix2 a, Matrix2 b)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = a[i, j] ^ b[i, j];

            return ret;
        }

        public static Matrix2 operator ^(Matrix2 a, int b)
        {
            Matrix2 ret = new Matrix2(0);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ret[i, j] = a[i, j] ^ b;

            return ret;
        }

        public override string ToString() => $"[{matrix[0, 0]}, {matrix[0, 1]}, {matrix[1, 0]}, {matrix[1, 1]}]";
    }

    struct Matrix3
    {
        private int[,] matrix;

        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public Matrix3(int initValue)
        {
            matrix = new int[3, 3];
            for (int row = 0; row < 3; row++)
                for (int col = 0; col < 3; col++)
                    matrix[row, col] = initValue;
        }

        public Matrix3(int v00, int v01, int v02,
                       int v10, int v11, int v12,
                       int v20, int v21, int v22)
        {
            matrix = new int[3, 3];

            matrix[0, 0] = v00; matrix[0, 1] = v01; matrix[0, 2] = v02;
            matrix[1, 0] = v10; matrix[1, 1] = v11; matrix[1, 2] = v12;;
            matrix[2, 0] = v20; matrix[2, 1] = v21; matrix[2, 2] = v22;
        }

        public static Matrix3 operator +(Matrix3 a) => a;

        public static Matrix3 operator +(Matrix3 a, Matrix3 b)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = a[i, j] + b[i, j];

            return ret;
        }

        public static Matrix3 operator -(Matrix3 a)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = 0 - a[i, j];

            return ret;
        }

        public static Matrix3 operator -(Matrix3 a, Matrix3 b)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = a[i, j] - b[i, j];

            return ret;
        }

        public static Matrix3 operator *(Matrix3 a, Matrix3 b)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = a[i, j] * b[i, j];

            return ret;
        }

        public static Matrix3 operator *(Matrix3 a, int b)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = a[i, j] * b;

            return ret;
        }

        public static Matrix3 operator /(Matrix3 a, Matrix3 b)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = a[i, j] / b[i, j];

            return ret;
        }

        public static Matrix3 operator /(Matrix3 a, int b)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = a[i, j] / b;

            return ret;
        }

        public static Matrix3 operator %(Matrix3 a, Matrix3 b)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = a[i, j] % b[i, j];

            return ret;
        }

        public static Matrix3 operator %(Matrix3 a, int b)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = a[i, j] % b;

            return ret;
        }

        public static Matrix3 operator ^(Matrix3 a, Matrix3 b)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = a[i, j] ^ b[i, j];

            return ret;
        }

        public static Matrix3 operator ^(Matrix3 a, int b)
        {
            Matrix3 ret = new Matrix3(0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = a[i, j] ^ b;

            return ret;
        }

        public override string ToString() => $"[{matrix[0, 0]}, {matrix[0, 1]}, {matrix[0, 2]}," +
                                             $" {matrix[1, 0]}, {matrix[1, 1]}, {matrix[1, 2]}," +
                                             $" {matrix[2, 0]}, {matrix[2, 1]}, {matrix[2, 2]}]";
    }

    struct Matrix4
    {
        private int[,] matrix;

        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public Matrix4(int initValue)
        {
            matrix = new int[4, 4];
            for (int row = 0; row < 4; row++)
                for (int col = 0; col < 4; col++)
                    matrix[row, col] = initValue;
        }

        public Matrix4(int v00, int v01, int v02, int v03,
                       int v10, int v11, int v12, int v13,
                       int v20, int v21, int v22, int v23,
                       int v30, int v31, int v32, int v33)
        {
            matrix = new int[4, 4];

            matrix[0, 0] = v00; matrix[0, 1] = v01;
            matrix[0, 2] = v02; matrix[0, 3] = v03;

            matrix[1, 0] = v10; matrix[1, 1] = v11;
            matrix[1, 2] = v12; matrix[1, 3] = v13;

            matrix[2, 0] = v20; matrix[2, 1] = v21;
            matrix[2, 2] = v22; matrix[2, 3] = v23;

            matrix[3, 0] = v30; matrix[3, 1] = v31;
            matrix[3, 2] = v32; matrix[3, 3] = v33;
        }

        public static Matrix4 operator +(Matrix4 a) => a;

        public static Matrix4 operator +(Matrix4 a, Matrix4 b)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = a[i, j] + b[i, j];

            return ret;
        }

        public static Matrix4 operator -(Matrix4 a)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = 0 - a[i, j];

            return ret;
        }

        public static Matrix4 operator -(Matrix4 a, Matrix4 b)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = a[i, j] - b[i, j];

            return ret;
        }

        public static Matrix4 operator *(Matrix4 a, Matrix4 b)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = a[i, j] * b[i, j];

            return ret;
        }

        public static Matrix4 operator *(Matrix4 a, int b)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = a[i, j] * b;

            return ret;
        }

        public static Matrix4 operator /(Matrix4 a, Matrix4 b)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = a[i, j] / b[i, j];

            return ret;
        }

        public static Matrix4 operator /(Matrix4 a, int b)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = a[i, j] / b;

            return ret;
        }

        public static Matrix4 operator %(Matrix4 a, Matrix4 b)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = a[i, j] % b[i, j];

            return ret;
        }

        public static Matrix4 operator %(Matrix4 a, int b)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = a[i, j] % b;

            return ret;
        }

        public static Matrix4 operator ^(Matrix4 a, Matrix4 b)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = a[i, j] ^ b[i, j];

            return ret;
        }

        public static Matrix4 operator ^(Matrix4 a, int b)
        {
            Matrix4 ret = new Matrix4(0);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    ret[i, j] = a[i, j] ^ b;

            return ret;
        }

        public override string ToString() => $"[{matrix[0, 0]}, {matrix[0, 1]}, {matrix[0, 2]}, {matrix[0, 3]}," +
                                             $" {matrix[1, 0]}, {matrix[1, 1]}, {matrix[1, 2]}, {matrix[1, 3]}," +
                                             $" {matrix[2, 0]}, {matrix[2, 1]}, {matrix[2, 2]}, {matrix[2, 3]}," +
                                             $" {matrix[3, 0]}, {matrix[3, 1]}, {matrix[3, 2]}, {matrix[3, 3]}]";
    }
}
