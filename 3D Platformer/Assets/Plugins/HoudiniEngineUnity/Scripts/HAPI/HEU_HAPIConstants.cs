/*
* Copyright (c) <2021> Side Effects Software Inc.
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*
* Produced by:
*      Side Effects Software Inc
*      123 Front Street West, Suite 1401
*      Toronto, Ontario
*      Canada   M5J 2M2
*      416-504-9876
*/


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// WARNING! This file is automatically GENERATED.
// DO NOT modify manually or commit to the repository!
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using UnityEngine;

namespace HoudiniEngineUnity
{
    using HAPI_Bool = System.Boolean;
    using HAPI_UInt8 = System.Byte;
    using HAPI_Int8 = System.SByte;
    using HAPI_Int16 = System.Int16;
    using HAPI_Int64 = System.Int64;
    using HAPI_ProcessId = System.Int32;
    using HAPI_SessionId = System.Int64;
    using HAPI_StringHandle = System.Int32;
    using HAPI_AssetLibraryId = System.Int32;
    using HAPI_NodeId = System.Int32;
    using HAPI_ParmId = System.Int32;
    using HAPI_PartId = System.Int32;
    using HAPI_PDG_WorkItemId = System.Int32;
    using HAPI_PDG_WorkitemId = System.Int32;
    using HAPI_PDG_GraphContextId = System.Int32;
    using HAPI_HIPFileId = System.Int32;
    using HAPI_ErrorCodeBits = System.Int32;
    using HAPI_NodeTypeBits = System.Int32;
    using HAPI_NodeFlagsBits = System.Int32;

    public static class HEU_HAPIConstants
    {
        public const int HAPI_POSITION_VECTOR_SIZE = 3;
        public const int HAPI_SCALE_VECTOR_SIZE = 3;
        public const int HAPI_SHEAR_VECTOR_SIZE = 3;
        public const int HAPI_NORMAL_VECTOR_SIZE = 3;
        public const int HAPI_QUATERNION_VECTOR_SIZE = 4;
        public const int HAPI_EULER_VECTOR_SIZE = 3;
        public const int HAPI_UV_VECTOR_SIZE = 2;
        public const int HAPI_COLOR_VECTOR_SIZE = 4;
        public const int HAPI_CV_VECTOR_SIZE = 4;
        public const int HAPI_PRIM_MIN_VERTEX_COUNT = 1;
        public const int HAPI_PRIM_MAX_VERTEX_COUNT = 16;
        public const int HAPI_INVALID_PARM_ID = -1;
        public const string HAPI_ATTRIB_POSITION = "P";
        public const string HAPI_ATTRIB_UV = "uv";
        public const string HAPI_ATTRIB_UV2 = "uv2";
        public const string HAPI_ATTRIB_NORMAL = "N";
        public const string HAPI_ATTRIB_TANGENT = "tangentu";
        public const string HAPI_ATTRIB_TANGENT2 = "tangentv";
        public const string HAPI_ATTRIB_COLOR = "Cd";
        public const string HAPI_ATTRIB_NAME = "name";
        public const string HAPI_ATTRIB_INSTANCE = "instance";
        public const string HAPI_ATTRIB_ROT = "rot";
        public const string HAPI_ATTRIB_SCALE = "scale";
        public const string HAPI_UNGROUPED_GROUP_NAME = "__ungrouped_group";
        public const string HAPI_RAW_FORMAT_NAME = "HAPI_RAW";
        public const string HAPI_PNG_FORMAT_NAME = "PNG";
        public const string HAPI_JPEG_FORMAT_NAME = "JPEG";
        public const string HAPI_BMP_FORMAT_NAME = "Bitmap";
        public const string HAPI_TIFF_FORMAT_NAME = "TIFF";
        public const string HAPI_TGA_FORMAT_NAME = "Targa";
        public const string HAPI_DEFAULT_IMAGE_FORMAT_NAME = HAPI_PNG_FORMAT_NAME;
        public const string HAPI_GLOBAL_NODES_NODE_NAME = "GlobalNodes";
        public const string HAPI_ENV_HIP = "HIP";
        public const string HAPI_ENV_JOB = "JOB";
        public const string HAPI_ENV_CLIENT_NAME = "HAPI_CLIENT_NAME";
        public const string HAPI_CACHE_COP2_COOK = "COP Cook Cache";
        public const string HAPI_CACHE_COP2_FLIPBOOK = "COP Flipbook Cache";
        public const string HAPI_CACHE_IMAGE = "Image Cache";
        public const string HAPI_CACHE_OBJ = "Object Transform Cache";
        public const string HAPI_CACHE_GL_TEXTURE = "OpenGL Texture Cache";
        public const string HAPI_CACHE_GL_VERTEX = "OpenGL Vertex Cache";
        public const string HAPI_CACHE_SOP = "SOP Cache";
        public const string HAPI_CACHE_VEX = "VEX File Cache";
        public const string HAPI_ATTRIB_INPUT_CURVE_COORDS = "hapi_input_curve_coords";

    }

}
