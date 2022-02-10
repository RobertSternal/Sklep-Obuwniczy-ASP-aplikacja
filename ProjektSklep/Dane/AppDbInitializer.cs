using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ProjektSklep.Dane.Static;
using ProjektSklep.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjektSklep.Models.But;

namespace ProjektSklep.Dane
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Kolorystyki
                //if(!context.Kolorystyki.Any())
                //{
                    //context.Kolorystyki.AddRange(new List<Kolorystyka>()
                    ICollection<Kolorystyka> Kolorystyki = new List<Kolorystyka>()
                    {
                        new Kolorystyka()
                        {
                            Nazwa = "Bred",
                            Opis = "Black/Red"
                        },
                        new Kolorystyka()
                        {
                            Nazwa = "Zebra",
                            Opis = "White/Black/Red"
                        },
                        new Kolorystyka()
                        {
                            Nazwa = "Black",
                            Opis = "Black"
                        },
                        new Kolorystyka()
                        {
                            Nazwa = "White",
                            Opis = "White"
                        }
                    };
                    //});
                    context.SaveChanges();
                //}
                //Producenci
                //if (!context.Producenci.Any())
                //{
                    //context.Producenci.AddRange(new List<Producent>()
                    ICollection<Producent> Producenci = new List<Producent>()
                    {
                        new Producent()
                        {
                            NazwaProducenta = "Adidas",
                            Opis = "Adidas Originals",
                            Logo = "https://w7.pngwing.com/pngs/488/478/png-transparent-adidas-originals-t-shirt-logo-brand-adidas-angle-text-retail.png"
                        },
                        new Producent()
                        {
                            NazwaProducenta = "Nike",
                            Opis = "Nike Sportswear",
                            Logo = "https://c.static-nike.com/a/images/w_1920,c_limit/mdbgldn6yg1gg88jomci/image.jpg"
                        },
                        new Producent()
                        {
                            NazwaProducenta = "Yeezy",
                            Opis = " Adidas YEEZY",
                            Logo = "https://wallpaperaccess.com/full/633432.jpg"
                        },
                        new Producent()
                        {
                            NazwaProducenta = "Y-3",
                            Opis = "Adidas Y-3",
                            Logo = "https://mdc.rinascente.it/media/aw_sbb/brand/Y3-ss21.png"
                        }
                    };
                    //});
                   //context.SaveChanges();


                //}
                //Buty
                //if (!context.Buty.Any())
                //{
                    //context.Buty.AddRange(new List<But>()
                    //{
                    ICollection<But> Buty = new List<But>()
                        {
                        new But()
                        {
                            Nazwa = "Yeezy 500",
                            Opis = "Yeezy 500 Salt",
                            Logo = "https://tenisufki.eu/storage/default/ooFfl6EpqgONuTw8etnPyCAIKusI1jAwCYwS3Di2.jpeg",
                            Cena = 849,
                            kategoriaButa = KategoriaButa.Lifestyle
                        },
                        new But()
                        {
                            Nazwa = "Air Max 95",
                            Opis = "Air max 95 black",
                            Logo = "https://sneakerstudio.pl/pol_pm_Buty-meskie-sneakersy-Nike-Air-Max-95-Triple-Black-609048-092-14374_4.jpg",
                            Cena = 799,
                            kategoriaButa = KategoriaButa.Sportowe
                        },
                        new But()
                        {
                            Nazwa = "Yeezy 350 v2",
                            Opis = "Yeezy 350 v2 Zebra",
                            Logo = "https://cdn.vitkac.com/uploads/gallery_AdidasSoldout9/66bf85054bcf00206b9e5d5e93caa661.png",
                            Cena = 899,
                            kategoriaButa = KategoriaButa.Lifestyle
                        },
                        new But()
                        {
                            Nazwa = "Air Jordan 1",
                            Opis = "Air Jordan 1 High UNC",
                            Logo = "https://houseofheat.co/app/uploads/2021/01/air-jordan-1-high-og-university-blue-2021-555088-134-release-date.jpg",
                            Cena = 679,
                            kategoriaButa = KategoriaButa.Lifestyle
                        },
                        new But()
                        {
                            Nazwa = "Yeezy 350 v2",
                            Opis = "Yeezy 350 v2 Bred",
                            Logo = "https://happybyhype.eu/userdata/public/gfx/1507.png",
                            Cena = 899,
                            kategoriaButa = KategoriaButa.Lifestyle
                        },
                        new But()
                        {
                            Nazwa = "Air Jordan 1",
                            Opis = "Air Jordan 1 High Bred",
                            Logo = "https://tenisufki.eu/storage/default/old/media/kcfinder/images/Air-Jordan-1-Bred-Toe-555088-610-Release-Date.jpg",
                            Cena = 679,
                            kategoriaButa = KategoriaButa.Lifestyle
                        }

                        };
                //}
                    //});

                    foreach (Kolorystyka kolorystyka in Kolorystyki)
                    {

                        context.Kolorystyki.Add(kolorystyka);
                    }

                    foreach (Producent producent in Producenci)
                    {

                        context.Producenci.Add(producent);
                    }

                    

                    foreach (But but in Buty)
                    {
                        if(but.Nazwa == "Yeezy 500")
                        {
                        but.Producent=Producenci.Where(x => x.NazwaProducenta.Equals("Adidas")).First();
                        }
                        if (but.Nazwa == "Air Max 95")
                        {
                        but.Producent = Producenci.Where(x => x.NazwaProducenta.Equals("Nike")).First();
                        }
                        if (but.Nazwa == "Yeezy 350 v2")
                        {
                        but.Producent = Producenci.Where(x => x.NazwaProducenta.Equals("Yeezy")).First();
                        }
                        if (but.Nazwa == "Air Jordan 1")
                        {
                        but.Producent = Producenci.Where(x => x.NazwaProducenta.Equals("Nike")).First();
                        }

                    foreach (Kolorystyka kolorystyka in Kolorystyki)
                        {
                        but.Kolorystyka.Add(kolorystyka);
                        }
                        
                        context.Buty.Add(but);

                    }
                    
                    context.SaveChanges(); 
                   
               }
                //Buty & Kolorystyki
                
            }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@shop.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Yeezy123!");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@shop.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Yeezy123!");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }

    }

    }

