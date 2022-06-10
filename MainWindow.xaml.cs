using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parsing_File_Xml_JSON
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            XmlParsing();
            JSON_Parsing();
        }

        public void XmlParsing()
        {
            XML_serialization_deserialization x = new XML_serialization_deserialization();
            x.Serializtion();
            x.Deserialization();
        }

        public void JSON_Parsing()
        {
            JSON_serialization_deserialization j = new JSON_serialization_deserialization();
            j.Serializtion();
            j.Deserialization();  
        }
    }
}
