namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDockNodeFlagsPrivate
    {
        ImGuiDockNodeFlags_DockSpace = 1024,
        ImGuiDockNodeFlags_CentralNode = 2048,
        ImGuiDockNodeFlags_NoTabBar = 4096,
        ImGuiDockNodeFlags_HiddenTabBar = 8192,
        ImGuiDockNodeFlags_NoWindowMenuButton = 16384,
        ImGuiDockNodeFlags_NoCloseButton = 32768,
        ImGuiDockNodeFlags_NoDocking = 65536,
        ImGuiDockNodeFlags_NoDockingSplitMe = 131072,
        ImGuiDockNodeFlags_NoDockingSplitOther = 262144,
        ImGuiDockNodeFlags_NoDockingOverMe = 524288,
        ImGuiDockNodeFlags_NoDockingOverOther = 1048576,
        ImGuiDockNodeFlags_NoResizeX = 2097152,
        ImGuiDockNodeFlags_NoResizeY = 4194304,
        ImGuiDockNodeFlags_SharedFlagsInheritMask = -1,
        ImGuiDockNodeFlags_NoResizeFlagsMask = 6291488,
        ImGuiDockNodeFlags_LocalFlagsMask = 6421616,
        ImGuiDockNodeFlags_LocalFlagsTransferMask = 6420592,
        ImGuiDockNodeFlags_SavedFlagsMask = 6421536,
    }
}
