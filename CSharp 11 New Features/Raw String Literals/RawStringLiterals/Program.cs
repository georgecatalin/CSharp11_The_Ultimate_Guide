/* ******************************************************************************************************
 * Raw string literals have been added in C# 11 (.NET 7.0 +) and makes it simple to represent:
 * multi line SQL Queries, JSON and XML elements, file paths, regular expressions with special characters
 * ***************************************************************************************************** */


namespace RawStringLiterals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonOldWay = "{\r\n    \"glossary\": {\r\n        \"title\": \"example glossary\",\r\n\t\t\"GlossDiv\": {\r\n            \"title\": \"S\",\r\n\t\t\t\"GlossList\": {\r\n                \"GlossEntry\": {\r\n                    \"ID\": \"SGML\",\r\n\t\t\t\t\t\"SortAs\": \"SGML\",\r\n\t\t\t\t\t\"GlossTerm\": \"Standard Generalized Markup Language\",\r\n\t\t\t\t\t\"Acronym\": \"SGML\",\r\n\t\t\t\t\t\"Abbrev\": \"ISO 8879:1986\",\r\n\t\t\t\t\t\"GlossDef\": {\r\n                        \"para\": \"A meta-markup language, used to create markup languages such as DocBook.\",\r\n\t\t\t\t\t\t\"GlossSeeAlso\": [\"GML\", \"XML\"]\r\n                    },\r\n\t\t\t\t\t\"GlossSee\": \"markup\"\r\n                }\r\n            }\r\n        }\r\n    }\r\n}\r\n";
            Console.WriteLine("JSON represented the old way" + jsonOldWay);

            string jsonRawStringLiteral = """
                                {
                    "glossary": {
                        "title": "example glossary",
                		"GlossDiv": {
                            "title": "S",
                			"GlossList": {
                                "GlossEntry": {
                                    "ID": "SGML",
                					"SortAs": "SGML",
                					"GlossTerm": "Standard Generalized Markup Language",
                					"Acronym": "SGML",
                					"Abbrev": "ISO 8879:1986",
                					"GlossDef": {
                                        "para": "A meta-markup language, used to create markup languages such as DocBook.",
                						"GlossSeeAlso": ["GML", "XML"]
                                    },
                					"GlossSee": "markup"
                                }
                            }
                        }
                    }
                }
                
                """;

            Console.WriteLine("\nJSON represented with RawStringLiteral (no difference)" + jsonRawStringLiteral );

            /* Notes:
             * 1. there can be any number of " delimiters, of three or more like """ or """" or """"" and so on
             * 2. the """ delimiters have to be placed at the start and ending on separate lines.
             * 3. spaces from the lines, other than delimiters' lines  are preserved in the value of the variable
             * 4. string interpolation can be used similarly with normal strings like $"""{variablename} is something"""
             * 5. raw string literals can be also represented on a single line
             * *********/
        }
    }
}
