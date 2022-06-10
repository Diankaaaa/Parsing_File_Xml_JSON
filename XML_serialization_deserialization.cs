using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Parsing_File_Xml_JSON
{
    class XML_serialization_deserialization : Factory
    {
        public override void Deserialization()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("people.xml", FileMode.OpenOrCreate))
            {
                Person[] newpeople = formatter.Deserialize(fs) as Person[];
                if (newpeople != null)
                {
                    foreach (Person person in newpeople)
                    {
                        MessageBox.Show($"Name: {person.Name} --- Age: {person.Age}");
                    }
                }
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
            XmlSerializer formatter = new XmlSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("people.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, people);
            }

        }
    }
}
