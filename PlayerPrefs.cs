//https://www.red-gate.com/simple-talk/dotnet/c-programming/saving-game-data-with-unity/
void SaveGame()
{
	PlayerPrefs.SetInt("SavedInteger", intToSave);
	PlayerPrefs.SetFloat("SavedFloat", floatToSave);
	PlayerPrefs.SetString("SavedString", stringToSave);
	PlayerPrefs.Save();
	Debug.Log("Game data saved!");
}

void LoadGame()
{
	if (PlayerPrefs.HasKey("SavedInteger"))
	{
		intToSave = PlayerPrefs.GetInt("SavedInteger");
		floatToSave = PlayerPrefs.GetFloat("SavedFloat");
		stringToSave = PlayerPrefs.GetString("SavedString");
		Debug.Log("Game data loaded!");
	}
	else
		Debug.LogError("There is no save data!");
}

void ResetData()
{
	PlayerPrefs.DeleteAll();
	intToSave = 0;
	floatToSave = 0.0f;
	stringToSave = "";
	Debug.Log("Data reset complete");
}
