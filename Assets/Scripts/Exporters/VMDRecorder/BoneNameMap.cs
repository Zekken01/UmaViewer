using System.Collections.Generic;

public static class BoneNameMap
{
    public static readonly Dictionary<string, string> JpToEn = new Dictionary<string, string>()
    {
        {"全ての親", "Root"},
        {"グルーブ", "Hip"},
        {"センター", "Waist"},
        {"上半身", "Spine"},
        {"上半身2", "Chest"},
        {"首", "Neck"},
        {"頭", "Head"},

        // Right arm / hand
        {"右肩", "Shoulder_R"},
        {"右腕", "Arm_R"},
        {"右ひじ", "Elbow_R"},
        {"右手首", "Wrist_R"},
        {"右親指１", "Thumb_01_R"},
        {"右親指２", "Thumb_02_R"},
        {"右人指１", "Index_01_R"},
        {"右人指２", "Index_02_R"},
        {"右人指３", "Index_03_R"},
        {"右中指１", "Middle_01_R"},
        {"右中指２", "Middle_02_R"},
        {"右中指３", "Middle_03_R"},
        {"右薬指１", "Ring_01_R"},
        {"右薬指２", "Ring_02_R"},
        {"右薬指３", "Ring_03_R"},
        {"右小指１", "Pinky_01_R"},
        {"右小指２", "Pinky_02_R"},
        {"右小指３", "Pinky_03_R"},

        // Left arm / hand
        {"左肩", "Shoulder_L"},
        {"左腕", "Arm_L"},
        {"左ひじ", "Elbow_L"},
        {"左手首", "Wrist_L"},
        {"左親指１", "Thumb_01_L"},
        {"左親指２", "Thumb_02_L"},
        {"左人指１", "Index_01_L"},
        {"左人指２", "Index_02_L"},
        {"左人指３", "Index_03_L"},
        {"左中指１", "Middle_01_L"},
        {"左中指２", "Middle_02_L"},
        {"左中指３", "Middle_03_L"},
        {"左薬指１", "Ring_01_L"},
        {"左薬指２", "Ring_02_L"},
        {"左薬指３", "Ring_03_L"},
        {"左小指１", "Pinky_01_L"},
        {"左小指２", "Pinky_02_L"},
        {"左小指３", "Pinky_03_L"},

        // Right leg
        {"右足", "Thigh_R"},
        {"右ひざ", "Knee_R"},
        {"右足首", "Ankle_R"},
        {"右足ＩＫ", "Toe_R_Handle"},
        {"右足先EX", "Toe_R"},
        {"右つま先ＩＫ", "Toe_R_IK"},

        // Left leg
        {"左足", "Thigh_L"},
        {"左ひざ", "Knee_L"},
        {"左足首", "Ankle_L"},
        {"左足ＩＫ", "Toe_L_Handle"},
        {"左足先EX", "Toe_L"},
        {"左つま先ＩＫ", "Toe_L_IK"},
    };

    public static string GetEnglish(string jpName, string fallback = null)
    {
        if (jpName == null) return fallback;
        if (JpToEn.TryGetValue(jpName, out var en)) return en;
        return fallback ?? jpName;
    }
}
