using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

using ImGuiTableColumnIdx = System.Char;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableCellData
    {
        public uint BgColor;
        public ImGuiTableColumnIdx Column;
    }
    
    public unsafe partial struct ImSpan_ImGuiTableCellData
    {
        public ImGuiTableCellData* Data;
        public ImGuiTableCellData* DataEnd;
    }

    public unsafe partial struct ImGuiTableCellDataPtr
    {
        public ImGuiTableCellData* NativePtr { get; }
        public ImGuiTableCellDataPtr(ImGuiTableCellData* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableCellDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableCellData*)nativePtr;
        public static implicit operator ImGuiTableCellDataPtr(ImGuiTableCellData* nativePtr) => new ImGuiTableCellDataPtr(nativePtr);
        public static implicit operator ImGuiTableCellData* (ImGuiTableCellDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableCellDataPtr(IntPtr nativePtr) => new ImGuiTableCellDataPtr(nativePtr);
        public ref uint BgColor => ref Unsafe.AsRef<uint>(&NativePtr->BgColor);
        public ref ImGuiTableColumnIdx Column => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->Column);
    }
}
