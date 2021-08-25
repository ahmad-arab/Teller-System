using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TellerDesktop
{
    public static class DataProvider
    {
        public static ObservableCollection<Branch> GetBrnaches()
        {
            return new ObservableCollection<Branch> { new Branch { Id=1, Name="سوريا",MainCurrency=new Currency{Name="ليرة سورية" }, FinancialAccount = FinancialAccount.GetRandomAccount(1) },
                                      new Branch { Id=2, Name="ألمانيا",MainCurrency=new Currency{Name="يورو" }, FinancialAccount = FinancialAccount.GetRandomAccount(10) },
                                      new Branch { Id=3, Name="دانمارك",MainCurrency=new Currency{Name="كرون" }, FinancialAccount = FinancialAccount.GetRandomAccount(100) },
                                      new Branch { Id=4, Name="يونان",MainCurrency=new Currency{Name="يورو" } , FinancialAccount = FinancialAccount.GetRandomAccount(3)},
                                      new Branch { Id=5, Name="تركيا",MainCurrency=new Currency{Name="دولار" }, FinancialAccount = FinancialAccount.GetRandomAccount(7) },
                                      new Branch { Id=6, Name="لبنان",MainCurrency=new Currency{Name="دولار" }, FinancialAccount = FinancialAccount.GetRandomAccount(90) },
                                      new Branch { Id=7, Name="سويد",MainCurrency=new Currency{Name="يورو" }, FinancialAccount = FinancialAccount.GetRandomAccount(86)} };
        }
        public static ObservableCollection<Rep> GetReps()
        {
            return new ObservableCollection<Rep> { new Rep {Id =1, Branch = new Branch{ Id=1, Name="سوريا" }, Name="عبد الواحد أحمدي", OfficeName="مكتب الفجر", City="الحسكة", Country="سوريا", Email="...",
                                                        Phone1="...",Phone2="...", RestOfTheAddress="...", WorkingHours="من فلان إلى فلان" , FinancialAccount = FinancialAccount.GetRandomAccount(44)},
                                   new Rep {Id =2, Branch= new Branch{ Id=2, Name="ألمانيا" }, Name="شيار قاسمو", OfficeName="مكتب غوتن تاغ", City="برلين", Country="ألمانيا", Email="...",
                                                        Phone1="...",Phone2="...", RestOfTheAddress="...", WorkingHours="من فلان إلى علان" , FinancialAccount = FinancialAccount.GetRandomAccount(45)},
                                   new Rep {Id =3, Branch= new Branch{ Id=1, Name="سوريا" }, Name="حميد مخللاتي", OfficeName="للمخللاتي للحوالات", City="دمشق", Country="سوريا", Email="...",
                                                        Phone1="...",Phone2="...", RestOfTheAddress="...", WorkingHours="من فلان إلى فلان" , FinancialAccount = FinancialAccount.GetRandomAccount(174)},
                                   new Rep {Id =4, Branch= new Branch{ Id=2, Name="ألمانيا" }, Name="شمدين حمي", OfficeName="النوفرة", City="لايبزغ", Country="ألمانيا", Email="...",
                                                        Phone1="...",Phone2="...", RestOfTheAddress="...", WorkingHours="من فلان إلى فلان" , FinancialAccount = FinancialAccount.GetRandomAccount(2345)},
                                   new Rep {Id =5, Branch= new Branch{ Id=5, Name="تركيا" }, Name="سميح أوغلو", OfficeName="يالدم", City="أنقرة", Country="تركيا", Email="...",
                                                        Phone1="...",Phone2="...", RestOfTheAddress="...", WorkingHours="من فلان إلى فلان" , FinancialAccount = FinancialAccount.GetRandomAccount(34)},
                                   new Rep {Id =6, Branch= new Branch{ Id=5, Name="تركيا" }, Name="بهزاد حسي", OfficeName="كومشاندن", City="قونيا", Country="تركيا", Email="...",
                                                        Phone1="...",Phone2="...", RestOfTheAddress="...", WorkingHours="من فلان إلى فلان" , FinancialAccount = FinancialAccount.GetRandomAccount(765)},
                                   new Rep {Id =7, Branch= new Branch{ Id=6, Name="لبنان" }, Name="ميشيل عفلق", OfficeName="الناظم للحوالات", City="بيروت", Country="لبنان", Email="...",
                                                        Phone1="...",Phone2="...", RestOfTheAddress="...", WorkingHours="من فلان إلى فلان" , FinancialAccount = FinancialAccount.GetRandomAccount(24)},};
        }
        public static ObservableCollection<Currency> GetCurrencies()
        {
            return new ObservableCollection<Currency> { new Currency { Name = "ليرة سورية" },
                                        new Currency { Name = "دولار" },
                                        new Currency { Name = "يورو" },
                                        new Currency { Name = "كرون" },
                                        new Currency { Name = "بيزو" },
                                        new Currency { Name = "روبل" },
                                        new Currency { Name = "دولار كندي" },
                                        new Currency { Name = "ليرة لبناني" },};
        }
        public static ObservableCollection<Partner> GetPartners()
        {
            return new ObservableCollection<Partner> { new Partner(){ Email="ahmad@ahmad.com", FinancialAccount = FinancialAccount.GetRandomAccount(37), Id=1, Name = "عبد الباقي", Phone1="0912345667", Phone2 = "05983567"},
                                                       new Partner(){ Email="shiar@shiar.com", FinancialAccount = FinancialAccount.GetRandomAccount(38), Id=1, Name = "أبو حمي", Phone1="0329345667", Phone2 = "00974567"},
                                                       new Partner(){ Email="sami@sami.com", FinancialAccount = FinancialAccount.GetRandomAccount(48), Id=1, Name = "سفو", Phone1="0912324867", Phone2 = "052340867"},

            };
        }
        public static ObservableCollection<Vault> GetVaults()
        {
            return new ObservableCollection<Vault> { new Vault() { Id = 0, Name = "صندوق القامشلي للحوالات", FinancialAccount = FinancialAccount.GetRandomAccount(92)},
                                                     new Vault() { Id = 0, Name = "صندوق القامشلي للصرافة", FinancialAccount = FinancialAccount.GetRandomAccount(92)},
                                                     new Vault() { Id = 0, Name = "صندوق دمشق للحوالات والصرافة", FinancialAccount = FinancialAccount.GetRandomAccount(92)},
            };
        }
        public static ObservableCollection<Customer> GetCustomers()
        {
            return new ObservableCollection<Customer> { new Customer { Id = 0, Name = "أحمد كاعود", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(26) },
                                                        new Customer { Id = 1, Name = "عبد الله معود", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(42) },
                                                        new Customer { Id = 2, Name = "مظفر النواب", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(545) },
                                                        new Customer { Id = 3, Name = "كازيمان عيسى", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(234) },
                                                        new Customer { Id = 4, Name = "روبرت بنس", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(234) },
                                                        new Customer { Id = 5, Name = "عبد المنعم الشاهين", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(45) },
                                                        new Customer { Id = 6, Name = "بهزادو", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(798) },
                                                        new Customer { Id = 7, Name = "دكتورة شيرين", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(123) },
                                                        new Customer { Id = 8, Name = "عبد القادر بونجغ", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(342) },
                                                        new Customer { Id = 9, Name = "فخر الدين بيزي", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(235) },
                                                        new Customer { Id = 10, Name = "سعود العلي", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(2252) },
                                                        new Customer { Id = 11, Name = "مجحم", Address = "القامشلي- حارا غربي", Email = "", Phone1 = "098900709", Phone2 = "", FinancialAccount = FinancialAccount.GetRandomAccount(234) },
            };
        }
        public static ObservableCollection<Employee> GetEmployees()
        {
            return new ObservableCollection<Employee> { new Employee { Id = 0, Name = "بونكين", Address = "القامشلي", Currency = new Currency(), WorkTitle = "محاسب" },
                                                        new Employee { Id = 1, Name = "شيار", Address = "القامشلي", Currency = new Currency(), WorkTitle = "رئيس المحاسبين الأعظم" },
                                                        new Employee { Id = 2, Name = "شيرو", Address = "القامشلي", Currency = new Currency(), WorkTitle = "محاسب" },};
        }
    }
}
