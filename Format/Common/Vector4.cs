﻿using System.Collections;

namespace MMD
{
    namespace Format
    {
        namespace Common
        {
            public class Vector4 : Chunk
            {
                public float x, y, z, w;

                public override void Read(System.IO.BinaryReader r)
                {
                    x = ReadFloat(r);
                    y = ReadFloat(r);
                    z = ReadFloat(r);
                    w = ReadFloat(r);
                }
            }
        }
    }
}