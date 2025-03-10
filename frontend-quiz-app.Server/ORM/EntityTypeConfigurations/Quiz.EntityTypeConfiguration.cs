using frontend_quiz_app.Server.DTOs.Enums;
using frontend_quiz_app.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace frontend_quiz_app.Server.ORM.EntityTypeConfigurations
{
    public class QuizEntityTypeConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasData(
                new Quiz()
                {
                    Id = new Guid("88A8BC10-5E04-4949-B93C-2F2F30A6DC5D"),
                    Question = "What does HTML stand for?",
                    Answer = "Hyper Text Markup Language",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "Hyper Trainer Marking Language",
                        "Hyper Text Marketing Language",
                        "Hyper Text Markup Language",
                        "Hyper Text Markup Leveler"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("82ACE605-FEC7-48DB-A9E3-CADDCB9B8AE0"),
                    Question = "Which of the following is the correct structure for an HTML document?",
                    Answer = "<html><head></head><body></body></html>",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "<html><head></head><body></body></html>",
                        "<head><html></html><body></body></head>",
                        "<body><head></head><html></html></body>",
                        "<html><body></body><head></head></html>"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("14D0C2EB-B52F-48E0-B647-33C877D1D38C"),
                    Question = "Which HTML element is used to define the title of a document?",
                    Answer = "<title>",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "<head>",
                        "<title>",
                        "<header>",
                        "<top>"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("37354314-63A8-468B-9592-2BF4E0C605EF"),
                    Question = "What is the purpose of the <body> tag in HTML?",
                    Answer = "It contains all the content such as text, images, and links.",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "It defines the document's head section.",
                        "It contains all the content such as text, images, and links.",
                        "It is used to define the main content of an HTML document.",
                        "It specifies the body of the email content in HTML."
                    }
                },
                new Quiz()
                {
                    Id = new Guid("1945A467-92B7-4F57-A420-83F60015DF5E"),
                    Question = "Which HTML tag is used to create a hyperlink?",
                    Answer = "<a>",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "<hyperlink>",
                        "<link>",
                        "<a>",
                        "<href>"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("4592F1FA-DC8A-46E2-9AED-8C00D7714193"),
                    Question = "Which tag is used to display images in HTML?",
                    Answer = "<img>",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "<img>",
                        "<image>",
                        "<src>",
                        "<pic>"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("E8D42B3E-D3B5-47A0-8981-44BF8C811250"),
                    Question = "What attribute is used to provide the path of an image in the <img> tag?",
                    Answer = "src",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "link",
                        "src",
                        "href",
                        "url"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("7AC82061-FA2E-4C1C-9EDA-FCC460185BFF"),
                    Question = "What attribute is used to provide the path of an image in the <img> tag?",
                    Answer = "src",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "link",
                        "src",
                        "href",
                        "url"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("485D3EB7-A0F1-4905-A97A-B998EADB711E"),
                    Question = "Which HTML tag is used to create an unordered list?",
                    Answer = "<ul>",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "<ul>",
                        "<ol>",
                        "<list>",
                        "<li>"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("A5639636-9622-4D4A-A930-96DF1ACEFBEF"),
                    Question = "What does the <br> tag do?",
                    Answer = "It inserts a line break.",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "It breaks the text into two sections.",
                        "It creates a bold text.",
                        "It inserts a line break.",
                        "It adds a new row in a table."
                    }
                },
                new Quiz()
                {
                    Id = new Guid("0F7BD0D1-22DC-4BD5-A4CA-0BD4E9ABAC55"),
                    Question = "In HTML, what does the `fieldset` tag do?",
                    Answer = "It is used to group related data in a form.",
                    Category = EQuizCategory.Html,
                    Options = new()
                    {
                        "It is used to group related data in a form.",
                        "It sets the field to a fixed size.",
                        "It automatically validates the fields within a form.",
                        "It hides the fields in a form."
                    }
                },
                new Quiz()
                {
                    Id = new Guid("5D4B8A72-6E90-4B5E-B02A-9E5B5A6D1C02"),
                    Question = "What does CSS stand for?",
                    Answer = "Cascading Style Sheets",
                    Category = EQuizCategory.Css,
                    Options = new()
                    {
                        "Colorful Style Sheets",
                        "Computer Style Sheets",
                        "Cascading Style Sheets",
                        "Creative Style Sheets"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("BFCE4F9D-2F8B-4A23-91C4-3F3B9E4F5F3D"),
                    Question = "Which HTML attribute is used to define inline styles?",
                    Answer = "style",
                    Category = EQuizCategory.Css,
                    Options = new()
                    {
                        "styles",
                        "style",
                        "class",
                        "font-style"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("76EFA40D-8A69-4D47-A3A8-9C5E9C3B6F91"),
                    Question = "How do you insert a comment in a CSS file?",
                    Answer = "/* this is a comment */",
                    Category = EQuizCategory.Css,
                    Options = new()
                    {
                        "// this is a comment //",
                        "/* this is a comment */",
                        "-- this is a comment --",
                        "<!-- this is a comment -->"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("3D4E1A20-5F14-4BE9-85F9-67D3A0BE5E64"),
                    Question = "Which property is used to change the background color of an element?",
                    Answer = "background-color",
                    Category = EQuizCategory.Css,
                    Options = new()
                    {
                        "color",
                        "bgcolor",
                        "background-color",
                        "background"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("6C2D9E71-8BF6-4FA2-A95F-DBF9B845D0F1"),
                    Question = "How do you apply a style to all <p> elements?",
                    Answer = "p { }",
                    Category = EQuizCategory.Css,
                    Options = new()
                    {
                        "p { }",
                        ".p { }",
                        "#p { }",
                        "all.p { }"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("C1A45E6F-BDB4-4E9F-80AE-9439F6DA9B2A"),
                    Question = "Which property is used to change the font of an element?",
                    Answer = "font-family",
                    Category = EQuizCategory.Css,
                    Options = new()
                    {
                        "font-style",
                        "text-style",
                        "font-family",
                        "typeface"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("F8D39B21-AF6C-49FA-8F99-5D6C3E9B2F54"),
                    Question = "How do you make each word in a text start with a capital letter?",
                    Answer = "text-transform: capitalize",
                    Category = EQuizCategory.Css,
                    Options = new()
                    {
                        "text-transform: capitalize",
                        "text-transform: uppercase",
                        "text-style: capital",
                        "font-transform: capitalize"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("D5A1C76B-30A7-4F99-B2D6-5F9C3E7B9D24"),
                    Question = "How do you select an element with the class name 'header'?",
                    Answer = ".header",
                    Category = EQuizCategory.Css,
                    Options = new()
                    {
                        ".header",
                        "#header",
                        "header",
                        "*header"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("7E4C9F2D-8B6A-4F87-89E3-5B1D6A4F9C3E"),
                    Question = "What is the default value of the 'position' property?",
                    Answer = "static",
                    Category = EQuizCategory.Css,
                    Options = new()
                    {
                        "relative",
                        "fixed",
                        "absolute",
                        "static"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("5D3E7A92-6C8B-4F1D-89A2-9E4C7F5B1D3F"),
                    Question = "What is the purpose of the z-index property in CSS?",
                    Answer = "To specify the stack order of an element",
                    Category = EQuizCategory.Css,
                    Options = new()
                    {
                        "To count the number of elements",
                        "To set the magnification level of an element",
                        "To specify the stack order of an element",
                        "To create a zoom effect"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("A1B2C3D4-E5F6-47A8-B9C0-D1E2F3A4B5C6"),
                    Question = "Which syntax is correct to output 'Hello World' in an alert box?",
                    Answer = "alert('Hello World');",
                    Category = EQuizCategory.JavaScript,
                    Options = new()
                    {
                        "alertBox('Hello World');",
                        "msg('Hello World');",
                        "alert('Hello World');",
                        "msgBox('Hello World');"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B2C3D4E5-F6A7-48B9-C0D1-E2F3A4B5C6D7"),
                    Question = "How do you call a function named 'myFunction'?",
                    Answer = "myFunction()",
                    Category = EQuizCategory.JavaScript,
                    Options = new()
                    {
                        "call function myFunction()",
                        "call myFunction()",
                        "myFunction()",
                        "execute myFunction()"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("C3D4E5F6-A7B8-49C0-D1E2-F3A4B5C6D7E8"),
                    Question = "How to write an IF statement in JavaScript?",
                    Answer = "if (i == 5)",
                    Category = EQuizCategory.JavaScript,
                    Options = new()
                    {
                        "if i = 5 then",
                        "if (i == 5)",
                        "if i == 5",
                        "if i = 5"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("82ACE605-FEC7-48DB-A9E3-CADDCB9B8AEE"),
                    Question = "How to write an IF statement for executing some code if 'i' is NOT equal to 5?",
                    Answer = "if (i != 5)",
                    Category = EQuizCategory.JavaScript,
                    Options = new()
                    {
                        "if (i <> 5)",
                        "if i =! 5 then",
                        "if (i != 5)",
                        "if i not = 5"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("82ACE605-FEC7-48DB-A9E3-CADDCB9B8AEF"),
                    Question = "How does a FOR loop start?",
                    Answer = "for (i = 0; i <= 5; i++)",
                    Category = EQuizCategory.JavaScript,
                    Options = new()
                    {
                        "for (i = 0; i <= 5)",
                        "for i = 1 to 5",
                        "for (i <= 5; i++)",
                        "for (i = 0; i <= 5; i++)"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("82ACE605-FEC7-48DB-A9E3-CADDCB9B8AF0"),
                    Question = "How can you add a single-line comment in JavaScript?",
                    Answer = "//This is a single-line comment",
                    Category = EQuizCategory.JavaScript,
                    Options = new()
                    {
                        "'This is a single-line comment",
                        "//This is a single-line comment",
                        "<!--This is a single-line comment-->",
                        "/* This is a single-line comment */"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("82ACE605-FEC7-48DB-A9E3-CADDCB9B8AF1"),
                    Question = "What is the correct way to write a JavaScript array?",
                    Answer = "var colors = ['red', 'green', 'blue']",
                    Category = EQuizCategory.JavaScript,
                    Options = new()
                    {
                        "var colors = (1:'red', 2:'green', 3:'blue')",
                        "var colors = ['red', 'green', 'blue']",
                        "var colors = 'red', 'green', 'blue'",
                        "var colors = 1 = ('red'), 2 = ('green'), 3 = ('blue')"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("82ACE605-FEC7-48DB-A9E3-CADDCB9B8AF2"),
                    Question = "How do you find the number with the highest value of x and y?",
                    Answer = "Math.max(x, y)",
                    Category = EQuizCategory.JavaScript,
                    Options = new()
                    {
                        "Math.ceil(x, y)",
                        "top(x, y)",
                        "Math.max(x, y)",
                        "Math.highest(x, y)"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("82ACE605-FEC7-48DB-A9E3-CADDCB9B8AF3"),
                    Question = "Which operator is used to assign a value to a variable?",
                    Answer = "=",
                    Category = EQuizCategory.JavaScript,
                    Options = new()
                    {
                        "-",
                        "*",
                        "=",
                        "x"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("82ACE605-FEC7-48DB-A9E3-CADDCB9B8AF4"),
                    Question = "What is the correct way to write a JavaScript object?",
                    Answer = "var person = {firstName: 'John', lastName: 'Doe'};",
                    Category = EQuizCategory.JavaScript,
                    Options = new()
                    {
                        "var person = {firstName: 'John', lastName: 'Doe'};",
                        "var person = {firstName = 'John', lastName = 'Doe'};",
                        "var person = (firstName: 'John', lastName: 'Doe');",
                        "var person = (firstName = 'John', lastName = 'Doe');"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B1A2C3D4-E5F6-7890-1234-56789ABCDE01"),
                    Question = "What does 'WCAG' stand for?",
                    Answer = "Web Content Accessibility Guidelines",
                    Category = EQuizCategory.Accessibility,
                    Options = new()
                    {
                        "Web Content Accessibility Guidelines",
                        "Web Compliance Accessibility Guide",
                        "Web Content Accessibility Goals",
                        "Website Compliance and Accessibility Guidelines"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B1A2C3D4-E5F6-7890-1234-56789ABCDE02"),
                    Question = "Which element is used to provide alternative text for images for screen reader users?",
                    Answer = "<img alt='description'>",
                    Category = EQuizCategory.Accessibility,
                    Options = new()
                    {
                        "<alt>",
                        "<figcaption>",
                        "<description>",
                        "<img alt='description'>"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B1A2C3D4-E5F6-7890-1234-56789ABCDE03"),
                    Question = "What does ARIA stand for in web development?",
                    Answer = "Accessible Rich Internet Applications",
                    Category = EQuizCategory.Accessibility,
                    Options = new()
                    {
                        "Accessible Rich Internet Applications",
                        "Advanced Responsive Internet Assistance",
                        "Accessible Responsive Internet Applications",
                        "Automated Responsive Internet Actions"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B1A2C3D4-E5F6-7890-1234-56789ABCDE04"),
                    Question = "Which of the following is not a principle of the WCAG?",
                    Answer = "Dependable",
                    Category = EQuizCategory.Accessibility,
                    Options = new()
                    {
                        "Perceivable",
                        "Dependable",
                        "Operable",
                        "Understandable"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B1A2C3D4-E5F6-7890-1234-56789ABCDE05"),
                    Question =
                        "Which of these color contrast ratios defines the minimum WCAG 2.1 Level AA requirement for normal text?",
                    Answer = "4.5:1",
                    Category = EQuizCategory.Accessibility,
                    Options = new()
                    {
                        "3:1",
                        "4.5:1",
                        "7:1",
                        "2:1"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B1A2C3D4-E5F6-7890-1234-56789ABCDE06"),
                    Question =
                        "Which of the following elements is inherently focusable, meaning it can receive focus without a 'tabindex' attribute?",
                    Answer = "<a href='...'>",
                    Category = EQuizCategory.Accessibility,
                    Options = new()
                    {
                        "<div>",
                        "<span>",
                        "<a href='...'>",
                        "<p>"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B1A2C3D4-E5F6-7890-1234-56789ABCDE07"),
                    Question = "What is the purpose of the 'lang' attribute in an HTML page?",
                    Answer = "To indicate the language of the page content",
                    Category = EQuizCategory.Accessibility,
                    Options = new()
                    {
                        "To specify the scripting language",
                        "To define the character set",
                        "To indicate the language of the page content",
                        "To declare a language pack"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B1A2C3D4-E5F6-7890-1234-56789ABCDE08"),
                    Question = "Which guideline ensures that content is accessible by keyboard as well as by mouse?",
                    Answer = "Keyboard Accessible",
                    Category = EQuizCategory.Accessibility,
                    Options = new()
                    {
                        "Keyboard Accessible",
                        "Mouse Independence",
                        "Device Independence",
                        "Operable Controls"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B1A2C3D4-E5F6-7890-1234-56789ABCDE09"),
                    Question = "What is the role of 'skip navigation' links in web accessibility?",
                    Answer = "To skip over primary navigation to the main content",
                    Category = EQuizCategory.Accessibility,
                    Options = new()
                    {
                        "To skip over primary navigation to the main content",
                        "To provide shortcuts to different sections of the website",
                        "To help users skip unwanted sections like advertisements",
                        "To bypass broken links in the navigation"
                    }
                },
                new Quiz()
                {
                    Id = new Guid("B1A2C3D4-E5F6-7890-1234-56789ABCDE10"),
                    Question = "Which of these tools can help in checking the accessibility of a website?",
                    Answer = "Google Lighthouse",
                    Category = EQuizCategory.Accessibility,
                    Options = new()
                    {
                        "W3C Validator",
                        "Google Lighthouse",
                        "CSS Validator",
                        "JavaScript Console"
                    }
                }
            );
        }
    }
}