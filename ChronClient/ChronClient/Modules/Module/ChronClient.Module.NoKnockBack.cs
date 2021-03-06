﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronClient.Module
{
    public static class NoKnockBack
    {
        public static Modules.ModuleType ModuleType = new Modules.ModuleType("NoKnockBack", "Player", true, ref _ToggleState, new Action(OnEnable), new Action(OnDisable), null, null, null, null, new Action(Refresh), new Action(Toggle));

        public static void OnLoad()
        {
            Modules.ModuleManagment.ValueRegister.RegisterModule(ModuleType);
        }

        public static bool _ToggleState = false;

        public static bool ToggleState
        {
            get { return _ToggleState; }
            set
            {
                if (_ToggleState != value)
                {
                    if (value)
                    {
                        OnEnable();
                        _ToggleState = value;
                    }
                    else if (!value)
                    {
                        OnDisable();
                        _ToggleState = value;
                    }
                }
            }
        }

        public static void OnEnable()
        {
            // X
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x121A8D2, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
            // Y
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x121A8DB, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
            // Z
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x121A8E4, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
        }

        public static void OnDisable()
        {
            // Restore Memory
            // X
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x121A8D2, new byte[] { 0x89, 0x81, 0x6C, 0x04, 0x00, 0x00 });
            // Y
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x121A8DB, new byte[] { 0x89, 0x81, 0x70, 0x04, 0x00, 0x00 });
            // Z
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x121A8E4, new byte[] { 0x89, 0x81, 0x74, 0x04, 0x00, 0x00 });
        }

        public static void Toggle()
        {
            _ToggleState = !_ToggleState;
        }

        public static void Refresh()
        {
            if (ToggleState)
            {
                OnEnable();
            }
            else if (!ToggleState)
            {
                OnDisable();
            }
        }
    }
}
