using System;

namespace ImGuiNET
{
    public unsafe delegate void ImGuiErrorLogCallback(void* user_data, string fmt, params string[] args);
}