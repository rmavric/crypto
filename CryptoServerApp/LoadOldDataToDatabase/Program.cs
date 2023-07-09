
using LoadOldDataToDatabase.Models;
using System.Globalization;
using System.Net;

namespace LoadOldDataToDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string cryptoCurrencyCode = "BTC";
            string countryCurrencyCode = "COP";
            //string uri = string.Format("https://min-api.cryptocompare.com/data/v2/histoday?fsym=BTC&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}", cryptoCurrencyCode, countryCurrencyCode);
            string uriBTCUSD = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=BTC&tsym=USD&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriBTCEUR = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=BTC&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriETHUSD = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=ETH&tsym=USD&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriETHEUR = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=ETH&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriXRPUSD = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=XRP&tsym=USD&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriXRPEUR = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=XRP&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriADAUSD = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=ADA&tsym=USD&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriADAEUR = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=ADA&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriDOGEUSD = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=DOGE&tsym=USD&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriDOGEEUR = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=DOGE&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriLTCUSD = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=LTC&tsym=USD&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriLTCEUR = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=LTC&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriSOLUSD = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=SOL&tsym=USD&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriSOLEUR = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=SOL&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriTRXUSD = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=TRX&tsym=USD&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriTRXEUR = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=TRX&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriDOTUSD = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=DOT&tsym=USD&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriDOTEUR = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=DOT&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriMATICUSD = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=MATIC&tsym=USD&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";
            string uriMATICEUR = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=MATIC&tsym=EUR&limit=2000&api_key={5b3a2ea7bf56e004ba7b0c93ce185274a6e9caaa80607ae4585aecf8cf5e8635}";


            var client = new WebClient();
            client.UseDefaultCredentials = true;
            DateTime date = DateTime.Now;

            //Everything is returned inside of a "data" property, so let's select that token.
            string forParsingBTCUSD = client.DownloadString(uriBTCUSD);
            string forParsingBTCEUR = client.DownloadString(uriBTCEUR);

            string forParsingETHUSD = client.DownloadString(uriETHUSD);
            string forParsingETHEUR = client.DownloadString(uriETHEUR);

            string forParsingXRPUSD = client.DownloadString(uriXRPUSD);
            string forParsingXRPEUR = client.DownloadString(uriXRPEUR);

            string forParsingADAUSD = client.DownloadString(uriADAUSD);
            string forParsingADAEUR = client.DownloadString(uriADAEUR);

            string forParsingDOGEUSD = client.DownloadString(uriDOGEUSD);
            string forParsingDOGEEUR = client.DownloadString(uriDOGEEUR);

            string forParsingLTCUSD = client.DownloadString(uriLTCUSD);
            string forParsingLTCEUR = client.DownloadString(uriLTCEUR);

            string forParsingSOLUSD = client.DownloadString(uriSOLUSD);
            string forParsingSOLEUR = client.DownloadString(uriSOLEUR);

            string forParsingTRXUSD = client.DownloadString(uriTRXUSD);
            string forParsingTRXEUR = client.DownloadString(uriTRXEUR);

            string forParsingDOTUSD = client.DownloadString(uriDOTUSD);
            string forParsingDOTEUR = client.DownloadString(uriDOTEUR);

            string forParsingMATICUSD = client.DownloadString(uriMATICUSD);
            string forParsingMATICEUR = client.DownloadString(uriMATICEUR);



            string[] stringListBTCUSD = forParsingBTCUSD.Split("\"},");
            string[] stringListBTCEUR = forParsingBTCEUR.Split("\"},");

            string[] stringListETHUSD = forParsingETHUSD.Split("\"},");
            string[] stringListETHEUR = forParsingETHEUR.Split("\"},");

            string[] stringListXRPUSD = forParsingXRPUSD.Split("\"},");
            string[] stringListXRPEUR = forParsingXRPEUR.Split("\"},");

            string[] stringListADAUSD = forParsingADAUSD.Split("\"},");
            string[] stringListADAEUR = forParsingADAEUR.Split("\"},");

            string[] stringListDOGEUSD = forParsingDOGEUSD.Split("\"},");
            string[] stringListDOGEEUR = forParsingDOGEEUR.Split("\"},");

            string[] stringListLTCUSD = forParsingLTCUSD.Split("\"},");
            string[] stringListLTCEUR = forParsingLTCEUR.Split("\"},");

            string[] stringListSOLUSD = forParsingSOLUSD.Split("\"},");
            string[] stringListSOLEUR = forParsingSOLEUR.Split("\"},");

            string[] stringListTRXUSD = forParsingTRXUSD.Split("\"},");
            string[] stringListTRXEUR = forParsingTRXEUR.Split("\"},");

            string[] stringListDOTUSD = forParsingDOTUSD.Split("\"},");
            string[] stringListDOTEUR = forParsingDOTEUR.Split("\"},");

            string[] stringListMATICUSD = forParsingMATICUSD.Split("\"},");
            string[] stringListMATICEUR = forParsingMATICEUR.Split("\"},");

            //Console.WriteLine(stringList[0]);
            //Console.WriteLine(stringList[1]);
            //Console.WriteLine(stringList.Length);


            //int index = 0;
            //while (index < stringList.Length)
            //{
            //    string toParse = stringList[index];
            //    int beginning = toParse.IndexOf("time");
            //    int end = toParse.IndexOf(",\"high");

            //    string time = toParse.Substring(toParse.IndexOf("time") + 6, toParse.IndexOf(",\"high") - (toParse.IndexOf("time") + 6));
            //    string value = toParse.Substring(toParse.IndexOf("open") + 6, toParse.IndexOf(",\"volumefrom") - (toParse.IndexOf("open") + 6));

            //    Console.WriteLine("Time: " + time + ", value:" + value);
            //    index++;
            //}

            List<DateTime> timeList = new List<DateTime>();
            timeList = extractTimeToVariable(stringListBTCUSD);


            List<float> BTCUSD = sendValuesToVariables(stringListBTCUSD);
            List<float> BTCEUR = sendValuesToVariables(stringListBTCEUR);

            List<float> ETHUSD = sendValuesToVariables(stringListETHUSD);
            List<float> ETHEUR = sendValuesToVariables(stringListETHEUR);

            List<float> XRPUSD = sendValuesToVariables(stringListXRPUSD);
            List<float> XRPEUR = sendValuesToVariables(stringListXRPEUR);

            List<float> ADAUSD = sendValuesToVariables(stringListADAUSD);
            List<float> ADAEUR = sendValuesToVariables(stringListADAEUR);

            List<float> DOGEUSD = sendValuesToVariables(stringListDOGEUSD);
            List<float> DOGEEUR = sendValuesToVariables(stringListDOGEEUR);

            List<float> LTCUSD = sendValuesToVariables(stringListLTCUSD);
            List<float> LTCEUR = sendValuesToVariables(stringListLTCEUR);

            List<float> SOLUSD = sendValuesToVariables(stringListSOLUSD);
            List<float> SOLEUR = sendValuesToVariables(stringListSOLEUR);

            List<float> TRXUSD = sendValuesToVariables(stringListTRXUSD);
            List<float> TRXEUR = sendValuesToVariables(stringListTRXEUR);

            List<float> DOTUSD = sendValuesToVariables(stringListDOTUSD);
            List<float> DOTEUR = sendValuesToVariables(stringListDOTEUR);

            List<float> MATICUSD = sendValuesToVariables(stringListMATICUSD);
            List<float> MATICEUR = sendValuesToVariables(stringListMATICEUR);



            Console.WriteLine("");


            dbCryptoProjectContext context = new dbCryptoProjectContext();


             



            try
            {
                for (int i = 0; i < timeList.Count; i++)
                {

                    CryptoDataModel model = new CryptoDataModel();

                    model.BtcvalueEur = BTCEUR[i];
                    model.BtcvalueUsd = BTCUSD[i];

                    model.EthvalueEur = ETHEUR[i];
                    model.EthvalueUsd = ETHUSD[i];

                    model.XrpvalueEur = XRPEUR[i];
                    model.XrpvalueUsd = XRPUSD[i];

                    model.AdavalueEur = ADAEUR[i];
                    model.AdavalueUsd = ADAUSD[i];

                    model.DogevalueEur = DOGEEUR[i];
                    model.DogevalueUsd = DOGEEUR[i];

                    model.LtcvalueEur = LTCEUR[i];
                    model.LtcvalueUsd = LTCUSD[i];

                    model.SolvalueEur = SOLEUR[i];
                    model.SolvalueUsd = SOLUSD[i];

                    model.TrxvalueEur = TRXEUR[i];
                    model.TrxvalueUsd = TRXUSD[i];

                    model.DotvalueEur = DOTEUR[i];
                    model.DotvalueUsd = DOTUSD[i];

                    model.MaticvalueEur = MATICEUR[i];
                    model.MaticvalueUsd = MATICUSD[i];

                    model.TimeNow = timeList[i];

                    context.CryptoDataModels.Add(model);
                }

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



        }

        private static List<float> sendValuesToVariables(string[] currency)
        {
            List<float> currencyValue = new List<float>();
            int index = 0;
            while (index < currency.Length)
            {
                string toParse = currency[index];
                //string time = toParse.Substring(toParse.IndexOf("time") + 6, toParse.IndexOf(",\"high") - (toParse.IndexOf("time") + 6));
                string value = toParse.Substring(toParse.IndexOf("open") + 6, toParse.IndexOf(",\"volumefrom") - (toParse.IndexOf("open") + 6));

                CultureInfo culture = new CultureInfo("en-US");
                currencyValue.Add(float.Parse(value, culture));
                index++;
            }

            return currencyValue;
        }



        private static List<DateTime> extractTimeToVariable(string[] currency)
        {
            List<DateTime> timeList = new List<DateTime>();
            int index = 0;
            while (index < currency.Length)
            {
                string toParse = currency[index];
                string timeInSeconds = toParse.Substring(toParse.IndexOf("time") + 6, toParse.IndexOf(",\"high") - (toParse.IndexOf("time") + 6));
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(int.Parse(timeInSeconds));
                timeList.Add(dateTimeOffset.DateTime);
                index++;
            }

            return timeList;
        }


    }



    
}