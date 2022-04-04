namespace VibeTest
{
    public static class DatasReutilizaveis
    {
        private static DateTime dataInicial = DateTime.Now;
        private static DateTime dataFinal = DateTime.Now;
        private static readonly DateTime dataAtual = DateTime.Now;
        public static DateTime DataInicial(string opcao)
        {
            
            switch (opcao)
            {
                case "Hoje":
                    return dataAtual;
                    
                case "Ontem":
                    return dataAtual.AddDays(-1);
                   
                case "Esta semana":
                    return DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                   
                case "Este mes":
                    return new DateTime(dataAtual.Year, dataAtual.Month, 1);
                   
                case "30 dias":
                    return  dataAtual.AddDays(-30);
                   
                case "Mes anterior":
                    var month = new DateTime(dataAtual.Year, dataAtual.Month, 1);
                    return month.AddMonths(-1);
                   
                case "3 meses":
                    month = new DateTime(dataAtual.Year, dataAtual.Month, 1);
                    return  month.AddMonths(-3);
                  
                case "6 meses":
                    month = new DateTime(dataAtual.Year, dataAtual.Month, 1);
                    return month.AddMonths(-6);
                  
                case "Este ano":
                    return new DateTime(dataAtual.Year, 1, 1);
                  
                case "Ano passado":
                    return new DateTime(dataAtual.AddYears(-1).Year, 1, 1);                  
            }
            return DateTime.Now;
        }
        public static DateTime DataFinal(string opcao)
        {
            switch (opcao)
            {
                case "Hoje":
                    return dataAtual;

                case "Ontem":
                    return dataAtual;

                case "Esta semana":
                    return dataInicial.AddDays(7);

                case "Este mes":
                    return dataInicial.AddMonths(1).AddDays(-1);

                case "30 dias":
                    return dataAtual;

                case "Mes anterior":
                    var month = new DateTime(dataAtual.Year, dataAtual.Month, 1);
                    return month.AddDays(-1);

                case "3 meses":
                    return dataAtual;

                case "6 meses":
                    return dataAtual;

                case "Este ano":
                    return dataAtual;

                case "Ano passado":
                    return new DateTime(dataAtual.AddYears(-1).Year, 12, 31);
            }
            return DateTime.Now;
        }
    }
}