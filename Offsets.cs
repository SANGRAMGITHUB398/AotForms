namespace AotForms
{
    internal static class Offsets
    {
        // Check karne ke liye ki kaunsa game chal raha hai
        public static bool IsMax = false;

        // IL2CPP & BASE
        internal static ulong Il2Cpp;
        internal static ulong InitBase;

        // MATCH OFFSETS
        internal static uint StaticClass;
        internal static uint DisableAFK;
        internal static uint CurrentMatch;
        internal static uint MatchStatus;
        internal static uint GameTimer;
        internal static uint FixedDeltaTime;
        internal static uint[] SpeedJoystickOffsets;

        // LOCAL / PLAYER OFFSETS
        internal static uint PlayerRotation;
        internal static uint LocalPlayer;
        internal static uint Player_IsDead;
        internal static uint Player_Data;
        internal static uint CurrentHP;
        internal static uint Player_Name;
        internal static uint IsBot;
        internal static uint DictionaryEntities;
        internal static uint Player_ShadowBase;
        internal static uint PlayerAttributes;
        internal static uint AimbotVisible;
        internal static uint XPose;
        internal static uint BotOffset;

        // AVATAR OFFSETS
        internal static uint AvatarManager;
        internal static uint Avatar;
        internal static uint Avatar_IsVisible;
        internal static uint Avatar_Data;
        internal static uint Avatar_Data_IsTeam;
        internal static uint AvatarPropManager;

        // CAMERA OFFSETS
        internal static uint FollowCamera;
        internal static uint Camera;
        internal static uint AimRotation;
        internal static uint MainCameraTransform;
        internal static uint ViewMatrix;

        // WEAPON OFFSETS
        internal static uint Weapon;
        internal static uint ActiveWeapon;
        internal static uint WeaponOnHand;
        internal static uint WeaponID;
        internal static uint WeaponRecoil;
        internal static uint WeaponData;
        internal static uint WeaponInfo;
        internal static uint WeaponName;
        internal static uint UnkPlayerWeaponInfoClass;
        internal static uint UnkPlayerWeaponInfoClass1;
        internal static uint NoReload;
        internal static uint AimAssist;

        // SILENT AIM OFFSETS
        internal static uint sAim1;
        internal static uint sAim2;
        internal static uint sAim3;
        internal static uint sAim4;

        // --- DYNAMIC LOAD FUNCTION ---
        public static void LoadOffsets(bool forMax)
        {
            IsMax = forMax;

            Bones.LoadBones(forMax);

            if (forMax)
            {
                // ==========================================
                // FREE FIRE MAX OFFSETS (Yahan Max wale dalo)
                // ==========================================
                InitBase = 0xB29057C;
                StaticClass = 0x5C;
                CurrentMatch = 0x50;
                MatchStatus = 0x74;
                GameTimer = 0x10;
                FixedDeltaTime = 0x24;
                SpeedJoystickOffsets = 0x44;

                PlayerRotation = 0xFC;
                LocalPlayer = 0x7C;
                Player_IsDead = 0x4C;
                Player_Data = 0x44;
                CurrentHP = 0x2B8;
                Player_Name = 0x27C;
                IsBot = 0x284;
                DictionaryEntities = 0x68;
                Player_ShadowBase = 0x15BC;
                PlayerAttributes = 0x44C;
                AimbotVisible = 0x434;
                XPose = 0x78;
                BotOffset = 0x58;
                DisableAFK = 0x6B2;

                AvatarManager = 0x450;
                Avatar = 0x94;
                Avatar_IsVisible = 0x7C;
                Avatar_Data = 0x10;
                Avatar_Data_IsTeam = 0x4D;
                AvatarPropManager = 0x458;

                FollowCamera = 0x3E0;
                Camera = 0x14;
                AimRotation = 0x398;
                MainCameraTransform = 0x200;
                ViewMatrix = 0xBC;

                Weapon = 0x38C;
                ActiveWeapon = 0x38C;
                WeaponOnHand = 0x4C;
                WeaponID = 0x08;
                WeaponRecoil = 0x0C;
                WeaponData = 0x64;
                WeaponInfo = 0x64;
                WeaponName = 0x58;
                UnkPlayerWeaponInfoClass = 0x44C;

                NoReload = 0x91;
                AimAssist = 0x3B8;

                sAim1 = 0x4D0;
                sAim2 = 0x8DC;
                sAim3 = 0x38;
                sAim4 = 0x2C;
            }
            else
            {
                // ==========================================
                // FREE FIRE NORMAL OFFSETS (Aapka Current Data)
                // ==========================================
                InitBase = 0xA3F438C;
                StaticClass = 0x5C;
                CurrentMatch = 0x50;
                MatchStatus = 0x08;
                GameTimer = 0x10;
                FixedDeltaTime = 0x24;
                SpeedJoystickOffsets = 0x44;

                LocalPlayer = 0x7C;
                PlayerRotation = 0xFC;
                Player_IsDead = 0x4C;
                Player_Data = 0x44;
                CurrentHP = 0x2C8;
                Player_Name = 0x28C;
                IsBot = 0x294;
                DictionaryEntities = 0x68;
                Player_ShadowBase = 0x15E8;
                PlayerAttributes = 0x45C;
                DisableAFK = 0x6B2;

                XPose = 0x78;
                BotOffset = 0x58;
                AimbotVisible = 0x444;

                AvatarManager = 0x460;
                Avatar = 0x94;
                Avatar_IsVisible = 0x7C;
                Avatar_Data = 0x10;
                Avatar_Data_IsTeam = 0x51;
                AvatarPropManager = 0xBC;

                FollowCamera = 0x3F0;
                Camera = 0x14;
                AimRotation = 0x3A8;
                MainCameraTransform = 0x1FC;
                ViewMatrix = 0xBC;

                Weapon = 0x39C;
                ActiveWeapon = 0x39C;
                WeaponOnHand = 0x4C;
                WeaponData = 0x64;
                WeaponID = 0x08;
                WeaponName = 0x64;
                WeaponInfo = 0x64;
                WeaponRecoil = 0x91;
                UnkPlayerWeaponInfoClass = 0x444;
                NoReload = 0x91;
                AimAssist = 0x3C8;

                sAim1 = 0x4E0;
                sAim2 = 0x8F0;
                sAim3 = 0x38;
                sAim4 = 0x2C;
            }
        }
    }

}

