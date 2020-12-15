using System.Security;
using BOMTool.C.Data;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BOMTool.C.Services
{
    public class OracleServices  : IOracleServices
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;

        public OracleServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private SecureString OracleSecurePassword(string password)
        {
            var securePassword = new SecureString();

            foreach (var c in password.ToCharArray())
            {
                securePassword.AppendChar(c);
            }

            securePassword.MakeReadOnly();
            return securePassword;

        }

        public string GetPartNumber(string OrgCode, string partNumber)
         {
            var oracleCredentials = new OracleCredential(_configuration.GetValue<string>("OracleUser"), OracleSecurePassword(_configuration.GetValue<string>
                ("OraclePassword")));

            using (var connetion = new OracleConnection(_configuration.GetConnectionString("Oracle"), oracleCredentials))
            {
                connetion.Open();
                using (var command = connetion.CreateCommand())
                {
                    var query = "SELECT  top_level_item As Model, child_item As PartNum, child_item_description As ItemDescription, child_Item_uom UOM, ROUND(quantity,4) QTY, child_item_type As ItemType, mp.organization_code As OrgCode ";
                    query += " FROM ( SELECT '" + partNumber + "' top_level_item, ";
                    query += " (SELECT msi.segment1 FROM apps.mtl_system_items msi , apps.mtl_parameters mp WHERE msi.inventory_item_id = bom.assembly_item_id AND msi.organization_id  = mp.organization_id AND mp.organization_code = '" + OrgCode + "') ";
                    query += " parent_item , LEVEL,  ";
                    query += " (SELECT msi.segment1 FROM apps.mtl_system_items msi, apps.mtl_parameters mp WHERE msi.inventory_item_id = bic.component_item_id AND msi.organization_id = mp.organization_id AND mp.organization_code = '" + OrgCode + "') ";
                    query += " child_item , ";
                    query += " (SELECT msi.description FROM apps.mtl_system_items msi , apps.mtl_parameters mp WHERE msi.inventory_item_id = bic.component_item_id AND msi.organization_id = mp.organization_id AND mp.organization_code = '" + OrgCode + "')";
                    query += " child_item_description, ";
                    query += " (SELECT msi.primary_uom_code FROM apps.mtl_system_items msi ,apps.mtl_parameters mp WHERE msi.inventory_item_id = bic.component_item_id AND msi.organization_id   = mp.organization_id AND mp.organization_code = '" + OrgCode + "') ";
                    query += " child_item_uom, ";
                    query += " (SELECT msi.item_type FROM apps.mtl_system_items msi , apps.mtl_parameters mp WHERE msi.inventory_item_id = bic.component_item_id AND msi.organization_id  = mp.organization_id AND mp.organization_code ='" + OrgCode + "')";
                    query += " child_item_type , ";
                    query += " bic.component_quantity quantity ";
                    query += " FROM apps.bom_inventory_components bic,";
                    query += " (SELECT bbom.* FROM apps.bom_bill_of_materials bbom , apps.mtl_parameters mp WHERE(bbom.organization_id = mp.organization_id) AND mp.organization_code = '" + OrgCode + "') bom ";
                    query += " WHERE bom.common_bill_sequence_id = bic.bill_sequence_id AND bom.common_bill_sequence_id  = bom.common_bill_sequence_id ";
                    query += " AND bic.bill_sequence_id = bic.bill_sequence_id AND NVL(bic.disable_date , SYSDATE + 1) > SYSDATE START WITH bom.assembly_item_id = ";
                    query += " (SELECT DISTINCT inventory_item_id FROM apps.mtl_system_items WHERE segment1 = '" + partNumber + "')";
                    query += " CONNECT BY NOCYCLE PRIOR bic.component_item_id = bom.assembly_item_id ORDER BY LEVEL, bic.item_num) ";               

                    command.CommandText = query;

                    OracleDataAdapter adapter = new OracleDataAdapter(query, connetion);
                    OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset, "dtPartNumbs");

                    DataTable dataTable = dataset.Tables["dtPartNumbs"];
                }   

            };

            return "Done";
        }

    }
}
