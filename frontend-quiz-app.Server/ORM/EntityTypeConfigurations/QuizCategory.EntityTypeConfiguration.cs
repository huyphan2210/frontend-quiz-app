using frontend_quiz_app.Server.DTOs.Enums;
using frontend_quiz_app.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace frontend_quiz_app.Server.ORM.EntityTypeConfigurations
{
    public class QuizCategoryEntityTypeConfiguration : IEntityTypeConfiguration<QuizCategory>
    {
        public void Configure(EntityTypeBuilder<QuizCategory> builder)
        {
            builder.HasData(
                new()
                {
                    Id = new Guid("738D6B49-F593-41C0-B343-5E3F3C4A68FA"),
                    ImgUrl =
                        "https://res.cloudinary.com/dejteftxn/image/upload/v1739241035/icon-html_vfxdlq_zxjoxa.svg",
                    Name = "HTML",
                    Type = EQuizCategory.Html,
                },
                new()
                {
                    Id = new Guid("0E72459A-47BD-4514-A539-D22123A86118"),
                    ImgUrl = "https://res.cloudinary.com/dejteftxn/image/upload/v1739240140/icon-css_kaleeb.svg",
                    Name = "CSS",
                    Type = EQuizCategory.Css,
                },
                new()
                {
                    Id = new Guid("0C713AA8-346F-47F3-AC4C-F8177A83BC66"),
                    ImgUrl = "https://res.cloudinary.com/dejteftxn/image/upload/v1739240140/icon-js_ipyeg7.svg",
                    Name = "Javascript",
                    Type = EQuizCategory.JavaScript,
                },
                new()
                {
                    Id = new Guid("21EE70DA-FFF3-4956-B2DF-BCC46493360E"),
                    ImgUrl =
                        "https://res.cloudinary.com/dejteftxn/image/upload/v1739240140/icon-accessibility_evm5t5.svg",
                    Name = "Accessibility",
                    Type = EQuizCategory.Accessibility,
                });
        }
    }
}