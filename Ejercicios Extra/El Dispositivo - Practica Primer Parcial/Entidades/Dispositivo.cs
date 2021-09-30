using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            sistemaOperativo = SistemaOperativo.ANDROID;
            appsInstaladas = new List<Aplicacion>();
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if(app is not null && app.SistemaOperativo == sistemaOperativo)
            {
                return appsInstaladas + app;
            }
            return false;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sistema Operativo: " + sistemaOperativo);
            foreach(Aplicacion app in appsInstaladas)
            {
                sb.AppendLine(app.ObtenerInformacionApp());
            }
            return sb.ToString();
        }
    }
}
