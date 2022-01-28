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
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Ftenisufki.eu%2Fartykul%2Fna-30-listopada-zapowiedziany-jest-restock-adidas-yeezy-500-utility-black&psig=AOvVaw0D-o9sZp2vOc5kl0IALgPb&ust=1643147010715000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCMiYsuGty_UCFQAAAAAdAAAAABAD",
                            Cena = 849,
                            kategoriaButa = KategoriaButa.Lifestyle
                        },
                        new But()
                        {
                            Nazwa = "Air Max 95",
                            Opis = "95",
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fsneakerstudio.pl%2Fproduct-pol-14374-Buty-meskie-sneakersy-Nike-Air-Max-95-Triple-Black-609048-092.html&psig=AOvVaw1b4QC6Qa_CdQW_x5wbgqmC&ust=1643147145286000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCOjUj6Guy_UCFQAAAAAdAAAAABAQ",
                            Cena = 799,
                            kategoriaButa = KategoriaButa.Sportowe
                        },
                        new But()
                        {
                            Nazwa = "Yeezy 350 v2",
                            Opis = "350",
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fallegro.pl%2Foferta%2Fadidas-yeezy-boost-350-v2-zebra-43-1-3-11380438707&psig=AOvVaw3zh3PVTG4gE8gB0hXFZICr&ust=1643147309001000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCJjV6vCuy_UCFQAAAAAdAAAAABAD",
                            Cena = 899,
                            kategoriaButa = KategoriaButa.Lifestyle
                        },
                        new But()
                        {
                            Nazwa = "Air Jordan 1",
                            Opis = "1",
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nike.com%2Fpl%2Flaunch%2Ft%2Fwomens-air-jordan-1-satin-red1&psig=AOvVaw3R7SCDbcsh2hvbfjKod4LR&ust=1643147415790000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCPDRiKWvy_UCFQAAAAAdAAAAABAD",
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

