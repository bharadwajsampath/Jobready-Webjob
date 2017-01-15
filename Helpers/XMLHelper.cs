using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Worker.Helpers
{
    public static class XMLHelper
    {
        public static string ConvertToXML(List<ExportStudent> studentList)
        {

            // The string to hold the object content
            String content;

            // Create a memoryStream into which the data can be written and readed
            using (var stream = new MemoryStream())
            {
                // Create the xml serializer, the serializer needs to know the type
                // of the object that will be serialized
                var xmlSerializer = new XmlSerializer(typeof(List<ExportStudent>));

                // Create a XmlTextWriter to write the xml object source, we are going
                // to define the encoding in the constructor
                using (var writer = new XmlTextWriter(stream, Encoding.UTF8))
                {
                    // Save the state of the object into the stream
                    xmlSerializer.Serialize(writer, studentList);

                    // Flush the stream
                    writer.Flush();

                    // Read the stream into a string
                    using (var reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        // Set the stream position to the begin
                        stream.Position = 0;

                        // Read the stream into a string
                        content = reader.ReadToEnd();
                    }
                }
            }

            // Return the xml string with the object content
            return content;

        }
    }
}
