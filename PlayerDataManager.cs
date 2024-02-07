using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class PlayerDataManager
{
    private static string _filePath = "playerData.dat";

    public static void SavePlayerData(PlayerData playerData)
    {
        try
        {
            using (Stream stream = File.Open(_filePath, FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, playerData);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error saving player data");
        }
    }
}

public static PlayerData LoadPlayerData()
{
    PlayerData playerData = new PlayerData();
    try
    {
        if (File.Exists(_filePath))
        {
            using (Stream stream = File.Open(_filePath, FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();
                playerData = (PlayerData)bin.Deserialize(stream);
                return playerData;
            }
        }
}
    catch (IOException)
    {
    Console.WriteLine("Error loading player data" + Exception.Message);
}
    return new playerData;
}
{

}
