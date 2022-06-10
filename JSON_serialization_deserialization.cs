using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Windows;

namespace Parsing_File_Xml_JSON
{
    class JSON_serialization_deserialization : Factory
    {
        public override void Deserialization()
        {
            using (FileStream fs = File.OpenRead("peoples.json"))
            {
                byte[] output = new byte[fs.Length];
                fs.Read(output, 0, output.Length);
                string text = Encoding.Default.GetString(output);
                MessageBox.Show(text);
            }
        }

        public override void Serializtion()
        {
            Person[] people = new Person[]
                {
                    new Person ("Kate", 18),
                    new Person ("Alexandra",19),
                    new Person ("Mika",19)
                };
            string jsonSerialization = JsonSerializer.Serialize(people, typeof(Person[]));
            using (FileStream fs = new FileStream("peoples.json", FileMode.OpenOrCreate))
            {
                byte[] input = Encoding.Default.GetBytes(jsonSerialization);
                fs.Write(input, 0, input.Length);
            }
        }
    }
}
