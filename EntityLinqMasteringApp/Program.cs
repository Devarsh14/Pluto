using System;
using System.Linq;

using EntityLinqMasteringApp.Models;
using EntityLinqMasteringApp.NopCommerceModel;
using EntityLinqMasteringApp.PlutoModel;
using EntityLinqMasteringApp.DevERPModels;
using Microsoft.EntityFrameworkCore;

namespace EntityLinqMasteringApp
{
    class Program
    {
        static void Main(string[] args)
        {

            DevERPContext devERP = new DevERPContext();

            var employeeQuery= devERP.HrmEmployeeM.Join(devERP.HrmEmployeeLogD, hrme => hrme.EmployeeId, hrmlog => hrmlog.EmployeeId, (HrmEmployeeM, HrmEmployeeLogD) => new
            {
                AllowLateArrival= HrmEmployeeLogD.AllowedMaxHoursLateArrival,
                IsLatePolicyApplicable=   HrmEmployeeLogD.IsLatePolicyApplicable
               
    

            }) ;



            foreach ( var item in employeeQuery)
            {
                Console.WriteLine(item.AllowLateArrival);
            }

            Console.ReadLine();
        }
    }
}
