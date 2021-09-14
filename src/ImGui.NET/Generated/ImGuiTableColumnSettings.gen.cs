using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

using ImGuiTableColumnIdx = System.Int32;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableColumnSettings
    {
        public float WidthOrWeight;
        public uint UserID;
        public ImGuiTableColumnIdx Index;
        public ImGuiTableColumnIdx DisplayOrder;
        public ImGuiTableColumnIdx SortOrder;
        public byte SortDirection;
        public byte IsEnabled;
        public byte IsStretch;
    }
    public unsafe partial struct ImGuiTableColumnSettingsPtr
    {
        public ImGuiTableColumnSettings* NativePtr { get; }
        public ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableColumnSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSettings*)nativePtr;
        public static implicit operator ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* nativePtr) => new ImGuiTableColumnSettingsPtr(nativePtr);
        public static implicit operator ImGuiTableColumnSettings* (ImGuiTableColumnSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableColumnSettingsPtr(IntPtr nativePtr) => new ImGuiTableColumnSettingsPtr(nativePtr);
        public ref float WidthOrWeight => ref Unsafe.AsRef<float>(&NativePtr->WidthOrWeight);
        public ref uint UserID => ref Unsafe.AsRef<uint>(&NativePtr->UserID);
        public ref ImGuiTableColumnIdx Index => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->Index);
        public ref ImGuiTableColumnIdx DisplayOrder => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->DisplayOrder);
        public ref ImGuiTableColumnIdx SortOrder => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->SortOrder);
        public ref byte SortDirection => ref Unsafe.AsRef<byte>(&NativePtr->SortDirection);
        public ref byte IsEnabled => ref Unsafe.AsRef<byte>(&NativePtr->IsEnabled);
        public ref byte IsStretch => ref Unsafe.AsRef<byte>(&NativePtr->IsStretch);
        public void Destroy()
        {
            ImGuiNative.ImGuiTableColumnSettings_destroy((ImGuiTableColumnSettings*)(NativePtr));
        }
    }
}
