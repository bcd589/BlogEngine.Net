namespace BlogEngine.Data.Migrations
{
    using BlogEngine.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogEngine.Data.BlogEngineDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogEngine.Data.BlogEngineDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //var roles = new List<Role>()
            //{
            //    new Role(){ Id = 1, RoleName= "admin" ,DateTime = System.DateTime.Now, RoleDesctription = "" },
            //    new Role(){ Id = 2, RoleName= "user" ,DateTime = System.DateTime.Now, RoleDesctription = "" },
            //};

            //foreach(var role in roles)
            //{
            //    context.Roles.AddOrUpdate(r => r.Id, role);
            //}

            //var logins = new List<Login>()
            //{
            //    new Login(){ Id = 1, Username = "admin", Password = "admin", RoleId = 1, IsVarified = true },
            //    new Login(){ Id = 2, Username = "user", Password = "user", RoleId = 2, IsVarified = true },
            //};

            //foreach (var login in logins)
            //{
            //    context.Logins.AddOrUpdate(l => l.Id, login);
            //}



            //var users = new List<User>()
            //{
            //    new User(){ Id = 1, Fullname = "Admin", Email = "Admin", Address = "", Url = "admin", DateTime = System.DateTime.Now, LoginId = 1, DateOfBirth = System.DateTime.Now, Mobile = ""},
            //    new User(){ Id = 2, Fullname = "User", Email = "User", Address = "", Url = "User", DateTime = System.DateTime.Now, LoginId = 2, DateOfBirth = System.DateTime.Now, Mobile = ""},
            //};

            //foreach(var user in users)
            //{
            //    context.Users.AddOrUpdate(u => u.Id, user);
            //}


//            var blogCatagories = new List<BlogCatagory>()
//            {
//                 new BlogCatagory(){ Id = 1, Title = "Technology", Url = "economic", DateTime = System.DateTime.Now, Description = "" , },

//                 new BlogCatagory(){ Id = 2, Title = "Music", Url = "music", DateTime = System.DateTime.Now, Description = "" , },

//                 new BlogCatagory(){ Id = 3, Title = "Fasion", Url = "fasion", DateTime = System.DateTime.Now, Description = "" , },

//                 new BlogCatagory(){ Id = 4, Title = "Car", Url = "car", DateTime = System.DateTime.Now, Description = "" , },

//                 new BlogCatagory(){ Id = 5, Title = "Real Estate", Url = "real-estate", DateTime = System.DateTime.Now, Description = "" , },

//                 new BlogCatagory(){ Id = 6, Title = "Food", Url = "food", DateTime = System.DateTime.Now, Description = "" , },

//                 new BlogCatagory(){ Id = 7, Title = "Travel", Url = "travel", DateTime = System.DateTime.Now, Description = "" , },

//                 new BlogCatagory(){ Id = 8, Title = "Photography", Url = "photography", DateTime = System.DateTime.Now, Description = "" , },

//            };
//            foreach (var cat in blogCatagories)
//            {
//                context.BlogCatagories.AddOrUpdate(c => c.Id, cat);
//            }



//            var blogTypes = new List<BlogType>()
//            {
//                new BlogType(){ Id = 1, Name = "Personal Blogs", Url = "personalblogs" , DateTime = System.DateTime.Now, Description = ""},
//                new BlogType(){ Id = 2, Name = "Business Blogs", Url = "businessblogs" , DateTime = System.DateTime.Now, Description = ""},
//                new BlogType(){ Id = 3, Name = "Professional Blogs", Url = "professionalblogs" , DateTime = System.DateTime.Now, Description = ""},
//                new BlogType(){ Id = 4, Name = "Niche Blogs", Url = "icheblogs" , DateTime = System.DateTime.Now, Description = ""},
//                new BlogType(){ Id = 5, Name = "Reverse Blogs", Url = "reverseblogs" , DateTime = System.DateTime.Now, Description = ""},
//                new BlogType(){ Id = 6, Name = "Affiliate Blogs", Url = "affiliateblogs" , DateTime = System.DateTime.Now, Description = ""},
//                new BlogType(){ Id = 7, Name = "Media Blogs", Url = "mediablogs" , DateTime = System.DateTime.Now, Description = ""},
//                new BlogType(){ Id = 8, Name = "Freelance Blogs", Url = "freelanceblogs" , DateTime = System.DateTime.Now, Description = ""},
                
//            };

//            foreach(var blogType in blogTypes)
//            {
//                context.BlogTypes.AddOrUpdate(b => b.Id, blogType);
//            }

//            var blogs = new List<Blog>()
//            {
//                new Blog(){ Id = 1 , Title = "Hatching Twitter: Why I learned more from Ev than Jack", Content = @"I started using Twitter shortly after the service hit it big at South by Southwest in 2007. My colleague (at the time) sMoRTy71 came back from Austin and told me that I seriously needed to get an account. I powered through the initial confusion stage (see The four stages of a typical Twitter user that I wrote in 2009) and realized that there was something illusively powerful about this thing.

//Over the next several years I wrote a lot about Twitter, from Is Twitter the most important development on the Web in 2008? to A quick Twitter guide and glossary for business users (in 2009) to my 2011 directory of tech experts to follow on Twitter.

//So, when Nick Bilton's book Hatching Twitter arrived on November 5, I immediately got a hold of it and read the whole story within a week during a trip to San Francisco. I hung on as the book raced through Twitter's early development and I happily correlated the events in the book with the details I remembered and wrote about during that period.

//I also found myself smiling as the book described very familiar places in San Francisco, since Twitter spawned a few blocks away from the CBS Interactive headquarters in the city's South of Market (SOMA) district.
//", Url = @"" , UserId = 1, BlogCatagoryId = 1, BlogTypeId = 1 , DateTime = System.DateTime.Now, Description = ""  , IsPublished = true, },
//                new Blog(){ Id = 2 , Title = @"Why history may judge Steve Ballmer more favorably than Wall Street or the tech industry", Content = @"I started using Twitter shortly after the service hit it big at South by Southwest in 2007. My colleague (at the time) sMoRTy71 came back from Austin and told me that I seriously needed to get an account. I powered through the initial confusion stage (see The four stages of a typical Twitter user that I wrote in 2009) and realized that there was something illusively powerful about this thing.

//Over the next several years I wrote a lot about Twitter, from Is Twitter the most important development on the Web in 2008? to A quick Twitter guide and glossary for business users (in 2009) to my 2011 directory of tech experts to follow on Twitter.

//So, when Nick Bilton's book Hatching Twitter arrived on November 5, I immediately got a hold of it and read the whole story within a week during a trip to San Francisco. I hung on as the book raced through Twitter's early development and I happily correlated the events in the book with the details I remembered and wrote about during that period.

//I also found myself smiling as the book described very familiar places in San Francisco, since Twitter spawned a few blocks away from the CBS Interactive headquarters in the city's South of Market (SOMA) district.

//Few CEOs have been more maligned over the past decade than Microsoft's Steve Ballmer. It's a thankless job to follow an industry legend and in his 14 years as Microsoft CEO, Ballmer never managed to step out of the shadow of Bill Gates.

//Here are four quick takeaways on the Ballmer era at Microsoft:
//1. The industry didn't embrace his vision

//Wall Street and the tech industry didn't embrace Ballmer primarily because his product vision never inspired enough confidence that Microsoft would be a winner in the future.
//2. Microsoft stumbled in the mobile revolution
//", Url = "" , UserId = 1, BlogCatagoryId = 1, BlogTypeId = 1 , DateTime = System.DateTime.Now, Description = ""  , IsPublished = true, },
                
//            };






//            foreach(var blog in blogs)
//            {
//                context.Blogs.AddOrUpdate(b => b.Id, blog);
//            }
        }


    }
}
