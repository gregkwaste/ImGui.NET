using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiNextWindowData
    {
        public ImGuiNextWindowDataFlags Flags;
        public ImGuiCond PosCond;
        public ImGuiCond SizeCond;
        public ImGuiCond CollapsedCond;
        public ImGuiCond DockCond;
        public ImVec2 PosVal;
        public ImVec2 PosPivotVal;
        public ImVec2 SizeVal;
        public ImVec2 ContentSizeVal;
        public ImVec2 ScrollVal;
        public byte PosUndock;
        public byte CollapsedVal;
        public ImRect SizeConstraintRect;
        public void* SizeCallback; //function pointer
        public void* SizeCallbackUserData;
        public float BgAlphaVal;
        public uint ViewportId;
        public uint DockId;
        public ImGuiWindowClass WindowClass;
        public ImVec2 MenuBarOffsetMinVal;
    }
    public unsafe partial struct ImGuiNextWindowDataPtr
    {
        public ImGuiNextWindowData* NativePtr { get; }
        public ImGuiNextWindowDataPtr(ImGuiNextWindowData* nativePtr) => NativePtr = nativePtr;
        public ImGuiNextWindowDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNextWindowData*)nativePtr;
        public static implicit operator ImGuiNextWindowDataPtr(ImGuiNextWindowData* nativePtr) => new ImGuiNextWindowDataPtr(nativePtr);
        public static implicit operator ImGuiNextWindowData* (ImGuiNextWindowDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiNextWindowDataPtr(IntPtr nativePtr) => new ImGuiNextWindowDataPtr(nativePtr);
        public ref ImGuiNextWindowDataFlags Flags => ref Unsafe.AsRef<ImGuiNextWindowDataFlags>(&NativePtr->Flags);
        public ref ImGuiCond PosCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->PosCond);
        public ref ImGuiCond SizeCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SizeCond);
        public ref ImGuiCond CollapsedCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->CollapsedCond);
        public ref ImGuiCond DockCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->DockCond);
        public ref Vector2 PosVal => ref Unsafe.AsRef<Vector2>(&NativePtr->PosVal);
        public ref Vector2 PosPivotVal => ref Unsafe.AsRef<Vector2>(&NativePtr->PosPivotVal);
        public ref Vector2 SizeVal => ref Unsafe.AsRef<Vector2>(&NativePtr->SizeVal);
        public ref Vector2 ContentSizeVal => ref Unsafe.AsRef<Vector2>(&NativePtr->ContentSizeVal);
        public ref Vector2 ScrollVal => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollVal);
        public ref bool PosUndock => ref Unsafe.AsRef<bool>(&NativePtr->PosUndock);
        public ref bool CollapsedVal => ref Unsafe.AsRef<bool>(&NativePtr->CollapsedVal);
        public ref ImRect SizeConstraintRect => ref Unsafe.AsRef<ImRect>(&NativePtr->SizeConstraintRect);
        public ref ImGuiSizeCallback SizeCallback => ref Unsafe.AsRef<ImGuiSizeCallback>(&NativePtr->SizeCallback);
        public IntPtr SizeCallbackUserData { get => (IntPtr)NativePtr->SizeCallbackUserData; set => NativePtr->SizeCallbackUserData = (void*)value; }
        public ref float BgAlphaVal => ref Unsafe.AsRef<float>(&NativePtr->BgAlphaVal);
        public ref uint ViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ViewportId);
        public ref uint DockId => ref Unsafe.AsRef<uint>(&NativePtr->DockId);
        public ref ImGuiWindowClass WindowClass => ref Unsafe.AsRef<ImGuiWindowClass>(&NativePtr->WindowClass);
        public ref Vector2 MenuBarOffsetMinVal => ref Unsafe.AsRef<Vector2>(&NativePtr->MenuBarOffsetMinVal);
        public void ClearFlags()
        {
            ImGuiNative.ImGuiNextWindowData_ClearFlags((ImGuiNextWindowData*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiNextWindowData_destroy((ImGuiNextWindowData*)(NativePtr));
        }
    }
}
