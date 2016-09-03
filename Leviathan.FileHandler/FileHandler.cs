using System;

namespace Leviathan.FileHandler
{
    public static class FileHandler
    {
        public static String GameFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/My Games/Leviathan/";
        public static String SaveFolder = GameFolder + "saves/";
        public static String ConfigFolder = GameFolder + "config/";

        public static T Read<T>(String filepath, Type typeInAssembly)
        {
            T result;

            using (System.IO.StreamReader sr = new System.IO.StreamReader(filepath))
            {
                String oldVersion = "";
                String currentVersion = System.Reflection.Assembly.GetAssembly(typeInAssembly).GetName().Version.ToString();

                try
                {
                    oldVersion = sr.ReadLine();
                    String content = sr.ReadToEnd();
                    //content = CryptoProvider.Decrypt(sr.ReadToEnd(), typeInAssembly.FullName);
                    result = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
                }
                catch
                {
                    String msg = "";

                    if (oldVersion != currentVersion)
                        msg = "This save file was created with a different version of the game. Cannot load character.";
                    else
                        msg = "This save file was probably corrupted. Cannot load character.";

                    throw new Exceptions.ReadException(msg);
                }

            }

            return result;
        }

        [Obsolete]
        public static String Read(String filepath, Type typeInAssembly)
        {
            String result = "";

            using (System.IO.StreamReader sr = new System.IO.StreamReader(filepath))
            {
                String oldVersion = "";
                String currentVersion = System.Reflection.Assembly.GetAssembly(typeInAssembly).GetName().Version.ToString();

                try
                {
                    oldVersion = sr.ReadLine();
                    result = sr.ReadToEnd();
                }
                catch
                {
                    String msg = "";

                    if (oldVersion != currentVersion)
                        msg = "This save file was created with a different version of the game. Cannot load character.";
                    else
                        msg = "This save file was probably corrupted. Cannot load character.";

                    throw new Exceptions.ReadException(msg);
                }
                
            }

            //return CryptoProvider.Decrypt(result, typeInAssembly.FullName);
            return result;
        }

        public static void Write<T>(String filepath, T objectToWrite, Type typeInAssembly)
        {
            String content = Newtonsoft.Json.JsonConvert.SerializeObject(objectToWrite, Newtonsoft.Json.Formatting.Indented);

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filepath))
            {
                String currentVersion = System.Reflection.Assembly.GetAssembly(typeInAssembly).GetName().Version.ToString();

                sw.WriteLine(currentVersion);
                //sw.WriteLine(CryptoProvider.Encrypt(content, typeInAssembly.FullName));
                sw.WriteLine(content);
            }
        }

        [Obsolete]
        public static void Write(String filepath, String content, Type typeInAssembly)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filepath))
            {
                String currentVersion = System.Reflection.Assembly.GetAssembly(typeInAssembly).GetName().Version.ToString();

                sw.WriteLine(currentVersion);
                //sw.WriteLine(CryptoProvider.Encrypt(content, typeInAssembly.FullName));
                sw.WriteLine(content);
            }
        }
    }
}
