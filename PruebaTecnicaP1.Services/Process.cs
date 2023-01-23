using PruebaTecnicaP1.DataAccess.Repository;
using PruebaTecnicaP1.Helpers.LoggerManager;
using PruebaTecnicaP1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaP1.Services
{
    public class Process : IProcess
    {
        private readonly IDataRepository<Covid> _covidRepo;
        private readonly ILog _log;

        public Process(IDataRepository<Covid> covidRepo, ILog log)
        {
            _covidRepo = covidRepo;
            _log = log;
        }

        public async Task GenerateProcess()
        {
            List<Covid> covids = new List<Covid>();

            List<string> includes = new List<string>()
            {
                "Region"
            };

            StringBuilder stringBuilder= new StringBuilder();
            string regionFilter = "all";
            try
            {
                System.Console.WriteLine("Escribe tu parametro");
                string parametro = System.Console.ReadLine()!;
                if (!string.IsNullOrEmpty(parametro))
                {
                    string[] array = parametro.Split('=');

                    #region Validacion de parametro
                    switch (array[0])
                    {
                        case "region":
                            covids = await _covidRepo.ListInclude(includes, x => x.Region.Descripcion == array[1]);
                            regionFilter = array[1];
                            break;

                        case "country":
                            covids = await _covidRepo.ListInclude(includes,x => x.Country == array[1]);
                            break;

                        case "total_cases":
                            bool isNumber = Int64.TryParse(array[1], out long value);
                            if (isNumber)
                            {
                                covids = await _covidRepo.ListInclude(includes, x => x.TotalCases == value);
                            }
                            else
                            {
                                System.Console.WriteLine("Debe ser un numero el valor del parametro");
                                return;
                            }                           
                            break;

                        case "active_cases":
                            bool isNumberActiveCases = Int64.TryParse(array[1], out long valueActiveCases);
                            if (isNumberActiveCases)
                            {
                                covids = await _covidRepo.ListInclude(includes, x => x.TotalCases == valueActiveCases);
                            }
                            else
                            {
                                System.Console.WriteLine("Debe ser un numero el valor del parametro");
                                return;
                            }
                            break;

                        case "total_tests":
                            bool isNumberTotalTests = Int64.TryParse(array[1], out long valueTotalTests);
                            if (isNumberTotalTests)
                            {
                                covids = await _covidRepo.ListInclude(includes, x => x.TotalCases == valueTotalTests);
                            }
                            else
                            {
                                System.Console.WriteLine("Debe ser un numero el valor del parametro");
                                return;
                            }
                            break;

                        default:
                            System.Console.WriteLine("Debe ser un parametro valido ejemplo: region=Europa | country=Colombia | total_cases=1 | active_cases=1 | total_tests=1");
                            return;
                    }
                    #endregion
                }
                else
                {
                    covids = await _covidRepo.ListInclude(includes);
                }

                stringBuilder.AppendLine(Linea());

                stringBuilder.AppendLine(MostrarRow("Region", "Country", "Total Cases", "Active Cases", "Total Tests"));
                stringBuilder.AppendLine(Linea());

                foreach (var item in covids)
                {
                    stringBuilder.AppendLine(MostrarRow(item.Region.Descripcion, item.Country, item.TotalCases.ToString()!, item.ActiveCases.ToString()!, item.TotalTests.ToString()!));
                }

                stringBuilder.AppendLine(Linea());

                DateTime dateTime= DateTime.Now;

                string filePathWithName = string.Concat(AppDomain.CurrentDomain.BaseDirectory, $"export_{regionFilter}_{dateTime.ToString("yy_MM_dd")}.csv");

                if (File.Exists(filePathWithName))
                {
                    File.Delete(filePathWithName);
                }

                File.WriteAllText(filePathWithName, stringBuilder.ToString());

            }
            catch (Exception e)
            {
                _log.LogError(e);
            }
        }

        private static string Linea()
        {
            string linea = new string('-', 81);
            System.Console.WriteLine(linea);
            return linea;
        }

        private string MostrarRow(params string[] columns)
        {
            int width = (80 - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += CentrarTexto(column, width) + "|";
            }

            System.Console.WriteLine(row);

            return row;
        }

        private string CentrarTexto(string text, int width)
        {
            text = text.Length > width ? $"{text.Substring(0, width - 3)}..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
