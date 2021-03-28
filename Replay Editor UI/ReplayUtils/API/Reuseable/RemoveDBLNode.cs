namespace Replay_Editor_UI.ReplayUtils.API.Reuseable
{
    class RemoveDBLNode
    {

        public static string Replace(string CP, bool AddBackPath)
        {
            CP = CP.Replace("/Game/", "FortniteGame/Content/");
            if (CP.Contains("FortniteGame/Content/Athena/Heroes/Meshes/Bodies/"))
            {
                CP = CP.Replace("FortniteGame/Content/Athena/Heroes/Meshes/Bodies/", "").Replace(".", "");
                CP = CP.Substring(CP.Length / 2);

               if (AddBackPath)
                {
                    CP = "FortniteGame/Content/Athena/Heroes/Meshes/Bodies/" + CP;
                }
                return CP;
            }
            if (CP.Contains("FortniteGame/Content/Athena/Heroes/Meshes/Heads/"))
            {
                CP = CP.Replace("FortniteGame/Content/Athena/Heroes/Meshes/Heads/", "").Replace(".", "");
                CP = CP.Substring(CP.Length / 2);

                if (AddBackPath)
                {
                    CP = "FortniteGame/Content/Athena/Heroes/Meshes/Heads/" + CP;
                }
                return CP;
            }
            if (CP.Contains("FortniteGame/Content/Characters/CharacterParts/Female/Medium/Bodies/"))
            {
                CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/Female/Medium/Bodies/", "").Replace(".", "");
                CP = CP.Substring(CP.Length / 2);

                if (AddBackPath)
                {
                    CP = "FortniteGame/Content/Characters/CharacterParts/Female/Medium/Bodies/" + CP;
                }
                return CP;
            }
            if (CP.Contains("FortniteGame/Content/Characters/CharacterParts/Female/Medium/Heads/"))
            {
                CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/Female/Medium/Heads/", "").Replace(".", "");
                CP = CP.Substring(CP.Length / 2);

                if (AddBackPath)
                {
                    CP = "FortniteGame/Content/Characters/CharacterParts/Female/Medium/Heads/" + CP;
                }
                return CP;
            }
            if (CP.Contains("FortniteGame/Content/Characters/CharacterParts/Male/Medium/Bodies/"))
            {
                CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/Male/Medium/Bodies/", "").Replace(".", "");
                CP = CP.Substring(CP.Length / 2);

                if (AddBackPath)
                {
                    CP = "FortniteGame/Content/Characters/CharacterParts/Male/Medium/Bodies/" + CP;
                }
                return CP;
            }
            if (CP.Contains("FortniteGame/Content/Characters/CharacterParts/Male/Medium/Heads/"))
            {
                CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/Male/Medium/Heads/", "").Replace(".", "");
                CP = CP.Substring(CP.Length / 2);

                if (AddBackPath)
                {
                    CP = "FortniteGame/Content/Characters/CharacterParts/Male/Medium/Heads/" + CP;
                }
                return CP;
            }
            if (CP.Contains("FortniteGame/Content/Characters/CharacterParts/Hats/"))
            {
                CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/Hats/", "").Replace(".", "");
                CP = CP.Substring(CP.Length / 2);

                if (AddBackPath)
                {
                    CP = "FortniteGame/Content/Characters/CharacterParts/Hats/" + CP;
                }
                return CP;
            }
            if (CP.Contains("FortniteGame/Content/Characters/CharacterParts/FaceAccessories/"))
            {
                CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/FaceAccessories/", "").Replace(".", "");
                CP = CP.Substring(CP.Length / 2);

                if (AddBackPath)
                {
                    CP = "FortniteGame/Content/Characters/CharacterParts/FaceAccessories/" + CP;
                }
                return CP;
            }
            return CP;
        }
    }
}
