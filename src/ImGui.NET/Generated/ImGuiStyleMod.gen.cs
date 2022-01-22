using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct ImGuiStyleMod
    {
        [FieldOffset(0)]
        public ImGuiStyleVar VarIdx;
        [FieldOffset(4)]
        public fixed int BackupInt[2];
        [FieldOffset(4)]
        public fixed float BackupFloat[2];
    }

    public unsafe partial struct ImGuiStyleModPtr
    {
        public ImGuiStyleMod* NativePtr { get; }
        public ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => NativePtr = nativePtr;
        public ImGuiStyleModPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleMod*)nativePtr;
        public static implicit operator ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => new ImGuiStyleModPtr(nativePtr);
        public static implicit operator ImGuiStyleMod* (ImGuiStyleModPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiStyleModPtr(IntPtr nativePtr) => new ImGuiStyleModPtr(nativePtr);
        public ref ImGuiStyleVar VarIdx => ref Unsafe.AsRef<ImGuiStyleVar>(&NativePtr->VarIdx);
        //gregkwaste: Still have no idea how to handle this
        //public ref union { int BackupInt[2]; float BackupFloat[2];}  => ref Unsafe.AsRef<union { int BackupInt[2]; float BackupFloat[2];}>(&NativePtr->);
        public void Destroy()
        {
            ImGuiNative.ImGuiStyleMod_destroy((ImGuiStyleMod*)(NativePtr));
        }
    }
}
