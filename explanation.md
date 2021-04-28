# Boundless Replay Editor Explained

Boundless Replay Editor is an **open-source** project for editing replays. This document explains each and every file of the replay editor's source.

# Basic Files

##### `MainWindow.xaml(.cs)` is the main window for the editor.
##### `Options.xaml(.cs)` is the options window for the editor.
##### `Discord/Init.cs` is the Discord Rich Presence For the Editor.
##### `Functions/BoundlessMessage(Box(.xaml.cs)).cs` is the Message Box System.

## Get Directory

##### `Gets/AppData.cs` is the `%appdata%` directory for where the editor places files for later use.
##### `Gets/Bytes.cs` is the `Get Bytes` function for getting bytes from a string (For writing in files).
##### `Gets/Params.cs` is the file that stores the swapping parameters/information.

## Utils Directory

##### `Utils/Download.cs` is the download helper class for the [replay dumper](https://github.com/Shiqan/FortniteReplayDecompressor).
##### `Utils/UserSettings.cs` along with Gets/AppData.cs this section is used to store information for later use; such as theme and output paths.

# Replay Utils
## Most Important Section along with Basic Files

##### `ReplayUtils/CheckLength.cs` as the name implies it checks the length of the input of `Search Name` and `Replace Name`, for example if one of the character parts for that skin was too long to keep the same size it wouldn't swap due to this check.
##### `ReplayUtils/Researcher.cs` a simple find and return offset class (search function).
##### `ReplayUtils/Writer.cs` writing bytes of a file is the whole point of the editor, this class holds the decompressed check to see if the file is already decompressed or is not decompressed yet, and the replace functions. Reffer to the class above.

### Sub Folder; API
##### `ReplayUtils/API/API_Backpack.cs` is the function to get the assets for editing for backblings.
##### `ReplayUtils/API/API_Emote.cs` is the function to get the assets for editing for dances.
##### `ReplayUtils/API/API_Pickaxe.cs` is the function to get the assets for editing for harvesting tools.
##### `ReplayUtils/API/API_Skin.cs` is the function to get the assets for editing for backblings.
##### `ReplayUtils/API/API_Wrap_And_Glider.cs` is the function to get the assets for editing for item wraps and glider gadgets.

#### Sub Folder of API; Manual
##### `ReplayUtils/Manual/API_FromHS.cs` is the function to get assets for editing for specializations (HS).

#### Sub Folder of API; Reuseable
##### `ReplayUtils/Reuseable/ByName.cs` gets the ID from the name of item you inputed.
##### `ReplayUtils/Reuseable/RemoveDBLNode.cs` removes the double node for the asset, for example `FortniteGame/Content/Characters/CharacterParts/Hats/Hat_F_RenegadeRaiderFire.Hat_F_RenegadeRaiderFire` to `FortniteGame/Content/Characters/CharacterParts/Hats/Hat_F_RenegadeRaiderFire`

### Sub Folder; Functions
##### `ReplayUtils/Functions/Test.cs` function for the test button on the MainWindow.
##### `ReplayUtils/Functions/Total.cs` as the name implies it is the total function, this is what controls everything editing related.
##### `ReplayUtils/Functions/Total_FromHS.cs` reffer to Total and API_FromHS.

### Sub Folder; Presets
##### `ReplayUtils/Presets/SetItemData.cs` function for storing and using stored asset data for reuse.

### Sub Folder; Swap
##### `ReplayUtils/Swap/LongSwitch.cs` function for the swapping of skins, reffer to ReplayUtils/Functions/Total.cs.
##### `ReplayUtils/Swap/SwapBackpack.cs` function for swapping backblings.
##### `ReplayUtils/Swap/SwapEmote.cs` function for swapping dances.
##### `ReplayUtils/Swap/SwapPickaxe.cs` function for swapping pickaxes.
##### `ReplayUtils/Swap/SwapWrapAndGlider.cs` function for swapping wraps and gliders.

#### Sub Folder of Swap; Manual
##### `ReplayUtils/Swap/Manual/FromHS.cs` basically ./LongSwitch.cs but for specializations.
##### `ReplayUtils/Swap/Manual/ManualSwap.cs` completely for the manually swapping feature (not HS).

# End of Explanation
