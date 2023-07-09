using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using System.Globalization;
using System.Threading;

namespace CryptoServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            ////BEFORE
            //while (true)
            //{
            //    string cryptoCurrencyCode = "BTC";
            //    string countryCurrencyCode = "COP";
            //    string uri = string.Format("https://min-api.cryptocompare.com/data/pricemulti?fsyms=BTC,ETH&tsyms=EUR,USD", cryptoCurrencyCode, countryCurrencyCode);

            //    var client = new WebClient();
            //    client.UseDefaultCredentials = true;
            //    DateTime date = DateTime.Now;

            //    //Everything is returned inside of a "data" property, so let's select that token.
            //    string forParsing = client.DownloadString(uri);
            //    Console.Write(forParsing);

            //    string BTC = forParsing.Substring(forParsing.IndexOf("BTC"), forParsing.IndexOf("}"));
            //    //Console.WriteLine("BTC: " + BTC);
            //    string ETH = forParsing.Substring(forParsing.IndexOf("ETH"), forParsing.Substring(forParsing.IndexOf("ETH")).LastIndexOf("}"));
            //    //Console.WriteLine("ETH: " + ETH);

            //    CultureInfo culture = new CultureInfo("en-US");
            //    float btcEUR = float.Parse(BTC.Substring(BTC.IndexOf("\"EUR\":") + 6, BTC.IndexOf(",") - (BTC.IndexOf("\"EUR\":") + 6)), culture);
            //    float btcUSD = float.Parse(BTC.Substring(BTC.IndexOf("\"USD\":") + 6, BTC.IndexOf("}") - (BTC.IndexOf("\"USD\":") + 6)), culture);
            //    float ethEUR = float.Parse(ETH.Substring(ETH.IndexOf("\"EUR\":") + 6, ETH.IndexOf(",") - (ETH.IndexOf("\"EUR\":") + 6)), culture);
            //    float ethUSD = float.Parse(ETH.Substring(ETH.IndexOf("\"USD\":") + 6, ETH.IndexOf("}") - (ETH.IndexOf("\"USD\":") + 6)), culture);

            //    Console.Write("BTC to EUR: " + btcEUR);
            //    Console.Write(", BTC to USD: " + btcUSD);
            //    Console.Write(", ETH to EUR: " + ethEUR);
            //    Console.Write(", ETH to USD: " + ethUSD);
            //    Console.WriteLine(", Now is: " + date);

            //    //cryptoDataModel model = new cryptoDataModel();
            //    //model.timeNow = date;
            //    //model.BTCvalueEUR = btcEUR;
            //    //model.BTCvalueUSD = btcUSD;
            //    //model.ETHvalueEUR = ethEUR;
            //    //model.ETHvalueUSD = ethUSD;

            //    //dbCryptoProjectEntities context = new dbCryptoProjectEntities();

            //    //try
            //    //{
            //    //    context.cryptoDataModels.Add(model);
            //    //    context.SaveChanges();
            //    //}
            //    //catch (DbEntityValidationException e)
            //    //{
            //    //    foreach (var eve in e.EntityValidationErrors)
            //    //    {
            //    //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //    //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //    //        foreach (var ve in eve.ValidationErrors)
            //    //        {
            //    //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //    //                ve.PropertyName, ve.ErrorMessage);
            //    //        }
            //    //    }
            //    //    throw;
            //    //}


            //    Thread.Sleep(60*1000);  // svakih 60 sek
            //    //Thread.Sleep(1000); // svakih 1 sek
            //}





            while (true)
            {
                string cryptoCurrencyCode = "BTC";
                string countryCurrencyCode = "COP";
                string uri = string.Format("https://min-api.cryptocompare.com/data/pricemulti?fsyms=BTC,ETH,XRP,ADA,DOGE,LTC,SOL,TRX,DOT,MATIC,&tsyms=EUR,USD", cryptoCurrencyCode, countryCurrencyCode);

                var client = new WebClient();
                client.UseDefaultCredentials = true;
                DateTime date = DateTime.Now;

                //Everything is returned inside of a "data" property, so let's select that token.
                string forParsing = client.DownloadString(uri);
                Console.Write(forParsing);

                string BTC = forParsing.Substring(forParsing.IndexOf("BTC"), forParsing.IndexOf("ETH") - forParsing.IndexOf("BTC"));
                string ETH = forParsing.Substring(forParsing.IndexOf("ETH"), forParsing.IndexOf("XRP") - forParsing.IndexOf("ETH"));
                string XRP = forParsing.Substring(forParsing.IndexOf("XRP"), forParsing.IndexOf("ADA") - forParsing.IndexOf("XRP"));
                string ADA = forParsing.Substring(forParsing.IndexOf("ADA"), forParsing.IndexOf("DOGE") - forParsing.IndexOf("ADA"));
                string DOGE = forParsing.Substring(forParsing.IndexOf("DOGE"), forParsing.IndexOf("LTC") - forParsing.IndexOf("DOGE"));
                string LTC = forParsing.Substring(forParsing.IndexOf("LTC"), forParsing.IndexOf("SOL") - forParsing.IndexOf("LTC"));
                string SOL = forParsing.Substring(forParsing.IndexOf("SOL"), forParsing.IndexOf("TRX") - forParsing.IndexOf("SOL"));
                string TRX = forParsing.Substring(forParsing.IndexOf("TRX"), forParsing.IndexOf("DOT") - forParsing.IndexOf("TRX"));
                string DOT = forParsing.Substring(forParsing.IndexOf("DOT"), forParsing.IndexOf("MATIC") - forParsing.IndexOf("DOT"));
                string MATIC = forParsing.Substring(forParsing.IndexOf("MATIC"), forParsing.LastIndexOf("}") - forParsing.IndexOf("MATIC"));
                //Console.WriteLine("BTC: " + BTC);

                //Console.WriteLine("ETH: " + ETH);

                CultureInfo culture = new CultureInfo("en-US");
                float btcEUR = float.Parse(BTC.Substring(BTC.IndexOf("\"EUR\":") + 6, BTC.IndexOf(",") - (BTC.IndexOf("\"EUR\":") + 6)), culture);
                float btcUSD = float.Parse(BTC.Substring(BTC.IndexOf("\"USD\":") + 6, BTC.IndexOf("}") - (BTC.IndexOf("\"USD\":") + 6)), culture);

                float ethEUR = float.Parse(ETH.Substring(ETH.IndexOf("\"EUR\":") + 6, ETH.IndexOf(",") - (ETH.IndexOf("\"EUR\":") + 6)), culture);
                float ethUSD = float.Parse(ETH.Substring(ETH.IndexOf("\"USD\":") + 6, ETH.IndexOf("}") - (ETH.IndexOf("\"USD\":") + 6)), culture);

                float xrpEUR = float.Parse(XRP.Substring(XRP.IndexOf("\"EUR\":") + 6, XRP.IndexOf(",") - (XRP.IndexOf("\"EUR\":") + 6)), culture);
                float xrpUSD = float.Parse(XRP.Substring(XRP.IndexOf("\"USD\":") + 6, XRP.IndexOf("}") - (XRP.IndexOf("\"USD\":") + 6)), culture);

                float adaEUR = float.Parse(ADA.Substring(ADA.IndexOf("\"EUR\":") + 6, ADA.IndexOf(",") - (ADA.IndexOf("\"EUR\":") + 6)), culture);
                float adaUSD = float.Parse(ADA.Substring(ADA.IndexOf("\"USD\":") + 6, ADA.IndexOf("}") - (ADA.IndexOf("\"USD\":") + 6)), culture);

                float dogeEUR = float.Parse(DOGE.Substring(DOGE.IndexOf("\"EUR\":") + 6, DOGE.IndexOf(",") - (DOGE.IndexOf("\"EUR\":") + 6)), culture);
                float dogeUSD = float.Parse(DOGE.Substring(DOGE.IndexOf("\"USD\":") + 6, DOGE.IndexOf("}") - (DOGE.IndexOf("\"USD\":") + 6)), culture);

                float ltcEUR = float.Parse(LTC.Substring(LTC.IndexOf("\"EUR\":") + 6, LTC.IndexOf(",") - (LTC.IndexOf("\"EUR\":") + 6)), culture);
                float ltcUSD = float.Parse(LTC.Substring(LTC.IndexOf("\"USD\":") + 6, LTC.IndexOf("}") - (LTC.IndexOf("\"USD\":") + 6)), culture);

                float solEUR = float.Parse(SOL.Substring(SOL.IndexOf("\"EUR\":") + 6, SOL.IndexOf(",") - (SOL.IndexOf("\"EUR\":") + 6)), culture);
                float solUSD = float.Parse(SOL.Substring(SOL.IndexOf("\"USD\":") + 6, SOL.IndexOf("}") - (SOL.IndexOf("\"USD\":") + 6)), culture);

                float trxEUR = float.Parse(TRX.Substring(TRX.IndexOf("\"EUR\":") + 6, TRX.IndexOf(",") - (TRX.IndexOf("\"EUR\":") + 6)), culture);
                float trxUSD = float.Parse(TRX.Substring(TRX.IndexOf("\"USD\":") + 6, TRX.IndexOf("}") - (TRX.IndexOf("\"USD\":") + 6)), culture);

                float dotEUR = float.Parse(DOT.Substring(DOT.IndexOf("\"EUR\":") + 6, DOT.IndexOf(",") - (DOT.IndexOf("\"EUR\":") + 6)), culture);
                float dotUSD = float.Parse(DOT.Substring(DOT.IndexOf("\"USD\":") + 6, DOT.IndexOf("}") - (DOT.IndexOf("\"USD\":") + 6)), culture);

                float maticEUR = float.Parse(MATIC.Substring(MATIC.IndexOf("\"EUR\":") + 6, MATIC.IndexOf(",") - (MATIC.IndexOf("\"EUR\":") + 6)), culture);
                float maticUSD = float.Parse(MATIC.Substring(MATIC.IndexOf("\"USD\":") + 6, MATIC.IndexOf("}") - (MATIC.IndexOf("\"USD\":") + 6)), culture);

                Console.WriteLine();

                Console.Write("BTC to EUR: " + btcEUR);
                Console.WriteLine(", BTC to USD: " + btcUSD);

                Console.Write("ETH to EUR: " + ethEUR);
                Console.WriteLine(", ETH to USD: " + ethUSD);

                Console.Write("XRP to EUR: " + xrpEUR);
                Console.WriteLine(", XRP to USD: " + xrpUSD);

                Console.Write("ADA to EUR: " + adaEUR);
                Console.WriteLine(", ADA to USD: " + adaUSD);

                Console.Write("DOGE to EUR: " + dogeEUR);
                Console.WriteLine(", DOGE to USD: " + dogeUSD);

                Console.Write("LTC to EUR: " + ltcEUR);
                Console.WriteLine(", LTC to USD: " + ltcUSD);

                Console.Write("SOL to EUR: " + solEUR);
                Console.WriteLine(", SOL to USD: " + solUSD);

                Console.Write("TRX to EUR: " + trxEUR);
                Console.WriteLine(", TRX to USD: " + trxUSD);

                Console.Write("DOT to EUR: " + dotEUR);
                Console.WriteLine(", DOT to USD: " + dotUSD);

                Console.Write("MATIC to EUR: " + maticEUR);
                Console.WriteLine(", MATIC to USD: " + maticUSD);

                Console.WriteLine(", Now is: " + date);

                CryptoDataModel model = new cryptoDataModel();
                model.timeNow = date;
                model.BTCvalueEUR = btcEUR;
                model.BTCvalueUSD = btcUSD;
                model.ETHvalueEUR = ethEUR;
                model.ETHvalueUSD = ethUSD;

                dbCryptoProjectEntities context = new dbCryptoProjectEntities();

                try
                {
                    context.cryptoDataModels.Add(model);
                    context.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }




                try
                {

                    CryptoDataModel model = new CryptoDataModel();

                    model.BtcvalueEur = btcEUR;
                    model.BtcvalueUsd = btcUSD;

                    model.EthvalueEur = ethEUR;
                    model.EthvalueUsd = ethUSD;

                    model.XrpvalueEur = xrpEUR;
                    model.XrpvalueUsd = xrpUSD;

                    model.AdavalueEur = adaEUR;
                    model.AdavalueUsd = adaUSD;

                    model.DogevalueEur = dogeEUR;
                    model.DogevalueUsd = dogeUSD;

                    model.LtcvalueEur = ltcEUR;
                    model.LtcvalueUsd = ltcUSD;

                    model.SolvalueEur = solEUR;
                    model.SolvalueUsd = solUSD;

                    model.TrxvalueEur = trxEUR;
                    model.TrxvalueUsd = trxUSD;

                    model.DotvalueEur = dotEUR;
                    model.DotvalueUsd = dotUSD;

                    model.MaticvalueEur = maticEUR;
                    model.MaticvalueUsd = maticUSD;

                    model.TimeNow =

                    context.CryptoDataModels.Add(model);


                    context.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    //foreach (var eve in e.)
                    //{
                    //    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                    //        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    //    foreach (var ve in eve.ValidationErrors)
                    //    {
                    //        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                    //            ve.PropertyName, ve.ErrorMessage);
                    //    }
                    //}
                    throw;
                }


                Thread.Sleep(60 * 1000);  // svakih 60 sek
                //Thread.Sleep(1000); // svakih 1 sek
            }

        }
    }
}
