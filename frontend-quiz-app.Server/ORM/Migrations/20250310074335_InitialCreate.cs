using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace frontend_quiz_app.Server.ORM.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuizCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImgUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Question = table.Column<string>(type: "TEXT", nullable: false),
                    Options = table.Column<string>(type: "TEXT", nullable: false),
                    Answer = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "QuizCategories",
                columns: new[] { "Id", "ImgUrl", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("0c713aa8-346f-47f3-ac4c-f8177a83bc66"), "https://res.cloudinary.com/dejteftxn/image/upload/v1739240140/icon-js_ipyeg7.svg", "Javascript", 3 },
                    { new Guid("0e72459a-47bd-4514-a539-d22123a86118"), "https://res.cloudinary.com/dejteftxn/image/upload/v1739240140/icon-css_kaleeb.svg", "CSS", 2 },
                    { new Guid("21ee70da-fff3-4956-b2df-bcc46493360e"), "https://res.cloudinary.com/dejteftxn/image/upload/v1739240140/icon-accessibility_evm5t5.svg", "Accessibility", 4 },
                    { new Guid("738d6b49-f593-41c0-b343-5e3f3c4a68fa"), "https://res.cloudinary.com/dejteftxn/image/upload/v1739241035/icon-html_vfxdlq_zxjoxa.svg", "HTML", 1 }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Answer", "Category", "Options", "Question" },
                values: new object[,]
                {
                    { new Guid("0f7bd0d1-22dc-4bd5-a4ca-0bd4e9abac55"), "It is used to group related data in a form.", 1, "[\"It is used to group related data in a form.\",\"It sets the field to a fixed size.\",\"It automatically validates the fields within a form.\",\"It hides the fields in a form.\"]", "In HTML, what does the `fieldset` tag do?" },
                    { new Guid("14d0c2eb-b52f-48e0-b647-33c877d1d38c"), "<title>", 1, "[\"\\u003Chead\\u003E\",\"\\u003Ctitle\\u003E\",\"\\u003Cheader\\u003E\",\"\\u003Ctop\\u003E\"]", "Which HTML element is used to define the title of a document?" },
                    { new Guid("1945a467-92b7-4f57-a420-83f60015df5e"), "<a>", 1, "[\"\\u003Chyperlink\\u003E\",\"\\u003Clink\\u003E\",\"\\u003Ca\\u003E\",\"\\u003Chref\\u003E\"]", "Which HTML tag is used to create a hyperlink?" },
                    { new Guid("37354314-63a8-468b-9592-2bf4e0c605ef"), "It contains all the content such as text, images, and links.", 1, "[\"It defines the document\\u0027s head section.\",\"It contains all the content such as text, images, and links.\",\"It is used to define the main content of an HTML document.\",\"It specifies the body of the email content in HTML.\"]", "What is the purpose of the <body> tag in HTML?" },
                    { new Guid("3d4e1a20-5f14-4be9-85f9-67d3a0be5e64"), "background-color", 2, "[\"color\",\"bgcolor\",\"background-color\",\"background\"]", "Which property is used to change the background color of an element?" },
                    { new Guid("4592f1fa-dc8a-46e2-9aed-8c00d7714193"), "<img>", 1, "[\"\\u003Cimg\\u003E\",\"\\u003Cimage\\u003E\",\"\\u003Csrc\\u003E\",\"\\u003Cpic\\u003E\"]", "Which tag is used to display images in HTML?" },
                    { new Guid("485d3eb7-a0f1-4905-a97a-b998eadb711e"), "<ul>", 1, "[\"\\u003Cul\\u003E\",\"\\u003Col\\u003E\",\"\\u003Clist\\u003E\",\"\\u003Cli\\u003E\"]", "Which HTML tag is used to create an unordered list?" },
                    { new Guid("5d3e7a92-6c8b-4f1d-89a2-9e4c7f5b1d3f"), "To specify the stack order of an element", 2, "[\"To count the number of elements\",\"To set the magnification level of an element\",\"To specify the stack order of an element\",\"To create a zoom effect\"]", "What is the purpose of the z-index property in CSS?" },
                    { new Guid("5d4b8a72-6e90-4b5e-b02a-9e5b5a6d1c02"), "Cascading Style Sheets", 2, "[\"Colorful Style Sheets\",\"Computer Style Sheets\",\"Cascading Style Sheets\",\"Creative Style Sheets\"]", "What does CSS stand for?" },
                    { new Guid("6c2d9e71-8bf6-4fa2-a95f-dbf9b845d0f1"), "p { }", 2, "[\"p { }\",\".p { }\",\"#p { }\",\"all.p { }\"]", "How do you apply a style to all <p> elements?" },
                    { new Guid("76efa40d-8a69-4d47-a3a8-9c5e9c3b6f91"), "/* this is a comment */", 2, "[\"// this is a comment //\",\"/* this is a comment */\",\"-- this is a comment --\",\"\\u003C!-- this is a comment --\\u003E\"]", "How do you insert a comment in a CSS file?" },
                    { new Guid("7ac82061-fa2e-4c1c-9eda-fcc460185bff"), "src", 1, "[\"link\",\"src\",\"href\",\"url\"]", "What attribute is used to provide the path of an image in the <img> tag?" },
                    { new Guid("7e4c9f2d-8b6a-4f87-89e3-5b1d6a4f9c3e"), "static", 2, "[\"relative\",\"fixed\",\"absolute\",\"static\"]", "What is the default value of the 'position' property?" },
                    { new Guid("82ace605-fec7-48db-a9e3-caddcb9b8ae0"), "<html><head></head><body></body></html>", 1, "[\"\\u003Chtml\\u003E\\u003Chead\\u003E\\u003C/head\\u003E\\u003Cbody\\u003E\\u003C/body\\u003E\\u003C/html\\u003E\",\"\\u003Chead\\u003E\\u003Chtml\\u003E\\u003C/html\\u003E\\u003Cbody\\u003E\\u003C/body\\u003E\\u003C/head\\u003E\",\"\\u003Cbody\\u003E\\u003Chead\\u003E\\u003C/head\\u003E\\u003Chtml\\u003E\\u003C/html\\u003E\\u003C/body\\u003E\",\"\\u003Chtml\\u003E\\u003Cbody\\u003E\\u003C/body\\u003E\\u003Chead\\u003E\\u003C/head\\u003E\\u003C/html\\u003E\"]", "Which of the following is the correct structure for an HTML document?" },
                    { new Guid("82ace605-fec7-48db-a9e3-caddcb9b8aee"), "if (i != 5)", 3, "[\"if (i \\u003C\\u003E 5)\",\"if i =! 5 then\",\"if (i != 5)\",\"if i not = 5\"]", "How to write an IF statement for executing some code if 'i' is NOT equal to 5?" },
                    { new Guid("82ace605-fec7-48db-a9e3-caddcb9b8aef"), "for (i = 0; i <= 5; i++)", 3, "[\"for (i = 0; i \\u003C= 5)\",\"for i = 1 to 5\",\"for (i \\u003C= 5; i\\u002B\\u002B)\",\"for (i = 0; i \\u003C= 5; i\\u002B\\u002B)\"]", "How does a FOR loop start?" },
                    { new Guid("82ace605-fec7-48db-a9e3-caddcb9b8af0"), "//This is a single-line comment", 3, "[\"\\u0027This is a single-line comment\",\"//This is a single-line comment\",\"\\u003C!--This is a single-line comment--\\u003E\",\"/* This is a single-line comment */\"]", "How can you add a single-line comment in JavaScript?" },
                    { new Guid("82ace605-fec7-48db-a9e3-caddcb9b8af1"), "var colors = ['red', 'green', 'blue']", 3, "[\"var colors = (1:\\u0027red\\u0027, 2:\\u0027green\\u0027, 3:\\u0027blue\\u0027)\",\"var colors = [\\u0027red\\u0027, \\u0027green\\u0027, \\u0027blue\\u0027]\",\"var colors = \\u0027red\\u0027, \\u0027green\\u0027, \\u0027blue\\u0027\",\"var colors = 1 = (\\u0027red\\u0027), 2 = (\\u0027green\\u0027), 3 = (\\u0027blue\\u0027)\"]", "What is the correct way to write a JavaScript array?" },
                    { new Guid("82ace605-fec7-48db-a9e3-caddcb9b8af2"), "Math.max(x, y)", 3, "[\"Math.ceil(x, y)\",\"top(x, y)\",\"Math.max(x, y)\",\"Math.highest(x, y)\"]", "How do you find the number with the highest value of x and y?" },
                    { new Guid("82ace605-fec7-48db-a9e3-caddcb9b8af3"), "=", 3, "[\"-\",\"*\",\"=\",\"x\"]", "Which operator is used to assign a value to a variable?" },
                    { new Guid("82ace605-fec7-48db-a9e3-caddcb9b8af4"), "var person = {firstName: 'John', lastName: 'Doe'};", 3, "[\"var person = {firstName: \\u0027John\\u0027, lastName: \\u0027Doe\\u0027};\",\"var person = {firstName = \\u0027John\\u0027, lastName = \\u0027Doe\\u0027};\",\"var person = (firstName: \\u0027John\\u0027, lastName: \\u0027Doe\\u0027);\",\"var person = (firstName = \\u0027John\\u0027, lastName = \\u0027Doe\\u0027);\"]", "What is the correct way to write a JavaScript object?" },
                    { new Guid("88a8bc10-5e04-4949-b93c-2f2f30a6dc5d"), "Hyper Text Markup Language", 1, "[\"Hyper Trainer Marking Language\",\"Hyper Text Marketing Language\",\"Hyper Text Markup Language\",\"Hyper Text Markup Leveler\"]", "What does HTML stand for?" },
                    { new Guid("a1b2c3d4-e5f6-47a8-b9c0-d1e2f3a4b5c6"), "alert('Hello World');", 3, "[\"alertBox(\\u0027Hello World\\u0027);\",\"msg(\\u0027Hello World\\u0027);\",\"alert(\\u0027Hello World\\u0027);\",\"msgBox(\\u0027Hello World\\u0027);\"]", "Which syntax is correct to output 'Hello World' in an alert box?" },
                    { new Guid("a5639636-9622-4d4a-a930-96df1acefbef"), "It inserts a line break.", 1, "[\"It breaks the text into two sections.\",\"It creates a bold text.\",\"It inserts a line break.\",\"It adds a new row in a table.\"]", "What does the <br> tag do?" },
                    { new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde01"), "Web Content Accessibility Guidelines", 4, "[\"Web Content Accessibility Guidelines\",\"Web Compliance Accessibility Guide\",\"Web Content Accessibility Goals\",\"Website Compliance and Accessibility Guidelines\"]", "What does 'WCAG' stand for?" },
                    { new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde02"), "<img alt='description'>", 4, "[\"\\u003Calt\\u003E\",\"\\u003Cfigcaption\\u003E\",\"\\u003Cdescription\\u003E\",\"\\u003Cimg alt=\\u0027description\\u0027\\u003E\"]", "Which element is used to provide alternative text for images for screen reader users?" },
                    { new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde03"), "Accessible Rich Internet Applications", 4, "[\"Accessible Rich Internet Applications\",\"Advanced Responsive Internet Assistance\",\"Accessible Responsive Internet Applications\",\"Automated Responsive Internet Actions\"]", "What does ARIA stand for in web development?" },
                    { new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde04"), "Dependable", 4, "[\"Perceivable\",\"Dependable\",\"Operable\",\"Understandable\"]", "Which of the following is not a principle of the WCAG?" },
                    { new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde05"), "4.5:1", 4, "[\"3:1\",\"4.5:1\",\"7:1\",\"2:1\"]", "Which of these color contrast ratios defines the minimum WCAG 2.1 Level AA requirement for normal text?" },
                    { new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde06"), "<a href='...'>", 4, "[\"\\u003Cdiv\\u003E\",\"\\u003Cspan\\u003E\",\"\\u003Ca href=\\u0027...\\u0027\\u003E\",\"\\u003Cp\\u003E\"]", "Which of the following elements is inherently focusable, meaning it can receive focus without a 'tabindex' attribute?" },
                    { new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde07"), "To indicate the language of the page content", 4, "[\"To specify the scripting language\",\"To define the character set\",\"To indicate the language of the page content\",\"To declare a language pack\"]", "What is the purpose of the 'lang' attribute in an HTML page?" },
                    { new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde08"), "Keyboard Accessible", 4, "[\"Keyboard Accessible\",\"Mouse Independence\",\"Device Independence\",\"Operable Controls\"]", "Which guideline ensures that content is accessible by keyboard as well as by mouse?" },
                    { new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde09"), "To skip over primary navigation to the main content", 4, "[\"To skip over primary navigation to the main content\",\"To provide shortcuts to different sections of the website\",\"To help users skip unwanted sections like advertisements\",\"To bypass broken links in the navigation\"]", "What is the role of 'skip navigation' links in web accessibility?" },
                    { new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde10"), "Google Lighthouse", 4, "[\"W3C Validator\",\"Google Lighthouse\",\"CSS Validator\",\"JavaScript Console\"]", "Which of these tools can help in checking the accessibility of a website?" },
                    { new Guid("b2c3d4e5-f6a7-48b9-c0d1-e2f3a4b5c6d7"), "myFunction()", 3, "[\"call function myFunction()\",\"call myFunction()\",\"myFunction()\",\"execute myFunction()\"]", "How do you call a function named 'myFunction'?" },
                    { new Guid("bfce4f9d-2f8b-4a23-91c4-3f3b9e4f5f3d"), "style", 2, "[\"styles\",\"style\",\"class\",\"font-style\"]", "Which HTML attribute is used to define inline styles?" },
                    { new Guid("c1a45e6f-bdb4-4e9f-80ae-9439f6da9b2a"), "font-family", 2, "[\"font-style\",\"text-style\",\"font-family\",\"typeface\"]", "Which property is used to change the font of an element?" },
                    { new Guid("c3d4e5f6-a7b8-49c0-d1e2-f3a4b5c6d7e8"), "if (i == 5)", 3, "[\"if i = 5 then\",\"if (i == 5)\",\"if i == 5\",\"if i = 5\"]", "How to write an IF statement in JavaScript?" },
                    { new Guid("d5a1c76b-30a7-4f99-b2d6-5f9c3e7b9d24"), ".header", 2, "[\".header\",\"#header\",\"header\",\"*header\"]", "How do you select an element with the class name 'header'?" },
                    { new Guid("e8d42b3e-d3b5-47a0-8981-44bf8c811250"), "src", 1, "[\"link\",\"src\",\"href\",\"url\"]", "What attribute is used to provide the path of an image in the <img> tag?" },
                    { new Guid("f8d39b21-af6c-49fa-8f99-5d6c3e9b2f54"), "text-transform: capitalize", 2, "[\"text-transform: capitalize\",\"text-transform: uppercase\",\"text-style: capital\",\"font-transform: capitalize\"]", "How do you make each word in a text start with a capital letter?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuizCategories");

            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
