using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.VFX;
using Object = UnityEngine.Object;

namespace UnityEditor.VFX
{
    class VFXTexture2DValue : VFXObjectValue
    {
        public VFXTexture2DValue(int instanceID = 0, Mode mode = Mode.FoldableVariable) : base(instanceID, mode, VFXValueType.Texture2D)
        {
        }

        sealed public override VFXValue CopyExpression(Mode mode)
        {
            var copy = new VFXTexture2DValue(Get(), mode);
            return copy;
        }
    }

    class VFXTexture3DValue : VFXObjectValue
    {
        public VFXTexture3DValue(int instanceID = 0, Mode mode = Mode.FoldableVariable) : base(instanceID, mode, VFXValueType.Texture3D)
        {
        }

        sealed public override VFXValue CopyExpression(Mode mode)
        {
            var copy = new VFXTexture3DValue(Get(), mode);
            return copy;
        }
    }

    class VFXTextureCubeValue : VFXObjectValue
    {
        public VFXTextureCubeValue(int instanceID = 0, Mode mode = Mode.FoldableVariable) : base(instanceID, mode, VFXValueType.TextureCube)
        {
        }

        sealed public override VFXValue CopyExpression(Mode mode)
        {
            var copy = new VFXTextureCubeValue(Get(), mode);
            return copy;
        }
    }

    class VFXTexture2DArrayValue : VFXObjectValue
    {
        public VFXTexture2DArrayValue(int instanceID = 0, Mode mode = Mode.FoldableVariable) : base(instanceID, mode, VFXValueType.Texture2DArray)
        {
        }

        sealed public override VFXValue CopyExpression(Mode mode)
        {
            var copy = new VFXTexture2DArrayValue(Get(), mode);
            return copy;
        }
    }

    class VFXTextureCubeArrayValue : VFXObjectValue
    {
        public VFXTextureCubeArrayValue(int instanceID = 0, Mode mode = Mode.FoldableVariable) : base(instanceID, mode, VFXValueType.TextureCubeArray)
        {
        }

        sealed public override VFXValue CopyExpression(Mode mode)
        {
            var copy = new VFXTextureCubeArrayValue(Get(), mode);
            return copy;
        }
    }

    class VFXMeshValue : VFXObjectValue
    {
        public VFXMeshValue(int instanceID = 0, Mode mode = Mode.FoldableVariable) : base(instanceID, mode, VFXValueType.Mesh)
        {
        }

        sealed public override VFXValue CopyExpression(Mode mode)
        {
            var copy = new VFXMeshValue(Get(), mode);
            return copy;
        }
    }

    class VFXSkinnedMeshRendererValue : VFXObjectValue
    {
        public VFXSkinnedMeshRendererValue(int instanceID = 0, Mode mode = Mode.FoldableVariable) : base(instanceID, mode, VFXValueType.SkinnedMeshRenderer)
        {
        }

        sealed public override VFXValue CopyExpression(Mode mode)
        {
            var copy = new VFXSkinnedMeshRendererValue(Get(), mode);
            return copy;
        }
    }
}
