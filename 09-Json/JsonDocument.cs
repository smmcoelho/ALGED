using System.Text.Json;

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

// Deserialize directly into a custom class structure
var schoolData = JsonDocument.Parse(jstring);

// Accessing properties using standard dot-notation
Console.WriteLine(schoolData.RootElement.GetProperty("school").GetString());                // Output: Greenwood High
Console.WriteLine(schoolData.RootElement.GetProperty("location").GetProperty("city").GetString()); // Output: New York
Console.WriteLine(schoolData.RootElement.GetProperty("students")[0].GetProperty("name").GetString());// Output: Emma
