using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using BOMTool.C.Data;
using BOMTool.C.Services;
using BOMTool.M;
using BOMTool.C;


namespace BOMTool.C.Services
{
    public class OracleServices : IOracleServices
    {
        private readonly IConfiguration _configuration;

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

        public string GetPartNumber(int Code)
         {
            var oracleCredentials = new OracleCredential(_configuration.GetValue<string>("OracleUser"), OracleSecurePassword(_configuration.GetValue<string>
                ("OraclePassword")));
            using (var connetion = new OracleConnection(_configuration.GetConnectionString("Oracle"), oracleCredentials))
            {
                connetion.Open();
                using (var command = connetion.CreateCommand())
                {
                    var query = "SELECT b.assembly_item_id, bc.component_item_id, mi.segment1 as Parent_Item, mi.description as Parent_Item_Desc, mi2.segment1 comp_item,";
                    query += "bc.component_quantity, mi2.description as Comp_Desc, Mi.Primary_Unit_Of_Measure, Mi.item_type as Parent_Item_Type, ";
                    query += "tp1.meaning as Item_Type_Desc, Mi2.Primary_Unit_Of_Measure as UOM, Mi2.item_type as item_type2, tp2.meaning as Component_Item_Type ";
                    query += "FROM apps.bom_bill_of_materials b, ";
                    query += "apps.bom_inventory_components bc, ";
                    query += "inv.mtl_system_items_b mi, ";
                    query += "inv.mtl_system_items_b mi2, ";
                    query += "apps.fnd_common_lookups tp1, ";
                    query += "apps.fnd_common_lookups tp2 ";
                    query += "WHERE b.bill_sequence_id = bc.bill_sequence_id and mi.inventory_item_id = b.assembly_item_id ";
                    query += "and mi2.inventory_item_id = bc.component_item_id  and mi.organization_id = b.organization_id ";
                    query += "and mi2.organization_id = b.organization_id and tp1.lookup_type = 'ITEM_TYPE' and tp2.lookup_type = 'ITEM_TYPE' ";
                    query += "and tp1.lookup_code = Mi.item_type and tp2.lookup_code = Mi2.item_type ";
                    query += "and b.organization_id = ";

                    command.CommandText = query;
                    command.Parameters.Add("Code", Code);

                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        

                    }

                }   

            };

            return "Done";
        }

    }
}
