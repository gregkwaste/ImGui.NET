using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiDockContext
    {
        public ImGuiStorage Nodes;
        public ImVector Requests;
        public ImVector NodesSettings;
        public byte WantFullRebuild;
    }

    //I have no fucking idea about this one. Can't find the definition anywhere
    public unsafe partial struct ImGuiDockNodeSettings
    {
        public ImGuiDockNodeFlags val;
    }
    
    public unsafe partial struct ImVector_ImGuiDockNodeSettings
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



    public unsafe partial struct ImVector_ImGuiDockRequest
    {
        public int Size;
        public int Capacity;
        public ImGuiDockRequest* Data;
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
        public ImPtrVector<ImVector_ImGuiDockRequest> Requests => new ImPtrVector<ImVector_ImGuiDockRequest>(NativePtr->Requests, Unsafe.SizeOf<ImGuiDockRequest>());
        public ImPtrVector<ImVector_ImGuiDockNodeSettings> NodesSettings => new ImPtrVector<ImVector_ImGuiDockNodeSettings>(NativePtr->NodesSettings, Unsafe.SizeOf<ImGuiDockNodeSettings>());
        public ref bool WantFullRebuild => ref Unsafe.AsRef<bool>(&NativePtr->WantFullRebuild);
        public void Destroy()
        {
            ImGuiNative.ImGuiDockContext_destroy((ImGuiDockContext*)(NativePtr));
        }
    }
}
