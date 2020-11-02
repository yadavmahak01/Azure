using Microsoft.WindowsAzure.Storage.Table;

namespace EmpDetails
{
    public class EmpDetailsClass : TableEntity
    {
            public EmpDetailsClass()
            {
            }

            public EmpDetailsClass(int empId, string company)
            {
                this.RowKey = empId.ToString();
                this.PartitionKey = company;
            }

            public string EmpName { get; set; }
            public string ContactNo { get; set; }
            public string Email { get; set; }
            public string ProfileImage { get; set; }
        }
    }

