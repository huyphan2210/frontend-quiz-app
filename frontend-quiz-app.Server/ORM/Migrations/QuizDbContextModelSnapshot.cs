﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using frontend_quiz_app.Server.ORM;

#nullable disable

namespace frontend_quiz_app.Server.ORM.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    partial class QuizDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("frontend_quiz_app.Server.Models.Quiz", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.PrimitiveCollection<string>("Options")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Quizzes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("88a8bc10-5e04-4949-b93c-2f2f30a6dc5d"),
                            Answer = "Hyper Text Markup Language",
                            Category = 1,
                            Options = "[\"Hyper Trainer Marking Language\",\"Hyper Text Marketing Language\",\"Hyper Text Markup Language\",\"Hyper Text Markup Leveler\"]",
                            Question = "What does HTML stand for?"
                        },
                        new
                        {
                            Id = new Guid("82ace605-fec7-48db-a9e3-caddcb9b8ae0"),
                            Answer = "<html><head></head><body></body></html>",
                            Category = 1,
                            Options = "[\"\\u003Chtml\\u003E\\u003Chead\\u003E\\u003C/head\\u003E\\u003Cbody\\u003E\\u003C/body\\u003E\\u003C/html\\u003E\",\"\\u003Chead\\u003E\\u003Chtml\\u003E\\u003C/html\\u003E\\u003Cbody\\u003E\\u003C/body\\u003E\\u003C/head\\u003E\",\"\\u003Cbody\\u003E\\u003Chead\\u003E\\u003C/head\\u003E\\u003Chtml\\u003E\\u003C/html\\u003E\\u003C/body\\u003E\",\"\\u003Chtml\\u003E\\u003Cbody\\u003E\\u003C/body\\u003E\\u003Chead\\u003E\\u003C/head\\u003E\\u003C/html\\u003E\"]",
                            Question = "Which of the following is the correct structure for an HTML document?"
                        },
                        new
                        {
                            Id = new Guid("14d0c2eb-b52f-48e0-b647-33c877d1d38c"),
                            Answer = "<title>",
                            Category = 1,
                            Options = "[\"\\u003Chead\\u003E\",\"\\u003Ctitle\\u003E\",\"\\u003Cheader\\u003E\",\"\\u003Ctop\\u003E\"]",
                            Question = "Which HTML element is used to define the title of a document?"
                        },
                        new
                        {
                            Id = new Guid("37354314-63a8-468b-9592-2bf4e0c605ef"),
                            Answer = "It contains all the content such as text, images, and links.",
                            Category = 1,
                            Options = "[\"It defines the document\\u0027s head section.\",\"It contains all the content such as text, images, and links.\",\"It is used to define the main content of an HTML document.\",\"It specifies the body of the email content in HTML.\"]",
                            Question = "What is the purpose of the <body> tag in HTML?"
                        },
                        new
                        {
                            Id = new Guid("1945a467-92b7-4f57-a420-83f60015df5e"),
                            Answer = "<a>",
                            Category = 1,
                            Options = "[\"\\u003Chyperlink\\u003E\",\"\\u003Clink\\u003E\",\"\\u003Ca\\u003E\",\"\\u003Chref\\u003E\"]",
                            Question = "Which HTML tag is used to create a hyperlink?"
                        },
                        new
                        {
                            Id = new Guid("4592f1fa-dc8a-46e2-9aed-8c00d7714193"),
                            Answer = "<img>",
                            Category = 1,
                            Options = "[\"\\u003Cimg\\u003E\",\"\\u003Cimage\\u003E\",\"\\u003Csrc\\u003E\",\"\\u003Cpic\\u003E\"]",
                            Question = "Which tag is used to display images in HTML?"
                        },
                        new
                        {
                            Id = new Guid("e8d42b3e-d3b5-47a0-8981-44bf8c811250"),
                            Answer = "src",
                            Category = 1,
                            Options = "[\"link\",\"src\",\"href\",\"url\"]",
                            Question = "What attribute is used to provide the path of an image in the <img> tag?"
                        },
                        new
                        {
                            Id = new Guid("7ac82061-fa2e-4c1c-9eda-fcc460185bff"),
                            Answer = "src",
                            Category = 1,
                            Options = "[\"link\",\"src\",\"href\",\"url\"]",
                            Question = "What attribute is used to provide the path of an image in the <img> tag?"
                        },
                        new
                        {
                            Id = new Guid("485d3eb7-a0f1-4905-a97a-b998eadb711e"),
                            Answer = "<ul>",
                            Category = 1,
                            Options = "[\"\\u003Cul\\u003E\",\"\\u003Col\\u003E\",\"\\u003Clist\\u003E\",\"\\u003Cli\\u003E\"]",
                            Question = "Which HTML tag is used to create an unordered list?"
                        },
                        new
                        {
                            Id = new Guid("a5639636-9622-4d4a-a930-96df1acefbef"),
                            Answer = "It inserts a line break.",
                            Category = 1,
                            Options = "[\"It breaks the text into two sections.\",\"It creates a bold text.\",\"It inserts a line break.\",\"It adds a new row in a table.\"]",
                            Question = "What does the <br> tag do?"
                        },
                        new
                        {
                            Id = new Guid("0f7bd0d1-22dc-4bd5-a4ca-0bd4e9abac55"),
                            Answer = "It is used to group related data in a form.",
                            Category = 1,
                            Options = "[\"It is used to group related data in a form.\",\"It sets the field to a fixed size.\",\"It automatically validates the fields within a form.\",\"It hides the fields in a form.\"]",
                            Question = "In HTML, what does the `fieldset` tag do?"
                        },
                        new
                        {
                            Id = new Guid("5d4b8a72-6e90-4b5e-b02a-9e5b5a6d1c02"),
                            Answer = "Cascading Style Sheets",
                            Category = 2,
                            Options = "[\"Colorful Style Sheets\",\"Computer Style Sheets\",\"Cascading Style Sheets\",\"Creative Style Sheets\"]",
                            Question = "What does CSS stand for?"
                        },
                        new
                        {
                            Id = new Guid("bfce4f9d-2f8b-4a23-91c4-3f3b9e4f5f3d"),
                            Answer = "style",
                            Category = 2,
                            Options = "[\"styles\",\"style\",\"class\",\"font-style\"]",
                            Question = "Which HTML attribute is used to define inline styles?"
                        },
                        new
                        {
                            Id = new Guid("76efa40d-8a69-4d47-a3a8-9c5e9c3b6f91"),
                            Answer = "/* this is a comment */",
                            Category = 2,
                            Options = "[\"// this is a comment //\",\"/* this is a comment */\",\"-- this is a comment --\",\"\\u003C!-- this is a comment --\\u003E\"]",
                            Question = "How do you insert a comment in a CSS file?"
                        },
                        new
                        {
                            Id = new Guid("3d4e1a20-5f14-4be9-85f9-67d3a0be5e64"),
                            Answer = "background-color",
                            Category = 2,
                            Options = "[\"color\",\"bgcolor\",\"background-color\",\"background\"]",
                            Question = "Which property is used to change the background color of an element?"
                        },
                        new
                        {
                            Id = new Guid("6c2d9e71-8bf6-4fa2-a95f-dbf9b845d0f1"),
                            Answer = "p { }",
                            Category = 2,
                            Options = "[\"p { }\",\".p { }\",\"#p { }\",\"all.p { }\"]",
                            Question = "How do you apply a style to all <p> elements?"
                        },
                        new
                        {
                            Id = new Guid("c1a45e6f-bdb4-4e9f-80ae-9439f6da9b2a"),
                            Answer = "font-family",
                            Category = 2,
                            Options = "[\"font-style\",\"text-style\",\"font-family\",\"typeface\"]",
                            Question = "Which property is used to change the font of an element?"
                        },
                        new
                        {
                            Id = new Guid("f8d39b21-af6c-49fa-8f99-5d6c3e9b2f54"),
                            Answer = "text-transform: capitalize",
                            Category = 2,
                            Options = "[\"text-transform: capitalize\",\"text-transform: uppercase\",\"text-style: capital\",\"font-transform: capitalize\"]",
                            Question = "How do you make each word in a text start with a capital letter?"
                        },
                        new
                        {
                            Id = new Guid("d5a1c76b-30a7-4f99-b2d6-5f9c3e7b9d24"),
                            Answer = ".header",
                            Category = 2,
                            Options = "[\".header\",\"#header\",\"header\",\"*header\"]",
                            Question = "How do you select an element with the class name 'header'?"
                        },
                        new
                        {
                            Id = new Guid("7e4c9f2d-8b6a-4f87-89e3-5b1d6a4f9c3e"),
                            Answer = "static",
                            Category = 2,
                            Options = "[\"relative\",\"fixed\",\"absolute\",\"static\"]",
                            Question = "What is the default value of the 'position' property?"
                        },
                        new
                        {
                            Id = new Guid("5d3e7a92-6c8b-4f1d-89a2-9e4c7f5b1d3f"),
                            Answer = "To specify the stack order of an element",
                            Category = 2,
                            Options = "[\"To count the number of elements\",\"To set the magnification level of an element\",\"To specify the stack order of an element\",\"To create a zoom effect\"]",
                            Question = "What is the purpose of the z-index property in CSS?"
                        },
                        new
                        {
                            Id = new Guid("a1b2c3d4-e5f6-47a8-b9c0-d1e2f3a4b5c6"),
                            Answer = "alert('Hello World');",
                            Category = 3,
                            Options = "[\"alertBox(\\u0027Hello World\\u0027);\",\"msg(\\u0027Hello World\\u0027);\",\"alert(\\u0027Hello World\\u0027);\",\"msgBox(\\u0027Hello World\\u0027);\"]",
                            Question = "Which syntax is correct to output 'Hello World' in an alert box?"
                        },
                        new
                        {
                            Id = new Guid("b2c3d4e5-f6a7-48b9-c0d1-e2f3a4b5c6d7"),
                            Answer = "myFunction()",
                            Category = 3,
                            Options = "[\"call function myFunction()\",\"call myFunction()\",\"myFunction()\",\"execute myFunction()\"]",
                            Question = "How do you call a function named 'myFunction'?"
                        },
                        new
                        {
                            Id = new Guid("c3d4e5f6-a7b8-49c0-d1e2-f3a4b5c6d7e8"),
                            Answer = "if (i == 5)",
                            Category = 3,
                            Options = "[\"if i = 5 then\",\"if (i == 5)\",\"if i == 5\",\"if i = 5\"]",
                            Question = "How to write an IF statement in JavaScript?"
                        },
                        new
                        {
                            Id = new Guid("82ace605-fec7-48db-a9e3-caddcb9b8aee"),
                            Answer = "if (i != 5)",
                            Category = 3,
                            Options = "[\"if (i \\u003C\\u003E 5)\",\"if i =! 5 then\",\"if (i != 5)\",\"if i not = 5\"]",
                            Question = "How to write an IF statement for executing some code if 'i' is NOT equal to 5?"
                        },
                        new
                        {
                            Id = new Guid("82ace605-fec7-48db-a9e3-caddcb9b8aef"),
                            Answer = "for (i = 0; i <= 5; i++)",
                            Category = 3,
                            Options = "[\"for (i = 0; i \\u003C= 5)\",\"for i = 1 to 5\",\"for (i \\u003C= 5; i\\u002B\\u002B)\",\"for (i = 0; i \\u003C= 5; i\\u002B\\u002B)\"]",
                            Question = "How does a FOR loop start?"
                        },
                        new
                        {
                            Id = new Guid("82ace605-fec7-48db-a9e3-caddcb9b8af0"),
                            Answer = "//This is a single-line comment",
                            Category = 3,
                            Options = "[\"\\u0027This is a single-line comment\",\"//This is a single-line comment\",\"\\u003C!--This is a single-line comment--\\u003E\",\"/* This is a single-line comment */\"]",
                            Question = "How can you add a single-line comment in JavaScript?"
                        },
                        new
                        {
                            Id = new Guid("82ace605-fec7-48db-a9e3-caddcb9b8af1"),
                            Answer = "var colors = ['red', 'green', 'blue']",
                            Category = 3,
                            Options = "[\"var colors = (1:\\u0027red\\u0027, 2:\\u0027green\\u0027, 3:\\u0027blue\\u0027)\",\"var colors = [\\u0027red\\u0027, \\u0027green\\u0027, \\u0027blue\\u0027]\",\"var colors = \\u0027red\\u0027, \\u0027green\\u0027, \\u0027blue\\u0027\",\"var colors = 1 = (\\u0027red\\u0027), 2 = (\\u0027green\\u0027), 3 = (\\u0027blue\\u0027)\"]",
                            Question = "What is the correct way to write a JavaScript array?"
                        },
                        new
                        {
                            Id = new Guid("82ace605-fec7-48db-a9e3-caddcb9b8af2"),
                            Answer = "Math.max(x, y)",
                            Category = 3,
                            Options = "[\"Math.ceil(x, y)\",\"top(x, y)\",\"Math.max(x, y)\",\"Math.highest(x, y)\"]",
                            Question = "How do you find the number with the highest value of x and y?"
                        },
                        new
                        {
                            Id = new Guid("82ace605-fec7-48db-a9e3-caddcb9b8af3"),
                            Answer = "=",
                            Category = 3,
                            Options = "[\"-\",\"*\",\"=\",\"x\"]",
                            Question = "Which operator is used to assign a value to a variable?"
                        },
                        new
                        {
                            Id = new Guid("82ace605-fec7-48db-a9e3-caddcb9b8af4"),
                            Answer = "var person = {firstName: 'John', lastName: 'Doe'};",
                            Category = 3,
                            Options = "[\"var person = {firstName: \\u0027John\\u0027, lastName: \\u0027Doe\\u0027};\",\"var person = {firstName = \\u0027John\\u0027, lastName = \\u0027Doe\\u0027};\",\"var person = (firstName: \\u0027John\\u0027, lastName: \\u0027Doe\\u0027);\",\"var person = (firstName = \\u0027John\\u0027, lastName = \\u0027Doe\\u0027);\"]",
                            Question = "What is the correct way to write a JavaScript object?"
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde01"),
                            Answer = "Web Content Accessibility Guidelines",
                            Category = 4,
                            Options = "[\"Web Content Accessibility Guidelines\",\"Web Compliance Accessibility Guide\",\"Web Content Accessibility Goals\",\"Website Compliance and Accessibility Guidelines\"]",
                            Question = "What does 'WCAG' stand for?"
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde02"),
                            Answer = "<img alt='description'>",
                            Category = 4,
                            Options = "[\"\\u003Calt\\u003E\",\"\\u003Cfigcaption\\u003E\",\"\\u003Cdescription\\u003E\",\"\\u003Cimg alt=\\u0027description\\u0027\\u003E\"]",
                            Question = "Which element is used to provide alternative text for images for screen reader users?"
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde03"),
                            Answer = "Accessible Rich Internet Applications",
                            Category = 4,
                            Options = "[\"Accessible Rich Internet Applications\",\"Advanced Responsive Internet Assistance\",\"Accessible Responsive Internet Applications\",\"Automated Responsive Internet Actions\"]",
                            Question = "What does ARIA stand for in web development?"
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde04"),
                            Answer = "Dependable",
                            Category = 4,
                            Options = "[\"Perceivable\",\"Dependable\",\"Operable\",\"Understandable\"]",
                            Question = "Which of the following is not a principle of the WCAG?"
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde05"),
                            Answer = "4.5:1",
                            Category = 4,
                            Options = "[\"3:1\",\"4.5:1\",\"7:1\",\"2:1\"]",
                            Question = "Which of these color contrast ratios defines the minimum WCAG 2.1 Level AA requirement for normal text?"
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde06"),
                            Answer = "<a href='...'>",
                            Category = 4,
                            Options = "[\"\\u003Cdiv\\u003E\",\"\\u003Cspan\\u003E\",\"\\u003Ca href=\\u0027...\\u0027\\u003E\",\"\\u003Cp\\u003E\"]",
                            Question = "Which of the following elements is inherently focusable, meaning it can receive focus without a 'tabindex' attribute?"
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde07"),
                            Answer = "To indicate the language of the page content",
                            Category = 4,
                            Options = "[\"To specify the scripting language\",\"To define the character set\",\"To indicate the language of the page content\",\"To declare a language pack\"]",
                            Question = "What is the purpose of the 'lang' attribute in an HTML page?"
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde08"),
                            Answer = "Keyboard Accessible",
                            Category = 4,
                            Options = "[\"Keyboard Accessible\",\"Mouse Independence\",\"Device Independence\",\"Operable Controls\"]",
                            Question = "Which guideline ensures that content is accessible by keyboard as well as by mouse?"
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde09"),
                            Answer = "To skip over primary navigation to the main content",
                            Category = 4,
                            Options = "[\"To skip over primary navigation to the main content\",\"To provide shortcuts to different sections of the website\",\"To help users skip unwanted sections like advertisements\",\"To bypass broken links in the navigation\"]",
                            Question = "What is the role of 'skip navigation' links in web accessibility?"
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-7890-1234-56789abcde10"),
                            Answer = "Google Lighthouse",
                            Category = 4,
                            Options = "[\"W3C Validator\",\"Google Lighthouse\",\"CSS Validator\",\"JavaScript Console\"]",
                            Question = "Which of these tools can help in checking the accessibility of a website?"
                        });
                });

            modelBuilder.Entity("frontend_quiz_app.Server.Models.QuizCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("QuizCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("738d6b49-f593-41c0-b343-5e3f3c4a68fa"),
                            ImgUrl = "https://res.cloudinary.com/dejteftxn/image/upload/v1739241035/icon-html_vfxdlq_zxjoxa.svg",
                            Name = "HTML",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("0e72459a-47bd-4514-a539-d22123a86118"),
                            ImgUrl = "https://res.cloudinary.com/dejteftxn/image/upload/v1739240140/icon-css_kaleeb.svg",
                            Name = "CSS",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("0c713aa8-346f-47f3-ac4c-f8177a83bc66"),
                            ImgUrl = "https://res.cloudinary.com/dejteftxn/image/upload/v1739240140/icon-js_ipyeg7.svg",
                            Name = "Javascript",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("21ee70da-fff3-4956-b2df-bcc46493360e"),
                            ImgUrl = "https://res.cloudinary.com/dejteftxn/image/upload/v1739240140/icon-accessibility_evm5t5.svg",
                            Name = "Accessibility",
                            Type = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
