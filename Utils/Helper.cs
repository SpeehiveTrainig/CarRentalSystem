using CarRentalSystem.DTOS;
using CarRentalSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.util
{
    public class Helper
    {
        //public Employe ReadDetails()
        //{
        //    Employe newEmploye=new Employe();
        //    Console.WriteLine("Enter your Name:");
        //    newEmploye.Name = Console.ReadLine();
        //    Console.WriteLine("Enter your ID:");
        //    newEmploye.Id=Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter your Salary:");
        //    newEmploye.Salary = Convert.ToInt32(Console.ReadLine());
        //    newEmploye.ModifiedTime = DateTime.Now;

        //    return newEmploye;

        //}
        public void FileWrite(string name, string email, string msg)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"E:\ALL\Projects\TrainingRepo\CarRentalSystem\StaticFiles/" + name + ".txt", true)) //// true to append data to the file
                {
                    writer.WriteLine("Employe Name:" + name);
                    writer.WriteLine("Employe ID:" + email);
                    writer.WriteLine("Employe ID:" + msg);
                }
               
              
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void SaveCarDetailsToFile(Car newCarObj)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"E:\ALL\Projects\TrainingRepo\CarRentalSystem\StaticFiles/" + newCarObj.Name + ".txt", true)) //// true to append data to the file
                {
                    writer.WriteLine("Car Name:" + newCarObj.Name);
                    writer.WriteLine("Model:" + newCarObj.ModelNo);
                    writer.WriteLine("Rate:" +newCarObj.RatePerHr.ToString() );
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
