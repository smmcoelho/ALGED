
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

// Pass PropertyNameCaseInsensitive = true as an option
var options = new JsonSerializerOptions 
{ 
    PropertyNameCaseInsensitive = true 
};

// Deserialize directly into a strongly-typed C# record/class
SchoolInfo schoolData = JsonSerializer.Deserialize<SchoolInfo>(jstring, options);

// Accessing properties using standard, clean dot-notation
Console.WriteLine(schoolData.School);                  // Output: Greenwood High
Console.WriteLine(schoolData.Location.City);            // Output: New York
Console.WriteLine(schoolData.Students[0].Name);         // Output: Emma


// // --- Supporting C# Records ---
public record SchoolInfo(string School, Location Location, List<Student> Students);
public record Location(string City, string State);
public record Student(string Name, int Age, string Grade);
