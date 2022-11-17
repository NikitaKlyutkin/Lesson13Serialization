
using Lesson13Serialization;

var result = ObjectExtentions.ReadFromJsonFile<Squad>(@"C:/squad.json");

ObjectExtentions.WriteToJsonFile<Squad>(@"C:/result.json", result);
ObjectExtentions.WriteToXmlFile<Squad>(@"C:/resultxml.xml", result);