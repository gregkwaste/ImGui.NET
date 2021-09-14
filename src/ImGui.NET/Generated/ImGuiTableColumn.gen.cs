using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

using ImGuiTableColumnIdx = System.Char;
using ImGuiTableDrawChannelIdx = System.Byte;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableColumn
    {
        public ImGuiTableColumnFlags Flags;
        public float WidthGiven;
        public float MinX;
        public float MaxX;
        public float WidthRequest;
        public float WidthAuto;
        public float StretchWeight;
        public float InitStretchWeightOrWidth;
        public ImRect ClipRect;
        public uint UserID;
        public float WorkMinX;
        public float WorkMaxX;
        public float ItemWidth;
        public float ContentMaxXFrozen;
        public float ContentMaxXUnfrozen;
        public float ContentMaxXHeadersUsed;
        public float ContentMaxXHeadersIdeal;
        public short NameOffset;
        public ImGuiTableColumnIdx DisplayOrder;
        public ImGuiTableColumnIdx IndexWithinEnabledSet;
        public ImGuiTableColumnIdx PrevEnabledColumn;
        public ImGuiTableColumnIdx NextEnabledColumn;
        public ImGuiTableColumnIdx SortOrder;
        public ImGuiTableDrawChannelIdx DrawChannelCurrent;
        public ImGuiTableDrawChannelIdx DrawChannelFrozen;
        public ImGuiTableDrawChannelIdx DrawChannelUnfrozen;
        public byte IsEnabled;
        public byte IsEnabledNextFrame;
        public byte IsVisibleX;
        public byte IsVisibleY;
        public byte IsRequestOutput;
        public byte IsSkipItems;
        public byte IsPreserveWidthAuto;
        public sbyte NavLayerCurrent;
        public byte AutoFitQueue;
        public byte CannotSkipItemsQueue;
        public byte SortDirection;
        public byte SortDirectionsAvailCount;
        public byte SortDirectionsAvailMask;
        public byte SortDirectionsAvailList;
    }
    public unsafe partial struct ImGuiTableColumnPtr
    {
        public ImGuiTableColumn* NativePtr { get; }
        public ImGuiTableColumnPtr(ImGuiTableColumn* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableColumnPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumn*)nativePtr;
        public static implicit operator ImGuiTableColumnPtr(ImGuiTableColumn* nativePtr) => new ImGuiTableColumnPtr(nativePtr);
        public static implicit operator ImGuiTableColumn* (ImGuiTableColumnPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableColumnPtr(IntPtr nativePtr) => new ImGuiTableColumnPtr(nativePtr);
        public ref ImGuiTableColumnFlags Flags => ref Unsafe.AsRef<ImGuiTableColumnFlags>(&NativePtr->Flags);
        public ref float WidthGiven => ref Unsafe.AsRef<float>(&NativePtr->WidthGiven);
        public ref float MinX => ref Unsafe.AsRef<float>(&NativePtr->MinX);
        public ref float MaxX => ref Unsafe.AsRef<float>(&NativePtr->MaxX);
        public ref float WidthRequest => ref Unsafe.AsRef<float>(&NativePtr->WidthRequest);
        public ref float WidthAuto => ref Unsafe.AsRef<float>(&NativePtr->WidthAuto);
        public ref float StretchWeight => ref Unsafe.AsRef<float>(&NativePtr->StretchWeight);
        public ref float InitStretchWeightOrWidth => ref Unsafe.AsRef<float>(&NativePtr->InitStretchWeightOrWidth);
        public ref ImRect ClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ClipRect);
        public ref uint UserID => ref Unsafe.AsRef<uint>(&NativePtr->UserID);
        public ref float WorkMinX => ref Unsafe.AsRef<float>(&NativePtr->WorkMinX);
        public ref float WorkMaxX => ref Unsafe.AsRef<float>(&NativePtr->WorkMaxX);
        public ref float ItemWidth => ref Unsafe.AsRef<float>(&NativePtr->ItemWidth);
        public ref float ContentMaxXFrozen => ref Unsafe.AsRef<float>(&NativePtr->ContentMaxXFrozen);
        public ref float ContentMaxXUnfrozen => ref Unsafe.AsRef<float>(&NativePtr->ContentMaxXUnfrozen);
        public ref float ContentMaxXHeadersUsed => ref Unsafe.AsRef<float>(&NativePtr->ContentMaxXHeadersUsed);
        public ref float ContentMaxXHeadersIdeal => ref Unsafe.AsRef<float>(&NativePtr->ContentMaxXHeadersIdeal);
        public ref short NameOffset => ref Unsafe.AsRef<short>(&NativePtr->NameOffset);
        public ref ImGuiTableColumnIdx DisplayOrder => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->DisplayOrder);
        public ref ImGuiTableColumnIdx IndexWithinEnabledSet => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->IndexWithinEnabledSet);
        public ref ImGuiTableColumnIdx PrevEnabledColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->PrevEnabledColumn);
        public ref ImGuiTableColumnIdx NextEnabledColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->NextEnabledColumn);
        public ref ImGuiTableColumnIdx SortOrder => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->SortOrder);
        public ref ImGuiTableDrawChannelIdx DrawChannelCurrent => ref Unsafe.AsRef<ImGuiTableDrawChannelIdx>(&NativePtr->DrawChannelCurrent);
        public ref ImGuiTableDrawChannelIdx DrawChannelFrozen => ref Unsafe.AsRef<ImGuiTableDrawChannelIdx>(&NativePtr->DrawChannelFrozen);
        public ref ImGuiTableDrawChannelIdx DrawChannelUnfrozen => ref Unsafe.AsRef<ImGuiTableDrawChannelIdx>(&NativePtr->DrawChannelUnfrozen);
        public ref bool IsEnabled => ref Unsafe.AsRef<bool>(&NativePtr->IsEnabled);
        public ref bool IsEnabledNextFrame => ref Unsafe.AsRef<bool>(&NativePtr->IsEnabledNextFrame);
        public ref bool IsVisibleX => ref Unsafe.AsRef<bool>(&NativePtr->IsVisibleX);
        public ref bool IsVisibleY => ref Unsafe.AsRef<bool>(&NativePtr->IsVisibleY);
        public ref bool IsRequestOutput => ref Unsafe.AsRef<bool>(&NativePtr->IsRequestOutput);
        public ref bool IsSkipItems => ref Unsafe.AsRef<bool>(&NativePtr->IsSkipItems);
        public ref bool IsPreserveWidthAuto => ref Unsafe.AsRef<bool>(&NativePtr->IsPreserveWidthAuto);
        public ref sbyte NavLayerCurrent => ref Unsafe.AsRef<sbyte>(&NativePtr->NavLayerCurrent);
        public ref byte AutoFitQueue => ref Unsafe.AsRef<byte>(&NativePtr->AutoFitQueue);
        public ref byte CannotSkipItemsQueue => ref Unsafe.AsRef<byte>(&NativePtr->CannotSkipItemsQueue);
        public ref byte SortDirection => ref Unsafe.AsRef<byte>(&NativePtr->SortDirection);
        public ref byte SortDirectionsAvailCount => ref Unsafe.AsRef<byte>(&NativePtr->SortDirectionsAvailCount);
        public ref byte SortDirectionsAvailMask => ref Unsafe.AsRef<byte>(&NativePtr->SortDirectionsAvailMask);
        public ref byte SortDirectionsAvailList => ref Unsafe.AsRef<byte>(&NativePtr->SortDirectionsAvailList);
        public void Destroy()
        {
            ImGuiNative.ImGuiTableColumn_destroy((ImGuiTableColumn*)(NativePtr));
        }
    }
}
