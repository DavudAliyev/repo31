
using System.IO;

DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\Asus\\Desktop\\C# Homeworks\\Homework 28");

Console.WriteLine("DirInfo: ");
Console.WriteLine("Fullname: "+ dirInfo.FullName);
Console.WriteLine("Name: "+ dirInfo.Name);
Console.WriteLine("Creation time: "+ dirInfo.CreationTime);
Console.WriteLine("Last Access time: "+ dirInfo.LastAccessTime);
Console.WriteLine("Parent: "+dirInfo.Parent);
Console.WriteLine("Files count: "+dirInfo.GetFiles().Length);
Console.WriteLine("Directories count: "+dirInfo.GetDirectories().Length);

Console.WriteLine("\n================================================\n");


FileInfo fileInfo = new FileInfo("C:\\Users\\Asus\\Desktop\\fileinfo");

Console.WriteLine("fileinfo: ");
Console.WriteLine("Fullname: "+fileInfo.FullName);
Console.WriteLine("Name: "+fileInfo.Name);
Console.WriteLine("Creation time: "+fileInfo.CreationTime);
Console.WriteLine("Last access time: "+fileInfo.LastAccessTime);
//Console.WriteLine("Length: " + fileInfo.Length);

Console.WriteLine("\n================================================\n");

FileInfo fileinfo1=new FileInfo("C:\\Users\\Asus\\Desktop\\fileinfo1");

if(!fileinfo1.Exists)
{
    Console.WriteLine("fayl tapilmadi, yenisi yaradilsin? y/n");
    string opt=Console.ReadLine();

    if(opt=="y")
    {
        var newfs=fileinfo1.Create();
        newfs.Close();
    }
}

Console.WriteLine("Directories in files folder");

foreach (var item in dirInfo.GetFiles())
{
    if(item.Length==0)
    {
        File.Delete(item.FullName);
    }
}




