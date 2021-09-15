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

        #region Currencies
        public static ObservableCollection<Currency> Currencies = new ObservableCollection<Currency>();
        public static ObservableCollection<Currency> GetCurrencies()
        {
            return new ObservableCollection<Currency> { Currency.GetRandomCurrencies()[0],
                                        Currency.GetRandomCurrencies()[1],
                                        Currency.GetRandomCurrencies()[2],
                                        Currency.GetRandomCurrencies()[3],
                                        Currency.GetRandomCurrencies()[4]};
        }
        public static void UpdateCurrencies()
        {
            Currencies = new ObservableCollection<Currency> { new Currency { Name = "ليرة سورية" },
                                        new Currency { Name = "دولار" },
                                        new Currency { Name = "يورو" },
                                        new Currency { Name = "كرون" },
                                        new Currency { Name = "بيزو" },
                                        new Currency { Name = "روبل" },
                                        new Currency { Name = "دولار كندي" },
                                        new Currency { Name = "ليرة لبناني" },};
        }
        #endregion

        #region StartupVoucher
        public static Voucher TheStartupVoucher = new Voucher();
        public static Voucher GetStartupVoucher()
        {
            return TheStartupVoucher;
        }
        #endregion

        #region JournalVouchers
        public static ObservableCollection<Voucher> JournalVouchers = new ObservableCollection<Voucher>();
        public static ObservableCollection<Voucher> GetJournalVouchers()
        {
            ObservableCollection<FinancialAction> actions = new ObservableCollection<FinancialAction>
            {
                new FinancialAction(1,1,FinancialAccount.GetRandomAccount(19),VoucherType.JournalVoucher,100,0,Currency.GetRandomCurrencies()[1],Currency.GetRandomCurrencies()[1].SellPrice,"لا شيء",100*Currency.GetRandomCurrencies()[1].SellPrice,new DateTime(2021,6,5)),
                new FinancialAction(2,1,FinancialAccount.GetRandomAccount(30),VoucherType.JournalVoucher,0,400000,Currency.GetRandomCurrencies()[0],Currency.GetRandomCurrencies()[0].SellPrice,"لا شيء",(-1)*100*Currency.GetRandomCurrencies()[0].SellPrice,new DateTime(2021,6,5)),
                new FinancialAction(1,2,FinancialAccount.GetRandomAccount(480),VoucherType.JournalVoucher,200,0,Currency.GetRandomCurrencies()[2],Currency.GetRandomCurrencies()[2].SellPrice,"لا شيء",200*Currency.GetRandomCurrencies()[2].SellPrice,new DateTime(2021,6,10)),
                new FinancialAction(2,2,FinancialAccount.GetRandomAccount(92),VoucherType.JournalVoucher,5000,0,Currency.GetRandomCurrencies()[3],Currency.GetRandomCurrencies()[3].SellPrice,"لا شيء",5000*Currency.GetRandomCurrencies()[3].SellPrice,new DateTime(2021,6,10)),
                new FinancialAction(3,2,FinancialAccount.GetRandomAccount(934),VoucherType.JournalVoucher,0,670,Currency.GetRandomCurrencies()[4],Currency.GetRandomCurrencies()[4].SellPrice,"لا شيء",(-1)*670*Currency.GetRandomCurrencies()[4].SellPrice,new DateTime(2021,6,10)),
                new FinancialAction(1,3,FinancialAccount.GetRandomAccount(983),VoucherType.JournalVoucher,0,50,Currency.GetRandomCurrencies()[1],Currency.GetRandomCurrencies()[1].SellPrice,"لا شيء",(-1)*50*Currency.GetRandomCurrencies()[1].SellPrice,new DateTime(2021,6,15)),
            };
            return new ObservableCollection<Voucher>
            {
                new Voucher(1,new DateTime(2021,6,5),Currency.GetRandomCurrencies()[0],Currency.GetRandomCurrencies()[0].SellPrice,null,0,"لماذا وضع الله الميزان", "عبد المنعم",VoucherType.JournalVoucher,new ObservableCollection<FinancialAction>(){actions[0],actions[1] }),
                new Voucher(2,new DateTime(2021,6,10),Currency.GetRandomCurrencies()[0],Currency.GetRandomCurrencies()[0].SellPrice,null,0,"السند الثاني بفضل الله", "عبد العظيم",VoucherType.JournalVoucher,new ObservableCollection<FinancialAction>(){actions[2],actions[3],actions[4] }),
                new Voucher(3,new DateTime(2021,6,15),Currency.GetRandomCurrencies()[0],Currency.GetRandomCurrencies()[0].SellPrice,null,0,"كيف أنساك!!!", "عبد المنعم",VoucherType.JournalVoucher,new ObservableCollection<FinancialAction>(){actions[5]})
            };
        }
        #endregion

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
