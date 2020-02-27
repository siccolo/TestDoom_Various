using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

public class Folders
{
     

    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        XDocument doc = XDocument.Parse(xml);
        
        var list2 = doc.Descendants("folder")
                 .Where(e => e.Attribute("name").Value.StartsWith(startingLetter.ToString(), StringComparison.InvariantCultureIgnoreCase))
                 .Select(e=> e.Attribute("name").Value)
                 ;

        return list2;

    }

    public static void Check()
    {
        string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"uuu\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +

                "<folder name=\"users\" />" +

                "<folder name=\"u1\">" +
                     "<folder name=\"program files\">" +
                        "<folder name=\"u3\" />" +
                    "</folder>" +
                "</folder>" +

            "</folder>";

        foreach (string name in Folders.FolderNames(xml, 'u'))
            Console.WriteLine(name);
    }
}