using System;

namespace ImGuiNET
{
    public enum ImGuiDir
    {
        None = -1,
        Left = 0,
        Right = 1,
        Up = 2,
        Down = 3,
        COUNT = 4,
    }
    
    public unsafe partial struct ImGuiDirPtr
    {
        public ImGuiDir* NativePtr { get; }
        public ImGuiDirPtr(ImGuiDir* nativePtr) => NativePtr = nativePtr;
        public ImGuiDirPtr(IntPtr nativePtr) => NativePtr = (ImGuiDir*)nativePtr;
        public static implicit operator ImGuiDirPtr(ImGuiDir* nativePtr) => new ImGuiDirPtr(nativePtr);
        public static implicit operator ImGuiDir* (ImGuiDirPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiDirPtr(IntPtr nativePtr) => new ImGuiDirPtr(nativePtr);
    
    }
}
