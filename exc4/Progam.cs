using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using exc4;



internal class program
{
    public List<HoGiaDinh>? hoGiaDinhs;
    public static void Main(string[] args)
    {
        KhuPho kp = new KhuPho();

        HoGiaDinh h1 = new HoGiaDinh()
        {
            new List<Nguoi> {
                        new Nguoi("DAT HDNA",22,"Software Intern", 111),
                        new Nguoi("HUYNH NGOC THINH", 22, "Software Intern",222)
                    },
        };
        kp.khuPhos.Add(
            new List<HoGiaDinh>()
            {
                new HoGiaDinh(
                    
                    "HUE",
                    2
                ),
            }
        });
                 new List<HoGiaDinh> {
                 }
                ),
                new HoGiaDinh(
                    new List<Nguoi> {
                        new Nguoi("DAT HDNA",22,"Software Intern", 111),
                        new Nguoi("HUYNH NGOC THINH", 22, "Software Intern",222)
                    },
                    "HUE",
                    2
                ),
                new HoGiaDinh(
                    new List<Nguoi>{
                        new Nguoi(" YEN HQTI", 25,"Software Intern",333),
                        new Nguoi("TRIEU HDNA", 24,"Software Intern",444)
                    },
                    "QUANG NAM",
                    2
                )
            }
            };
        int record = khuPho.HoGiaDinhs.Count();
        while (true)
        {

            Console.WriteLine("# Enter 1: To show infomations of families  #");
            Console.WriteLine("# Enter 2: To exit                          #");

            int choose = Int32.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the number of families you want to see: ");
                        int n = Int32.Parse(Console.ReadLine());
                        if (n > record)
                        {
                            Console.WriteLine("Only " + record + "/" + n + " families was saved!");
                            for (int i = 0; i < record; i++)
                            {
                                Console.WriteLine("Family " + (i + 1) + " has " + khuPho.HoGiaDinhs[i].SoThanhVien + " Persons");
                                foreach (var item in khuPho.HoGiaDinhs[i].Nguois)
                                {
                                    Console.Write("TEN: " + item.Ten + "TUOI: " + item.Tuoi + " CONG VIEC" + item.CongViec + " CCCD: " + item.CCCD);
                                    Console.WriteLine(" DIA CHIA: " + khuPho.HoGiaDinhs[i].DiaChi);
                                }
                            }
                        }
                        if (n < record)
                        {
                            Console.WriteLine(n + "/" + record + " families!");
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("GIA DINH " + (i + 1) + " CO " + khuPho.HoGiaDinhs[i].SoThanhVien + " NGUOI");
                                foreach (var item in khuPho.HoGiaDinhs[i].Nguois)
                                {
                                    Console.Write("Name: " + item.ten + "Age: " + item.tuoi + " Job" + item.CongViec + " Id: " + item.CCCD);
                                    Console.WriteLine(" Address: " + khuPho.HoGiaDinhs[i].SoThanhVien);
                                }
                            }

                            Console.WriteLine("# Enter M: To show more infomations  #");
                            Console.WriteLine("# Enter E: To exit                   #");

                            string? choose_step = Console.ReadLine();
                            switch (choose_step)
                            {
                                case "M":
                                    {
                                        for (int i = 0; i < record; i++)
                                        {
                                            Console.WriteLine("GIA DINH " + (i + 1) + " CO " + khuPho.HoGiaDinhs[i].SoThanhVien + " NGUOI");
                                            foreach (var item in khuPho.HoGiaDinhs[i].Nguois)
                                            {
                                                Console.Write("TEN: " + item.Ten + "TUOI: " + item.Tuoi + " CONGVIEC" + item.CongViec + " CCCD: " + item.CCCD);
                                                Console.WriteLine(" DIA CHI: " + khuPho.HoGiaDinhs[i].DiaChi);
                                            }
                                        }
                                        break;
                                    }
                                case "E":
                                    {
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Exit");
                                    break;
                            }
                        }
                        else

                            Console.WriteLine(record + "ho gia dinh");
                        for (int i = 0; i < record; i++)
                        {
                            Console.WriteLine("Family " + (i + 1) + " has " + town.families[i].NumofPerson + " Persons");
                            foreach (var item in town.families[i].Persons)
                            {
                                Console.Write("Name: " + item.Name + "Age: " + item.Age + " Job" + item.Job + " Id: " + item.Id);
                                Console.WriteLine(" Address: " + town.families[i].Address);
                            }
                        }
                    }
                    break;
                case 2:
                    {
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }
            }
        }
    }
}


            
        



    


