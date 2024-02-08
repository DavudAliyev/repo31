using LessonPractice;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using System.Xml.Serialization;


User user1 = null;
user1 = new User()
{
    Name = "Raul",
    Surname = "Aliyev",
    Age = 23
};

Console.WriteLine(user1);

void SerializeBinary(User user)
{
    FileStream fs=new FileStream("C:\\Users\\Asus\\Desktop\\User",FileMode.Create);
    BinaryFormatter bf=new BinaryFormatter();
    bf.Serialize(fs, user);
    fs.Close();
}

User DeserializeBinary()
{
    FileStream fs=new FileStream("C:\\Users\\Asus\\Desktop\\User", FileMode.Open);
    BinaryFormatter bf=new BinaryFormatter();
    var data = bf.Deserialize(fs) as User;
    return data;
}

void SerializeXml(User user)
{
    FileStream fs = new FileStream("C:\\Users\\Asus\\Desktop\\User2", FileMode.Create);
    XmlSerializer bf=new XmlSerializer(typeof(User));
    bf.Serialize(fs, user);
    fs.Close();
}

User DeserializeXml()
{
    User data = null;

    using (var fs = new FileStream("C:\\Users\\Asus\\Desktop\\User2", FileMode.Open)) 
    {
        XmlSerializer bf=new XmlSerializer(typeof(User));
        data= bf.Deserialize(fs) as User;
    }

    return data;

}

void SerializeJson(User user)
{
    using(FileStream fs = new FileStream("C:\\Users\\Asus\\Desktop\\User3", FileMode.Create))
    {
        var jsonStr=JsonConvert.SerializeObject(user);
        Console.WriteLine(jsonStr);

        StreamWriter sw=new StreamWriter(fs);
        sw.Write(jsonStr);
        sw.Close();

    }
}

User DeserializeJson()
{
    User data=null; 


    using(FileStream fs=new FileStream("C:\\Users\\Asus\\Desktop\\User3", FileMode.Open))
    {
        StreamReader sr=new StreamReader(fs);
        var jsonStr=sr.ReadToEnd(); 
        data=JsonConvert.DeserializeObject<User>(jsonStr);
    }

    return data;
}



