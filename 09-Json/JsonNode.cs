
using System.Text.Json.Nodes;

// 1. Use a Raw String Literal (""") for clean, multi-line JSON without escape characters
string jstring = """
                 {
                     "school": "Greenwood High",
                     "location": {
                         "city": "New York",
                         "state": "NY"
                     },
                     "students": [
                         {"name": "Emma", "age": 15, "grade": "10"},
                         {"name": "Liam", "age": 14, "grade": "9"},
                         {"name": "Olivia", "age": 16, "grade": "11"}
                     ]
                 }
                 """;

// 2. Parse the JSON string into a JSON Node
var jdoc = JsonNode.Parse(jstring);

Console.WriteLine(jdoc["school"]);
Console.WriteLine(jdoc["location"]["city"]);
Console.WriteLine(jdoc["students"][0]["name"]);
