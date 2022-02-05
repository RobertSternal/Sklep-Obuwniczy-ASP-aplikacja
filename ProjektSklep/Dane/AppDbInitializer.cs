using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ProjektSklep.Models;
using System.Collections.Generic;
using System.Linq;
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
                            Opis = "Black/Red",
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.logaster.com%2Fpl%2Fblog%2Fadidas-logo%2F&psig=AOvVaw0FQJd-a7CNoc38lhl4a83F&ust=1643145310973000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCLiHrrany_UCFQAAAAAdAAAAABAJ"
                        },
                        new Producent()
                        {
                            NazwaProducenta = "Nike",
                            Opis = "White/Black/Red",
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FSwoosh&psig=AOvVaw3dnGmhQhcECuCbgJqG9ITV&ust=1643145391292000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCMC4gOCny_UCFQAAAAAdAAAAABAD"
                        },
                        new Producent()
                        {
                            NazwaProducenta = "Yeezy",
                            Opis = "Black",
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fblog.logomyway.com%2Fyeezy-logo%2F&psig=AOvVaw2idqMZgj6xdAhsw_rGZ2Et&ust=1643145444824000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCMCIy_any_UCFQAAAAAdAAAAABAD"
                        },
                        new Producent()
                        {
                            NazwaProducenta = "Y-3",
                            Opis = "White",
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Flogos-download.com%2F11496-y-3-logo-download.html&psig=AOvVaw0TDKmS0tsedAYLViQs09kD&ust=1643145782946000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCPiRtJipy_UCFQAAAAAdAAAAABAD"
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
                            Opis = "500",
                            Logo = "https://cdn-images.farfetch-contents.com/13/49/74/92/13497492_21554204_480.jpg",
                            Cena = 849,
                            kategoriaButa = KategoriaButa.Lifestyle
                        },
                        new But()
                        {
                            Nazwa = "Air Max 95",
                            Opis = "95",
                            Logo = "https://sneakerstudio.pl/pol_pm_Buty-meskie-sneakersy-Nike-Air-Max-95-Triple-Black-609048-092-14374_4.jpg",
                            Cena = 799,
                            kategoriaButa = KategoriaButa.Sportowe
                        },
                        new But()
                        {
                            Nazwa = "Yeezy 350 v2",
                            Opis = "350",
                            Logo = "https://cdn.vitkac.com/uploads/gallery_AdidasSoldout9/66bf85054bcf00206b9e5d5e93caa661.png",
                            Cena = 899,
                            kategoriaButa = KategoriaButa.Lifestyle
                        },
                        new But()
                        {
                            Nazwa = "Air Jordan 1",
                            Opis = "1",
                            Logo = "https://houseofheat.co/app/uploads/2021/01/air-jordan-1-high-og-university-blue-2021-555088-134-release-date.jpg",
                            Cena = 649,
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
        }
    }

