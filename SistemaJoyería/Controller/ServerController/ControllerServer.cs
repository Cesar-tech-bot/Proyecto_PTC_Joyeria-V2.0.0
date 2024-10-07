using SistemaJoyería.View.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJoyería.Controller.ServerController
{
    internal class ControllerServer
    {
        ServerConfig ObjServerCon;

        public ControllerServer(ServerConfig View)
        {
            ObjServerCon = View;
            ObjServerCon.btnLogin.Click += (sender, e) => vincular();
        }

        public void vincular() 
        { 
            string server = ObjServerCon.txtServer.Text;
            string database = ObjServerCon.txtDataB.Text;
            string user = ObjServerCon.txtUserS.Text;
            string password = ObjServerCon.txtPasswordS.Text;

            string newConnectionString = $"Data Source={server};Initial Catalog={database};User Id={user};Password={password};";

            UpdateString("conecction", newConnectionString);
        }

        private void UpdateString(string name, string newConnectionString) 
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)configFile.GetSection("connectionStrings");


            connectionStringsSection.ConnectionStrings[name].ConnectionString = newConnectionString;
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            System.Windows.Forms.Application.Exit();
        }
    }
}
