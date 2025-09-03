namespace Aula18;
using System.IO;

public class Program
{
    public static void Main()
    {
        //Criar um arquivo
        //string content = "Hello World!";

        // File.WriteAllText("file.txt", content);

        //Console.WriteLine("Arquivo criado com sucesso");

        //Criar arquivo em local especifico 
        //string path = @"D:\Aulas\Aula18\fileName.txt";

        //string content = "Hello World";

        //File.WriteAllText(path, content);

        //Criar um arquivo Word
        //string path = @"D:\Aulas\Aula18\";
        //string filename = "myDocument.Doc";
        //string filhePath = path + filename;

        //string content = "Hello World";

        // File.WriteAllText(filhePath, content);

        // Console.WriteLine("Arquivo Word criado com sucesso");

        //string path = @"D:\Aulas\Aula18\";
        //string filename = "myDocument.Doc";
        //string filhePath = path + filename;

        //string additionalContent = "Curso de C# e .NET ";

        // File.AppendAllText(filhePath, additionalContent);

        //Console.WriteLine("Arquivo Atualizado com sucesso");

        //Ler o arquivo
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("Conteudo do Arquivo: " + fileContent);
        string filhePath = path + filename;

        string fileContent = fileContent.ReadAllText(filhePath);
        Console.WriteLine(fileContent);
    
    }
}