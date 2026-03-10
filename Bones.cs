namespace AotForms
{
    internal static class Bones
    {
        // Saari bone offsets ko variables bana diya taaki update ho sakein
        internal static uint Head;
        internal static uint Root;
        internal static uint Hip;
        internal static uint Spine;
        internal static uint RightCalf;
        internal static uint LeftCalf;
        internal static uint RightFoot;
        internal static uint LeftFoot;
        internal static uint RightShoulder;
        internal static uint LeftShoulder;
        internal static uint RightElbow;
        internal static uint LeftElbow;
        internal static uint RightWrist;
        internal static uint LeftWrist;
        internal static uint RightWristJoint;
        internal static uint LeftWristJoint;
        internal static uint RightHand;
        internal static uint LeftHand;

        // Ye function Offsets.LoadOffsets ke andar se call hoga
        public static void LoadBones(bool forMax)
        {
            if (forMax)
            {
                // ============================
                // FREE FIRE MAX BETA BONE OFFSETS
                // ============================
                Head = 0x3E8;
                Hip = 0x3EC;
                Spine = 0x3F0;
                Root = 0x3FC;
                RightCalf = 0x400;
                LeftCalf = 0x404;
                RightFoot = 0x408;
                LeftFoot = 0x40C;
                LeftWrist = 0x3E4;
                RightWrist = 0x410;
                LeftHand = 0x414;
                LeftShoulder = 0x41C;
                RightShoulder = 0x420;
                RightWristJoint = 0x424;
                LeftWristJoint = 0x428;
                LeftElbow = 0x42C;
                RightElbow = 0x430;
            }
            else
            {
                // ============================
                // FREE FIRE NORMAL BONE OFFSETS
                // ============================
                Head = 0x3F8;
                Hip = 0x3FC;
                Spine = 0x400;
                Root = 0x40C;
                RightCalf = 0x410;
                LeftCalf = 0x414;
                RightFoot = 0x418;
                LeftFoot = 0x41C;
                LeftWrist = 0x3F4;
                RightWrist = 0x420;
                LeftHand = 0x424;
                LeftShoulder = 0x42C;
                RightShoulder = 0x430;
                RightWristJoint = 0x434;
                LeftWristJoint = 0x438;
                LeftElbow = 0x43C;
                RightElbow = 0x440;
            }
        }
    }
}