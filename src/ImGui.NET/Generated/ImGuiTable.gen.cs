using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

using ImGuiTableColumnIdx = System.Char;
using ImGuiTableDrawChannelIdx = System.Byte;
using ImPoolIdx = System.Int32;

namespace ImGuiNET
{
    
    
    public unsafe partial struct ImSpan_ImGuiTableColumn
    {
        public ImGuiTableColumn* Data;
        public ImGuiTableColumn* DataEnd;

    }

    public unsafe partial struct ImSpan_ImGuiTableColumnIdx
    {
        public ImGuiTableColumnIdx* Data;
        public ImGuiTableColumnIdx* DataEnd;

    }

    
    public unsafe partial struct ImVector_ImGuiTable
    {
        public int Size;
        public int Capacity;
        public ImGuiTable* Data;
    }


    public unsafe partial struct ImPool_ImGuiTable
    {
        public ImVector_ImGuiTable Buf;
        public ImGuiStorage Map;
        public ImPoolIdx FreeIdx;
    }

    public unsafe partial struct ImGuiTable
    {
        public uint ID;
        public ImGuiTableFlags Flags;
        public void* RawData;
        public ImGuiTableTempData* TempData;
        public ImSpan_ImGuiTableColumn Columns;
        public ImSpan_ImGuiTableColumnIdx DisplayOrderToIndex;
        public ImSpan_ImGuiTableCellData RowCellData;
        public ulong EnabledMaskByDisplayOrder;
        public ulong EnabledMaskByIndex;
        public ulong VisibleMaskByIndex;
        public ulong RequestOutputMaskByIndex;
        public ImGuiTableFlags SettingsLoadedFlags;
        public int SettingsOffset;
        public int LastFrameActive;
        public int ColumnsCount;
        public int CurrentRow;
        public int CurrentColumn;
        public short InstanceCurrent;
        public short InstanceInteracted;
        public float RowPosY1;
        public float RowPosY2;
        public float RowMinHeight;
        public float RowTextBaseline;
        public float RowIndentOffsetX;
        public ImGuiTableRowFlags RowFlags;
        public ImGuiTableRowFlags LastRowFlags;
        public int RowBgColorCounter;
        public fixed uint RowBgColor[2];
        public uint BorderColorStrong;
        public uint BorderColorLight;
        public float BorderX1;
        public float BorderX2;
        public float HostIndentX;
        public float MinColumnWidth;
        public float OuterPaddingX;
        public float CellPaddingX;
        public float CellPaddingY;
        public float CellSpacingX1;
        public float CellSpacingX2;
        public float LastOuterHeight;
        public float LastFirstRowHeight;
        public float InnerWidth;
        public float ColumnsGivenWidth;
        public float ColumnsAutoFitWidth;
        public float ResizedColumnNextWidth;
        public float ResizeLockMinContentsX2;
        public float RefScale;
        public ImRect OuterRect;
        public ImRect InnerRect;
        public ImRect WorkRect;
        public ImRect InnerClipRect;
        public ImRect BgClipRect;
        public ImRect Bg0ClipRectForDrawCmd;
        public ImRect Bg2ClipRectForDrawCmd;
        public ImRect HostClipRect;
        public ImRect HostBackupInnerClipRect;
        public ImGuiWindow* OuterWindow;
        public ImGuiWindow* InnerWindow;
        public ImGuiTextBuffer ColumnsNames;
        public ImDrawListSplitter* DrawSplitter;
        public ImGuiTableColumnSortSpecs SortSpecsSingle;
        public ImVector SortSpecsMulti;
        public ImGuiTableSortSpecs SortSpecs;
        public ImGuiTableColumnIdx SortSpecsCount;
        public ImGuiTableColumnIdx ColumnsEnabledCount;
        public ImGuiTableColumnIdx ColumnsEnabledFixedCount;
        public ImGuiTableColumnIdx DeclColumnsCount;
        public ImGuiTableColumnIdx HoveredColumnBody;
        public ImGuiTableColumnIdx HoveredColumnBorder;
        public ImGuiTableColumnIdx AutoFitSingleColumn;
        public ImGuiTableColumnIdx ResizedColumn;
        public ImGuiTableColumnIdx LastResizedColumn;
        public ImGuiTableColumnIdx HeldHeaderColumn;
        public ImGuiTableColumnIdx ReorderColumn;
        public ImGuiTableColumnIdx ReorderColumnDir;
        public ImGuiTableColumnIdx LeftMostEnabledColumn;
        public ImGuiTableColumnIdx RightMostEnabledColumn;
        public ImGuiTableColumnIdx LeftMostStretchedColumn;
        public ImGuiTableColumnIdx RightMostStretchedColumn;
        public ImGuiTableColumnIdx ContextPopupColumn;
        public ImGuiTableColumnIdx FreezeRowsRequest;
        public ImGuiTableColumnIdx FreezeRowsCount;
        public ImGuiTableColumnIdx FreezeColumnsRequest;
        public ImGuiTableColumnIdx FreezeColumnsCount;
        public ImGuiTableColumnIdx RowCellDataCurrent;
        public ImGuiTableDrawChannelIdx DummyDrawChannel;
        public ImGuiTableDrawChannelIdx Bg2DrawChannelCurrent;
        public ImGuiTableDrawChannelIdx Bg2DrawChannelUnfrozen;
        public byte IsLayoutLocked;
        public byte IsInsideRow;
        public byte IsInitializing;
        public byte IsSortSpecsDirty;
        public byte IsUsingHeaders;
        public byte IsContextPopupOpen;
        public byte IsSettingsRequestLoad;
        public byte IsSettingsDirty;
        public byte IsDefaultDisplayOrder;
        public byte IsResetAllRequest;
        public byte IsResetDisplayOrderRequest;
        public byte IsUnfrozenRows;
        public byte IsDefaultSizingPolicy;
        public byte MemoryCompacted;
        public byte HostSkipItems;
    }
    public unsafe partial struct ImGuiTablePtr
    {
        public ImGuiTable* NativePtr { get; }
        public ImGuiTablePtr(ImGuiTable* nativePtr) => NativePtr = nativePtr;
        public ImGuiTablePtr(IntPtr nativePtr) => NativePtr = (ImGuiTable*)nativePtr;
        public static implicit operator ImGuiTablePtr(ImGuiTable* nativePtr) => new ImGuiTablePtr(nativePtr);
        public static implicit operator ImGuiTable* (ImGuiTablePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTablePtr(IntPtr nativePtr) => new ImGuiTablePtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImGuiTableFlags Flags => ref Unsafe.AsRef<ImGuiTableFlags>(&NativePtr->Flags);
        public IntPtr RawData { get => (IntPtr)NativePtr->RawData; set => NativePtr->RawData = (void*)value; }
        public ImGuiTableTempDataPtr TempData => new ImGuiTableTempDataPtr(NativePtr->TempData);
        public ref ImSpan_ImGuiTableColumn Columns => ref Unsafe.AsRef<ImSpan_ImGuiTableColumn>(&NativePtr->Columns);
        public ref ImSpan_ImGuiTableColumnIdx DisplayOrderToIndex => ref Unsafe.AsRef<ImSpan_ImGuiTableColumnIdx>(&NativePtr->DisplayOrderToIndex);
        public ref ImSpan_ImGuiTableCellData RowCellData => ref Unsafe.AsRef<ImSpan_ImGuiTableCellData>(&NativePtr->RowCellData);
        public ref ulong EnabledMaskByDisplayOrder => ref Unsafe.AsRef<ulong>(&NativePtr->EnabledMaskByDisplayOrder);
        public ref ulong EnabledMaskByIndex => ref Unsafe.AsRef<ulong>(&NativePtr->EnabledMaskByIndex);
        public ref ulong VisibleMaskByIndex => ref Unsafe.AsRef<ulong>(&NativePtr->VisibleMaskByIndex);
        public ref ulong RequestOutputMaskByIndex => ref Unsafe.AsRef<ulong>(&NativePtr->RequestOutputMaskByIndex);
        public ref ImGuiTableFlags SettingsLoadedFlags => ref Unsafe.AsRef<ImGuiTableFlags>(&NativePtr->SettingsLoadedFlags);
        public ref int SettingsOffset => ref Unsafe.AsRef<int>(&NativePtr->SettingsOffset);
        public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);
        public ref int ColumnsCount => ref Unsafe.AsRef<int>(&NativePtr->ColumnsCount);
        public ref int CurrentRow => ref Unsafe.AsRef<int>(&NativePtr->CurrentRow);
        public ref int CurrentColumn => ref Unsafe.AsRef<int>(&NativePtr->CurrentColumn);
        public ref short InstanceCurrent => ref Unsafe.AsRef<short>(&NativePtr->InstanceCurrent);
        public ref short InstanceInteracted => ref Unsafe.AsRef<short>(&NativePtr->InstanceInteracted);
        public ref float RowPosY1 => ref Unsafe.AsRef<float>(&NativePtr->RowPosY1);
        public ref float RowPosY2 => ref Unsafe.AsRef<float>(&NativePtr->RowPosY2);
        public ref float RowMinHeight => ref Unsafe.AsRef<float>(&NativePtr->RowMinHeight);
        public ref float RowTextBaseline => ref Unsafe.AsRef<float>(&NativePtr->RowTextBaseline);
        public ref float RowIndentOffsetX => ref Unsafe.AsRef<float>(&NativePtr->RowIndentOffsetX);
        public ref ImGuiTableRowFlags RowFlags => ref Unsafe.AsRef<ImGuiTableRowFlags>(&NativePtr->RowFlags);
        public ref ImGuiTableRowFlags LastRowFlags => ref Unsafe.AsRef<ImGuiTableRowFlags>(&NativePtr->LastRowFlags);
        public ref int RowBgColorCounter => ref Unsafe.AsRef<int>(&NativePtr->RowBgColorCounter);
        public RangeAccessor<uint> RowBgColor => new RangeAccessor<uint>(NativePtr->RowBgColor, 2);
        public ref uint BorderColorStrong => ref Unsafe.AsRef<uint>(&NativePtr->BorderColorStrong);
        public ref uint BorderColorLight => ref Unsafe.AsRef<uint>(&NativePtr->BorderColorLight);
        public ref float BorderX1 => ref Unsafe.AsRef<float>(&NativePtr->BorderX1);
        public ref float BorderX2 => ref Unsafe.AsRef<float>(&NativePtr->BorderX2);
        public ref float HostIndentX => ref Unsafe.AsRef<float>(&NativePtr->HostIndentX);
        public ref float MinColumnWidth => ref Unsafe.AsRef<float>(&NativePtr->MinColumnWidth);
        public ref float OuterPaddingX => ref Unsafe.AsRef<float>(&NativePtr->OuterPaddingX);
        public ref float CellPaddingX => ref Unsafe.AsRef<float>(&NativePtr->CellPaddingX);
        public ref float CellPaddingY => ref Unsafe.AsRef<float>(&NativePtr->CellPaddingY);
        public ref float CellSpacingX1 => ref Unsafe.AsRef<float>(&NativePtr->CellSpacingX1);
        public ref float CellSpacingX2 => ref Unsafe.AsRef<float>(&NativePtr->CellSpacingX2);
        public ref float LastOuterHeight => ref Unsafe.AsRef<float>(&NativePtr->LastOuterHeight);
        public ref float LastFirstRowHeight => ref Unsafe.AsRef<float>(&NativePtr->LastFirstRowHeight);
        public ref float InnerWidth => ref Unsafe.AsRef<float>(&NativePtr->InnerWidth);
        public ref float ColumnsGivenWidth => ref Unsafe.AsRef<float>(&NativePtr->ColumnsGivenWidth);
        public ref float ColumnsAutoFitWidth => ref Unsafe.AsRef<float>(&NativePtr->ColumnsAutoFitWidth);
        public ref float ResizedColumnNextWidth => ref Unsafe.AsRef<float>(&NativePtr->ResizedColumnNextWidth);
        public ref float ResizeLockMinContentsX2 => ref Unsafe.AsRef<float>(&NativePtr->ResizeLockMinContentsX2);
        public ref float RefScale => ref Unsafe.AsRef<float>(&NativePtr->RefScale);
        public ref ImRect OuterRect => ref Unsafe.AsRef<ImRect>(&NativePtr->OuterRect);
        public ref ImRect InnerRect => ref Unsafe.AsRef<ImRect>(&NativePtr->InnerRect);
        public ref ImRect WorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->WorkRect);
        public ref ImRect InnerClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->InnerClipRect);
        public ref ImRect BgClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->BgClipRect);
        public ref ImRect Bg0ClipRectForDrawCmd => ref Unsafe.AsRef<ImRect>(&NativePtr->Bg0ClipRectForDrawCmd);
        public ref ImRect Bg2ClipRectForDrawCmd => ref Unsafe.AsRef<ImRect>(&NativePtr->Bg2ClipRectForDrawCmd);
        public ref ImRect HostClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostClipRect);
        public ref ImRect HostBackupInnerClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupInnerClipRect);
        public ImGuiWindowPtr OuterWindow => new ImGuiWindowPtr(NativePtr->OuterWindow);
        public ImGuiWindowPtr InnerWindow => new ImGuiWindowPtr(NativePtr->InnerWindow);
        public ref ImGuiTextBuffer ColumnsNames => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->ColumnsNames);
        public ImDrawListSplitterPtr DrawSplitter => new ImDrawListSplitterPtr(NativePtr->DrawSplitter);
        public ref ImGuiTableColumnSortSpecs SortSpecsSingle => ref Unsafe.AsRef<ImGuiTableColumnSortSpecs>(&NativePtr->SortSpecsSingle);
        public ImPtrVector<ImGuiTableColumnSortSpecsPtr> SortSpecsMulti => new ImPtrVector<ImGuiTableColumnSortSpecsPtr>(NativePtr->SortSpecsMulti, Unsafe.SizeOf<ImGuiTableColumnSortSpecs>());
        public ref ImGuiTableSortSpecs SortSpecs => ref Unsafe.AsRef<ImGuiTableSortSpecs>(&NativePtr->SortSpecs);
        public ref ImGuiTableColumnIdx SortSpecsCount => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->SortSpecsCount);
        public ref ImGuiTableColumnIdx ColumnsEnabledCount => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->ColumnsEnabledCount);
        public ref ImGuiTableColumnIdx ColumnsEnabledFixedCount => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->ColumnsEnabledFixedCount);
        public ref ImGuiTableColumnIdx DeclColumnsCount => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->DeclColumnsCount);
        public ref ImGuiTableColumnIdx HoveredColumnBody => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->HoveredColumnBody);
        public ref ImGuiTableColumnIdx HoveredColumnBorder => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->HoveredColumnBorder);
        public ref ImGuiTableColumnIdx AutoFitSingleColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->AutoFitSingleColumn);
        public ref ImGuiTableColumnIdx ResizedColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->ResizedColumn);
        public ref ImGuiTableColumnIdx LastResizedColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->LastResizedColumn);
        public ref ImGuiTableColumnIdx HeldHeaderColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->HeldHeaderColumn);
        public ref ImGuiTableColumnIdx ReorderColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->ReorderColumn);
        public ref ImGuiTableColumnIdx ReorderColumnDir => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->ReorderColumnDir);
        public ref ImGuiTableColumnIdx LeftMostEnabledColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->LeftMostEnabledColumn);
        public ref ImGuiTableColumnIdx RightMostEnabledColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->RightMostEnabledColumn);
        public ref ImGuiTableColumnIdx LeftMostStretchedColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->LeftMostStretchedColumn);
        public ref ImGuiTableColumnIdx RightMostStretchedColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->RightMostStretchedColumn);
        public ref ImGuiTableColumnIdx ContextPopupColumn => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->ContextPopupColumn);
        public ref ImGuiTableColumnIdx FreezeRowsRequest => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->FreezeRowsRequest);
        public ref ImGuiTableColumnIdx FreezeRowsCount => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->FreezeRowsCount);
        public ref ImGuiTableColumnIdx FreezeColumnsRequest => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->FreezeColumnsRequest);
        public ref ImGuiTableColumnIdx FreezeColumnsCount => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->FreezeColumnsCount);
        public ref ImGuiTableColumnIdx RowCellDataCurrent => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->RowCellDataCurrent);
        public ref ImGuiTableDrawChannelIdx DummyDrawChannel => ref Unsafe.AsRef<ImGuiTableDrawChannelIdx>(&NativePtr->DummyDrawChannel);
        public ref ImGuiTableDrawChannelIdx Bg2DrawChannelCurrent => ref Unsafe.AsRef<ImGuiTableDrawChannelIdx>(&NativePtr->Bg2DrawChannelCurrent);
        public ref ImGuiTableDrawChannelIdx Bg2DrawChannelUnfrozen => ref Unsafe.AsRef<ImGuiTableDrawChannelIdx>(&NativePtr->Bg2DrawChannelUnfrozen);
        public ref bool IsLayoutLocked => ref Unsafe.AsRef<bool>(&NativePtr->IsLayoutLocked);
        public ref bool IsInsideRow => ref Unsafe.AsRef<bool>(&NativePtr->IsInsideRow);
        public ref bool IsInitializing => ref Unsafe.AsRef<bool>(&NativePtr->IsInitializing);
        public ref bool IsSortSpecsDirty => ref Unsafe.AsRef<bool>(&NativePtr->IsSortSpecsDirty);
        public ref bool IsUsingHeaders => ref Unsafe.AsRef<bool>(&NativePtr->IsUsingHeaders);
        public ref bool IsContextPopupOpen => ref Unsafe.AsRef<bool>(&NativePtr->IsContextPopupOpen);
        public ref bool IsSettingsRequestLoad => ref Unsafe.AsRef<bool>(&NativePtr->IsSettingsRequestLoad);
        public ref bool IsSettingsDirty => ref Unsafe.AsRef<bool>(&NativePtr->IsSettingsDirty);
        public ref bool IsDefaultDisplayOrder => ref Unsafe.AsRef<bool>(&NativePtr->IsDefaultDisplayOrder);
        public ref bool IsResetAllRequest => ref Unsafe.AsRef<bool>(&NativePtr->IsResetAllRequest);
        public ref bool IsResetDisplayOrderRequest => ref Unsafe.AsRef<bool>(&NativePtr->IsResetDisplayOrderRequest);
        public ref bool IsUnfrozenRows => ref Unsafe.AsRef<bool>(&NativePtr->IsUnfrozenRows);
        public ref bool IsDefaultSizingPolicy => ref Unsafe.AsRef<bool>(&NativePtr->IsDefaultSizingPolicy);
        public ref bool MemoryCompacted => ref Unsafe.AsRef<bool>(&NativePtr->MemoryCompacted);
        public ref bool HostSkipItems => ref Unsafe.AsRef<bool>(&NativePtr->HostSkipItems);
        public void Destroy()
        {
            ImGuiNative.ImGuiTable_destroy((ImGuiTable*)(NativePtr));
        }
    }
}
