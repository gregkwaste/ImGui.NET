using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{

    //I have no fucking idea about this one. Can't find the definition anywhere
    public unsafe partial struct ImGuiDockNodeSettings
    {
        public ImGuiDockNodeFlags val;
    }

    public unsafe partial struct ImGuiDockNodeSettingsPtr
    {
        public int Size;
        public int Capacity;
        public ImGuiDockNodeSettings* Data;
    }

    //I have no fucking idea about this one. Can't find the definition anywhere
    public unsafe partial struct ImGuiDockRequest
    {
        public int val;
    }



    public unsafe partial struct ImGuiDockRequestPtr
    {
        public int Size;
        public int Capacity;
        public ImGuiDockRequest* Data;
    }

    
    public unsafe partial struct ImGuiDockContext
    {
        public ImGuiStorage Nodes;
        public ImVector Requests;
        public ImVector NodesSettings;
        public byte WantFullRebuild;
    }
    public unsafe partial struct ImGuiDockContextPtr
    {
        public ImGuiDockContext* NativePtr { get; }
        public ImGuiDockContextPtr(ImGuiDockContext* nativePtr) => NativePtr = nativePtr;
        public ImGuiDockContextPtr(IntPtr nativePtr) => NativePtr = (ImGuiDockContext*)nativePtr;
        public static implicit operator ImGuiDockContextPtr(ImGuiDockContext* nativePtr) => new ImGuiDockContextPtr(nativePtr);
        public static implicit operator ImGuiDockContext* (ImGuiDockContextPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiDockContextPtr(IntPtr nativePtr) => new ImGuiDockContextPtr(nativePtr);
        public ref ImGuiStorage Nodes => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->Nodes);
        public ImPtrVector<ImGuiDockRequestPtr> Requests => new ImPtrVector<ImGuiDockRequestPtr>(NativePtr->Requests, Unsafe.SizeOf<ImGuiDockRequest>());
        public ImPtrVector<ImGuiDockNodeSettingsPtr> NodesSettings => new ImPtrVector<ImGuiDockNodeSettingsPtr>(NativePtr->NodesSettings, Unsafe.SizeOf<ImGuiDockNodeSettings>());
        public ref bool WantFullRebuild => ref Unsafe.AsRef<bool>(&NativePtr->WantFullRebuild);
        public void Destroy()
        {
            ImGuiNative.ImGuiDockContext_destroy((ImGuiDockContext*)(NativePtr));
        }
    }
}
